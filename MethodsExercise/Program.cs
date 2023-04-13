namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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


            
        }
    }
}
