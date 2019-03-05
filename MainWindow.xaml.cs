using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cglr1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    enum P
    {
        A, B
    }

    public partial class MainWindow : Window
    {
        const double c = 720;

        const double centerx = 350;
        const double centerz = 350;
        const double centery = 350;

        const double zx = 350;
        const double zy1 = 40;
        const double zy2 = 660;

        const double xx1 = 40;
        const double xy = 350;
        const double xx2 = 660;

        const double yx1 = 80;
        const double yy1 = 80;
        const double yx2 = 620;
        const double yy2 = 620;

        Point T = new Point(centerx, centerz);
        Point T1 = new Point(centerx, centerz);
        Point T2 = new Point(centerx, centerz);

        Point BT = new Point(centerx, centerz);
        Point BT1 = new Point(centerx, centerz);
        Point BT2 = new Point(centerx, centerz);

        Point CT1 = new Point(c + centerx, centerz);
        Point CT2 = new Point(c + centerx, centerz);
        Point CT3 = new Point(c + centerx, centerz);
        Point PCT1 = new Point(c + centerx, centerz);
        Point PCT2 = new Point(c + centerx, centerz);
        Point PCT3 = new Point(c + centerx, centerz);
        Point PCT4 = new Point(c + centerx, centerz);

        Point BCT1 = new Point(c + centerx, centerz);
        Point BCT2 = new Point(c + centerx, centerz);
        Point BCT3 = new Point(c + centerx, centerz);
        Point BPCT1 = new Point(c + centerx, centerz);
        Point BPCT2 = new Point(c + centerx, centerz);
        Point BPCT3 = new Point(c + centerx, centerz);
        Point BPCT4 = new Point(c + centerx, centerz);

        Line px = new Line();
        Line py = new Line();
        Line py1 = new Line();
        Line py2 = new Line();
        Line py3 = new Line();
        Line pz = new Line();
        Line pz1 = new Line();
        Line px1 = new Line();
        Line pz2 = new Line();
        Line px2 = new Line();
        Line pz3 = new Line();
        Line px3 = new Line();
        Line c1 = new Line();
        Line c2 = new Line();
        Line c3 = new Line();
        Line c4 = new Line();
        Line c5 = new Line();
        Line c6 = new Line();
        Line c7 = new Line();

        Line bpx = new Line();
        Line bpy = new Line();
        Line bpy1 = new Line();
        Line bpy2 = new Line();
        Line bpy3 = new Line();
        Line bpz = new Line();
        Line bpz1 = new Line();
        Line bpx1 = new Line();
        Line bpz2 = new Line();
        Line bpx2 = new Line();
        Line bpz3 = new Line();
        Line bpx3 = new Line();
        Line bc1 = new Line();
        Line bc2 = new Line();
        Line bc3 = new Line();
        Line bc4 = new Line();
        Line bc5 = new Line();
        Line bc6 = new Line();
        Line bc7 = new Line();

        Ellipse e = new Ellipse();
        Ellipse e1 = new Ellipse();
        Ellipse e2 = new Ellipse();
        Ellipse e3 = new Ellipse();
        Ellipse ce1 = new Ellipse();
        Ellipse ce2 = new Ellipse();
        Ellipse ce3 = new Ellipse();

        Ellipse be = new Ellipse();
        Ellipse be1 = new Ellipse();
        Ellipse be2 = new Ellipse();
        Ellipse be3 = new Ellipse();
        Ellipse bce1 = new Ellipse();
        Ellipse bce2 = new Ellipse();
        Ellipse bce3 = new Ellipse();

        TextBlock a = new TextBlock();
        TextBlock a1 = new TextBlock();
        TextBlock a2 = new TextBlock();
        TextBlock a3 = new TextBlock();
        TextBlock ca1 = new TextBlock();
        TextBlock ca2 = new TextBlock();
        TextBlock ca3 = new TextBlock();

        TextBlock b = new TextBlock();
        TextBlock b1 = new TextBlock();
        TextBlock b2 = new TextBlock();
        TextBlock b3 = new TextBlock();
        TextBlock cb1 = new TextBlock();
        TextBlock cb2 = new TextBlock();
        TextBlock cb3 = new TextBlock();

        Line lr = new Line();

        Line lrp1 = new Line();
        Line lrp2 = new Line();
        Line lrp3 = new Line();

        Line lrc1 = new Line();
        Line lrc2 = new Line();
        Line lrc3 = new Line();

        double savex = 0;
        double savey = 0;
        double savez = 0;

        P pn;

        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            InitializeXYZ();
            InitializeComplex();
            SetScrollBarValue();
            InitializeProections();
            InitializeNames();
            InitializePoints();
            Update(pz, px, px1, pz1, py, pz2, py2, px2, px3, pz3, py3, py1, T, T1, ref T2);
            UpdateComplex(ref CT1, ref CT2, ref CT3, PCT1, PCT2, PCT3, PCT4, c1, c2, c3, c4, c5, c6, c7);
            Update(bpz, bpx, bpx1, bpz1, bpy, bpz2, bpy2, bpx2, bpx3, bpz3, bpy3, bpy1, BT, BT1, ref BT2);
            UpdateComplex(ref BCT1, ref BCT2, ref BCT3, BPCT1, BPCT2, BPCT3, BPCT4, bc1, bc2, bc3, bc4, bc5, bc6, bc7);
            savex = sx.Value;
            savez = sz.Value;
            savey = sy.Value;
        }

        private void InitializeNames()
        {
            List<TextBlock> lt = new List<TextBlock>
            {
                a,a1,a2,a3,ca1,ca2,ca3,
                b,b1,b2,b3,cb1,cb2,cb3
            };
            foreach (TextBlock t in lt)
            {
                t.HorizontalAlignment = HorizontalAlignment.Left;
                t.VerticalAlignment = VerticalAlignment.Top;
                t.FontSize = 20;
                grid.Children.Add(t);
            }

            b.Text = "N";
            b1.Text = "N1";
            b2.Text = "N2";
            b3.Text = "N3";
            cb1.Text = "N1";
            cb2.Text = "N2";
            cb3.Text = "N3";

            a.Text = "M";
            a1.Text = "M1";
            a2.Text = "M2";
            a3.Text = "M3";
            ca1.Text = "M1";
            ca2.Text = "M2";
            ca3.Text = "M3";
        }

        private void SetScrollBarValue()
        {
            sx.Minimum = xx1;
            sx.Maximum = xx2;
            sy.Minimum = yx1;
            sy.Maximum = yx2;
            sz.Minimum = zy1;
            sz.Maximum = zy2;
            sx.Value = (sx.Maximum + sx.Minimum) / 2;
            sz.Value = (sz.Maximum + sz.Minimum) / 2;
            sy.Value = (sy.Maximum + sy.Minimum) / 2;
        }

        private void ToPrevious()
        {
            double s1 = sx.Value;
            double s2 = sy.Value;
            double s3 = sz.Value;

            sx.Value = savex;
            sz.Value = savez;
            sy.Value = savey;

            savex = s1;
            savey = s2;
            savez = s3;
        }

        private void InitializePoints()
        {
            List<Ellipse> le = new List<Ellipse>
            {
                e,e1,e2,e3,ce1,ce2,ce3,
                be,be1,be2,be3,bce1,bce2,bce3
            };
            foreach (Ellipse f in le)
            {
                f.HorizontalAlignment = HorizontalAlignment.Left;
                f.VerticalAlignment = VerticalAlignment.Top;
                f.Fill = Brushes.LightGreen;
                f.Stroke = Brushes.LightGreen;
                f.Width = 10;
                f.Height = 10;
                grid.Children.Add(f);
            }
        }

        private void InitializeProections()
        {
            DoubleCollection d = new DoubleCollection
                {
                    8,2
                };

            List<Line> ps = new List<Line>
            {
                px,py,pz,px1,px2,px3,py1,py2,py3,pz1,pz2,pz3,c1,c2,c3,c4,c5,c6,c7

            };

            List<Line> ls = new List<Line>
            {
                bpx,bpy,bpz,bpx1,bpx2,bpx3,bpy1,bpy2,bpy3,bpz1,bpz2,bpz3,bc1,bc2,bc3,bc4,bc5,bc6,bc7
            };

            List<Line> lrs = new List<Line>
            {
                lrp1,lrp2,lrp3,lrc1,lrc2,lrc3
            };

            foreach (Line l in ls)
            {
                l.Stroke = Brushes.Red;
                l.StrokeDashArray = d;
                l.StrokeThickness = 2;
                grid.Children.Add(l);
            }

            foreach (Line l in ps)
            {
                l.Stroke = Brushes.Blue;
                l.StrokeDashArray = d;
                l.StrokeThickness = 2;
                grid.Children.Add(l);
            }

            foreach (Line l in lrs)
            {
                l.Stroke = Brushes.Black;
                grid.Children.Add(l);
            }

            lr.Stroke = Brushes.Violet;
            lr.StrokeThickness = 3;
            grid.Children.Add(lr);
        }

        private void InitializeComplex()
        {
            Line xc = CreateLine(c + xx1, xy, c + xx2, xy, "X(-Y)");
            Line yc = CreateLine(c + zx, zy1, c + zx, zy2, "Z(-Y)");
            TextBlock name = new TextBlock();
            name.HorizontalAlignment = HorizontalAlignment.Left;
            name.VerticalAlignment = VerticalAlignment.Top;
            name.Margin = new Thickness(xc.X2 - 20, xc.Y2, 0, 0);
            name.Text = "Y(-X)";
            name.FontSize = 20;
            grid.Children.Add(name);
            TextBlock name1 = new TextBlock();
            name1.HorizontalAlignment = HorizontalAlignment.Left;
            name1.VerticalAlignment = VerticalAlignment.Top;
            name1.Margin = new Thickness(yc.X2, yc.Y2, 0, 0);
            name1.Text = "Y(-Z)";
            name1.FontSize = 20;
            grid.Children.Add(name1);
            grid.Children.Add(xc);
            grid.Children.Add(yc);
        }

        private void InitializeXYZ()
        {
            Line z = CreateLine(zx, zy1, zx, zy2, "Z");
            Line x = CreateLine(xx1, xy, xx2, xy, "X");
            Line y = CreateLine(yx2, yy2, yx1, yy1, "Y");
            Arrow(zx, zy2, zx, zy1);
            Arrow(xx2, xy, xx1, xy);
            Arrow(yx1, yy1, yx2, yy2);
            grid.Children.Add(x);
            grid.Children.Add(y);
            grid.Children.Add(z);
        }

        private Line CreateLine(double X1, double Y1, double X2, double Y2, string Name)
        {
            Line l = new Line
            {
                X1 = X1,
                X2 = X2,
                Y1 = Y1,
                Y2 = Y2
            };

            TextBlock name = new TextBlock();
            name.HorizontalAlignment = HorizontalAlignment.Left;
            name.VerticalAlignment = VerticalAlignment.Top;
            name.Margin = new Thickness(X1 + 10, Y1 + 10, 0, 0);
            name.Text = Name;
            name.FontSize = 20;
            grid.Children.Add(name);

            l.Stroke = Brushes.Black;
            l.StrokeThickness = 3;
            return l;
        }

        private void UpdateCoordinates()
        {
            tx.Text = "X = " + (sx.Value - centerx);
            ty.Text = "Y = " + (sy.Value - centery) / Math.Cos(45);
            tz.Text = "Z = " + (sz.Value - centerz);
        }

        private void UpdateComplex(ref Point CT1, ref Point CT2, ref Point CT3, Point PCT1, Point PCT2, Point PCT3, Point PCT4, Line c1, Line c2, Line c3, Line c4, Line c5, Line c6, Line c7)
        {
            CT1.X = c + (sx.Maximum + sx.Minimum - sx.Value);
            CT1.Y = sz.Maximum + sz.Minimum - sz.Value;

            CT2.X = c + (sx.Maximum + sx.Minimum - sx.Value);
            CT2.Y = sy.Value;

            CT3.X = c + sy.Value;
            CT3.Y = sz.Maximum + sz.Minimum - sz.Value;

            PCT1.X = c + centerx;
            PCT1.Y = sy.Value;

            PCT2.X = c + sy.Value;
            PCT2.Y = centery;

            PCT3.X = c + (sx.Maximum + sx.Minimum - sx.Value);
            PCT3.Y = centery;

            PCT4.X = c + centerx;
            PCT4.Y = sz.Maximum + sz.Minimum - sz.Value;

            c5.X1 = c4.X1;
            c5.Y1 = c4.Y1;
            c5.X2 = c3.X1;
            c5.Y2 = c3.Y1;

            c4.X1 = PCT2.X;
            c4.Y1 = PCT2.Y;
            c4.X2 = CT3.X;
            c4.Y2 = CT3.Y;

            c7.X1 = PCT4.X;
            c7.Y1 = PCT4.Y;
            c7.X2 = CT3.X;
            c7.Y2 = CT3.Y;

            c2.X1 = CT1.X;
            c2.Y1 = CT1.Y;
            c2.X2 = PCT4.X;
            c2.Y2 = PCT4.Y;

            c1.X1 = PCT3.X;
            c1.Y1 = PCT3.Y;
            c1.X2 = CT2.X;
            c1.Y2 = CT2.Y;

            c6.X1 = CT1.X;
            c6.Y1 = CT1.Y;
            c6.X2 = PCT3.X;
            c6.Y2 = PCT3.Y;

            c3.X1 = PCT1.X;
            c3.Y1 = PCT1.Y;
            c3.X2 = CT2.X;
            c3.Y2 = CT2.Y;
        }

        private void UpdateXYZThickness(Ellipse e, Ellipse e1, Ellipse e2, Ellipse e3, TextBlock a, TextBlock a1, TextBlock a2, TextBlock a3, Line px2, Line py2, Line px3, Point T2)
        {
            e3.Margin = new Thickness(px2.X1 - 5, px2.Y1 - 5, 0, 0);
            a3.Margin = new Thickness(px2.X1, px2.Y1, 0, 0);
            e2.Margin = new Thickness(py2.X2 - 5, py2.Y2 - 5, 0, 0);
            a2.Margin = new Thickness(py2.X2, py2.Y2 - 30, 0, 0);
            e1.Margin = new Thickness(px3.X2 - 5, px3.Y2 - 5, 0, 0);
            a1.Margin = new Thickness(px3.X2, px3.Y2, 0, 0);
            e.Margin = new Thickness(T2.X - 5, T2.Y - 5, 0, 0);
            a.Margin = new Thickness(T2.X, T2.Y, 0, 0);
        }

        private void UpdateComplexThickness(Ellipse ce1, Ellipse ce2, Ellipse ce3, TextBlock ca1, TextBlock ca2, TextBlock ca3, Point CT1, Point CT2, Point CT3)
        {
            ce1.Margin = new Thickness(CT2.X - 5, CT2.Y - 5, 0, 0);
            ca1.Margin = new Thickness(CT2.X, CT2.Y, 0, 0);
            ce2.Margin = new Thickness(CT1.X - 5, CT1.Y - 5, 0, 0);
            ca2.Margin = new Thickness(CT1.X, CT1.Y, 0, 0);
            ce3.Margin = new Thickness(CT3.X - 5, CT3.Y - 5, 0, 0);
            ca3.Margin = new Thickness(CT3.X, CT3.Y, 0, 0);
        }

        private void Update(Line ppz, Line ppx, Line ppx1, Line ppz1, Line ppy, Line ppz2, Line ppy2, Line ppx2, Line ppx3, Line ppz3, Line ppy3, Line ppy1, Point TT, Point TT1, ref Point TT2)
        {
            ppz.X1 = TT.X;
            ppz.Y1 = TT.Y;
            ppz.X2 = zx;
            ppz.Y2 = sz.Maximum + sz.Minimum - sz.Value;

            ppx.X1 = (sx.Maximum + sx.Minimum - sx.Value);
            ppx.Y1 = xy;
            ppx.X2 = TT.X;
            ppx.Y2 = TT.Y;

            ppx1.X1 = centerx;
            ppx1.Y1 = centerz;
            ppx1.X2 = (sx.Maximum + sx.Minimum - sx.Value);
            ppx1.Y2 = xy;

            ppz1.X1 = centerx;
            ppz1.Y1 = centerz;
            ppz1.X2 = zx;
            ppz1.Y2 = sz.Maximum + sz.Minimum - sz.Value;

            ppy.X1 = centerx;
            ppy.Y1 = centerz;
            ppy.X2 = TT1.X;
            ppy.Y2 = TT1.Y;

            ppz2.X1 = TT1.X;
            ppz2.Y1 = TT1.Y;
            ppz2.X2 = zx + (TT1.X - centerx);
            ppz2.Y2 = sz.Maximum + sz.Minimum - sz.Value + TT1.Y - centerz;

            ppy1.X1 = ppz1.X2;
            ppy1.Y1 = ppz1.Y2;
            ppy1.X2 = ppz2.X2;
            ppy1.Y2 = ppz2.Y2;

            ppx2.X1 = ppy1.X2;
            ppx2.Y1 = ppy1.Y2;
            ppx2.X2 = TT1.X + (ppz.X1 - ppz1.X1);
            ppx2.Y2 = TT1.Y + (ppz.Y1 - ppz1.Y1);

            ppy2.X1 = ppx2.X2;
            ppy2.Y1 = ppx2.Y2;
            ppy2.X2 = ppz.X1;
            ppy2.Y2 = ppz.Y1;

            ppx3.X1 = ppz2.X1;
            ppx3.Y1 = ppz2.Y1;
            ppx3.Y2 = TT1.X + (ppx1.Y2 - ppx1.Y1);
            ppx3.X2 = TT1.Y + (ppx1.X2 - ppx1.Y1);

            ppz3.X1 = ppx3.X2;
            ppz3.Y1 = ppx3.Y2;
            ppz3.X2 = ppx2.X2;
            ppz3.Y2 = ppx2.Y2;

            ppy3.X1 = ppx1.X2;
            ppy3.Y1 = ppx1.Y2;
            ppy3.X2 = ppx3.X2;
            ppy3.Y2 = ppx3.Y2;

            TT2.X = ppy2.X1;
            TT2.Y = ppy2.Y1;
        }

        private void FullUpdate()
        {
            switch (pn)
            {
                case P.A:
                    {
                        Update(pz, px, px1, pz1, py, pz2, py2, px2, px3, pz3, py3, py1, T, T1, ref T2);
                        UpdateComplex(ref CT1, ref CT2, ref CT3, PCT1, PCT2, PCT3, PCT4, c1, c2, c3, c4, c5, c6, c7);
                        UpdateCoordinates();
                        UpdateComplexThickness(ce1, ce2, ce3, ca1, ca2, ca3, CT1, CT2, CT3);
                        UpdateXYZThickness(e, e1, e2, e3, a, a1, a2, a3, px2, py2, px3, T2);
                        break;
                    }
                case P.B:
                    {
                        Update(bpz, bpx, bpx1, bpz1, bpy, bpz2, bpy2, bpx2, bpx3, bpz3, bpy3, bpy1, BT, BT1, ref BT2);
                        UpdateComplex(ref BCT1, ref BCT2, ref BCT3, BPCT1, BPCT2, BPCT3, BPCT4, bc1, bc2, bc3, bc4, bc5, bc6, bc7);
                        UpdateCoordinates();
                        UpdateComplexThickness(bce1, bce2, bce3, cb1, cb2, cb3, BCT1, BCT2, BCT3);
                        UpdateXYZThickness(be, be1, be2, be3, b, b1, b2, b3, bpx2, bpy2, bpx3, BT2);
                        break;
                    }
            }

            if ((bool)lb.IsChecked)
            {
                UpdateLine();
            }

        }

        public void UpdateLine()
        {
            lrp1.X1 = e1.Margin.Left + 5;
            lrp1.Y1 = e1.Margin.Top + 5;
            lrp1.X2 = be1.Margin.Left + 5;
            lrp1.Y2 = be1.Margin.Top + 5;

            lrp2.X1 = e2.Margin.Left + 5;
            lrp2.Y1 = e2.Margin.Top + 5;
            lrp2.X2 = be2.Margin.Left + 5;
            lrp2.Y2 = be2.Margin.Top + 5;

            lrp3.X1 = e3.Margin.Left + 5;
            lrp3.Y1 = e3.Margin.Top + 5;
            lrp3.X2 = be3.Margin.Left + 5;
            lrp3.Y2 = be3.Margin.Top + 5;

            lrc1.X1 = ce1.Margin.Left + 5;
            lrc1.Y1 = ce1.Margin.Top + 5;
            lrc1.X2 = bce1.Margin.Left + 5;
            lrc1.Y2 = bce1.Margin.Top + 5;

            lrc2.X1 = ce2.Margin.Left + 5;
            lrc2.Y1 = ce2.Margin.Top + 5;
            lrc2.X2 = bce2.Margin.Left + 5;
            lrc2.Y2 = bce2.Margin.Top + 5;

            lrc3.X1 = ce3.Margin.Left + 5;
            lrc3.Y1 = ce3.Margin.Top + 5;
            lrc3.X2 = bce3.Margin.Left + 5;
            lrc3.Y2 = bce3.Margin.Top + 5;

            lr.X1 = T2.X;
            lr.Y1 = T2.Y;
            lr.X2 = BT2.X;
            lr.Y2 = BT2.Y;
        }

        private void sx_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            T.X = (sx.Maximum + sx.Minimum - sx.Value);
            BT.X = (sx.Maximum + sx.Minimum - sx.Value);
            FullUpdate();
        }

        private void sy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            T1.Y = sy.Value;
            T1.X = sy.Value;
            BT1.Y = sy.Value;
            BT1.X = sy.Value;
            FullUpdate();
        }

        private void sz_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            T.Y = sz.Maximum + sz.Minimum - sz.Value;
            BT.Y = sz.Maximum + sz.Minimum - sz.Value;
            FullUpdate();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            pn = P.A;
            ToPrevious();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            pn = P.B;
            ToPrevious();
        }

        private void lb_Checked(object sender, RoutedEventArgs e)
        {
            UpdateLine();
            lr.Visibility = Visibility.Visible;
            lrc1.Visibility = Visibility.Visible;
            lrc2.Visibility = Visibility.Visible;
            lrc3.Visibility = Visibility.Visible;
            lrp1.Visibility = Visibility.Visible;
            lrp2.Visibility = Visibility.Visible;
            lrp3.Visibility = Visibility.Visible;
        }

        private void lb_Unchecked(object sender, RoutedEventArgs e)
        {
            lr.Visibility = Visibility.Collapsed;
            lrc1.Visibility = Visibility.Collapsed;
            lrc2.Visibility = Visibility.Collapsed;
            lrc3.Visibility = Visibility.Collapsed;
            lrp1.Visibility = Visibility.Collapsed;
            lrp2.Visibility = Visibility.Collapsed;
            lrp3.Visibility = Visibility.Collapsed;
        }

        private void Arrow(double x1, double y1, double x2, double y2)
        {
            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            double X = x2 - x1;
            double Y = y2 - y1;

            double X3 = x2 - (X / d) * 25;
            double Y3 = y2 - (Y / d) * 25;

            double Xp = y2 - y1;
            double Yp = x1 - x2;

            double X4 = X3 + (Xp / d) * 5;
            double Y4 = Y3 + (Yp / d) * 5;
            double X5 = X3 - (Xp / d) * 5;
            double Y5 = Y3 - (Yp / d) * 5;

            Line line = new Line
            {
                StrokeThickness = 3,
                Stroke = Brushes.Black,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };
            grid.Children.Add(line);

            line = new Line
            {
                StrokeThickness = 3,
                Stroke = Brushes.Black,
                X1 = x2 - (X / d) * 10,
                Y1 = y2 - (Y / d) * 10,
                X2 = X4,
                Y2 = Y4
            };
            grid.Children.Add(line);

            line = new Line
            {
                StrokeThickness = 3,
                Stroke = Brushes.Black,
                X1 = x2 - (X / d) * 10,
                Y1 = y2 - (Y / d) * 10,
                X2 = X5,
                Y2 = Y5
            };
            grid.Children.Add(line);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Line> lq = from UIElement element in grid.Children
                                   let line = element as Line
                                   where line != null && line.StrokeThickness < 3
                                   select line;

            foreach (var ln in lq)
                ln.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IEnumerable<Line> lq = from UIElement element in grid.Children
                                   let line = element as Line
                                   where line != null && line.StrokeThickness < 3
                                   select line;

            foreach (var line in lq)
                line.Visibility = Visibility.Visible;
        }
    }
}
