using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ExpertSystem
{
    public class Shell
    {
        public ExpertSystem CurrentExpertSystem { get; set; }
        public Consulting ConsultCache { get; set; }

        public Shell()
        {
            CurrentExpertSystem = new ExpertSystem();
        }

        public void LoadSystem(string FileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream stream = File.Open(FileName, FileMode.Open))
            {
                CurrentExpertSystem = (ExpertSystem)formatter.Deserialize(stream); 
            }
        }

        public void CreateSystem()
        {
            CurrentExpertSystem = new ExpertSystem();
        }

        public void StartConsult(Variable Goal)
        {
            ConsultCache = new Consulting();
            ConsultCache.MainGoal.Var = Goal;
            ConsultCache.StartConsult(CurrentExpertSystem);
        }

        public void SaveSystem(string FileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream stream = File.Open(FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, CurrentExpertSystem); 
            }
        }
    }
}
