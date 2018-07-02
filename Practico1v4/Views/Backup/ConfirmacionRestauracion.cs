using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Views.Backup
{
	public partial class ConfirmacionRestauracion : Form
	{
		public ConfirmacionRestauracion()
		{
			InitializeComponent();
		}

		string imagepath = @"C:\Users\Ezequiel\Desktop\BACKUPS\tempimage.bmp";

		private void CreateImage()
		{
			Random rand = new Random();
			string code = GetRandomText();
			Bitmap bitmap = new Bitmap(200, 50, PixelFormat.Format32bppArgb);
			Graphics g = Graphics.FromImage(bitmap);
			Pen pen = new Pen(Color.Yellow);
			Rectangle rect = new Rectangle(0, 0, 200, 50);
			SolidBrush b = new SolidBrush(Color.Black);
			SolidBrush White = new SolidBrush(Color.White);
			int counter = 0;
			g.DrawRectangle(pen, rect);
			g.FillRectangle(b, rect);
			for (int i = 0; i < code.Length; i++)
			{
				g.DrawString(code[i].ToString(), new Font("Georgia", 10 + rand.Next(14, 18)), White, new PointF(10 + counter, 10));
				counter += 20;
			}
			DrawRandomLines(g);
			Image img;
			

			//if (File.Exists(imagepath))
			//{
			//	try
			//	{
					
					
			//		File.Delete(imagepath);
					
			//		bitmap.Save(imagepath);
					
					
			//	}
			//	catch (Exception ex)
			//	{
			//		throw ex;
			//		//MessageBox.Show(ex.Message);
			//	}
			//}
			//else
			//{
			//	bitmap.Save(imagepath);
				
			//}
			using (var bmpTemp = new Bitmap(bitmap))
			{
				img = new Bitmap(bmpTemp);
				pictureBox1.Image = img;
			}

			g.Dispose();
			bitmap.Dispose();
			
			//pictureBox1.Image = Image.FromFile(imagepath);
			

		}

		string code;
		private string GetRandomText()
		{
			StringBuilder randomText = new StringBuilder();
			if (String.IsNullOrEmpty(code))
			{
				string alphabets = "abcdefghijklmnopqrstuvwxyz123456789";
				Random r = new Random();
				for (int j = 0; j <= 5; j++)
				{
					randomText.Append(alphabets[r.Next(alphabets.Length)]);
				}
				code = randomText.ToString();
			}
			return code;
		}

		private void DrawRandomLines(Graphics g)
		{
			SolidBrush green = new SolidBrush(Color.Green);
			//For Creating Lines on The Captcha 
			for (int i = 0; i < 20; i++)
			{
				g.DrawLines(new Pen(green, 2), GetRandomPoints());
			}

		}

		private Point[] GetRandomPoints()
		{
			Random rand = new Random();
			Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
			return points;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == code.ToString())
			{
				DialogResult = DialogResult.Yes;
			}
			else
			{
				MessageBox.Show("Incorrecto");
			}
		}

		private void ConfirmacionRestauracion_Load(object sender, EventArgs e)
		{
			CreateImage();
		}
	}
}
