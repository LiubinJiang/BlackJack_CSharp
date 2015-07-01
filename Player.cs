using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign_final
{
    class Player:BasePlayer
    {
        public Player()
        {
            this.Name = "Bambie";
            cardList = new Card[52];
            Points = 1000;
        }
        public Player(string name)
        {
            this.Name = name;
            cardList = new Card[52];
            Points = 1000;
        }
        public override bool GetNextCard()
        {
            Boolean calling = false;
            Console.WriteLine("是否继续叫牌（y/n）?y为继续，其他均为不叫");
            if (Console.ReadLine() == "y")
                calling = true;
            return calling;
        }

    }
}
