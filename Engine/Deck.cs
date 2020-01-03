using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Deck
    {
        public List<Card> DeckOfCards { get; set; }

        public void populateDeck()
        {
            DeckOfCards = new List<Card>();

            for (int i = 1; i <= 13; i++)
            {
                Card newC = new Card();
                Card newC2 = new Card();
                Card newC3 = new Card();
                Card newC4 = new Card();

                newC.Value = i;
                newC.setName(i);
                DeckOfCards.Add(newC);

                newC2.Value = i;
                newC2.setName(i);
                DeckOfCards.Add(newC2);

                newC3.Value = i;
                newC3.setName(i);
                DeckOfCards.Add(newC3);

                newC4.Value = i;
                newC4.setName(i);
                DeckOfCards.Add(newC4);
            }
        } 
        
        public List<Card> shuffleDeck()
        {
            var rand = new Random();
            var result = DeckOfCards.OrderBy(item => rand.Next());

            return result.ToList<Card>();
        }
    }
}
