


public class  UndoCommand : Command {
    TextDocument document;
    string text;

    public UndoCommand(History history) : base(history)
    {
    }

    protected override IMemento exec()
    {
        history.undo();
        return null;
    }
}