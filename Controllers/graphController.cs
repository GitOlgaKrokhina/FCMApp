using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FCMApp.Views;

namespace FCMApp.Controllers
{
    class graphController
    {
    }
    //Классы VertexDraw, EdgeDraw и DrawGrapg релизуют необходимые для визуализации графа функции, а также некоторые алгоритмы
    //Класс VertexDraw - класс для создания вершин, хранящий в себе координаты конкретной вершины на плоскости
    public class VertexDraw
    {
        //Координаты местонахождения вершины на плоскости
        public int x, y;
        //Конструктор
        public VertexDraw(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    //Класс EdgeDraw - класс для создания ребер, хранящий в себе информацию о том, какие вершины соединяет ребро
    public class EdgeDraw
    {
        // v1 и v2 (кратко vertex1 и vertex2) - вершины, которые соединяет ребро
        public int v1, v2;
        //Конструктор
        public EdgeDraw(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
    //Класс DrawGraph - класс, отвечающий за визуализацию необходимых элементов
    class DrawGraph
    {
        //Объект, используемый для работы с изображениями, определяемыми данными пикселей
        Bitmap bitmap;
        //Цвета линий
        Pen redPen;
        Pen skyBluePen;
        Pen darkBluePen;
        //Поверхность рисования
        Graphics graphicsGDI;
        //Формат текста (текст в вершинах, подписи к ребрам)
        Font textFormat;
        //Заливка фигур
        Brush brush;
        //Пара чисел, координаты на двумерной плоскости
        PointF points;
        //Радиус для вершины (окружность)
        public int Radius = 11;
        //Конструктор, в который мы передаем размеры поверхности для работы
        public DrawGraph(int width, int height)
        {
            //Создаем объект, определяемый пикселями, для работы
            bitmap = new Bitmap(width, height);
            //Создаем поверхность
            graphicsGDI = Graphics.FromImage(bitmap);
            //Очищаем поверхность
            clearAllSheet();
            //Задаем цвета линий и их размер
            darkBluePen = new Pen(Color.DarkBlue);
            darkBluePen.Width = 2;
            redPen = new Pen(Color.Red);
            redPen.Width = 2;
            skyBluePen = new Pen(Color.SkyBlue);
            skyBluePen.Width = 2;
            //Задаем стиль и размер текста на графике
            textFormat = new Font("Arial", 8);
            //Задаем цвет кисти для заливки
            brush = Brushes.Black;
        }
        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        //Очистить поверхность (цвет фона белый)
        public void clearAllSheet()
        {
            graphicsGDI.Clear(Color.White);
        }

        //Функции для визуализация элементов и графа в целом
        public void drawVertex(int x, int y, string number) //Нарисовать вершину
        {
            //Создание эллипса по определнным измерениям, зависящим от радиуса, заполнение белым цветом
            graphicsGDI.FillEllipse(Brushes.White, (x - Radius), (y - Radius), 2 * Radius, 2 * Radius);
            //Создание контура эллипса темно синего цвета
            graphicsGDI.DrawEllipse(darkBluePen, (x - Radius), (y - Radius), 2 * Radius, 2 * Radius);
            //Создание координатной пары на основе выбранной для фигуры позиции
            points = new PointF(x - 9, y - 9);
            //Создание текстовой строки в указанном месте
            graphicsGDI.DrawString(number, textFormat, brush, points);
        }
        public void drawSelectedVertex(int x, int y) //Выделить вершину, которую мы выбираем для получения информации
        {
            //Выделение границы фигуры красным цветом
            graphicsGDI.DrawEllipse(redPen, (x - Radius), (y - Radius), 2 * Radius, 2 * Radius);
        }
        public void drawEdge(VertexDraw V1, VertexDraw V2, EdgeDraw E, int numberE, double weight) //Нарисовать ребро
        {
            Pen pen = new Pen(Color.LightBlue, 3);
            pen.CustomEndCap = new AdjustableArrowCap(6, 6);

            if ((FCMView.SelectedVertex.Contains(Convert.ToInt32(E.v2.ToString() + E.v1.ToString()))))
            {
                float radius = 200;
                PointF A = new PointF(V1.x, V1.y);

                PointF B = new PointF(V2.x, V2.y);

                // get distance components
                double x = B.X - A.X, y = B.Y - A.Y;
                // get orientation angle
                var θ = Math.Atan2(y, x);
                // length between A and B
                var l = Math.Sqrt(x * x + y * y);
                // find the sweep angle (actually half the sweep angle)
                var φ = Math.Asin(l / (2 * radius));
                // triangle height from the chord to the center
                var h = radius * Math.Cos(φ);
                // get center point. 
                // Use sin(θ)=y/l and cos(θ)=x/l
                PointF C = new PointF(
                    (float)(A.X + x / 2 - h * (y / l)),
                    (float)(A.Y + y / 2 + h * (x / l)));

                // Conversion factor between radians and degrees
                const double to_deg = 180 / Math.PI;

                // Draw arc based on square around center and start/sweep angles
                graphicsGDI.DrawArc(pen, C.X - radius, C.Y - radius, 2 * radius, 2 * radius,
                    (float)((θ - φ) * to_deg) - 90, (float)(2 * φ * to_deg));


                // координаты конечных точек дуги
                double x1 = V1.x;
                double y1 = V1.y;
                double x2 = V2.x;
                double y2 = V2.y;


                // координаты центра окружности, на которой лежит дуга
                double centerX = (x1 + x2) / 2;
                double centerY = (y1 + y2) / 2;

                // расстояние между конечными точками дуги
                double chordLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                // расстояние от центра окружности до середины дуги
                double distance = Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(chordLength / 2, 2));

                // направление вектора от центра окружности к середине дуги
                double directionX = (y2 - y1) / chordLength;
                double directionY = (x1 - x2) / chordLength;

                // координаты середины дуги
                double midX = centerX + directionX * distance;
                double midY = centerY + directionY * distance;



                points = new PointF((float)(midX/2+ distance), (float)(midY/2 + distance/2));
                //Текстовая строка с названием ребра и его длиной
                graphicsGDI.DrawString((weight).ToString(), textFormat, brush, points);
                //Выделяем вершину
                drawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
                drawVertex(V2.x, V2.y, (E.v2 + 1).ToString());
                //Добавляем в словарь значения - название дуги и ее длину
                FCMView.forVertexes.Add((char)('a' + numberE), weight);
            }
            else
            {
                //Начальная и конечная не совпадают - соединяем их прямой линией
                graphicsGDI.DrawLine(pen, V1.x, V1.y, V2.x, V2.y);
                //Задание координат
                points = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                //Текстовая строка с названием ребра и его длиной
                graphicsGDI.DrawString((weight).ToString(), textFormat, brush, points);
                //Выделяем вершины, которые соеденили
                drawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
                drawVertex(V2.x, V2.y, (E.v2 + 1).ToString());
                //Добавляем в словарь значения - название дуги и ее длину
                FCMView.forVertexes.Add((char)('a' + numberE), weight);
            }

            
        }
        public void drawALLGraph(List<VertexDraw> V, List<EdgeDraw> E) //Нарисвать весь граф
        {
            //Рисуем все ребра
            for (int i = 0; i < E.Count; i++)
            {
                if (E[i].v1 == E[i].v2) //Если совпадают
                {
                    graphicsGDI.DrawArc(skyBluePen, (V[E[i].v1].x - 2 * Radius), (V[E[i].v1].y - 2 * Radius), 2 * Radius, 2 * Radius, 90, 270);
                    points = new PointF(V[E[i].v1].x - (int)(2.75 * Radius), V[E[i].v1].y - (int)(2.75 * Radius));
                    graphicsGDI.DrawString(((char)('a' + i) + "=" + FCMView.forVertexes[(char)('a' + i)]).ToString(), textFormat, brush, points);
                }
                else //Если не совпадают
                {
                    graphicsGDI.DrawLine(skyBluePen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                    points = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
                    graphicsGDI.DrawString(((char)('a' + i) + "=" + FCMView.forVertexes[(char)('a' + i)]).ToString(), textFormat, brush, points);
                }
            }
            //Рисуем все вершины
            for (int i = 0; i < V.Count; i++)
            {
                drawVertex(V[i].x, V[i].y, (i + 1).ToString());
            }
        }

        


    }
}
