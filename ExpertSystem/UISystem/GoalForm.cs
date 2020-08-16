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
    public partial class GoalForm : Form
    {
        Variable m_Var;
        public GoalForm()
        {
            InitializeComponent();
            
            foreach(Variable var in MainForm.CurrentShell.CurrentExpertSystem.Vars)
            {
                if(var.Type == eVarType.vtOutput || var.Type == eVarType.vtInpoutp)
                {
                    cmbGoal.Items.Add(var);
                }
            }

            if (cmbGoal.Items.Count == 0)
            {
                btnOK.Enabled = false;
                return;
            }
            if (m_Var == null) cmbGoal.SelectedIndex = 0;
            else cmbGoal.SelectedItem = m_Var;
        }

        public Variable Goal
        {
            get { return (Variable)cmbGoal.SelectedItem; }
            set { m_Var = value; }
        }
    }
}
