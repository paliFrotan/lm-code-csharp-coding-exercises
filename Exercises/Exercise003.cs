using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Exercise003
    {
        
        public string[] IceCreamFlavours => new string[] {"Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet"};

       
        /*public int IceCreamCode(string iceCreamFlavour)
        {
            for (int i = 0; i < IceCreamFlavours.Length; i++)
            {
                if (IceCreamFlavours[i] == iceCreamFlavour)
                {
                    return i;
                };
            }
            return -1; 
        } */
        public int IceCreamCode(string iceCreamFlavour)  => Array.IndexOf(IceCreamFlavours, iceCreamFlavour);
    }
}
