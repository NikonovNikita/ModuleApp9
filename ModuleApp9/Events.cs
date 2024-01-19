namespace ModuleApp9
{
    internal class Events
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;
        internal void Read()
        {
            Console.WriteLine();
            Console.Write("Необходимо ввести значение 1 или 2: ");
            
            int number = Convert.ToInt32(Console.ReadLine());

            if(number != 1 && number != 2) throw new FormatException();

            NumberEntered(number);
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}
