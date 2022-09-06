using System.Collections.Generic;

public class History{
    Stack<IMemento> memnetos = new Stack<IMemento>();

    public void push(IMemento memento){
        memnetos.Push(memento);
    }

    public void undo(){
        if(memnetos.Count > 0){
            memnetos.Pop().restore();
        }
    }

}