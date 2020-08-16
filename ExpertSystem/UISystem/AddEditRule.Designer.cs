namespace ExpertSystem
{
    partial class AddEditRule
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditCondition = new System.Windows.Forms.Button();
            this.lvCondition = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelCondition = new System.Windows.Forms.Button();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditRes = new System.Windows.Forms.Button();
            this.lvResulution = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelRes = new System.Windows.Forms.Button();
            this.btnAddRes = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя правила";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(8, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(331, 20);
            this.tbName.TabIndex = 6;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditCondition);
            this.groupBox1.Controls.Add(this.lvCondition);
            this.groupBox1.Controls.Add(this.btnDelCondition);
            this.groupBox1.Controls.Add(this.btnAddCondition);
            this.groupBox1.Location = new System.Drawing.Point(2, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnEditCondition
            // 
            this.btnEditCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCondition.Location = new System.Drawing.Point(254, 48);
            this.btnEditCondition.Name = "btnEditCondition";
            this.btnEditCondition.Size = new System.Drawing.Size(83, 23);
            this.btnEditCondition.TabIndex = 13;
            this.btnEditCondition.Text = "Изменить";
            this.btnEditCondition.UseVisualStyleBackColor = true;
            this.btnEditCondition.Click += new System.EventHandler(this.btnEditCondition_Click);
            // 
            // lvCondition
            // 
            this.lvCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvCondition.BackColor = System.Drawing.Color.White;
            this.lvCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCondition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvCondition.ForeColor = System.Drawing.Color.Black;
            this.lvCondition.FullRowSelect = true;
            this.lvCondition.GridLines = true;
            this.lvCondition.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCondition.HideSelection = false;
            this.lvCondition.Location = new System.Drawing.Point(6, 19);
            this.lvCondition.MultiSelect = false;
            this.lvCondition.Name = "lvCondition";
            this.lvCondition.Size = new System.Drawing.Size(242, 81);
            this.lvCondition.TabIndex = 15;
            this.lvCondition.UseCompatibleStateImageBehavior = false;
            this.lvCondition.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Условие";
            this.columnHeader1.Width = 225;
            // 
            // btnDelCondition
            // 
            this.btnDelCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCondition.Location = new System.Drawing.Point(254, 77);
            this.btnDelCondition.Name = "btnDelCondition";
            this.btnDelCondition.Size = new System.Drawing.Size(83, 23);
            this.btnDelCondition.TabIndex = 14;
            this.btnDelCondition.Text = "Удалить";
            this.btnDelCondition.UseVisualStyleBackColor = true;
            this.btnDelCondition.Click += new System.EventHandler(this.btnDelCondition_Click);
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCondition.Location = new System.Drawing.Point(254, 19);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(83, 23);
            this.btnAddCondition.TabIndex = 12;
            this.btnAddCondition.Text = "Добавить";
            this.btnAddCondition.UseVisualStyleBackColor = true;
            this.btnAddCondition.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditRes);
            this.groupBox2.Controls.Add(this.lvResulution);
            this.groupBox2.Controls.Add(this.btnDelRes);
            this.groupBox2.Controls.Add(this.btnAddRes);
            this.groupBox2.Location = new System.Drawing.Point(2, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 112);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnEditRes
            // 
            this.btnEditRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRes.Location = new System.Drawing.Point(254, 54);
            this.btnEditRes.Name = "btnEditRes";
            this.btnEditRes.Size = new System.Drawing.Size(83, 23);
            this.btnEditRes.TabIndex = 13;
            this.btnEditRes.Text = "Изменить";
            this.btnEditRes.UseVisualStyleBackColor = true;
            this.btnEditRes.Click += new System.EventHandler(this.btnEditRes_Click);
            // 
            // lvResulution
            // 
            this.lvResulution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvResulution.BackColor = System.Drawing.Color.White;
            this.lvResulution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvResulution.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvResulution.ForeColor = System.Drawing.Color.Black;
            this.lvResulution.FullRowSelect = true;
            this.lvResulution.GridLines = true;
            this.lvResulution.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResulution.HideSelection = false;
            this.lvResulution.Location = new System.Drawing.Point(6, 25);
            this.lvResulution.MultiSelect = false;
            this.lvResulution.Name = "lvResulution";
            this.lvResulution.Size = new System.Drawing.Size(242, 81);
            this.lvResulution.TabIndex = 15;
            this.lvResulution.UseCompatibleStateImageBehavior = false;
            this.lvResulution.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Заключение";
            this.columnHeader2.Width = 228;
            // 
            // btnDelRes
            // 
            this.btnDelRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelRes.Location = new System.Drawing.Point(254, 83);
            this.btnDelRes.Name = "btnDelRes";
            this.btnDelRes.Size = new System.Drawing.Size(83, 23);
            this.btnDelRes.TabIndex = 14;
            this.btnDelRes.Text = "Удалить";
            this.btnDelRes.UseVisualStyleBackColor = true;
            this.btnDelRes.Click += new System.EventHandler(this.btnDelRes_Click);
            // 
            // btnAddRes
            // 
            this.btnAddRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRes.Location = new System.Drawing.Point(254, 25);
            this.btnAddRes.Name = "btnAddRes";
            this.btnAddRes.Size = new System.Drawing.Size(83, 23);
            this.btnAddRes.TabIndex = 12;
            this.btnAddRes.Text = "Добавить";
            this.btnAddRes.UseVisualStyleBackColor = true;
            this.btnAddRes.Click += new System.EventHandler(this.btnAddRes_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(256, 356);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(167, 356);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(6, 16);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(331, 45);
            this.tbReason.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbReason);
            this.groupBox3.Location = new System.Drawing.Point(2, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 67);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Объяснение";
            // 
            // AddEditRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 391);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Правило";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditRule_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditCondition;
        private System.Windows.Forms.ListView lvCondition;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnDelCondition;
        private System.Windows.Forms.Button btnAddCondition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditRes;
        private System.Windows.Forms.ListView lvResulution;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDelRes;
        private System.Windows.Forms.Button btnAddRes;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}