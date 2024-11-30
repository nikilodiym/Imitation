namespace Imitation
{
    public class Animal
    {
        private string? _name;
        private int? _age;
        private string? _type;

        public string Name
        {
            get => _name ?? "No name";
            set => _name = value;
        }

        public int Age
        {
            get => _age ?? -1;
            set => _age = value;
        }

        public string Type
        {
            get => _type ?? "No type";
            set => _type = value;
        }

        public Animal(string? name, int? age, string? type)
        {
            Name = name;
            Age = age ?? -1; // Fix: Use null-coalescing operator to provide a default value
            Type = type;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, World!: ");
            Console.Read();
        }
    }
}
