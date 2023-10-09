namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cats myCat=new Cats();
            myCat.species="Persian";
            Console.WriteLine("my cat species is "+ myCat.species);
            myCat.eating("Beef");
            myCat.sleeping(26);
            
            Horses myHorse=new Horses();
            myHorse.sleeping("my Horse", 12);
            Console.WriteLine("the Horses species is " + myHorse.species);
            myHorse.sleeping();
             

            Pigs myPig=new Pigs();
            myPig.eating();
            myPig.sleeping("Piggy",9);


            Console.ReadLine();
        }
    }
    public abstract class Animals
    {
        public virtual void eating() { Console.WriteLine("Mm, Food"); }
        public abstract void sleeping();
        public abstract string species { get; set; }
    }
    public class Cats : Animals
    { 
        public override void sleeping() { Console.WriteLine("Cats sleep an average of 15 Hours per day"); }
        public void sleeping(int Hours)
        {
            if (Hours < 24)
                Console.WriteLine("My Cat sleeps " + Hours + " Hours per day");
            else Console.WriteLine("a day is only 24 Hours");
        }
        public  void sleeping(string myCat, int Hours) 
        {
            if (Hours < 24)
                Console.WriteLine(myCat +" sleeps " + Hours +" Hours per day");
            else Console.WriteLine("a day is only 24 Hours");
        }
        public override void eating() { Console.WriteLine("Meow"); }
        public void eating(string Food) { Console.WriteLine("my cat eats "+ Food); }
        public override string species { get; set; } = "Felis Catus";
    }

    public class Pigs : Animals 
    {
        public override void sleeping() { Console.WriteLine("pigs sleep an average of 8 Hours per day"); }
        public void sleeping(int Hours)
        {
            if (Hours < 24)
                Console.WriteLine("My pig sleeps " + Hours + " Hours per day");
            else Console.WriteLine("a day is only 24 Hours");
        }
        public void sleeping(string myPig, int Hours)
        {
            if (Hours < 24)
                Console.WriteLine(myPig + " sleeps " + Hours + " Hours per day");
            else Console.WriteLine("a day is only 24 Hours");
        }
        public override string species { get; set; } = "Sus Domesticus";
    }

    public class Horses : Animals 
    {
        public override void sleeping() { Console.WriteLine("Horses sleep an average of 5-7 Hours per day"); }
        public void sleeping(int Hours)
        {
            if (Hours < 24)
                Console.WriteLine("My Horse sleeps " + Hours + " Hours per day");
            else Console.WriteLine("a day is only 24 Hours");
        }
        public void sleeping(string myHorse, int Hours)
        {
            if (Hours < 24)
                Console.WriteLine(myHorse + " sleeps " + Hours + " Hours per day");
            else Console.WriteLine("a day is only 24 Hours");
        }
        public override string species { get; set; } = "Equus Caballus";
    }
}