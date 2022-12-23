// See https://aka.ms/new-console-template for more information
//              0  1  2  3  4  5  6  7  8    9   10  11  
int[] array = { 1, 2, 5, 7, 8, 9, 18, 6, 888, 66, 3, 18 };
int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        //если много повторяющихся, прервёт на первом значении
        break;
    }
    index++;
}