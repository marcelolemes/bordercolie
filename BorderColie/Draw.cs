using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BorderColie
{
    class Draw
    {
        Bitmap foto;
        Bitmap borda;
        Bitmap resultado;
        int p_x;
        int p_y;
        int tam_x;
        int tam_y;
        int tamX;
        int tamY;

        public Bitmap desenhar(String fotoTxt, String bordaTxt, Boolean check, int tamanho)
        {
            if (tamanho == 15) {
                tam_x = (1795)*3;
                tam_y = (2480)*3;

                tamX = (2362)*2;
                tamY = (3543)*2;
            }
            else
            {
                tam_x = ((tamanho) * 118);
                tam_y = (3543);

                tamX = (2362);
            }
            foto = new Bitmap(fotoTxt);
            borda = new Bitmap(bordaTxt);
            resultado = new Bitmap(tam_x, tam_y);
         
            if (foto.Width > foto.Height)
            {
                foto.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            if (borda.Width > borda.Height)
            {
                borda.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }


            if (check == true)
            {
                using (Graphics g = Graphics.FromImage(resultado))
                {
                 

                    if (tamanho == 20)
                    {
                        p_x = (int)((tamX - (tamX * 0.9)) / 2); // ponto de referência  com relação à X
                        p_y = (int)((tam_y - (tam_y * 0.9)) / 2); // ponto de referência  com relação à Y

                        g.DrawImage(foto, new Rectangle(0, 0, tam_x, tam_y));
                        g.DrawImage(borda, new Rectangle(p_x, p_y, (int)(tamX * 0.9), (int)(tam_y * 0.9)));
                    }
                    else
                    {
                        p_x = (int)((tam_x - (tamX)) / 2); // ponto de referência  com relação à X
                        p_y = (int)((tam_y - (tam_y)) / 2); // ponto de referência  com relação à Y
                        g.DrawImage(foto, new Rectangle(0, 0, tam_x, tam_y));
                        g.DrawImage(borda, new Rectangle(p_x, p_y, (int)(tamX), (int)(tam_y)));
                    }
                }
            }
            else
            {
                using (Graphics g = Graphics.FromImage(resultado))
                {
                    if (tamanho == 15)
                    {
                       // tam_x = borda.Width;
                        //tam_y = borda.Height;
                        
                        p_x = (int)((tam_x - (tamX)) / 2); // ponto de referência  com relação à X
                        p_y = (int)((tam_y - (tamY)) / 2); // ponto de referência  com relação à Y

                        g.DrawImage(borda, new Rectangle(0, 0, tam_x, tam_y));
                        g.DrawImage(foto, new Rectangle(p_x, p_y, (int)(tamX), (int)(tamY)));
                    }

                    else if (tamanho == 20)
                    {
                        p_x = (int)((tamX - (tamX * 0.9)) / 2); // ponto de referência  com relação à X
                        p_y = (int)((tam_y - (tam_y * 0.9)) / 2); // ponto de referência  com relação à Y

                        g.DrawImage(borda, new Rectangle(0, 0, tam_x, tam_y));
                        g.DrawImage(foto, new Rectangle(p_x, p_y, (int)(tamX * 0.9), (int)(tam_y * 0.9)));
                    }
                    else
                    {
                        p_x = (int)((tam_x - (tamX)) / 2); // ponto de referência  com relação à X
                        p_y = (int)((tam_y - (tam_y)) / 2); // ponto de referência  com relação à Y
                        g.DrawImage(borda, new Rectangle(0, 0, tam_x, tam_y));
                        g.DrawImage(foto, new Rectangle(p_x, p_y, (int)(tamX), (int)(tam_y)));
                    }
                }
            }
            foto.Dispose();
            borda.Dispose();
            return resultado;



        }

    }
}
