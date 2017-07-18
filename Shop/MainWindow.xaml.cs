using System;

using System.Windows;
using System.Windows.Input;
using NHibernate;
using NHibernate.Cfg;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Enter.Cursor = Cursors.Hand;
            New_Product.Cursor = Cursors.Hand;
           // var session = NHibernateHelper.SessionFactory;
           // session.Evict(typeof(Settings));
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            Ordering order = new Ordering();
          
            order.Show();
            order.ResizeMode = ResizeMode.NoResize;
            order.Width = 600;
            order.Height = 350;
            order.Owner = this;
            
        }

        private void New_Product_Click(object sender, RoutedEventArgs e)
        {
            Add_product add = new Add_product();
            add.ResizeMode = ResizeMode.NoResize;

            add.Show();
            add.Width = 350;
            add.Height = 350;
            add.Owner = this;
        }
    }
}
