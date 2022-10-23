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
                Console.WriteLine("� � � � � � �");
                Console.WriteLine("�� ������ �� {0}, ������ ��", this.name);
                Console.WriteLine("{0} ����, ����� {1}", this.klas, this.id);
                Console.WriteLine($"��� - {this.dBEL:f2}");
                Console.WriteLine($"���� ���� - {this.dForeign:f2}");
                Console.WriteLine($"���������� - {this.dMath:f2}");
                Console.WriteLine($"������ - {this.dPhys:f2}", this.dPhys);
                Console.WriteLine($"����� - {this.dChem:f2}");
                Console.WriteLine($"�������� - {this.dBio:f2}");
                Console.WriteLine($"������ ����� - {this.average:f2}");

            }

        }

        static void Main(string[] args)
        {

            Student uchenik = new Student();

            Console.WriteLine("������ ���:");
            uchenik.Name = Console.ReadLine();


            Console.WriteLine("������ ����:");
            uchenik.Klas = Console.ReadLine();


            Console.WriteLine("������ ����� � �����:");
            uchenik.Id = int.Parse(Console.ReadLine());


            Console.WriteLine("������ ������ �� ���:");
            uchenik.DBEL = double.Parse(Console.ReadLine());

            Console.WriteLine("������ ������ �� ���� ����:");
            uchenik.DForeign = double.Parse(Console.ReadLine());

            Console.WriteLine("������ ������ �� ����������:");
            uchenik.DMath = double.Parse(Console.ReadLine());

            Console.WriteLine("������ ������ �� ������:");
            uchenik.DPhys = double.Parse(Console.ReadLine());

            Console.WriteLine("������ ������ �� �����:");
            uchenik.DChem = double.Parse(Console.ReadLine());

            Console.WriteLine("������ ������ �� ��������:");
            uchenik.DBio = double.Parse(Console.ReadLine());

            uchenik.calcAverage();
            uchenik.spravka();


        }

    }


}