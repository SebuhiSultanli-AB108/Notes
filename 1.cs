#region Task1
/*--> Verilmiş natural ədədlərdən ibarət olan array daxilində cüt elementlərin sayının tapılması. <--*/
int[] nums = { 1, 5, 46, 85, 77, 12545456, 2112, 99 };
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0) count++;
}
Console.WriteLine(count);
#endregion


#region Task2
/*--> Verilmiş natural ədədlərdən ibarət olan array daxilində ən böyük tək elementin tapılması. <--*/
int[] nums = { 1, 5, 46, 85, 77, 12545456, 2112, 99 };
int cash = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 1 && nums[i] > cash) cash = nums[i];
}
Console.WriteLine(cash);
#endregion


#region Task3
/*--> Verilmiş array-ın elementlərinin tərsinə çevrilməsi. <--*/
int[] nums = { 1, 5, 46, 85, 77, 12545456, 2112, 99 };
int[] newNums = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    newNums[i] = nums[nums.Length - i - 1];
}

for (int i = 0; i < newNums.Length; i++)
{
    Console.WriteLine(newNums[i]);
}
#endregion


#region Task4
/*--> Verilmiş array-ın elementlərinin sayının tapılması. <--*/
int[] nums = { 1, 5, 46, 85, 77, 12545456, 2112, 99 };
int count = 0;
foreach (int num in nums)
{
    count++;
}
Console.WriteLine(count);
#endregion


#region Task5
/*--> Verilmiş elementin array-in daxilində yer alıb-almaması məlumatının əldə edilməsi. <--*/
int[] nums = { 1, 5, 46, 85, 77, 12545456, 2112, 99 };
int target = 77;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == target)
    {
        Console.WriteLine("got it! " + " It was at " + i + ". index");
        break;
    }
}
Console.WriteLine("can't find it!");
#endregion


#region Task6
/*--> Verilmiş element array daxilində yer alırsa neçə dəfə təkrarlandığı məlumatının əldə edilməsi. <--*/
int[] nums = { 1, 5, 46, 85, 77, 12545456, 2112, 99, 77, 77 };
int target = 77;
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == target)
    {
        count++;
    }
}
Console.WriteLine(count);
#endregion