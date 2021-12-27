using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    public class Vehicle
    {
        public static Random rnd = new Random();
        public int WheelRadius = 0; //радиус колес
        public virtual String GetInfo()
        {
            var str = String.Format("\r\nРадиус колес - {0} см", this.WheelRadius);
            return str;
        }
    }
    public enum BicyclesType { mountain, city, child };
    public class Bicycles : Vehicle
    {
        public BicyclesType type = BicyclesType.mountain;
        private string get_type(BicyclesType type)
        {
            if (type == BicyclesType.mountain)
                return "Горный";
            else if (type == BicyclesType.city)
                return "Городской";
            else
                return "Детский";
        }

        public override string GetInfo()
        {
            var str = "Велосипед";
            str += base.GetInfo();
            str += String.Format("\r\nТип: {0}", get_type(this.type));
            return str;

        }
        public static Bicycles Generate()
        {
            return new Bicycles
            {
                WheelRadius = 5 + rnd.Next() % 20, 
                type = (BicyclesType)rnd.Next(3)
            };
        }
    }

    public enum CarsType { bus, truck, SUV, passenger };
    public class Cars : Vehicle
    {
        public int EngineVolume = 0; //объем двигателя
        public int NumberOfDoors = 0; //количество дверей
        public CarsType type = CarsType.bus;

        private string get_type(CarsType type)
        {
            if (type == CarsType.bus)
                return "Автобус";
            else if (type == CarsType.truck)
                return "Грузовик";
            else if (type == CarsType.SUV)
                return "Внедорожник";
            else
                return "Легковой";
        }

        public override string GetInfo()
        {
            var str = "Автомобиль";
            str += base.GetInfo();
            str += String.Format("\r\nОбъем двигателя: {0}", this.EngineVolume);
            str += String.Format("\r\nКоличество дверей: {0}", this.NumberOfDoors);
            str += String.Format("\r\nТип: {0}", get_type(this.type));
            return str;
        }
        public static Cars Generate()
        {
            return new Cars
            {
                WheelRadius = 10 + rnd.Next() % 20,
                EngineVolume = 5 + rnd.Next() % 20, 
                NumberOfDoors = 2 + rnd.Next() % 4,
                type = (CarsType)rnd.Next(4)
            };
        }
    }

    public enum EngineType { jetEngine, fanEngine };
    public class Plane : Vehicle
    {
        public int MaximumFlightAltitude = 0; //максимальная высота полета
        public EngineType type = EngineType.jetEngine;

        public string get_type(EngineType type)
        {
            if (type == EngineType.jetEngine)
                return "Реактивный";
            else
                return "Пропеллерный";
        }
        public override string GetInfo()
        {
            var str = "Самолёт";
            str += base.GetInfo();
            str += String.Format("\r\nМаксимальная высота полета: {0}", this.MaximumFlightAltitude);
            str += String.Format("\r\nТип двигателя: {0}", get_type(this.type));
            return str;
        }
        public static Plane Generate()
        {
            return new Plane
            {
                WheelRadius = 10 + rnd.Next() % 50,
                MaximumFlightAltitude = 5 + rnd.Next() % 20, 
                type = (EngineType)rnd.Next(2)
            };
        }
    }
}