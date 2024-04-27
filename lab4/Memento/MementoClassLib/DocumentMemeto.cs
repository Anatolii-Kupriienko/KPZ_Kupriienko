
using System.Text;

namespace MementoClassLib
{
    public class DocumentMemeto : IMemento
    {
        private readonly Document State;

        private readonly DateTime Date;

        public DocumentMemeto(Document state)
        {
            this.State = state;
            this.Date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return this.Date;
        }

        public Document GetState()
        {
            return this.State;
        }

        public string GetStateDescription()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(this.Date).Append(" // ");
            string content = this.State.Content;
            stringBuilder.Append(content).Append("... // with cursor at ").Append(this.State.CursorPosition);
            return stringBuilder.ToString();
        }
    }
}