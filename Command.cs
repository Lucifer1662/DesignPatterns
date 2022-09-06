

public abstract class Command {

    protected History history;

    protected Command(History history)
    {
        this.history = history;
    }

    protected abstract IMemento exec();

    public void run(){
        var memento = exec();
        if(history != null && memento != null){
            history.push(memento);
        }

    }
}
