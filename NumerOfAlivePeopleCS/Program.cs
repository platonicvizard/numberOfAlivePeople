using System;

namespace NumerOfAlivePeopleCS
{
    public class Program
    {
        static void Main(string[] args)
        {
            var other = new OtherProgram();
            other.Main(new string[] { "", "", "" }, (i) => {
                Console.WriteLine($"Index({i})");
            });
            Console.WriteLine("Hello World!");
        }
    }

    public class OtherProgram
    {
        public delegate void CallBack(int i);

        public void Main(String[] args, CallBack callBack)
        {
            
            if (args == null)
            {
                return;
            }

            for (int i = 0; i < args.Length; i++)
            {
                callBack(i);
            }
            Console.WriteLine("Other Program CallBack");
        }
    }
}
