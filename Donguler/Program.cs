﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" ,
                "Programlamaya başlangıç için temel kurs",
                "Java" ,"Python","C#"};

            for(int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            //Dizi temelli yapıları tek tek dönmeye yarıyor
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("Sayfa sonu");


        }
    }
}
