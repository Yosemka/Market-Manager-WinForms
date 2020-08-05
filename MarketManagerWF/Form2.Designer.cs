namespace MarketManagerWF
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.form2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.addBT = new System.Windows.Forms.Button();
            this.cancelBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.openResultLabel = new System.Windows.Forms.Label();
            this.openBT = new System.Windows.Forms.Button();
            this.openTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // form2TextBox
            // 
            this.form2TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form2TextBox.Location = new System.Drawing.Point(3, 54);
            this.form2TextBox.Name = "form2TextBox";
            this.form2TextBox.Size = new System.Drawing.Size(397, 27);
            this.form2TextBox.TabIndex = 0;
            this.form2TextBox.TextChanged += new System.EventHandler(this.form2TextBox_TextChanged);
            this.form2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form2TextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название новой секции";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // addBT
            // 
            this.addBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBT.BackColor = System.Drawing.Color.LimeGreen;
            this.addBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBT.Enabled = false;
            this.addBT.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.addBT.FlatAppearance.BorderSize = 0;
            this.addBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.addBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.addBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBT.Location = new System.Drawing.Point(92, 5);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(106, 23);
            this.addBT.TabIndex = 2;
            this.addBT.Text = "ОК";
            this.addBT.UseVisualStyleBackColor = false;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // cancelBT
            // 
            this.cancelBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBT.BackColor = System.Drawing.Color.Salmon;
            this.cancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBT.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cancelBT.FlatAppearance.BorderSize = 0;
            this.cancelBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cancelBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.cancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBT.Location = new System.Drawing.Point(383, 5);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(106, 23);
            this.cancelBT.TabIndex = 3;
            this.cancelBT.Text = "Отмена";
            this.cancelBT.UseVisualStyleBackColor = false;
            this.cancelBT.Click += new System.EventHandler(this.cancelBT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.form2TextBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(576, 102);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cancelBT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addBT, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 279);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 34);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 151);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выгрузить из файла";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.75758F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.24242F));
            this.tableLayoutPanel2.Controls.Add(this.openResultLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.openBT, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.openTextBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 125);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // openResultLabel
            // 
            this.openResultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openResultLabel.AutoSize = true;
            this.openResultLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.openResultLabel.Location = new System.Drawing.Point(129, 83);
            this.openResultLabel.Name = "openResultLabel";
            this.openResultLabel.Size = new System.Drawing.Size(178, 20);
            this.openResultLabel.TabIndex = 19;
            this.openResultLabel.Text = "Результат выгрузки";
            // 
            // openBT
            // 
            this.openBT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openBT.BackColor = System.Drawing.Color.DimGray;
            this.openBT.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.openBT.FlatAppearance.BorderSize = 0;
            this.openBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.openBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.openBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openBT.Location = new System.Drawing.Point(444, 37);
            this.openBT.Name = "openBT";
            this.openBT.Size = new System.Drawing.Size(124, 22);
            this.openBT.TabIndex = 2;
            this.openBT.Text = "Выбрать";
            this.openBT.UseVisualStyleBackColor = false;
            this.openBT.Click += new System.EventHandler(this.openBT_Click);
            // 
            // openTextBox
            // 
            this.openTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openTextBox.Location = new System.Drawing.Point(3, 32);
            this.openTextBox.Name = "openTextBox";
            this.openTextBox.ReadOnly = true;
            this.openTextBox.Size = new System.Drawing.Size(430, 27);
            this.openTextBox.TabIndex = 18;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(582, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "Form2";
            this.Text = "Добавление секции";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox form2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label openResultLabel;
        private System.Windows.Forms.Button openBT;
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}