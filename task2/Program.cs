// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1
using System.ComponentModel.Design;

Console.WriteLine("whats your name?");
string  name = Console.ReadLine();
Console.WriteLine("language?");
string language = Console.ReadLine();

if (language == "en ") 
Console.WriteLine("hello " + name);
else if
    (language == "es") 
Console.WriteLine("hola" + name);
else if
    (language == "fr") 
Console.WriteLine("bonjor" + name);

else if (language == "tr") 
Console.WriteLine("merhaba" + name);

//2
Console.WriteLine("enter the first num");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter the second num");
double num2 = Convert.ToDouble((Console.ReadLine()));

if (num1 > num2)
    Console.WriteLine("bigger number is number 1");
else 

//3
Console.WriteLine("what your grade?");
double grade = Convert.ToDouble(Console.ReadLine());
if (grade >= 80)
    Console.WriteLine("A");
else if (grade >= 70 && grade <80)
    Console.WriteLine("B");
else if (grade >= 60 && grade < 70)
    Console.WriteLine("C");
else if (grade >= 50 && grade <60)
    Console.WriteLine("D");
else
{
    Console.WriteLine("F");
}





    






