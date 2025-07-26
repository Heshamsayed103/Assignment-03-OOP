using Assignment_03_OOP.Class_Q1;
using Assignment_03_OOP.Classes_Q2;
using Assignment_03_OOP.Classes_Q3;
using Assignment_03_OOP.Interfaces;
using Assignment_03_OOP.Interfaces_Q2;
using Assignment_03_OOP.Interfaces_Q3;

namespace Assignment_03_OOP
{
    internal class Program
    {
        static void Main()
        {
            // 1. Class
            // 2. Struct
            // 3. Enum 
            // 4. Interface



            ////static void Print10Numbers(SeriesByTwo series)
            ////{
            ////    for (int i = 0;i<10;i++)
            ////    {
            ////        Console.Write($"{series.Current} ");
            ////        series.Next();
            ////    }
            ////    Console.WriteLine();
            ////    series.Reset();

            ////}

            //static void Print10Numbers(SeriesByThree series)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.Write($"{series.Current} ");
            //        series.Next();
            //    }
            //    Console.WriteLine();
            //    series.Reset();

            //}

            //static void Print10Numbers(SeriesByFour series)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.Write($"{series.Current} ");
            //        series.Next();
            //    }
            //    Console.WriteLine();
            //    series.Reset();

            //}

            static void Print10Numbers(Iseries series)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{series.Current} ");
                    series.Next();
                }
                Console.WriteLine();
                series.Reset();

            }
            static void Main()
            {
                #region Interface EX01:

                //// Interface : Reference Type 
                //// Code Contract Betwen The Developer Who Write It And Who Use It [Implemantion]

                ////IMyType myType = new IMyType();

                //// NOT : Can Not Create Object From Any Interfaces

                ////MyType myType = new MyType();

                ////myType.Salary = 12000;
                ////Console.WriteLine(myType.Salary);
                ////myType.MyFun();


                //IMyType myType;
                //// Ref --> Can Refer To Object From Any Class Which Implemented The Interface 'IMyType'

                //myType = new MyType();

                //myType.Salary = 12000;
                //myType.Print();
                //myType.MyFun();
                //Console.WriteLine(myType.Salary); 
                #endregion

                #region Interface EX02:

                ////SeriesByTwo seriesByTwo = new SeriesByTwo();

                ////Print10Numbers(seriesByTwo);


                ////SeriesByThree seriesByThree = new SeriesByThree();

                ////Print10Numbers(seriesByThree);

                ////SeriesByFour seriesByFour = new SeriesByFour();

                ////Print10Numbers(seriesByFour);

                ////int[] Number = { 1, 2, 7, 8,4,5,67, 9 };

                ////Array.Sort(Number);

                ////foreach (int number in Number)
                ////{
                ////    Console.Write(number);

                ////}


                //Employee[] employees = new Employee[3]

                //{
                //    new Employee(){ Id =1 , Name ="Ahmed" , Age =30 , Salary =12000  },
                //    new Employee(){ Id =2 , Name ="Fares" , Age =27 , Salary =11000  },
                //    new Employee(){ Id =3 , Name ="Ali"   , Age =28 , Salary =13000  }

                //};

                //Array.Sort(employees);

                //foreach (Employee item in employees)
                //{
                //    Console.Write(item);

                //} 
                #endregion

                #region Interface EX03:

                ////Car car = new Car();

                ////car.Speed = 150;
                ////car.Forword();

                //AirPlan airplan = new AirPlan();

                //IMoveable moveable = airplan;

                //moveable.Forword();

                //IFlyable flyable = airplan;

                //flyable.Forword(); 
                #endregion

                #region Shallow Copy Vs Deep Copy
                //  //// Shallow Copy Vs Deep Copy

                //  //int[] Arr01 = { 1, 2, 3 };
                //  //int[] Arr02 = { 4, 5, 6 };

                //  //string[] Arr01 = { "Ahmed", "Ali", "Omer" };
                //  //string[] Arr02 = { "Fares", "Tamer", "Belal" };

                //  StringBuilder[] Arr01 = new StringBuilder[]
                //  {
                //   new StringBuilder("Ahmed"),
                //   new StringBuilder("Ali"),
                //   new StringBuilder("Fares")
                //  };

                //  StringBuilder[] Arr02 = new StringBuilder[]
                //{
                //   new StringBuilder("Omer"),
                //   new StringBuilder("Tamer"),
                //   new StringBuilder("Amer")
                //};

                //  Console.WriteLine($"Arr01 {Arr01.GetHashCode()}");
                //  Console.WriteLine($"Arr02 {Arr02.GetHashCode()}");

                //  Arr02 = (StringBuilder[])Arr01.Clone(); // Shallow Copy
                //  // Copy Identity
                //  // {1,2,3} --> Has Two Rerencese Arr01,Arr02
                //  // {4,5,6} --> UnReahable object 
                //  Console.WriteLine();
                //  Console.WriteLine($"Arr01 {Arr01.GetHashCode()}");
                //  Console.WriteLine($"Arr02 {Arr02.GetHashCode()}");

                //  //// Identity (Address)+ Object State (Data ) 

                //  Arr02[0].Append("Ahmed Amin");
                //  Console.WriteLine(Arr01[0]);
                //  Console.WriteLine(Arr02[0]);


                //  //====================================

                //  // Shallow Copy Vs Deep Copy

                //  //int[] Arr01 = { 1, 2, 3 };
                //  //int[] Arr02 = { 4, 5, 6 };

                //  //Console.WriteLine($"Arr01 {Arr01.GetHashCode()}");
                //  //Console.WriteLine($"Arr02 {Arr02.GetHashCode()}");

                //  //Arr02 = (int[])Arr01.Clone(); // Deep Copy
                //  //// Clone Methode Will Copy The Object state Of The Caller
                //  //// Assign The New Object To Arr02 , Will Genarate NEW Identity

                //  //Console.WriteLine();
                //  //Console.WriteLine($"Arr01 {Arr01.GetHashCode()}");
                //  //Console.WriteLine($"Arr02 {Arr02.GetHashCode()}");

                //  //// Identity (Address)+ Object State (Data ) 

                //  //Arr02[0] = 100;
                //  //Console.WriteLine(Arr01[0]); 
                #endregion

                #region Bulit In Interface IClonable

                //Employee E01 = new Employee() { Id = 1 ,Name = "Ahmed", Age= 27,Salary =12000};
                //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 29, Salary = 11000 };

                ////E01 =E02; // Shallow Copy 

                //E01 = (Employee)E02.Clone(); // Deep Copy 
                //E01.Salary = 5;

                //Console.WriteLine(E01.GetHashCode()); 
                //Console.WriteLine(E02.GetHashCode());
                //Console.WriteLine(E01);
                //Console.WriteLine(E02); 
                #endregion

                #region Bulit In Interface ICompareable

                //Employee[] employees = new Employee[3]

                //{
                //    new Employee(){ Id =1 , Name ="Ahmed" , Age =30 , Salary =12000  },
                //    new Employee(){ Id =2 , Name ="Fares" , Age =27 , Salary =11000  },
                //    new Employee(){ Id =3 , Name ="Ali"   , Age =28 , Salary =13000  }

                //};

                //Array.Sort(employees);

                ////int X = employees[0].CompareTo (employees[1]);
                ////// +ve : Caller Greater Than Parameter
                ////// -ve : Caller Less Than Parameter
                //////  0  : Caller Equal Parameter

                ////Console.WriteLine(X); 

                //foreach (Employee item in employees)
                //{
                //    Console.Write(item);

                //} 
                #endregion

                #region Last Example

                //Employee[] employees = new Employee[3]

                //{
                //    new Employee(){ Id =1 , Name ="Ahmed" , Age =30 , Salary =12000  },
                //    new Employee(){ Id =2 , Name ="Fares" , Age =27 , Salary =11000  },
                //    new Employee(){ Id =3 , Name ="Ali"   , Age =28 , Salary =13000  }

                //};

                //Array.Sort(employees, new EmployeeComparerSalary());

                //foreach (Employee item in employees)
                //{
                //    Console.Write(item); 
                //}
                #endregion




            }











        }
    }
}
   

