namespace MarketManagerWF
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBT = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.openResultLabel = new System.Windows.Forms.Label();
            this.openTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Количество секций";
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
            this.cancelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBT.Location = new System.Drawing.Point(379, 5);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(106, 23);
            this.cancelBT.TabIndex = 4;
            this.cancelBT.Text = "Отмена";
            this.cancelBT.UseVisualStyleBackColor = false;
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
            this.addBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBT.Location = new System.Drawing.Point(91, 5);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(106, 23);
            this.addBT.TabIndex = 3;
            this.addBT.Text = "ОК";
            this.addBT.UseVisualStyleBackColor = false;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(3, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(282, 27);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(291, 54);
            this.amountTextBox.Mask = "0000";
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 27);
            this.amountTextBox.TabIndex = 1;
            this.amountTextBox.Text = "10";
            this.amountTextBox.ValidatingType = typeof(int);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // openBT
            // 
            this.openBT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openBT.BackColor = System.Drawing.Color.DimGray;
            this.openBT.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.openBT.FlatAppearance.BorderSize = 0;
            this.openBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.openBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 128);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать новый";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.amountTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.nameTextBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(576, 102);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 185);
            this.groupBox2.TabIndex = 19;
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
            // openTextBox
            // 
            this.openTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openTextBox.Location = new System.Drawing.Point(3, 32);
            this.openTextBox.Name = "openTextBox";
            this.openTextBox.ReadOnly = true;
            this.openTextBox.Size = new System.Drawing.Size(430, 27);
            this.openTextBox.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.addBT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelBT, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 34);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(582, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "Form4";
            this.Text = "Создать супермаркет";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox amountTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.Button openBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label openResultLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}