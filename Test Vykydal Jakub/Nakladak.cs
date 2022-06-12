using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Vykydal_Jakub
{
    public class Nakladak
    {


        public int MaxNosnost { get; set; }
        public int MaxPalivo { get; set; }
        public int Spotreba { get; set; }
        public int Vzdalenost { get; set; }
        public int Palivo { get; set; }
        public int Naklad { get; set; }
        
        public Nakladak()
        {
            MaxNosnost = 3000;
            MaxPalivo = 150;
            Naklad = 0;
            Vzdalenost = 0;
            Palivo = 150;
            Spotreba = 0;
        }
        public void Nalozit()
        {
            if(Naklad < 3000)
            {
                Naklad += 1000;
            }
            else if(Naklad == 3000)
            {
                Naklad += 0;
            }
        }
        public void Vylozit()
        {
            if (Naklad > 0)
            {
                Naklad -= 1000;
            }
            else if (Naklad == 0)
            {
                Naklad -= 0;
            }
        }
        public void Jizda()
        {
            
            if (Palivo > 0)
            {
                Vzdalenost += 100;
                Palivo -= 30;
            }
            
            else if(Palivo == 0)
            {
                Vzdalenost += 0;
            }
        }

        public void SpoTreba()
        {
            if (Palivo == 0)
            {
                Spotreba = 0;
            }
            else if (Naklad >= 2000)
            {
                Spotreba = 50;
            }
            else if (Naklad < 2000)
            {
                Spotreba = 40;
            }
            else if(Naklad <= 1000)
            {
                Spotreba = 30;
            }
        }
        public void Natankovat()
        {
            if(Palivo < 150)
            {
                Palivo += 30;
            }
            if(Palivo == 150)
            {
                Palivo += 0;
            }
        }
    }
}
