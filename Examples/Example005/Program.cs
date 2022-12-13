// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.Write("Ничего себе, вот она - Маша!!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
}
