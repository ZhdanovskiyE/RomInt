namespace RomanToINT
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите римское число");
            string rome = Console.ReadLine();
            int answer = Detect(rome);
            Console.WriteLine(answer);
            Console.ReadLine();
        }


        public static int Detect(string rsym)
        {
            int total = 0;
            for (int i = 0; i < rsym.Length; i++)
                if (i + 1 < rsym.Length && CheckAct(rsym[i], rsym[i + 1]))
                {
                    total = total - dict[rsym[i]];
                }
                else
                { 
                    total = total + dict[rsym[i]];
                }
            return total;
        }

        private static bool CheckAct(char c1, char c2)
        {
            return dict[c1] < dict[c2];

        }

        private static Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

    }
}