namespace Observer
{

    public interface IObserver
    {
        void Update();
        void StartReporting(IObservable provider);
        

    }
    
}