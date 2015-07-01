using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign_final
{
    class Banker:BasePlayer
    {
        public Banker()
        {
            this.Name = "CPU";
            this.Points = 1000;
            this.cardList =new Card[52];
        }
        public Banker(string name)
        {
            this.Name = name;
            this.Points = 1000;
            this.cardList = new Card[52];
        }
 
        public override bool GetNextCard()
        {
            bool weather = false;
            if (TotalRanks < 16)
                weather = true;
            return weather;
        }

    }
}
