using Ay.Framework.WPF;
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

namespace OA.UI.Views
{
    /// <summary>
    /// EmployeeInfoPage.xaml 的交互逻辑
    /// </summary>
    public partial class EmployeeInfoPage : Page
    {

        /// <summary>
        /// 你可以把这个模型放到viewmodel中
        /// </summary>
        private AyPagingDto<EmployeeInfo> Result;

        public EmployeeInfoPage()
        {
            Result = new AyPagingDto<EmployeeInfo>();
            InitializeComponent();
            this.DataContext = Result;
        }



        private void ck_AllSelect_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (Result.Data != null)
            {
                foreach (var data in Result.Data)
                {
                    data.Selected = cb.IsChecked.Value;
                }
            }
        }



        private void dataPager_PageChanged(object sender, PageChangedEventArgs args)
        {
            SearchEmployee(args.PageSize, args.PageIndex);
        }



        #region 只为创建模拟数据
        string[] degrees = { "大专", "本科", "硕士", "初中", "高中", "博士", "研究生" };
        /// <summary>
        /// 得到随机日期
        /// </summary>
        /// <param name="time1">起始日期</param>
        /// <param name="time2">结束日期</param>
        /// <returns>间隔日期之间的 随机日期</returns>
        public static DateTime GetRandomTime(DateTime time1, DateTime time2)
        {
            Random random = new Random();
            DateTime minTime = new DateTime();
            DateTime maxTime = new DateTime();

            System.TimeSpan ts = new System.TimeSpan(time1.Ticks - time2.Ticks);

            // 获取两个时间相隔的秒数
            double dTotalSecontds = ts.TotalSeconds;
            int iTotalSecontds = 0;

            if (dTotalSecontds > System.Int32.MaxValue)
            {
                iTotalSecontds = System.Int32.MaxValue;
            }
            else if (dTotalSecontds < System.Int32.MinValue)
            {
                iTotalSecontds = System.Int32.MinValue;
            }
            else
            {
                iTotalSecontds = (int)dTotalSecontds;
            }


            if (iTotalSecontds > 0)
            {
                minTime = time2;
                maxTime = time1;
            }
            else if (iTotalSecontds < 0)
            {
                minTime = time1;
                maxTime = time2;
            }
            else
            {
                return time1;
            }

            int maxValue = iTotalSecontds;

            if (iTotalSecontds <= System.Int32.MinValue)
                maxValue = System.Int32.MinValue + 1;

            int i = random.Next(System.Math.Abs(maxValue));

            return minTime.AddSeconds(i);
        }
        #endregion

        public void SearchEmployee(int size, int pageIndex, params string[] otherCondition)
        {
            //查询数据库，这里模拟数据
            List<EmployeeInfo> list = new List<EmployeeInfo>();
            DateTime t1 = new DateTime(2009, 1, 1);
            DateTime t2 = new DateTime(2015, 8, 20);
            DateTime t3 = new DateTime(2015, 8, 20);
            Random r = new Random();
            for (int i = 10001; i < 10323; i++)
            {
                list.Add(new EmployeeInfo { EmployeeNo = i.ToString(), Name = "AY君" + i, Sex = "男", WorkDate = GetRandomTime(t1, t2), Degree = degrees[r.Next(0, 7)], WorkMonth = r.Next(0, 37) });
            }

            Result.Total = list.Count;//设置总数量
            //这里只放需要显示的数据
            Result.Data = new ObservableCollection<EmployeeInfo>(list.Skip((pageIndex - 1) * size).Take(size).ToList());
        }

        private void editInfo_Click(object sender, RoutedEventArgs e)
        {
            AyImageButton img = sender as AyImageButton;
            if (img != null)
            {
                EmployeeInfo emp = img.Tag as EmployeeInfo;
                //MessageBox.Show("编辑员工ID：" + empNo);
                EditEmployeeWindowMainView view = new EditEmployeeWindowMainView();
                view.MainTitle = "员工信息-" + emp.Name;
                view.Nation = "342457198912143675";
                view.EmpName = emp.Name;
                view.EmpNo = emp.EmployeeNo;
                EditEmployeeWindow w = new EditEmployeeWindow(view);
                w.ShowDialog();
            }
        }

        private void viewInfo_Click(object sender, RoutedEventArgs e)
        {
            AyImageButton img = sender as AyImageButton;
            if (img != null)
            {
                EmployeeInfo emp = img.Tag as EmployeeInfo;
                MessageBox.Show("查看员工ID：" + emp.EmployeeNo);
                //EditEmployeeWindowMainView view = new EditEmployeeWindowMainView();
                //view.Nation = "342457198912143675";
                //view.EmpName = emp.Name;
                //view.EmpNo = emp.EmployeeNo;
                //EditEmployeeWindow w = new EditEmployeeWindow(view);
                //w.ShowDialog();
            }

        }
    }




}

