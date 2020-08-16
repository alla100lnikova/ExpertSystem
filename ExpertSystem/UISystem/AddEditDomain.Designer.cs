namespace ExpertSystem
{
    partial class AddEditDomain
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.btnEditValue = new System.Windows.Forms.Button();
            this.btnDelValue = new System.Windows.Forms.Button();
            this.lvValues = new ListViewDD();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lvValues);
            this.groupBox1.Location = new System.Drawing.Point(9, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 184);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список допустимых значений";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbVal);
            this.groupBox2.Controls.Add(this.btnAddValue);
            this.groupBox2.Controls.Add(this.btnEditValue);
            this.groupBox2.Controls.Add(this.btnDelValue);
            this.groupBox2.Location = new System.Drawing.Point(261, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 158);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значение";
            // 
            // tbVal
            // 
            this.tbVal.Location = new System.Drawing.Point(6, 19);
            this.tbVal.Multiline = true;
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(83, 47);
            this.tbVal.TabIndex = 15;
            // 
            // btnAddValue
            // 
            this.btnAddValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddValue.Location = new System.Drawing.Point(6, 72);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(83, 23);
            this.btnAddValue.TabIndex = 12;
            this.btnAddValue.Text = "Добавить";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // btnEditValue
            // 
            this.btnEditValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditValue.Location = new System.Drawing.Point(6, 101);
            this.btnEditValue.Name = "btnEditValue";
            this.btnEditValue.Size = new System.Drawing.Size(83, 23);
            this.btnEditValue.TabIndex = 13;
            this.btnEditValue.Text = "Изменить";
            this.btnEditValue.UseVisualStyleBackColor = true;
            this.btnEditValue.Click += new System.EventHandler(this.btnEditValue_Click);
            // 
            // btnDelValue
            // 
            this.btnDelValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelValue.Location = new System.Drawing.Point(6, 129);
            this.btnDelValue.Name = "btnDelValue";
            this.btnDelValue.Size = new System.Drawing.Size(83, 23);
            this.btnDelValue.TabIndex = 14;
            this.btnDelValue.Text = "Удалить";
            this.btnDelValue.UseVisualStyleBackColor = true;
            this.btnDelValue.Click += new System.EventHandler(this.btnDelValue_Click);
            // 
            // lvValues
            // 
            this.lvValues.AllowDrop = true;
            this.lvValues.AllowRowReorder = true;
            this.lvValues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0});
            this.lvValues.ForeColor = System.Drawing.Color.Black;
            this.lvValues.FullRowSelect = true;
            this.lvValues.GridLines = true;
            this.lvValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvValues.HideSelection = false;
            this.lvValues.Location = new System.Drawing.Point(6, 19);
            this.lvValues.MultiSelect = false;
            this.lvValues.Name = "lvValues";
            this.lvValues.Size = new System.Drawing.Size(246, 159);
            this.lvValues.TabIndex = 15;
            this.lvValues.UseCompatibleStateImageBehavior = false;
            this.lvValues.View = System.Windows.Forms.View.Details;
            this.lvValues.SelectedIndexChanged += new System.EventHandler(this.lvValues_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Значение";
            this.columnHeader0.Width = 237;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Имя домена";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(15, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(344, 20);
            this.tbName.TabIndex = 12;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(276, 236);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(178, 236);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 23);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // AddEditDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 268);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditDomain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Домен";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditDomain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditValue;
        private System.Windows.Forms.Button btnDelValue;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private ListViewDD lvValues;
    }
}