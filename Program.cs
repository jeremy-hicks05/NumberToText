namespace NumberToText
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string words = "";
            string? input;
            Console.WriteLine("Enter Series of Numbers");

            input = Console.ReadLine();

            Phone phone = new Phone();

            //var temp = phone.PressButton(2, 2).ToList();

            List<Tuple<string, int>> numbersAndReps =
                GetRepeats(input, phone).ToList();

            foreach (Tuple<string, int> pair in numbersAndReps)
            {
                words += new string(phone.PressButton(int.Parse(pair.Item1), pair.Item2).ToList().ToArray());
            }

            Console.WriteLine(words.ToString());
            Console.WriteLine("Finished!");
        }

        private static IEnumerable<Tuple<string, int>> GetRepeats(string numbers, Phone phone)
        {
            int pointer = 0;
            int repetitions = 1;
            // get the number of times each number repeats in a row
            char firstNumber = numbers[pointer];

            while (pointer < numbers.Length)
            {
                if (!(pointer + 1 == numbers.Length) &&
                    numbers[pointer] == numbers[pointer + 1])
                {
                    repetitions++;
                    pointer++;
                }
                else
                {
                    yield return new Tuple<string, int>(numbers[pointer].ToString(), repetitions);
                    repetitions = 1;
                    pointer++;
                }
            }
        }
    }
}
