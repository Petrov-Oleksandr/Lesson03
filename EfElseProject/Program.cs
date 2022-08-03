//if (20 > 18)
//{
//    Console.WriteLine("20 is greater than 18");
//}

//int x = 20;
//int y = 18;
//if (x > y)
//{
//    Console.WriteLine("x is greater than y");
//}

//int time = 20;
//if (time < 18)
//{
//    Console.WriteLine("Good day.");
//}
////else
////{
////    Console.WriteLine("Good evening.");
////}

//int time = 22;
//if (time < 10)
//{
//    Console.WriteLine("Good morning.");
//}
//else if (time < 20)
//{
//    Console.WriteLine("Good day.");
//}
//else
//{
//    Console.WriteLine("Good evening.");
//}

//int day = 4;
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
////        Console.WriteLine("Saturday");
////        break;
////    case 7:
////        Console.WriteLine("Sunday");
////        break;
////}
//int day = 4;
//switch (day)
//{
//    case 6:
//        Console.WriteLine("Today is Saturday.");
//        break;
//    case 7:
//        Console.WriteLine("Today is Sunday.");
//        break;
//    default:
//        Console.WriteLine("Looking forward to the Weekend.");
//        break;
//}

//int b = a == 1 ? 10 : 15;

//int time = 20;
//if (time < 18)
//{
//    Console.WriteLine("Good day.");
//}
////else
////{
////    Console.WriteLine("Good evening.");
////}

//int i = 0;
//while (i < 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i < 5);


//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}

//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//foreach (string i in cars)
//{
//    Console.WriteLine(i);
//}


//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}
//Console.WriteLine("The End");

//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

//for (var i = 0; i < 10; i++)
//{
//    if (i > 5) break;
//    Console.Write(i);
//}

//for (var i = 0; i < 10; i++)
//{
//    if (i == 5) continue;
//    Console.Write(i);
//}

//while (false)
//{
//    Console.WriteLine("Hello, World");
//}

//do
//{
//    Console.WriteLine("Hello, World");
//} while (false);

//for (var i = 10; i < 15; i++)
//{
//    Console.Write('a');
//}

//string s = "test";
//if (s == "test")
//{
//    Console.WriteLine(s);
//}
//else
//{
//    Console.WriteLine("Hello");
//}

//switch (s)
//{
//    case "test":
//        Console.WriteLine(s);
//        break;
//    default:
//        Console.WriteLine("Hello");
//        break;
//}

//int sum=0;
//for (int i=2; i<10; i++)
//{
//    sum+=i;
//}
//Console.WriteLine(sum);


//while (i<9)
//{
//    i++;
//    sum += i;

//}
//Console.WriteLine(sum);

//int sum = 0;
//int i = 1;

//do
//{
//    i++;
//    sum += i;
//} while (i < 9);
//Console.WriteLine(sum);


//Homework Extra

int x = 3;
int y = 1;
int z = 0;
int sum = 0;

Console.WriteLine("Input X");
string strX = Console.ReadLine(); 
try
{
    x = Int32.Parse(strX);
}
catch (FormatException)
{
    Console.WriteLine("Input string is invalid.");
    return;
}

Console.WriteLine("Input Y");
string strY = Console.ReadLine();
try
{
    y = Int32.Parse(strY);
}
catch (FormatException)
{
    Console.WriteLine("Input string is invalid.");
    return;
}

if (x > y)
{
    z = x;
    x = y;
    y= z;
}

if (x == y)
{
    sum = x;
}
else
{
    for (int i = x; i < y + 1; i++)
    {
        sum += i;
    }
}
Console.WriteLine($"Sum from {x} to {y} = {sum}");



