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
    public partial class AddEditRule : BaseForm
    {
        private Rule m_Rule;
        bool m_bIsEditMode = false;

        public Rule EditRule
        {
            get { return m_Rule; }
            set { m_Rule = value; }
        }

        public void InitControls()
        {
            m_bIsEditMode = true;
            tbName.Text = m_Rule.Name;
            tbReason.Text = m_Rule.Reason;
            UpdateCond();
            UpdateRes();
        }

        public AddEditRule()
        {
            InitializeComponent();
            tbName.Text = "Rule" + (MainForm.CurrentShell.CurrentExpertSystem.Rules.Count + 1);
        }

        private eClosingType m_IsOK = eClosingType.ctExit;
        private void buttonOK_Click(object sender, EventArgs e)
        {
            m_IsOK = eClosingType.ctOK;
            if (!OnOK())
            {
                m_IsOK = eClosingType.ctNotValid;
                return;
            }
        }

        private Fact AddFact(bool IsCondition)
        {
            AddEditFact frmAddFact = new AddEditFact() { CurFact = new Fact() };
            frmAddFact.InitControls(false, IsCondition);
            if(frmAddFact.ShowDialog() == DialogResult.OK)
            {
                return frmAddFact.CurFact;
            }

            return null; 
        }

        private void UpdateCond()
        {
            lvCondition.Items.Clear();
            foreach (var cond in m_Rule.ConditionList)
            {
                var lvi = new ListViewItem(new[]
                {
                    cond.Var.Name + " = " + cond.Value,
                })
                {
                    Tag = cond
                };
                lvCondition.Items.Add(lvi);
            }
        }

        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            lvCondition.BackColor = Color.White;

            Fact fact = AddFact(true);
            if (fact != null && fact.Var != null && fact.Value != null)
            {
                m_Rule.ConditionList.Add(fact);
                fact.Var.UseCount++;
                UpdateCond();
            }
        }

        private void UpdateRes()
        {
            lvResulution.Items.Clear();
            foreach (var res in m_Rule.ResultList)
            {
                var lvi = new ListViewItem(new[]
                {
                    res.Var.Name + " = " + res.Value,
                })
                {
                    Tag = res
                };
                lvResulution.Items.Add(lvi);
            }
        }

        private void btnAddRes_Click(object sender, EventArgs e)
        {
            lvResulution.BackColor = Color.White;

            Fact fact = AddFact(false);
            if (fact != null)
            {
                m_Rule.ResultList.Add(fact);
                fact.Var.UseCount++;
                UpdateRes();
            }
        }

        private void EditFact(ref Fact fact, bool IsCondition)
        {
            AddEditFact frmEditFact = new AddEditFact() { CurFact = fact };
            frmEditFact.InitControls(true, IsCondition);
            if (frmEditFact.ShowDialog() == DialogResult.OK)
            {
                fact = frmEditFact.CurFact;
            }
        }

        private void btnEditRes_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvResulution.SelectedItems)
            {
                Fact CurFact = (Fact)selectedItem.Tag;
                EditFact(ref CurFact, false);
            }
            UpdateRes();
        }

        private void btnEditCondition_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvCondition.SelectedItems)
            {
                Fact CurFact = (Fact)selectedItem.Tag;
                EditFact(ref CurFact, true);
            }
            UpdateCond();
        }

        private void btnDelCondition_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvCondition.SelectedItems)
            {
                Fact CurFact = (Fact)selectedItem.Tag;
                CurFact.Var.UseCount--;
                m_Rule.ConditionList.Remove(CurFact);
            }
            UpdateCond();
        }

        private void btnDelRes_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvResulution.SelectedItems)
            {
                Fact CurFact = (Fact)selectedItem.Tag;
                CurFact.Var.UseCount--;
                m_Rule.ResultList.Remove(CurFact);
            }
            UpdateRes();
        }

        private bool IsValidRule()
        {
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.BackColor = Color.Red;
                return false;
            }

            if (MainForm.CurrentShell.CurrentExpertSystem.Rules.Any(x => x.Name == tbName.Text) && !m_bIsEditMode)
            {
                tbName.BackColor = Color.Red;
                return false;
            }

            if (lvCondition.Items.Count == 0)
            {
                lvCondition.BackColor = Color.Red;
                return false;
            }

            if (lvResulution.Items.Count == 0)
            {
                lvResulution.BackColor = Color.Red;
                return false;
            }

            return true;
        }

        protected override bool OnOK()
        {
            if (!IsValidRule()) return false;

            m_Rule.Name = tbName.Text;
            m_Rule.SetText();
            m_Rule.Reason = tbReason.Text;

            return true;
        }

        private void AddEditRule_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (m_IsOK)
            {
                case eClosingType.ctExit:
                    bool Res = true;
                    this.DialogResult = ExitDialog(ref Res);
                    if (!Res) e.Cancel = true;
                    break;
                case eClosingType.ctOK:
                    m_IsOK = eClosingType.ctExit;
                    break;
                case eClosingType.ctNotValid:
                    m_IsOK = eClosingType.ctExit;
                    e.Cancel = true;
                    break;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.BackColor == Color.Red)
                tbName.BackColor = Color.White;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            m_IsOK = eClosingType.ctOK;
        }
    }
}
