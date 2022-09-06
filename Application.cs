using System;
using System.Windows.Forms;
using System.Drawing;

public class App
{
    TextDocument document = new TextDocument();
    History history = new History();

    TextDocumentGUI textDocumentGUI = new TextDocumentGUI();

    public void run()
    {
        Form mainForm = new Form();
        mainForm.KeyPreview = true;
        FlowLayoutPanel panel = new FlowLayoutPanel();
    
        
        Button undoButton = new Button();
        undoButton.Text = "Undo";
        var undoCommand = new UndoCommand(history);

        undoButton.Click += (sender, args)=>{
            undoCommand.run();
        };

        mainForm.Controls.Add(panel);
        panel.Controls.Add(textDocumentGUI);
        panel.Controls.Add(undoButton);



        textDocumentGUI.onChange = (string s) =>
        {
            var command = new ChangeTextCommand(document, s, history);
            command.run();
        };
        
        document.textChanged += () => {
            textDocumentGUI.Text = document.getText();
        };

        Application.Run(mainForm);

    }


    public static void Main()
    {
        App app = new App();
        app.run();
    }
}