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
    public partial class AddEditVar : BaseForm
    {
        Variable m_Var;
        bool m_bIsEditMode;

        public Variable EditVar
        {
            get { return m_Var; }
            set { m_Var = value; }
        }

        public void InitControls(bool IsEditMode)
        {
            m_bIsEditMode = IsEditMode;
            foreach (var dom in MainForm.CurrentShell.CurrentExpertSystem.Domains)
            {
                cmbDom.Items.Add(dom);
                cmbDom.ValueMember = dom.Name;
            }

            if (IsEditMode)
            {
                if (cmbDom.Items.Count > 0) cmbDom.SelectedItem = m_Var.Dom;

                tbName.Text = m_Var.Name;
                tbQuestion.Text = m_Var.Text;

                chbInp.Checked = m_Var.Type == eVarType.vtInput || m_Var.Type == eVarType.vtInpoutp;
                chbOut.Checked = m_Var.Type == eVarType.vtOutput || m_Var.Type == eVarType.vtInpoutp;

                cmbDom.Enabled = btnAddDomain.Enabled = btnEditDomain.Enabled = m_Var.Dom.UseCount <= 1;
            }
            else
            {
                tbName.Text = "Var" + (MainForm.CurrentShell.CurrentExpertSystem.Vars.Count + 1);
                if(cmbDom.Items.Count > 0) cmbDom.SelectedIndex = 0;
                chbInp.Checked = true;
            }
        }

        public AddEditVar()
        {
            InitializeComponent();
        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            AddEditDomain frmDom = new AddEditDomain()
            {
                EditDom = new Domain()
            };

            if (frmDom.ShowDialog() == DialogResult.OK)
            {
                MainForm.CurrentShell.CurrentExpertSystem.AddOrEditDomain(frmDom.EditDom, false);
                cmbDom.SelectedIndex = cmbDom.Items.Add(frmDom.EditDom);
            }
        }

        private void btnEditDomain_Click(object sender, EventArgs e)
        {
            Domain Dom = (Domain)cmbDom.SelectedItem;
            bool IsEditMode = true;
            AddEditDomain frmDom = new AddEditDomain() 
            {
                EditDom = Dom
            };

            bool IsCopy = false;
            if (Dom.UseCount > 1)
            {
                DialogResult Res = MessageBox.Show("Домен используется в переменных, его значения нельзя изменять! Создать копию?", "Внимание!", MessageBoxButtons.YesNo);
                switch (Res)
                {
                    case DialogResult.Yes:
                        IsCopy = true;
                        frmDom = new AddEditDomain()
                        {
                            EditDom = new Domain(Dom.Name + "_COPY", Dom.Values)
                        };
                        break;
                    default: break;
                }
            }

            if (IsEditMode) frmDom.InitControls();

            if (frmDom.ShowDialog() == DialogResult.OK)
            {
                if (IsCopy) IsEditMode = false;
                MainForm.CurrentShell.CurrentExpertSystem.AddOrEditDomain(frmDom.EditDom, IsEditMode, cmbDom.SelectedIndex);
                cmbDom.Items.Add(frmDom.EditDom);
                cmbDom.SelectedItem = frmDom.EditDom;
            }
        }

        private void cmbDom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Domain Dom = (Domain)cmbDom.SelectedItem;
            lvValues.Items.Clear();
            foreach (string val in Dom.Values)
            {
                var lvi = new ListViewItem(new[]
                {
                    val
                })
                {
                    Tag = val
                };
                lvValues.Items.Add(lvi);
            }
        }

        protected override bool OnOK()
        {
            if (!IsValidVar()) return false;

            m_Var.Dom = (Domain)cmbDom.SelectedItem;
            m_Var.Name = tbName.Text;
            m_Var.Text = tbQuestion.Text;
            m_Var.Dom.UseCount++;

            if (chbInp.Checked && chbOut.Checked) m_Var.Type = eVarType.vtInpoutp;
            else
            {
                if (chbInp.Checked) m_Var.Type = eVarType.vtInput;
                else m_Var.Type = eVarType.vtOutput;
            }

            return true;
        }

        private bool IsValidVar()
        {
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.BackColor = Color.Red;
                return false;
            }

            if(MainForm.CurrentShell.CurrentExpertSystem.Vars.Any(x=>x.Name == tbName.Text) && !m_bIsEditMode)
            {
                tbName.BackColor = Color.Red;
                return false;
            }

            if(!chbInp.Checked && !chbOut.Checked)
            {
                gbType.ForeColor = Color.Red;
                return false;
            }

            return true;
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

        private void AddEditVar_FormClosing(object sender, FormClosingEventArgs e)
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

        private void chbInp_CheckedChanged(object sender, EventArgs e)
        {
            gbType.ForeColor = Color.Black;
            tbQuestion.Enabled = chbInp.Checked;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.BackColor == Color.Red)
                tbName.BackColor = Color.Black;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            m_IsOK = eClosingType.ctOK;
        }
    }
}
