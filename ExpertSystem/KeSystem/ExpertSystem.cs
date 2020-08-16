using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    [Serializable]
    public class ExpertSystem
    {
        public List<Domain> Domains { get; set; }
        public List<Rule> Rules { get; set; }
        public List<Variable> Vars { get; set; }

        public ExpertSystem()
        {
            Domains = new List<Domain>();
            Rules = new List<Rule>();
            Vars = new List<Variable>();
        }

        public void InsertRule(int Out, int In)
        {
            Rule CurRule = Rules[Out];
            Rules.Remove(CurRule);
            AddOrEditRule(CurRule, false, In);
        }

        public void AddOrEditRule(Rule NewRule, bool IsEditMode, int Index)
        {
            if(IsEditMode)
            {
                Rules[Index - 1] = NewRule;
            }
            else
            {
                if (Index != 0 && Index < Rules.Count)
                {
                    Rules.Insert(Index, NewRule);
                }
                else
                {
                    Rules.Add(NewRule);
                }
            }
        }

        public void AddOrEditVar(Variable NewVar, bool IsEditMode, int Index = 0)
        {
            if(IsEditMode)
            {
                Vars[Index] = NewVar;
            }
            else
            {
                Vars.Add(NewVar);
            }
        }

        public void AddOrEditDomain(Domain NewDom, bool IsEditMode, int Index = 0)
        {
            if (IsEditMode)
            {
                Domains[Index] = NewDom;
            }
            else
            {
                Domains.Add(NewDom);
            }
        }

        public void DeleteRule(Rule DelRule)
        {
            foreach(var fact in DelRule.ConditionList)
            {
                fact.Var.UseCount--;
            }

            foreach (var fact in DelRule.ResultList)
            {
                fact.Var.UseCount--;
            }

            Rules.Remove(DelRule);
        }

        public void DeleteVar(Variable DelVar)
        {
            if (DelVar.UseCount == 0)
            {
                DelVar.Dom.UseCount--;
                Vars.Remove(DelVar);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Невозможно удалить переменную, она используется в правилах!");
            }
        }

        public void DeleteDomain(Domain DelDom)
        {
            if (DelDom.UseCount == 0)
            {
                Domains.Remove(DelDom);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Невозможно удалить домен, он используется в переменных!");
            }
        }
    }
}
