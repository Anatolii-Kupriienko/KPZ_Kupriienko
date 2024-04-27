using MementoClassLib;

string initialContent = "Hello, World!";
Document document = new Document(initialContent, initialContent.Length);
MacrohardNumber editor = new MacrohardNumber(document);

editor.ShowDocument();

editor.Backup();
document.AppendCharacter('!');
editor.ShowDocument();

editor.Backup();
document.AppendCharacter('*');
editor.ShowDocument();

editor.Backup();
document.EraseCharacter();
editor.ShowDocument();

editor.Undo();
editor.ShowDocument();

editor.Undo();
editor.ShowDocument();

editor.Undo();
editor.ShowDocument();