// Программа из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.
//["hello","2","world",":-)"] -> ["2",":-)"]
string[] strArray = {"1", "May", "Dodo", "web", "12", "March", "Saturday"};  //зададим массив
void PrintArray(string[] array)                     //определяем метод печати массива
{
    Console.Write($"[{array[0]}, ");
    for (int i = 1; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}
string[] Main (string[] array)                //определяем метод расчета итогового массива
{
    string[] arrayFinal = new string[array.Length];  //задаем итоговый массив такого же размера, как основной
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if(array[i].Length <= 3)
        {
            arrayFinal[j] = array[i];
            j = j+1;
        }
    }
    Array.Resize(ref arrayFinal, j);     //изменим размер итогового массива до нужного кол-ва строк
    return arrayFinal;
}
PrintArray(strArray);       //выводим на печать заданный массив
Console.Write("  ->  ");
PrintArray(Main(strArray));  //выводим на печать итоговый массив