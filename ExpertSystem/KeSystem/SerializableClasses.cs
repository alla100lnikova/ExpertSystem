using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    [Serializable]
    public class Domain
    {
        public string Name { get; set; }
        public List<string> Values { get; set; }
        public int UseCount { get; set; }

        public Domain()
        {
            Values = new List<string>();
        }

        public Domain (string Name, List<string> Values)
        {
            this.Name = Name;
            this.Values = Values;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public enum eVarType
    {
        vtInput = 1,
        vtOutput = 2,
        vtInpoutp = 3
    }

    [Serializable]
    public class Variable
    {
        public string Name { get; set; }
        public eVarType Type { get; set; }
        public Domain Dom { get; set; }
        public int UseCount { get; set; }
        public string Text { get; set; }

        public Variable() { }

        public Variable(string Name, eVarType Type, Domain Dom, string Text = "")
        {
            this.Name = Name;
            this.Type = Type;
            this.Dom = Dom;
            this.Text = Text;
        }

        public string VarTypeToString()
        {
            switch(Type)
            {
                case eVarType.vtInput: return "Запрашиваемая";
                case eVarType.vtOutput: return "Выводимая";
                case eVarType.vtInpoutp: return "Выводимо-запрашиваемая";
            }

            return "";
        }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class Fact
    {
        public Variable Var { get; set; }
        public string Value { get; set; }

        public Fact() { }

        public Fact(Variable Var, string Value)
        {
            this.Var = Var;
            this.Value = Value;
        }
    }

    [Serializable]
    public class Rule
    {
        public string Name { get; set; }
        public List<Fact> ConditionList { get; set; }
        public List<Fact> ResultList { get; set; }
        public string Reason { get; set; }
        private string m_Text;

        public string Text
        {
            get { return m_Text; }
        }

        public string SetText()
        {
            m_Text = "IF(" + ConditionList[0].Var.Name + " = " + ConditionList[0].Value;
            for (int i = 1, Count = ConditionList.Count; i < Count; i++)
            {
                m_Text += " AND " + ConditionList[i].Var.Name + " = " + ConditionList[i].Value;
            }

            m_Text += ") THEN " + ResultList[0].Var.Name + " = " + ResultList[0].Value;

            for (int i = 1, Count = ResultList.Count; i < Count; i++)
            {
                m_Text += ", " + ResultList[i].Var.Name + " = " + ResultList[i].Value;
            }

            return m_Text;
        }

        public Rule()
        {
            ConditionList = new List<Fact>();
            ResultList = new List<Fact>();
        }

        public Rule(string Name, List<Fact> ConditionList, List<Fact> ResultList, string Reason)
        {
            this.Name = Name;
            this.ConditionList = ConditionList;
            this.ResultList = ResultList;
            this.Reason = Reason;

            SetText();
        }
    }
}
