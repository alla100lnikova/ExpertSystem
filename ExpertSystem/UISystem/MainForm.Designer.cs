using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExpertSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.показатьОбъяснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCurrentVar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVarType = new System.Windows.Forms.TextBox();
            this.gbCurrentDomain = new System.Windows.Forms.GroupBox();
            this.listViewAllowedValues = new System.Windows.Forms.ListView();
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbCurrentRule = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewCondition = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewResolution = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveRule = new System.Windows.Forms.Button();
            this.buttonEditRule = new System.Windows.Forms.Button();
            this.buttonAddRule = new System.Windows.Forms.Button();
            this.lvTable = new ListViewDD();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lvVarDom = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbCurrentVar.SuspendLayout();
            this.gbCurrentDomain.SuspendLayout();
            this.gbCurrentRule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.domainToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(865, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.createToolStripMenuItem.Text = "Новый";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openToolStripMenuItem.Text = "Открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveToolStripMenuItem.Text = "Сохранить как...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // domainToolStripMenuItem
            // 
            this.domainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.domainsToolStripMenuItem,
            this.variablesToolStripMenuItem,
            this.правилаToolStripMenuItem});
            this.domainToolStripMenuItem.Name = "domainToolStripMenuItem";
            this.domainToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.domainToolStripMenuItem.Text = "Приобретение знаний";
            // 
            // domainsToolStripMenuItem
            // 
            this.domainsToolStripMenuItem.Name = "domainsToolStripMenuItem";
            this.domainsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.domainsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.domainsToolStripMenuItem.Text = "Домены";
            this.domainsToolStripMenuItem.Click += new System.EventHandler(this.domainsToolStripMenuItem_Click);
            // 
            // variablesToolStripMenuItem
            // 
            this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            this.variablesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.variablesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.variablesToolStripMenuItem.Text = "Переменные";
            this.variablesToolStripMenuItem.Click += new System.EventHandler(this.variablesToolStripMenuItem_Click);
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.правилаToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setGoalToolStripMenuItem,
            this.doConsultationToolStripMenuItem,
            this.toolStripSeparator2,
            this.показатьОбъяснениеToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.consultationToolStripMenuItem.Text = "Консультация";
            // 
            // setGoalToolStripMenuItem
            // 
            this.setGoalToolStripMenuItem.Name = "setGoalToolStripMenuItem";
            this.setGoalToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.setGoalToolStripMenuItem.Text = "Задать цель консультации";
            this.setGoalToolStripMenuItem.Click += new System.EventHandler(this.setGoalToolStripMenuItem_Click);
            // 
            // doConsultationToolStripMenuItem
            // 
            this.doConsultationToolStripMenuItem.Name = "doConsultationToolStripMenuItem";
            this.doConsultationToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.doConsultationToolStripMenuItem.Text = "Начать консультацию";
            this.doConsultationToolStripMenuItem.Click += new System.EventHandler(this.doConsultationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(266, 6);
            // 
            // показатьОбъяснениеToolStripMenuItem
            // 
            this.показатьОбъяснениеToolStripMenuItem.Name = "показатьОбъяснениеToolStripMenuItem";
            this.показатьОбъяснениеToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.показатьОбъяснениеToolStripMenuItem.Text = "Показать результаты консультации";
            this.показатьОбъяснениеToolStripMenuItem.Click += new System.EventHandler(this.показатьОбъяснениеToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "bin";
            this.saveFileDialog.Filter = "Binary files|*.bin";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "bin";
            this.openFileDialog.Filter = "Binary files|*.bin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbCurrentVar);
            this.panel1.Controls.Add(this.gbCurrentDomain);
            this.panel1.Controls.Add(this.gbCurrentRule);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(595, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 490);
            this.panel1.TabIndex = 1;
            // 
            // gbCurrentVar
            // 
            this.gbCurrentVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCurrentVar.Controls.Add(this.lvVarDom);
            this.gbCurrentVar.Controls.Add(this.label3);
            this.gbCurrentVar.Controls.Add(this.rtbQuestion);
            this.gbCurrentVar.Controls.Add(this.label2);
            this.gbCurrentVar.Controls.Add(this.tbDomain);
            this.gbCurrentVar.Controls.Add(this.label1);
            this.gbCurrentVar.Controls.Add(this.tbVarType);
            this.gbCurrentVar.Location = new System.Drawing.Point(11, 3);
            this.gbCurrentVar.Name = "gbCurrentVar";
            this.gbCurrentVar.Size = new System.Drawing.Size(250, 398);
            this.gbCurrentVar.TabIndex = 5;
            this.gbCurrentVar.TabStop = false;
            this.gbCurrentVar.Text = "Переменная";
            this.gbCurrentVar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Текст вопроса";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbQuestion.Location = new System.Drawing.Point(6, 122);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.ReadOnly = true;
            this.rtbQuestion.Size = new System.Drawing.Size(238, 106);
            this.rtbQuestion.TabIndex = 4;
            this.rtbQuestion.TabStop = false;
            this.rtbQuestion.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Домен";
            // 
            // tbDomain
            // 
            this.tbDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDomain.Location = new System.Drawing.Point(6, 40);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.ReadOnly = true;
            this.tbDomain.Size = new System.Drawing.Size(238, 20);
            this.tbDomain.TabIndex = 2;
            this.tbDomain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип";
            // 
            // tbVarType
            // 
            this.tbVarType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVarType.Location = new System.Drawing.Point(6, 79);
            this.tbVarType.Name = "tbVarType";
            this.tbVarType.ReadOnly = true;
            this.tbVarType.Size = new System.Drawing.Size(238, 20);
            this.tbVarType.TabIndex = 0;
            this.tbVarType.TabStop = false;
            // 
            // gbCurrentDomain
            // 
            this.gbCurrentDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCurrentDomain.Controls.Add(this.listViewAllowedValues);
            this.gbCurrentDomain.Location = new System.Drawing.Point(11, 3);
            this.gbCurrentDomain.Name = "gbCurrentDomain";
            this.gbCurrentDomain.Size = new System.Drawing.Size(250, 398);
            this.gbCurrentDomain.TabIndex = 5;
            this.gbCurrentDomain.TabStop = false;
            this.gbCurrentDomain.Text = "Допустимые значения";
            this.gbCurrentDomain.Visible = false;
            // 
            // listViewAllowedValues
            // 
            this.listViewAllowedValues.BackColor = System.Drawing.SystemColors.Window;
            this.listViewAllowedValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewAllowedValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderValue});
            this.listViewAllowedValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAllowedValues.ForeColor = System.Drawing.Color.Black;
            this.listViewAllowedValues.FullRowSelect = true;
            this.listViewAllowedValues.GridLines = true;
            this.listViewAllowedValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAllowedValues.HideSelection = false;
            this.listViewAllowedValues.Location = new System.Drawing.Point(3, 16);
            this.listViewAllowedValues.MultiSelect = false;
            this.listViewAllowedValues.Name = "listViewAllowedValues";
            this.listViewAllowedValues.Size = new System.Drawing.Size(244, 379);
            this.listViewAllowedValues.TabIndex = 5;
            this.listViewAllowedValues.UseCompatibleStateImageBehavior = false;
            this.listViewAllowedValues.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Значение";
            this.columnHeaderValue.Width = 200;
            // 
            // gbCurrentRule
            // 
            this.gbCurrentRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbCurrentRule.Controls.Add(this.splitContainer1);
            this.gbCurrentRule.Location = new System.Drawing.Point(8, 4);
            this.gbCurrentRule.Name = "gbCurrentRule";
            this.gbCurrentRule.Size = new System.Drawing.Size(250, 394);
            this.gbCurrentRule.TabIndex = 7;
            this.gbCurrentRule.TabStop = false;
            this.gbCurrentRule.Text = "Правило";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewCondition);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewResolution);
            this.splitContainer1.Size = new System.Drawing.Size(244, 375);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 0;
            // 
            // listViewCondition
            // 
            this.listViewCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCondition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCondition.ForeColor = System.Drawing.Color.Black;
            this.listViewCondition.FullRowSelect = true;
            this.listViewCondition.GridLines = true;
            this.listViewCondition.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCondition.HideSelection = false;
            this.listViewCondition.Location = new System.Drawing.Point(0, 0);
            this.listViewCondition.MultiSelect = false;
            this.listViewCondition.Name = "listViewCondition";
            this.listViewCondition.Size = new System.Drawing.Size(244, 167);
            this.listViewCondition.TabIndex = 1;
            this.listViewCondition.UseCompatibleStateImageBehavior = false;
            this.listViewCondition.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Условие";
            this.columnHeader1.Width = 217;
            // 
            // listViewResolution
            // 
            this.listViewResolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewResolution.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResolution.ForeColor = System.Drawing.Color.Black;
            this.listViewResolution.FullRowSelect = true;
            this.listViewResolution.GridLines = true;
            this.listViewResolution.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewResolution.HideSelection = false;
            this.listViewResolution.Location = new System.Drawing.Point(0, 0);
            this.listViewResolution.MultiSelect = false;
            this.listViewResolution.Name = "listViewResolution";
            this.listViewResolution.Size = new System.Drawing.Size(244, 204);
            this.listViewResolution.TabIndex = 1;
            this.listViewResolution.UseCompatibleStateImageBehavior = false;
            this.listViewResolution.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Заключение";
            this.columnHeader2.Width = 217;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonRemoveRule);
            this.groupBox1.Controls.Add(this.buttonEditRule);
            this.groupBox1.Controls.Add(this.buttonAddRule);
            this.groupBox1.Location = new System.Drawing.Point(8, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonRemoveRule
            // 
            this.buttonRemoveRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveRule.Location = new System.Drawing.Point(169, 19);
            this.buttonRemoveRule.Name = "buttonRemoveRule";
            this.buttonRemoveRule.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveRule.TabIndex = 5;
            this.buttonRemoveRule.Text = "Удалить";
            this.buttonRemoveRule.UseVisualStyleBackColor = true;
            this.buttonRemoveRule.Click += new System.EventHandler(this.buttonRemoveRule_Click);
            // 
            // buttonEditRule
            // 
            this.buttonEditRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRule.Location = new System.Drawing.Point(87, 19);
            this.buttonEditRule.Name = "buttonEditRule";
            this.buttonEditRule.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRule.TabIndex = 4;
            this.buttonEditRule.Text = "Изменить";
            this.buttonEditRule.UseVisualStyleBackColor = true;
            this.buttonEditRule.Click += new System.EventHandler(this.buttonEditRule_Click);
            // 
            // buttonAddRule
            // 
            this.buttonAddRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRule.Location = new System.Drawing.Point(6, 19);
            this.buttonAddRule.Name = "buttonAddRule";
            this.buttonAddRule.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRule.TabIndex = 3;
            this.buttonAddRule.Text = "Добавить";
            this.buttonAddRule.UseVisualStyleBackColor = true;
            this.buttonAddRule.Click += new System.EventHandler(this.buttonAddRule_Click);
            // 
            // lvTable
            // 
            this.lvTable.AllowDrop = true;
            this.lvTable.AllowRowReorder = true;
            this.lvTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderRule});
            this.lvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTable.ForeColor = System.Drawing.Color.Black;
            this.lvTable.FullRowSelect = true;
            this.lvTable.GridLines = true;
            this.lvTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTable.HideSelection = false;
            this.lvTable.Location = new System.Drawing.Point(0, 24);
            this.lvTable.MultiSelect = false;
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(595, 490);
            this.lvTable.TabIndex = 2;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            this.lvTable.SelectedIndexChanged += new System.EventHandler(this.lvTable_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 80;
            // 
            // columnHeaderRule
            // 
            this.columnHeaderRule.Text = "Содержание";
            this.columnHeaderRule.Width = 800;
            // 
            // lvVarDom
            // 
            this.lvVarDom.BackColor = System.Drawing.SystemColors.Window;
            this.lvVarDom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvVarDom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvVarDom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvVarDom.ForeColor = System.Drawing.Color.Black;
            this.lvVarDom.FullRowSelect = true;
            this.lvVarDom.GridLines = true;
            this.lvVarDom.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvVarDom.HideSelection = false;
            this.lvVarDom.Location = new System.Drawing.Point(3, 234);
            this.lvVarDom.MultiSelect = false;
            this.lvVarDom.Name = "lvVarDom";
            this.lvVarDom.Size = new System.Drawing.Size(244, 161);
            this.lvVarDom.TabIndex = 6;
            this.lvVarDom.UseCompatibleStateImageBehavior = false;
            this.lvVarDom.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Значение";
            this.columnHeader3.Width = 223;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 514);
            this.Controls.Add(this.lvTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукционная оболочка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbCurrentVar.ResumeLayout(false);
            this.gbCurrentVar.PerformLayout();
            this.gbCurrentDomain.ResumeLayout(false);
            this.gbCurrentRule.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem domainToolStripMenuItem;
        private ToolStripMenuItem consultationToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem variablesToolStripMenuItem;
        private ToolStripMenuItem domainsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem setGoalToolStripMenuItem;
        private ToolStripMenuItem doConsultationToolStripMenuItem;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderRule;
        private GroupBox groupBox1;
        private Button buttonRemoveRule;
        private Button buttonEditRule;
        private Button buttonAddRule;
        private ToolTip toolTip;
        private GroupBox gbCurrentRule;
        private SplitContainer splitContainer1;
        private ListView listViewCondition;
        private ListView listViewResolution;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox gbCurrentDomain;
        private ListView listViewAllowedValues;
        private ColumnHeader columnHeaderValue;
        private GroupBox gbCurrentVar;
        private Label label3;
        private RichTextBox rtbQuestion;
        private Label label2;
        private TextBox tbDomain;
        private Label label1;
        private TextBox tbVarType;
        private ToolStripMenuItem правилаToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem показатьОбъяснениеToolStripMenuItem;
        private ListViewDD lvTable;
        private ListView lvVarDom;
        private ColumnHeader columnHeader3;
    }
}

