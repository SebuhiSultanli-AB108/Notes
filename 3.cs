#region Task1
//string str = Console.ReadLine();
//char[] arr = new char[str.Length];

//for (int i = 0; i < str.Length; i++)
//{
//    arr[i] = str[str.Length - i - 1];
//}

//foreach (char c in arr) Console.WriteLine(c);
#endregion

#region Task2
//int num = int.Parse(Console.ReadLine());
//int sum = 0;

//for (int i = 1; i < num; i++)
//{
//    if (num%i == 0) sum += i;
//}

//if (sum == num) Console.WriteLine("Perfect");
//else Console.WriteLine("Not Perfect");
#endregion

#region Task3
//string sait = "aeuioAEUIO";
//Console.Write("Uzunluq: ");
//int len = int.Parse(Console.ReadLine());
//string[] words = new string[len];
//int Truecount = 0;

//for (int i = 0; i < len; i++)
//{
//    words[i] = Console.ReadLine();
//}

//foreach (string word in words)
//{
//    int count = 0;
//    Console.WriteLine("------------------------");
//    Console.WriteLine("Soz: " + word);
//    foreach (char c in word)
//    {
//        for (int i = 0; i < sait.Length; i++)
//        {
//            if (sait[i] == c) count++;
//            break;
//        }
//    }
//    Console.Write("Sait: ");
//    int guess = int.Parse(Console.ReadLine());
//    if (guess == count)
//    {
//        Console.WriteLine();
//        Console.WriteLine("True!");
//        Truecount++;
//    }
//    else Console.WriteLine("Flase");
//}
//Console.WriteLine(Truecount + "/" + len);
#endregion

#region Task4
//int[] arrOne = { 1, 5, 6, 2, 4, 89, 5, 4, 154 };
//int[] arrTwo = { 4, 45, 56, 68, 89, 6 };
//int[] newArr = new int[arrOne.Length + arrTwo.Length];

//for (int i = 0; i < arrOne.Length + arrTwo.Length; i++)
//{
//    if (i < arrOne.Length) newArr[i] = arrOne[i];
//    else if (i < arrOne.Length + arrTwo.Length) newArr[i] = arrTwo[i - arrOne.Length];
//}

//foreach (int i in newArr) Console.WriteLine(i);
#endregion

#region Task5
//int[] arrOne = { 1, 4, 7, 9 };
//bool sirali = true;

//for (int x = 0; x < arrOne.Length - 1; x++)
//{
//    if (arrOne[x] > arrOne[x + 1])
//    {
//        sirali = false;
//        break;
//    }
//}
//if (sirali) Console.WriteLine("Siralidi");
//else Console.WriteLine("Sirali deyil");
#endregion
