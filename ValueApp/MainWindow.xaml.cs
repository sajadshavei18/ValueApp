using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ValueApp.DAL;
using ValueApp.Entitis;

namespace ValueApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_OnClick(object sender, RoutedEventArgs e)
        {
            if (DriveBox.Text.Count() <= 1)
            {
                MessageBox.Show("مسیر فایل را مشخص کنید");
                return;
            }
            List<string> list = new List<string>();
            Context context = new Context();
            int KalameNumber = 0;
            int b = 1;
            int Drive = 0;
            int FileName = 0;
            for (int I = 0; I <= context.values.Count(); I++)
            {
                string[] aray = new string[1];
                int a = 0;
                var Kalame = context.values.Skip(KalameNumber).FirstOrDefault();
                var ListData = context.values.ToList();

                if (Kalame == null)
                {
                    break;
                }
                aray[0] = Kalame.Name + " ";
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {

                        aray[0] += value.Name + " ";
                        if (a == 10)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            aray[0] = Kalame.Name + " ";
                            a = -1;

                        }
                        a++;
                    }
                }

                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 2)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }




                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 3)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }


                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 4)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }


                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 5)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }

                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 6)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }


                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 7)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }


                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 8)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }


                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 9)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }


                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 10)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }


                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 11)
                        {
                            aray[0] += Kalame.Name + " ";
                        }

                        aray[0] += value.Name + " ";
                        if (a == 11)
                        {
                            list.Add(aray[0].Trim());

                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }

                aray[0] = null;
                a = 1;
                foreach (var value in ListData)
                {
                    if (value == Kalame)
                    {

                    }
                    else
                    {
                        if (a == 11)
                        {
                            aray[0] += Kalame.Name + " ";
                        }
                        aray[0] += value.Name + " ";

                        if (a == 11)
                        {

                            list.Add(aray[0].Trim());
                            aray[0] = null;
                            a = 0;

                        }

                        a++;
                    }
                }
                foreach (var VARIABLE in list)
                {
                    if (Drive == 10000)
                    {
                        FileName++;
                        Drive = -1;
                    }
                    File.AppendAllText($"{DriveBox.Text}/Info{FileName}.Text", VARIABLE + "\n");
                    Drive++;
                }
                list.Clear();

                KalameNumber++;
            }


            MessageBox.Show($"کلمات با موفقیت به جمله تبدیل شد");
            DriveBox.Text = "";
        }

        private void Add_OnClick(object sender, RoutedEventArgs e)
        {
            Context db = new Context();
            string[] aray = AddBox.Text.Split(" ");
            int a = 0;
            int b = 0;
            int c = 0;
            foreach (var s in aray)
            {


                if (s.Length > 8 || s.Length < 3)
                {
                    b++;
                }
                else
                {
                    bool any = db.values.Any(x => x.Name == s.ToLower());
                    if (any)
                    {
                        a++;
                    }
                    else
                    {
                        Value value = new Value()
                        {
                            Name = s.ToLower()
                        };
                        db.values.Add(value);
                        db.SaveChanges();
                        c++;
                    }
                }
            }
            MessageBox.Show($"تعداد ( {a} ) کلمه موجود بوده \n تعداد ( {b} ) کلمه یا کمتر از 3 ویا بیشتر از 8 کارکتر بوده \n تعداد ( {c} ) هم اضافه شده است");
            AddBox.Text = "";
        }
    }
}