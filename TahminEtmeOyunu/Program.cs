internal class Program
{
    private static void Main(string[] args)
    {
        string secretWord = "giraffe";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool outOfGuesses = false;
        while (guess != secretWord && !outOfGuesses)
        {
            if (guessCount < guessLimit)
            {
                Console.Write("Tahmininizi giriniz: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            else
            {
                outOfGuesses = true;
            }
        }
        if (outOfGuesses)
        {
            Console.WriteLine("Kaybettiniz!");
        }
        else
        {
            Console.WriteLine("Tebrikler, Kazandınız!");
        }   
        


    }
}