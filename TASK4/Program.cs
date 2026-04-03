//1
using System.Xml;

int[] numbers = { 3, 7, 2, 9, 5, 1 };
int sum = 0;

foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine(sum);

//2

int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
Array.Sort(temps);
int minSort = temps[0];
int maxSort = temps[temps.Length - 1];

int minMath = temps.Min();
int maxMath = temps.Max();
Console.WriteLine($"Min: {minMath}, Max = {maxMath}");


//3

string[] words = { "apple", "banana", "cherry", "date" };
string[] arr = (string[])words.Clone();
for (int i = 0; i < arr.Length / 2; i++)
{
     string temp = arr[i];
     arr[i] = arr[arr.Length - 1 - i];
     arr[arr.Length - 1 - i] = temp;
 }
 Console.Write("Manual: ");
 foreach (string w in arr)
 {
    Console.Write(w + " ");
 }
 Console.WriteLine();

 string[] arr2 = (string[])words.Clone();
 Array.Reverse(arr2);
 Console.Write("Reverse(): ");
 foreach (string w in arr2)
  {
    Console.Write(w + " ");
}


//4

int[] data = { 4, 7, 2, 11, 6, 9, 14, 8, 3 };

int even = 0, odd = 0;

for (int i = 0; i < data.Length; i++)
{
    if (data[i] % 2 == 0) even++;
    else odd++;
}
Console.WriteLine($"Even = {even}, Odd = {odd}");

//5

int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2 };
List<int> unique = new List<int>();
for (int i = 0; i < raw.Length; i++)
{
    if (unique.IndexOf(raw[i]) == -1)
        unique.Add(raw[i]);
}
foreach (int x in unique)
    Console.Write(x + " ");

//6

int[] arr3 = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;

int[] result = RotateLeft(arr3, k);

foreach (int x in result)
    Console.Write(x + " ");

static int[] RotateLeft(int[] arr, int k)
{
    int n = arr.Length;
    int[] res = new int[n];

    k = k % n;

    for (int i = 0; i < n; i++)
    {
        res[i] = arr[(i + k) % n];
    }

    return res;
}
