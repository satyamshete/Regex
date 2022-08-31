namespace UseOfRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regex Problems");
            RegexProblem regexProblem = new RegexProblem();

            ////UC1 
            regexProblem.CheckFirstName("Viraj");

            ////UC2
            regexProblem.CheckLastName("Shinde");

            ///UC3
            regexProblem.CheckEmail("abc.xyz@bl.co.in");

            ///UC4
            regexProblem.CheckMobilNumber("91 9145896327");

        }
    }
}