## Практика 2
# Задача 1
```c#
using System;

class Program
{
    // Функция для вычисления факториала
    static double Factorial(int n)
    {
        if (n == 0) return 1;
        double result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    // Функция для вычисления n-го члена ряда Маклорена для e^x
    static double GetNthTerm(double x, int n)
    {
        return Math.Pow(x, n) / Factorial(n);
    }

    // Функция для вычисления суммы ряда с заданной точностью
    static double CalculateSeries(double x, double epsilon)
    {
        double sum = 0;
        double term;
        int n = 0;

        do
        {
            term = GetNthTerm(x, n);
            sum += term;
            n++;
        }
        while (Math.Abs(term) > epsilon);

        return sum;
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите точность (e < 0.01):");
            double epsilon = double.Parse(Console.ReadLine());

            if (epsilon >= 0.01 || epsilon <= 0)
            {
                Console.WriteLine("Точность должна быть меньше 0.01 и больше 0");
                return;
            }

            double result = CalculateSeries(x, epsilon);
            Console.WriteLine($"Значение функции с точностью {epsilon}: {result}");
            Console.WriteLine("\nВведите номер члена ряда (n):");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Номер члена должен быть неотрицательным");
                return;
            }

            double nthTerm = GetNthTerm(x, n);
            Console.WriteLine($"Значение {n}-го члена ряда: {nthTerm}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено нечисловое значение");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: введено слишком большое число");
        }
    }
}

```
Пример 1:
Введите x:
4
Введите точность (e < 0.01):
0,002
Значение функции с точностью 0,002: 54,5978829056501

Введите номер члена ряда (n):
4
Значение 4-го члена ряда: 10,666666666666666

Пример 2:
Введите x:
3333
Введите точность (e < 0.01):
0,000033
Значение функции с точностью 3,3E-05: не число

Введите номер члена ряда (n):
333333
Значение 333333-го члена ряда: не число

Пример 3:
Введите x:
3
Введите точность (e < 0.01):
0,003
Значение функции с точностью 0,003: 20,08521256087662

Введите номер члена ряда (n):
r
Ошибка: введено нечисловое значение


# Задача 2
```c#
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите шестизначное число: ");
        int num = int.Parse(Console.ReadLine());
        if (num < 100000 || num > 999999)
        {
            Console.WriteLine("Неправильный ввод. Число должно быть шестизначным. Пример: 123321");
            return;
        }
        int c1 = 0, c2 = 0;
        c1 = (num / 100000) + ((num / 10000) % 10) + ((num / 1000) % 10);
        c2 = ((num / 100) % 10) + ((num / 10) % 10) + (num % 10);
        if (c1 == c2)
        {
            Console.WriteLine("Счастливый билет");
        }
        else
        {
            Console.WriteLine("Не счастливый билет");
        }
    }
}
```

