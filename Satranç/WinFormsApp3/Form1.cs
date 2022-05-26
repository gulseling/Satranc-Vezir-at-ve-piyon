using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/* öNCELİKLE İŞ YOĞUNLUĞUM SEBEBİYLE KODLARI TOPLARLAYAMADIĞIMI BELİRTMEK İSTERİM VE ÖZÜR DİLERİM
 Zamanım olsaydı tüm tekrarlı yerleri birer fonksiyon halinde toplayıp Form1 Load'ın içine atacaktım.
Saygılarımla Gülselin Güler
 */
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        //değişkenleri tanımladım
        double beyazpuan = 0;
        double siyahpuan = 0;
   
        string[,,] bkonumlar = new string[8, 8, 3]; // string tipinde arraylar oluşturdum.
        string[,,] skonumlar = new string[8, 8, 3];
   
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> satirlar = new List<string>(); //satırların tutulacağı list<string> tipinde listeyi oluşturdum.


            using (StreamReader sr = new StreamReader("board3.txt")) //StreamReader fonksiyonu ile dosyayı çekiyorum.
            {
                string satir; //
                while ((satir = sr.ReadLine()) != null) // satır boş değilse, satirlar List'ine ekliyorum.
                {

                    satirlar.Add(satir);
                    string[] taslar = satir.Split(" ");// txt. dosyasından aldığım satırları boşluk gördü yerden bölerek taşlara ve konumlarına ulaşıyorum.
                    for (int i = 0; i <= 7; i++)
                    {
                        // dinamik olarak buton oluşturup taş görsellerini ekleyip tahtayı renklendiriyorum.
                        Button btn = new Button();
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Text = "";
                        btn.Dock = DockStyle.Fill;

                        tableLayoutPanel1.Controls.Add(btn, i, (satirlar.Count - 1));
                        if (i % 2 == 0 & (satirlar.Count - 1) % 2 == 0)
                        {
                            btn.BackColor = Color.Maroon;
                        }
                        else if (i % 2 != 0 & (satirlar.Count - 1) % 2 == 0)
                        {
                            btn.BackColor = Color.Sienna;
                        }
                        else if (i % 2 == 0 & (satirlar.Count - 1) % 2 != 0)
                        {
                            btn.BackColor = Color.Sienna;
                        }
                        else { btn.BackColor = Color.Maroon; }
                        // tasların rengini , puanını ve konumunuatıyorum.
                        switch (taslar[i])
                        {
                            case "ks":

                                btn.ImageList = siyahlar;
                                btn.ImageKey = "ks.png";
                                skonumlar[i, (satirlar.Count - 1), 0] = "k";
                                skonumlar[i, (satirlar.Count - 1), 1] = "5";
                                break;
                            case "fs":
                                btn.ImageList = siyahlar;
                                btn.ImageKey = "fs.png";
                                skonumlar[i, (satirlar.Count - 1), 0] = "f";
                                skonumlar[i, (satirlar.Count - 1), 1] = "3";
                                break;
                            case "as":
                                btn.ImageList = siyahlar;
                                btn.ImageKey = "as.png";

                                skonumlar[i, (satirlar.Count - 1), 0] = "a";
                                skonumlar[i, (satirlar.Count - 1), 1] = "3";
                                break;
                            case "vs":
                                btn.ImageList = siyahlar;
                                btn.ImageKey = "vs.png";
                                skonumlar[i, (satirlar.Count - 1), 0] = "v";
                                skonumlar[i, (satirlar.Count - 1), 1] = "9";
                                break;
                            case "ss":
                                btn.ImageList = siyahlar;
                                btn.ImageKey = "ss.png";
                                skonumlar[i, (satirlar.Count - 1), 0] = "s";
                                skonumlar[i, (satirlar.Count - 1), 1] = "100";
                                break;
                            case "ps":
                                btn.ImageList = siyahlar;
                                btn.ImageKey = "ps.png";
                                skonumlar[i, (satirlar.Count - 1), 0] = "p";
                                skonumlar[i, (satirlar.Count - 1), 1] = "1";
                                break;
                            case "kb":
                                btn.ImageList = beyazlar;
                                btn.ImageKey = "kb.png";
                                bkonumlar[i, (satirlar.Count - 1), 0] = "k";
                                bkonumlar[i, (satirlar.Count - 1), 1] = "5";
                                break;
                            case "fb":
                                btn.ImageList = beyazlar;
                                btn.ImageKey = "fb.png";
                                bkonumlar[i, (satirlar.Count - 1), 0] = "f";
                                bkonumlar[i, (satirlar.Count - 1), 1] = "3";

                                break;
                            case "ab":
                                btn.ImageList = beyazlar;
                                btn.ImageKey = "ab.png";
                                bkonumlar[i, (satirlar.Count - 1), 0] = "a";
                                bkonumlar[i, (satirlar.Count - 1), 1] = "3";

                                break;
                            case "vb":
                                btn.ImageList = beyazlar;
                                btn.ImageKey = "vb.png";
                                bkonumlar[i, (satirlar.Count - 1), 0] = "v";
                                bkonumlar[i, (satirlar.Count - 1), 1] = "9";

                                break;
                            case "sb":
                                btn.ImageList = beyazlar;
                                btn.ImageKey = "sb.png";
                                bkonumlar[i, (satirlar.Count - 1), 0] = "s";
                                bkonumlar[i, (satirlar.Count - 1), 1] = "100";

                                break;
                            case "pb":
                                btn.ImageList = beyazlar;
                                btn.ImageKey = "pb.png";
                                bkonumlar[i, (satirlar.Count - 1), 0] = "p";
                                bkonumlar[i, (satirlar.Count - 1), 1] = "1";

                                break;
                            default:

                                break;

                        }


                    }
                }

            }
            //tehdit durumları
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (bkonumlar[i, j, 0] == "p")// eğer beyaz bir piyon varsa bir önceki satırda bir önceki sutun veya bir sonraki sutunda siyah bir taş var mı diye kontrol ediyorum.
                    {

                        try
                        {
                            if (skonumlar[i - 1, j - 1, 1] != null && skonumlar[i - 1, j - 1, 2] != "kontrol edildi") // eğer kontrol edildiyse veya boşsa kontrol etmiyorum.
                                skonumlar[i - 1, j - 1, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - 1, j - 1, 1]) / 2));// eğer tehdit durumunda bir taş varsa puanını yarıya düşürüyorum.
                            skonumlar[i - 1, j - 1, 2] = "kontrol edildi";


                        }
                        catch { }
                        try
                        {
                            if (skonumlar[i + 1, j - 1, 1] != null && skonumlar[i + 1, j - 1, 2] != "kontrol edildi")
                                skonumlar[i + 1, j - 1, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + 1, j - 1, 1]) / 2));
                            skonumlar[i + 1, j - 1, 2] = "kontrol edildi";
                        }
                        catch { }
                    }
                    if (bkonumlar[i, j, 0] == "a")// eğer beyaz bir at varsa tehdit durumunda siyah bir taş var mı diye kontrol ediyorum.
                    {
                        try
                        {
                            if (skonumlar[i - 1, j - 2, 1] != null && skonumlar[i - 1, j - 2, 2] != "kontrol edildi")
                                skonumlar[i - 1, j - 2, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - 1, j - 2, 1]) / 2));
                            skonumlar[i - 1, j - 2, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (skonumlar[i + 1, j - 2, 1] != null && skonumlar[i + 1, j - 2, 2] != "kontrol edildi")
                                skonumlar[i + 1, j - 2, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + 1, j - 2, 1]) / 2));
                            skonumlar[i + 1, j - 2, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (skonumlar[i - 2, j - 1, 1] != null && skonumlar[i - 2, j - 1, 2] != "kontrol edildi")
                                skonumlar[i - 2, j - 1, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - 2, j - 1, 1]) / 2));
                            skonumlar[i - 2, j - 1, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (skonumlar[i + 2, j - 1, 1] != null && skonumlar[i + 2, j - 1, 2] != "kontrol edildi")
                                skonumlar[i + 2, j - 1, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + 2, j - 1, 1]) / 2));
                            skonumlar[i + 2, j - 1, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (skonumlar[i - 2, j + 1, 1] != null && skonumlar[i - 2, j + 1, 2] != "kontrol edildi")
                                skonumlar[i - 2, j + 1, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - 2, j + 1, 1]) / 2));
                            skonumlar[i - 2, j + 1, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (skonumlar[i + 2, j + 1, 1] != null && skonumlar[i + 2, j + 1, 2] != "kontrol edildi")
                                skonumlar[i + 2, j + 1, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + 2, j + 1, 1]) / 2));
                            skonumlar[i + 2, j + 1, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (skonumlar[i - 1, j + 2, 1] != null && skonumlar[i - 1, j + 2, 2] != "kontrol edildi")
                                skonumlar[i - 1, j + 2, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - 1, j + 2, 1]) / 2));
                            skonumlar[i - 1, j + 2, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (skonumlar[i + 1, j + 2, 1] != null && skonumlar[i + 1, j + 2, 2] != "kontrol edildi")
                                skonumlar[i + 1, j + 2, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + 1, j + 2, 1]) / 2));
                            skonumlar[i + 1, j + 2, 2] = "kontrol edildi";

                        }
                        catch { }

                    }
                    /*if (bkonumlar[i, j, 0] == "f")/ eğer fil bir piyon varsa tehdit durumunda siyah bir taş var mı diye kontrol ediyorum.
                    {

                        for (int a = 1; a < 8; a++)
                        {
                            int cont1 = 0;
                            int cont2 = 0;
                            int cont3 = 0;
                            int cont4 = 0;


                            try
                            {
                                if (bkonumlar[i - a, j - a, 0] != null) { cont1 = 1; }
                                if (cont1 == 0)
                                {
                                    if (skonumlar[i - a, j - a, 1] != null && skonumlar[i - a, j - a, 2] != "kontrol edildi")
                                        skonumlar[i - a, j - a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - a, j - a, 1]) / 2));
                                    skonumlar[i - a, j - a, 2] = "kontrol edildi";
                                }
                            }
                            catch { }
                            try
                            {
                                if (bkonumlar[i + a, j - a, 0] != null) { cont2 = 1; }
                                if (cont2 == 0)
                                {
                                    if (skonumlar[i + a, j - a, 1] != null && skonumlar[i + a, j - a, 2] != "kontrol edildi")
                                        skonumlar[i + a, j - a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + a, j - a, 1]) / 2));
                                    skonumlar[i + a, j - a, 2] = "kontrol edildi";

                                }
                            }
                            catch { }
                            try
                            {
                                if (bkonumlar[i + a, j + a, 0] != null) { cont3 = 1; }
                                if (cont3 == 0)
                                {
                                    if (skonumlar[i + a, j + a, 1] != null && skonumlar[i + a, j + a, 2] != "kontrol edildi")
                                        skonumlar[i + a, j + a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + a, j + a, 1]) / 2));
                                    skonumlar[i + a, j + a, 2] = "kontrol edildi";

                                }

                            }
                            catch { }
                            try
                            {
                                if (bkonumlar[i - a, j + a, 0] != null) { cont4 = 1; }
                                if (cont4 == 0)
                                {
                                    if (skonumlar[i - a, j + a, 1] != null && skonumlar[i - a, j + a, 2] != "kontrol edildi")
                                        skonumlar[i - a, j + a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - a, j + a, 1]) / 2));
                                    skonumlar[i - a, j + a, 2] = "kontrol edildi";

                                }

                            }
                            catch { }

                        }

                    }*/
                    if (bkonumlar[i, j, 0] == "v")// eğer beyaz bir vezir varsa tehdit durumunda siyah bir taş var mı diye kontrol ediyorum.
                    {
                        int cont1 = 0;
                        int cont2 = 0;
                        int cont3 = 0;
                        int cont4 = 0;
                        int cont5 = 0;
                        int cont6 = 0;
                        int cont7 = 0;
                        int cont8 = 0;

                        for (int a = 1; a < 8; a++)
                        {
                            try
                            {
                                if (cont5 == 0)
                                {
                                    if (bkonumlar[i + a, j, 0] != null || skonumlar[i + a, j, 0] != null) { cont5 = 1; }

                                    if (skonumlar[i + a, j, 1] != null && skonumlar[i + a, j, 2] != "kontrol edildi")
                                        skonumlar[i + a, j, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + a, j, 1]) / 2));
                                    skonumlar[i + a, j, 2] = "kontrol edildi";
                                }

                            }
                            catch { }
                            try
                            {

                                if (cont6 == 0)
                                {
                                    if (bkonumlar[i - a, j, 0] != null || skonumlar[i - a, j, 0] != null) { cont6 = 1; }
                                    if (skonumlar[i - a, j, 1] != null && skonumlar[i - a, j, 2] != "kontrol edildi")
                                        skonumlar[i - a, j, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - a, j, 1]) / 2));
                                    skonumlar[i - a, j, 2] = "kontrol edildi";
                                }
                            }
                            catch { }
                            try
                            {

                                if (cont7 == 0)
                                {
                                    if (bkonumlar[i, j + a, 0] != null || skonumlar[i, j + a, 0] != null) { cont7 = 1; }
                                    if (skonumlar[i, j + a, 1] != null && skonumlar[i, j + a, 2] != "kontrol edildi")
                                        skonumlar[i, j + a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i, j + a, 1]) / 2));
                                    skonumlar[i, j + a, 2] = "kontrol edildi";
                                }

                            }
                            catch { }
                            try
                            {

                                if (cont8 == 0)
                                {
                                    if (bkonumlar[i, j - a, 0] != null || skonumlar[i, j - a, 0] != null) { cont8 = 1; }
                                    if (skonumlar[i, j - a, 1] != null && skonumlar[i, j - a, 2] != "kontrol edildi")
                                        skonumlar[i, j - a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i, j - a, 1]) / 2));
                                    skonumlar[i, j - a, 2] = "kontrol edildi";
                                }

                            }
                            catch { }

                            if (a != j)
                            {
                                try
                                {

                                    if (cont1 == 0)
                                    {
                                        if (bkonumlar[i - a, j - a, 0] != null || skonumlar[i - a, j - a, 0] != null) { cont1 = 1; }
                                        if (skonumlar[i - a, j - a, 1] != null && skonumlar[i - a, j - a, 2] != "kontrol edildi")
                                            skonumlar[i - a, j - a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - a, j - a, 1]) / 2));
                                        skonumlar[i - a, j - a, 2] = "kontrol edildi";
                                    }
                                }
                                catch { }
                                try
                                {

                                    if (cont2 == 0)
                                    {
                                        if (bkonumlar[i + a, j - a, 0] != null || skonumlar[i + a, j - a, 0] != null) { cont2 = 1; }
                                        if (skonumlar[i + a, j - a, 1] != null && skonumlar[i + a, j - a, 2] != "kontrol edildi")
                                            skonumlar[i + a, j - a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + a, j - a, 1]) / 2));
                                        skonumlar[i + a, j - a, 2] = "kontrol edildi";

                                    }
                                }
                                catch { }
                                try
                                {

                                    if (cont3 == 0)
                                    {
                                        if (bkonumlar[i + a, j + a, 0] != null || skonumlar[i + a, j + a, 0] != null) { cont3 = 1; }
                                        if (skonumlar[i + a, j + a, 1] != null && skonumlar[i + a, j + a, 2] != "kontrol edildi")
                                            skonumlar[i + a, j + a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i + a, j + a, 1]) / 2));
                                        skonumlar[i + a, j + a, 2] = "kontrol edildi";

                                    }

                                }
                                catch { }
                                try
                                {

                                    if (cont4 == 0)
                                    {
                                        if (bkonumlar[i - a, j + a, 0] != null || skonumlar[i - a, j + a, 0] != null) { cont4 = 1; }
                                        if (skonumlar[i - a, j + a, 1] != null && skonumlar[i - a, j + a, 2] != "kontrol edildi")
                                            skonumlar[i - a, j + a, 1] = Convert.ToString((Convert.ToDouble(skonumlar[i - a, j + a, 1]) / 2));
                                        skonumlar[i - a, j + a, 2] = "kontrol edildi";

                                    }

                                }
                                catch { }

                            }
                        }

                    }

                    // yukardaki tehdit durumları fonsiyonlaştırılıp parametrelerle siyah ve beyaz konumlar gönderilmeliydi.
                    //aşağıda da aynı tehdit durumlarını beyaz taşlar için yapıyorum.

                    if (skonumlar[i, j, 0] == "p")
                    {

                        try
                        {
                            if (bkonumlar[i - 1, j + 1, 1] != null && bkonumlar[i - 1, j + 1, 2] != "kontrol edildi")
                                bkonumlar[i - 1, j + 1, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - 1, j + 1, 1]) / 2));
                            bkonumlar[i - 1, j + 1, 2] = "kontrol edildi";


                        }
                        catch { }
                        try
                        {
                            if (bkonumlar[i + 1, j + 1, 1] != null && bkonumlar[i + 1, j + 1, 2] != "kontrol edildi")
                                bkonumlar[i + 1, j + 1, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + 1, j + 1, 1]) / 2));
                            bkonumlar[i + 1, j + 1, 2] = "kontrol edildi";
                        }
                        catch { }
                    }
                    if (skonumlar[i, j, 0] == "a")
                    {
                        try
                        {
                            if (bkonumlar[i - 1, j - 2, 1] != null && bkonumlar[i - 1, j - 2, 2] != "kontrol edildi")
                                bkonumlar[i - 1, j - 2, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - 1, j - 2, 1]) / 2));
                            bkonumlar[i - 1, j - 2, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (bkonumlar[i + 1, j - 2, 1] != null && bkonumlar[i + 1, j - 2, 2] != "kontrol edildi")
                                bkonumlar[i + 1, j - 2, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + 1, j - 2, 1]) / 2));
                            bkonumlar[i + 1, j - 2, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (bkonumlar[i - 2, j - 1, 1] != null && bkonumlar[i - 2, j - 1, 2] != "kontrol edildi")
                                bkonumlar[i - 2, j - 1, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - 2, j - 1, 1]) / 2));
                            bkonumlar[i - 2, j - 1, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (bkonumlar[i + 2, j - 1, 1] != null && bkonumlar[i + 2, j - 1, 2] != "kontrol edildi")
                                bkonumlar[i + 2, j - 1, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + 2, j - 1, 1]) / 2));
                            bkonumlar[i + 2, j - 1, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (bkonumlar[i - 2, j + 1, 1] != null && bkonumlar[i - 2, j + 1, 2] != "kontrol edildi")
                                bkonumlar[i - 2, j + 1, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - 2, j + 1, 1]) / 2));
                            bkonumlar[i - 2, j + 1, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (bkonumlar[i + 2, j + 1, 1] != null && bkonumlar[i + 2, j + 1, 2] != "kontrol edildi")
                                bkonumlar[i + 2, j + 1, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + 2, j + 1, 1]) / 2));
                            bkonumlar[i + 2, j + 1, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (bkonumlar[i - 1, j + 2, 1] != null && bkonumlar[i - 1, j + 2, 2] != "kontrol edildi")
                                bkonumlar[i - 1, j + 2, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - 1, j + 2, 1]) / 2));
                            bkonumlar[i - 1, j + 2, 2] = "kontrol edildi";

                        }
                        catch { }
                        try
                        {
                            if (bkonumlar[i + 1, j + 2, 1] != null && bkonumlar[i + 1, j + 2, 2] != "kontrol edildi")
                                bkonumlar[i + 1, j + 2, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + 1, j + 2, 1]) / 2));
                            bkonumlar[i + 1, j + 2, 2] = "kontrol edildi";

                        }
                        catch { }

                    }
                    /*if (skonumlar[i, j,0] == "f")
                    {
                       
                        for (int a = 1; a < 8; a++)
                        {
                            int cont1 = 0;
                            int cont2 = 0;
                            int cont3 = 0;
                            int cont4 = 0;


                                try
                                {
                                if (skonumlar[i - a, j - a,0]!=null) { cont1 = 1; }
                                if (cont1 == 0) {                                    
                                    if (bkonumlar[i - a, j - a, 1] != null && bkonumlar[i - a, j - a, 2] != "kontrol edildi")
                                        bkonumlar[i - a, j - a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - a, j - a, 1]) / 2));
                                    bkonumlar[i - a, j - a, 2] = "kontrol edildi";
                                }                             
                                }
                                catch { }
                            try
                            {
                                if (skonumlar[i + a, j - a, 0] != null) { cont2 = 1; }
                                if (cont2 == 0)
                                {
                                    if (bkonumlar[i + a, j - a, 1] != null && bkonumlar[i + a, j - a, 2] != "kontrol edildi")
                                        bkonumlar[i + a, j - a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + a, j - a, 1]) / 2));
                                    bkonumlar[i + a, j - a, 2] = "kontrol edildi";
                                   
                                }
                            }
                            catch { }
                                try
                                {
                                if (skonumlar[i + a, j + a, 0] != null) { cont3 = 1; }
                                if (cont3 == 0)
                                {
                                    if (bkonumlar[i + a, j + a, 1] != null && bkonumlar[i + a, j+ a, 2] != "kontrol edildi")
                                        bkonumlar[i + a, j + a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + a, j + a, 1]) / 2));
                                    bkonumlar[i + a, j + a, 2] = "kontrol edildi";

                                }
                               
                                }
                                catch { }
                                try
                                {
                                if (skonumlar[i - a, j + a, 0] != null) { cont4 = 1; }
                                if (cont4 == 0)
                                {
                                    if (bkonumlar[i - a, j + a, 1] != null && bkonumlar[i - a, j + a, 2] != "kontrol edildi")
                                        bkonumlar[i - a, j + a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - a, j + a, 1]) / 2));
                                    bkonumlar[i - a, j + a, 2] = "kontrol edildi";

                                }

                            }
                            catch { }
                            
                        }

                    }*/
                    if (skonumlar[i, j, 0] == "v")
                    {
                        int cont1 = 0;
                        int cont2 = 0;
                        int cont3 = 0;
                        int cont4 = 0;
                        int cont5 = 0;
                        int cont6 = 0;
                        int cont7 = 0;
                        int cont8 = 0;

                        for (int a = 1; a < 8; a++)
                        {
                            try
                            {

                                if (cont5 == 0)
                                {
                                    if (skonumlar[i + a, j, 0] != null || bkonumlar[i + a, j, 0] != null) { cont5 = 1; }
                                    if (bkonumlar[i + a, j, 1] != null && bkonumlar[i + a, j, 2] != "kontrol edildi")
                                        bkonumlar[i + a, j, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + a, j, 1]) / 2));
                                    bkonumlar[i + a, j, 2] = "kontrol edildi";
                                }

                            }
                            catch { }
                            try
                            {

                                if (cont6 == 0)
                                {
                                    if (skonumlar[i - a, j, 0] != null || bkonumlar[i - a, j, 0] != null) { cont6 = 1; }
                                    if (bkonumlar[i - a, j, 1] != null && bkonumlar[i - a, j, 2] != "kontrol edildi")
                                        bkonumlar[i - a, j, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - a, j, 1]) / 2));
                                    bkonumlar[i - a, j, 2] = "kontrol edildi";
                                }

                            }
                            catch { }
                            try
                            {

                                if (cont7 == 0)
                                {
                                    if (skonumlar[i, j + a, 0] != null || bkonumlar[i, j + a, 0] != null) { cont7 = 1; }
                                    if (bkonumlar[i, j + a, 1] != null && bkonumlar[i, j + a, 2] != "kontrol edildi")
                                        bkonumlar[i, j + a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i, j + a, 1]) / 2));
                                    bkonumlar[i, j + a, 2] = "kontrol edildi";
                                }

                            }
                            catch { }
                            try
                            {

                                if (cont8 == 0)
                                {
                                    if (skonumlar[i, j - a, 0] != null || bkonumlar[i, j - a, 0] != null) { cont8 = 1; }
                                    if (bkonumlar[i, j - a, 1] != null && bkonumlar[i, j - a, 2] != "kontrol edildi")
                                        bkonumlar[i, j - a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i, j - a, 1]) / 2));
                                    bkonumlar[i, j - a, 2] = "kontrol edildi";
                                }

                            }
                            catch { }

                            if (a != j)
                            {
                                try
                                {

                                    if (cont1 == 0)
                                    {
                                        if (skonumlar[i - a, j - a, 0] != null || bkonumlar[i - a, j - a, 0] != null) { cont1 = 1; }
                                        if (bkonumlar[i - a, j - a, 1] != null && bkonumlar[i - a, j - a, 2] != "kontrol edildi")
                                            bkonumlar[i - a, j - a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - a, j - a, 1]) / 2));
                                        bkonumlar[i - a, j - a, 2] = "kontrol edildi";
                                    }
                                }
                                catch { }
                                try
                                {

                                    if (cont2 == 0)
                                    {
                                        if (skonumlar[i + a, j - a, 0] != null || bkonumlar[i + a, j - a, 0] != null) { cont2 = 1; }
                                        if (bkonumlar[i + a, j - a, 1] != null && bkonumlar[i + a, j - a, 2] != "kontrol edildi")
                                            bkonumlar[i + a, j - a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + a, j - a, 1]) / 2));
                                        bkonumlar[i + a, j - a, 2] = "kontrol edildi";

                                    }
                                }
                                catch { }
                                try
                                {

                                    if (cont3 == 0)
                                    {
                                        if (skonumlar[i + a, j + a, 0] != null || bkonumlar[i + a, j + a, 0] != null) { cont3 = 1; }
                                        if (bkonumlar[i + a, j + a, 1] != null && bkonumlar[i + a, j + a, 2] != "kontrol edildi")
                                            bkonumlar[i + a, j + a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i + a, j + a, 1]) / 2));
                                        bkonumlar[i + a, j + a, 2] = "kontrol edildi";

                                    }

                                }
                                catch { }
                                try
                                {

                                    if (cont4 == 0)
                                    {
                                        if (skonumlar[i - a, j + a, 0] != null || bkonumlar[i - a, j + a, 0] != null) { cont4 = 1; }
                                        if (bkonumlar[i - a, j + a, 1] != null && bkonumlar[i - a, j + a, 2] != "kontrol edildi")
                                            bkonumlar[i - a, j + a, 1] = Convert.ToString((Convert.ToDouble(bkonumlar[i - a, j + a, 1]) / 2));
                                        bkonumlar[i - a, j + a, 2] = "kontrol edildi";

                                    }

                                }
                                catch { }

                            }
                        }

                    }


                }

            }
            puanhesapla(bkonumlar, skonumlar);
        }
        // puan hesabı
        public void puanhesapla(string[,,] beyaz, string[,,] siyah)
        {

            for (int b = 0; b < 8; b++)
            {
                for (int c = 0; c < 8; c++)
                {
                    beyazpuan = Convert.ToDouble(beyaz[b, c, 1]) + beyazpuan;

                    siyahpuan = Convert.ToDouble(siyah[b, c, 1]) + siyahpuan;

                }

            }

            listBox2.Items.Add("Siyah Puanı");
            listBox2.Items.Add(siyahpuan);
            listBox1.Items.Add("Beyaz Puanı");
            listBox1.Items.Add(beyazpuan);
        }


    }
}




