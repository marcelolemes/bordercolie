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

namespace BorderColie
{
    public partial class Form1 : Form
    {
        Draw draw = new Draw();
        List<String> imagens = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {


            try
            {
                if (fotoTxt.Text.Equals("Multiplos Valores") | imagens.Count > 1)
                {
                    foreach (String s in imagens)
                    {
                        Bordear_Imagens(s);
                    }

                }
                else
                    Bordear_Imagens(fotoTxt.Text);

            }
            catch
            { }
            MessageBox.Show("TERMINADO!");
            Application.Exit();
        }

        private void bordaTxt_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void bordaTxt_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                bordaTxt.Text = a.GetValue(0).ToString();
            }
            catch { }
        }

        private void bordaTxt_DragLeave(object sender, EventArgs e)
        {

        }

        private void fotoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fotoTxt_DragEnter(object sender, DragEventArgs e)
        {
            imagens.Clear();
            imagens.AddRange((String[])e.Data.GetData(DataFormats.FileDrop));
            if (imagens.Count > 1)
            {
                fotoTxt.Text = "Multiplos Valores";
            }
            else
            {
                Array ay = (Array)e.Data.GetData(DataFormats.FileDrop);
                fotoTxt.Text = ay.GetValue(0).ToString();
            }

        }

        private void fotoTxt_DragDrop(object sender, DragEventArgs e)
        {

        }

        public void Bordear_Imagens(String f)
        {
            List<String> parcial = new List<string>();
            parcial.AddRange(f.Split('\\'));
            StringBuilder caminhoDestino = new StringBuilder();
            String pastaDestino = parcial[parcial.Count - 2];
            String nomeAntigo = parcial[parcial.Count - 1];
            Bitmap finalImagem;
            parcial.Remove(nomeAntigo);
            parcial.Remove(pastaDestino);

            //MessageBox.Show("Nome antigo "+nomeAntigo+" pasta Destino "+pastaDestino); 

            foreach (String s in parcial)
            {
                caminhoDestino.Append(s + "\\");
            }
            //  MessageBox.Show(""+caminhoDestino);
            String reduzidas = caminhoDestino + "Reduzidas Borda\\" + pastaDestino;

            int tamanho=0;
            try
            {
                tamanho = Int16.Parse(comboBox1.SelectedItem.ToString().Substring(0, 2));
            }
            catch {
                tamanho = 20;
            }
            MessageBox.Show(""+tamanho);

            if (tamanho > 0)
            {
                
                finalImagem = draw.desenhar(f, bordaTxt.Text, checkBox1.Checked, tamanho);
                
            }
            else
            {
                
                finalImagem = draw.desenhar(f, bordaTxt.Text, checkBox1.Checked, 20);
            }
            try
            {
                if (!Directory.Exists(reduzidas))
                {
                    Directory.CreateDirectory(reduzidas);
                    File.Move(f, reduzidas + "\\" + nomeAntigo);
                }
                else
                {
                    try
                    {
                        File.Move(f, reduzidas + "\\" + nomeAntigo);
                    }
                    catch { }
                }
            }
            catch { }
            try
            {
                finalImagem.Save(caminhoDestino + pastaDestino + "\\" + nomeAntigo, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch { }
            finalImagem.Dispose();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("15X21");
            comboBox1.Items.Add("20X30");
            comboBox1.Items.Add("24X30");
            comboBox1.Equals("");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox1.SelectedItem.ToString().Equals("Tamanho"))
            {
                bordaTxt.Text = "N:\\Bordas Jpg\\borda" + comboBox1.SelectedItem.ToString() + ".jpg";
                MessageBox.Show(comboBox1.SelectedItem.ToString().Substring(0, 2));


            }
            else
            {



            }
        }
    }

}
