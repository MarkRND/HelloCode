﻿int [] array = {12,24,3,46,56,61,7,85,9};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
    }
    // array[0] = 12;
    // Console.WriteLine(array[4]);
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);
// int max = Max(
//     Max(array b1, c1),
//     Max(a2, b2, c2),
//     Max(a3, b3, c3));


// /
// Console.Write("max = ");
// Console.WriteLine(max);