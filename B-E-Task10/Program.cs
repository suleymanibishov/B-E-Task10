using System;

namespace B_E_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Student tural = new Student();
            Console.WriteLine(tural.Age); //1

            Student suleyman = new Student();
            Console.WriteLine(suleyman.Age); //2

            Student gafar = new Student();
            Console.WriteLine(gafar.Age); //3

            Student semed = new Student();
            Console.WriteLine(semed.Age); //4
        }
    }
}
