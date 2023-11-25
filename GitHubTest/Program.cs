namespace GitHubTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] data = new int[5,5];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rnd.Next(0, 100);
                }
            }

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Массив создан");
        }
    }
}