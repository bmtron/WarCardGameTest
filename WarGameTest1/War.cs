using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace WarGameTest1
{
    public partial class War : Form
    {
        public Deck deck = new Deck();
        public List<Card> shuff;
        public Player p1 = new Player();
        public Computer c1 = new Computer();
        public List<Card> cardPool = new List<Card>();
        public War()
        {
            InitializeComponent();


            playButton.Visible = false;
            restartButton.Visible = false;

            deck.populateDeck();

            shuff = deck.shuffleDeck();
            Console.WriteLine(shuff.Count());
            p1.getPlayerCards(shuff);
            
            c1.getCompCards(shuff);
            Console.WriteLine(c1.cardSize);

            cCardActual.Text = c1.cardSize.ToString();
            pCardActual.Text = p1.cardSize.ToString();

            
        }

        private void War_Load(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            
            c1.getDeckSize();
            p1.getDeckSize();
            pCardActual.Text = p1.cardSize.ToString();
            cCardActual.Text = c1.cardSize.ToString();

            Card tempPlayer = p1.playerCards[0];
            Card tempComp = c1.compCards[0];
            gameBox.Text += Environment.NewLine + "Player plays a " + tempPlayer.Name + " and the computer plays a " + tempComp.Name;
            cardPool.Add(p1.playerCards[0]);
            cardPool.Add(c1.compCards[0]);

            p1.playerCards.RemoveAt(0);
            c1.compCards.RemoveAt(0);

            if (tempComp.Value > tempPlayer.Value)
            {
                gameBox.Text += Environment.NewLine + "Computer wins the hand!";

                foreach (Card c in cardPool.ToList())
                {
                    c1.compCards.Add(c);
                    cardPool.Remove(c);
                }
            }
            else if (tempPlayer.Value > tempComp.Value)
            {
                
                gameBox.Text += Environment.NewLine + "Player wins the hand!";
                foreach (Card c in cardPool.ToList())
                {
                    p1.playerCards.Add(c);
                    cardPool.Remove(c);
                }
            }
            else if (tempPlayer.Value == tempComp.Value)
            {
                Console.WriteLine(cardPool.Count());
                tempPlayer = p1.playerCards[1];
                tempComp = c1.compCards[1];

                cardPool.Add(p1.playerCards[0]);
                cardPool.Add(p1.playerCards[1]);

                cardPool.Add(c1.compCards[0]);
                cardPool.Add(c1.compCards[1]);

               
                p1.playerCards.RemoveAt(0);
                p1.playerCards.RemoveAt(0);

                c1.compCards.RemoveAt(0);
                c1.compCards.RemoveAt(0);

                gameBox.Text += Environment.NewLine + "Player plays a " + tempPlayer.Name + " and the computer plays a " + tempComp.Name;

                if (tempPlayer.Value > tempComp.Value)
                {
                    Console.WriteLine(cardPool.Count());
                    gameBox.Text += Environment.NewLine + "Player wins the hand!";
                    foreach (Card c in cardPool.ToList())
                    {
                        p1.playerCards.Add(c);
                        cardPool.Remove(c);
                    }
                    Console.WriteLine(cardPool.Count());
                }
                else if (tempComp.Value > tempPlayer.Value)
                {
                    Console.WriteLine(cardPool.Count());
                    gameBox.Text += Environment.NewLine + "Computer wins the hand!";

                    foreach (Card c in cardPool.ToList())
                    {
                        c1.compCards.Add(c);
                        cardPool.Remove(c);
                    }
                    Console.WriteLine(cardPool.Count());
                }
                else if (tempPlayer.Value == tempComp.Value)
                {
                    while (tempComp.Value == tempPlayer.Value)
                    {
                        
                        tempPlayer = p1.playerCards[1];
                        tempComp = c1.compCards[1];

                        cardPool.Add(p1.playerCards[0]);
                        cardPool.Add(p1.playerCards[1]);

                        cardPool.Add(c1.compCards[0]);
                        cardPool.Add(c1.compCards[1]);


                        p1.playerCards.RemoveAt(0);
                        p1.playerCards.RemoveAt(1);

                        c1.compCards.RemoveAt(0);
                        c1.compCards.RemoveAt(1);

                        gameBox.Text += Environment.NewLine + "Player plays a " + tempPlayer.Name + " and the computer plays a " + tempComp.Name;
                    }
                    if (tempPlayer.Value > tempComp.Value)
                    {
                        Console.WriteLine(cardPool.Count());
                        gameBox.Text += Environment.NewLine + "Player wins the hand!";
                        foreach (Card c in cardPool.ToList())
                        {
                            p1.playerCards.Add(c);
                            cardPool.Remove(c);
                        }
                        Console.WriteLine(cardPool.Count());
                    }
                    else if (tempComp.Value > tempPlayer.Value)
                    {
                        Console.WriteLine(cardPool.Count());
                        gameBox.Text += Environment.NewLine + "Computer wins the hand!";

                        foreach (Card c in cardPool.ToList())
                        {
                            c1.compCards.Add(c);
                            cardPool.Remove(c);
                        }
                        Console.WriteLine(cardPool.Count());
                    }
                }
  
                
            }

            if (p1.cardSize == 0)
            {
                gameBox.Text = "Computer Wins!";
                playButton.Visible = false;
                restartButton.Visible = true;
            }
            if (c1.cardSize == 0)
            {
                gameBox.Text = "Player wins!";
                playButton.Visible = false;
                restartButton.Visible = true;
            }

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            startButton.Visible = false;
            playButton.Visible = true;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
    }
}
