Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine(); //наименование переменной

if(username.ToLower() == "маша") // условие
{
    Console.WriteLine("Ура, это же МАША!");//набор дпействтй
}
else
{
    Console.Write("Привет, "); // набор действией 2
    Console.WriteLine(username);
}

