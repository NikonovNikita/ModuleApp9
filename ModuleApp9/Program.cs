using ModuleApp9;

class Program
{
    static private void buttonW_Click()
    {
        Console.WriteLine(" Вперед");
    }
    static private void buttonS_Click()
    {
        Console.WriteLine(" Назад");
    }
    static void Main(string[] args)
    {
        KeyboardMaster keyboardMaster = new KeyboardMaster();

        keyboardMaster.wKeyPressedEvent += buttonW_Click;
        keyboardMaster.sKeyPressedEvent += buttonS_Click;

        ConsoleKey userInput;
        
        while (true)
        {
            userInput = Console.ReadKey().Key;

            switch(userInput)
            {
                case ConsoleKey.W:
                    keyboardMaster.WKeyPressedMethod(); break;
                case ConsoleKey.S:
                    keyboardMaster.SKeyPressedMethod(); break;
            }
        }
    }
}
