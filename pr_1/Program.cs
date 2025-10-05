// See https://aka.ms/new-console-template for more information
using System;

class Canculator
{
    public static void Main(string[] args)
    {
        //+, -, *, /,%, 1/x, x^2, корень квадратный из x, M+, M-, MR.
        Console.WriteLine("available operations: +, -, *, /,%, 1/x, x^2, sqrt, M+, M-, MR");
        //без проверки на дурака, так как это лишние if else и так раз 50
        double mr = 0;
        double n1 = 0;
        double r = 0;//result
        double n2 = 0;
        string act;
        string input;
        string mr_work;
        int check = 0;// что было последним
        while (true) {
            Console.Write("Write: ");
            input = Console.ReadLine();
            if (double.TryParse(input, out double n0))
            {
                n1 = n0;
                check = 0;
                continue;
            }
            else {
               
                act = input; 
            }
            if (check == 1)
                n1 = r;
                switch (act)
            {
                case "1/x":
                    r = 1 / n1;
                    check = 1;
                    Console.WriteLine($"Result: {r}");
                    break;
                case "x^2":
                    r = Math.Pow(n1,2);
                    check = 1;
                    Console.WriteLine($"Result: {r}");
                    break;
                case "sqrt":
                    r = Math.Sqrt(n1);
                    check = 1;
                    Console.WriteLine($"Result: {r}");
                    break;
                case "M+":
                    mr += n1;
                    check = 1;
                    Console.WriteLine($"Memory: {mr}");
                    break;
                case "M-":
                    mr -= n1;
                    check = 1;
                    Console.WriteLine($"Memory: {mr}");
                    break;
                case "MR":
                    //Убрать если не захотите чтобы оно было уже введено
                    r = mr;
                    check = 1;
                    Console.WriteLine("Число в памяти: {0}", mr);
                    Console.WriteLine("Оно в строке, как будто вы его только что ввели");
                    
                    break;
                    
            }

            if (act == "+" || act == "-" || act == "*" || act == "/" || act == "%")
            {
                Console.Write("Write second number or MR: ");
                mr_work = Console.ReadLine();
                if (mr_work == "MR")
                {
                    n2 = mr;
                }
                else
                {
                    n2 = Convert.ToDouble(mr_work);
                }
                    
                check = 1;

                switch (act)
                {
                    case "+":
                        r = n1 + n2;
                        break;
                    case "-":
                        r = n1 - n2;
                        break;
                    case "*":
                        r = n1 * n2;
                        break;
                    case "/":
                        r = n1 / n2;
                        break;
                    case "%":
                        r = n1 % n2;
                        break;

                    default:
                        Console.WriteLine("Неверная операция");
                        break;
                }
                Console.WriteLine($"Result: {r}");

            }
        }
    }
}
