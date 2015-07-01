using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign_final
{
    public class Deck
    {
        Card[] allCards;
        int count;

        //剩余数量
        public int CardCount
        {
            get
            {
                return count;
            }
        }
        
        //下一张牌
        public Card nextCard()
        {
            int remain=count;
            Card next_card;
            Random ran=new Random();
            int temp=ran.Next(52);
            while(allCards[temp]== null)
            {
                temp=ran.Next(52);
            }
            next_card = allCards[temp];
            allCards[temp] = null;
            count--;
            return next_card;
        }


        //创建一副牌
        public Deck()
        {
            allCards = new Card[52];
            this.count = 52;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 13; i++)
                {
                    allCards[i + j * 13] = new Card((CardRank)i, (CardColor)j);
                }//点数
            }//花色
        }
        public void show()
        {
            for (int i = 0; i < 52; i++)
            {
                if (allCards[i] != null)
                {
                    Console.WriteLine(allCards[i].Cardstr);
                }
                else
                {
                    Console.WriteLine("null");
                }
            }
        }

        




    }//end of class
}

