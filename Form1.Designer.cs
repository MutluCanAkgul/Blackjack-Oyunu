namespace Blackjack_Oyunu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 18);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 0;
            label1.Text = "Krupiyer";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(127, 538);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 1;
            label2.Text = "Siz";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.card_back_orange;
            pictureBox2.Location = new Point(175, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.card_back_orange;
            pictureBox3.Location = new Point(19, 298);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 200);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.card_back_orange;
            pictureBox4.Location = new Point(175, 298);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 200);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(223, 18);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(223, 538);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(957, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 571);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(6, 245);
            button3.Name = "button3";
            button3.Size = new Size(188, 91);
            button3.TabIndex = 2;
            button3.Text = "Kart Çek";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(6, 148);
            button2.Name = "button2";
            button2.Size = new Size(188, 91);
            button2.TabIndex = 1;
            button2.Text = "Kal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(188, 91);
            button1.TabIndex = 0;
            button1.Text = "Oyunu Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(0, 282);
            label5.Name = "label5";
            label5.Size = new Size(959, 10);
            label5.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1169, 607);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
    }
}