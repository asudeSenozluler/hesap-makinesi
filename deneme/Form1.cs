using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace deneme
{
    public partial class Form1 : Form
    {
        //butun formda kullanılacak degiskenleri global alanda tanımladım
        double FirstNumber;
        //operatorlere farklı degisken atamak icin bu degiskeni kullandım
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            //c butonuna basıldıgında ekranı boş bırakıyor
            textBox1.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if(textBox1.Text=="0" && textBox1.Text==null)
            {
                //textboxa 1 yaz
                textBox1.Text = "1";
            }
            else
            {
                //değilse yazan değerin yanına 1 ekle
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa 2 yaz
                textBox1.Text = "2";
            }
            else
            {
                //değilse yazan değerin yanına 2 ekle
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa 3 yaz
                textBox1.Text = "3";
            }
            else
            {
                //değilse yazan değerin yanına 3 ekle
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa 4 yaz
                textBox1.Text = "4";
            }
            else
            {
                //değilse yazan değerin yanına 4 ekle
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa 5 yaz
                textBox1.Text = "5";
            }
            else
            {
                //değilse yazan değerin yanına 5 ekle
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa 6 yaz
                textBox1.Text = "6";
            }
            else
            {
                //değilse yazan değerin yanına 6 ekle
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa 7 yaz
                textBox1.Text = "7";
            }
            else
            {
                //değilse yazan değerin yanına 7 ekle
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa 8 yaz
                textBox1.Text = "8";
            }
            else
            {
                //değilse yazan değerin yanına 8 ekle
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa 9 yaz
                textBox1.Text = "9";
            }
            else
            {
                //değilse yazan değerin yanına 9 ekle
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa 0 yaz
                textBox1.Text = "0";
            }
            else
            {
                //değilse yazan değerin yanına 0 ekle
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void btnvirgul_Click(object sender, EventArgs e)
        {
            // eger textboxın içi boş ve içinde sıfır yazıyorsa
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                //textboxa , yaz
                textBox1.Text = ",";
            }
            else
            {
                //değilse yazan değerin yanına , ekle
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void btnartı_Click(object sender, EventArgs e)
        {
          //textboxın içine girilen sayıyı double'a çevir 
            FirstNumber = Convert.ToDouble(textBox1.Text);
            //textboxın içini boş değer yap
            textBox1.Text = null;
            //operatör değişkenine + ata
            Operation = "+";
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            //textboxın içine girilen sayıyı double'a çevir 
            FirstNumber = Convert.ToDouble(textBox1.Text);
            //textboxın içini boş değer yap
            textBox1.Text = null;
            //operatör değişkenine - ata
            Operation = "-";
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            //textboxın içine girilen sayıyı double'a çevir 
            FirstNumber = Convert.ToDouble(textBox1.Text);
            //textboxın içini boş değer yap
            textBox1.Text = null;
            //operatör değişkenine * ata
            Operation = "*";
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            //textboxın içine girilen sayıyı double'a çevir 
            FirstNumber = Convert.ToDouble(textBox1.Text);
            //textboxın içini boş değer yap
            textBox1.Text = null;
            //operatör değişkenine / ata
            Operation = "/";
        }

        private void btnesit_Click(object sender, EventArgs e)
        {
            //eşittire basıldığında döndürülecek sonuç için bu değişkeni tanımladım
            double Result;
            //aritmetik girilecek ikinci değer için bu değişkeni tanımladım
            double SecondNumber;
            //textboxın içine girilen ikinci değeri double'a çevir
            SecondNumber = Convert.ToDouble(textBox1.Text);
            //eğer operatör artıysa
            if(Operation=="+")
            {
                //result değişkeni için birinci ve ikinci değeri topla
                Result = (FirstNumber + SecondNumber);
              //resulttan gelen değeri stringe çevir ve textboxa yazdır
                textBox1.Text = Convert.ToString(Result);
                //ilk değeri result değişkenine ata
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                //result değişkeni için birinci değerden ikinci değeri çıkart
                Result = (FirstNumber - SecondNumber);
                //resulttan gelen değeri stringe çevir ve textboxa yazdır
                textBox1.Text = Convert.ToString(Result);
                //ilk değeri result değişkenine ata
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                //result değişkeni için birinci değer ile ikinci değeri çarp
                Result = (FirstNumber * SecondNumber);
                //resulttan gelen değeri stringe çevir ve textboxa yazdır
                textBox1.Text = Convert.ToString(Result);
                //ilk değeri result değişkenine ata
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                //result değişkeni için birinci değeri ikinci değere böl
                Result = (FirstNumber / SecondNumber);
                //resulttan gelen değeri stringe çevir ve textboxa yazdır
                textBox1.Text = Convert.ToString(Result);
                //ilk değeri result değişkenine ata
                FirstNumber = Result;
            }
            if (Operation == "%")
            {
                //result değişkeni için birinci değerin ikinci değere göre yüzdesini al
                Result = ((FirstNumber / 100)*SecondNumber);
                //resulttan gelen değeri stringe çevir ve textboxa yazdır
                textBox1.Text = Convert.ToString(Result);
                //ilk değeri result değişkenine ata
                FirstNumber = Result;
            }
            



        }

        private void btnyuzde_Click(object sender, EventArgs e)
        {
            //yuzdeyi görmek için eşittire basın
            //resulttan gelen değeri stringe çevir ve textboxa yazdır
            FirstNumber = Convert.ToDouble(textBox1.Text);
            //textboxın içini boş değer yap
            textBox1.Text = null;
            //operatör değişkenine % ata
            Operation = "%";
        }

        private void btnkok_Click(object sender, EventArgs e)
        {
            //kök almak için önce sayıyı yazın
            //resulttan gelen değeri stringe çevir ve textboxa yazdır
            FirstNumber = Convert.ToDouble(textBox1.Text);
            //textboxın içini boş değer yap
            textBox1.Text = null;
            //sonuç değerini tutsun diye bu değişkeni oluşturdum
            double sonuc;
            //matematik kütüphanesinden kök alma metodunu çağırdım
            sonuc=Math.Sqrt(FirstNumber);
            //sonuç değerini stringe çevirip textboxa yazdırdım
            textBox1.Text = sonuc.ToString();

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            //textboxın içini boş  yapıyor
            textBox1.Text = "";



        }

        private void btnce_Click(object sender, EventArgs e)
        {
            //textboxın içine boş değer atıyor
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //kök alma operatörünü ekrana yazdıramadığımız için kullanıcıdan önce sayı girmesini istedik
            MessageBox.Show("Lütfen kök almak istediğiniz sayıyı önce yazınız.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kök almak için önce sayıyı yazın
            //resulttan gelen değeri stringe çevir ve textboxa yazdır
            FirstNumber = Convert.ToDouble(textBox1.Text);
            //textboxın içini boş değer yap
            textBox1.Text = null;
            //sonuç değerini tutsun diye bu değişkeni oluşturdum
            double sonuc;
            //matematik kütüphanesinden üs alma komutunu çağırdım
            sonuc = Math.Pow(FirstNumber,2);
            //sonuç değerini stringe çevirip textboxa yazdırdım
            textBox1.Text = sonuc.ToString();
        }
    }
}
