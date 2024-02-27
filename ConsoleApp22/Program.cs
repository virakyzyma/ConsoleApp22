namespace ConsoleApp22
{
    internal class Program
    {
        static void Main()
        {
            String str = new String("Hello world");
            Console.WriteLine($"String: {str}. Length: {str.Length}");
            String str2 = new String(str, 6);
            Console.WriteLine($"String: {str2}. Length: {str2.Length}");
            String str3 = new String(10);
            Console.WriteLine($"String: {str3}. Length: {str3.Length}");
        }
    }
    public class String
    {
        char[] array;
        public int Length => array.Length;
        public char this[int index] => array[index];

        public override string ToString()
        {
            return array.Length == 0 ? "Empty string!" : new string(array);
        }
        public String(int length)
        {
            array = length <= 0 ? new char[0] : new char[length];
        }
        public String(string str)
        {
            array = str.ToCharArray();
        }
        public String(String str, int length)
        {
            if (length <= str.Length)
            {
                array = new char[length];
                for (int i = 0; i < length; i++)
                {
                    array[i] = str[i];
                }
            }
        }
    }
}
