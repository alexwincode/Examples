
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?
   


// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// +"ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";


// string Replais(string text, char oldValue, char newValue)
// {
//     string result =String.Empty;
// int  length = text.Length;
//   for (int i = 0; i < length; i++)
//   {
//     if(text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
//   }
//     return result;
// }

// string newTvext = Replais(text, ' ', '|');

// System.Console.WriteLine(newTvext);
// System.Console.WriteLine();
// newTvext = Replais(newTvext, 'к', 'К');
// System.Console.WriteLine(newTvext);
// System.Console.WriteLine();
// newTvext = Replais(newTvext, 'с', 'С');
// System.Console.WriteLine(newTvext);


int[] arr = {1,5,6,4,3,2,6,7,1,1,8,9};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}



void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
       int minPosition = i; 
        for (int j = i+1; j < array.Length; j++)
        {
          if(array[j]< array[minPosition])  minPosition =j;
        }
       int tempporary = array[i];
       array[i] = array[minPosition];
       array[minPosition] =tempporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);