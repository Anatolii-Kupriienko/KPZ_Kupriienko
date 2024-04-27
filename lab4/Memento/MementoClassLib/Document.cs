namespace MementoClassLib
{
    public class Document : IDocument
    {
        public string Content { get; private set; }
        public int CursorPosition { get; private set; }

        public Document(string content, int CursorPosition)
        {
            this.Content = content;
            this.CursorPosition = CursorPosition;
        }

        public void AppendCharacter(char c)
        {
            if (this.CursorPosition == this.Content.Length)
            {
                this.Content += c;
            }
            else
            {
                this.Content = this.Content.Substring(0, this.CursorPosition) + c + this.Content.Substring(this.CursorPosition);
            }
            this.CursorPosition++;
        }

        public void EraseCharacter()
        {
            if (this.Content.Length == 0 || this.CursorPosition == 0)
            {
                return;
            }

            if (this.CursorPosition == this.Content.Length)
            {
                this.Content = this.Content.Substring(0, this.Content.Length - 1);
            }
            else
            {
                this.Content = this.Content.Substring(0, this.CursorPosition - 1) + this.Content.Substring(this.CursorPosition);
            }
            this.CursorPosition--;
        }

        public void Restore(IMemento state)
        {
            var snapshot = state.GetState();
            this.Content = snapshot.Content;
            this.CursorPosition = snapshot.CursorPosition;
        }

        public IMemento Save()
        {
            return new DocumentMemeto(new Document(this.Content, this.CursorPosition));
        }
    }
}