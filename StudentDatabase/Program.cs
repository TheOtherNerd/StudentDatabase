class Program
{
    public static void Main()
    {
        string[] names = { "Tommy", "Phil", "Joey" };
        string[] hometown = { "Place1", "Place2", "Place3" };
        string[] favFood = { "food1", "food2", "food3" };

        Console.WriteLine("Which student would you like to learn more about? Enter a number 1-3");
        string input = Console.ReadLine();
        //input = int.Parse(Console.Readline());

        //failsafe here
        //bool failsafe = true;
        

        int num = int.Parse(input) - 1;
        string name = names[num];

        Console.WriteLine($"Student {num} is {name}. What would you like to know? Enter 'hometown' or 'favorite food'.");
        string input2 = Console.ReadLine();
        bool check = true;
        while (check == true)
        {

            if (input2 == "hometown")
            {
                string home = hometown[num];
                Console.WriteLine($"{name} is from {home}.");
                break;
            }
            else if (input2 == "favorite food" || input2 == "food")
            {
                string food = favFood[num];
                Console.WriteLine($"{name}'s favorite food is {food}.");
                break;
            }
            else
            {
                Console.WriteLine("Sorry I didnt understand that.");
            }
            input2 = Console.ReadLine();
        }
        Console.WriteLine("Would you like to learn about another student?");
        string ask = Console.ReadLine();
        bool check2 = true;
        while (check2 == true)
        {
            if (ask == "y")
            {
                Main();
                break;
            }
            else if (ask == "n")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry I didnt understand that.");
                ask = Console.ReadLine();
            }
        }
    }
}