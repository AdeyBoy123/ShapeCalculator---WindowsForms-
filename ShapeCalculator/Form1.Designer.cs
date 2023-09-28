namespace ShapeCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelRectangleHeight = new System.Windows.Forms.Label();
            this.labelRectangleLength = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.buttonAreaCalc = new System.Windows.Forms.Button();
            this.labelAreaResult = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCircleArea = new System.Windows.Forms.TextBox();
            this.textBoxCircleCircumference = new System.Windows.Forms.TextBox();
            this.labelCirclePerimeter = new System.Windows.Forms.Label();
            this.buttonCircleArea = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTriangleArea = new System.Windows.Forms.Label();
            this.labelTrianglePerimeter = new System.Windows.Forms.Label();
            this.textBoxTriangleArea = new System.Windows.Forms.TextBox();
            this.textBoxTrianglePerimeter = new System.Windows.Forms.TextBox();
            this.labelTriangleBase = new System.Windows.Forms.Label();
            this.labelTriangleHeight = new System.Windows.Forms.Label();
            this.textBoxTriangleBase = new System.Windows.Forms.TextBox();
            this.textBoxTriangleHeight = new System.Windows.Forms.TextBox();
            this.buttonTriangleArea = new System.Windows.Forms.Button();
            this.buttonTrianglePerimeter = new System.Windows.Forms.Button();
            this.labelTriangleSide1 = new System.Windows.Forms.Label();
            this.labelTriangleSide2 = new System.Windows.Forms.Label();
            this.labelTriangleSide3 = new System.Windows.Forms.Label();
            this.textBoxTriangleSide1 = new System.Windows.Forms.TextBox();
            this.textBoxTriangleSide2 = new System.Windows.Forms.TextBox();
            this.textBoxTriangleSide3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rectangle Calculation";
            // 
            // labelRectangleHeight
            // 
            this.labelRectangleHeight.AutoSize = true;
            this.labelRectangleHeight.Location = new System.Drawing.Point(11, 35);
            this.labelRectangleHeight.Name = "labelRectangleHeight";
            this.labelRectangleHeight.Size = new System.Drawing.Size(155, 13);
            this.labelRectangleHeight.TabIndex = 1;
            this.labelRectangleHeight.Text = "Enter Rectangle Height (in cm):";
            // 
            // labelRectangleLength
            // 
            this.labelRectangleLength.AutoSize = true;
            this.labelRectangleLength.Location = new System.Drawing.Point(11, 61);
            this.labelRectangleLength.Name = "labelRectangleLength";
            this.labelRectangleLength.Size = new System.Drawing.Size(157, 13);
            this.labelRectangleLength.TabIndex = 2;
            this.labelRectangleLength.Text = "Enter Rectangle Length (in cm):";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(172, 32);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 3;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(172, 61);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxLength.TabIndex = 4;
            // 
            // buttonAreaCalc
            // 
            this.buttonAreaCalc.Location = new System.Drawing.Point(461, 25);
            this.buttonAreaCalc.Name = "buttonAreaCalc";
            this.buttonAreaCalc.Size = new System.Drawing.Size(106, 23);
            this.buttonAreaCalc.TabIndex = 5;
            this.buttonAreaCalc.Text = "Calculate Area";
            this.buttonAreaCalc.UseVisualStyleBackColor = true;
            this.buttonAreaCalc.Click += new System.EventHandler(this.buttonAreaCalc_Click);
            // 
            // labelAreaResult
            // 
            this.labelAreaResult.AutoSize = true;
            this.labelAreaResult.Location = new System.Drawing.Point(291, 35);
            this.labelAreaResult.Name = "labelAreaResult";
            this.labelAreaResult.Size = new System.Drawing.Size(32, 13);
            this.labelAreaResult.TabIndex = 6;
            this.labelAreaResult.Text = "Area:";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(329, 32);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxArea.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Calculate Perimeter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(291, 61);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(54, 13);
            this.labelPerimeter.TabIndex = 10;
            this.labelPerimeter.Text = "Perimeter:";
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Location = new System.Drawing.Point(351, 58);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxPerimeter.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Circle Calculation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter radius of Circle:";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(129, 146);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadius.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Circle Area:";
            // 
            // textBoxCircleArea
            // 
            this.textBoxCircleArea.Location = new System.Drawing.Point(87, 181);
            this.textBoxCircleArea.Name = "textBoxCircleArea";
            this.textBoxCircleArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxCircleArea.TabIndex = 16;
            // 
            // textBoxCircleCircumference
            // 
            this.textBoxCircleCircumference.Location = new System.Drawing.Point(130, 207);
            this.textBoxCircleCircumference.Name = "textBoxCircleCircumference";
            this.textBoxCircleCircumference.Size = new System.Drawing.Size(100, 20);
            this.textBoxCircleCircumference.TabIndex = 17;
            // 
            // labelCirclePerimeter
            // 
            this.labelCirclePerimeter.AutoSize = true;
            this.labelCirclePerimeter.Location = new System.Drawing.Point(20, 210);
            this.labelCirclePerimeter.Name = "labelCirclePerimeter";
            this.labelCirclePerimeter.Size = new System.Drawing.Size(104, 13);
            this.labelCirclePerimeter.TabIndex = 18;
            this.labelCirclePerimeter.Text = "Circle Circumference";
            // 
            // buttonCircleArea
            // 
            this.buttonCircleArea.Location = new System.Drawing.Point(193, 178);
            this.buttonCircleArea.Name = "buttonCircleArea";
            this.buttonCircleArea.Size = new System.Drawing.Size(113, 23);
            this.buttonCircleArea.TabIndex = 19;
            this.buttonCircleArea.Text = "Calculate Circle Area";
            this.buttonCircleArea.UseVisualStyleBackColor = true;
            this.buttonCircleArea.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(236, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Calculate Circle Circumference";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Triangle Calculation";
            // 
            // labelTriangleArea
            // 
            this.labelTriangleArea.AutoSize = true;
            this.labelTriangleArea.Location = new System.Drawing.Point(8, 354);
            this.labelTriangleArea.Name = "labelTriangleArea";
            this.labelTriangleArea.Size = new System.Drawing.Size(73, 13);
            this.labelTriangleArea.TabIndex = 22;
            this.labelTriangleArea.Text = "Triangle Area:";
            // 
            // labelTrianglePerimeter
            // 
            this.labelTrianglePerimeter.AutoSize = true;
            this.labelTrianglePerimeter.Location = new System.Drawing.Point(11, 485);
            this.labelTrianglePerimeter.Name = "labelTrianglePerimeter";
            this.labelTrianglePerimeter.Size = new System.Drawing.Size(95, 13);
            this.labelTrianglePerimeter.TabIndex = 23;
            this.labelTrianglePerimeter.Text = "Triangle Perimeter:";
            // 
            // textBoxTriangleArea
            // 
            this.textBoxTriangleArea.Location = new System.Drawing.Point(87, 354);
            this.textBoxTriangleArea.Name = "textBoxTriangleArea";
            this.textBoxTriangleArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxTriangleArea.TabIndex = 24;
            // 
            // textBoxTrianglePerimeter
            // 
            this.textBoxTrianglePerimeter.Location = new System.Drawing.Point(112, 485);
            this.textBoxTrianglePerimeter.Name = "textBoxTrianglePerimeter";
            this.textBoxTrianglePerimeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrianglePerimeter.TabIndex = 25;
//            this.textBoxTrianglePerimeter.TextChanged += new System.EventHandler(this.textBoxTrianglePerimeter_TextChanged);
            // 
            // labelTriangleBase
            // 
            this.labelTriangleBase.AutoSize = true;
            this.labelTriangleBase.Location = new System.Drawing.Point(11, 295);
            this.labelTriangleBase.Name = "labelTriangleBase";
            this.labelTriangleBase.Size = new System.Drawing.Size(103, 13);
            this.labelTriangleBase.TabIndex = 26;
            this.labelTriangleBase.Text = "Enter Triangle Base:";
            // 
            // labelTriangleHeight
            // 
            this.labelTriangleHeight.AutoSize = true;
            this.labelTriangleHeight.Location = new System.Drawing.Point(12, 327);
            this.labelTriangleHeight.Name = "labelTriangleHeight";
            this.labelTriangleHeight.Size = new System.Drawing.Size(110, 13);
            this.labelTriangleHeight.TabIndex = 27;
            this.labelTriangleHeight.Text = "Enter Triangle Height:";
            // 
            // textBoxTriangleBase
            // 
            this.textBoxTriangleBase.Location = new System.Drawing.Point(120, 292);
            this.textBoxTriangleBase.Name = "textBoxTriangleBase";
            this.textBoxTriangleBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxTriangleBase.TabIndex = 28;
            // 
            // textBoxTriangleHeight
            // 
            this.textBoxTriangleHeight.Location = new System.Drawing.Point(130, 327);
            this.textBoxTriangleHeight.Name = "textBoxTriangleHeight";
            this.textBoxTriangleHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxTriangleHeight.TabIndex = 29;
            // 
            // buttonTriangleArea
            // 
            this.buttonTriangleArea.Location = new System.Drawing.Point(193, 351);
            this.buttonTriangleArea.Name = "buttonTriangleArea";
            this.buttonTriangleArea.Size = new System.Drawing.Size(126, 23);
            this.buttonTriangleArea.TabIndex = 30;
            this.buttonTriangleArea.Text = "Calculate Triangle Area";
            this.buttonTriangleArea.UseVisualStyleBackColor = true;
            this.buttonTriangleArea.Click += new System.EventHandler(this.buttonTriangleArea_Click);
            // 
            // buttonTrianglePerimeter
            // 
            this.buttonTrianglePerimeter.Location = new System.Drawing.Point(218, 480);
            this.buttonTrianglePerimeter.Name = "buttonTrianglePerimeter";
            this.buttonTrianglePerimeter.Size = new System.Drawing.Size(168, 23);
            this.buttonTrianglePerimeter.TabIndex = 31;
            this.buttonTrianglePerimeter.Text = "Calculate Triangle Perimeter";
            this.buttonTrianglePerimeter.UseVisualStyleBackColor = true;
            this.buttonTrianglePerimeter.Click += new System.EventHandler(this.buttonTrianglePerimeter_Click);
            // 
            // labelTriangleSide1
            // 
            this.labelTriangleSide1.AutoSize = true;
            this.labelTriangleSide1.Location = new System.Drawing.Point(8, 404);
            this.labelTriangleSide1.Name = "labelTriangleSide1";
            this.labelTriangleSide1.Size = new System.Drawing.Size(66, 13);
            this.labelTriangleSide1.TabIndex = 32;
            this.labelTriangleSide1.Text = "Enter side 1:";
            // 
            // labelTriangleSide2
            // 
            this.labelTriangleSide2.AutoSize = true;
            this.labelTriangleSide2.Location = new System.Drawing.Point(8, 429);
            this.labelTriangleSide2.Name = "labelTriangleSide2";
            this.labelTriangleSide2.Size = new System.Drawing.Size(66, 13);
            this.labelTriangleSide2.TabIndex = 33;
            this.labelTriangleSide2.Text = "Enter side 2:";
            // 
            // labelTriangleSide3
            // 
            this.labelTriangleSide3.AutoSize = true;
            this.labelTriangleSide3.Location = new System.Drawing.Point(8, 457);
            this.labelTriangleSide3.Name = "labelTriangleSide3";
            this.labelTriangleSide3.Size = new System.Drawing.Size(66, 13);
            this.labelTriangleSide3.TabIndex = 34;
            this.labelTriangleSide3.Text = "Enter side 3:";
            // 
            // textBoxTriangleSide1
            // 
            this.textBoxTriangleSide1.Location = new System.Drawing.Point(80, 401);
            this.textBoxTriangleSide1.Name = "textBoxTriangleSide1";
            this.textBoxTriangleSide1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTriangleSide1.TabIndex = 35;
            // 
            // textBoxTriangleSide2
            // 
            this.textBoxTriangleSide2.Location = new System.Drawing.Point(80, 427);
            this.textBoxTriangleSide2.Name = "textBoxTriangleSide2";
            this.textBoxTriangleSide2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTriangleSide2.TabIndex = 36;
            // 
            // textBoxTriangleSide3
            // 
            this.textBoxTriangleSide3.Location = new System.Drawing.Point(80, 454);
            this.textBoxTriangleSide3.Name = "textBoxTriangleSide3";
            this.textBoxTriangleSide3.Size = new System.Drawing.Size(100, 20);
            this.textBoxTriangleSide3.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 590);
            this.Controls.Add(this.textBoxTriangleSide3);
            this.Controls.Add(this.textBoxTriangleSide2);
            this.Controls.Add(this.textBoxTriangleSide1);
            this.Controls.Add(this.labelTriangleSide3);
            this.Controls.Add(this.labelTriangleSide2);
            this.Controls.Add(this.labelTriangleSide1);
            this.Controls.Add(this.buttonTrianglePerimeter);
            this.Controls.Add(this.buttonTriangleArea);
            this.Controls.Add(this.textBoxTriangleHeight);
            this.Controls.Add(this.textBoxTriangleBase);
            this.Controls.Add(this.labelTriangleHeight);
            this.Controls.Add(this.labelTriangleBase);
            this.Controls.Add(this.textBoxTrianglePerimeter);
            this.Controls.Add(this.textBoxTriangleArea);
            this.Controls.Add(this.labelTrianglePerimeter);
            this.Controls.Add(this.labelTriangleArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonCircleArea);
            this.Controls.Add(this.labelCirclePerimeter);
            this.Controls.Add(this.textBoxCircleCircumference);
            this.Controls.Add(this.textBoxCircleArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPerimeter);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelAreaResult);
            this.Controls.Add(this.buttonAreaCalc);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelRectangleLength);
            this.Controls.Add(this.labelRectangleHeight);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRectangleHeight;
        private System.Windows.Forms.Label labelRectangleLength;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Button buttonAreaCalc;
        private System.Windows.Forms.Label labelAreaResult;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCircleArea;
        private System.Windows.Forms.TextBox textBoxCircleCircumference;
        private System.Windows.Forms.Label labelCirclePerimeter;
        private System.Windows.Forms.Button buttonCircleArea;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTriangleArea;
        private System.Windows.Forms.Label labelTrianglePerimeter;
        private System.Windows.Forms.TextBox textBoxTriangleArea;
        private System.Windows.Forms.TextBox textBoxTrianglePerimeter;
        private System.Windows.Forms.Label labelTriangleBase;
        private System.Windows.Forms.Label labelTriangleHeight;
        private System.Windows.Forms.TextBox textBoxTriangleBase;
        private System.Windows.Forms.TextBox textBoxTriangleHeight;
        private System.Windows.Forms.Button buttonTriangleArea;
        private System.Windows.Forms.Button buttonTrianglePerimeter;
        private System.Windows.Forms.Label labelTriangleSide1;
        private System.Windows.Forms.Label labelTriangleSide2;
        private System.Windows.Forms.Label labelTriangleSide3;
        private System.Windows.Forms.TextBox textBoxTriangleSide1;
        private System.Windows.Forms.TextBox textBoxTriangleSide2;
        private System.Windows.Forms.TextBox textBoxTriangleSide3;
    }
}

