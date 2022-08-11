using System;
using System.IO;

int floor = 0;
int pos = 0;
List<int> list = new List<int>();

using (StreamReader file = new StreamReader("input.txt"))
{
        foreach (var l in file.ReadLine())
    {
        switch (l)
        {
        case '(':
            floor += 1;
            break;
        case ')':
            floor -= 1;
            break;
        }
        pos++;
        if (floor == -1)
        {
            list.Add(pos);
        }
    }
}

Console.WriteLine("Part 1: {0}\nPart 2: {1}", floor, list[0]);