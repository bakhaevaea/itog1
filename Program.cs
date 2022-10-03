using System;

class MyNewClass
{
    static void Main()
    {
        string [] stringArr = {"Скачайте", "файл", "контрольной", "работы", "справа", "от", "урока", ",",  "решите", "задачи",
                        "и", "направьте", "файл", "с", "выполненной", "работой", "в", "окно", "загрузки", "«практического", "задания»"};
        
        Console.WriteLine(String.Join("', '", stringArr));
        
        //массив, содержащий индексы элементов с длиной <=3
        int [] indexArr = new int [stringArr.Length];
        int count  = 0;  // кол-во элементов с длиной <=3
        
        for (int i = 0; i < stringArr.Length; i++ )    
        {
            if (stringArr[i].Length <= 3)
            {
                indexArr[count] = i;
                count ++;
            }
        }

        // Формируем результирующий массив
        string [] stringArrLen3 = new string [count];
        for (int i = 0; i < count; i++ )
        {
            stringArrLen3[i] = stringArr[indexArr[i]];
        }
        
        // выводим готовый массив
        Console.WriteLine(String.Join("', '", stringArrLen3));
    }
}
