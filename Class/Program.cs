namespace Test1
{
    public class Program()
    {
        static void Main()
        {
            Grade[] MyGrades = {
                new Grade(100, 7, "Math"),
                new Grade(70, 8, "Sience"),
                new Grade(20, 6, "History")
            };
            Student Sabuhi = new Student("Sabuhi", "Sultanli", MyGrades);

            Console.WriteLine("\nAwarage Grade: " + Sabuhi.GetAvarageGrade(MyGrades) + "\n");
            
            PrintArr(Sabuhi.Grades);
            Sabuhi.AddGrade(new Grade(80, 8, "Subject_A"));
            Sabuhi.AddGrade(new Grade(70, 4, "Subject_B"));
            Sabuhi.AddGrade(new Grade(90, 2, "Subject_C"));
            Sabuhi.AddGrade(new Grade(10, 9, "Subject_D"));
            PrintArr(Sabuhi.Grades);
        }

        static void PrintArr(Grade[] arr)
        {
            Console.WriteLine("-------------------------------------------------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].Subject + " ");
            }
            Console.WriteLine("\n-------------------------------------------------------------");
        }
    }
}