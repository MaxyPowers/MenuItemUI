using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MenuItemUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        /// <summary>
        /// Сгенерировать случайное меню
        /// </summary>
        private void MakeTheMenu()
        {
            //Создать массив для 5 эелементов меню
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrice; //Переменная для хранения цены дополнительного элемента 

            //Цикл инициализирует элементы массива
            for (int i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem(); //Выделить память для элемента массива
                if(i >= 3) 
                {
                    //После трех итераций поле Breads у новых элементов инициализируется новым массивом
                    menuItems[i].Breads = new string[] {"plain bagel", "onion bagel", "pumpernickel bagel",
                                                        "everything bagel"};
                }
                //Сгенерировать элемент меню и цену
                menuItems[i].GenerateMenuItem();
            }

            //Вывести значения полей Description и Price в TextBlock
            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Price;
            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Price;
            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;
            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;
            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;

            //Дополнительный объект MenuItem с новыми массивами
            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };

            //Сгенерировать состав и цену нового элемента
            specialMenuItem.GenerateMenuItem();

            //Вывести значине полей в TextBlock
            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            //Еще один дополнительный элемент меню
            MenuItem guacamoleItem = new MenuItem();
            guacamoleItem.GenerateMenuItem();
            guacamolePrice = guacamoleItem.Price;

            guacamole.Text = "Add guacamole for " + guacamoleItem.Price;
        }
    }
}
