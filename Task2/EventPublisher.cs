namespace Task2
{
    public delegate void stringSorter(List<string> list);
    internal class EventPublisher
    {
        public event stringSorter EventClick_1;
        public event stringSorter EventClick_2;

        internal void Clicked_1(List<string> list)
        {
            EventClick_1?.Invoke(list);
        }
        
        internal void Clicked_2(List<string> list)
        {
            EventClick_2?.Invoke(list);
        }

        internal List<string> ProcessBusinessLogiс()
        {
            List<string> list = new List<string>();
            Console.WriteLine("Введите пять фамилий для сортировки:");

            do
            {
                try
                {
                    string userInput = Console.ReadLine();
                    
                    if (string.IsNullOrWhiteSpace(userInput))
                        throw new ArgumentNullException();
                    
                    foreach(var s in userInput)
                    {
                        if (char.IsDigit(s) || char.IsSymbol(s) || char.IsWhiteSpace(s) || char.IsPunctuation(s))
                            throw new IncorrectInputException("Исключение! Неверный формат ввода!");
                    }
                    
                    list.Add(userInput);
                }
                catch(Exception ex) when (ex is IncorrectInputException)
                {
                    Console.WriteLine($"\n{ex.Message}");
                    Console.WriteLine($"{ex.Data["DateTimeInfo"]}");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (list.Count < 5);
            return list;
        }

        internal void HowToSort(List<string> list)
        {
            do
            {
                try
                {
                    Console.WriteLine("\nВыберите способ сортировки списка фамилий:\n1 - Сортировка А-Я\n2 - Сортировка Я-А");

                    var userInput = int.Parse(Console.ReadLine());

                    if (userInput != 1 && userInput != 2)
                        throw new IncorrectInputException("Исключение! Допустимый ввод в формате 1 или 2");

                    switch (userInput)
                    {
                        case 1: Clicked_1(list); return;
                        case 2: Clicked_2(list); return;
                    }
                }
                catch (Exception ex) when (ex is IncorrectInputException)
                {
                    Console.WriteLine($"\n{ex.Message}");
                    Console.WriteLine($"{ex.Data["DateTimeInfo"]}");
                }
                catch(Exception ex) when (ex is FormatException)
                {
                    Console.WriteLine($"\n{ex.Message}");
                }
            } while (true);
        }
    }
}
