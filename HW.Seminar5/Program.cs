int NumEnter(string str)
{
System.Console.WriteLine(str);
int num = int.Parse(Console.ReadLine());
return num;
} 


int [] GetRandomArray(int size, int begin = -100, int last = 100)
{
int[] array = new int[size];
Random random = new Random();
for (int i = 0; i < size; i++)
{
     array[i] = random.Next(begin, last + 1);
}
return array;
}


int [] GetRandomArray000(int size, int begin = 100, int last = 1000)
{
int[] arr = new int[size];
Random random = new Random();
for (int i = 0; i < size; i++)
{
     arr[i] = random.Next(begin, last + 1);
}

return arr;
}

start();

void start()
{
    while (true)
    {
Console.ReadLine();
Console.Clear();
System.Console.WriteLine("34) Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
System.Console.WriteLine("36) Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
System.Console.WriteLine("38) Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
System.Console.WriteLine("0) End"); 

int NumTask = NumEnter("Номер задачи");

switch (NumTask)
{
    case 0: return; break;
    case 34: Random002Array(); break;
    case 36: RandomArrayOnOddPosition(); break;
    case 38: RandomNumsSum(); break;

}
    }
}


// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Random002Array()
{

int size = NumEnter("Размер массива?");
int [] arr = GetRandomArray000(size);
System.Console.WriteLine($"[{String.Join(",", arr)}]");
for (int i = 0; i < size; i++)
{
    int N = arr[i];
    int num = N%2;
    if(num == 0) System.Console.WriteLine($"Четное число {arr[i] + " "}");
}
}     

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void RandomArrayOnOddPosition()
{
int arraylength = NumEnter("Размер массива?");
int [] arr = GetRandomArray(arraylength);
System.Console.WriteLine($"[{String.Join(",", arr)}]");
int sum = 0;
for (int i = 0; i < arraylength; i++)
{
    int N = arr[i];
   
    int num = N%2;
    if(num != 0) sum = sum + N;
}
System.Console.WriteLine($"Сумма нечетных чисел массива равна {sum}");
}     

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива


void RandomNumsSum(){
int arraylength = NumEnter("Размер массива?");
int [] arr = GetRandomArray(arraylength);
System.Console.WriteLine($"[{String.Join(",", arr)}]");
int maxN = arr.Max();
int minN = arr.Min();
System.Console.WriteLine($"Сумма большего и меньшего чисел равна {maxN + minN}");
}
