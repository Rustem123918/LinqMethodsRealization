namespace LinqMethodsRealization
{
    sealed class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return Name + " " + Age.ToString();
        }
        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (student == null)
                return false;
            return student.Name == Name && student.Age == Age;
        }
        public override int GetHashCode()
        {
            var result = 0;
            foreach (var symbol in Name)
                result += symbol;
            result += Age * 7;
            return result;
        }
    }
}
