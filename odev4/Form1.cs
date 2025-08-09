using Microsoft.VisualBasic.Logging;
using System.Security.AccessControl;

namespace odev4
{
    public partial class Form1 : Form
    {

        private TextBox faktoriyel;
        private Label faktoriyelsonuc;
        private TextBox �s;
        private TextBox �ss�;
        private Label �ssonuc;
        private TextBox asalsay�;
        private Label asalsonuc;
        private TextBox numara;
        private TextBox deger;
        private ComboBox islem;
        private Label trigosonuc;
        private TextBox taban;
        private TextBox �st;
        private Label Logasonuc;
        private List<string> yap�lanlar;
        private Label ozetlabel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yap�lanlar = new List<string>();
            this.Height = 600;
            this.Width = 800;
            faktoriyel = new TextBox();
            faktoriyel.Location = new Point(150, 30);
            faktoriyel.Size = new Size(120, 95);
            faktoriyel.ForeColor = Color.Black;
            this.Controls.Add(faktoriyel);

            Label faktoriyelhesap = new Label();
            faktoriyelhesap.Location = new Point(30,30);
            faktoriyelhesap.Size = new Size(150,30);
            faktoriyelhesap.Text = "Faktoriyel Hesab�:";
            this.Controls.Add(faktoriyelhesap);

            Button faktoriyelbutton = new Button();
            faktoriyelbutton.Location = new Point(300,30);
            faktoriyelbutton.Size = new Size(150, 30);
            faktoriyelbutton.Text = "Faktoriyeli hesapla";
            this.Controls.Add(faktoriyelbutton);

            faktoriyelsonuc = new Label();
            faktoriyelsonuc.Location = new Point(500,30);
            faktoriyelsonuc.Size = new Size(150, 30);
            faktoriyelsonuc.Text = "Faktoriyel Sonucu";
            this.Controls.Add(faktoriyelsonuc);
            
            faktoriyelbutton.Click += faktoriyelbuttont�kla;

            �s = new TextBox();
            �s.Location = new Point(150, 100);
            �s.Size = new Size(120, 30);
            this.Controls.Add(�s);

            �ss� = new TextBox();
            �ss�.Location = new Point(300, 100);
            �ss�.Size=new Size(120, 30);
            this.Controls.Add(�ss�);

            Label �shesaplabel = new Label();
            �shesaplabel.Location = new Point(30, 100);
            �shesaplabel.Size = new Size(150, 30);
            �shesaplabel.Text = "�s hesapla:";
            this.Controls.Add(�shesaplabel);
            
            Label �shesaplabel2 = new Label();
            �shesaplabel2.Location = new Point(265, 100);
            �shesaplabel2.Size = new Size(150, 30);
            �shesaplabel2.Text = "�ss�";
            this.Controls.Add(�shesaplabel2);

            Button �sbutton = new Button();
            �sbutton.Location = new Point(450, 100);
            �sbutton.Size = new Size(150, 30);
            �sbutton.Text = "�s Hesapla";
            this.Controls.Add(�sbutton);

            �ssonuc =new Label();
            �ssonuc.Location = new Point(600, 100);
            �ssonuc.Size = new Size(150, 30);
            �ssonuc.Text = "�s Sonucu";
            this.Controls.Add(�ssonuc);

            �sbutton.Click += �sbuttont�kla;

            asalsay� = new TextBox();
            asalsay�.Location = new Point(150, 170);
            asalsay�.Size = new Size(120, 95);
            this.Controls.Add(asalsay�);

            Label asalsay�kontrol = new Label();
            asalsay�kontrol.Location = new Point(30, 170);
            asalsay�kontrol.Size = new Size(150, 30);
            asalsay�kontrol.Text = "Asal say� kontrol:";
            this.Controls.Add(asalsay�kontrol);
            
            Button asalsay�button = new Button();
            asalsay�button.Location = new Point(300, 170);
            asalsay�button.Size = new Size(150, 30);
            asalsay�button.Text = "Kontrol";
            this.Controls.Add(asalsay�button);

