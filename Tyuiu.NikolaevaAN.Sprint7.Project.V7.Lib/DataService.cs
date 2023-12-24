using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.NikolaevaAN.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public int CountPersons(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
