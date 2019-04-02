using System;
// using System.Collection.Generic;
namespace hungry_ninja{
    public class Buffet{
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza",600,false,false),
                new Food("Rice",200,false,false),
                new Food("Ice-cream",500,false,true),
                new Food("Sandwich",450,false,false),
                new Food("Milktea",400,false,true),
            };
        }
        Random rand = new Random ();
        public Food Serve()
        {
            return Menu[rand.Next(Menu.Count)];
        }
    }
}