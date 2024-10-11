#region Task1
int num = int.Parse(Console.ReadLine());
int fact = 1;

if (num > 1)
{
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
}
else if (num < 0)
    Console.WriteLine("Give me a number higher then 0 bro !!!");
else
{
    Console.WriteLine(1);
}
Console.WriteLine(fact);

#endregion

#region Task2
int x = 0;
int y = x + 1;
int cash = 0;
while (x < 50000)
{
    Console.WriteLine(x);
    cash = y;
    y = x + y;
    x = cash;
}

#endregion

#region Task3
string text = Console.ReadLine();
int count = 0;

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == 'a')
    {
        count++;
    }
}
Console.WriteLine(count);
#endregion

#region Task4
string text = Console.ReadLine();
string target = Console.ReadLine();
int count = 0;
bool foundIt = false;

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == target[count])
    {
        count++;
        if (count == target.Length)
        {
            foundIt = true;
            break;
        }
    }
    else
    {
        if (count > 0) i -= count;
        count = 0;

    }
}
if (foundIt) Console.WriteLine("Found it !!!");
else Console.WriteLine("There is no " + target + " in the sentence !!!");
#endregion

#region Task5
int[] arr = { 8, 1, 46, 6, 2, 5, 3, 25, };
int num = 0;

for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] < arr[j])
        {
            num = arr[i];
            arr[i] = arr[j];
            arr[j] = num;
        }
    }
}

foreach (int item in arr)
{
    Console.WriteLine(item);
}
#endregion

#region Task6
int num = int.Parse(Console.ReadLine());
int numForLenght = num;
int numLenght = 0;

for (int i = 0; 0 < numForLenght; i++)
{
    numLenght++;
    numForLenght /= 10;
}

int[] arr = new int[numLenght];
int mem = 0;

for (int i = arr.Length - 1; i >= 0; i--)
{
    arr[i] = num % 10;
    num /= 10;
}

for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            mem = arr[i];
            arr[i] = arr[j];
            arr[j] = mem;
        }
    }
}

int final = 0;
foreach (int i in arr)
{
    final *= 10;
    final += i;
}

Console.WriteLine(final);
#endregion

#region task 7

int[] arrOne = { 1, 5, 7, 6, 4, 2, 63, 74, 11 };
int[] arrTwo = { 5, 7, 56, 4, 5, 7, 1, 5, 4 };

bool isEqual = false;

for (int i = 0; i < arrOne.Length; i++)
{
    for (int j = 0; j < arrTwo.Length; j++)
    {
        if (arrOne[i] == arrTwo[j])
        {
            isEqual = true;
            break;
        }
    }
    if (!isEqual) Console.WriteLine(arrOne[i]);
    isEqual = false;
}
#endregion

#region Task 8
int[] arr = { 1, 5, 7, 6, 4, 2, 6, 11 };

int evenSum = 0;
int oddSum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 1) oddSum += arr[i];
    else evenSum += arr[i];
}

Console.WriteLine(evenSum);
Console.WriteLine("----------------");
Console.WriteLine(oddSum);

#endregion