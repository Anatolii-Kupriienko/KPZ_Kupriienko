namespace MediatorClassLibrary
{
    public interface IMediator
    {
        bool Notify(object sender, string ev);
    }
}