using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

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
		
		public Button firstPlace = new Button();
		public Button secondPlace = new Button();
		public Image image = Image.FromFile("/workspace/Spider_Card_Game/img/Card_back.png");
		
		public void BasicBack(Form form)
		{
			backForm = form;
			
			Main();
			
			backForm.Controls.Add(scoreLabel);
			backForm.Controls.Add(moveCountLabel);
			
			backForm.Controls.Add(testBtn);
			backForm.Controls.Add(firstPlace);
			backForm.Controls.Add(secondPlace);
			
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
			
			firstPlace.Location = new Point(100, 100);
			firstPlace.Size = new Size(50, 50);
			firstPlace.Image = image;
			
			secondPlace.Location = new Point(200, 100);
			secondPlace.Size = new Size(50, 50);
			secondPlace.Image = image;
		}
		
		public void OnLeftClick(object sender, EventArgs e)
		{
			Point originalPoint = new Point(testBtn.Location.X, testBtn.Location.Y);
			// **IT HAS A PROBLEM WITH WHILE LOOP THERFORE I MADE IT WITH FOR WITHIN 500 FRAMES OF SPEED**
			for(int i = 1; i <= 500; i++)
			{
				testBtn.Location = new Point(Cursor.Position.X, Cursor.Position.Y + 80);
				// testBtn.Refresh();
			}
			// **IT HAS A PROBLEM WITH WHILE LOOP THERFORE I MADE IT WITH FOR WITHIN 500 FRAMES OF SPEED**
			Console.WriteLine("distance : " + GetDistance(testBtn.Location.X, firstPlace.Location.X, testBtn.Location.Y, firstPlace.Location.Y));
			
			double distance = GetDistance(testBtn.Location.X, firstPlace.Location.X, testBtn.Location.Y, firstPlace.Location.Y);
			if(-50 < distance && distance < 50)
			{
				testBtn.Location = new Point(firstPlace.Location.X, firstPlace.Location.Y + 10);
			}
			else
			{
				testBtn.Location = originalPoint;
			}
			
		}
		
		public double GetDistance(double x1, double y1, double x2, double y2)
		{
			 return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
		}
	}
}