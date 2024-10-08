﻿using System.Threading;

namespace CourseApps
{


public class ReverseStopWatch
    {
    
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));

        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            System.Environment.Exit(0);

        PreStart(time * multiplier);


    }

    public static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("GO!");
        Thread.Sleep(2000);

        Start(time);


    }

    public static void Start(int time)
    {

        int currentTime = time;


        while (currentTime > 0)

        {
            Console.Clear();
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
            currentTime--;


        }

        Console.Clear();
        Console.WriteLine("Cronometro Finalizado");
        Thread.Sleep(3000);

        Menu();

    }


}

}