using System;
using System.Collections.Generic;
using System.Text;

namespace kur
{
    public class consumption
    {
        public string NameConsumption { get; set; }
        public int SumConsumption { get; set; }

        public consumption()
        {

        }
        public consumption(string nameConsumption, int sumConsumption)
        {
            NameConsumption = nameConsumption;
            SumConsumption = sumConsumption;
        }
    }


}
