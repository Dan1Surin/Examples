int[] array = new int [10];
void FillArray (int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position <count)
    {
        int index = 0;
        collection[index] = new Random().Next(1,10);
        position++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos <count)
    {
        Console.Write(col[pos]);
        pos++;
    }
}
FillArray(array);
PrintArray(array);

