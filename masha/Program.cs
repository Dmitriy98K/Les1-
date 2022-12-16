Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();
// ToLower() ливитирует маШа МашА
if(username.ToLower()=="маша")
{
    Console.WriteLine("ES!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);

}