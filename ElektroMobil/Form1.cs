using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElektroMobil
{
    public partial class Voltacar : Form
    {
        private string data;


        public Voltacar()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port);               //Seri portları comboBox1'e ekleme
           
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
            comboBox2.Items.Add(4800);
            comboBox2.Items.Add(9600);
            comboBox2.Items.Add(19200);
            label3.Text = "Bağlantı Kapalı";
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();                      //Veriyi al
            this.Invoke(new EventHandler(displayData_event));
        }

        private void displayData_event(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int ms = dt.Millisecond;
            textBox1.Text += Convert.ToString(DateTime.Now)+":";
            textBox1.Text += ms.ToString()+";"+data+ "\n";
            textBox2.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            string[] tt = new string[100];
            tt = data.Split(';');
            textBox2.Text = Convert.ToString(DateTime.Now)+":"+ ms.ToString() +"\n";
            textBox4.Text = tt[0] + "\n";
            textBox5.Text = tt[1] + "\n";
            textBox6.Text = tt[2] + "\n";
            textBox7.Text = tt[3] + "\n";
            



        }


        private void baslat_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;  
                
                serialPort1.Open();                     //Seri portu aç
                label3.Text = "Bağlantı Kuruldu";
                durdur.Enabled = true;                  //Durdurma butonunu aktif hale getir
                baslat.Enabled = false;                 //Başlatma butonunu pasif hale getir
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");    //Hata mesajı göster
            }
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            serialPort1.Close();        //Seri Portu kapa
            label3.Text = "Bağlantı Kapalı";
            durdur.Enabled = false;     //Durdurma butonunu pasif hale getir
            baslat.Enabled = true;      //Başlatma butonunu aktif hale getir
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat
        }


        private void sifirla_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();           //textBox1'i sıfırla
            textBox2.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();


        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
            
                string[] dizi = new string[4];
                dizi = Convert.ToString(DateTime.Now).Split(new char[] {' ',':'});
                StreamWriter file = new StreamWriter("Volta Data " + dizi[0]+" "+ dizi[1]+"."+ dizi[2]+ "." + dizi[3]+".txt", true);
                file.WriteLine(textBox1.Text);
                file.Close();
                MessageBox.Show("Dosya başarıyla kaydedildi", "Mesaj");                                     //Dosya kaydedildiğinde kullanıcıya mesaj gönder
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Hata");       //Hata mesajı
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = int.Parse(comboBox2.Text);
        }


    }
}

