namespace Exercise_2
{
    class Student : Person // Create Student class inherit from the Person class
    {
        private int gpa;
        //field gpa

        public int Gpa // property for Gpa
        {
            get { return gpa; } // getter
            set { gpa = value; }// setter
        }

        public Student() // default constructor
        {
            this.gpa = 0;
        }

        public Student(int gpa)//constructor with a argument "gpa"
        {
            this.gpa = gpa;
        }

        public override string ToString()// convert object Student to string
        {
            return "{name:" + Name + ",age: " + Age + ",gpa: " + Gpa+"}";
        }

        public void DisplayStudent()//display Student to console
        {
            System.Console.WriteLine("Student: \n\tName: " + Name + "\n\tAge: " + Age + "\n\tGpa: " + Gpa);
        }

        public void Input(int gpa){//set value to Student with a agrument "gpa"
            this.gpa = gpa;
        }
    }
}