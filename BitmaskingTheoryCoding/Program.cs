namespace BitmaskingTheoryCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UpperToLower(new() {'a', 'H', 'a', 'A', 'n', 'T', 'h', 'a', 'K', 'u', 'r'});
            LowerToUpper(new() { 'a', 'H', 'a', 'A', 'n', 'T', 'h', 'a', 'K', 'u', 'r' });
            SwitchingCase(new() { 'a', 'H', 'a', 'A', 'n', 'T', 'h', 'a', 'K', 'u', 'r' });
            Console.ReadLine();
        }

        static void UpperToLower(List<char> Input)
        {
            Console.WriteLine($"The input is {string.Join("", Input)}");
            int x = 32;
            for (int i = 0; i < Input.Count(); i++)
            {
                Input[i] = Convert.ToChar(Convert.ToInt16(Input[i]) | x);
            }
            Console.WriteLine($"The output is {string.Join("", Input)}");
        }

        static void LowerToUpper(List<char> Input)
        {
            Console.WriteLine($"The input is {string.Join("", Input)}");
            int x = 32;
            for (int i = 0; i < Input.Count(); i++)
            {
                Input[i] = Convert.ToChar(Convert.ToInt16(Input[i]) & ~x);
            }
            Console.WriteLine($"The output is {string.Join("", Input)}");
        }

        static void SwitchingCase(List<char> Input)
        {
            Console.WriteLine($"The input is {string.Join("", Input)}");
            int x = 32;
            for (int i = 0; i < Input.Count(); i++)
            {
                Input[i] = Convert.ToChar(Convert.ToInt16(Input[i]) ^ x);
            }
            Console.WriteLine($"The output is {string.Join("", Input)}");
        }
    }
}