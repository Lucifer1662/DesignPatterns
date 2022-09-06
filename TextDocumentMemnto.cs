


public class TextDocumentMemnto : IMemento {
    TextDocument originator;
    string text;

    public string getText(){
        return text;
    }

    public TextDocumentMemnto(TextDocument originator, string text)
    {
        this.originator = originator;
        this.text = text;
    }

    public void restore()
    {
        originator.recover(this);
    }
}