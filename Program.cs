string [] array = {"2", "no way", "964", "система", "replay", "no"};
int count = 0;
for (int i = 0; i < array.Length; i++) //подсчет количества подходящих элементов
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}
string [] newArray = new string [count];
int j = 0;
for (int i = 0; i < array.Length; i++) //заполнение и вывод нового массива
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        Console.Write(newArray[j] + " ");
        j++;
    }
}