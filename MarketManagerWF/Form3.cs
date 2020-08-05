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

namespace MarketManagerWF
{
    public partial class Form3 : Form
    {
        public Form3(Form1 form1, string header)
        {
            InitializeComponent();
            this.Text = header + " товара";
            if (header == "Редактирование")
                nameTextBox.Text = Form1.mainMarket.GetSection(Form1.currentSectionName).GetElementByName(Form1.currentGoodName).Name;
        }

        private Goods good;
        public Goods Good
        {
            get { return good; }
            set { good = value; }
        }

        private double newGoodPrice;
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {            
            if (Form1.mainMarket.GetSection(Form1.currentSectionName).GetElementByName(nameTextBox.Text) != null)
            {   //если имя уже есть
                errorProvider1.SetError(label1, "Данное наименование уже используется");
                addBT.Enabled = false;
            }
            else if (nameTextBox.Text == "")
            {   //если поле пустое
                errorProvider1.SetError(label1, "Поле не может быть пустым");
                addBT.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                addBT.Enabled = true;
            }
        }
        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            double tmp;
            if (!double.TryParse(priceTextBox.Text, out tmp))
                errorProvider1.SetError(label2, "Неверное значение цены");
            else
            {   //ошибок в парсинге нет
                if(tmp < 0)
                    errorProvider1.SetError(label2, "Цена должна быть больше нуля");
                else
                {   //ошибок в цене нет
                    errorProvider1.Clear();
                    newGoodPrice = tmp;
                }
            }                
        }
        private void addBT_Click(object sender, EventArgs e)
        {
            if (good == null)
            {
                good = new Goods();
                good.Name = nameTextBox.Text;
                good.Price = newGoodPrice;
            }

            this.Hide();
        }

        private void cancelBT_Click(object sender, EventArgs e)
        {
            Good = null;
            this.Hide();
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addBT.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                cancelBT.PerformClick();
        }

        private void openBT_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            if (!Directory.Exists(Form1.supermarketXmlPath))
                //если папка XML не сущестует, то создать ее
                Directory.CreateDirectory(Form1.supermarketXmlPath);

            openFileDialog.InitialDirectory = Form1.supermarketXmlPath;
            openFileDialog.Filter = "Файлы XML (*.xml)|*.xml";
            dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                openTextBox.Text = openFileDialog.FileName;
                good = new Goods();
                if (good.Deserialize(openFileDialog.FileName))
                {
                    openResultLabel.ForeColor = Color.Green;
                    openResultLabel.Text = "Выгрузка товара \"" + good.Name + "\" прошла успешно";
                    addBT.Enabled = true;
                }
                else
                {
                    openResultLabel.ForeColor = Color.Red;
                    openResultLabel.Text = "Выгрузка прошла неуспешно";
                }
            }
        }
    }
}
