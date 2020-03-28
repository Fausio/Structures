using System;

namespace Structures
{
    struct Student
    {
        public int Id;
        public string Name;
        public double Avg ;

        public void Details()
        {
            Console.WriteLine("The student Id is "+ this.Id );
            Console.WriteLine("The Name of the student is "+ this.Name);
            Console.WriteLine("The Abg of the student is "+ this.Avg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            #region Simple Stucture example
            //Student F;
            //F.Id = 123;
            //F.Name = "Fausio";
            //F.Avg = 15.5;

            //Console.WriteLine("Student Id :" + F.Id);
            //Console.WriteLine("Name :" + F.Name);
            //Console.WriteLine("Avg :" + F.Avg);
            #endregion
            #region Array of strutures

            Student[] S = new Student[3];

            Random random = new Random();
            for (int i = 0; i < S.Length; i++)
            {
                S[i].Id = 10 + i;
                Console.WriteLine("The name of {0} student", i);
                S[i].Name = (Console.ReadLine());
                S[i].Avg = 4 + (random.NextDouble() * 100);
            }

            foreach (var item in S)
            {
                Console.WriteLine("_____________________________");
                item.Details();                 
            }
             #endregion


            Console.ReadKey();
        }
    }
}
