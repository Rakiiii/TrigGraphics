using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadeSOmePictures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //созадапем битмап для каждого pctrbx
            Bitmap bmpPBMain = new Bitmap(pctrbxMain.Width, pctrbxMain.Height);
            Bitmap bmpPBSin = new Bitmap(pctrbxSin.Width, pctrbxSin.Height);
            Bitmap bmpPBCos = new Bitmap(pctrbxCos.Width, pctrbxCos.Height);
            Bitmap bmpPBCtg = new Bitmap(pctrbxCtg.Width, pctrbxCtg.Height);
            Bitmap bmpPBTg = new Bitmap(pctrbxTg.Width, pctrbxTg.Height);
            Pen blackPen = new Pen(Color.Black);
            //отрисоываем оси в каждом pctrbx
            bmpPBMain = Class1.drawMidleLines(bmpPBMain, pctrbxMain, blackPen);
            bmpPBSin = Class1.drawMidleLines(bmpPBSin, pctrbxSin, blackPen);
            bmpPBCos = Class1.drawMidleLines(bmpPBCos, pctrbxCos, blackPen);
            bmpPBCtg = Class1.drawMidleLines(bmpPBCtg, pctrbxCtg, blackPen);
            bmpPBTg = Class1.drawMidleLines(bmpPBTg, pctrbxTg, blackPen);
            Graphics grphMain = Graphics.FromImage(bmpPBMain);
            //рисуем еденичную окружность для главного pctrbx
            grphMain.DrawEllipse(blackPen,  new Rectangle( 10, 20, pctrbxMain.Width-20, pctrbxMain.Height-40));
            //изменяем изображения в pctrbx на наши битмапы
            pctrbxMain.Image = bmpPBMain;
            pctrbxSin.Image = bmpPBSin;
            pctrbxCos.Image = bmpPBCos;
            pctrbxCtg.Image = bmpPBCtg;
            pctrbxTg.Image = bmpPBTg;
            
        }

        //заполняем txtb
        private void txtbAngle_KeyPress(object sender, KeyPressEventArgs e)
        {

            //отлавливаем случайные ошибки

            try
            {
                //отсеиваем все кроме чисел
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '.'))
                {
                    return;
                }
                else
                {
                    //преверяем на минус
                    if (e.KeyChar == '-')
                    {
                        //если уже входил или пишется не первым,то не даем ввести
                        if ((txtbAngle.TextLength > 0) || (txtbAngle.Text.IndexOf('-') != -1))
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        //разарешаем удаление 
                        if (e.KeyChar == '\b')
                        {
                            return;
                        }
                        //двигаем фокус на следующий элемент
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            btnOk.Focus();
                        }
                        else
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            catch (Exception InputE)
            {
                lblAngle.Text = "Ops you broke some thing";
            }
        }

        //обрабатываем нажатие на кнопку ок
        private void btnOk_Click(object sender, EventArgs e)
        {
            //читаем угол
            double angle = Convert.ToDouble(txtbAngle.Text);
            double ilblAngle = 0.0;
            //переводим угл в необходимую велечину
            if(rdbAngle.Checked)
            {
                ilblAngle = ((Convert.ToDouble(txtbAngle.Text) * Math.PI) / 180)%(2*Math.PI);
                angle = ((Convert.ToDouble(txtbAngle.Text) * Math.PI) / 180) % (2 * Math.PI);
            }
            if(rdbRadian.Checked)
            {
                ilblAngle = ((Convert.ToDouble(txtbAngle.Text)*180)/Math.PI)%360;
            }
            //выводим переведенной значение в lbl
            lblAngle.Text = "angle=" + Convert.ToString(ilblAngle);
            //созадапем битмап для каждого pctrbx
            Bitmap bmpPBMain = new Bitmap(pctrbxMain.Width, pctrbxMain.Height);
            Bitmap bmpPBSin = new Bitmap(pctrbxSin.Width, pctrbxSin.Height);
            Bitmap bmpPBCos = new Bitmap(pctrbxCos.Width, pctrbxCos.Height);
            Bitmap bmpPBCtg = new Bitmap(pctrbxCtg.Width, pctrbxCtg.Height);
            Bitmap bmpPBTg = new Bitmap(pctrbxTg.Width, pctrbxTg.Height);
            Pen blackPen = new Pen(Color.Black);
            Pen redPen = new Pen(Color.Red);
            Graphics grphMain = Graphics.FromImage(bmpPBMain);
            //отрисоываем оси в каждом pctrbx
            bmpPBMain = Class1.drawMidleLines(bmpPBMain, pctrbxMain, blackPen);
            bmpPBSin = Class1.drawMidleLines(bmpPBSin, pctrbxSin, blackPen);
            bmpPBCos = Class1.drawMidleLines(bmpPBCos, pctrbxCos, blackPen);
            bmpPBCtg = Class1.drawMidleLines1(bmpPBCtg, pctrbxCtg,blackPen);
            bmpPBTg = Class1.drawMidleLines(bmpPBTg, pctrbxTg, blackPen);
            //рисуем наш угол в еденичной окружности
            grphMain.DrawLine(redPen, (pctrbxMain.Width - 5) / 2, (pctrbxMain.Height) / 2,
                (int)((pctrbxMain.Width - 5) / 2 + Math.Cos(angle) * ((pctrbxMain.Width - 20) / 2)),
                (int)(pctrbxMain.Height / 2 - Math.Sin(angle) * ((pctrbxMain.Height - 40) / 2)));
            //рисуем еденичную окружность для главного pctrbx
            grphMain.DrawEllipse(blackPen, new Rectangle(10, 20, pctrbxMain.Width - 20, pctrbxMain.Height - 40));
            //рисуем наши триганометрически графики
            bmpPBSin = Class1.drawSin(bmpPBSin, pctrbxSin, redPen, angle);
            bmpPBCos = Class1.drawCos(bmpPBCos, pctrbxCos, redPen, angle);
            bmpPBTg = Class1.drawTg(bmpPBTg, pctrbxTg, redPen, angle);
            bmpPBCtg = Class1.drawCtg(bmpPBCtg, pctrbxCtg, redPen, angle);
            //выводим изменненные битмапы в pctrbx
            pctrbxMain.Image = bmpPBMain;
            pctrbxSin.Image = bmpPBSin;
            pctrbxCos.Image = bmpPBCos;
            pctrbxCtg.Image = bmpPBCtg;
            pctrbxTg.Image = bmpPBTg;
            //считаем и выводим значение угла в тригонометрических функциях
            label1.Text = "Sin=" + Convert.ToString(Math.Sin(angle));
            label2.Text = "Cos=" + Convert.ToString(Math.Cos(angle));
            label3.Text = "Tg=" + Convert.ToString(Math.Tan(angle));
            label4.Text = "Ctg=" + Convert.ToString(1/Math.Tan(angle));

        }
    }
}

