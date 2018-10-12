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
    //класс для отрисовки графиков
    static class Class1
    {
        //отрисовываем оси , в битмапе
        public static Bitmap drawMidleLines(Bitmap btm ,PictureBox somePictureBox , Pen somePen )
        {
            Graphics lines =  Graphics.FromImage(btm);
            lines.DrawLine(somePen, 0, (somePictureBox.Height / 2), somePictureBox.Width, (somePictureBox.Height / 2));
            lines.DrawLine(somePen, (somePictureBox.Width-5) / 2, 0, (somePictureBox.Width-5) / 2, somePictureBox.Height);
            return btm;
        }
        //костыльные оси для ctg
        public static Bitmap drawMidleLines1(Bitmap btm, PictureBox somePictureBox, Pen somePen)
        {
            Graphics lines = Graphics.FromImage(btm);
            lines.DrawLine(somePen, 0, ((somePictureBox.Height-0) / 2), somePictureBox.Width, ((somePictureBox.Height-0) / 2));
            lines.DrawLine(somePen, (somePictureBox.Width - 90) / 2, 0, (somePictureBox.Width - 90) / 2, somePictureBox.Height);
            return btm;
        }

        //отрисовываем синус
        public static Bitmap drawSin(Bitmap btm , PictureBox somePicturebox , Pen somePen , double angle)
        {
            Graphics gr = Graphics.FromImage(btm);
            //нужно для читаемости
            int x = somePicturebox.Width;
            int y = somePicturebox.Height / 2;
            //массив координат с плавающией запятой
            PointF[] ptf = new PointF[x];
            Pen secPen = new Pen(Color.Black);
            //заполняем массив координат с шагом в 1 пиксель
            for(int i = 0; i < x; i++)
            {          
                //x соответствует нынешнему пикселю
                ptf[i].X = i;
                //высчитываем y для синуса с учетом масштаба
                ptf[i].Y = (float)(((y/2) * (1 - Math.Sin(i * 8 * Math.PI / (x - 1))))+(y%50));
            }
            //костыль для коректной отрисовки относительно осей и масштаба из-зи кривых pctrbx
            int z = 5;
            if (angle == 0) z = 0;
            //отрисовываем график синуса
            gr.DrawLines(secPen, ptf);
            //отрисовываем линию обозначаюшую введенный пользователем синус
            gr.DrawLine(somePen, 0, (float)((y) - Math.Sin(angle) * (y/2) -z  ),
                somePicturebox.Width, (float)((y )- Math.Sin(angle) * (y/2) - z));
            //возвращаем изменненый битмап
            return btm;
        }

        //отрисовываем косинус
        public static Bitmap drawCos(Bitmap btm, PictureBox somePicturebox, Pen somePen, double angle)
        {
            Graphics gr = Graphics.FromImage(btm);
            //для читаемости заменяем переменные
            int x = somePicturebox.Width;
            int y = somePicturebox.Height / 2;
            //массив координат с плавающией запятой
            PointF[] ptf = new PointF[x];
            Pen secPen = new Pen(Color.Black);
            //заполняем массив координат с шагом в 1 пиксель
            for (int i = 0; i < x; i++)
            {
                //x соответствует нынешнему пикселю
                ptf[i].X = i;
                //высчитываем y для косинуса с учетом масштаба
                ptf[i].Y = (float)(((y / 2) * (1 - Math.Cos(i * 8 * Math.PI / (x - 1)))) + (y % 50));
            }            
            //костыль для коректной отрисовки относительно осей и масштаба из-зи кривых pctrbx
            int z = 5;
            if (angle == Math.PI/2 || angle == -Math.PI / 2) z = 0;
            //отрисовываем график косинуса
            gr.DrawLines(secPen, ptf);
            //отрисовываем прямую ,задданую пользователем
            gr.DrawLine(somePen, 0, (float)((y) - Math.Cos(angle) * (y / 2) -z ),
                somePicturebox.Width, (float)((y) - Math.Cos(angle) * (y / 2) - z));
            //возвращаем измененнный битмап
            return btm;
        }

        //отрисовываем тангенс
        public static Bitmap drawTg(Bitmap btm, PictureBox somePicturebox, Pen somePen, double angle)
        {
            Graphics gr = Graphics.FromImage(btm);
            //для читаемости заменяем переменные
            int x = somePicturebox.Width;
            int y = somePicturebox.Height / 2;
            //массив координат с плавающией запятой
            PointF[] ptf = new PointF[x];
            Pen secPen = new Pen(Color.Black);
            //заполняем массив координат с шагом в 1 пиксель
            for (int i = 0; i < x; i++)
            {
                //x соответствует нынешнему пикселю
                ptf[i].X = i;
                //высчитываем y для тангенса с учетом масштаба
                ptf[i].Y = (float)(((y / 2) * (1 - Math.Tan(i * 8 * Math.PI / (x - 1)))) + (y % 50));
            }  
            //костыль для масштаба
            int z = 0;
            //костыль для точек в, которых тангенса нет
            if (angle != Math.PI / 2 && angle != -Math.PI/2)
            {
                //рисуем пряму по введенному углу если она есть
                gr.DrawLine(somePen, 0, (float)((y) - Math.Tan(angle) * (y / 2) - z),
                    somePicturebox.Width, (float)((y) - Math.Tan(angle) * (y / 2) - z));
            }
            //рисуем график тангенса в битмапе
            gr.DrawLines(secPen, ptf);
            //вохвращаем изменненый битмап
            return btm;
        }

        //отрисовываем ctg
        public static Bitmap drawCtg(Bitmap btm, PictureBox somePicturebox, Pen somePen, double angle)
        {
            Graphics gr = Graphics.FromImage(btm);
            //для читаемости заменяем переменные
            int x = somePicturebox.Width;
            int y = somePicturebox.Height / 2;
            //массив координат с плавающией запятой
            PointF[] ptf = new PointF[x];
            Pen secPen = new Pen(Color.Black);
            //заполняем массив координат с шагом в 1 пиксель
            for (int i = 0; i < x; i++)
            {
                //x соответствует нынешнему пикселю
                ptf[i].X = i;
                //костыль чтобы исключить ситуацию, когда sinx =0
                if ((Math.Sin(i * 8 * Math.PI / (x - 1)) != 0)
                    //костыль чтоюы исключить ситуациию когда координаты почему-то выходят за пределы pctrbx
                    && ((float)(((y / 2) * (1 - Math.Cos(i * 8 * Math.PI / (x - 1)) / Math.Sin(i * 8 * Math.PI / (x - 1))))) < 200) 
                    //костыль для исключения координат когда ctg приблежается к асимптотам
                    && ((Math.Cos(i * 8 * Math.PI / (x - 1)) / Math.Sin(i * 8 * Math.PI / (x - 1))%Math.PI)!=Math.PI) )
                {
                    //для читабельности посчитаем ctg,x=i+5 - костыл для коректной отрисовки
                    double ctg = Math.Cos((i+5) * 8 * Math.PI / (x - 1)) / Math.Sin((i+5) * 8 * Math.PI / (x - 1));
                    //высчитываем y относительно ctg
                    ptf[i].Y = (float)(((y / 2) * (1 - ctg) + 50));
                }
            }
            //костыл для того, что бы не рисовать ctg по введенному углу, если его не существует
            if (angle != 0)
            {
                gr.DrawLine(somePen, 0, (float)((y) - 1 / Math.Tan(angle) * (y / 2)),
                somePicturebox.Width, (float)((y) - 1 / Math.Tan(angle) * (y / 2)));
            }
            //рисуем график ctg
            gr.DrawLines(secPen, ptf);
            //возвращаем битмап
            return btm;
        }


    }
}
