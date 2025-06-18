namespace ClassAndObject
{
    public class Program
    {
        
        public static void Main(String[] args)
        {
            Prime myobj = new Prime();
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            myobj.primeNumber(num);

           
            Console.WriteLine("Enter factorial number: ");
            long factData = Convert.ToInt32(Console.ReadLine());
            myobj.primeNumber(factData);



           
            Console.Write("Enter string value: ");
            string name = Console.ReadLine();
            string newValue = myobj.primeNumber(name);
            Console.WriteLine("Reverse: "+ newValue);
        }
    }
}