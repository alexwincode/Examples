﻿int[] arrey = { 1, 12, 31, 4, 18,15, 16, 17, 18, 91 };

int n = arrey.Length;
int find = 18;
int index = 0;
while (index < n)
{
if (arrey[index] == find)

    {
     Console.WriteLine(index);  
     break;
    }  
    index++;
}