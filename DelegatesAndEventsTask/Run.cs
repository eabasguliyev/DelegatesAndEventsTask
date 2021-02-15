namespace DelegatesAndEventsTask
{
    public class Run
    {
        public void RunFunc(MyFunc func, string data)
        {
            func.Invoke(data);
        }
    }
}