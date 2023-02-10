namespace InputApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input Integer Array (Please seperate elemnets by comma): ");
                string inputString = Console.ReadLine();

                string[] inputElemets = inputString.Split(',');

                int[] input = new int[inputElemets.Length];

                for (int i = 0; i < inputElemets.Length; i++)
                {
                    input[i] = int.Parse(inputElemets[i]);
                }

                int sum = 1;

                foreach (int i in input)
                {
                    sum *= i;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = sum / input[i];
                }


                Console.WriteLine("Input: " + inputString);
                Console.WriteLine("Result: " + string.Join(", ", input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex.Message);
                Console.WriteLine("PLease try again.");
            }
        }
    }
}