using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassesExercises
{
    class Program
    {
        class Student
        {
            private string name;
            private string klas;
            private int id;
            private double average;

            private double dBEL;
            private double dForeign;
            private double dMath;
            private double dPhys;
            private double dChem;
            private double dBio;
            public string Name
            {
                set { this.name = value; }

                get { return this.name; }

            }
            public string Klas
            {

                set { this.klas = value; }

                get { return this.klas; }

            }
            public int Id
            {

                set
                {
                    if (this.id <= 26)
                    {
                        this.id = value;
                    }
                }

                get { return this.id; }

            }
            public double Average
            {
                set { this.average = value; }

                get { return this.average; }

            }
            public double DBEL
            {
                set { if (value <= 6.00 && value >= 2.00) { this.dBEL = value; } }

                get { return this.dBEL; }
            }
            public double DForeign
            {
                set { if (value <= 6.00 && value >= 2.00) { this.dForeign = value; } }

                get { return this.dForeign; }
            }
            public double DMath
            {
                set { if (value <= 6.00 && value >= 2.00) { this.dMath = value; } }

                get { return this.dMath; }
            }
            public double DPhys
            {

                set { if (value <= 6.00 && value >= 2.00) { this.dPhys = value; } }

                get { return this.dPhys; }
            }
            public double DChem
            {
                set { if (value <= 6.00 && value >= 2.00) { this.dChem = value; } }

                get { return this.dChem; }
            }
            public double DBio
            {
                set { if (value <= 6.00 && value >= 2.00) { this.dBio = value; } }

                get { return this.dBio; }
            }
            public void calcAverage()
            {
                this.Average = (this.DBEL + this.DForeign + this.DMath + this.DPhys + this.DChem + this.DBio) / 6;
            }
            public void spravka()
            {
                Console.WriteLine("С П Р А В К А");
                Console.WriteLine("за успеха на {0}, ученик от", this.name);
                Console.WriteLine("{0} клас, номер {1}", this.klas, this.id);
                Console.WriteLine($"БЕЛ - {this.dBEL:f2}");
                Console.WriteLine($"Чужд език - {this.dForeign:f2}");
                Console.WriteLine($"Математика - {this.dMath:f2}");
                Console.WriteLine($"Физика - {this.dPhys:f2}", this.dPhys);
                Console.WriteLine($"Химия - {this.dChem:f2}");
                Console.WriteLine($"Биология - {this.dBio:f2}");
                Console.WriteLine($"Среден успех - {this.average:f2}");

            }

        }

        static void Main(string[] args)
        {

            Student uchenik = new Student();

            Console.WriteLine("Въведи име:");
            uchenik.Name = Console.ReadLine();


            Console.WriteLine("Въведи клас:");
            uchenik.Klas = Console.ReadLine();


            Console.WriteLine("Въведи номер в класа:");
            uchenik.Id = int.Parse(Console.ReadLine());


            Console.WriteLine("Въведи оценка по БЕЛ:");
            uchenik.DBEL = double.Parse(Console.ReadLine());

            Console.WriteLine("Въведи оценка по Чужд език:");
            uchenik.DForeign = double.Parse(Console.ReadLine());

            Console.WriteLine("Въведи оценка по Математика:");
            uchenik.DMath = double.Parse(Console.ReadLine());

            Console.WriteLine("Въведи оценка по Физика:");
            uchenik.DPhys = double.Parse(Console.ReadLine());

            Console.WriteLine("Въведи оценка по Химия:");
            uchenik.DChem = double.Parse(Console.ReadLine());

            Console.WriteLine("Въведи оценка по Биология:");
            uchenik.DBio = double.Parse(Console.ReadLine());

            uchenik.calcAverage();
            uchenik.spravka();


        }

    }


}