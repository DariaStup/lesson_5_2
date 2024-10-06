bool live = true;
int Egg = 0;

while (live) { 

    void Feed()
        {
            Console.WriteLine("Введите количество зерен:");
            int cereal = Convert.ToInt32(Console.ReadLine());
            if (cereal < 3)
            {
                live = false;
            }
            else
            {
                Egg++;
            }
        }

    void TakeEgg()
        {
            Console.WriteLine("Забираем яйцо...");
            Egg--;
            live = false;
        }

    void DoNothing()
    {
        Console.WriteLine("Ничего не делаем");
        live = false;
    }

    Console.WriteLine($"МЕНЮ:\nПокормить курицу - 1 \nЗабрать яйцо - 2\nНичего не делать - 3");
    string input = Console.ReadLine();
    int Menus = int.Parse(input);
    switch (Menus)
    {
        case 1:
            Feed();
            break;
        case 2:
            TakeEgg();
            break;
        case 3:
            DoNothing();
            break;
        
    }
}
