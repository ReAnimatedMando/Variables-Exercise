namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Aaron Tanguma"; // declare and initialize name variable type string

            int age = 40; // declare and initialize age variable type int

            char gender = 'm'; // declare and initialize gender variable type char

            bool isStudent = true; // declare and initialize fact type variable isStudent

            double average = 98.43; // declare and initialize average variable type double

            decimal myAccount = 3400.33m; // declare and initialize myAccount variable type decimal
            
            Console.WriteLine($"Hi, I'm {name}! I am a {age} year old {gender}!"); // use variables to create a message to the console.
            
            // I notice that my IDE points to variables that haven't been used by underlining them in yellow.
        }
    }
}
