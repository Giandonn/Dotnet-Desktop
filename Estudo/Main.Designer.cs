

namespace Estudo
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			textBox1 = new TextBox();
			label2 = new Label();
			label1 = new Label();
			textBox2 = new TextBox();
			label3 = new Label();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Font = new Font("Microsoft Sans Serif", 8.25F);
			button1.Location = new Point(363, 272);
			button1.Name = "button1";
			button1.Size = new Size(100, 23);
			button1.TabIndex = 1;
			button1.Text = "Calculate";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(300, 210);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 2;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F);
			label2.Location = new Point(406, 213);
			label2.Name = "label2";
			label2.Size = new Size(18, 20);
			label2.TabIndex = 0;
			label2.Text = "X";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F);
			label1.Location = new Point(554, 213);
			label1.Name = "label1";
			label1.Size = new Size(52, 20);
			label1.TabIndex = 0;
			label1.Text = "Result:";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(430, 210);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 2;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11F);
			label3.Location = new Point(300, 135);
			label3.Name = "label3";
			label3.Size = new Size(245, 20);
			label3.TabIndex = 0;
			label3.Text = "FILL BOTH FIELDS TO MULTIPLICATE";
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(button1);
			Name = "Main";
			Text = "Estudo";
			Load += Main_Load_3;
			ResumeLayout(false);
			PerformLayout();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		//evento de click no botão
		private void button1_Click(object sender, EventArgs e)
		{
			var n1 = Convert.ToInt32(textBox1.Text);
			var n2 = Convert.ToInt32(textBox2.Text);
			var result = n1 * n2;
			label1.Text = result.ToString();
		}

		//alteraçao do texto da label1
		private void Main_Load_3(object sender, EventArgs e)
		{
			label1.Text = "Result:"; 
		}

#endregion
		private Button button1;
		private TextBox textBox1;
		private Label label2;
		private Label label1;
		private TextBox textBox2;
		private Label label3;
	}
}
