public interface ISubject
{
    void AddObserver(IInGameObserver observer);
    void RemoveObserver(IInGameObserver observer);
}
