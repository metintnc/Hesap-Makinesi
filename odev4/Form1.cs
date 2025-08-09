using Microsoft.VisualBasic.Logging;
using System.Security.AccessControl;

namespace odev4
{
    public partial class Form1 : Form
    {

        private TextBox faktoriyel;
        private Label faktoriyelsonuc;
        private TextBox üs;
        private TextBox üssü;
        private Label üssonuc;
        private TextBox asalsayý;
        private Label asalsonuc;
        private TextBox numara;
        private TextBox deger;
        private ComboBox islem;
        private Label trigosonuc;
        private TextBox taban;
        private TextBox üst;
        private Label Logasonuc;
        private List<string> yapýlanlar;
        private Label ozetlabel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yapýlanlar = new List<string>();
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
            faktoriyelhesap.Text = "Faktoriyel Hesabý:";
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
            
            faktoriyelbutton.Click += faktoriyelbuttontýkla;

            üs = new TextBox();
            üs.Location = new Point(150, 100);
            üs.Size = new Size(120, 30);
            this.Controls.Add(üs);

            üssü = new TextBox();
            üssü.Location = new Point(300, 100);
            üssü.Size=new Size(120, 30);
            this.Controls.Add(üssü);

            Label üshesaplabel = new Label();
            üshesaplabel.Location = new Point(30, 100);
            üshesaplabel.Size = new Size(150, 30);
            üshesaplabel.Text = "Üs hesapla:";
            this.Controls.Add(üshesaplabel);
            
            Label üshesaplabel2 = new Label();
            üshesaplabel2.Location = new Point(265, 100);
            üshesaplabel2.Size = new Size(150, 30);
            üshesaplabel2.Text = "üssü";
            this.Controls.Add(üshesaplabel2);

            Button üsbutton = new Button();
            üsbutton.Location = new Point(450, 100);
            üsbutton.Size = new Size(150, 30);
            üsbutton.Text = "Üs Hesapla";
            this.Controls.Add(üsbutton);

            üssonuc =new Label();
            üssonuc.Location = new Point(600, 100);
            üssonuc.Size = new Size(150, 30);
            üssonuc.Text = "Üs Sonucu";
            this.Controls.Add(üssonuc);

            üsbutton.Click += üsbuttontýkla;

            asalsayý = new TextBox();
            asalsayý.Location = new Point(150, 170);
            asalsayý.Size = new Size(120, 95);
            this.Controls.Add(asalsayý);

            Label asalsayýkontrol = new Label();
            asalsayýkontrol.Location = new Point(30, 170);
            asalsayýkontrol.Size = new Size(150, 30);
            asalsayýkontrol.Text = "Asal sayý kontrol:";
            this.Controls.Add(asalsayýkontrol);
            
            Button asalsayýbutton = new Button();
            asalsayýbutton.Location = new Point(300, 170);
            asalsayýbutton.Size = new Size(150, 30);
            asalsayýbutton.Text = "Kontrol";
            this.Controls.Add(asalsayýbutton);

            asalsonuc = new Label();
            asalsonuc.Location = new Point(550, 170);
            asalsonuc.Size = new Size(150, 170);
            asalsonuc.Text = "Asal sonucu";
            this.Controls.Add (asalsonuc);

            asalsayýbutton.Click += asalbuttontýkla;

            Label numaralabel = new Label();
            numaralabel.Location = new Point(10, 300);
            numaralabel.Size = new Size(140, 30);
            numaralabel.Text = "Öðrenci Numarasý:";
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

            numaraonay.Click += numaraonaytýkla;

            Button ozet = new Button();
            ozet.Location = new Point(600, 500);
            ozet.Size = new Size(150, 30);
            ozet.Text = "Özet";
            this.Controls.Add(ozet);

            ozetlabel = new Label();
            ozetlabel.Location = new Point(30, 400);
            ozetlabel.AutoSize = true;
            this.Controls.Add(ozetlabel);

