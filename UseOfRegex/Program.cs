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

            ///UC5
            regexProblem.CheckPassmin8Char("Abc01234abre");

            ///UC6
            regexProblem.CheckPass8CharWithUpperCase("54bAvads");

            ///UC7
            regexProblem.CheckPass8CharWithNumber("abqmbAAAAA1");

            ///UC8
            regexProblem.CheckPass8CharWithSpecialChar("adf@asfwefwedw");

        }
    }
}