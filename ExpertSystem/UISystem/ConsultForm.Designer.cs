namespace ExpertSystem
{
    partial class ConsultForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCons = new System.Windows.Forms.TabPage();
            this.gbConsult = new System.Windows.Forms.GroupBox();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.cmbAnswer = new System.Windows.Forms.ComboBox();
            this.lvDialog = new System.Windows.Forms.ListBox();
            this.tpReason = new System.Windows.Forms.TabPage();
            this.lvFacts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeReason = new System.Windows.Forms.TreeView();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpCons.SuspendLayout();
            this.gbConsult.SuspendLayout();
            this.gbAnswer.SuspendLayout();
            this.tpReason.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpCons);
            this.tabControl1.Controls.Add(this.tpReason);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 341);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCons
            // 
            this.tpCons.Controls.Add(this.gbConsult);
            this.tpCons.Location = new System.Drawing.Point(4, 22);
            this.tpCons.Name = "tpCons";
            this.tpCons.Padding = new System.Windows.Forms.Padding(3);
            this.tpCons.Size = new System.Drawing.Size(1017, 315);
            this.tpCons.TabIndex = 0;
            this.tpCons.Text = "Консультация";
            this.tpCons.UseVisualStyleBackColor = true;
            // 
            // gbConsult
            // 
            this.gbConsult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbConsult.Controls.Add(this.gbAnswer);
            this.gbConsult.Controls.Add(this.lvDialog);
            this.gbConsult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConsult.Location = new System.Drawing.Point(3, 3);
            this.gbConsult.Name = "gbConsult";
            this.gbConsult.Size = new System.Drawing.Size(1011, 309);
            this.gbConsult.TabIndex = 0;
            this.gbConsult.TabStop = false;
            this.gbConsult.Text = "Цель консультации = ";
            // 
            // gbAnswer
            // 
            this.gbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAnswer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbAnswer.Controls.Add(this.btnAnswer);
            this.gbAnswer.Controls.Add(this.cmbAnswer);
            this.gbAnswer.Location = new System.Drawing.Point(745, 19);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(260, 281);
            this.gbAnswer.TabIndex = 2;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Ответ";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(6, 59);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(248, 23);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnswer.FormattingEnabled = true;
            this.cmbAnswer.Location = new System.Drawing.Point(6, 19);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Size = new System.Drawing.Size(248, 21);
            this.cmbAnswer.TabIndex = 1;
            // 
            // lvDialog
            // 
            this.lvDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDialog.FormattingEnabled = true;
            this.lvDialog.Location = new System.Drawing.Point(6, 23);
            this.lvDialog.Name = "lvDialog";
            this.lvDialog.Size = new System.Drawing.Size(733, 277);
            this.lvDialog.TabIndex = 0;
            // 
            // tpReason
            // 
            this.tpReason.Controls.Add(this.button2);
            this.tpReason.Controls.Add(this.btnExp);
            this.tpReason.Controls.Add(this.lvFacts);
            this.tpReason.Controls.Add(this.treeReason);
            this.tpReason.Location = new System.Drawing.Point(4, 22);
            this.tpReason.Name = "tpReason";
            this.tpReason.Padding = new System.Windows.Forms.Padding(3);
            this.tpReason.Size = new System.Drawing.Size(1017, 315);
            this.tpReason.TabIndex = 1;
            this.tpReason.Text = "Объяснение";
            this.tpReason.UseVisualStyleBackColor = true;
            // 
            // lvFacts
            // 
            this.lvFacts.BackColor = System.Drawing.Color.White;
            this.lvFacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvFacts.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvFacts.ForeColor = System.Drawing.Color.Black;
            this.lvFacts.FullRowSelect = true;
            this.lvFacts.GridLines = true;
            this.lvFacts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFacts.HideSelection = false;
            this.lvFacts.Location = new System.Drawing.Point(714, 3);
            this.lvFacts.MultiSelect = false;
            this.lvFacts.Name = "lvFacts";
            this.lvFacts.Size = new System.Drawing.Size(300, 309);
            this.lvFacts.TabIndex = 16;
            this.lvFacts.UseCompatibleStateImageBehavior = false;
            this.lvFacts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Переменная";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 146;
            // 
            // treeReason
            // 
            this.treeReason.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeReason.Location = new System.Drawing.Point(3, 3);
            this.treeReason.Name = "treeReason";
            this.treeReason.Size = new System.Drawing.Size(612, 309);
            this.treeReason.TabIndex = 0;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnd.Location = new System.Drawing.Point(878, 350);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(148, 27);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Закончить консультацию";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExp.Location = new System.Drawing.Point(621, 6);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(45, 36);
            this.btnExp.TabIndex = 17;
            this.btnExp.Text = "+";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(621, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConsultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 389);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConsultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultForm_FormClosing);
            this.Shown += new System.EventHandler(this.ConsultForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tpCons.ResumeLayout(false);
            this.gbConsult.ResumeLayout(false);
            this.gbAnswer.ResumeLayout(false);
            this.tpReason.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCons;
        private System.Windows.Forms.TabPage tpReason;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox gbConsult;
        private System.Windows.Forms.TreeView treeReason;
        private System.Windows.Forms.GroupBox gbAnswer;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.ComboBox cmbAnswer;
        private System.Windows.Forms.ListBox lvDialog;
        private System.Windows.Forms.ListView lvFacts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExp;
    }
}