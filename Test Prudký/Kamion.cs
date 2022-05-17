using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Prudký
{
    internal class Kamion
    {
        public int maxcarry { get; }
        public int maxfuel { get; }
        public int consum { get; }
        public int distance { get; }
        public int curentcarry { get; set; }
        public int curentfuel { get; set; }

        public Kamion(int nosnost, int nadrz, int spotreba)
        {
            maxfuel = nadrz;
            consum = spotreba;
            maxcarry = nosnost;
            distance = 0;
            curentcarry = 0;
            curentfuel = 0;



        }
        
    


        
    }
    
   

}
