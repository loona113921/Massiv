// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
void Main()
{

System.Console.WriteLine("Введите число: ");
int size = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();

for(int i = 0; i<size;i++)
{
   
char tmp = (char)rand.Next( 'A', 'Z' + 1 );
System.Console.Write(tmp);

}


}
Main();