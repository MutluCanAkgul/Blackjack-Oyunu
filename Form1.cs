namespace Blackjack_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayac = 1;
        int a, b, c, d, f;
        int x, y, z, w,u;
        int deger1=0, deger2=0;
        PictureBox picture1 = new PictureBox();
        PictureBox picture2 = new PictureBox();
        PictureBox picture3 = new PictureBox();
        PictureBox picture4 = new PictureBox();
        PictureBox picture5 = new PictureBox();
        PictureBox picture6 = new PictureBox();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniOyun();
            a = rnd.Next(1, 11);
            x = rnd.Next(1, 11);
            if (x == 1)
            {
                x = 11;
                deger1 = x;
                label4.Text = deger1.ToString();
                pictureBox1.Image = Properties.Resources.ace_of_hearts;

            }
            else if (x >= 2 && x <= 10)
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(x + "_of_hearts");
            }
            deger1 = a;
            deger2 = x;
            label4.Text = deger1.ToString();
            label3.Text = deger2.ToString();
            sayac++;        
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = true;
            button2.Visible = true;
            button3.Enabled = true;
            button3.Visible = true;
            if (a == 1)
            {
                a = 11;
                deger1 = a;
                label4.Text = deger1.ToString();    
                pictureBox3.Image = Properties.Resources.ace_of_diamonds;

            }
           else if(a >=2 && a<=10)
            {
                pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject( a + "_of_diamonds");
            }
            if (sayac == 2)
            {
                b = rnd.Next(1, 11);
                deger1 = a + b;
                label4.Text = deger1.ToString();
                if (b == 1)
                {
                    if (a == 11)
                    {
                        b = 1;
                        deger1 = a + b;
                    }                   
                    pictureBox4.Image = Properties.Resources.ace_of_clubs;

                }
                else if (b >= 2 && b <= 10)
                {
                    pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(b + "_of_clubs");
                }

            }
            if (a == 10 && b == 1 || a == 1 && b == 10)
            {
                deger1 = 21;
                label4.Text = "BJ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac++;        
            if (sayac == 3)
            {
                c = rnd.Next(1, 11);
                deger1 = a + b + c;
                label4.Text = deger1.ToString();
                picture1.Size = new Size(150, 200);
                this.Controls.Add(picture1);
                picture1.Location = new Point(331, 298);
                picture1.BackColor = Color.White;
                picture1.SizeMode = PictureBoxSizeMode.StretchImage;
                if (c == 1)
                {        
                    picture1.Image = Properties.Resources.ace_of_spades;
                }
                else if (c >= 2 && c <= 10)
                {
                    picture1.Image = (Image)Properties.Resources.ResourceManager.GetObject(c + "_of_spades");
                }
            }
            if (sayac == 4)
            {
                d = rnd.Next(1, 11);
                deger1 += d;
                label4.Text = deger1.ToString();
                picture2.Size = new Size(150, 200);
                this.Controls.Add(picture2);
                picture2.Location = new Point(487, 298);
                picture2.BackColor = Color.White;
                picture2.SizeMode = PictureBoxSizeMode.StretchImage;
                if (d == 1)
                {
                    picture2.Image = Properties.Resources.ace_of_clubs;
                }
                else if (d>= 2 && d <= 10)
                {
                    picture2.Image = (Image)Properties.Resources.ResourceManager.GetObject(d + "_of_clubs");
                }
            }
            if (sayac == 5)
            {
                f = rnd.Next(1, 11);
                deger1 += f;
                label4.Text = deger1.ToString();

                picture3.Size = new Size(150, 200);
                this.Controls.Add(picture3);
                picture3.Location = new Point(643, 298);
                picture3.BackColor = Color.White;
                picture3.SizeMode = PictureBoxSizeMode.StretchImage;
                if (f == 1)
                {

                    picture3.Image = Properties.Resources.ace_of_hearts;
                }
                else if (f >= 2 && f <= 10)
                {
                    picture3.Image = (Image)Properties.Resources.ResourceManager.GetObject(f + "_of_hearts");
                }
            }
            if (deger1 > 21)
            {
                MessageBox.Show("Kaybettiniz");
                degisim();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y = rnd.Next(1, 11);
            deger2 = x + y;
            label3.Text = deger2.ToString();
            if(y == 1)
            {
                pictureBox2.Image = Properties.Resources.ace_of_diamonds;
            }
            else if (y >= 2 && y <= 10)
            {
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject(y + "_of_diamonds");
            }
            if(x == 10 && y == 1 || y ==10 && x == 1)
            {
                deger2 = 21;
                label3.Text = deger2.ToString();
            }
            if (deger2 < 17)
            {
                z = rnd.Next(1, 11);
                deger2 = x + y + z;
                label3.Text = deger2.ToString();
                picture4.Size = new Size(150, 200);
                picture4.Location = new Point(331, 75);
                this.Controls.Add(picture4);
                picture4.SizeMode = PictureBoxSizeMode.StretchImage;
                if(z == 1)
                {
                    picture4.Image = Properties.Resources.ace_of_spades;
                }
                else if (z >= 2 && z <= 10)
                {
                    picture4.Image = (Image)Properties.Resources.ResourceManager.GetObject(z + "_of_spades");
                }
            }
            if (deger2 < 17)
            {
                w = rnd.Next(1, 11);
                deger2 = x+y+z+w;
                label3.Text = deger2.ToString();
                picture5.Size = new Size(150, 200);
                picture5.Location = new Point(487, 75);
                this.Controls.Add(picture5);
                picture5.SizeMode = PictureBoxSizeMode.StretchImage;
                if (w == 1)
                {
                    picture5.Image = Properties.Resources.ace_of_clubs;
                }
                else if (w >= 2 && w <= 10)
                {
                    picture5.Image = (Image)Properties.Resources.ResourceManager.GetObject(w + "_of_clubs");
                }
            }
            if (deger2 < 17)
            {
                u = rnd.Next(1, 11);
                deger2 = x + y + z + w + u;
                label3.Text = deger2.ToString();
                picture5.Size = new Size(150, 200);
                picture5.Location = new Point(643, 75);
                this.Controls.Add(picture5);
                picture5.SizeMode = PictureBoxSizeMode.StretchImage;
                if (u == 1)
                {
                    picture5.Image = Properties.Resources.ace_of_clubs;
                }
                else if (u >= 2 && u <= 10)
                {
                    picture5.Image = (Image)Properties.Resources.ResourceManager.GetObject(u + "_of_clubs");
                }
            }
            else if (deger2 >= 22)
            {
                MessageBox.Show("Kazandýnýz");
                degisim();

            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                if (deger1 > deger2)
                {
                    MessageBox.Show("Kazandýnýz");
                    degisim();
                }
                else if (deger2 > deger1)
                {
                    MessageBox.Show("Krupiyer Kazandý");
                    degisim();
                }
                else
                {
                    MessageBox.Show("Berabere");
                    degisim();
                }
            }

        }
        void degisim()
        {
            button3.Enabled = false;
            button3.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            button1.Enabled = true;
            button1.Visible = true;
        }
        void YeniOyun()
        {
            sayac = 1;
            deger1 = 0;
            deger2 = 0;
            pictureBox1.Image = Properties.Resources.card_back_orange;
            pictureBox2.Image = Properties.Resources.card_back_orange;
            pictureBox3.Image = Properties.Resources.card_back_orange;
            pictureBox4.Image = Properties.Resources.card_back_orange;
            this.Controls.Remove(picture1);
            this.Controls.Remove(picture2);
            this.Controls.Remove(picture3);
            this.Controls.Remove(picture4);
            this.Controls.Remove(picture5);
        }

    }

}