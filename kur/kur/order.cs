using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace kur
{
    public class order
    {
        public string Name { get; set; }
        public int sumOrder { get; set; }
        public int sumPrepayment { get; set; }
        public int costInstal { get; set; }
        public int Expemses { get; set; }
        public ObservableCollection<consumption> Cons {get; set;}
        public order()
        {

        }
        public order(string name, int sumorder, int sumprepayment, int costinstal, int expemses)
        {
            Name = name;
            sumOrder = sumorder;
            sumPrepayment = sumprepayment;
            costInstal = costinstal;
            Expemses = expemses;

        }
    }
}
