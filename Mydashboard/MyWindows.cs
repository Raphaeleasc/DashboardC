using System;
using System.Windows.Forms;

class MyWindow : Form
{
    public MyWindow()
    {
        this.Text = "My First App";
        this.Width = 400;
        this.Height = 200;

        Button button = new Button();

        button.Text = "Cliquer Moi !!!";
        button.Left = 100;
        button.Top = 50;

        this.Controls.Add(button);
        
    
    
    
    }
}