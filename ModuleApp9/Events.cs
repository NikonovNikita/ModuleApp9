namespace ModuleApp9
{
    public delegate void EventDelegate();
    internal class Event
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }
}
