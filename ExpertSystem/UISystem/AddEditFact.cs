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
    public partial class AddEditFact : BaseForm
    {
        Fact m_Fact;
        bool m_IsCondition;

        public Fact CurFact
        {
            get { return m_Fact; }
            set { m_Fact = value; }
        }

        public void InitControls(bool IsEditMode, bool IsCondition)
        {
            m_IsCondition = IsCondition;
            foreach(var variable in MainForm.CurrentShell.CurrentExpertSystem.Vars)
            {
                if (IsCondition)
                {
                    cmbVar.Items.Add(variable);
                }
                else
                {
                    if(variable.Type == eVarType.vtOutput || variable.Type == eVarType.vtInpoutp)
                    {
                        cmbVar.Items.Add(variable);
                    }
                }
            }

            if (IsEditMode)
            {
                if(cmbVar.Items.Count > 0)  cmbVar.SelectedItem = m_Fact.Var;
                if (cmbValue.Items.Count > 0) cmbValue.SelectedItem = m_Fact.Value;
            }
            else
            {
                if(cmbVar.Items.Count > 0)  cmbVar.SelectedIndex = 0;
                if (cmbValue.Items.Count > 0) cmbValue.SelectedIndex = 0;
            }
        }

        public AddEditFact()
        {
            InitializeComponent();
        }

        private void cmbVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lVar.ForeColor = Color.Black;
            Variable Var = (Variable)cmbVar.SelectedItem;
            cmbValue.Items.Clear();
            foreach (var val in Var.Dom.Values)
            {
                cmbValue.Items.Add(val);
            }
            cmbValue.SelectedIndex = 0;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            m_IsOK = eClosingType.ctOK;
            if(!OnOK()) m_IsOK = eClosingType.ctNotValid;
        }

        private eClosingType m_IsOK = eClosingType.ctExit;
        protected override bool OnOK()
        {
            if (!IsValidFact()) return false;

            m_Fact.Var = (Variable)cmbVar.SelectedItem;
            m_Fact.Value = (string)cmbValue.SelectedItem;

            return true;
        }

        private void AddEditFact_FormClosing(object sender, FormClosingEventArgs e)
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

        bool IsValidFact()
        {
            if (cmbVar.SelectedItem == null)
            {
                lVar.ForeColor = Color.Red;
                return false;
            }
            if (cmbValue.SelectedItem == null)
            {
                lValue.ForeColor = Color.Red;
                return false;
            }

            return  true;
        }

        private void btnAddVar_Click(object sender, EventArgs e)
        {
            AddEditVar frmVar = new AddEditVar()
            {
                EditVar = new Variable()
            };

            frmVar.InitControls(false);

            if (frmVar.ShowDialog() == DialogResult.OK)
            {
                MainForm.CurrentShell.CurrentExpertSystem.AddOrEditVar(frmVar.EditVar, false, 0);
                if ((!m_IsCondition && frmVar.EditVar.Type != eVarType.vtInput) || m_IsCondition)
                {
                    cmbVar.Items.Add(frmVar.EditVar);
                    cmbVar.SelectedItem = frmVar.EditVar;
                }
            }
        }

        private void cmbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            lValue.ForeColor = Color.Black;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            m_IsOK = eClosingType.ctOK;
        }
    }
}
