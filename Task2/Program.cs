// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

void Main()
{

System.Console.WriteLine("Введите текст: ");
string? str = Console.ReadLine().ToLower();

System.Console.Write(str);

}
Main();