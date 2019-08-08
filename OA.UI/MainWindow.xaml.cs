using Ay.Framework.WPF.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace OA.UI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : AyWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;
        }
        public ObservableCollection<AyTreeViewItemModel> CreateMenuTreeData()
        {
            ObservableCollection<AyTreeViewItemModel> list = new ObservableCollection<AyTreeViewItemModel>();
            AyTreeViewItemModel root = new AyTreeViewItemModel("组织机构", "/OA.UI;component/SystemResources/Images/tree/folder_01.png", null, false, true);
            AyTreeViewItemModel root0_1 = new AyTreeViewItemModel("机构信息", "/OA.UI;component/SystemResources/Images/icon/11_b.png", root, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root0_2 = new AyTreeViewItemModel("部门信息", "/OA.UI;component/SystemResources/Images/icon/12_b.png", root, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root0_3 = new AyTreeViewItemModel("职位信息", "/OA.UI;component/SystemResources/Images/icon/13_b.png", root, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root0_4 = new AyTreeViewItemModel("架构一览", "/OA.UI;component/SystemResources/Images/icon/408004339_b.png", root, false, "/Views/HRPage.xaml");


            AyTreeViewItemModel root_1 = new AyTreeViewItemModel("人事档案", "/OA.UI;component/SystemResources/Images/tree/folder_01.png", null, true, true);

            AyTreeViewItemModel root1_1 = new AyTreeViewItemModel("人员信息", "/OA.UI;component/SystemResources/Images/icon/21606_b.png", root_1, false, "/Views/EmployeeInfoPage.xaml");
            root1_1.IsSelected = true;

            AyTreeViewItemModel root1_2 = new AyTreeViewItemModel("档案管理", "/OA.UI;component/SystemResources/Images/icon/21602_b.png", root_1, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root1_3 = new AyTreeViewItemModel("档案查询", "/OA.UI;component/SystemResources/Images/icon/21605_b.png", root_1, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root1_6 = new AyTreeViewItemModel("档案报表", "/OA.UI;component/SystemResources/Images/icon/21604_b.png", root_1, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root1_4 = new AyTreeViewItemModel("人员调动", "/OA.UI;component/SystemResources/Images/icon/21607_b.png", root_1, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root1_5 = new AyTreeViewItemModel("批量修改", "/OA.UI;component/SystemResources/Images/icon/24406_b.png", root_1, false, "/Views/HRPage.xaml");

            AyTreeViewItemModel root_2 = new AyTreeViewItemModel("人事合同", "/OA.UI;component/SystemResources/Images/tree/folder_01.png", null, false, true);
            AyTreeViewItemModel root2_1 = new AyTreeViewItemModel("合同登记", "/OA.UI;component/SystemResources/Images/icon/22001_b.png", root_2, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root2_2 = new AyTreeViewItemModel("合同管理", "/OA.UI;component/SystemResources/Images/icon/22002_b.png", root_2, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root2_3 = new AyTreeViewItemModel("合同设置", "/OA.UI;component/SystemResources/Images/icon/22002_b.png", root_2, false, "/Views/HRPage.xaml");

            AyTreeViewItemModel root_3 = new AyTreeViewItemModel("培训管理", "/OA.UI;component/SystemResources/Images/tree/folder_01.png", null, false, true);
            AyTreeViewItemModel root3_1 = new AyTreeViewItemModel("培训计划", "/OA.UI;component/SystemResources/Images/icon/22110_s.png", root_3, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root3_2 = new AyTreeViewItemModel("培训项目", "/OA.UI;component/SystemResources/Images/icon/22111_s.png", root_3, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root3_3 = new AyTreeViewItemModel("培训资源", "/OA.UI;component/SystemResources/Images/icon/22112_s.png", root_3, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root3_4 = new AyTreeViewItemModel("采课记录", "/OA.UI;component/SystemResources/Images/icon/22113_s.png", root_3, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root3_5 = new AyTreeViewItemModel("培训统计", "/OA.UI;component/SystemResources/Images/icon/22114_s.png", root_3, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root3_6 = new AyTreeViewItemModel("培训设置", "/OA.UI;component/SystemResources/Images/icon/22115_s.png", root_3, false, "/Views/HRPage.xaml");

            AyTreeViewItemModel root_4 = new AyTreeViewItemModel("人事基础设置", "/OA.UI;component/SystemResources/Images/tree/folder_01.png", null, false, true);
            AyTreeViewItemModel root4_3 = new AyTreeViewItemModel("人事档案设置", "/OA.UI;component/SystemResources/Images/icon/22401_s.png", root_4, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root4_4 = new AyTreeViewItemModel("人事权利设置", "/OA.UI;component/SystemResources/Images/icon/22403_s.png", root_4, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root4_5 = new AyTreeViewItemModel("人力分析设置", "/OA.UI;component/SystemResources/Images/icon/22404_s.png", root_4, false, "/Views/HRPage.xaml");
            AyTreeViewItemModel root4_6 = new AyTreeViewItemModel("人事系统设置", "/OA.UI;component/SystemResources/Images/icon/22405_s.png", root_4, false, "/Views/HRPage.xaml");
            list.Add(root);
            list.Add(root_1);
            list.Add(root_2);
            list.Add(root_3);
            list.Add(root_4);
            return list;
        }
        TreeModelBase model = new TreeModelBase();
        private void AyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            tvLeftMenu.ItemsSource = CreateMenuTreeData();
        }




        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {

            TreeViewItem tvi = e.OriginalSource as TreeViewItem;
            if (tvi != null)
            {
                AyTreeViewItemModel selectedmodel = tvi.DataContext as AyTreeViewItemModel;
                if (selectedmodel.ExtValue == null) return;
                frameMain.Source = new Uri(selectedmodel.ExtValue.ToString(), UriKind.Relative);


            }
        }

    }
}

