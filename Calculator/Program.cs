//variables
double a, b, c;
string go;
char oper;
//app
try
{
    //start app
    Console.WriteLine("Hey! It's my calculator on C# ^.^\n\n" +
           "Would you calculate something?[Y(yes)/N(no)]");
    go = Convert.ToString(Console.ReadLine());
    //cycle
    while (go != "n")
    {
        //choise
        switch (go)
        {
            case "y":
                //mess
                Console.WriteLine("Enter first number--> ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter operator--> ");
                oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter second number--> ");
                b = Convert.ToDouble(Console.ReadLine());

                //log
                if (oper == '-')
                {
                    c = a - b;
                    Console.WriteLine($"{a} - {b} = {c}");
                }
                else if (oper == '+')
                {
                    c = a + b;
                    Console.WriteLine($"{a} + {b} = {c}");
                }
                else if (oper == '*')
                {
                    c = a * b;
                    Console.WriteLine($"{a} * {b} = {c}");
                }
                else if (oper == '/')
                {
                    c = a / b;
                    Console.WriteLine($"{a} / {b} = {c}");
                }
                else
                {
                    Console.WriteLine("Error! Unknown operator!");
                }
                break;

            default:
                continue;
        }
        Console.WriteLine("\n\nCan you continue calculate?[Y(yes)/N(no)]");
        go = Convert.ToString(Console.ReadLine());
    }
}
 catch
{
    Console.WriteLine("Error! Reload application!");
}