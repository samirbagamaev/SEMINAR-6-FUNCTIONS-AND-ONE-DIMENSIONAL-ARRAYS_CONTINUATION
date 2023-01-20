// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] GetRandomArray(int size, int leftRange, int rightRange) //границы диапозона
{
   int[] array = new int[size];
   for(int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(leftRange, rightRange + 1); //от правого к левому 
   }
   return array;
}

const int size = 5;
const int leftRange = -6;
const int rightRange = 9;
int[] massive = GetRandomArray(size, leftRange, rightRange);

int[] newArray = new int[massive.Length];

for(int i = 0; i  < massive.Length; i++)
{
    newArray[i] = massive[i];
}

Console.WriteLine(string.Join(",", massive));
Console.WriteLine(string.Join(",", newArray));


