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
    public partial class AddEditDomain : BaseForm
    {
        static Domain m_Dom;
        bool m_bIsEditMode = false;

        public Domain EditDom
        {
            get { return m_Dom; }
            set { m_Dom = value; }
        }

        private void UpdateVal()
        {
            lvValues.Items.Clear();
            foreach (var val in m_Dom.Values)
            {
                var lvi = new ListViewItem(new[]
                {
                        val,
                    })
                {
                    Tag = val
                };
                lvValues.Items.Add(lvi);
            }
        }

        public void InitControls()
        {
            tbName.Text = m_Dom.Name;
            UpdateVal();
            m_bIsEditMode = true;
            btnAddValue.Enabled = btnDelValue.Enabled = btnEditValue.Enabled = lvValues.Enabled = m_Dom.UseCount <= 1;
        }


        public static void DomainValueEdit(int Out, int In)
        {
            string CurVal = m_Dom.Values[Out];
            m_Dom.Values.Remove(CurVal);
            m_Dom.Values.Insert(In, CurVal);
        }

        public AddEditDomain()
        {
            InitializeComponent();
            tbName.Text = "Dom" + (MainForm.CurrentShell.CurrentExpertSystem.Domains.Count + 1);
        }

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            lvValues.BackColor = Color.White;

            if(String.IsNullOrWhiteSpace(tbVal.Text))
            {
                MessageBox.Show("Значение не должно быть пустым!");
                return;
            }

            if (m_Dom.Values.Any(x => tbVal.Text == x)) MessageBox.Show("Значение уже существует в данном домене!");
            else
            {
                m_Dom.Values.Add(tbVal.Text);
                UpdateVal();
                tbVal.Text = "";
            }
        }

        private void btnEditValue_Click(object sender, EventArgs e)
        {
            if (lvValues.SelectedItems.Count != 0)
            {
                int Index = lvValues.SelectedItems[0].Index;
                m_Dom.Values[Index] = tbVal.Text;
                UpdateVal();
                tbVal.Text = "";
            }
        }

        private void btnDelValue_Click(object sender, EventArgs e)
        {
            if (lvValues.SelectedItems.Count != 0)
            {
                string Val = (string)lvValues.SelectedItems[0].Tag;
                m_Dom.Values.Remove(Val);
                UpdateVal();
                tbVal.Text = "";
                //возможно надо проверять, где используется
            }
        }

        private void lvValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvValues.SelectedItems.Count != 0)
            {
                tbVal.Text = (string)lvValues.SelectedItems[0].Tag;
            }
        }

        private bool IsValidDom()
        {
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.BackColor = Color.Red;
                return false;
            }

            if (MainForm.CurrentShell.CurrentExpertSystem.Domains.Any(x => x.Name == tbName.Text) && !m_bIsEditMode)
            {
                tbName.BackColor = Color.Red;
                return false;
            }

            if (lvValues.Items.Count == 0)
            {
                lvValues.BackColor = Color.Red;
                return false;
            }

            return true;
        }

        protected override bool OnOK()
        {
            if (!IsValidDom()) return false;

            m_Dom.Name = tbName.Text;
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

        private void AddEditDomain_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch(m_IsOK)
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
