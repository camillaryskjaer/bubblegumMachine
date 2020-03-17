using System;
using System.Collections;
using System.Linq.Expressions;

namespace bubblegumMachine
{
    class Dispenser
    {
        Bubblegum blueberry = new Bubblegum("Blueberry","Blue");
        Bubblegum blackberry = new Bubblegum("Blackberry", "Black");
        Bubblegum tuttifrutti = new Bubblegum("TuttiFrutti", "Yellow");
        Bubblegum orange = new Bubblegum("Orange", "Orange");
        Bubblegum strawberry = new Bubblegum("Strawberry", "Red");
        Bubblegum apple = new Bubblegum("Apple", "Green");

        public ArrayList Bubblegum = new ArrayList();

        private int blueberryFill = 14;
        private int blackberryFill = 7;
        private int tuttifruttiFill = 11;
        private int orangeFill = 10;
        private int strawberryFill = 7;
        private int appleFill = 6;
        static Random rand = new Random();
        
        
        

        // det er denne metode som skal trække et random stykke tyggegummi 
        public void DrawRandomGum()
        {
            int drawGum = rand.Next(0, Bubblegum.Count);

            var gum = Bubblegum[drawGum];
            Bubblegum.Remove(drawGum);
            
        }

        public void PrintDrawRandom()
        {

        }

        public void FillDispenser()
        {
            FillBlueberry();
            FillBlackberry();
            FillTuttifrutti();
            FillOrange();
            FillStrawberry();
            FillApple();
        }

        public void PrintBubblegum()
        {
            foreach (Bubblegum BubbleGum in Bubblegum)
            {
                Console.WriteLine($"{BubbleGum.Name}");
            }
        }


        
        public void FillBlueberry()
        {
            for (int i = 0; i < blueberryFill; i++)
            {
                Bubblegum.Add(blueberry);
            }
        }

        public void FillBlackberry()
        {
            for (int i = 0; i < blackberryFill; i++)
            {
                Bubblegum.Add(blackberry);
            }
        }

        public void FillTuttifrutti()
        {
            for (int i = 0; i < tuttifruttiFill; i++)
            {
                Bubblegum.Add(tuttifrutti);
            }
        }

        public void FillOrange()
        {
            for (int i = 0; i < orangeFill; i++)
            {
                Bubblegum.Add(orange);
            }
        }

        public void FillStrawberry()
        {
            for (int i = 0; i < strawberryFill; i++)
            {
                Bubblegum.Add(strawberry);
            }
        }

        public void FillApple()
        {
            for (int i = 0; i < appleFill; i++)
            {
                Bubblegum.Add(apple);
            }
        }
    }
}