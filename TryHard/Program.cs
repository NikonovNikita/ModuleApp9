class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        Console.WriteLine("Заполните список фамилий:");
        do
        {
            try
            {
                string userInput = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(userInput))
                    throw new ArgumentNullException();

                foreach(var s in userInput)
                {
                    if (char.IsDigit(s) || char.IsSymbol(s) || char.IsWhiteSpace(s))
                        throw new FormatException();
                }
                
                list.Add(userInput);
            }
            catch (Exception ex) when (ex is FormatException)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (list.Count < 5);
        
    }
}
