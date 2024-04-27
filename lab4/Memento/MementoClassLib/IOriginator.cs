namespace MementoClassLib
{
    public interface IDocument
    {
        string Content { get; }
        int CursorPosition { get; }

        IMemento Save();
        void Restore(IMemento state);
    }
}