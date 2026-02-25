namespace ThirdTask
{
    public class Logic
    {
        public static double CalculatePercentLetter(string str)
        {
            var count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    count++;
                }
            }
            return Math.Round((double)count / str.Length * 100, 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дано предложение. Определить долю (в %) букв в нем.
            Console.Write("Введите предложение ... ");
            string str = Console.ReadLine();
            
            var percent = Logic.CalculatePercentLetter(str);
            Console.WriteLine("Доля букв в ашем предложении: "+percent);
        }
    }
}
