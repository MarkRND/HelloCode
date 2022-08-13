int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };
// первый метод вывода масива
void PrintArray(int[] array)
{
        int count = array.Length;

        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        } 
        Console.WriteLine();
}
// метод который будет упарядычевать масив
void SelectonSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition =j;
        }
        int tepmporay = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tepmporay;
    }
}

PrintArray(arr);
SelectonSort(arr);

PrintArray(arr);