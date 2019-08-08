using Ay.Framework.WPF;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Ay.Framework.WPF.Controls
{

    public class AyWindow : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        #region 拓展,右上角按钮显示

        /// <summary>
        /// 最小化按钮是否显示
        /// </summary>
        public Visibility CloseButtonVisibility
        {
            get { return (Visibility)GetValue(CloseButtonVisibilityProperty); }
            set { SetValue(CloseButtonVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseButtonVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseButtonVisibilityProperty =
            DependencyProperty.Register("CloseButtonVisibility", typeof(Visibility), typeof(AyWindow), new PropertyMetadata(Visibility.Visible));



        public Visibility SkinButtonVisibility
        {
            get { return (Visibility)GetValue(SkinButtonVisibilityProperty); }
            set { SetValue(SkinButtonVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SkinButtonVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SkinButtonVisibilityProperty =
            DependencyProperty.Register("SkinButtonVisibility", typeof(Visibility), typeof(AyWindow), new PropertyMetadata(Visibility.Visible));




        public Visibility MinButtonVisibility
        {
            get { return (Visibility)GetValue(MinButtonVisibilityProperty); }
            set { SetValue(MinButtonVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinButtonVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinButtonVisibilityProperty =
            DependencyProperty.Register("MinButtonVisibility", typeof(Visibility), typeof(AyWindow), new PropertyMetadata(Visibility.Visible));



        public Visibility MaxButtonVisibility
        {
            get { return (Visibility)GetValue(MaxButtonVisibilityProperty); }
            set { SetValue(MaxButtonVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxButtonVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxButtonVisibilityProperty =
            DependencyProperty.Register("MaxButtonVisibility", typeof(Visibility), typeof(AyWindow), new PropertyMetadata(Visibility.Visible));

        private bool canDrag = true;

        public bool CanDrag
        {
            get { return canDrag; }
            set { canDrag = value; }
        }


        #endregion

        private const int WM_SYSCOMMAND = 0x112;
        public const int WM_LBUTTONUP = 0x0202;
        private HwndSource hs;
        IntPtr retInt = IntPtr.Zero;


        private static double shad = 14.00;//控制默认阴影大小
        private double relativeClip = 20.00;

        /// <summary>
        /// 控制外层拖拽范围
        /// </summary>
        public double RelativeClip
        {
            get
            {
                return ShadowMargin.Left + 6;
            }
            set { relativeClip = value; }
        }


        public AyWindow()
        {
            this.AllowsTransparency = true;
            this.WindowStyle = WindowStyle.None; 
            GetWindowBackgroundConfig();
            this.Loaded += delegate
            {
                InitializeEvent();
            };
            this.SourceInitialized += new EventHandler(AyWindow_SourceInitialized);
           
        }
     

        public void GetWindowBackgroundConfig()
        {
           
        }


        #region 依赖属性
        /// <summary>
        /// window窗体的标题栏目的背景画刷
        /// </summary>
        public Brush WindowTitleBarBg
        {
            get { return (Brush)GetValue(WindowTitleBarBgProperty); }
            set { SetValue(WindowTitleBarBgProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WindowTitleBarBg.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WindowTitleBarBgProperty =
            DependencyProperty.Register("WindowTitleBarBg", typeof(Brush), typeof(AyWindow), new PropertyMetadata(null));





        /// <summary>
        /// 工具栏内容
        /// </summary>
        public object ToolBarContent
        {
            get { return (object)GetValue(ToolBarContentProperty); }
            set { SetValue(ToolBarContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ToolBarContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToolBarContentProperty =
            DependencyProperty.Register("ToolBarContent", typeof(object), typeof(AyWindow), new PropertyMetadata(null));


        /// <summary>
        /// 工具栏圆角
        /// </summary>
        public CornerRadius ToolBarCornerRadius
        {
            get { return (CornerRadius)GetValue(ToolBarCornerRadiusProperty); }
            set { SetValue(ToolBarCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ToolBarCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToolBarCornerRadiusProperty =
            DependencyProperty.Register("ToolBarCornerRadius", typeof(CornerRadius), typeof(AyWindow), new PropertyMetadata(new CornerRadius(1)));


        /// <summary>
        /// 工具栏边框
        /// </summary>
        public Thickness ToolBarBorderThickness
        {
            get { return (Thickness)GetValue(ToolBarBorderThicknessProperty); }
            set { SetValue(ToolBarBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ToolBarBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToolBarBorderThicknessProperty =
            DependencyProperty.Register("ToolBarBorderThickness", typeof(Thickness), typeof(AyWindow), new PropertyMetadata(new Thickness(0)));



        /// <summary>
        /// 工具栏背景色
        /// </summary>
        public Brush ToolBarBrush
        {
            get { return (Brush)GetValue(ToolBarBrushProperty); }
            set { SetValue(ToolBarBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ToolBarBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToolBarBrushProperty =
            DependencyProperty.Register("ToolBarBrush", typeof(Brush), typeof(AyWindow), new PropertyMetadata(new SolidColorBrush(Colors.Transparent)));





        public Brush ToolBarBackground
        {
            get { return (Brush)GetValue(ToolBarBackgroundProperty); }
            set { SetValue(ToolBarBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ToolBarBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToolBarBackgroundProperty =
            DependencyProperty.Register("ToolBarBackground", typeof(Brush), typeof(AyWindow), new PropertyMetadata(new SolidColorBrush(Colors.Transparent)));




        public Thickness CloseButtonMargin
        {
            get { return (Thickness)GetValue(CloseButtonMarginProperty); }
            set { SetValue(CloseButtonMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseButtonMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseButtonMarginProperty =
            DependencyProperty.Register("CloseButtonMargin", typeof(Thickness), typeof(AyWindow), new PropertyMetadata(new Thickness(0)));

        #endregion

        public double TitleBarHeight
        {
            get { return (double)GetValue(TitleBarHeightProperty); }
            set { SetValue(TitleBarHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleBarHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleBarHeightProperty =
            DependencyProperty.Register("TitleBarHeight", typeof(double), typeof(AyWindow), new PropertyMetadata(24.00));

        private void AyWindow_SourceInitialized(object sender, EventArgs e)
        {
            hs = PresentationSource.FromVisual((Visual)sender) as HwndSource;
            hs.AddHook(new HwndSourceHook(WndProc));
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                case 0x0024:/* WM_GETMINMAXINFO */
                    WmGetMinMaxInfo(hwnd, lParam);
                    handled = true;
                    break;
                case 0x0086:
                    if (wParam == (IntPtr)0)
                    {
                        return (IntPtr)1;
                    }
                    break;
                case 0x0085:
                    return (System.IntPtr)0;

                case 0x0084:
                    #region 注释部分
                    //int x = lParam.ToInt32() & 0xffff;
                    //int y = lParam.ToInt32() >> 16;
                    //double w = this.ActualWidth;
                    //double h = this.ActualHeight;

                    //if (x <= relativeClip & y <= relativeClip) // left top
                    //{
                    //    return (IntPtr)Win32.HTTOPLEFT;
                    //}

                    //else if (x >= w - relativeClip & y <= relativeClip) //right top
                    //{
                    //    return (IntPtr)Win32.HTTOPRIGHT;
                    //}

                    //else if (x >= w - relativeClip & y >= h - relativeClip) //bottom right
                    //{
                    //    return (IntPtr)Win32.HTBOTTOMRIGHT;
                    //}

                    //else if (x <= relativeClip & y >= h - relativeClip)  // bottom left
                    //{
                    //    return (IntPtr)Win32.HTBOTTOMLEFT;
                    //}

                    //else if ((x >= relativeClip & x <= w - relativeClip) & y <= relativeClip) //top
                    //{
                    //    return (IntPtr)Win32.HTTOP;
                    //}

                    //else if (x >= w - relativeClip & (y >= relativeClip & y <= h - relativeClip)) //right
                    //{
                    //    return (IntPtr)Win32.HTRIGHT;
                    //}

                    //else if ((x >= relativeClip & x <= w - relativeClip) & y > h - relativeClip) //bottom
                    //{
                    //    return (IntPtr)Win32.HTBOTTOM;
                    //}

                    //else if (x <= relativeClip & (y <= h - relativeClip & y >= relativeClip)) //left
                    //{
                    //    return (IntPtr)Win32.HTLEFT;
                    //}
                    //else
                    //{
                    //    return (IntPtr)Win32.HTCAPTION;
                    //}
                    #endregion
                    break;
                case 0x0083:
                    return (System.IntPtr)0;

                default: break;
            }
            return (System.IntPtr)0;
        }


        public Thickness ShadowMargin
        {
            get { return (Thickness)GetValue(ShadowMarginProperty); }
            set { SetValue(ShadowMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShadowMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShadowMarginProperty =
            DependencyProperty.Register("ShadowMargin", typeof(Thickness), typeof(AyWindow), new PropertyMetadata(new Thickness(shad)));


        private double shadowRadius;

        public double ShadowRadius
        {
            get
            {
                return ShadowMargin.Left;
            }
            set
            {
                shadowRadius = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ShadowRadius"));
            }
        }

        private Thickness shadowBorderThickness;

        public Thickness ShadowBorderThickness
        {
            get
            {
                return new Thickness(ShadowMargin.Left / 2);
            }
            set
            {
                shadowBorderThickness = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ShadowBorderThickness"));
            }
        }



        private Thickness dragBorderMargin;

        public Thickness DragBorderMargin
        {
            get { return new Thickness(ShadowMargin.Left - 5); }
            set
            {
                dragBorderMargin = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DragBorderMargin"));
            }
        }




        private Thickness oldShadowMargin = new Thickness(shad);

        #region 这一部分用于最大化时不遮蔽任务栏
        private void WmGetMinMaxInfo(System.IntPtr hwnd, System.IntPtr lParam)
        {

            MINMAXINFO mmi = (MINMAXINFO)Marshal.PtrToStructure(lParam, typeof(MINMAXINFO));

            // Adjust the maximized size and position to fit the work area of the correct monitor
            int MONITOR_DEFAULTTONEAREST = 0x00000002;
            System.IntPtr monitor = MonitorFromWindow(hwnd, MONITOR_DEFAULTTONEAREST);

            if (monitor != System.IntPtr.Zero)
            {
                MONITORINFO monitorInfo = new MONITORINFO();
                GetMonitorInfo(monitor, monitorInfo);
                RECT rcWorkArea = monitorInfo.rcWork;
                RECT rcMonitorArea = monitorInfo.rcMonitor;

                mmi.ptMaxPosition.x = Math.Abs(rcWorkArea.left - rcMonitorArea.left);
                mmi.ptMaxPosition.y = Math.Abs(rcWorkArea.top - rcMonitorArea.top);
                mmi.ptMaxSize.x = Math.Abs(rcWorkArea.right - rcWorkArea.left);
                mmi.ptMaxSize.y = Math.Abs(rcWorkArea.bottom - rcWorkArea.top);


            }

            Marshal.StructureToPtr(mmi, lParam, true);
        }


        [DllImport("user32")]
        internal static extern bool GetMonitorInfo(IntPtr hMonitor, MONITORINFO lpmi);

        [DllImport("User32")]
        internal static extern IntPtr MonitorFromWindow(IntPtr handle, int flags);
        #endregion

        #region 这一部分用于得到元素相对于窗体的位置
        public Size GetElementPixelSize(UIElement element)
        {
            Matrix transformToDevice;
            var source = PresentationSource.FromVisual(element);
            if (source != null)
                transformToDevice = source.CompositionTarget.TransformToDevice;
            else
                using (var source1 = new HwndSource(new HwndSourceParameters()))
                    transformToDevice = source1.CompositionTarget.TransformToDevice;

            if (element.DesiredSize == new Size())
                element.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));

            return (Size)transformToDevice.Transform((Vector)element.DesiredSize);
        }
        #endregion

        #region 这一部分是四个边加上四个角
        public enum ResizeDirection
        {
            Left = 1,
            Right = 2,
            Top = 3,
            TopLeft = 4,
            TopRight = 5,
            Bottom = 6,
            BottomLeft = 7,
            BottomRight = 8,
        }
        #endregion

        #region 用于改变窗体大小
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private void ResizeWindow(ResizeDirection direction)
        {
            SendMessage(hs.Handle, WM_SYSCOMMAND, (IntPtr)(61440 + direction), IntPtr.Zero);
            //控制鼠标是否可以调整大小
            if (this.MinWidth != double.NaN && this.MinWidth > this.Width)
            {
                this.Width = this.MinWidth;
            }
            if (this.MinHeight != double.NaN && this.MinHeight > this.Height)
            {
                this.Height = this.MinHeight;
            }
        }
        #endregion


        /// <summary>
        /// 控制还原图标的可见性，用户无心关心
        /// </summary>
        public Visibility maxWindowVisibility
        {
            get { return (Visibility)GetValue(maxWindowVisibilityProperty); }
            set { SetValue(maxWindowVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for maxWindowVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty maxWindowVisibilityProperty =
            DependencyProperty.Register("maxWindowVisibility", typeof(Visibility), typeof(Window), new PropertyMetadata(Visibility.Visible));


        /// <summary>
        /// 控制还原图标的可见性，用户无心关心
        /// </summary>
        public Visibility restoreWindowVisibility
        {
            get { return (Visibility)GetValue(restoreWindowVisibilityProperty); }
            set { SetValue(restoreWindowVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for restoreWindowVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty restoreWindowVisibilityProperty =
            DependencyProperty.Register("restoreWindowVisibility", typeof(Visibility), typeof(Window), new PropertyMetadata(Visibility.Collapsed));




        public ContextMenu WindowMenu
        {
            get { return (ContextMenu)GetValue(WindowMenuProperty); }
            set { SetValue(WindowMenuProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WindowMenu.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WindowMenuProperty =
            DependencyProperty.Register("WindowMenu", typeof(ContextMenu), typeof(AyWindow), new PropertyMetadata(null));



        public Visibility WindowMenuVisibility
        {
            get { return (Visibility)GetValue(WindowMenuVisibilityProperty); }
            set { SetValue(WindowMenuVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WindowMenuVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WindowMenuVisibilityProperty =
            DependencyProperty.Register("WindowMenuVisibility", typeof(Visibility), typeof(AyWindow), new PropertyMetadata(Visibility.Collapsed));





  

        #region 为元素注册事件
        private void InitializeEvent()
        {

            base.Style = Application.Current.Resources["AyWindowStyle"] as Style;
            base.UpdateLayout();
            ControlTemplate baseWindowTemplate = this.Template;
      


            //Button skinBtn = (Button)baseWindowTemplate.FindName("SkinBtn", this);
            //if (skinBtn != null)
            //{
            //    skinBtn.Click += delegate
            //    {
            //        if (curPop != null && !curPop.isClickClose)
            //        {
            //            curPop.BeginCloseAnimation();
            //        }
            //        else
            //        {
            //            ShowSkinPop();
            //        }

            //    };
            //}
            Button closeBtn = (Button)baseWindowTemplate.FindName("CloseBtn", this);
            if (closeBtn != null)
            {
                closeBtn.Click += delegate
                {
                    CloseWindowOperate();
                };
            }


            Button minBtn = (Button)baseWindowTemplate.FindName("MinBtn", this);
            if (minBtn != null)
            {
                minBtn.Click += delegate
                {
                    MinWindowOperation();
                };
            }

            Button maxBtn = (Button)baseWindowTemplate.FindName("maxWindow", this);
            if (maxBtn != null)
            {
                maxBtn.Click += delegate
                {
                    DoMaxOrReStoreWindow();
                };
            }

            Button menuWindow = (Button)baseWindowTemplate.FindName("menuWindow", this);
            if (menuWindow != null)
            {
                if (WindowMenu != null)
                {
                    WindowMenuVisibility = Visibility.Visible;
                    WindowMenu.Placement = PlacementMode.Bottom;
                    WindowMenu.PlacementTarget = menuWindow;
                }

                menuWindow.Click += delegate
                {
                    ShowWindowMenu();
                };
            }

            Button restoreBtn = (Button)baseWindowTemplate.FindName("restoreWindow", this);
            if (restoreBtn != null)
            {
                restoreBtn.Click += delegate
                {
                    DoMaxOrReStoreWindow();
                };
            }
            if (this.WindowState == WindowState.Normal)
            {
                restoreWindowVisibility = Visibility.Collapsed;
                maxWindowVisibility = Visibility.Visible;
            }
            else
            {
                restoreWindowVisibility = Visibility.Visible;
                maxWindowVisibility = Visibility.Collapsed;
            }


            Border borderClip = (Border)baseWindowTemplate.FindName("AyWindowDragBorder", this);

            if (borderClip != null)
            {
                if (this.ResizeMode == ResizeMode.NoResize)
                {

                }
                else
                {
                    borderClip.MouseMove += delegate
                    {
                        DisplayResizeCursor(null, null);
                    };
                    this.PreviewMouseMove += delegate
                    {
                        ResetCursor(null, null);
                    };
                    borderClip.PreviewMouseDown += delegate
                    {
                        Resize(null, null);
                    };

                }

                if (canDrag)
                {
                        Border borderMove = (Border)baseWindowTemplate.FindName("AyWindowMovePanel", this);
                        borderMove.MouseLeftButtonDown += borderClip_MouseLeftButtonDown;
                }
            }


            if (WindowState == WindowState.Maximized)
            {
                ShadowMargin = new Thickness(0);
              
            }

        }

        public void CloseWindowOperate()
        {
            try
            {
                if (Application.Current.MainWindow == this)
                {
                    Application.Current.Shutdown();
                }
                else
                {
                    this.Close();
                }
            }
            catch
            {

            }
        }

        public void MinWindowOperation()
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ShowWindowMenu()
        {
            if (WindowMenu != null)
            {
                WindowMenu.IsOpen = true;
            }
        }

        void borderClip_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.ClickCount == 3 && MaxButtonVisibility == Visibility.Visible)
            //{
            //    DoMaxOrReStoreWindow();
            //}
            if (e.ClickCount == 1)
            {
                DragMove();
            }

        }


      
        public void DoMaxOrReStoreWindow()
        {
            if (this.WindowState == WindowState.Normal)
            {
                ShadowMargin = new Thickness(0);
                ShadowRadius = 0;
                restoreWindowVisibility = Visibility.Visible;
                maxWindowVisibility = Visibility.Collapsed;

            }
            else
            {
                ShadowMargin = oldShadowMargin;
                ShadowRadius = ShadowMargin.Left;
                restoreWindowVisibility = Visibility.Collapsed;
                maxWindowVisibility = Visibility.Visible;

            }

            this.WindowState = (this.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal);
        }

   
        #endregion

        #region 重写的DragMove，以便解决利用系统自带的DragMove出现Exception的情况
        public new void DragMove()
        {
            if (this.WindowState == WindowState.Normal)
            {
                SendMessage(hs.Handle, WM_SYSCOMMAND, (IntPtr)0xf012, IntPtr.Zero);
                SendMessage(hs.Handle, WM_LBUTTONUP, IntPtr.Zero, IntPtr.Zero);
            }
        }
        #endregion

        #region 显示拖拉鼠标形状
        private void DisplayResizeCursor(object sender, MouseEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                Point pos = Mouse.GetPosition(this);
                double x = pos.X;
                double y = pos.Y;
                //double w = this.ActualWidth;  //注意这个地方使用ActualWidth,才能够实时显示宽度变化
                //double h = this.ActualHeight;
                double w = this.ActualWidth;
                double h = this.ActualHeight;

                if (x <= RelativeClip & y <= RelativeClip) // left top
                {
                    this.Cursor = Cursors.SizeNWSE;
                }
                if (x >= w - RelativeClip & y <= RelativeClip) //right top
                {
                    this.Cursor = Cursors.SizeNESW;
                }

                if (x >= w - RelativeClip & y >= h - RelativeClip) //bottom right
                {
                    this.Cursor = Cursors.SizeNWSE;
                }

                if (x <= RelativeClip & y >= h - RelativeClip)  // bottom left
                {
                    this.Cursor = Cursors.SizeNESW;
                }

                if ((x >= RelativeClip & x <= w - RelativeClip) & y <= RelativeClip) //top
                {
                    this.Cursor = Cursors.SizeNS;
                }

                if (x >= w - RelativeClip & (y >= RelativeClip & y <= h - RelativeClip)) //right
                {
                    this.Cursor = Cursors.SizeWE;
                }

                if ((x >= RelativeClip & x <= w - RelativeClip) & y > h - RelativeClip) //bottom
                {
                    this.Cursor = Cursors.SizeNS;
                }

                if (x <= RelativeClip & (y <= h - RelativeClip & y >= RelativeClip)) //left
                {
                    this.Cursor = Cursors.SizeWE;
                }
            }
        }
        #endregion

        #region  还原鼠标形状
        private void ResetCursor(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton != MouseButtonState.Pressed)
            {
                this.Cursor = Cursors.Arrow;
            }
        }
        #endregion

        #region 判断区域，改变窗体大小
        private void Resize(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                Point pos = Mouse.GetPosition(this);
                double x = pos.X;
                double y = pos.Y;
                double w = this.ActualWidth;
                double h = this.ActualHeight;
                //是否可以改变 2015-6-9 13:53:10 增加



                if (x <= RelativeClip & y <= RelativeClip) // left top
                {
                    this.Cursor = Cursors.SizeNWSE;
                    ResizeWindow(ResizeDirection.TopLeft);
                }
                if (x >= w - RelativeClip & y <= RelativeClip) //right top
                {
                    this.Cursor = Cursors.SizeNESW;
                    ResizeWindow(ResizeDirection.TopRight);
                }

                if (x >= w - RelativeClip & y >= h - RelativeClip) //bottom right
                {
                    this.Cursor = Cursors.SizeNWSE;
                    ResizeWindow(ResizeDirection.BottomRight);
                }

                if (x <= RelativeClip & y >= h - RelativeClip)  // bottom left
                {
                    this.Cursor = Cursors.SizeNESW;
                    ResizeWindow(ResizeDirection.BottomLeft);
                }

                if ((x >= RelativeClip & x <= w - RelativeClip) & y <= RelativeClip) //top
                {
                    this.Cursor = Cursors.SizeNS;
                    ResizeWindow(ResizeDirection.Top);
                }

                if (x >= w - RelativeClip & (y >= RelativeClip & y <= h - RelativeClip)) //right
                {
                    this.Cursor = Cursors.SizeWE;
                    ResizeWindow(ResizeDirection.Right);
                }

                if ((x >= RelativeClip & x <= w - RelativeClip) & y > h - RelativeClip) //bottom
                {
                    this.Cursor = Cursors.SizeNS;
                    ResizeWindow(ResizeDirection.Bottom);
                }

                if (x <= RelativeClip & (y <= h - RelativeClip & y >= RelativeClip)) //left
                {
                    this.Cursor = Cursors.SizeWE;
                    ResizeWindow(ResizeDirection.Left);
                }
            }
        }
        #endregion




        #region 2015-6-11 10:05:00 拓展4块遮罩Rectangle 透明度
        private double rectangleOpacity1 = 1;
        /// <summary>
        /// 左侧菜单
        /// </summary>
        public double RectangleOpacity1
        {
            get { return rectangleOpacity1; }
            set
            {
                rectangleOpacity1 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("RectangleOpacity1"));
            }
        }
        /// <summary>
        /// 内容区
        /// </summary>
        private double rectangleOpacity2 = 1;

        public double RectangleOpacity2
        {
            get { return rectangleOpacity2; }
            set
            {
                rectangleOpacity2 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("RectangleOpacity2"));
            }
        }

        /// <summary>
        /// 主界面
        /// </summary>
        private double rectangleOpacity3 = 1;

        public double RectangleOpacity3
        {
            get { return rectangleOpacity3; }
            set
            {
                rectangleOpacity3 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("RectangleOpacity3"));
            }
        }
        private double rectangleOpacity4 = 1;
        /// <summary>
        /// 待定
        /// </summary>
        public double RectangleOpacity4
        {
            get { return rectangleOpacity4; }
            set
            {
                rectangleOpacity4 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("RectangleOpacity4"));
            }
        }

        #endregion




        public Visibility TitleVisibility
        {
            get { return (Visibility)GetValue(TitleVisibilityProperty); }
            set { SetValue(TitleVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleVisibilityProperty =
            DependencyProperty.Register("TitleVisibility", typeof(Visibility), typeof(AyWindow), new PropertyMetadata(Visibility.Visible));



    
    }
    /// <summary>
    /// 2015-6-8 11:17:29 增加
    /// 更改AyWindow,支持 内容超越右侧任务栏
    /// </summary>
    public class Number2ThicknessConverter : IValueConverter
    {
        public double AddValue { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string t = parameter as string;
            if (t == null)
            {
                t = "上";
            }
            double v = CommonHelper.GetDouble(value);
            switch (t)
            {
                case "上":
                    return new Thickness(0, v, 0, 0);
                case "下":
                    return new Thickness(0, 0, 0, v);
                case "左":
                    return new Thickness(v, 0, 0, 0);
                case "右":
                    return new Thickness(0, 0, v, 0);
                default:
                    return new Thickness(0, v, 0, 0);
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string t = parameter as string;
            if (t == null)
            {
                t = "上";
            }
            Thickness v = (Thickness)value;
            switch (t)
            {
                case "上":
                    return v.Top;
                case "下":
                    return v.Bottom;
                case "左":
                    return v.Left;
                case "右":
                    return v.Right;
                default:
                    return v.Top;
            }
        }
    }
    /// <summary>
    /// POINT aka POINTAPI
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        /// <summary>
        /// x coordinate of point.
        /// </summary>
        public int x;
        /// <summary>
        /// y coordinate of point.
        /// </summary>
        public int y;

        /// <summary>
        /// Construct a point of coordinates (x,y).
        /// </summary>
        public POINT(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    /// <summary>
    /// 窗体大小信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MINMAXINFO
    {
        public POINT ptReserved;
        public POINT ptMaxSize;
        public POINT ptMaxPosition;
        public POINT ptMinTrackSize;
        public POINT ptMaxTrackSize;
    };
    /// <summary> Win32 </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public struct RECT
    {
        /// <summary> Win32 </summary>
        public int left;
        /// <summary> Win32 </summary>
        public int top;
        /// <summary> Win32 </summary>
        public int right;
        /// <summary> Win32 </summary>
        public int bottom;

        /// <summary> Win32 </summary>
        public static readonly RECT Empty = new RECT();

        /// <summary> Win32 </summary>
        public int Width
        {
            get { return Math.Abs(right - left); }  // Abs needed for BIDI OS
        }
        /// <summary> Win32 </summary>
        public int Height
        {
            get { return bottom - top; }
        }

        /// <summary> Win32 </summary>
        public RECT(int left, int top, int right, int bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }


        /// <summary> Win32 </summary>
        public RECT(RECT rcSrc)
        {
            this.left = rcSrc.left;
            this.top = rcSrc.top;
            this.right = rcSrc.right;
            this.bottom = rcSrc.bottom;
        }

        /// <summary> Win32 </summary>
        public bool IsEmpty
        {
            get
            {
                // BUGBUG : On Bidi OS (hebrew arabic) left > right
                return left >= right || top >= bottom;
            }
        }
        /// <summary> Return a user friendly representation of this struct </summary>
        public override string ToString()
        {
            if (this == RECT.Empty) { return "RECT {Empty}"; }
            return "RECT { left : " + left + " / top : " + top + " / right : " + right + " / bottom : " + bottom + " }";
        }

        /// <summary> Determine if 2 RECT are equal (deep compare) </summary>
        public override bool Equals(object obj)
        {
            if (!(obj is Rect)) { return false; }
            return (this == (RECT)obj);
        }

        /// <summary>Return the HashCode for this struct (not garanteed to be unique)</summary>
        public override int GetHashCode()
        {
            return left.GetHashCode() + top.GetHashCode() + right.GetHashCode() + bottom.GetHashCode();
        }


        /// <summary> Determine if 2 RECT are equal (deep compare)</summary>
        public static bool operator ==(RECT rect1, RECT rect2)
        {
            return (rect1.left == rect2.left && rect1.top == rect2.top && rect1.right == rect2.right && rect1.bottom == rect2.bottom);
        }

        /// <summary> Determine if 2 RECT are different(deep compare)</summary>
        public static bool operator !=(RECT rect1, RECT rect2)
        {
            return !(rect1 == rect2);
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class MONITORINFO
    {
        /// <summary>
        /// </summary>            
        public int cbSize = Marshal.SizeOf(typeof(MONITORINFO));

        /// <summary>
        /// </summary>            
        public RECT rcMonitor = new RECT();

        /// <summary>
        /// </summary>            
        public RECT rcWork = new RECT();

        /// <summary>
        /// </summary>            
        public int dwFlags = 0;
    }
}

