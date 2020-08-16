namespace ExpertSystem
{
    partial class AddEditFact
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
            this.cmbVar = new System.Windows.Forms.ComboBox();
            this.cmbValue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lVar = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbVar
            // 
            this.cmbVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVar.FormattingEnabled = true;
            this.cmbVar.Location = new System.Drawing.Point(12, 38);
            this.cmbVar.Name = "cmbVar";
            this.cmbVar.Size = new System.Drawing.Size(130, 21);
            this.cmbVar.TabIndex = 0;
            this.cmbVar.SelectedIndexChanged += new System.EventHandler(this.cmbVar_SelectedIndexChanged);
            // 
            // cmbValue
            // 
            this.cmbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValue.FormattingEnabled = true;
            this.cmbValue.Location = new System.Drawing.Point(172, 38);
            this.cmbValue.Name = "cmbValue";
            this.cmbValue.Size = new System.Drawing.Size(172, 21);
            this.cmbValue.TabIndex = 1;
            this.cmbValue.SelectedIndexChanged += new System.EventHandler(this.cmbValue_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // lVar
            // 
            this.lVar.AutoSize = true;
            this.lVar.Location = new System.Drawing.Point(9, 18);
            this.lVar.Name = "lVar";
            this.lVar.Size = new System.Drawing.Size(74, 13);
            this.lVar.TabIndex = 3;
            this.lVar.Text = "Переменная:";
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Location = new System.Drawing.Point(168, 18);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(58, 13);
            this.lValue.TabIndex = 4;
            this.lValue.Text = "Значение:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(261, 75);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 23);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(172, 75);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 23);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // btnAddVar
            // 
            this.btnAddVar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVar.Location = new System.Drawing.Point(12, 75);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(130, 23);
            this.btnAddVar.TabIndex = 25;
            this.btnAddVar.Text = "Добавить";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // AddEditFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 110);
            this.Controls.Add(this.btnAddVar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.lValue);
            this.Controls.Add(this.lVar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbValue);
            this.Controls.Add(this.cmbVar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditFact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Факт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditFact_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVar;
        private System.Windows.Forms.ComboBox cmbValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lVar;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button btnAddVar;
    }
}