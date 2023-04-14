using MaterialDesignThemes.Wpf;
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
using training.ViewModel;

namespace training
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<SubItem> menuReg = new List<SubItem>();
            menuReg.Add(new SubItem("Customer",new UserControlCustomers()));
            menuReg.Add(new SubItem("Providers", new UserControlProviders()));
            menuReg.Add(new SubItem("Employees"));
            menuReg.Add(new SubItem("Products"));
            ItemMenu item0 = new ItemMenu("Register", menuReg, PackIconKind.Register);

            List<SubItem> menuSchd = new List<SubItem>();
            menuSchd.Add(new SubItem("Services"));
            menuSchd.Add(new SubItem("Meetings"));
            ItemMenu item1 = new ItemMenu("Schedule", menuSchd, PackIconKind.Schedule);

            List<SubItem> menuReport = new List<SubItem>();            
            menuReport.Add(new SubItem("Products"));
            menuReport.Add(new SubItem("Stock"));
            menuReport.Add(new SubItem("Sales"));
            ItemMenu item2 = new ItemMenu("Reports", menuReport, PackIconKind.FileReport);

            List<SubItem> menuExpenses = new List<SubItem>();
            menuExpenses.Add(new SubItem("Fixed"));
            menuExpenses.Add(new SubItem("Variable"));
            ItemMenu item3 = new ItemMenu("Expenses", menuExpenses, PackIconKind.ShoppingBasket);

            List<SubItem> menuFinancial = new List<SubItem>();
            menuFinancial.Add(new SubItem("Cash flow"));
            menuFinancial.Add(new SubItem("Cash Cow"));
            ItemMenu item4 = new ItemMenu("Financial", menuFinancial, PackIconKind.ScaleBalance);

            Menu.Children.Add(new UserControlMenuItem(item0, this));
            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this));
            Menu.Children.Add(new UserControlMenuItem(item3, this));
            Menu.Children.Add(new UserControlMenuItem(item4, this));

        }

        public void ChangeScreen(object sender)
        {
            UserControl screen = (UserControl)sender;

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }

    }
}
