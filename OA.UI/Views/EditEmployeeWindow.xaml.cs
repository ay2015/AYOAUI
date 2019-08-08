using Ay.Framework.WPF;
using Ay.Framework.WPF.Controls;
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

using System.Windows.Shapes;

namespace OA.UI.Views
{
    /// <summary>
    /// EditEmployeeWindow.xaml 的交互逻辑
    /// </summary>
    public partial class EditEmployeeWindow : AyWindow
    {
        public EditEmployeeWindowMainView view;
        public EditEmployeeWindow()
        {
            InitializeComponent();
      


        }
        public EditEmployeeWindow(EditEmployeeWindowMainView v)
        {
            this.view = v;
            InitializeComponent();
            //视图模型补充

            //赋值
            this.DataContext = view;
            tabFrameMain.Source = new Uri("/views/EmployeeBaseInfoPage.xaml", UriKind.Relative);

        }

        private void tabFrameMain_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            var content = tabFrameMain.Content as FrameworkElement;
            if (content == null)
                return;
            content.DataContext = tabFrameMain.DataContext;
        }

        private void tabFrameMain_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var content = tabFrameMain.Content as FrameworkElement;
            if (content == null)
                return;
            content.DataContext = tabFrameMain.DataContext;
        }


        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                string a = rb.Tag as string;
                string a1 = "/Views/" + a;
                tabFrameMain.Source = new Uri(a1, UriKind.Relative);
                //switch (a)
                //{
                //    case "EmployeeBaseInfoPage.xaml":
                //        EmployeeBaseInfoPage p = new EmployeeBaseInfoPage();

                //        break;
                //    default:
                //        break;
                //}
            }
        }

        private void AyWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }

    public class EditEmployeeWindowMainView : AyPropertyChanged
    {
        private string _mainTitle;

        public string MainTitle
        {
            get { return _mainTitle; }
            set
            {
                _mainTitle = value;
                OnPropertyChanged("MainTitle");
            }
        }


        #region 其他字段


        private string _empName;

        public string EmpName
        {
            get { return _empName; }
            set
            {
                _empName = value;
                OnPropertyChanged("EmpName");
            }
        }

        private string _nation;

        public string Nation
        {
            get { return _nation; }
            set
            {
                _nation = value;
                OnPropertyChanged("Nation");
            }
        }


        private string _empNo;

        public string EmpNo
        {
            get { return _empNo; }
            set
            {
                _empNo = value;
                OnPropertyChanged("EmpNo");
            }
        }



        #endregion

    }
}
