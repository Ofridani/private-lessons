﻿for (int i = 1; i < 100; i++)
{
    if ((i % 7 == 0) || (i % 10 == 7) || (i / 10 % 10 == 7))
    {
        Console.WriteLine(i + " boom!");
    }
    else
    {
        Console.WriteLine(i);
    }
}