            ozet.Click += ozetclick;
        }
        public void faktoriyelbuttontýkla(object sender, EventArgs e)
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
            yapýlanlar.Add( deger+" sayýsýnýn faktoriyeli alýndý. Sonuç: "+sonuc);
        }
        public void üsbuttontýkla(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(üs.Text);
            int deger2 =Convert.ToInt32(üssü.Text);
            int sonuc = 1;
            for(int i = 0; i<deger2; i++)
            {
                sonuc *= deger;
            }
            üssonuc.Text = Convert.ToString(sonuc);
            yapýlanlar.Add(deger + "üssü" + deger2 +" sayýsýnýn deðeri istendi. Sonuç: "+sonuc);
        }
        public void asalbuttontýkla(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(asalsayý.Text);
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
                asalsonuc.Text = "Sayý Asal deðildir";
            }
            else
            {
                asalsonuc.Text = "Sayý Asaldýr";
            }
            yapýlanlar.Add(deger + " sayýsý asal mý deðilmi kontrol edildi. Sonuç: " + asalsonuc.Text);
        }
        public void numaraonaytýkla(object sender, EventArgs e) 
        {
            int sayi = Convert.ToInt32(numara.Text);
            if(sayi %2 == 0)
            {
                Label Trigo = new Label();
                Trigo.Location = new Point(10, 340);
                Trigo.Size = new Size(150, 30);
                Trigo.Text = "Trigonometrik Ýþlem";
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
                trigosonuc.Text = "Sonuç";
                this.Controls.Add (trigosonuc);

                hesapla.Click += trigohesapla;
                numara.Enabled = false;
            }
            else if(sayi%2 == 1)
            {
                Label Loga = new Label();
                Loga.Location = new Point(10, 340);
                Loga.Size = new Size(140, 30);
                Loga.Text = "Logaritmik Ýþlem";
                this.Controls.Add(Loga);

                taban = new TextBox();
                taban.Location = new Point(150, 340);
                taban.Size = new Size(120, 30);
                taban.Text = "Taban";
                this.Controls.Add(taban);
                taban.MouseClick += clear;

                üst = new TextBox();
                üst.Location = new Point(300, 340);
                üst.Size = new Size(120, 30);
                üst.Text = "Üssü";
                this.Controls.Add(üst);

                Button Logahesap = new Button();
                Logahesap.Location = new Point(500, 340);
                Logahesap.Size = new Size(150,30);
                Logahesap.Text = "Hesapla";
                this.Controls.Add(Logahesap);

                Logasonuc = new Label();
                Logasonuc.Location = new Point(600,380);
                Logasonuc.Size = new Size(1150, 30);
                Logasonuc.Text = "Sonuç";
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
                yapýlanlar.Add("Cosinus"+sayi2 + " Hesaplandý. Sonuç: " + trigosonuc.Text);
            }
            else if (islem.SelectedItem == "Sinus")
            {
                trigosonuc.Text = Convert.ToString(Math.Sin(sayi2 * Math.PI / 180));
                yapýlanlar.Add("Sinus" + sayi2 + " Hesaplandý. Sonuç: " + trigosonuc.Text);
            }
            else if (islem.SelectedItem == "Tanjant")
            {
                trigosonuc.Text = Convert.ToString(Math.Tan(sayi2 * Math.PI / 180));
                yapýlanlar.Add("Tanjant" + sayi2 + " Hesaplandý. Sonuç: " + trigosonuc.Text);
            }
            else if(islem.SelectedItem == "Cotanjant")
            {
                trigosonuc.Text = Convert.ToString(1 / Math.Tan(sayi2 * Math.PI / 180));
                yapýlanlar.Add("Cotanjant" + sayi2 + " Hesaplandý. Sonuç: " + trigosonuc.Text);
            }
        }
        public void clear(object sender, EventArgs e)
        {
            taban.Clear();
            üst.Clear();
        }
        public void Logahesapla(object sender, EventArgs e)
        {
            int üstsayi = Convert.ToInt32(üst.Text);
            if (taban.Text == "e")
            {
                Logasonuc.Text = Convert.ToString(Math.Log(üstsayi));
                yapýlanlar.Add("Ln"+üstsayi+" Hesaplandý. Sonuç: "+Logasonuc.Text);
            }
            else
            {
                int tabansayi = Convert.ToInt32(taban.Text);
                Logasonuc.Text = Convert.ToString(Math.Log(üstsayi, tabansayi));
                yapýlanlar.Add("Log"+tabansayi+"tabanýnda"+üstsayi+" Hesaplandý. Sonuç: "+Logasonuc.Text);
            }
        }
        public void ozetclick(object sender, EventArgs e)
        {
            string ozet="";
            foreach(string s in yapýlanlar)
            {
                ozet += s + "\n";
                ozetlabel.Text = ozet;
            }
        }
    }
}

