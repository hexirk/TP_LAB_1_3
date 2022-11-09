namespace Sizykh_lab_1_3
{
    public class Logic
    {
        public static string Reverse(string str)
        {
            string message = "";
            string[] words = str.Split(" ");
            str = "";
            for (int i = words.Length; i > 0; i--)
            {
                str = str + words[i-1] + " ";
            }
            message = "Перевернутое предложение: \n" + str;
            return message;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            var str = Console.ReadLine();
            var outMessage = Logic.Reverse(str);
            Console.WriteLine(outMessage);
            Console.ReadLine();
        }
    }
}