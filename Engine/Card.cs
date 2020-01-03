using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Card
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public void setName(int val)
        {
            switch (val)
            {
                case 1:
                    this.Name = "Ace";
                    break;
                case 2:
                    this.Name = "Two";
                    break;
                case 3:
                    this.Name = "Three";
                    break;
                case 4:
                    this.Name = "Four";
                    break;
                case 5:
                    this.Name = "Five";
                    break;
                case 6:
                    this.Name = "Six";
                    break;
                case 7:
                    this.Name = "Seven";
                    break;
                case 8:
                    this.Name = "Eight";
                    break;
                case 9:
                    this.Name = "Nine";
                    break;
                case 10:
                    this.Name = "Ten";
                    break;
                case 11:
                    this.Name = "Jack";
                    break;
                case 12:
                    this.Name = "Queen";
                    break;
                case 13:
                    this.Name = "King";
                    break;
                default:
                    this.Name = "Joker";
                    break;
            }
        }
    }
}
