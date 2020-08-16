namespace ExpertSystem
{
    partial class AddEditVar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditDomain = new System.Windows.Forms.Button();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.cmbDom = new System.Windows.Forms.ComboBox();
            this.lvValues = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.chbInp = new System.Windows.Forms.CheckBox();
            this.chbOut = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbType.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditDomain);
            this.groupBox1.Controls.Add(this.btnAddDomain);
            this.groupBox1.Controls.Add(this.cmbDom);
            this.groupBox1.Controls.Add(this.lvValues);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 213);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Домен";
            // 
            // btnEditDomain
            // 
            this.btnEditDomain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDomain.Location = new System.Drawing.Point(261, 46);
            this.btnEditDomain.Name = "btnEditDomain";
            this.btnEditDomain.Size = new System.Drawing.Size(83, 23);
            this.btnEditDomain.TabIndex = 13;
            this.btnEditDomain.Text = "Изменить";
            this.btnEditDomain.UseVisualStyleBackColor = true;
            this.btnEditDomain.Click += new System.EventHandler(this.btnEditDomain_Click);
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDomain.Location = new System.Drawing.Point(261, 17);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(83, 23);
            this.btnAddDomain.TabIndex = 12;
            this.btnAddDomain.Text = "Добавить";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // cmbDom
            // 
            this.cmbDom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDom.FormattingEnabled = true;
            this.cmbDom.Location = new System.Drawing.Point(6, 19);
            this.cmbDom.Name = "cmbDom";
            this.cmbDom.Size = new System.Drawing.Size(246, 21);
            this.cmbDom.TabIndex = 17;
            this.cmbDom.SelectedIndexChanged += new System.EventHandler(this.cmbDom_SelectedIndexChanged);
            // 
            // lvValues
            // 
            this.lvValues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0});
            this.lvValues.ForeColor = System.Drawing.Color.Black;
            this.lvValues.FullRowSelect = true;
            this.lvValues.GridLines = true;
            this.lvValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvValues.HideSelection = false;
            this.lvValues.Location = new System.Drawing.Point(6, 48);
            this.lvValues.MultiSelect = false;
            this.lvValues.Name = "lvValues";
            this.lvValues.Size = new System.Drawing.Size(246, 159);
            this.lvValues.TabIndex = 15;
            this.lvValues.UseCompatibleStateImageBehavior = false;
            this.lvValues.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Значение";
            this.columnHeader0.Width = 237;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Имя переменной";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(18, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(338, 20);
            this.tbName.TabIndex = 18;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(270, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 23);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(181, 392);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 23);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.chbInp);
            this.gbType.Controls.Add(this.chbOut);
            this.gbType.Location = new System.Drawing.Point(12, 267);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(353, 45);
            this.gbType.TabIndex = 23;
            this.gbType.TabStop = false;
            this.gbType.Text = "Тип переменной";
            // 
            // chbInp
            // 
            this.chbInp.AutoSize = true;
            this.chbInp.Location = new System.Drawing.Point(143, 22);
            this.chbInp.Name = "chbInp";
            this.chbInp.Size = new System.Drawing.Size(109, 17);
            this.chbInp.TabIndex = 1;
            this.chbInp.Text = "Запрашиваемая";
            this.chbInp.UseVisualStyleBackColor = true;
            this.chbInp.CheckedChanged += new System.EventHandler(this.chbInp_CheckedChanged);
            // 
            // chbOut
            // 
            this.chbOut.AutoSize = true;
            this.chbOut.Location = new System.Drawing.Point(6, 22);
            this.chbOut.Name = "chbOut";
            this.chbOut.Size = new System.Drawing.Size(85, 17);
            this.chbOut.TabIndex = 0;
            this.chbOut.Text = "Выводимая";
            this.chbOut.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbQuestion);
            this.groupBox3.Location = new System.Drawing.Point(12, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 68);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Текст вопроса (для запрашиваемых переменных)";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(6, 23);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(335, 39);
            this.tbQuestion.TabIndex = 0;
            // 
            // AddEditVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 427);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditVar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Переменная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditVar_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDom;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.Button btnEditDomain;
        private System.Windows.Forms.ListView lvValues;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.CheckBox chbInp;
        private System.Windows.Forms.CheckBox chbOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbQuestion;
    }
}