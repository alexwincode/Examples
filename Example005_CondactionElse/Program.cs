Console.Write("Введите имя пользователя  - ");
string username = Console.ReadLine();

if(username.ToLower() == "meri")
{
    Console.WriteLine("Ура, Это МАША");

}

else 
{
    Console.Write("Привет,   ");
    Console.WriteLine(username);
}