            asalsonuc = new Label();
            asalsonuc.Location = new Point(550, 170);
            asalsonuc.Size = new Size(150, 170);
            asalsonuc.Text = "Asal sonucu";
            this.Controls.Add (asalsonuc);

            asalsay�button.Click += asalbuttont�kla;

            Label numaralabel = new Label();
            numaralabel.Location = new Point(10, 300);
            numaralabel.Size = new Size(140, 30);
            numaralabel.Text = "��renci Numaras�:";
            this.Controls.Add(numaralabel);

            numara = new TextBox();
            numara.Location = new Point(150, 300);
            numara.Size = new Size(120, 95);
            this.Controls.Add(numara);

            Button numaraonay = new Button();
            numaraonay.Location = new Point(300, 300);
            numaraonay.Size = new Size(150, 30);
            numaraonay.Text = "Onayla";
            this.Controls.Add(numaraonay);

            numaraonay.Click += numaraonayt�kla;

            Button ozet = new Button();
            ozet.Location = new Point(600, 500);
            ozet.Size = new Size(150, 30);
            ozet.Text = "�zet";
            this.Controls.Add(ozet);

            ozetlabel = new Label();
            ozetlabel.Location = new Point(30, 400);
            ozetlabel.AutoSize = true;
            this.Controls.Add(ozetlabel);

