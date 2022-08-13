// 1 Вид метода
void Method()
    {
        Console.WriteLine(" Автор MarkRND");
    }




    //  Вызов метода
// Method();    указываеи индификатор метода .Вызов метода

// Вид 2
void Method2(string msg)      // void ИНДИФИКАТОР (какойто количество аргуметов)
{

   Console.WriteLine(msg);   // msg - аргумент
}
 //  Вызов метода
// Method2("Текст сообщения");    указываеи индификатор метода .Вызов метода


void Method21(string msg, int count)      // void ИНДИФИКАТОР (какойто количество аргуметов)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);  // msg - аргумент
        i++;                   
    }
    
}
 //  Вызов метода
//Method21("Текст сообщения", 4);    //указываеи индификатор метода .Вызов метода
// Method21(msg:"Текст сообщения", count: 4); можно указывать явное значение, Какое значение, какому аргументу мы хотим присвоить
// Method21(count: 4, msg:"Новый текст сообщения"); // если мы используемы именованые значения, то можно их писать не по порядку

// 3 что то возвращают, но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}

// int year = Method3();            вызов этого метода
// Console.WriteLine(year);


// Вид 4 что то принимают и что то возвращают
string Method4(int count, string text)
{
    // int i = 0;
    string result = String.Empty;//"";  переменная result изначально будет пустой строкой
    for(int i = 0; i < count; i++) 
    // while (i < count)
    {
        result = result + text;
        // i++;
    }
    return result;
}

string res = Method4(10, "ПривЭт " );
Console.WriteLine(res);


// Класическое использование цикла в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}