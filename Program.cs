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

        // for (int i = 0; i < stringArr.Length; i++ )    
        // {
            
        // }
    }
}
