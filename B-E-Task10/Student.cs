namespace B_E_Task10
{
    internal class Student
    {
        private static int lastAge;
        public Student()
        {
            Age = ++lastAge;
            
        }
        public int Age { get; set; }
    }
}