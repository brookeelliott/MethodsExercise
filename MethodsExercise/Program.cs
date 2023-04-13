namespace MethodsExercise
{
    public class Program

    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            // Exercise 1

            Console.WriteLine("Lets do a very simple Madlib! First, give me a name.");
            string UserName = Console.ReadLine();

            Console.WriteLine("Now give me an animal.");
            string Animal = Console.ReadLine();

            Console.WriteLine("Great! Now lets do a color.");
            string Color = Console.ReadLine();

            Console.WriteLine("Okay last but not least, I need a number, any number.");
            string NumberInput = Console.ReadLine();

            Console.WriteLine($"There once was a {Color} {Animal} named {UserName}. {UserName} really wanted to go out for icecream \n" +
                $"but couldnt because they dont know how far the nearest ice cream shop is. They typed it into their smartphone and to \n" +
                $"surprise the nearest shop is {NumberInput} miles away!!! So {UserName} starts waliing. Eventually they decide an uber is better \n" +
                $"and they are so happy they buy the driver ice cream to. The End :)");

            // Exercise 2
            var Answer1 = Addition(2, 4);
            var Answer2 = Multiply(3, 4, 5);
            var Answer3 = Divide(10, 2);
            

        }


    }
}
