namespace ClassLibrary1
{
    public class ExtClass : MyBaseClass
    {
        public string Name = "Awesome";

        public ExtClass(string name, string data) : base(12)
        {
            base.Name = data;
        }
    }

    public class MyBaseClass
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public MyBaseClass(int age)
        {
            Age = age;
        }
    }
}
