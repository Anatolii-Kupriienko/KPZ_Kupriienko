namespace MementoClassLib
{
    public interface IMemento
    {
        Document GetState();
        DateTime GetDate();
        string GetStateDescription();
    }
}