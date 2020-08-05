using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace MarketManagerWF
{
    enum MenuLevel
    {
        CreateMarket = 0,
        SupermarketEdit,
        SectionCollection,
        SectionEdit,
        GoodsCollection,
        GoodsEdit
    }
    enum MenuEditIndex
    {
        ShowAll,
        AddNew,
        Delete,
        Serialize,
        Deserialize,
        ChangeName,
        Exit
    }

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
       /* switch (currentMenu.level)
            {
                case (int)MenuLevel.SupermarketEdit:    //Редактирование супермаркета
                    {
                        Console.WriteLine($"Супермаркет {mainMarket.Name}. Количество существующих отделов {mainMarket.SectionAmount}." +
                        $"Максимально возможное число секций {mainMarket.QueueSize}\n");
                        break;
                    }
                case (int)MenuLevel.SectionCollection:  //Список секций
                    {
                        menu[(int)MenuLevel.SectionCollection] = new string[mainMarket.SectionAmount];
                        for (int i = 0; i < mainMarket.SectionAmount; i++)
                        {
                            menu[(int)MenuLevel.SectionCollection][i] = String.Format("{0, -20}\t{1, -10}", mainMarket.AllExistSections[i].Name, mainMarket.AllExistSections[i].Count);
                        }
                        Console.WriteLine("Выберите нужную секцию для просмотра и редактирования.\n\n" + String.Format("{0, -20} | {1, -30}", "Название секции", "Кол-во товаров в секции.\n"));
                        break;
                    }
                case (int)MenuLevel.SectionEdit:        //Редактирование секции
                    {
                        Console.WriteLine($"Секция: {mainMarket.GetSection(currentSectionName).Name}. " +
                        $"Количество товаров: {mainMarket.GetSection(currentSectionName).Count}\n");
                        break;
                    }
                case (int)MenuLevel.GoodsCollection:    //Список товаров
                    {
                        SectionGoods section = mainMarket.GetSection(currentSectionName);

                        //выделение памяти для товаров 
                        List<Goods> allGoods = section.GetAllElements();
                        menu[(int)MenuLevel.GoodsCollection] = new string[section.Count];
                        //Заполнение массива товарами
                        for (int i = 0; i < section.Count; i++)
                        {
                            menu[(int)MenuLevel.GoodsCollection][i] = String.Format("{0, -20}\t{1, -10}", allGoods[i].Name, allGoods[i].Price);
                        }
                        Console.WriteLine("Выберите нужную секцию для просмотра и редактирования.\n\n" + String.Format("{0, -20} | {1, -30}", "Название товара", "Цена\n"));
                        
                        break;
                    }
                case (int)MenuLevel.GoodsEdit:          //Редактирование товара
                    {
                        Goods good = mainMarket.GetSection(currentSectionName).GetElementByName(currentGoodName);
                        if(good != null)
                        {
                            Console.WriteLine("Товар: " + good.ToString());
                        }
                        
                        break;
                    }
            }
            //Вывод меню
            for (int i = 0; i < menu[level].Length; i++)
            {
                if (index == i)
                    Console.WriteLine($">> {menu[level][i]}");
                else
                    Console.WriteLine($"   {menu[level][i]}");
            }
        }
        
       
        static bool NeedRefreshEditMenu()
        {
            switch(currentMenu.index)
            {
                case (int)MenuEditIndex.ShowAll:
                    
                    if (currentMenu.level == (int)MenuLevel.GoodsEdit)
                    {   //если текущее меню - "Редактировать товар",
                        ChangeItemNameMenu();
                        //ChangeGoodNameMenu();   //то вызвать функцию изменения названия товара
                        return false;
                    }
                    else
                        return true;    //перейти на новую страницу меню - "Показать все секции/товары"
                case (int)MenuEditIndex.AddNew:
                    if (currentMenu.level == (int)MenuLevel.GoodsEdit)
                    {   //если текущее меню - "Редактировать товар",
                        ChangeGoodPriceMenu();   //то вызвать функцию изменения цены товара
                        return false;
                    }
                    else
                    {
                        AddItem();      //Добавление нового элемента                        
                    }
                    return false;   //остаться на данной странице - "Добавить новую секцию/товар"
                case (int)MenuEditIndex.Delete:
                    return DeleteItem();    //остаться на данной странице - "Удалить секцию/товар"
                case (int)MenuEditIndex.Serialize:
                    SerializeItem();
                    return false;    //остаться на данной странице - "Сохранить данные о супермаркете/секции/товаре"
                case (int)MenuEditIndex.Deserialize:
                    //перейти на новую страницу "Редактирование супермаркета/секции/товара"
                    //или нет в зависимости от результата десериализации
                    return DeserializeItemAndChangeMenu();
                case (int)MenuEditIndex.ChangeName:
                    ChangeItemNameMenu();
                    return false;
                default: return false;
            } 
        }
        static bool DeleteItem()
        {
            switch(currentMenu.level)
            {
                case (int)MenuLevel.SupermarketEdit:
                    string deleteResult = mainMarket.DeleteSectionAndGoods();
                    if (deleteResult == null)
                    {   //DeleteSectionAndGoods возвращает null, когда список пуст
                        WriteAlarmMessage("Список секций пуст. Удаление невозможно.");
                    }
                    else
                    {   //DeleteSectionAndGoods возвращает имя удаленного отдела
                        Console.WriteLine($"Отдел \"{deleteResult}\" и список товаров отдела успешно удалены.");
                    }
                    return false;
                case (int)MenuLevel.SectionEdit:
                    //в данном случае не удаление, а получение общей стоимости товаров в секции
                    SectionGoods section = mainMarket.GetSection(currentSectionName);
                    Console.WriteLine($"Общая стоимость товаров в отделе \"{section.Name}\" {section.GetTotalSectionPrice()}");
                    return false;
                case (int)MenuLevel.GoodsEdit:
                    string deletedGood = mainMarket.GetSection(currentSectionName).DeleteGoodFromList(currentGoodName);
                    if (deletedGood != null)
                    {   //если имя удаленного товара не равен null
                        Console.WriteLine($"Товар \"{deletedGood}\" успешно удален.");
                    }
                    else
                    {
                        WriteAlarmMessage($"Товар \"{deletedGood}\" не найден.");
                    }
                    return true;
                default: return false;
            }
        }
        static void AddItem()
        {
            switch(currentMenu.level)
            {
                case (int)MenuLevel.SupermarketEdit:
                    AddSectionMenu();
                    break;
                case (int)MenuLevel.SectionEdit:
                    AddGoodMenu();
                    break;
                default: break;
            }
        }
        static void SerializeItem()
        {
            switch (currentMenu.level)
            {
                case (int)MenuLevel.SupermarketEdit:
                    Console.WriteLine("Информация о супермаркете сохранена в файле " + mainMarket.Serialize());
                    break;
                case (int)MenuLevel.SectionEdit:
                    Console.WriteLine("Информация о секции сохранена в файле " + mainMarket.GetSection(currentSectionName).Serialize());
                    break;
                case (int)MenuLevel.GoodsEdit:
                    Console.WriteLine("Информация о товаре сохранена в файле " + mainMarket.GetSection(currentSectionName).GetElementByName(currentGoodName).Serialize());
                    break;
                default: break;
            }
        }
        static bool DeserializeItemAndChangeMenu()
        {
            Console.WriteLine("Введите название файла без расширения:\n");
            if (mainMarket == null)
                mainMarket = new Supermarket();

            if (Console.ReadKey(intercept: true).Key != ConsoleKey.Escape)
            {
                switch (currentMenu.level)
                {
                    case (int)MenuLevel.CreateMarket:
                        if (mainMarket.Deserialize(supermarketXmlPath + Console.ReadLine() + ".xml"))
                            return true;    //Поменять страницу меню при успешной десериализации
                        else
                        {
                            WriteAlarmMessage("Неуспешная выгрузка данных.");
                            return false;   //остаться на прежней странице при неумпешной десериализации
                        }
                    case (int)MenuLevel.SupermarketEdit:
                        {
                            if (mainMarket.Deserialize(supermarketXmlPath + Console.ReadLine() + ".xml"))
                                Console.WriteLine("Выгрузка прошла успешно.");
                            else
                                WriteAlarmMessage("Неуспешная выгрузка данных.");
                            
                            return false;   //остаться на прежней странице при неумпешной десериализации
                        }
                    case (int)MenuLevel.SectionEdit:
                        {
                            SectionGoods tmpSection = new SectionGoods();
                            SectionGoods currentSec = mainMarket.GetSection(currentSectionName);

                            if (tmpSection.Deserialize(supermarketXmlPath + Console.ReadLine() + ".xml"))
                            {
                                if (mainMarket.GetSection(tmpSection.Name) != null)
                                {
                                    WriteAlarmMessage("Данное название уже используется в другой секции. Изменение секции невозможно.");
                                    return false;
                                }
                                else
                                {
                                    mainMarket.GetSection(currentSectionName).Count = tmpSection.Count;
                                    mainMarket.GetSection(currentSectionName).Head = tmpSection.Head;
                                    mainMarket.GetSection(currentSectionName).Name = tmpSection.Name;
                                    currentSectionName = tmpSection.Name;
                                    return false;
                                }
                            }
                            else
                            {
                                WriteAlarmMessage("Неуспешная выгрузка.");
                                return false;
                            }
                        }
                    case (int)MenuLevel.GoodsEdit:
                        {
                            Goods good = mainMarket.GetSection(currentSectionName).GetElementByName(currentGoodName);
                            Goods tmpGood = new Goods();
                            if (tmpGood.Deserialize(supermarketXmlPath + Console.ReadLine() + ".xml"))
                            {
                                if(mainMarket.GetSection(currentSectionName).GetElementByName(tmpGood.Name) == null)
                                {
                                    mainMarket.GetSection(currentSectionName).GetElementByName(currentGoodName).Price = tmpGood.Price;
                                    mainMarket.GetSection(currentSectionName).GetElementByName(currentGoodName).Name = tmpGood.Name;
                                    currentGoodName = tmpGood.Name;
                                    return false;
                                }
                                else
                                {
                                    WriteAlarmMessage("Данное название уже используется в другой позиции товара. Изменение товара невозможно.");
                                    return false;
                                }
                            }
                            return false;
                        }
                    default: return false;
                }
            }
            else
            {
                ClearConsoleLines(2);
                currentMenu.level--;
                currentMenu.index = 0;
                return false;
            }
        }
        static void ChangeItemNameMenu()
        {
            string newName;
            Console.WriteLine("Введите новое название\n");
            newName = Console.ReadLine();
            newName.TrimEnd(' ');

            switch (currentMenu.level)
            {
                case (int)MenuLevel.SupermarketEdit:

                    mainMarket.Name = newName;
                    Console.WriteLine($"Новое название Супермаркета \"{mainMarket.Name}\"\n");
                    break;

                case (int)MenuLevel.SectionEdit:

                    if (mainMarket.GetSection(newName) == null)
                    {
                        mainMarket.GetSection(currentSectionName).Name = newName;
                        currentSectionName = newName;
                        Console.WriteLine($"Новое название Секции \"{mainMarket.GetSection(currentSectionName).Name}\"\n");
                    }
                    else
                    {
                        WriteAlarmMessage("Данное название уже используется в другой секции. Изменение секции невозможно.");
                    }
                    break;

                case (int)MenuLevel.GoodsEdit:

                    SectionGoods curSec = mainMarket.GetSection(currentSectionName);
                    
                    if (curSec.GetElementByName(newName) == null)
                    {   //если товар с новым именем не существует
                        mainMarket.GetSection(currentSectionName).GetElementByName(currentGoodName).Name = newName;
                        Console.WriteLine($"Новое название Товара \"{newName}\"\n");
                        currentGoodName = newName;
                    }
                    else
                    {
                        ClearConsoleLines(2);
                        WriteAlarmMessage("Данное имя уже используется.");
                    }
                    break;
                default: break;
            }
        }
        
        //  ДОБАВИТЬ СУПЕРМАРКЕТ  //
        static void CreateSupermarketMenu()
        {
            Console.WriteLine("Введите название супермаркета и количество отделов\nНазвание: ");
            string name = Console.ReadLine();
            int amount;
            Console.WriteLine("Количество отделов");
            while (!int.TryParse(Console.ReadLine(), out amount))
            {
                ClearConsoleLines(2);
                WriteAlarmMessage("Неверное значение. Введите количество отделов.");
            }
            mainMarket = new Supermarket(amount);
            mainMarket.Name = name;
        }

        //  ДОБАВИТЬ СЕКЦИЮ  //
        static void AddSectionMenu()
        {
            if (!mainMarket.IsQueueFull())
            {   //если список не заполнен
                Console.WriteLine("Введите название новой секции:\n");
                string newName;
                while ((newName = Console.ReadLine()) == "")
                {
                    WriteAlarmMessage("Невозможно создать отдел с пустым именем");
                }
                //если имя не пустое
                int newSectionID = mainMarket.AddNewSection(newName);
                switch (newSectionID)
                {
                    case -1:
                        WriteAlarmMessage("Список заполнен. Нет свободного места для добавления секции.");
                        break;
                    case -2:
                        WriteAlarmMessage("Данное название уже используется в другой секции. Добавление секции невозможно.");
                        break;
                    default:
                        Console.WriteLine($"Отдел \"{mainMarket.GetSection(newName).Name}\" создан успешно.");
                        break;
                }
            }
            else
            {
                WriteAlarmMessage("Список заполнен. Нет свободного места для добавления секции.");
            }
        } 

        //  ДОБАВИТЬ ТОВАР  //
        static void AddGoodMenu()
        {
            SectionGoods section = mainMarket.GetSection(currentSectionName);
            
            double newPrice;
            string newName;
            
            Console.WriteLine("Введите название товара: ");
            newName = Console.ReadLine();

            if (section.GetElementByName(newName) == null)
            {   
                //если новое имя не используется в списке
                Console.WriteLine("Введите цену товара: ");
                while (!double.TryParse(Console.ReadLine().
                    Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator), out newPrice)
                    && newPrice >= 0)
                {
                    ClearConsoleLines(2);
                    Console.WriteLine("Неверное значение.");
                }
                mainMarket.GetSection(currentSectionName).AddGoodToList(newName);
                mainMarket.GetSection(currentSectionName).GetElementByName(newName).Price = newPrice; //присваивание цены
            }            
            ClearConsoleLines(4);
        }
              
        
        //  ИЗМЕНЕНИЕ ЦЕНЫ ТОВАРА  //
        static bool ChangeGoodPriceMenu()
        {
            Console.WriteLine("Введите новую  цену. ");
            double newPrice;
            while (!double.TryParse(Console.ReadLine(), out newPrice))
            {
                ClearConsoleLines(2);
                WriteAlarmMessage("Неверное значение цены. Введите корректное значение.");
            }
            mainMarket.GetSection(currentSectionName).GetElementByName(currentGoodName).Price = newPrice;
            return true;
        }
       */
