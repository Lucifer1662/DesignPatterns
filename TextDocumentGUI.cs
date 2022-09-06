using System;
using System.Windows.Forms;

public class TextDocumentGUI : TextBox
{
    public Action<string> onChange;
    public TextDocumentGUI()
    {
        ReadOnly = true;
        (this as Control).KeyPress += (Object sender, KeyPressEventArgs e) =>
        {
            textChange(e.KeyChar.ToString());
        };
    }


    void textChange(string s)
    {
        onChange?.Invoke(s);
    }


}