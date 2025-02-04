namespace Y9_SwitchStatements
{
    internal class Program
    {
        static void SwitchIntro()
        {
            int my_age = 8;
            switch (my_age)
            {
                case > 27: //cases are labelled with the value you're testing for
                    Console.WriteLine("You're age is 27 more");
                    break;
                case 26:
                    Console.WriteLine("thine age is 26");
                    break;
                case 8:
                    Console.WriteLine("preschool");
                    break;
                case int i when i > 4 && i < 7: //ranges - introducing a local variable, taking on the value of the tested variable (won't let you use the original my_age variable)
                    Console.WriteLine("key stage 1");
                    break;
                case int i when i > 7 && i < 11: //need to define variable i again because it is destroyed after the first use of it
                    Console.WriteLine("key stage 2");
                    break;
                default: //the else part of a switch statement
                    Console.WriteLine("thou doth not exist/are old");
                    break;
            }
        }
        static void ExtGradeCalc()
        {
            int grade = 0;
            Console.WriteLine("Input the percentage");
            double percent = double.Parse(Console.ReadLine());
            switch (percent)
            {
                case > 85:
                    grade = 9;
                    break;
                case double i when i > 75 && i < 84:
                    grade = 8;
                    break;
                case double i when i > 65 && i < 74:
                    grade = 7;
                    break;
                case double i when i > 55 && i < 64:
                    grade = 6;
                    break;
                case double i when i > 45 && i < 54:
                    grade = 5;
                    break;
                case double i when i > 35 && i < 44:
                    grade = 4;
                    break;
                case double i when i > 25 && i < 34:
                    grade = 3;
                    break;
                case double i when i > 15 && i < 24:
                    grade = 2;
                    break;
                case double i when i > 5 && i < 14:
                    grade = 8;
                    break;

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
