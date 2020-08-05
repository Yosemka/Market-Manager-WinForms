using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagerWF
{
    public partial class Form2 : Form
    {
        public Form2(Form1 form1, string header)
        {
            InitializeComponent();
            this.Text = header + " секции";
            if(header == "Редактирование")
                form2TextBox.Text = Form1.currentSectionName;
        }

        private string newSectionName;
        public string NewSectionName
        {
            get { return newSectionName; }
            set { newSectionName = value; }
        }
        private void form2TextBox_TextChanged(object sender, EventArgs e)
        {
            string str = form2TextBox.Text;

            if (Form1.mainMarket.GetSection(str) != null)
            {
                errorProvider1.SetError(form2TextBox, "Данное наименование уже используется");
                addBT.Enabled = false;
            }
            else if(str.Trim() == string.Empty)
            {
                errorProvider1.SetError(form2TextBox, "Поле не может быть пустым");
                addBT.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                addBT.Enabled = true;
                NewSectionName = str;
            }
        }
       
        private void addBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelBT_Click(object sender, EventArgs e)
        {
            NewSectionName = string.Empty;
            this.Hide();
        }

        private void form2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBT.PerformClick();
            }
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
                SectionGoods tmpSection = new SectionGoods();
                if (tmpSection.Deserialize(openFileDialog.FileName))
                {
                    openResultLabel.ForeColor = Color.Green;
                    openResultLabel.Text = "Выгрузка секции \"" + tmpSection.Name + "\" прошла успешно";
                    NewSectionName = tmpSection.Name;
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
