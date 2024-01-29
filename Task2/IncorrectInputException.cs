namespace Task2
{
    internal class IncorrectInputException : FormatException
    {
        public IncorrectInputException(string message) : base(message)
        {
            Data.Add("DateTimeInfo", DateTime.Now);
        }
    }
}
