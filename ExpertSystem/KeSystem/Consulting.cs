using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ExpertSystem
{
    public class WorkRule
    {
        public bool IsWorkedRule { get; set; }
        public Rule WRule { get; set; }

        public WorkRule(Rule NRule) { WRule = NRule; IsWorkedRule = false; }
    }

    public class Consulting
    {
        public List<WorkRule> RuleList { get; set; }
        public Fact MainGoal { get; set; }

        public List<Fact> VarValues { get; set; }

        private ConsultForm m_Form;
        bool IsNotError = true;
        private ExpertSystem m_ExpertSystem;

        public Consulting()
        {
            VarValues = new List<Fact>();
            RuleList = new List<WorkRule>();
            MainGoal = new Fact();
        }

        void GetNextGoal(Fact CurGoal, int Index)
        {
            WorkRule WRule;
            //Ищем правило, которое означит текущую переменную
            for (; Index < m_ExpertSystem.Rules.Count; Index++)
            {
                Fact fact = m_ExpertSystem.Rules[Index].ResultList.Find(y => y.Var == CurGoal.Var);
                if (fact != null && fact.Var == CurGoal.Var) break;
            }
            //Если правило не найдено - выход с ошибкой
            if (Index == m_ExpertSystem.Rules.Count && CurGoal.Var.Type != eVarType.vtInpoutp)
            {
                IsNotError = false;
                return;
            }
            else
            {
                if(Index == m_ExpertSystem.Rules.Count && CurGoal.Var.Type == eVarType.vtInpoutp)
                {
                    m_Form.Invoke((MethodInvoker)delegate
                    {
                        m_Form.AddQuestion(CurGoal);
                    });
                    CurGoal.Value = m_Form.Answer;
                    VarValues.Add(CurGoal);
                    return;
                }
            }

            WRule = new WorkRule(m_ExpertSystem.Rules[Index]);
            foreach (var fact in WRule.WRule.ConditionList)
            {
                Fact Var = VarValues.Find(x => x.Var == fact.Var);
                //Переменная не означена, нужно запросить значение, делаем текущей посылкой
                if (Var == null)
                {
                    //запрашиваем
                    Var = new Fact();
                    Var.Var = fact.Var;
                    if (fact.Var.Type == eVarType.vtInput)
                    {
                        m_Form.Invoke((MethodInvoker)delegate
                        {
                            m_Form.AddQuestion(fact);
                        });
                        Var.Value = m_Form.Answer;
                        VarValues.Add(Var);
                    }
                    //или пробуем вывести
                    else
                    {
                        GetNextGoal(Var, 0);
                        Var = VarValues.Find(x => x.Var == fact.Var); 
                    }
                }

                if (!IsNotError) return;
                //если не равно, нужно искать новое правило (после текущего)
                if (Var.Value != fact.Value)
                {
                    WRule.IsWorkedRule = false;
                    GetNextGoal(CurGoal, Index + 1);
                    break;
                }

                WRule.IsWorkedRule = true;
                //Переменная с нужным значением, идем по правилу дальше
            }
            //Если правило сработало - означиваем заключения
            RuleList.Add(WRule);
            if (WRule.IsWorkedRule)
            {
                foreach(var res in  WRule.WRule.ResultList)
                {
                    VarValues.Add(res);
                }
            }

            if (!IsNotError) return;
            //Если текущая означена, сохраним - выйдем из рек. к след.
            if (CurGoal.Value != "") return;
        }

        public void GetNextQuestion()
        {
            GetNextGoal(MainGoal, 0);
            if (!IsNotError)
            {
                MainGoal.Value = "Система не смогла найти ответ, обратитесь к другой системе!";
                VarValues.Add(MainGoal);
            }
            MainGoal.Value = VarValues.Find(x => x.Var == MainGoal.Var).Value;
            m_Form.Invoke((MethodInvoker)delegate
            {
                m_Form.AddResult(MainGoal, RuleList, VarValues);
            });
        }

        public void StartConsult(ExpertSystem ExSystem)
        {
            m_ExpertSystem = ExSystem;
            m_Form = new ConsultForm(this);
            m_Form.ShowDialog();
        }

        public void GetLineOfReasoning()
        {
            m_Form.ShowDialog();
        }
    }
}
