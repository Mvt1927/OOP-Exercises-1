namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new();
            a.Input(age: 22, name: "mvt");
            a.Input(gpa: 10);
            a.DisplayStudent();
            a.DisplayPerson();
        }
    }
}