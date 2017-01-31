using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testitesti
{
    class Car
    {
        //propety = ominaisuus, ominaisuudet aina julkisia/public
        //näinki voi tehdä mutt vältä
        //public int Speed;
        public int Horsepower { get; set; }
        //sisäinen muuttuja määrittelee maksiminopeuden joka oliolle voidaa asettaa
        private const int maxSpeed = 200; //const tarkoitta vakiota
        private int speed;
        public int Speed


        {
            //get-aksessiru palauttaa propertylle arvon
            get
            {
                return speed;
            }
            //set-aksessorilla asetetaan propertyn arvoa
            set
            {
                if (value > maxSpeed)
                    speed = maxSpeed;
                else
                    speed = value;
            }
        }
        public string Brand { get; set; }
        //constructors
        public Car()
        //oletus knostruktori
        { }
        public Car(int horsepower, int speed)
        {
            Horsepower = horsepower;
            if (speed < maxSpeed)
                this.speed = speed; //this viittaa olioon itseensä
            else
                this.speed = maxSpeed;
        }
        //methods
        public void Accelerate(int addition)
        {
            //kiihdytetään autoa mutta ei yli maksiminopeuden
            if (speed + addition < maxSpeed)
                speed = speed + addition;
            else
                speed = maxSpeed;
        }
                public override string ToString()
        {
            return Brand + " hv:" + Horsepower + " nopeus:" + speed;
        }
           
        
    }
        
    
    class Program
    {
        static void TestMyCarClass()
        {
            //luodaan Car-olio
            Car car = new Car();
            car.Brand = "Toyota";
            car.Horsepower = 120;
            car.Speed = 175;
            //loudaan toinen caara
            Car car2 = new Car();
            car2.Brand = "Porsche";
            car2.Horsepower = 300;
            car2.Speed = 250;
            //loudaan kolmas caara
            Car fiat = new Car(55, 105);
            fiat.Brand = "Fiat";
        //näytetään kosolilla
        Console.WriteLine("Ensimmäinen auto {0}", car.ToString());
            Console.WriteLine("Autosi {1} nopeus on {0}", car.Speed, car.Brand);
            Console.WriteLine("Autosi {1} nopeus on {0}", car2.Speed, car2.Brand);
            Console.WriteLine("Autosi {1} nopeus on {0}", fiat.Speed, fiat.Brand);
            //kiihdytetään kumpaakin autoa 20km/h
            car.Accelerate(20);
        car2.Accelerate(20);
            fiat.Accelerate(20);
        Console.WriteLine("Kiihdytettiin 20km/h");
        Console.WriteLine("Autosi 1 nopeus on {0}", car.Speed);
        Console.WriteLine("Autosi 2 nopeus on {0}", car2.Speed);
            Console.WriteLine("Autosi fiat nopeus on {0}", fiat.Speed);
        }
        static void Main(string[] args)
        {
            TestMyCarClass();
        }
    }
}
// 2-7 Labra 4 31.1 kotitehtävät.