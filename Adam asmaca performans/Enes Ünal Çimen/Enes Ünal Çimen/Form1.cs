namespace Enes_Ünal_Çimen
{
    public partial class Form1 : Form
    {
        public string bulunacak_kelime;
        public string[] bulunan_harfler;
        public int can;
        public double resim_parcalari = 0;


        public Form1()
        {

            InitializeComponent();
           
            this.Size = new Size(185, 100);
            this.MaximumSize = new Size(185, 100);
            this.MinimumSize = new Size(185, 100);
        }
        
        string Bulunacak_Kelime()
        {
            Random rand = new Random();

            string[] kelimeler = new string[10];
            kelimeler[0] = "Sevgi";
            kelimeler[1] = "Aşk";
            kelimeler[2] = "Araba";
            kelimeler[3] = "İhanet";
            kelimeler[4] = "Emek";
            kelimeler[5] = "Bilgisayar";
            kelimeler[6] = "Yazılım";
            kelimeler[7] = "Arkadaşlık";
            kelimeler[8] = "Dostluk";
            kelimeler[9] = "Öğretmen";
            int random_sayi = rand.Next(0, kelimeler.Length);
            return kelimeler[random_sayi];
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;

            
            bulunacak_kelime = Bulunacak_Kelime().ToUpper();
            can = bulunacak_kelime.Length;
            label4.Text = can.ToString() + " deneme hakkınız kaldı";



           
            bulunan_harfler = new string[bulunacak_kelime.Length];
            label3.Text = "";
            for (int i = 0; i < bulunacak_kelime.Length; i++)
            {
                bulunan_harfler[i] = "_ "; 
                label3.Text += bulunan_harfler[i].ToString();
            }

           
            Label1.Text = "Bulmanız gereken kelime " + bulunacak_kelime.Length.ToString() + " Harflidir.";

           
            panel2.Visible = true;
            Form1.ActiveForm.Size = new Size(900, 500);
            Form1.ActiveForm.MaximumSize = new Size(900, 500);
            Form1.ActiveForm.MinimumSize = new Size(900, 500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool dogru_bildimi = false;

                
                string girilen_kelime = textBox1.Text.ToUpper();


                if (string.IsNullOrEmpty(girilen_kelime) && string.IsNullOrWhiteSpace(girilen_kelime))
                {
                }
                else
                {
                    if (girilen_kelime == bulunacak_kelime)
                    {
                        
                        label3.Text = "";
                        for (int i = 0; i < bulunacak_kelime.Length; i++)
                        {
                            label3.Text += girilen_kelime[i] + " ";
                        }
                        Oyunu_Kazandin();
                    }
                    else
                    {
                        label3.Text = "";
                      
                        for (int i = 0; i < bulunacak_kelime.Length; i++)
                        {
                            if (girilen_kelime[0] == bulunacak_kelime[i])
                            {
                                bulunan_harfler[i] = girilen_kelime[0] + " ";
                                dogru_bildimi = true;
                            }
                        }


                      
                        if (bulunan_harfler.Contains("_ ") == false)
                        {
                            Oyunu_Kazandin();
                        }
                        Dogru_Bildimi(dogru_bildimi);


                        for (int b = 0; b < bulunacak_kelime.Length; b++)
                        {
                            label3.Text += bulunan_harfler[b];
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Şu anda sistemde bir hata var.");
            }
        }
        void Dogru_Bildimi(bool dogru_bildimi)
        {
            if (!dogru_bildimi)
            {
                if (can > 0)
                {                
                    can--;
                    label4.Text = can.ToString() + " deneme hakkınız kaldı";
                    resim_parcalari += (8.0 / bulunacak_kelime.Length);
                    Resim_Parcalarini_Goster(resim_parcalari);
                    if (can == 0)
                    {

                        textBox1.Enabled = false;
                        button2.Enabled = false;

                        button3.Visible = true;
                    }

                }
            }
        }
        void Oyunu_Kazandin()
        {
            label2.Text = "Cevap doğru kazandınız.";
            label4.Text = "Cevap doğru kazandınız";
            textBox1.Enabled = false;
            button2.Enabled = false;

            button3.Visible = true;
        }

        void Resim_Parcalarini_Goster(double sayi)
        {
            if (sayi >= 1)
            {
                pictureBox1.Visible = true;
                if (sayi >= 2)
                {
                    pictureBox2.Visible = true;
                    if (sayi >= 3)
                    {
                        pictureBox3.Visible = true;
                        if (sayi >= 4)
                        {
                            pictureBox4.Visible = true;
                            if (sayi >= 5)
                            {
                                pictureBox5.Visible = true;
                                if (sayi >= 6)
                                {
                                    pictureBox6.Visible = true;
                                    if (sayi >= 7)
                                    {
                                        pictureBox7.Visible = true;
                                        if (sayi >= 8)
                                        {
                                            pictureBox8.Visible = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
    }
