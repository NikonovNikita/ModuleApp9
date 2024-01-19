using ModuleApp9;

class Program
{
    private static void EventHandler1()
    {
        Console.WriteLine("Запущен первый обработчик события");
    }
    
    private static void EventHandler2()
    {
        Console.WriteLine("Запущен второй обработчик события");
    }
    
    static void Main(string[] args)
    {
        Event instance = new Event();

        // Подписка на событие //

        instance.MyEvent += new EventDelegate(EventHandler1);
        instance.MyEvent += EventHandler2;

        instance.InvokeEvent();
    }
}
