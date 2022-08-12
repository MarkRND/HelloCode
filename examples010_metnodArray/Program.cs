int [] array = {12,85,3,46,56,61,7,85};

int n = array.Length;  // длина масива
int find = 85;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;        // останавливает цикл на первом сопадение     
}
    
    index++;
}