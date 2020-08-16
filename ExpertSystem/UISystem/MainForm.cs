using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class MainForm : Form
    {
        private eFormType m_FormType;
        public static Shell CurrentShell { get; set; }
        private Variable m_Goal;

        public MainForm()
        {
            InitializeComponent();
            CurrentShell = new Shell();
            m_FormType = eFormType.ftRules;
        }

        enum eFormType
        {
            ftDomains = 0,
            ftVars = 1,
            ftRules = 2
        }

        private void UpdateForm(int Index = 0)
        {
            gbCurrentDomain.Visible = m_FormType == eFormType.ftDomains;
            gbCurrentRule.Visible = m_FormType == eFormType.ftRules;
            gbCurrentVar.Visible = m_FormType == eFormType.ftVars;
            lvTable.Clear();
            lvTable.Columns.Add("Имя");
            switch (m_FormType)
            {
                case eFormType.ftDomains:
                    {
                        foreach (var dom in CurrentShell.CurrentExpertSystem.Domains)
                        {
                            var lvi = new ListViewItem(new[]
                            {
                                    dom.Name
                                })
                            {
                                Tag = dom
                            };
                            lvTable.Items.Add(lvi);
                        }
                        if (lvTable.Items.Count > Index) lvTable.Items[Index].Selected = true;
                        UpdateDom();
                    }
                    break;
                case eFormType.ftVars:
                    {
                        lvTable.Columns.Add("Тип");
                        lvTable.Columns.Add("Домен");

                        foreach (var var in CurrentShell.CurrentExpertSystem.Vars)
                        {
                            var lvi = new ListViewItem(new[]
                            {
                                    var.Name,
                                    var.VarTypeToString(),
                                    var.Dom.Name
                                })
                            {
                                Tag = var
                            };
                            lvTable.Items.Add(lvi);
                        }
                        if (lvTable.Items.Count > Index) lvTable.Items[Index].Selected = true;
                        UpdateVar();
                    }
                    break;
                case eFormType.ftRules:
                    {
                        lvTable.Columns.Add("Текст правила");

                        foreach (var rule in CurrentShell.CurrentExpertSystem.Rules)
                        {
                            var lvi = new ListViewItem(new[]
                            {
                                    rule.Name,
                                    rule.SetText()
                                })
                            {
                                Tag = rule
                            };
                            lvTable.Items.Add(lvi);
                        }

                        if(lvTable.Items.Count > Index) lvTable.Items[Index].Selected = true;
                        UpdateRule();
                    }
                    break;
            }

            lvTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void domainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_FormType = eFormType.ftDomains;
            this.AllowDrop = false;
            UpdateForm();
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_FormType = eFormType.ftVars;
            this.AllowDrop = false;
            UpdateForm();
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            m_FormType = eFormType.ftRules;
            UpdateForm();
        }

        private void AddOrEditRule(bool IsEditMode)
        {
            ListViewItem selectedItem = null;
            int Index = -1;
            if (lvTable.SelectedItems.Count != 0)
            {
                selectedItem = lvTable.SelectedItems[0];
                Index = selectedItem.Index;
            }
            if (IsEditMode && selectedItem == null) return;

            AddEditRule frmRule = new AddEditRule()
            {
                EditRule = IsEditMode ? (Rule)selectedItem.Tag : new Rule()
            };

            if(IsEditMode) frmRule.InitControls();

            if (frmRule.ShowDialog() == DialogResult.OK)
            {
                CurrentShell.CurrentExpertSystem.AddOrEditRule(frmRule.EditRule, IsEditMode, Index + 1);
                UpdateForm(Index + 1);
            }
        }

        private void AddOrEditVar(bool IsEditMode)
        {
            ListViewItem selectedItem = null;
            int Index = 0;
            if (lvTable.SelectedItems.Count != 0)
            {
                selectedItem = lvTable.SelectedItems[0];
                Index = selectedItem.Index;
            }

            if (IsEditMode && selectedItem == null) return;

            AddEditVar frmVar = new AddEditVar()
            {
                EditVar = IsEditMode ? (Variable)selectedItem.Tag : new Variable()
            };

            frmVar.InitControls(IsEditMode);

            if (frmVar.ShowDialog() == DialogResult.OK)
            {
                CurrentShell.CurrentExpertSystem.AddOrEditVar(frmVar.EditVar, IsEditMode, Index);
                UpdateForm(Index);
            }
        }

        private void AddOrEditDomain(bool IsEditMode)
        {
            ListViewItem selectedItem = null;
            int Index = 0;
            if (lvTable.SelectedItems.Count != 0)
            {
                selectedItem = lvTable.SelectedItems[0];
                Index = selectedItem.Index;
            }

            if (IsEditMode && selectedItem == null) return;

            Domain Dom = new Domain();
            AddEditDomain frmDom = new AddEditDomain()
            {
                EditDom = new Domain()
            };

            bool IsCopy = false;
            if (IsEditMode)
            {
                Dom = (Domain)selectedItem.Tag;
                if (Dom.UseCount > 1)
                {
                    DialogResult Res = MessageBox.Show("Домен используется в переменных, его значения нельзя изменять! Создать копию?", "Внимание!", MessageBoxButtons.YesNo); //frmEditDom.ShowDialog();
                    switch (Res)
                    {
                        case DialogResult.Yes:
                            frmDom = new AddEditDomain()
                            {
                                EditDom = new Domain(Dom.Name + "_COPY", Dom.Values)
                            };
                            IsCopy = true;
                            break;
                        default:
                            frmDom = new AddEditDomain()
                            {
                                EditDom = Dom
                            };
                            break;
                    }
                }
                else
                {
                    frmDom = new AddEditDomain()
                    {
                        EditDom = Dom
                    };
                }
            }

            if (IsEditMode) frmDom.InitControls();

            if (frmDom.ShowDialog() == DialogResult.OK)
            {
                if (IsCopy) IsEditMode = false;
                CurrentShell.CurrentExpertSystem.AddOrEditDomain(frmDom.EditDom, IsEditMode, Index);
                UpdateForm(Index);
            }
        }

        private void buttonAddRule_Click(object sender, EventArgs e)
        {
            switch(m_FormType)
            {
                case eFormType.ftRules:
                    AddOrEditRule(false); break;
                case eFormType.ftVars:
                    AddOrEditVar(false); break;
                case eFormType.ftDomains:
                    AddOrEditDomain(false); break;
            }
        }

        private void buttonEditRule_Click(object sender, EventArgs e)
        {
            switch (m_FormType)
            {
                case eFormType.ftRules:
                    AddOrEditRule(true); break;
                case eFormType.ftVars:
                    AddOrEditVar(true); break;
                case eFormType.ftDomains:
                    AddOrEditDomain(true); break;
            }
        }

        private void buttonRemoveRule_Click(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count != 0)
            {
                switch (m_FormType)
                {
                    case eFormType.ftRules:
                        {
                            CurrentShell.CurrentExpertSystem.DeleteRule((Rule)lvTable.SelectedItems[0].Tag);
                        }
                        break;
                    case eFormType.ftVars:
                        {
                            CurrentShell.CurrentExpertSystem.DeleteVar((Variable)lvTable.SelectedItems[0].Tag);
                        }
                        break;
                    case eFormType.ftDomains:
                        {
                            CurrentShell.CurrentExpertSystem.DeleteDomain((Domain)lvTable.SelectedItems[0].Tag);
                        }
                        break;
                }
                UpdateForm();
            }
        }

        private void UpdateDom()
        {
            if (lvTable.SelectedItems.Count != 0)
            {
                Domain Dom = (Domain)lvTable.SelectedItems[0].Tag;
                listViewAllowedValues.Items.Clear();
                foreach (string val in Dom.Values)
                {
                    var lvi = new ListViewItem(new[]
                    {
                    val
                })
                    {
                        Tag = val
                    };
                    listViewAllowedValues.Items.Add(lvi);
                }
            }
        }

        private void UpdateVar()
        {
            if (lvTable.SelectedItems.Count != 0)
            {
                Variable Var = (Variable)lvTable.SelectedItems[0].Tag;
                tbDomain.Text = Var.Dom.Name;
                tbVarType.Text = Var.VarTypeToString();
                rtbQuestion.Text = Var.Text;

                Domain Dom = Var.Dom;
                lvVarDom.Items.Clear();
                foreach (string val in Dom.Values)
                {
                    var lvi = new ListViewItem(new[]
                    {
                    val
                })
                    {
                        Tag = val
                    };
                    lvVarDom.Items.Add(lvi);
                }
            }
        }

        private void UpdateRule()
        {
            if (lvTable.SelectedItems.Count != 0)
            {
                Rule pRule = (Rule)lvTable.SelectedItems[0].Tag;
                listViewResolution.Items.Clear();
                foreach (var res in pRule.ResultList)
                {
                    var lvi = new ListViewItem(new[]
                    {
                    res.Var.Name + " = " + res.Value,
                })
                    {
                        Tag = res
                    };
                    listViewResolution.Items.Add(lvi);
                }

                listViewCondition.Items.Clear();
                foreach (var cond in pRule.ConditionList)
                {
                    var lvi = new ListViewItem(new[]
                    {
                    cond.Var.Name + " = " + cond.Value,
                })
                    {
                        Tag = cond
                    };
                    listViewCondition.Items.Add(lvi);
                }
            }
        }

        private void lvTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (m_FormType)
            {
                case eFormType.ftRules:
                    UpdateRule(); break;
                case eFormType.ftVars:
                    UpdateVar(); break;
                case eFormType.ftDomains:
                    UpdateDom(); break;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CurrentShell.LoadSystem(openFileDialog.FileName);
                    UpdateForm();
                }
                catch (ArgumentException ex)
                {
                    int num = (int)MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void Save()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CurrentShell.SaveSystem(saveFileDialog.FileName);
                }
                catch (ArgumentException ex)
                {
                    int num = (int)MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentShell.CreateSystem();
            UpdateForm();
        }

        private bool ExitDialog()
        {
            DialogResult Res = MessageBox.Show("Сохранить изменения перед закрытием?", "Внимание!", MessageBoxButtons.YesNoCancel);
            if (Res == DialogResult.Yes)
            {
                Save();
            }
            else
            {
                if (Res == DialogResult.Cancel) return false;
            }

            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ExitDialog()) e.Cancel = true;
        }

        private void setGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoalForm SetGoal = new GoalForm()
            {
                Goal = m_Goal
            };

            if(SetGoal.ShowDialog() == DialogResult.OK)
            {
                m_Goal = SetGoal.Goal;
            }
        }

        private void doConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Goal == null) MessageBox.Show("Необходимо задать цель консультации!");
            else CurrentShell.StartConsult(m_Goal);
        }

        private void показатьОбъяснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentShell.ConsultCache == null) MessageBox.Show("Сначала нужно пройти консультацию!");
            else CurrentShell.ConsultCache.GetLineOfReasoning();
        }
    }
}

