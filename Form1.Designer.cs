namespace Clicker
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cpsTxtbox = new System.Windows.Forms.TextBox();
			this.cpsValue = new System.Windows.Forms.Label();
			this.btnToggle = new System.Windows.Forms.Button();
			this.Autoclicker = new System.Windows.Forms.Timer(this.components);
			this.Random = new System.Windows.Forms.Timer(this.components);
			this.randomTxt = new System.Windows.Forms.TextBox();
			this.bindBtn = new System.Windows.Forms.Button();
			this.Binding = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Orange;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clicker";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Orange;
			this.label2.Location = new System.Drawing.Point(14, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Left Click CPS";
			// 
			// cpsTxtbox
			// 
			this.cpsTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.cpsTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cpsTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cpsTxtbox.ForeColor = System.Drawing.Color.Orange;
			this.cpsTxtbox.Location = new System.Drawing.Point(17, 53);
			this.cpsTxtbox.Name = "cpsTxtbox";
			this.cpsTxtbox.Size = new System.Drawing.Size(282, 15);
			this.cpsTxtbox.TabIndex = 2;
			this.cpsTxtbox.Text = "100";
			this.cpsTxtbox.TextChanged += new System.EventHandler(this.cpsTxtbox_TextChanged);
			// 
			// cpsValue
			// 
			this.cpsValue.AutoSize = true;
			this.cpsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cpsValue.ForeColor = System.Drawing.Color.Orange;
			this.cpsValue.Location = new System.Drawing.Point(305, 52);
			this.cpsValue.Name = "cpsValue";
			this.cpsValue.Size = new System.Drawing.Size(28, 16);
			this.cpsValue.TabIndex = 3;
			this.cpsValue.Text = "100";
			// 
			// btnToggle
			// 
			this.btnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnToggle.ForeColor = System.Drawing.Color.Orange;
			this.btnToggle.Location = new System.Drawing.Point(110, 12);
			this.btnToggle.Name = "btnToggle";
			this.btnToggle.Size = new System.Drawing.Size(216, 35);
			this.btnToggle.TabIndex = 4;
			this.btnToggle.Text = "enable";
			this.btnToggle.UseVisualStyleBackColor = false;
			this.btnToggle.TextChanged += new System.EventHandler(this.btnToggle_TextChanged);
			this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
			// 
			// Autoclicker
			// 
			this.Autoclicker.Tick += new System.EventHandler(this.Autoclicker_Tick);
			// 
			// Random
			// 
			this.Random.Interval = 150;
			this.Random.Tick += new System.EventHandler(this.Random_Tick);
			// 
			// randomTxt
			// 
			this.randomTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.randomTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.randomTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.randomTxt.ForeColor = System.Drawing.Color.Orange;
			this.randomTxt.Location = new System.Drawing.Point(17, 95);
			this.randomTxt.Name = "randomTxt";
			this.randomTxt.Size = new System.Drawing.Size(282, 15);
			this.randomTxt.TabIndex = 5;
			this.randomTxt.TextChanged += new System.EventHandler(this.randomTxt_TextChanged);
			// 
			// bindBtn
			// 
			this.bindBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.bindBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.bindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindBtn.ForeColor = System.Drawing.Color.Orange;
			this.bindBtn.Location = new System.Drawing.Point(332, 12);
			this.bindBtn.Name = "bindBtn";
			this.bindBtn.Size = new System.Drawing.Size(92, 35);
			this.bindBtn.TabIndex = 7;
			this.bindBtn.Text = "none";
			this.bindBtn.UseVisualStyleBackColor = false;
			this.bindBtn.Click += new System.EventHandler(this.bindBtn_Click);
			this.bindBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindBtn_KeyDown);
			// 
			// Binding
			// 
			this.Binding.Enabled = true;
			this.Binding.Tick += new System.EventHandler(this.Binding_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bindBtn);
			this.Controls.Add(this.randomTxt);
			this.Controls.Add(this.btnToggle);
			this.Controls.Add(this.cpsValue);
			this.Controls.Add(this.cpsTxtbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox cpsTxtbox;
		private System.Windows.Forms.Label cpsValue;
		private System.Windows.Forms.Button btnToggle;
		private System.Windows.Forms.Timer Autoclicker;
		private System.Windows.Forms.Timer Random;
		private System.Windows.Forms.TextBox randomTxt;
		private System.Windows.Forms.Button bindBtn;
		private System.Windows.Forms.Timer Binding;
	}
}

