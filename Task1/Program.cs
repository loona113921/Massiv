// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
void Main()
{


char[,] chars = 
{
    {'d','g','t','y'},
    {'h','f','v','n'},
    {'e','e','e','e'}
};

string str ="";
foreach (char letter in chars)
str += letter;
System.Console.WriteLine(str);


}
Main();