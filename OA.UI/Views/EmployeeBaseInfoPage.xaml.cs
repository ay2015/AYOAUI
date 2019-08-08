using System;
using System.Collections.Generic;
using System.Linq;
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

namespace OA.UI.Views
{
    /// <summary>
    /// EmployeeBaseInfoPage.xaml 的交互逻辑
    /// </summary>
    public partial class EmployeeBaseInfoPage : Page
    {
        EmployeeInfo info = new EmployeeInfo();
        public EmployeeBaseInfoPage()
        {
            InitializeComponent();
       
        }

        private string _empNo;

        public string EmpNo
        {
            get { return _empNo; }
            set { _empNo = value; }
        }

        private void export_Click(object sender, RoutedEventArgs e)
        {
            AyExportWindow exp = new AyExportWindow();
            exp.ShowDialog();
        }
    }
}
