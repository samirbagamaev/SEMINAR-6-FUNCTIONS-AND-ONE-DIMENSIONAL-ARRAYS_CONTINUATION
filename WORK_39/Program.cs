// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray(int size, int leftRange, int rightRange) //границы диапозона
{
   int[] array = new int[size];
   for(int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(leftRange, rightRange + 1); //от правого к левому 
   }
   return array;
}

void Reverse(int[] sourceArray)  //Reverse = разворот   sourceArray = значение индекса 
{
    for(int i = 0; i < sourceArray.Length / 2; i++) // две перестановки, так как в массиве с 5 числами, есть только 2 пары    
    {
        // для перестановки нужны 3 переменные
         int temp = sourceArray[i]; //временная переменная
         sourceArray[i] = sourceArray[sourceArray.Length - i - 1]; // вытащили последний элемент
         sourceArray[sourceArray.Length - i - 1] =  temp;          // 5 - 1 - 0 = 4
    }
}

const int size = 5;
const int leftRange = -9;
const int rightRange = 9;

int[] massive = GetRandomArray(size, leftRange, rightRange);
Console.WriteLine(string.Join(",", massive));
Reverse(massive); // РАЗВЕРНУЛИ МАССИВ
Console.WriteLine(string.Join(",", massive));