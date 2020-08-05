using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MarketManagerWF
{
    public partial class Form1 : Form
    {
        public static string supermarketXmlPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\xml\";
        public static Supermarket mainMarket;
        public static SectionGoods mainSection;
        public static Goods mainGood;
        public static string currentSectionName;        //для передачи в другие формы при редактировании секции
        public static string currentGoodName;           //для передачи в другие формы при редактировании товара
        private DataTable goodsDT = new DataTable();
        private DataTable sectionsDT = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
            
            goodsGridView.DataSource = goodsDT;
            sectionsGridView.DataSource = sectionsDT;

            sectionsDT.Columns.Add(new DataColumn("Название", typeof(string)));
            sectionsDT.Columns.Add(new DataColumn("Кол-во тов.", typeof(int)));
            sectionsDT.Columns.Add(new DataColumn("Общая сумма", typeof(double)));

            goodsDT.Columns.Add(new DataColumn("Наименование", typeof(string)));
            goodsDT.Columns.Add(new DataColumn("Стоимость", typeof(double)));
            goodsDT.Columns.Add(new DataColumn("Секция", typeof(string)));
        }

        private void FillGoodsTable()
        {
            if (goodsGridView.Rows.Count > 0)
                goodsDT.Rows.Clear();

            if (mainMarket != null && mainMarket.AllExistSections != null)
            {   //супермаркет имеет секции
                SectionGoods section;
                foreach (DataGridViewRow row in sectionsGridView.SelectedRows)
                {
                    section = mainMarket.GetSection(sectionsGridView[0, row.Index].Value.ToString());
                    if(!section.IsEmpty)
                    {   //если секция не пустая, те содержит товары
                        foreach (Goods good in section.GetAllElements())
                        {   //добавить их в таблицу
                            goodsDT.Rows.Add(good.Name, good.Price, sectionsGridView[0, row.Index].Value.ToString());
                        }
                    }
                }
                
            }
            else
            {
                addGoodBT.Enabled = false;
                deleteGoodBT.Enabled = false;
                editGoodBT.Enabled = false;
                saveGoodBT.Enabled = false;
            }
        }
        private void FillSectionsTable()
        {
            if (sectionsGridView.Rows.Count > 0)
                sectionsDT.Rows.Clear();
            
            if (mainMarket != null)
            {   //супермаркет создан
                
                addSectionBT.Enabled = true;

                if (mainMarket.AllExistSections != null)
                {
                    deleteSectionBT.Enabled = true;
                    foreach (SectionGoods section in mainMarket.AllExistSections)
                    {
                        sectionsDT.Rows.Add(section.Name, section.Count, section.GetTotalSectionPrice());
                    }
                    sectionsGridView.Refresh();
                }
                else
                {
                    deleteSectionBT.Enabled = false;
                    editSectionBT.Enabled = false;
                    saveSectionBT.Enabled = false;
                }
            } 
            else
            {
                addSectionBT.Enabled = false;
                deleteSectionBT.Enabled = false; 
                editSectionBT.Enabled = false;
                saveSectionBT.Enabled = false;
            }
            
            //sectionsGridView.ClearSelection();
        }
        
        
        /****************************
         ******** СОЗДАНИЕ  *********        
         ****************************/
        private void createMarketBT_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();

            if (mainMarket == null)
            {   //Если супермаркет еще не создан                
                Form4 form4 = new Form4(this);
                dr = form4.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    mainMarket = new Supermarket();
                    mainMarket = form4.Market;                    
                    
                    marketNameLabel.Text = mainMarket.Name;                    
                    sectionsAmountLabel.Text = mainMarket.QueueSize.ToString();
                    
                    marketNameLabel.ForeColor = Color.White;
                    sectionsAmountLabel.ForeColor = Color.White;
                    
                    //Активация кнопок
                    addSectionBT.Enabled = true;
                    deleteMarketBT.Enabled = true;
                    editMarketBT.Enabled = true;
                    saveMarketBT.Enabled = true;
                    
                    //Заполнение таблиц
                    FillSectionsTable();
                    FillGoodsTable();
                }
            }
            else  //Если создан
            {   //предложить сохранить текущий супермаркет
                dr = MessageBox.Show(
                    "Сохранить текущие данные о супермаркете \"" + mainMarket.Name + "\"?\nПри создании нового все данные будут потеряны.",
                    "Создать новый файл?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    saveMarketBT.PerformClick();
                }
                else if(dr == DialogResult.No)
                {
                    //Удаление
                    mainMarket.Clear();
                    mainMarket = null;
                    marketNameLabel.Text = "Название супермаркета";
                    marketNameLabel.ForeColor = Color.Silver;
                    sectionsAmountLabel.Text = "Количество секций";
                    sectionsAmountLabel.ForeColor = Color.Silver;

                    //Деактивация кнопок
                    addSectionBT.Enabled = false;
                    deleteMarketBT.Enabled = false;
                    editMarketBT.Enabled = false;
                    saveMarketBT.Enabled = false;
                    FillSectionsTable();
                    FillGoodsTable();

                    createMarketBT.PerformClick();
                }
            }

        }
        private void addSectionBT_Click_1(object sender, EventArgs e)
        {
            if(mainMarket != null)
            {
                DialogResult dr = new DialogResult();
                Form2 form2 = new Form2(this, "Добавление");
                dr = form2.ShowDialog();

                if (dr == DialogResult.OK)
                {   //Если была нажата кнопка "Добавить"
                    if (mainMarket.AddNewSection(form2.NewSectionName) >= 0)
                    {
                        FillSectionsTable();
                        sectionsGridView.ClearSelection();
                        sectionsGridView.Rows[sectionsGridView.Rows.Count - 1].Selected = true;
                    }
                }
            }            
        }
        private void addGoodBT_Click_1(object sender, EventArgs e)
        {
            int index = sectionsGridView.SelectedRows[0].Index;
            currentSectionName = sectionsGridView[0, index].Value.ToString();
            
            DialogResult dr = new DialogResult();
            Form3 form3 = new Form3(this, "Добавление");
            dr = form3.ShowDialog();

            if (dr == DialogResult.OK)
            {   //Если была нажата кнопка "Добавить"
                if (mainMarket.GetSection(currentSectionName).AddGoodToList(form3.Good.Name) > 0)
                {
                    mainMarket.GetSection(currentSectionName).GetElementByName(form3.Good.Name).Price = form3.Good.Price;
                    FillSectionsTable();
                    sectionsGridView.ClearSelection();
                    sectionsGridView.Rows[index].Selected = true;
                    FillGoodsTable();
                }
            }            
        }


        /****************************
         ******** УДАЛЕНИЕ  *********        
         ****************************/
        private void deleteMarketBT_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(
                "Сохранить супермаркет \"" + mainMarket.Name + "\" перед удалением?",
                "Удаление",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Cancel)
            {
                return;                
            }
            else if (dr == DialogResult.Yes)
            {
                saveMarketBT.PerformClick();
            }
            //Удаление
            mainMarket.Clear();
            mainMarket = null;
            marketNameLabel.Text = "Название супермаркета";
            marketNameLabel.ForeColor = Color.Silver;
            sectionsAmountLabel.Text = "Количество секций";
            sectionsAmountLabel.ForeColor = Color.Silver;
            
            //Деактивация кнопок
            addSectionBT.Enabled = false;
            deleteMarketBT.Enabled = false;
            editMarketBT.Enabled = false;
            saveMarketBT.Enabled = false;
            FillSectionsTable();
            FillGoodsTable();
        }
        private void deleteSectionBT_Click(object sender, EventArgs e)
        {
            mainMarket.DeleteSectionAndGoods();
            FillSectionsTable();
            FillGoodsTable();
        }
        private void deleteGoodBT_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in goodsGridView.SelectedRows)
            {
                mainMarket.GetSection(goodsGridView[2, row.Index].Value.ToString()).DeleteGoodFromList(goodsGridView[0, row.Index].Value.ToString());
            }
            FillSectionsTable();
            FillGoodsTable();
        }

        
        /****************************
         ******** ИЗМЕНЕНИЕ *********        
         ****************************/
        private void editMarketBT_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Form4 form4 = new Form4(this);
            dr = form4.ShowDialog();

            if (dr == DialogResult.OK)
            {
                mainMarket.Name = form4.Market.Name;
                mainMarket.QueueSize = form4.Market.QueueSize;

                marketNameLabel.Text = mainMarket.Name;
                sectionsAmountLabel.Text = mainMarket.QueueSize.ToString();
            }
        }        
        private void editSectionBT_Click(object sender, EventArgs e)
        {
            currentSectionName = sectionsGridView[0, sectionsGridView.SelectedCells[0].RowIndex].Value.ToString();
            DialogResult dr = new DialogResult();
            Form2 form2 = new Form2(this, "Редактирование");
            dr = form2.ShowDialog();

            if (dr == DialogResult.OK)
            {   //Если была нажата кнопка "ОК"
                mainMarket.GetSection(currentSectionName).Name = form2.NewSectionName;
                FillSectionsTable();
                sectionsGridView.ClearSelection();
                sectionsGridView[0, sectionsGridView.Rows.Count - 1].Selected = true;
            }
        }
        private void editGoodBT_Click(object sender, EventArgs e)
        {
            currentSectionName = sectionsGridView[0, sectionsGridView.SelectedCells[0].RowIndex].Value.ToString();
            currentGoodName = goodsGridView[0, goodsGridView.SelectedCells[0].RowIndex].Value.ToString();
            int index = sectionsGridView.SelectedCells[0].RowIndex;
            
            DialogResult dr = new DialogResult();
            Form3 form3 = new Form3(this, "Редактирование");
            dr = form3.ShowDialog();

            if (dr == DialogResult.OK)
            {   //Если была нажата кнопка "Редактирование"
                mainMarket.GetSection(currentSectionName).GetElementByName(currentGoodName).Name = form3.Good.Name;
                mainMarket.GetSection(currentSectionName).GetElementByName(form3.Good.Name).Price = form3.Good.Price;
                FillSectionsTable();
                FillGoodsTable();
            }
        }
        

        /****************************
         ******** СОХРАНЕНИЕ ********        
         ****************************/
        private void saveMarketBT_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            
            if (!Directory.Exists(supermarketXmlPath))
                //если папка XML не сущестует, то создать ее
                Directory.CreateDirectory(supermarketXmlPath);

            saveFileDialog.InitialDirectory = supermarketXmlPath;
            saveFileDialog.FileName = mainMarket.Name;// + ".xml";
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.Filter = "Файлы XML (*.xml)|*.xml";
            dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {   //Serialize возвращает путь
                if(mainMarket.Serialize(saveFileDialog.FileName) != string.Empty)
                {

                }
            }
        }
        private void saveSectionBT_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            currentSectionName = sectionsGridView[0, sectionsGridView.SelectedRows[0].Index].Value.ToString();

            if (!Directory.Exists(supermarketXmlPath))
                //если папка XML не сущестует, то создать ее
                Directory.CreateDirectory(supermarketXmlPath);

            saveFileDialog.InitialDirectory = supermarketXmlPath;
            saveFileDialog.FileName = currentSectionName;
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.Filter = "Файлы XML (*.xml)|*.xml";
            dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {   //Serialize возвращает путь
                if(mainMarket.GetSection(currentSectionName).Serialize(saveFileDialog.FileName) != string.Empty)
                {

                }
            }
        }
        private void saveGoodBT_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            currentSectionName = sectionsGridView[0, sectionsGridView.SelectedRows[0].Index].Value.ToString();
            string goodName = goodsGridView[0, goodsGridView.SelectedCells[0].RowIndex].Value.ToString();
            //int index = sectionsGridView.SelectedCells[0].RowIndex;

            if (!Directory.Exists(supermarketXmlPath))
                //если папка XML не сущестует, то создать ее
                Directory.CreateDirectory(supermarketXmlPath);

            saveFileDialog.InitialDirectory = supermarketXmlPath;
            saveFileDialog.FileName = goodName;
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.Filter = "Файлы XML (*.xml)|*.xml";
            dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {   //Serialize возвращает путь
                if (mainMarket.GetSection(currentSectionName).GetElementByName(goodName).Serialize(saveFileDialog.FileName) != string.Empty)
                {

                }
            }
        }

       
        /**************************** ВЫДЕЛЕНИЕ СТРОК ****************************/
        private void sectionsGridView_SelectionChanged(object sender, EventArgs e)
        {
            FillGoodsTable();

            //Активация кнопок Сохранить и Изменить
            if (sectionsGridView.SelectedRows.Count == 1)
            {
                saveSectionBT.Enabled = true;
                editSectionBT.Enabled = true;
                addGoodBT.Enabled = true;
            }
            else
            {
                saveGoodBT.Enabled = false;
                editGoodBT.Enabled = false;
                addGoodBT.Enabled = false;
            }
        }

        private void goodsGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Активация кнопок
            if (goodsGridView.SelectedRows.Count == 1)
            {
                saveGoodBT.Enabled = true;
                deleteGoodBT.Enabled = true;        //активировать кнопку удалить
                editGoodBT.Enabled = true;
            }
            else
            if (goodsGridView.SelectedRows.Count > 0)
            {   //если выделено больше 1 товара, то
                saveGoodBT.Enabled = true;        //активировать кнопку удалить
                saveSectionBT.Enabled = false;      //деактивировать "Сохранить"
                editGoodBT.Enabled = false;
            }
            else
            {
                saveGoodBT.Enabled = false;
                deleteGoodBT.Enabled = false;        //активировать кнопку удалить
                editGoodBT.Enabled = false;
            }
        }
    }
}

