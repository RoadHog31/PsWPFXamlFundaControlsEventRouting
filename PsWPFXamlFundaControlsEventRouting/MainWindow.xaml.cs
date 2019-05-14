using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PsWPFXamlFundaControlsEventRouting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.MouseEnter += MouseEnterHandler;
            myBorder.MouseEnter += MouseEnterHandler;
            myPanel.MouseEnter += MouseEnterHandler;
            myEllipse.MouseEnter += MouseEnterHandler;
            myRectangle.MouseEnter += MouseEnterHandler;

            this.MouseDown += MouseDownHandler;
            myBorder.MouseDown += MouseDownHandler;
            myPanel.MouseDown += MouseDownHandler;
            myEllipse.MouseDown += MouseDownHandler;
            myRectangle.MouseDown += MouseDownHandler;

            for (int i = 0; i <= 5; ++i)
            {
                Button btn = new Button();
                btn.Content = "Button " + 1;
                myPanel.Children.Add(btn);

                //btn.Click += new RoutedEventHandler(btn_Click);
            }
            myPanel.AddHandler(Button.ClickEvent, new RoutedEventHandler(btn_Click));
        }

        void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button) e.Source; 
            btn.Background = Brushes.Green;
        }

        private void MouseDownHandler(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("MouseEnter: " + sender);
        }

        private void MouseEnterHandler(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("MouseDown: " + sender);
        }
    }
}
