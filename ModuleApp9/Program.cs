using ModuleApp9;

class Program
{
    static void Main(string[] args)
    {
        Events events = new Events();
        events.NumberEnteredEvent += ShowNumber;
        try
        {
            events.Read();
        }
        catch (FormatException)
        {
            Console.WriteLine("Введено некорректное значение!");
            
        }
    }

    static void ShowNumber(int number)
    {
        switch (number)
        {
            case 1: Console.WriteLine("Введено значение 1"); break;
            case 2: Console.WriteLine("Введено значение 2"); break;
        }
    }
}
