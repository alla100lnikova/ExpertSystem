using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ExpertSystem
{
    public partial class ConsultForm : Form
    {
        private Consulting m_Consult;
        Thread ConsultThread;
        bool IsOpen = false;

        public string Answer = "";

        public ConsultForm(Consulting Consult)
        {
            InitializeComponent();
            gbConsult.Text = "Цель консультации: " + Consult.MainGoal.Var.Name;
            m_Consult = Consult;    
        }

        public void InitControls()
        {
            IsOpen = true;
            ConsultThread = new Thread(delegate ()
            {
                m_Consult.GetNextQuestion();
            });
            ConsultThread.Start();
        }

        public void AddQuestion(Fact CurGoal)
        {
            ConsultThread.Suspend();
            cmbAnswer.Items.Clear();
            if (String.IsNullOrWhiteSpace(CurGoal.Var.Text)) lvDialog.Items.Add("Вопрос: " + CurGoal.Var.Name + ":");
            else lvDialog.Items.Add("Вопрос: " + CurGoal.Var.Text);

            foreach(var val in CurGoal.Var.Dom.Values)
            {
                cmbAnswer.Items.Add(val);
            }
            if(cmbAnswer.Items.Count != 0) cmbAnswer.SelectedIndex = 0;
        }

        public void BuildReasonTree(Fact Goal, List<WorkRule> Rules, List<Fact> Facts)
        {
            treeReason.Nodes.Add("Цель: " + Goal.Var.Name);
            foreach (var rule in Rules)
            {
                if (rule.IsWorkedRule)
                {
                    int i = treeReason.Nodes.Add(new TreeNode(rule.WRule.Name + ": " + rule.WRule.Text));
                    treeReason.Nodes[i].Nodes.Add(new TreeNode(rule.WRule.Reason));
                }
            }
            treeReason.Nodes.Add("Результат: " + Goal.Var.Name + " = " + Goal.Value);

            foreach (var fact in Facts)
            {
                var lvi = new ListViewItem(new[]
                {
                    fact.Var.Name,
                    fact.Value
                })
                {
                    Tag = fact
                };
                lvFacts.Items.Add(lvi);
            }
        }

        public void AddResult(Fact Goal, List<WorkRule> Rules, List<Fact> Facts)
        {
            lvDialog.Items.Add("");
            lvDialog.Items.Add("Результат консультации: " + Goal.Value);
            gbAnswer.Enabled = false;
            BuildReasonTree(Goal, Rules, Facts);
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Answer = (string)cmbAnswer.SelectedItem;
            lvDialog.Items.Add("Ответ: " + Answer);
            ConsultThread.Resume();
        }

        private void ConsultForm_Shown(object sender, EventArgs e)
        {
            if(!IsOpen) InitControls();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ConsultThread.ThreadState != ThreadState.Suspended)  ConsultThread.Abort();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            treeReason.ExpandAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeReason.CollapseAll();
        }
    }
}