            ozet.Click += ozetclick;
        }
        public void faktoriyelbuttont�kla(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(faktoriyel.Text);
            int sonuc=1;
            for (int i = deger;i > 0;i--)
            {
                sonuc *= i;
            }
            if (deger == 0)
            {
                sonuc = 1;
            }
            faktoriyelsonuc.Text = Convert.ToString(sonuc);
            yap�lanlar.Add( deger+" say�s�n�n faktoriyeli al�nd�. Sonu�: "+sonuc);
        }
        public void �sbuttont�kla(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(�s.Text);
            int deger2 =Convert.ToInt32(�ss�.Text);
            int sonuc = 1;
            for(int i = 0; i<deger2; i++)
            {
                sonuc *= deger;
            }
            �ssonuc.Text = Convert.ToString(sonuc);
            yap�lanlar.Add(deger + "�ss�" + deger2 +" say�s�n�n de�eri istendi. Sonu�: "+sonuc);
        }
        public void asalbuttont�kla(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(asalsay�.Text);
            int sonuc = 0;

            for (int i = 2; i < deger; i++)
            {
                if (deger % i == 0)
                {
                    sonuc = 1;
                }
            }
            if (sonuc == 1 || deger == 1)
            {
                asalsonuc.Text = "Say� Asal de�ildir";
            }
            else
            {
                asalsonuc.Text = "Say� Asald�r";
            }
            yap�lanlar.Add(deger + " say�s� asal m� de�ilmi kontrol edildi. Sonu�: " + asalsonuc.Text);
        }
        public void numaraonayt�kla(object sender, EventArgs e) 
        {
            int sayi = Convert.ToInt32(numara.Text);
            if(sayi %2 == 0)
            {
                Label Trigo = new Label();
                Trigo.Location = new Point(10, 340);
                Trigo.Size = new Size(150, 30);
                Trigo.Text = "Trigonometrik ��lem";
                this.Controls.Add(Trigo);

                islem = new ComboBox();
                islem.Location = new Point(200, 340);
                islem.Size = new Size(150, 30);
                islem.Items.Add("Sinus");
                islem.Items.Add("Cosinus");
                islem.Items.Add("Tanjant");
                islem.Items.Add("Cotanjant");
                this.Controls.Add(islem);

                deger = new TextBox();
                deger.Location = new Point(400, 340);
                deger.Size = new Size(150, 30);
                this.Controls.Add(deger);

                Button hesapla = new Button();
                hesapla.Location = new Point(600, 340);
                hesapla.Size = new Size(150, 30);
                hesapla.Text = "Hesapla";
                this.Controls.Add(hesapla);

                trigosonuc = new Label();
                trigosonuc.Location = new Point(600,380);
                trigosonuc.Size = new Size(150, 30);
                trigosonuc.Text = "Sonu�";
                this.Controls.Add (trigosonuc);

                hesapla.Click += trigohesapla;
                numara.Enabled = false;
            }
            else if(sayi%2 == 1)
            {
                Label Loga = new Label();
                Loga.Location = new Point(10, 340);
                Loga.Size = new Size(140, 30);
                Loga.Text = "Logaritmik ��lem";
                this.Controls.Add(Loga);

                taban = new TextBox();
                taban.Location = new Point(150, 340);
                taban.Size = new Size(120, 30);
                taban.Text = "Taban";
                this.Controls.Add(taban);
                taban.MouseClick += clear;

                �st = new TextBox();
                �st.Location = new Point(300, 340);
                �st.Size = new Size(120, 30);
                �st.Text = "�ss�";
                this.Controls.Add(�st);

                Button Logahesap = new Button();
                Logahesap.Location = new Point(500, 340);
                Logahesap.Size = new Size(150,30);
                Logahesap.Text = "Hesapla";
                this.Controls.Add(Logahesap);

                Logasonuc = new Label();
                Logasonuc.Location = new Point(600,380);
                Logasonuc.Size = new Size(1150, 30);
                Logasonuc.Text = "Sonu�";
                this.Controls.Add(Logasonuc);

                Logahesap.Click += Logahesapla;
                numara.Enabled = false;
            }
        }
        public void trigohesapla(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt32(deger.Text);
            if (islem.SelectedItem == "Cosinus")
            {
                trigosonuc.Text = Convert.ToString(Math.Cos(sayi2 * Math.PI / 180));
                yap�lanlar.Add("Cosinus"+sayi2 + " Hesapland�. Sonu�: " + trigosonuc.Text);
            }
            else if (islem.SelectedItem == "Sinus")
            {
                trigosonuc.Text = Convert.ToString(Math.Sin(sayi2 * Math.PI / 180));
                yap�lanlar.Add("Sinus" + sayi2 + " Hesapland�. Sonu�: " + trigosonuc.Text);
            }
            else if (islem.SelectedItem == "Tanjant")
            {
                trigosonuc.Text = Convert.ToString(Math.Tan(sayi2 * Math.PI / 180));
                yap�lanlar.Add("Tanjant" + sayi2 + " Hesapland�. Sonu�: " + trigosonuc.Text);
            }
            else if(islem.SelectedItem == "Cotanjant")
            {
                trigosonuc.Text = Convert.ToString(1 / Math.Tan(sayi2 * Math.PI / 180));
                yap�lanlar.Add("Cotanjant" + sayi2 + " Hesapland�. Sonu�: " + trigosonuc.Text);
            }
        }
        public void clear(object sender, EventArgs e)
        {
            taban.Clear();
            �st.Clear();
        }
        public void Logahesapla(object sender, EventArgs e)
        {
            int �stsayi = Convert.ToInt32(�st.Text);
            if (taban.Text == "e")
            {
                Logasonuc.Text = Convert.ToString(Math.Log(�stsayi));
                yap�lanlar.Add("Ln"+�stsayi+" Hesapland�. Sonu�: "+Logasonuc.Text);
            }
            else
            {
                int tabansayi = Convert.ToInt32(taban.Text);
                Logasonuc.Text = Convert.ToString(Math.Log(�stsayi, tabansayi));
                yap�lanlar.Add("Log"+tabansayi+"taban�nda"+�stsayi+" Hesapland�. Sonu�: "+Logasonuc.Text);
            }
        }
        public void ozetclick(object sender, EventArgs e)
        {
            string ozet="";
            foreach(string s in yap�lanlar)
            {
                ozet += s + "\n";
                ozetlabel.Text = ozet;
            }
        }
    }
}

