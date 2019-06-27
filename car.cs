using System;
using System.Collections;
using System.Collections.Generic;
namespace Less8
{
    enum fuelList {petrol,diesel,gas,electric,hybrid};
    enum сolourList {white, yellow, green, blue, violet, metallic, black};
    enum modelList {Mercedes_Benz, Audi, BMW, Volkswagen, Honda, Lexus};
    enum cl_сarList{coupe, sedan, wagon ,hatchback, jeep, minivan};

    class car
    {// поля
        private fuelList fuel; //вид топлива
        private сolourList сolour;//цвет авто
        private modelList model;//марка авто
        private cl_сarList cl_Сar;//тип кузова

        //свойства

        public fuelList Fuel { get => fuel; set => fuel = value; }
        public  сolourList Сolour { get => сolour; set => сolour = value; }
        public  modelList Model { get => model; set => model = value; }
        public  cl_сarList Cl_Сar { get => cl_Сar; set => cl_Сar = value; }

        //конструктор
        public car(fuelList fuel, сolourList сolour, modelList model, cl_сarList cl_Сar)
        {
            Fuel = fuel;
            Сolour = сolour;
            Model = model;
            Cl_Сar = cl_Сar;
        }

        // метод 
        public override string ToString()
        {
            return $"вид топлива:{fuel},\nцвет авто:{сolour},\nмарка авто:{model},\nтип кузова: {cl_Сar}";
        }

        // Console.WriteLine($"вид топлива:{fuel},цвет авто:{сolour}, марка авто:{model}, тип кузова: {cl_сar}");

    }
}