```
Пример 1:
Введите шестизначное число: 123321
Счастливый билет

Пример 2:
Введите шестизначное число: 968745
Не счастливый билет

Пример 3:
Введите шестизначное число: 1234567890
Неправильный ввод. Число должно быть шестизначным. Пример: 123321
```
# Задача 3
```c#
using System;
class Program
{
    static void Main(string[] args)
    {
        int m, n;
        Console.Write("Введите числитель m: ");
        m = int.Parse(Console.ReadLine());
        Console.Write("Введите знаменатель n: ");
        n = int.Parse(Console.ReadLine());
        int c=Nod(Math.Abs(m), Math.Abs(n));
        
        Console.WriteLine($"Результат: {m/c}/{n/c}");
    }
    static int Nod(int m,int n)
    {
        while(m!=0 && n != 0)
        {
            if (m > n)
            {
                m = m % n;
            }
            else
            {
                n = n % m;
            }
        }
        m = m + n;
        return m;
    }
}
```
```
Пример 1:
Введите числитель m: 12
Введите знаменатель n: 18
Результат: 2/3

Пример 2:
Введите числитель m: -14
Введите знаменатель n: 7
Результат: -2/1

Пример 3:
Введите числитель m: 24
Введите знаменатель n: 5
Результат: 24/5
```
# Задача 4
```c#
using System;
class Program
{
    static void Main(string[] args)
    {
        int b = 0, e = 63;
        int c=0;
        string t;
        for (int i=0; i < 7; i++)
        {
            c = (b+e) / 2;
            Console.Write($"Ваше число больше или равно {c}? (1/0/yes): ");
            t = Console.ReadLine();
            if (t == "1")
            {
                b =c+1;
            }
            else if (t == "0")
            {
                e=c;
            }
            else if (t == "yes")
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка. Неверный ввод.");
                i--; 
                continue;
            }
            
        }
        Console.WriteLine($"Ваше число: {c}");
    }
}
```
```
Пример 1:
Ваше число больше или равно 31? (1/0/yes): 4
Ошибка. Неверный ввод.
Ваше число больше или равно 31? (1/0/yes): 1
Ваше число больше или равно 47? (1/0/yes): 1
Ваше число больше или равно 55? (1/0/yes): 1
Ваше число больше или равно 59? (1/0/yes): 1
Ваше число больше или равно 61? (1/0/yes): 1
Ваше число больше или равно 62? (1/0/yes): 1
Ваше число больше или равно 63? (1/0/yes): yes
Ваше число: 63

Пример 2:
Ваше число больше или равно 31? (1/0/yes): 1
Ваше число больше или равно 47? (1/0/yes): 0
Ваше число больше или равно 39? (1/0/yes): 1
Ваше число больше или равно 43? (1/0/yes): 0
Ваше число больше или равно 41? (1/0/yes): 1
Ваше число больше или равно 42? (1/0/yes): yes
Ваше число: 42

Пример 3:
Ваше число больше или равно 31? (1/0/yes): 0
Ваше число больше или равно 15? (1/0/yes): 1
Ваше число больше или равно 23? (1/0/yes): 1
Ваше число больше или равно 27? (1/0/yes): 1
Ваше число больше или равно 29? (1/0/yes): 1
Ваше число больше или равно 30? (1/0/yes): yes
Ваше число: 30

```
# Задача 5
```c#
using System;

class CoffeeMachine
{
    static void Main()
    {
        Console.Write("Введите количество воды (мл): ");
        int water = int.Parse(Console.ReadLine());

        Console.Write("Введите количество молока (мл): ");
        int milk = int.Parse(Console.ReadLine());
        int americanoCount = 0;
        int latteCount = 0;
        int totalRevenue = 0;
        while (true)
        {
            // Проверяем, можно ли приготовить хотя бы один напиток
            bool canMakeAmericano = water >= 300;
            bool canMakeLatte = water >= 30 && milk >= 270;

            if (!canMakeAmericano && !canMakeLatte)
            {
                break;
            }
            Console.WriteLine("\nВыберите напиток:");
            Console.WriteLine("1 - Американо (150 руб)");
            Console.WriteLine("2 - Латте (170 руб)");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    if (water >= 300)
                    {
                        water -= 300;
                        americanoCount++;
                        totalRevenue += 150;
                        Console.WriteLine("Ваш напиток готов");
                    }
                    else
                    {
                        Console.WriteLine("Не хватает воды");
                    }
                    break;

                case "2":
                    if (water >= 30 && milk >= 270)
                    {
                        water -= 30;
                        milk -= 270;
                        latteCount++;
                        totalRevenue += 170;
                        Console.WriteLine("Ваш напиток готов");
                    }
                    else if (water < 30)
                    {
                        Console.WriteLine("Не хватает воды");
                    }
                    else
                    {
                        Console.WriteLine("Не хватает молока");
                    }
                    break;

                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }

        Console.WriteLine("\n=== ОТЧЁТ ===");
        Console.WriteLine("Ингредиенты подошли к концу");
        Console.WriteLine($"Остаток воды: {water} мл");
        Console.WriteLine($"Остаток молока: {milk} мл");
        Console.WriteLine($"Приготовлено американо: {americanoCount} чашек");
        Console.WriteLine($"Приготовлено латте: {latteCount} чашек");
        Console.WriteLine($"Итоговый заработок: {totalRevenue} рублей");
    }
}
```
```
Пример 1:
Введите количество воды (мл): 500
Введите количество молока (мл): 300

Выберите напиток:
1 - Американо (150 руб)
2 - Латте (170 руб)
Ваш выбор: 1
Ваш напиток готов

Выберите напиток:
1 - Американо (150 руб)
2 - Латте (170 руб)
Ваш выбор: 1
Не хватает воды

Выберите напиток:
1 - Американо (150 руб)
2 - Латте (170 руб)
Ваш выбор: 2
Ваш напиток готов

=== ОТЧЁТ ===
Ингредиенты подошли к концу
Остаток воды: 170 мл
Остаток молока: 30 мл
Приготовлено американо: 1 чашек
Приготовлено латте: 1 чашек
Итоговый заработок: 320 рублей
Пример 2:
Введите количество воды (мл): 20
Введите количество молока (мл): 100

=== ОТЧЁТ ===
Ингредиенты подошли к концу
Остаток воды: 20 мл
Остаток молока: 100 мл
Приготовлено американо: 0 чашек
Приготовлено латте: 0 чашек
Итоговый заработок: 0 рублей

Пример 3:
Введите количество воды (мл): 500
Введите количество молока (мл): 100

Выберите напиток:
1 - Американо (150 руб)
2 - Латте (170 руб)
Ваш выбор: 1
Ваш напиток готов

=== ОТЧЁТ ===
Ингредиенты подошли к концу
Остаток воды: 200 мл
Остаток молока: 100 мл
Приготовлено американо: 1 чашек
Приготовлено латте: 0 чашек
Итоговый заработок: 150 рублей
```
# Задача 6
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество бактерий N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите количество капель антибиотика X: ");
        int x = int.Parse(Console.ReadLine());
        int hour = 0;
        int antibioticPower = 10;
        Console.WriteLine($"Час {hour}: {n} бактерий, сила антибиотика: {antibioticPower * x}");
        while (n > 0 && x > 0 && antibioticPower > 0)
        {
            hour++;
            n *= 2;
            // Фаза действия антибиотика
            int bacteriaKilled = Math.Min(n, antibioticPower * x);
            n -= bacteriaKilled;
            antibioticPower--;
            Console.WriteLine($"Час {hour}: {n} бактерий, антибиотика: {antibioticPower * x}");
            if (antibioticPower == 0)
            {
                x = 0;
            }
        }
        Console.WriteLine($"\nПроцесс завершен через {hour} часов");
        Console.WriteLine($"Конечное количество бактерий: {n}");
    }
}
```
```
Пример 1:
Введите количество бактерий N: 400
Введите количество капель антибиотика X: 10
Час 0: 400 бактерий, сила антибиотика: 100
Час 1: 700 бактерий, антибиотика: 90
Час 2: 1310 бактерий, антибиотика: 80
Час 3: 2540 бактерий, антибиотика: 70
Час 4: 5010 бактерий, антибиотика: 60
Час 5: 9960 бактерий, антибиотика: 50
Час 6: 19870 бактерий, антибиотика: 40
Час 7: 39700 бактерий, антибиотика: 30
Час 8: 79370 бактерий, антибиотика: 20
Час 9: 158720 бактерий, антибиотика: 10
Час 10: 317430 бактерий, антибиотика: 0

