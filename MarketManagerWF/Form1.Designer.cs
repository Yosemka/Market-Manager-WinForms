namespace MarketManagerWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.saveMarketBT = new System.Windows.Forms.Button();
            this.createMarketBT = new System.Windows.Forms.Button();
            this.deleteMarketBT = new System.Windows.Forms.Button();
            this.editMarketBT = new System.Windows.Forms.Button();
            this.marketNameLabel = new System.Windows.Forms.Label();
            this.sectionsAmountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sectionsGridView = new System.Windows.Forms.DataGridView();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.addSectionBT = new System.Windows.Forms.Button();
            this.saveSectionBT = new System.Windows.Forms.Button();
            this.editSectionBT = new System.Windows.Forms.Button();
            this.deleteSectionBT = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.addGoodBT = new System.Windows.Forms.Button();
            this.deleteGoodBT = new System.Windows.Forms.Button();
            this.editGoodBT = new System.Windows.Forms.Button();
            this.saveGoodBT = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridView)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Controls.Add(this.tableLayoutPanel3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(958, 471);
            this.mainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56051F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.43949F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(958, 471);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.19395F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.80605F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 535F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.marketNameLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.sectionsAmountLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(952, 72);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.saveMarketBT, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.createMarketBT, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.deleteMarketBT, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.editMarketBT, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(419, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(530, 66);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // saveMarketBT
            // 
            this.saveMarketBT.BackColor = System.Drawing.Color.Plum;
            this.saveMarketBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveMarketBT.Enabled = false;
            this.saveMarketBT.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.saveMarketBT.FlatAppearance.BorderSize = 0;
            this.saveMarketBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.saveMarketBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.saveMarketBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.saveMarketBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveMarketBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveMarketBT.Location = new System.Drawing.Point(402, 15);
            this.saveMarketBT.Margin = new System.Windows.Forms.Padding(6, 15, 6, 15);
            this.saveMarketBT.Name = "saveMarketBT";
            this.saveMarketBT.Size = new System.Drawing.Size(122, 36);
            this.saveMarketBT.TabIndex = 5;
            this.saveMarketBT.Text = "Сохранить";
            this.saveMarketBT.UseVisualStyleBackColor = false;
            this.saveMarketBT.Click += new System.EventHandler(this.saveMarketBT_Click);
            // 
            // createMarketBT
            // 
            this.createMarketBT.BackColor = System.Drawing.Color.LimeGreen;
            this.createMarketBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createMarketBT.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.createMarketBT.FlatAppearance.BorderSize = 0;
            this.createMarketBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.createMarketBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.createMarketBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.createMarketBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.createMarketBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createMarketBT.Location = new System.Drawing.Point(6, 15);
            this.createMarketBT.Margin = new System.Windows.Forms.Padding(6, 15, 6, 15);
            this.createMarketBT.Name = "createMarketBT";
            this.createMarketBT.Size = new System.Drawing.Size(120, 36);
            this.createMarketBT.TabIndex = 3;
            this.createMarketBT.Text = "Создать";
            this.createMarketBT.UseVisualStyleBackColor = false;
            this.createMarketBT.Click += new System.EventHandler(this.createMarketBT_Click);
            // 
            // deleteMarketBT
            // 
            this.deleteMarketBT.BackColor = System.Drawing.Color.Salmon;
            this.deleteMarketBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteMarketBT.Enabled = false;
            this.deleteMarketBT.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.deleteMarketBT.FlatAppearance.BorderSize = 0;
            this.deleteMarketBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick;
            this.deleteMarketBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.deleteMarketBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteMarketBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteMarketBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteMarketBT.Location = new System.Drawing.Point(138, 15);
            this.deleteMarketBT.Margin = new System.Windows.Forms.Padding(6, 15, 6, 15);
            this.deleteMarketBT.Name = "deleteMarketBT";
            this.deleteMarketBT.Size = new System.Drawing.Size(120, 36);
            this.deleteMarketBT.TabIndex = 2;
            this.deleteMarketBT.Text = "Удалить";
            this.deleteMarketBT.UseVisualStyleBackColor = false;
            this.deleteMarketBT.Click += new System.EventHandler(this.deleteMarketBT_Click);
            // 
            // editMarketBT
            // 
            this.editMarketBT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editMarketBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editMarketBT.Enabled = false;
            this.editMarketBT.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.editMarketBT.FlatAppearance.BorderSize = 0;
            this.editMarketBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.editMarketBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.editMarketBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.editMarketBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editMarketBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editMarketBT.Location = new System.Drawing.Point(270, 15);
            this.editMarketBT.Margin = new System.Windows.Forms.Padding(6, 15, 6, 15);
            this.editMarketBT.Name = "editMarketBT";
            this.editMarketBT.Size = new System.Drawing.Size(120, 36);
            this.editMarketBT.TabIndex = 4;
            this.editMarketBT.Text = "Изменить";
            this.editMarketBT.UseVisualStyleBackColor = false;
            this.editMarketBT.Click += new System.EventHandler(this.editMarketBT_Click);
            // 
            // marketNameLabel
            // 
            this.marketNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.marketNameLabel.AutoSize = true;
            this.marketNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marketNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.marketNameLabel.Location = new System.Drawing.Point(113, 44);
            this.marketNameLabel.Name = "marketNameLabel";
            this.marketNameLabel.Size = new System.Drawing.Size(20, 24);
            this.marketNameLabel.TabIndex = 6;
            this.marketNameLabel.Text = "_";
            // 
            // sectionsAmountLabel
            // 
            this.sectionsAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sectionsAmountLabel.AutoSize = true;
            this.sectionsAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sectionsAmountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sectionsAmountLabel.Location = new System.Drawing.Point(318, 44);
            this.sectionsAmountLabel.Name = "sectionsAmountLabel";
            this.sectionsAmountLabel.Size = new System.Drawing.Size(25, 24);
            this.sectionsAmountLabel.TabIndex = 7;
            this.sectionsAmountLabel.Text = " _";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(77, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(266, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кол-во секций";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel1.Controls.Add(this.sectionsGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sectionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.goodsGridView, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.808564F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.19144F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 387);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sectionsGridView
            // 
            this.sectionsGridView.AllowUserToAddRows = false;
            this.sectionsGridView.AllowUserToResizeRows = false;
            this.sectionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sectionsGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.sectionsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sectionsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sectionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sectionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionsGridView.EnableHeadersVisualStyles = false;
            this.sectionsGridView.GridColor = System.Drawing.Color.Gray;
            this.sectionsGridView.Location = new System.Drawing.Point(3, 33);
            this.sectionsGridView.Name = "sectionsGridView";
            this.sectionsGridView.ReadOnly = true;
            this.sectionsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sectionsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sectionsGridView.RowHeadersVisible = false;
            this.sectionsGridView.RowHeadersWidth = 40;
            this.sectionsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.sectionsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.sectionsGridView.RowTemplate.Height = 20;
            this.sectionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sectionsGridView.Size = new System.Drawing.Size(273, 351);
            this.sectionsGridView.TabIndex = 5;
            this.sectionsGridView.SelectionChanged += new System.EventHandler(this.sectionsGridView_SelectionChanged);
            // 
            // sectionLabel
            // 
            this.sectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sectionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sectionLabel.Location = new System.Drawing.Point(101, 3);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(76, 24);
            this.sectionLabel.TabIndex = 2;
            this.sectionLabel.Text = "Секции";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(575, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Товары";
            // 
            // goodsGridView
            // 
            this.goodsGridView.AllowUserToAddRows = false;
            this.goodsGridView.AllowUserToResizeRows = false;
            this.goodsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.goodsGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.goodsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goodsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.goodsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.goodsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodsGridView.EnableHeadersVisualStyles = false;
            this.goodsGridView.GridColor = System.Drawing.Color.Gray;
            this.goodsGridView.Location = new System.Drawing.Point(394, 33);
            this.goodsGridView.Name = "goodsGridView";
            this.goodsGridView.ReadOnly = true;
            this.goodsGridView.RowHeadersVisible = false;
            this.goodsGridView.RowHeadersWidth = 40;
            this.goodsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.goodsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.goodsGridView.RowTemplate.Height = 20;
            this.goodsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodsGridView.Size = new System.Drawing.Size(441, 351);
            this.goodsGridView.TabIndex = 1;
            this.goodsGridView.SelectionChanged += new System.EventHandler(this.goodsGridView_SelectionChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.addSectionBT, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.saveSectionBT, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.editSectionBT, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.deleteSectionBT, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(279, 30);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(112, 357);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // addSectionBT
            // 
            this.addSectionBT.BackColor = System.Drawing.Color.LimeGreen;
            this.addSectionBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSectionBT.Enabled = false;
            this.addSectionBT.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.addSectionBT.FlatAppearance.BorderSize = 0;
            this.addSectionBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.addSectionBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.addSectionBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addSectionBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addSectionBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addSectionBT.Location = new System.Drawing.Point(3, 3);
            this.addSectionBT.Name = "addSectionBT";
            this.addSectionBT.Size = new System.Drawing.Size(106, 44);
            this.addSectionBT.TabIndex = 3;
            this.addSectionBT.Text = "Добавить";
            this.addSectionBT.UseVisualStyleBackColor = false;
            this.addSectionBT.Click += new System.EventHandler(this.addSectionBT_Click_1);
            // 
            // saveSectionBT
            // 
            this.saveSectionBT.BackColor = System.Drawing.Color.Plum;
            this.saveSectionBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveSectionBT.Enabled = false;
            this.saveSectionBT.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.saveSectionBT.FlatAppearance.BorderSize = 0;
            this.saveSectionBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.saveSectionBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.saveSectionBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.saveSectionBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveSectionBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveSectionBT.Location = new System.Drawing.Point(3, 303);
            this.saveSectionBT.Name = "saveSectionBT";
            this.saveSectionBT.Size = new System.Drawing.Size(106, 51);
            this.saveSectionBT.TabIndex = 6;
            this.saveSectionBT.Text = "Сохранить";
            this.saveSectionBT.UseVisualStyleBackColor = false;
            this.saveSectionBT.Click += new System.EventHandler(this.saveSectionBT_Click);
            // 
            // editSectionBT
            // 
            this.editSectionBT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editSectionBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editSectionBT.Enabled = false;
            this.editSectionBT.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.editSectionBT.FlatAppearance.BorderSize = 0;
            this.editSectionBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.editSectionBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.editSectionBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.editSectionBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editSectionBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editSectionBT.Location = new System.Drawing.Point(3, 203);
            this.editSectionBT.Name = "editSectionBT";
            this.editSectionBT.Size = new System.Drawing.Size(106, 44);
            this.editSectionBT.TabIndex = 4;
            this.editSectionBT.Text = "Изменить";
            this.editSectionBT.UseVisualStyleBackColor = false;
            this.editSectionBT.Click += new System.EventHandler(this.editSectionBT_Click);
            // 
            // deleteSectionBT
            // 
            this.deleteSectionBT.BackColor = System.Drawing.Color.Salmon;
            this.deleteSectionBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteSectionBT.Enabled = false;
            this.deleteSectionBT.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.deleteSectionBT.FlatAppearance.BorderSize = 0;
            this.deleteSectionBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick;
            this.deleteSectionBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.deleteSectionBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteSectionBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteSectionBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteSectionBT.Location = new System.Drawing.Point(3, 103);
            this.deleteSectionBT.Name = "deleteSectionBT";
            this.deleteSectionBT.Size = new System.Drawing.Size(106, 44);
            this.deleteSectionBT.TabIndex = 2;
            this.deleteSectionBT.Text = "Удалить";
            this.deleteSectionBT.UseVisualStyleBackColor = false;
            this.deleteSectionBT.Click += new System.EventHandler(this.deleteSectionBT_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.addGoodBT, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.deleteGoodBT, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.editGoodBT, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.saveGoodBT, 0, 6);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(838, 30);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 7;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(114, 357);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // addGoodBT
            // 
            this.addGoodBT.BackColor = System.Drawing.Color.LimeGreen;
            this.addGoodBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addGoodBT.Enabled = false;
            this.addGoodBT.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.addGoodBT.FlatAppearance.BorderSize = 0;
            this.addGoodBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.addGoodBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.addGoodBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addGoodBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addGoodBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addGoodBT.Location = new System.Drawing.Point(3, 3);
            this.addGoodBT.Name = "addGoodBT";
            this.addGoodBT.Size = new System.Drawing.Size(108, 44);
            this.addGoodBT.TabIndex = 5;
            this.addGoodBT.Text = "Добавить";
            this.addGoodBT.UseVisualStyleBackColor = false;
            this.addGoodBT.Click += new System.EventHandler(this.addGoodBT_Click_1);
            // 
            // deleteGoodBT
            // 
            this.deleteGoodBT.BackColor = System.Drawing.Color.Salmon;
            this.deleteGoodBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteGoodBT.Enabled = false;
            this.deleteGoodBT.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.deleteGoodBT.FlatAppearance.BorderSize = 0;
            this.deleteGoodBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick;
            this.deleteGoodBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.deleteGoodBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteGoodBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteGoodBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteGoodBT.Location = new System.Drawing.Point(3, 103);
            this.deleteGoodBT.Name = "deleteGoodBT";
            this.deleteGoodBT.Size = new System.Drawing.Size(108, 44);
            this.deleteGoodBT.TabIndex = 4;
            this.deleteGoodBT.Text = "Удалить";
            this.deleteGoodBT.UseVisualStyleBackColor = false;
            this.deleteGoodBT.Click += new System.EventHandler(this.deleteGoodBT_Click);
            // 
            // editGoodBT
            // 
            this.editGoodBT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editGoodBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGoodBT.Enabled = false;
            this.editGoodBT.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.editGoodBT.FlatAppearance.BorderSize = 0;
            this.editGoodBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.editGoodBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.editGoodBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.editGoodBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editGoodBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editGoodBT.Location = new System.Drawing.Point(3, 203);
            this.editGoodBT.Name = "editGoodBT";
            this.editGoodBT.Size = new System.Drawing.Size(108, 44);
            this.editGoodBT.TabIndex = 6;
            this.editGoodBT.Text = "Изменить";
            this.editGoodBT.UseVisualStyleBackColor = false;
            this.editGoodBT.Click += new System.EventHandler(this.editGoodBT_Click);
            // 
            // saveGoodBT
            // 
            this.saveGoodBT.BackColor = System.Drawing.Color.Plum;
            this.saveGoodBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveGoodBT.Enabled = false;
            this.saveGoodBT.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.saveGoodBT.FlatAppearance.BorderSize = 0;
            this.saveGoodBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.saveGoodBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.saveGoodBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.saveGoodBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveGoodBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveGoodBT.Location = new System.Drawing.Point(3, 303);
            this.saveGoodBT.Name = "saveGoodBT";
            this.saveGoodBT.Size = new System.Drawing.Size(108, 51);
            this.saveGoodBT.TabIndex = 7;
            this.saveGoodBT.Text = "Сохранить";
            this.saveGoodBT.UseVisualStyleBackColor = false;
            this.saveGoodBT.Click += new System.EventHandler(this.saveGoodBT_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(958, 471);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Менеджер маркета";
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridView)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView goodsGridView;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteSectionBT;
        private System.Windows.Forms.DataGridView sectionsGridView;
        private System.Windows.Forms.Button addSectionBT;
        private System.Windows.Forms.Button deleteGoodBT;
        private System.Windows.Forms.Button addGoodBT;
        private System.Windows.Forms.Button editGoodBT;
        private System.Windows.Forms.Button editSectionBT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button createMarketBT;
        private System.Windows.Forms.Button deleteMarketBT;
        private System.Windows.Forms.Button editMarketBT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label marketNameLabel;
        private System.Windows.Forms.Label sectionsAmountLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button saveMarketBT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button saveSectionBT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button saveGoodBT;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

