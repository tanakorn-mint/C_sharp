﻿using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human hun = new Human("Hun");
            Console.WriteLine(hun.name);
            Console.WriteLine(hun.health);

            Wizard wizzy = new Wizard("Wizzy");
            wizzy.heal();
            Console.WriteLine(wizzy.health);


        }
    }
}
