﻿using System;

public class Exercises
{
    public static void Main(string[] args)
    {
        Exercise_01 exercise_01 = new Exercise_01();
        Exercise_02 exercise_02 = new Exercise_02();
        Exercise_03 exercise_03 = new Exercise_03();
        Exercise_04 exercise_04 = new Exercise_04();
        Exercise_05 exercise_05 = new Exercise_05();
        Exercise_06 exercise_06 = new Exercise_06();

        Console.WriteLine("Choose an exercise:");
        Console.WriteLine("- 1. Exercise 01");
        Console.WriteLine("- 2. Exercise 02");
        Console.WriteLine("- 3. Exercise 03");
        Console.WriteLine("- 4. Exercise 04");
        Console.WriteLine("- 5. Exercise 05");
        Console.WriteLine("- 6. Exercise 06");
        
        Console.WriteLine("Option: ");
        string option = Console.ReadLine();

        switch(option){
            case "1":
                exercise_01.run();
                break;
            case "2":
                exercise_02.run();
                break;
            case "3":
                exercise_03.run();
                break;
            case "4":
                exercise_04.run();
                break;
            case "5":
                exercise_05.run();
                break;
            case "6":
                exercise_06.run();
                break;
        }
    }
}