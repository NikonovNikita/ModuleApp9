namespace ModuleApp9
{
    public delegate void KeyPressEventDelegate();
    internal class KeyboardMaster
    {
        public event KeyPressEventDelegate wKeyPressedEvent = null;
        public event KeyPressEventDelegate sKeyPressedEvent = null;

        public void WKeyPressedMethod()
        {
            if(wKeyPressedEvent != null)
            {
                wKeyPressedEvent.Invoke();
            }
        }
        public void SKeyPressedMethod()
        {
            if(sKeyPressedEvent != null)
            {
                sKeyPressedEvent.Invoke();
            }
        }
    }
}
