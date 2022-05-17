using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Vykydal_Jakub
{
    class Nakladak
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
        public void Nalozit()
        {
            int naklad =+ 1000;
            if (maxNosnost == 3000)
            {
                naklad =+ 0;
            }
        }
        public void Vylozit()
        {
            int naklad =- 1000;
            if(naklad == 0)
            {
                naklad =-0;
            }
        }
    
    }
}
