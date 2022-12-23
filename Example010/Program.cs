/* shift + alt + A */
/* int a1 = 1;
int a2 = 2;
int a3 = 3;
 */
int Max(int arg1, int arg2, int arg3)
    {
        int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
    }

//              0  1  2  3  4  5  6  7  8    9   10    
int[] array = { 1, 2, 5, 7, 8, 9, 6, 6, 888, 66, 3 };

int result = Max
(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
);
Console.WriteLine(result);

