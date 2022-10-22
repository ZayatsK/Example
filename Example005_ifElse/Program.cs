Console.Write("Введите имя Пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "костя")
{
    Console.WriteLine("Ура! это же Костя");
}
else
{
    Console.Write("Ааа это ты... ");
    Console.WriteLine(username);
}