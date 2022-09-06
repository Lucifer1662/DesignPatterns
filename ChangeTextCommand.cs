


using System;

public class  ChangeTextCommand : Command {
    TextDocument document;
    string text;

    public ChangeTextCommand(TextDocument document, string text, History history) : base(history)
    {
        this.document = document;
        this.text = text;
    }

    protected override IMemento exec()
    {
        var memento = document.save();
        document.changeText(document.getText() + text);
        return memento;
    }
}