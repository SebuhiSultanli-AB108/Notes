namespace Test1
{
    public class Student
    {
        public string Name;
        public string Surname;
        public Grade[] Grades;

        public Student(string Name, string Surname, Grade[] Grades)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Grades = Grades;
        }

        public  int GetAvarageGrade( Grade[] Grades)
        {
            int awg = 0;
            foreach (Grade grade in Grades)
            {
                awg += grade.Point;
            }
            awg /= Grades.Length;
            return awg;
        }
        public int GetCreditCount(Grade[] Grades)
        {
            int count = 0;
            foreach (Grade grade in Grades)
            {
                count += grade.CreditCount;
            }
            count /= Grades.Length;
            return count;
        }

        public void AddGrade(Grade newGrade)
        {
            Grade[] newGrades = new Grade[Grades.Length+1];
            for (int i = 0; i < Grades.Length; i++)
            {
                newGrades[i] = Grades[i];
            }
            newGrades[Grades.Length] = newGrade;
            Grades = newGrades;
        }
    }
}
