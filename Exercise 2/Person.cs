namespace Exercise_2
{
    class Person
    {
        private int age;
        //field age
        private string name = "";
        //field name

        public int Age // property for Age
        {
            get { return age; }     //getter
            set { age = value; }    //setter
        }

        public string Name // property for Name
        {
            get { return name; }    //getter
            set { name = value; }   //setter
        }

        public Person() //default constructor
        {
            this.age = 0;
            this.name = "default";
        }
        public Person(int age, string name)//constructor with 2 argument "age" and "name"
        {
            this.age = age;
            this.name = name;
        }

        public void DisplayPerson() //Display Person to console
        {
            System.Console.WriteLine("Person: \n\tName: " + Name + "\n\tAge: " + Age);
        }


        public override String ToString()// convert Person to string 
        {
            return "{name:" + Name + ",age:" + Age+"}";
        }

        public void Input(int age, string name)//set value to Input
        {
            this.age = age;
            this.name = name;
        }

    }
}