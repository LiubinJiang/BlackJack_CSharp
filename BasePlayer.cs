using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign_final
{
    class BasePlayer
    {
         //字段
        private string name;
        protected Card[] cardList;
        private int points;
        private int card_count;

        //属性
        public string Name
        {
            get { return name; }
            protected set
            {
                name = value;
            }
        }
        public int Card_count
        {
            get { return card_count; }
        }
        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        public int TotalRanks
        {
            get
            {
                int ranks = 0;
                for (int i = 0; i < card_count; i++)
                {
                    Card card = cardList[i];
                    if ((int)(card.Rank) <= 9)
                    {
                        ranks += (int)card.Rank+1;
                    }
                    else
                    {
                        ranks += 10;
                    }
                }
                return ranks;
            }
        }

        //构造方法
        public BasePlayer()
        {
            this.name = "Bambie";
            cardList = new Card[52];
            Points = 0;
        }
        public BasePlayer(string name)
        {
            this.name = name;
            cardList=new Card[52];
            Points = 0;
        }
        public BasePlayer(string name,int points)
        {
            this.name = name;
            this.Points = points;
            cardList=new Card[52];
        }

        //方法
        //收到牌后判断输赢
        public void GetACard(Card next_card)
        {
            cardList[card_count] = next_card;
            card_count++;
        }
        //收到牌后判断输赢
        public int WinOrNot()
        {
            if (TotalRanks == 21)
                return 1;
            if (TotalRanks > 21)
                return -1;
            if (card_count == 5 && TotalRanks < 21)
                return 1;
            return 0;
        }
        //显示手中的牌
        public void ShowAll()
        {
            Console.WriteLine(this.name + ":");
            for (int i = 0; i < card_count; i++)
            {
                Console.Write(cardList[i].Cardstr);
                Console.Write("\t");
            }
        }
        //得到下一张牌

        public virtual bool GetNextCard()
        {
            return false;
        }
 
        public void StartNextRound()
        {
            this.cardList = new Card[52];
            card_count = 0;
        }
        public void ShowNow()
        {
            Console.WriteLine("庄家手中牌:");
            for (int i = 1; i < card_count; i++)
            {
                Console.WriteLine(cardList[i].Cardstr);
            }
        }
    }
}
