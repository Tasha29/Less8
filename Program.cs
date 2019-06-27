using System;
using System.Collections;
using System.Collections.Generic;

namespace Less8
{
    class Program
    {
        /*Реализовать класс Таксопарк, как динамический массив объектов класса Такси с реализацией всевозможных проверок всех полей всех классов.

Создать консольное приложение, позволяющее заполнить и получить всевозможную статистику по автопарку.

Ниже приведён перечень обязательных (полей) и [методов] для всех классов, участвующих в проекте.

Таксопарк (массив автомобилей) [добавить авто с номером, удалить авто с номером, отредактировать авто с номером, 
очистить таксопарк, заполнить таксопарк, setter и getter для каждого поля,
несколько видов конструкторов, статистические методы (например, поиск авто по номеру)]

Автомобиль (регистрационный номер, марка, модель, водители (массив), тип, цвет, состояние, цена) 
[setter и getter для каждого поля, несколько видов конструкторов, статистические методы]

Водитель (ФИО, дом.адрес,  телефон, дата рождения) [setter и getter для каждого поля, несколько видов конструкторов, статистические методы]
        */
        static void Main(string[] args)
        {
            car Car1 = new car(fuelList.electric, сolourList.black, modelList.Audi, cl_сarList.coupe);
            driver driv1 = new driver(nameList.Андрей, "Щокотов", "Васильевич", 48, sexList.мужской);

            Console.WriteLine("Автомобиль:");
            Console.WriteLine(Car1);
            Console.WriteLine("");
            Console.WriteLine("Водитель:");
            Console.WriteLine(driv1);

           /*Dictionary<int, string> fuel = new Dictionary<int, string>(5);
            fuel.Add(1, "petrol");
            fuel.Add(2, "diesel");
            fuel.Add(3, "gas");
            fuel.Add(4, "electric");
            fuel.Add(5, "hybrid");

            foreach (KeyValuePair<int, string> keyValue in fuel)

            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine("\n");
            ArrayList colour = new ArrayList();
            colour.Add("white");
            colour.Add("yellow");
            colour.Add("green");
            colour.Add("blue");
            colour.Add("violet");
            colour.Add("metallic");
            colour.Add("black");

            foreach (var item in colour)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            ArrayList cl_сar = new ArrayList();
            cl_сar.Add("coupe");
            cl_сar.Add("sedan");
            cl_сar.Add("wagon");
            cl_сar.Add("hatchback");
            cl_сar.Add("jeep");
            cl_сar.Add("minivan");
            
            foreach (var item in cl_сar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            ArrayList model = new ArrayList();
            model.Add("Mercedes_Benz");
            model.Add("Audi");
            model.Add("BMW");
            model.Add("Volkswagen");
            model.Add("Honda");
            model.Add("Lexus");

          
            foreach (var item in model)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Car1.GetType();
            Console.WriteLine($"Вид топлива:{fuel[2]},\nЦвет авто:{colour[4]},\nМарка авто:{model[1]},\nТип кузова: {cl_сar[5]}");
            */
        }
    }
}
