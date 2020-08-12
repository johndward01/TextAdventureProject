using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    public class DeadBody
    {
        public int MoneyInWallet { get; set; } = 0;
        public string DeadBodyDescription { get; set; } = "There's blood everywhere";
        public string PocketWatch { get; set; } = "The only thing in the man's pockets is an old silver pocketwatch.\nOdd..the pocketwatch's time is stopped at 6:30. 30 minutes after I left the office.";
        public string Shoes { get; set; } = "The shoes have mud on them";
        public string Clothes { get; set; } = "On the inner stitching of his jacket there's an embroidery that says: Hitchcock";

        public void SearchBody()
        {
            Console.WriteLine(this.DeadBodyDescription);
        }
        public void SearchPockets()
        {
            Console.WriteLine(this.PocketWatch);
        }
        public void SearchClothes()
        {
            Console.WriteLine(this.Shoes);
            Console.WriteLine(this.Clothes);
        }
    }
}
