using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSytemWorkingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Написать программу, читающую побайтно заданный файл и подсчитывающую число появлений
             * каждого из 256 возможных знаков.*/
            string readPath = @"C:\Users\Acer-PC\source\repos\FileSytemWorkingLesson-master\FileSytemWorkingLesson\unsubdued.txt";
            using(StreamReader sr= new StreamReader(readPath, System.Text.Encoding.Default))
            {
                char[] array = new char[256];
                sr.Read(array, 0, 256);
                Console.WriteLine(array);
            }


            /*2. С помощью класса StreamWriter записать в текстовый файл свое имя, фамилию и возраст. 
             * Каждая запись должна начинаться с новой строки.*/
            string writePath = @"C:\Users\Acer-PC\source\repos\FileSytemWorkingLesson-master\FileSytemWorkingLesson\name.txt";
            Console.Write("Введите имя: ");
            string name=Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            using (StreamWriter sw =new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(name);
                sw.WriteLine(surname);
                sw.WriteLine(age);
            }

        }
    }
}
