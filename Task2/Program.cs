using Task2;
class Program
{
    static void Main(string[] args)
    {
        EventPublisher eventPublisher = new EventPublisher();
        
        eventPublisher.EventClick_1 += Sort;
        eventPublisher.EventClick_2 += ReverseSort;

        eventPublisher.HowToSort(eventPublisher.ProcessBusinessLogiс());
    }

    static void Sort(List<string> list)
    {
        list.Sort();
        Console.WriteLine("Фамилии отсортированы в формате А-Я");
        Enumerate(list);
    }

    static void ReverseSort(List<string> list)
    {
        list.Sort();
        list.Reverse();
        Console.WriteLine("Фамилии отсортированы в формате Я-А");
        Enumerate(list);
    }

    static void Enumerate(List<string> list)
    {
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
    }


}
