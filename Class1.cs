namespace ClassLibrary1
{
    public class ExtClass : MyBaseClass
    {
        public string Name = "Extended.Class";

        public ExtClass(string name)
        {
            base.Name = name;
        }
    }

    public class MyBaseClass
    {
        public string Name { get; set; }
    }
}
