void FullArray(int[] Collection)
{
    int length = Collection.Length;
    int index = 0;
    while(index < length)
    {
        Collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] Col)
{
    int count = Col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(Col[position] +" ");
        position++;
    }
}

int Indexof(int[] Collection, int find)
{
    int count = Collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(Collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}

int[] array = new int[10];

FullArray(array);
PrintArray(array);

Console.WriteLine();

int pos = Indexof(array, 3);
Console.WriteLine(pos);