using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assign_final
{
    public partial class GameForm : Form
    {
        //全局变量
        private PictureBox[] banker_card;
        private PictureBox[] player_card;

        BasePlayer player;
        BasePlayer banker;

        public int bet;
        public Card banker_hidden = new Card();
        public Deck deck;

        //构造函数
        public GameForm()
        {
            InitializeComponent();
        }
        public GameForm(string name)
        {
            InitializeComponent();
            player_name.Text = name;
            player_name.Show();

            banker_card = new PictureBox[5];
            player_card = new PictureBox[5];

            banker = new Banker("CPU");
            player = new Player(name);

            deck = new Deck();
            bet = 50;

            InitBankerBox(banker_card, new Point(670, 120), new Size(85, 110));
            InitPlayerBox(player_card, new Point(93, 352), new Size(85, 110));
        }


        //初始化庄家牌位置
        public void InitBankerBox(PictureBox[] pcs, Point p, Size s)
        {
            for (int i = 0; i < pcs.Length; i++)
            {
                pcs[i] = new PictureBox();
                pcs[i].Location = new Point(p.X - i * 40, p.Y);
                pcs[i].Size = s;
                this.Controls.Add(pcs[i]);
            }
        }
        //初始化玩家牌位置
        public void InitPlayerBox(PictureBox[] pcs, Point p, Size s)
        {
            for (int i = 0; i < pcs.Length; i++)
            {
                pcs[i] = new PictureBox();
                pcs[i].Location = new Point(p.X + i * 40, p.Y);
                pcs[i].Size = s;
                this.Controls.Add(pcs[i]);
            }
        }
        //赌注
        private void button1_Click(object sender, EventArgs e)
        {
            bet = 50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bet = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bet = 150;
        }
        //游戏函数：newround
        private void NewRound()
        {
            player.StartNextRound();
            banker.StartNextRound();
            deck = new Deck();
            bet = 0;
            for (int i = 0; i < 5; i++)
            {
                banker_card[i].Image = null;
                player_card[i].Image = null;
            }
        }
        //游戏函数：比较大小
        private void ComparedTo()
        {
            if (player.TotalRanks < banker.TotalRanks)
                RoundOverAndWin(banker.Name, bet);
            if (player.TotalRanks > banker.TotalRanks)
                RoundOverAndWin(player.Name, bet);
            if (player.TotalRanks == banker.TotalRanks)
                RoundOverAndTie();
        }
        private void RoundOverAndWin(string wonName, int bet)
        {
            
            
            if (wonName == player.Name)
            {
                player.Points += bet;
                banker.Points -= bet;
                string pp = player.Points.ToString();
                string bp = banker.Points.ToString();
                
                CPU_point.Text = pp;
                player_point.Text = bp;
            }
            if (wonName == banker.Name)
            {
               
                banker.Points += bet;
                player.Points -= bet;
                string pp = player.Points.ToString();
                string bp = banker.Points.ToString();
                CPU_point.Text = pp;
                player_point.Text =bp;
            }
            
            DialogResult dr = MessageBox.Show(wonName + " wins！是否继续游戏", "游戏结束", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                Begin_btn_pic.Show();
            }
            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }
        private void RoundOverAndTie()
        {
            MessageBox.Show("平局","游戏结束");
        }

        private void Calling_Click(object sender, EventArgs e)
        {
            Card c = new Card();
            c = deck.nextCard();
            player.GetACard(c);
            player_card[player.Card_count - 1].Image = card_list.Images[c.CardIndex];
            player_ranks.Text = player.TotalRanks.ToString();
            if (player.WinOrNot() == 1)
                RoundOverAndWin(player.Name, bet);
            if (player.WinOrNot() == -1)
                RoundOverAndWin(banker.Name, bet);
                       
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            banker_card[1].Image = card_list.Images[banker_hidden.CardIndex];
            if (!banker.GetNextCard() && banker.WinOrNot() == 0)
            {
                ComparedTo();
            }
            else
            {
                while (banker.GetNextCard() && player.WinOrNot() == 0)
                {
                    MessageBox.Show("庄家不够16点，补牌中");
                    if (banker.WinOrNot() == 0)
                    {
                        Card c=new Card();
                        c=deck.nextCard();
                        banker.GetACard(c);
                        banker_card[banker.Card_count - 1].Image = card_list.Images[c.CardIndex];
                        banker_ranks.Text = banker.TotalRanks.ToString();
                        if (banker.WinOrNot() == 1)
                            RoundOverAndWin(banker.Name, bet);
                        if (banker.WinOrNot() == -1)
                            RoundOverAndWin(player.Name, bet);
                    }
                    else
                    {
                        break;
                    }
                }
                 if (banker.WinOrNot() == 0 && player.WinOrNot() == 0)
                 {
                      ComparedTo();
                 }
                 

            }
                           
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void begin_game_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void begin_game_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Begin_btn_pic_MouseEnter(object sender, EventArgs e)
        {
            Begin_btn_pic.Image = changing_list.Images[1];
        }

        private void Begin_btn_pic_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Begin_btn_pic_MouseLeave(object sender, EventArgs e)
        {
            Begin_btn_pic.Image = changing_list.Images[0];
        }

        private void Begin_btn_pic_Click(object sender, EventArgs e)
        {
            if (player.Points >= bet && banker.Points >= bet)
            {
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                Begin_btn_pic.Hide();
                NewRound();
                //开局每人人分两张牌
                Card c = new Card();

                c = deck.nextCard();
                player.GetACard(c);
                player_card[0].Image = card_list.Images[c.CardIndex];

                c = deck.nextCard();
                banker.GetACard(c);
                banker_card[0].Image = card_list.Images[c.CardIndex];

                c = deck.nextCard();
                player.GetACard(c);
                player_card[1].Image = card_list.Images[c.CardIndex];


                banker_hidden = deck.nextCard();
                banker.GetACard(banker_hidden);
                //banker_card[1].Image = card_list.Images[c.CardIndex];
                banker_card[1].Image = card_list.Images[52];

                player_ranks.Text = player.TotalRanks.ToString();
                banker_ranks.Text = "未知";
            }
            else
                MessageBox.Show("游戏结束", "点数不足，游戏结束", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void 关于游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        


   


        
    }//end form
}//end namespace
