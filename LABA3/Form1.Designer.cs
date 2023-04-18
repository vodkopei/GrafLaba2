namespace LABA3
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
            this.textBoxTranslateX = new System.Windows.Forms.TextBox();
            this.textBoxTranslateY = new System.Windows.Forms.TextBox();
            this.textBoxRotateAngle = new System.Windows.Forms.TextBox();
            this.textBoxScaleX = new System.Windows.Forms.TextBox();
            this.textBoxScaleY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxReflectAxis = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxRotateAngle1 = new System.Windows.Forms.TextBox();
            this.textBoxTranslateY1 = new System.Windows.Forms.TextBox();
            this.textBoxTranslateX1 = new System.Windows.Forms.TextBox();
            this.textBoxScaleY1 = new System.Windows.Forms.TextBox();
            this.textBoxScaleX1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTranslateX
            // 
            this.textBoxTranslateX.Location = new System.Drawing.Point(115, 6);
            this.textBoxTranslateX.Name = "textBoxTranslateX";
            this.textBoxTranslateX.Size = new System.Drawing.Size(100, 20);
            this.textBoxTranslateX.TabIndex = 0;
            this.textBoxTranslateX.Enter += new System.EventHandler(this.textBoxTranslateX_Enter);
            this.textBoxTranslateX.Leave += new System.EventHandler(this.textBoxTranslateX_Leave);
            // 
            // textBoxTranslateY
            // 
            this.textBoxTranslateY.Location = new System.Drawing.Point(115, 31);
            this.textBoxTranslateY.Name = "textBoxTranslateY";
            this.textBoxTranslateY.Size = new System.Drawing.Size(100, 20);
            this.textBoxTranslateY.TabIndex = 1;
            this.textBoxTranslateY.Enter += new System.EventHandler(this.textBoxTranslateY_Enter);
            this.textBoxTranslateY.Leave += new System.EventHandler(this.textBoxTranslateY_Leave);
            // 
            // textBoxRotateAngle
            // 
            this.textBoxRotateAngle.Location = new System.Drawing.Point(110, 6);
            this.textBoxRotateAngle.Name = "textBoxRotateAngle";
            this.textBoxRotateAngle.Size = new System.Drawing.Size(100, 20);
            this.textBoxRotateAngle.TabIndex = 8;
            this.textBoxRotateAngle.Enter += new System.EventHandler(this.textBoxRotateAngle_Enter);
            this.textBoxRotateAngle.Leave += new System.EventHandler(this.textBoxRotateAngle_Leave);
            // 
            // textBoxScaleX
            // 
            this.textBoxScaleX.Location = new System.Drawing.Point(110, 6);
            this.textBoxScaleX.Name = "textBoxScaleX";
            this.textBoxScaleX.Size = new System.Drawing.Size(100, 20);
            this.textBoxScaleX.TabIndex = 9;
            this.textBoxScaleX.Enter += new System.EventHandler(this.textBoxScaleX_Enter);
            this.textBoxScaleX.Leave += new System.EventHandler(this.textBoxScaleX_Leave);
            // 
            // textBoxScaleY
            // 
            this.textBoxScaleY.Location = new System.Drawing.Point(110, 32);
            this.textBoxScaleY.Name = "textBoxScaleY";
            this.textBoxScaleY.Size = new System.Drawing.Size(100, 20);
            this.textBoxScaleY.TabIndex = 10;
            this.textBoxScaleY.TextChanged += new System.EventHandler(this.textBoxScaleY_TextChanged);
            this.textBoxScaleY.Enter += new System.EventHandler(this.textBoxScaleY_Enter);
            this.textBoxScaleY.Leave += new System.EventHandler(this.textBoxScaleY_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Транформ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Транформ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Транформ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // comboBoxReflectAxis
            // 
            this.comboBoxReflectAxis.FormattingEnabled = true;
            this.comboBoxReflectAxis.Location = new System.Drawing.Point(105, 6);
            this.comboBoxReflectAxis.Name = "comboBoxReflectAxis";
            this.comboBoxReflectAxis.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReflectAxis.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Транформ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonReflect_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1106, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "Очистити";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Reset);
            // 
            // textBoxRotateAngle1
            // 
            this.textBoxRotateAngle1.Location = new System.Drawing.Point(6, 33);
            this.textBoxRotateAngle1.Name = "textBoxRotateAngle1";
            this.textBoxRotateAngle1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRotateAngle1.TabIndex = 33;
            this.textBoxRotateAngle1.TextChanged += new System.EventHandler(this.textBoxRotateAngle1_TextChanged);
            this.textBoxRotateAngle1.Enter += new System.EventHandler(this.textBoxRotateAngle1_Enter);
            this.textBoxRotateAngle1.Leave += new System.EventHandler(this.textBoxRotateAngle1_Leave);
            // 
            // textBoxTranslateY1
            // 
            this.textBoxTranslateY1.Location = new System.Drawing.Point(112, 7);
            this.textBoxTranslateY1.Name = "textBoxTranslateY1";
            this.textBoxTranslateY1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTranslateY1.TabIndex = 36;
            this.textBoxTranslateY1.Enter += new System.EventHandler(this.textBoxTranslateY1_Enter);
            this.textBoxTranslateY1.Leave += new System.EventHandler(this.textBoxTranslateY1_Leave);
            // 
            // textBoxTranslateX1
            // 
            this.textBoxTranslateX1.Location = new System.Drawing.Point(6, 7);
            this.textBoxTranslateX1.Name = "textBoxTranslateX1";
            this.textBoxTranslateX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTranslateX1.TabIndex = 35;
            this.textBoxTranslateX1.Enter += new System.EventHandler(this.textBoxTranslateX1_Enter);
            this.textBoxTranslateX1.Leave += new System.EventHandler(this.textBoxTranslateX1_Leave);
            // 
            // textBoxScaleY1
            // 
            this.textBoxScaleY1.Location = new System.Drawing.Point(6, 59);
            this.textBoxScaleY1.Name = "textBoxScaleY1";
            this.textBoxScaleY1.Size = new System.Drawing.Size(100, 20);
            this.textBoxScaleY1.TabIndex = 40;
            this.textBoxScaleY1.Enter += new System.EventHandler(this.textBoxScaleY1_Enter);
            this.textBoxScaleY1.Leave += new System.EventHandler(this.textBoxScaleY1_Leave);
            // 
            // textBoxScaleX1
            // 
            this.textBoxScaleX1.Location = new System.Drawing.Point(112, 33);
            this.textBoxScaleX1.Name = "textBoxScaleX1";
            this.textBoxScaleX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxScaleX1.TabIndex = 39;
            this.textBoxScaleX1.Enter += new System.EventHandler(this.textBoxScaleX1_Enter);
            this.textBoxScaleX1.Leave += new System.EventHandler(this.textBoxScaleX1_Leave);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 43;
            this.button5.Text = "Транформ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.All_At_once);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(860, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 149);
            this.tabControl1.TabIndex = 45;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxTranslateY1);
            this.tabPage1.Controls.Add(this.textBoxTranslateX1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.textBoxScaleX1);
            this.tabPage1.Controls.Add(this.textBoxRotateAngle1);
            this.tabPage1.Controls.Add(this.textBoxScaleY1);
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxTranslateX);
            this.tabPage2.Controls.Add(this.textBoxTranslateY);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(313, 120);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "паралельне перенесення";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxRotateAngle);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(313, 120);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "поворот об\'єкта";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxScaleX);
            this.tabPage4.Controls.Add(this.textBoxScaleY);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 49);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(313, 96);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Стиснення/Розтягування";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBoxReflectAxis);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Location = new System.Drawing.Point(4, 49);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(313, 96);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "відобразити об\'єкт ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 662);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button6);
            this.Name = "Form1";
            this.Text = "LABA2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxTranslateX;
		private System.Windows.Forms.TextBox textBoxTranslateY;
		private System.Windows.Forms.TextBox textBoxRotateAngle;
		private System.Windows.Forms.TextBox textBoxScaleX;
		private System.Windows.Forms.TextBox textBoxScaleY;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox comboBoxReflectAxis;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBoxRotateAngle1;
		private System.Windows.Forms.TextBox textBoxTranslateY1;
		private System.Windows.Forms.TextBox textBoxTranslateX1;
		private System.Windows.Forms.TextBox textBoxScaleY1;
		private System.Windows.Forms.TextBox textBoxScaleX1;
		private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

