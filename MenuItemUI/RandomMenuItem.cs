using System;
/*
 * 
 */

class MenuItem
{
    public static Random Randomizer = new Random();

    //Поля содержащие массивы ингридиентов
    public string[] Proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" }; 
    public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo",
                                   "relish", "french dressing" };
    public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };

    //Резервное поле для хранения описания элемента меню
    public string Description = "";
    //Резервное поле для хранения цены
    public string Price;

    /// <summary>
    /// Инициализирует резервные поля
    /// </summary>
    public void GenerateMenuItem()
    {
        //Сохранить по одному ингридиенту из массивов
        //Для обращения по индексу к элементу массива использовать случайное число
        //в диапазоне длины массива
        string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
        string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
        string randomBread = Breads[Randomizer.Next(Breads.Length)];

        //Инициализировать поле выбраными элементами
        Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

        //Сгенерировать случайную цену в указаных диапазонах
        decimal bucks = Randomizer.Next(2, 5);
        decimal cents = Randomizer.Next(1, 98);
        decimal price = bucks + (cents * .01M);

        Price = price.ToString("c");
    }
}