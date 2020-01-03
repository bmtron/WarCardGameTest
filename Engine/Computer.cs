using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Computer
    {
        public int cardSize { get; set; }

        public List<Card> compCards { get; set; }

        public void getCompCards(List<Card> s)
        {
            Console.WriteLine(s.Count());
            compCards = new List<Card>();

           for (var i = 0; i < s.Count(); i++)
            {
                compCards.Add(s[i]);
            }
            cardSize = compCards.Count();
        }
        public void getDeckSize()
        {
            cardSize = compCards.Count();
        }
    }
}
