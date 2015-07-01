using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign_final
{
        public enum CardRank
        {
            ACE,TWO,THREE,FORE,FIVE,SIX,SEVEN,EIGHT,NINE,TEN,JACK,QUEEN,KING
        }
        //花色
        public enum CardColor
        {
            HEART, BLACK, DIAMOND, CLUB
        }

    public class Card
    {
            readonly CardRank rank;
            readonly CardColor color;

            //获取点数
            public CardRank Rank
            {
                get{ return rank;}
            }

            //获取花色
            public CardColor Color
            {
                get { return color; }               
            }
            
            //显示一张牌
            public string Cardstr
            {
                get
                {

                        return ((char)((int)color+3)).ToString()+" " + rank.ToString();
                        
                }
            }

            public int CardIndex
            {
                get
                {
                    return ((int)color)*13+(int)rank;
                }
            }

            //无参构造
            public Card()
            {
                rank = (CardRank)0;
                color = (CardColor)0;
            }
            public Card(CardRank rank,CardColor color)
            {
                this.rank=rank;
                this.color=color;
            }
    }
}
