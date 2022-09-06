

using System;

public class TextDocument : IUndoable<TextDocumentMemnto>
{
    string text = "";
    public Action textChanged;
    
    public string getText(){
        return text;
    }

    public void recover(TextDocumentMemnto memento)
    {
        changeText(memento.getText());
    }

    public IMemento save()
    {
        return new TextDocumentMemnto(this, text);
    }

    public void changeText(string newText){
        text = newText;
        textChanged?.Invoke();
        Console.WriteLine(text);
    }

}