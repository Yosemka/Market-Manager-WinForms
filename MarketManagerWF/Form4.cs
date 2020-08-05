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
    public partial class Form4 : Form
    {
        public Form4(Form1 form1)
        {
            InitializeComponent();

            if (Form1.mainMarket != null)
            {
                nameTextBox.Text = Form1.mainMarket.Name;
                amountTextBox.Text = Form1.mainMarket.QueueSize.ToString();
            }
        }
        private Supermarket market;
        public Supermarket Market
        {
            get { return market; }
            set { market = value; }
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            if (market == null)
            {
                market = new Supermarket();
                market.Name = nameTextBox.Text;
                if (amountTextBox.Text != string.Empty)
                    market.QueueSize = Convert.ToInt32(amountTextBox.Text);
                else
                    market.QueueSize = 0;
            }            
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            string str = nameTextBox.Text;
           if (nameTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(label1, "Поле не может быть пустым");
                addBT.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                addBT.Enabled = true;
            }
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
                market = new Supermarket();
                if(market.Deserialize(openFileDialog.FileName))
                {
                    openResultLabel.ForeColor = Color.Green;
                    openResultLabel.Text = "Выгрузка супермаркета \"" + market.Name + "\" прошла успешно";
                    addBT.Enabled = true;
                }
                else 
                {
                    openResultLabel.ForeColor = Color.Red;
                    openResultLabel.Text = "Выгрузка прошла неуспешно";
                }
            }
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addBT.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                cancelBT.PerformClick();
        }
    }
}
