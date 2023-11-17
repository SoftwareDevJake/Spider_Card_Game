using System;
using System.Drawing;
using System.Windows.Forms;

namespace Background
{
	public class BasicBackground
	{
		public Form backForm;
		
		public Panel backgroundpanel = new Panel();
		
		public Label scoreLabel = new Label();
		public string scoreTxt = "";
		
		public Label moveCountLabel = new Label();
		public int moveCount = 0;
		
		public Button testBtn = new Button();
		
		public void BasicBack(Form form)
		{
			backForm = form;
			
			Main();
			
			backForm.Controls.Add(scoreLabel);
			backForm.Controls.Add(moveCountLabel);
			backForm.Controls.Add(testBtn);
			
			backForm.Controls.Add(backgroundpanel);
		}
		
		public void Main()
		{
			// main green background
			backgroundpanel.Size = new Size(500, 500);
			backgroundpanel.BackColor = Color.Green;
			
			// score and moves
			scoreLabel.Location = new Point(230, 350);
			scoreLabel.AutoSize = true;
			scoreLabel.Text = "Score: ";
			
			moveCountLabel.Location = new Point(230, 370);
			moveCountLabel.AutoSize = true;
			moveCountLabel.Text = "Moves: ";
			
			testBtn.Location = new Point(200, 200);
			testBtn.Text = "TEST BUTTON";
			testBtn.Size = new Size(50, 50);
			testBtn.Click += new EventHandler(OnLeftClick);
		}
		
		public void OnLeftClick(object sender, EventArgs e)
		{
			Console.WriteLine("pressing");
			
			Console.WriteLine("x : " + Cursor.Position.X + " y : " + Cursor.Position.Y);
		}
	}
}