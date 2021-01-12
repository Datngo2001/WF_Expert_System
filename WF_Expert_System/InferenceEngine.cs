using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WF_Expert_System
{
    class InferenceEngine
    {
        protected List<Parameter> facts = new List<Parameter>();
        public List<Parameter> Facts 
        {
            get { return facts; }
            set { facts = Facts; } 
        }
        public KnowledgeBase Base { get; set; }
        public InferenceEngine()
        {

        }
        public InferenceEngine(KnowledgeBase knowledgeBase)
        {
            this.Base = knowledgeBase;
        }
        public void Start()
        {
            do
            {
                for (int i = 0; i < Base.Rules.Count; i++)
                {
                    if (isRelated(Base.Rules[i].Conditions))
                    {
                        int satifyCondition = 0;
                        for (int j = 0; j < Base.Rules[i].Conditions.Count; j++)
                        {
                            if (!isAsked(Base.Rules[i].Conditions[j]))
                            {
                                bool answer = askPeople(Base.Rules[i].Conditions[j]);
                                if (Base.Rules[i].Conditions[j].Value != answer)
                                {
                                    Parameter fact = new Parameter();
                                    fact.Name = Base.Rules[i].Conditions[j].Name;
                                    fact.Value = answer;
                                    Facts.Add(fact);
                                }
                                else
                                {
                                    satifyCondition++;
                                    Facts.Add(Base.Rules[i].Conditions[j]);
                                }
                            }else if (isExist(Base.Rules[i].Conditions[j]))
                            {
                                satifyCondition++;
                            }
                        }
                        double percentSatify = (double)satifyCondition / (double)Base.Rules[i].Conditions.Count;
                        if (percentSatify >= 0.5 && !isExist(Base.Rules[i].Result))
                        {
                            Facts.Add(Base.Rules[i].Result);
                        }
                    }
                }
            } while (FactIncrease());

        }
        public string ShowResult()
        {
            string a = "";
            string b = "";
            for (int i = 0; i < Facts.Count; i++)
            {
                if (Facts[i].Name.EndsWith('*') && Facts[i].Value == true)
                {
                    a += Facts[i].Name.Remove(Facts[i].Name.Length - 1, 1) + "\n";
                }
            }
            Console.WriteLine();
            Console.WriteLine("Ban nen: ");
            for (int i = 0; i < Facts.Count; i++)
            {
                if (Facts[i].Name.EndsWith('+') && Facts[i].Value == true)
                {
                    b += Facts[i].Name.Remove(Facts[i].Name.Length - 1, 1) + "\n";
                }
            }
            return a + "?" + b;
        }
        protected bool askPeople(Parameter parameter)
        {
            string question = "";
            question = "Ban co " + parameter.Name + " khong? (Co/Khong)";
            DialogResult answer = MessageBox.Show(question, "Question", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected int lastCount = 0;
        protected bool FactIncrease()
        {
            if(Facts.Count > lastCount)
            {
                lastCount = Facts.Count;
                return true;
            }
            return false;
        }
        protected bool ToBool(string value)
        {
            if (value == "Co" || value == "co" || value == "yes" || value == "Yes")
            {
                return true;
            }
            else if (value == "Khong" || value == "khong" || value == "No" || value == "no")
            {
                return false;
            }
            return false;
        }
        protected bool isExist(Parameter parameter)
        {
            for (int i = 0; i < Facts.Count; i++)
            {
                if(parameter.Name == Facts[i].Name && parameter.Value == Facts[i].Value)
                {
                    return true;
                }
            }
            return false;
        }
        protected bool isRelated(List<Parameter> conditions)
        {
            for (int i = 0; i < conditions.Count; i++)
            {
                if (isExist(conditions[i]))
                {
                    return true;
                }
                else
                {
                    
                }
            }
            return false;
        }
        protected bool isAsked(Parameter parameter)
        {
            for (int i = 0; i < Facts.Count; i++)
            {
                if (parameter.Name == Facts[i].Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
