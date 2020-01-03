using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        public int cardSize { get; set; }

        public List<Card> playerCards { get; set; }
        public void getPlayerCards(List<Card> s)
        {
            playerCards = new List<Card>();

            for (var i = 0; i < 26; i++)
            {
                playerCards.Add(s[i]);
                s.RemoveAt(i);
            }

            cardSize = playerCards.Count();
        }

        public void getDeckSize()
        {
            cardSize = playerCards.Count();
        }
    }
}
