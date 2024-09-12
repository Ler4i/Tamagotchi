using Tamagotchi;

Console.WriteLine("Добро пожаловать в пробную игру тамагочи!");
//Thread.Sleep(2000);
Console.Clear();

Console.WriteLine("Выберите вид питомца: \n 1)котик \n 2)собачка \n 3)рыбка \n Ps:сменить питомца нельзя");
string num = Console.ReadLine();
while (true)
{
    switch (num)
    {
        case "1":
            Console.WriteLine("Вы выбрали котика!");
            break;
        case "2":
            Console.WriteLine("Вы выбрали собачку!");
            break;
        case "3":
            Console.WriteLine("Вы выбрали рыбку!");
            break;
        default:
            Console.WriteLine("Извините, я не знаю такой цифры. Попробуйте еще раз");
            num = Console.ReadLine();
            continue;
    }
    break;
}

if(num == "1")
{
    Console.WriteLine("Придумайте имя для вашей кошечки или котика: ");
    Cat cat = new Cat();
    cat.Name = Console.ReadLine();
    string NameCat = cat.Name;
    Console.WriteLine("Вашего питомца зовут: " + NameCat);
    Console.WriteLine("И так, у вашего питомца есть 4 базовые потребности: \n 1)бодрость = " + cat.LevelVivacity + 
        "\n 2)радость = " + cat.LevelJoy + "\n 3)голод = " + cat.LevelHunger + "\n 4)ласка = " + cat.LevelOfAffection);
    Console.WriteLine("Изначально все они равны 100, но с течением времени они будут уменьшаться! А вы сможете повышать их.");

    Console.WriteLine("По истечении определенного времени будет выводиться промежуточный результат " +
        "пока что это 5 секунд, чтобы видеть результат");
    cat.ReducingNeeds();
    

}






































