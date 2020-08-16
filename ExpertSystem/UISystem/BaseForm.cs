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
    public partial class BaseForm : Form
    {
        public enum eClosingType
        {
            ctExit,
            ctOK,
            ctNotValid
        }

        public BaseForm()
        {
            InitializeComponent();
        }

        protected virtual bool OnOK() { return true; }

        protected DialogResult ExitDialog(ref bool Res)
        {
            DialogResult IsClose;
            DialogResult IsSave = MessageBox.Show("Сохранить изменения перед закрытием?", "Внимание!", MessageBoxButtons.YesNoCancel);//frmEditDom.ShowDialog();
            if (IsSave == DialogResult.Yes)
            {
                Res = true;
                IsClose = DialogResult.OK;
                if (!OnOK())
                {
                    Res = false;
                    IsClose = DialogResult.Cancel;
                }
            }
            else
            {
                Res = true;
                IsClose = DialogResult.Cancel;
                if (IsSave == DialogResult.Cancel)
                {
                    Res = false;
                    return IsClose;
                }
            }

            return IsClose;
        }
    }
}
