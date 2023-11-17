using System;
using System.Drawing;
using System.Windows.Forms;

using Background;

class MForm : Form {
    public MForm() {
		
		this.Width = 500;
		this.Height = 500;
		
        BasicBackground back = new BasicBackground();

		back.BasicBack(this);
		
        CenterToScreen();
    }

    void OnExit(object sender, EventArgs e) {
       Close();
    }
}

class MApplication {
    public static void Main() {
        Application.Run(new MForm());
    }
}
