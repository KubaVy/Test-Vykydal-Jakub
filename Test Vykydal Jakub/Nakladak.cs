using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Vykydal_Jakub
{
    public class Nakladak
    {
        
        
        public int maxNosnost { get; set; }
        public int maxPalivo { get; set; }
        public int spotreba { get; set; }
        public int vzdalenost { get; set; }
        public int palivo { get; set; }
        public int naklad { get; set; }

        public Nakladak()
        {
            int maxNosnost = 3000;
            int maxpalivo = 1500;
            int spotreba = 50;
            int naklad = 0;
        }
        
    
    }
}
