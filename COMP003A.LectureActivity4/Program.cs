namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This "while" loop tracks tasks 1 through 5.
            int tasknumber = 1;
            while (tasknumber <= 5)
            {
                Console.WriteLine($"Task {tasknumber} completed");
                tasknumber++;
            }
            Console.WriteLine();
        }
    }
}
