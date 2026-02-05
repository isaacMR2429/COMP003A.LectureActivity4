namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This "while" loop tracks tasks 1 through 5.
            Console.WriteLine("Section A: while - Loop Practice ");
            int tasknumber = 1;
            while (tasknumber <= 5)
            {
                Console.WriteLine($"Task {tasknumber} completed");
                tasknumber++;
            }

            /*
             * This "do-while" Loop repeats because the code inside the "do" block
             * runs before the condition gets checked
             */ 
            Console.WriteLine("\nSection B: do-while - Loop Practice");
            int attempt = 1;
            do
            {
                Console.WriteLine($"Attempt {attempt}");
                attempt++;
            }
            while (attempt <= 3);

            // This "for" loop works here because the number of steps is known
            Console.WriteLine("\nSection C: for - Loop Practice");
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Step {i}");
            }

            Console.WriteLine("\nSection D: Loop Control (break and continue)");
            int number = 0;
            while (number <= 6)
            {
                number++;
                if (number == 4)
                {
                    continue; // Continue will skip number 4 from being shown
                }
                if (number == 6)
                {
                    break; //Break will stop the loop when the number gets to 6
                }
                Console.WriteLine(number);
            }
            /*
             * Section E: Loop Tracing and Reflection
             * 
             * The loop the was easiest for me to understand is "for" loop,
             * because you're setting up the condition and letting it know from what numbers it needs to loop
             * 
             * 
             * 
             */ 
        }
    }
}
