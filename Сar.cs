using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._09._2022
{
    internal class Car
    {

        public string Сompany { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        public TypeCar Type { get; set; }


        public Car(string company, string model, double speed, TypeCar type)
        {
            Сompany = company;
            Model = model;
            Speed = speed;
            Type = type;

        }

        public void ToString()
        {
            Console.WriteLine($"{Model} Компании: {Сompany}. Скорость: {Speed}/ Тип: {Type}");
        }


    }
    enum TypeCar
    {

        cargo,
        passenger,
        military,
        undefined

    }

}
