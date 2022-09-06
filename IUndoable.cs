


public interface IUndoable<T> where T : IMemento {
    public void recover(T memento);
    public IMemento save();
}