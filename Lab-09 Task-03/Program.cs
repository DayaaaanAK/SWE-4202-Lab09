namespace Lab_09_Task_03
{
    internal class Cow : Animal
    {
        public override string vocalize()
        {
            return "moo";
        }
    }
    internal class Chicken : Animal
    {
        public override string vocalize()
        {
            return "buck buck";
        }
    }
    internal class Cat : Animal
    {
        public override string vocalize()
        {
            return "meow";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow();
            Cat cat = new Cat();
            Chicken chicken = new Chicken();

            Console.WriteLine(cow.vocalize());
            Console.WriteLine(cat.vocalize());
            Console.WriteLine(chicken.vocalize());
        }
    }
}