Процесс завершен через 10 часов
Конечное количество бактерий: 317430

Пример 2:
Введите числитель m: -14
Введите знаменатель n: 7
Результат: -2/1

Пример 3:
Введите числитель m: 24
Введите знаменатель n: 5
Результат: 24/5
```
# Задача 7
```c#
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите количество модулей n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите размер модуля a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите размер модуля b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину поля w:");
            int w = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту поля h:");
            int h = int.Parse(Console.ReadLine());

            if (n <= 0 || a <= 0 || b <= 0 || w <= 0 || h <= 0)
            {
                Console.WriteLine("Все значения должны быть положительными");
                return;
            }

            int maxD = FindMaxProtectionThickness(n, a, b, w, h);

            if (maxD >= 0)
            {
                Console.WriteLine($"Максимальная толщина защиты: {maxD} м");
            }
            else
            {
                Console.WriteLine("Невозможно разместить модули без защиты");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите целые числа");
        }
    }

    static int FindMaxProtectionThickness(int n, int a, int b, int w, int h)
    {
        int maxD = -1;

        // Перебираем возможные варианты размещения в строки и столбцы
        for (int cols = 1; cols <= n; cols++)
        {
            int rows = (n + cols - 1) / cols; // Округление вверх

            // Проверяем оба варианта ориентации модуля
            CheckOrientation(a, b, w, h, rows, cols, ref maxD);
            CheckOrientation(b, a, w, h, rows, cols, ref maxD);
        }

        return maxD;
    }
    static void CheckOrientation(int moduleWidth, int moduleHeight, int fieldWidth, int fieldHeight,
                               int rows, int cols, ref int maxD)
    {
        // Максимально возможная толщина защиты (ограничена размерами поля)
        int maxPossibleD = Math.Min(fieldWidth, fieldHeight) / 2;

        // Бинарный поиск максимальной толщины защиты
        int left = 0;
        int right = maxPossibleD;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int protectedWidth = moduleWidth + 2 * mid;
            int protectedHeight = moduleHeight + 2 * mid;

            // Проверяем, помещаются ли модули в поле
            if (cols * protectedWidth <= fieldWidth && rows * protectedHeight <= fieldHeight)
            {
                // Если помещаются, пробуем увеличить толщину
                maxD = Math.Max(maxD, mid);
                left = mid + 1;
            }
            else
            {
                // Если не помещаются, уменьшаем толщину
                right = mid - 1;
            }
        }
    }
}
```
```
Пример 1:
Введите количество модулей n:
1
Введите размер модуля a:
2
Введите размер модуля b:
2
Введите ширину поля w:
8
Введите высоту поля h:
8
Максимальная толщина защиты: 3 м

Пример 2:
Введите количество модулей n:
2
Введите размер модуля a:
2
Введите размер модуля b:
4
Введите ширину поля w:
8
Введите высоту поля h:
8
Максимальная толщина защиты: 1 м

Пример 3:
Введите количество модулей n:
5
Введите размер модуля a:
4
Введите размер модуля b:
5
Введите ширину поля w:
8
Введите высоту поля h:
8
Невозможно разместить модули без защиты

```