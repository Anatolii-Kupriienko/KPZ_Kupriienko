namespace MementoClassLib
{
    public class MacrohardNumber : ICaretaker //this is the "text editor"
    {
        private IDocument OriginalDocument;
        private Stack<IMemento> Memetos = new Stack<IMemento>();

        public MacrohardNumber(IDocument document)
        {
            OriginalDocument = document;
        }

        public void Backup()
        {
            var snapshot = OriginalDocument.Save();
            Memetos.Push(snapshot);
            Console.WriteLine("Backing up state: " + snapshot.GetStateDescription());
        }

        public void Undo()
        {
            if (Memetos.Count == 0)
            {
                return;
            }

            var memento = Memetos.Pop();
            try
            {
                Console.WriteLine("Restoring state to: " + memento.GetStateDescription());
                OriginalDocument.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowDocument()
        {
            Console.WriteLine(OriginalDocument.Content);
        }
    }
}