using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using bilgisayarkaydet;


namespace sevdasimsek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buton_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bilgisayarKaydet bilkay = new bilgisayarKaydet();
                bool sonuc = bilkay.kaydet(new models(textbox_ram.Text.Trim(), textbox_hdd.Text.Trim(), textbox_psuwatt.Text.Trim(), textbox_ekrankarti.Text.Trim(), textbox_anakart.Text.Trim()));
                if (sonuc)
                {
                    MessageBox.Show("işlem basarılı");
                }
                else
                {
                    MessageBox.Show("işlem basarısız");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("null referans hatası");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
