
using Ay.Framework.WPF.Helpers;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;


namespace Ay.Framework.WPF.Controls
{

    /// <summary>
    /// 2015-06-29 09:25:40 用于转换treeview的模式
    /// </summary>
    public enum IconMode
    {
        Icon,
        IconText
    }

    public class AyTreeView : TreeView
    {

        public bool TreeViewAnimationIsOpen
        {
            get { return (bool)GetValue(TreeViewAnimationIsOpenProperty); }
            set { SetValue(TreeViewAnimationIsOpenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TreeViewAnimationIsOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TreeViewAnimationIsOpenProperty =
            DependencyProperty.Register("TreeViewAnimationIsOpen", typeof(bool), typeof(AyTreeView), new PropertyMetadata(false, ChangeExpandEvent));




        /// <summary>
        /// 2015-06-08 19:02:42 增加
        /// 用于控制 AyTreeView整体偏移thick,而不影响整行选中
        /// </summary>
        public Thickness FirstAyTreeViewItemPadding
        {
            get { return (Thickness)GetValue(FirstAyTreeViewItemPaddingProperty); }
            set { SetValue(FirstAyTreeViewItemPaddingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FirstAyTreeViewItemPadding.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstAyTreeViewItemPaddingProperty =
            DependencyProperty.Register("FirstAyTreeViewItemPadding", typeof(Thickness), typeof(AyTreeView), new PropertyMetadata(new Thickness(0.00)));




    
        /// <summary>
        /// 用来控制是否显示子的弹出框，仅用于  图标模式,强制第一次打开所以子popup，然后瞬间关上，达到初始化的工作
        /// </summary>
        public bool IsInitSubItem
        {
            get { return (bool)GetValue(IsInitSubItemProperty); }
            set { SetValue(IsInitSubItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsInitSubItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsInitSubItemProperty =
            DependencyProperty.Register("IsInitSubItem", typeof(bool), typeof(AyTreeView), new PropertyMetadata(false));

        
          


        /// <summary>
        /// 2015-6-29 9:27:59 增加
        /// 用于控制Treeview的显示模式
        /// </summary>
        public IconMode AyTreeMode
        {
            get { return (IconMode)GetValue(AyTreeModeProperty); }
            set { SetValue(AyTreeModeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AyTreeMode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AyTreeModeProperty =
            DependencyProperty.Register("AyTreeMode", typeof(IconMode), typeof(AyTreeView), new PropertyMetadata(IconMode.IconText));





        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(AyTreeView), new PropertyMetadata(16.00));



        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(AyTreeView), new PropertyMetadata(16.00));



        public double IconFontSize
        {
            get { return (double)GetValue(IconFontSizeProperty); }
            set { SetValue(IconFontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFontSizeProperty =
            DependencyProperty.Register("IconFontSize", typeof(double), typeof(AyTreeView), new PropertyMetadata(16.00));




        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HoverForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverForegroundProperty =
            DependencyProperty.Register("HoverForeground", typeof(Brush), typeof(AyTreeView), new PropertyMetadata(SolidColorBrushConverter.From16JinZhi("#FFFFFF")));



        public Brush PressedForeground
        {
            get { return (Brush)GetValue(PressedForegroundProperty); }
            set { SetValue(PressedForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PressedForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PressedForegroundProperty =
            DependencyProperty.Register("PressedForeground", typeof(Brush), typeof(AyTreeView), new PropertyMetadata(SolidColorBrushConverter.From16JinZhi("#5CA2F3")));



        public double TreeViewItemHeight
        {
            get { return (double)GetValue(TreeViewItemHeightProperty); }
            set { SetValue(TreeViewItemHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TreeViewItemHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TreeViewItemHeightProperty =
            DependencyProperty.Register("TreeViewItemHeight", typeof(double), typeof(AyTreeView), new PropertyMetadata(26.00));

        bool isFirstChange = false;
        private static void ChangeExpandEvent(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            AyTreeView aa = d as AyTreeView;
            if (aa.AyTreeMode == IconMode.IconText)
            {
                if (aa.isFirstChange)
                {

                    bool newvalue = (bool)e.NewValue;
                    if (newvalue)
                    {
                        //aa.SetValue(VirtualizingStackPanel.IsVirtualizingProperty, false);
                        aa.AddHandler(TreeViewItem.ExpandedEvent, new RoutedEventHandler(aa.AyTreeViewItemExpanded));
                        aa.AddHandler(TreeViewItem.CollapsedEvent, new RoutedEventHandler(aa.AyTreeViewItemCollapsed));
                    }
                    else
                    {
                        //aa.SetValue(VirtualizingStackPanel.IsVirtualizingProperty, true);
                        aa.RemoveHandler(TreeViewItem.ExpandedEvent, new RoutedEventHandler(aa.AyTreeViewItemExpanded));
                        aa.RemoveHandler(TreeViewItem.CollapsedEvent, new RoutedEventHandler(aa.AyTreeViewItemCollapsed));
                    }

                }
                aa.isFirstChange = true;
            }
         

        }

        /// <summary>
        /// 绑定动画
        /// </summary>
        public void BindExpandAnimation() {
            //this.SetValue(VirtualizingStackPanel.IsVirtualizingProperty, false);
            this.AddHandler(TreeViewItem.ExpandedEvent, new RoutedEventHandler(this.AyTreeViewItemExpanded));
            this.AddHandler(TreeViewItem.CollapsedEvent, new RoutedEventHandler(this.AyTreeViewItemCollapsed));
        }
        /// <summary>
        /// 解绑动画
        /// </summary>
        public void UnBindExpandAnimation()
        {
            //this.SetValue(VirtualizingStackPanel.IsVirtualizingProperty, true);
            this.RemoveHandler(TreeViewItem.ExpandedEvent, new RoutedEventHandler(this.AyTreeViewItemExpanded));
            this.RemoveHandler(TreeViewItem.CollapsedEvent, new RoutedEventHandler(this.AyTreeViewItemCollapsed));
        }

        public AyTreeView()
        {
            this.Initialized += AyTreeView_Initialized;
            //this.AddHandler(TreeViewItem., new RoutedEventHandler(this.ItemLoadedEvent));

        }
        //private void ItemLoadedEvent(object sender, RoutedEventArgs e)
        //{

        //    TreeViewItem tvi =sender as TreeViewItem;
        //    if (tvi != null) {
        //        var a = tvi.IsExpanded;
        //    }
        
        //}


        /// <summary>
        /// 2015-6-12 8:49:02增加
        /// 用来当treeview当做菜单导航时候按钮，是否显示三角
        /// </summary>


        public double SelectedRightSJXOpacity
        {
            get { return (double)GetValue(SelectedRightSJXOpacityProperty); }
            set { SetValue(SelectedRightSJXOpacityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedRightSJXOpacity.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedRightSJXOpacityProperty =
            DependencyProperty.Register("SelectedRightSJXOpacity", typeof(double), typeof(AyTreeView), new PropertyMetadata(0.00));



        public Brush SelectedRightSJXBrush
        {
            get { return (Brush)GetValue(SelectedRightSJXBrushProperty); }
            set { SetValue(SelectedRightSJXBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedRightSJXBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedRightSJXBrushProperty =
            DependencyProperty.Register("SelectedRightSJXBrush", typeof(Brush), typeof(AyTreeView), new PropertyMetadata(new SolidColorBrush(Colors.White)));



        void AyTreeView_Initialized(object sender, EventArgs e)
        {
            if (TreeViewAnimationIsOpen && AyTreeMode==IconMode.IconText)
            {
                //this.SetValue(VirtualizingStackPanel.IsVirtualizingProperty, false);
                this.AddHandler(TreeViewItem.ExpandedEvent, new RoutedEventHandler(AyTreeViewItemExpanded));
                this.AddHandler(TreeViewItem.CollapsedEvent, new RoutedEventHandler(AyTreeViewItemCollapsed));
            }
        }


        IEasingFunction easyOut = new CircleEase() { EasingMode = EasingMode.EaseOut };
        IEasingFunction easyIn = new CircleEase() { EasingMode = EasingMode.EaseIn };

        ItemsPresenter itemhost = null;
        int ExpandedTime = 400;
        private void AyTreeViewItemCollapsed(object sender, RoutedEventArgs e)
        {

            TreeViewItem tvi = e.OriginalSource as TreeViewItem;
            //tvi.IsExpanded = false;
            if (tvi != null && tvi.Items.Count > 0)
            {

                itemhost = WpfTreeHelper.GetChildObject<ItemsPresenter>(tvi, "ItemsHost");

                // double targetHeight = 0;
                ////添加动画
                foreach (var item in tvi.Items)
                {
                    AyTreeViewItemModel temp = item as AyTreeViewItemModel;
                    if (temp.RelativeItem != null)
                    {
                        temp.ParentCategory.IsExpanded = false;
                        break;
                    }
                }

                if (itemhost != null)
                {
                    DoubleAnimationUsingKeyFrames HeightKey = new DoubleAnimationUsingKeyFrames();
                    HeightKey.Duration = new Duration(TimeSpan.FromMilliseconds(ExpandedTime));
                    HeightKey.FillBehavior = FillBehavior.Stop;

                    EasingDoubleKeyFrame HeightKey0 = new EasingDoubleKeyFrame(itemhost.ActualHeight, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(0)));
                    EasingDoubleKeyFrame HeightKey1 = new EasingDoubleKeyFrame(0);
                    HeightKey1.EasingFunction = easyOut;
                    HeightKey.KeyFrames.Add(HeightKey0);
                    HeightKey.KeyFrames.Add(HeightKey1);
                    HeightKey.Completed += HeightKey_Completed;
                    itemhost.BeginAnimation(ItemsPresenter.HeightProperty, HeightKey);
                }
            }
            e.Handled = true;
        }

        void HeightKey_Completed(object sender, EventArgs e)
        {
            if (itemhost != null)
            {
                itemhost.Visibility = Visibility.Collapsed;
            }

        }


        private Thickness GetTargetThickness(int depth, double marginleft = 5)
        {
            if (depth == 0)
            {
                return new Thickness(0);
            }
            return new Thickness(marginleft + 12 * depth, 0, 0, 0);
        }

        public int GetTreeViewItemCount(AyTreeViewItemModel temp)
        {
            int a = 1;
            if (temp.IsExpanded && temp.Children != null)
            {
                foreach (var item in temp.Children)
                {
                    a += GetTreeViewItemCount(item);
                }
            }
            return a;
        }


        /// <summary>
        /// 每个时常都是一样的,暂定200
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AyTreeViewItemExpanded(object sender, RoutedEventArgs e)
        {

            TreeViewItem tvi = e.OriginalSource as TreeViewItem;
            if (tvi != null && tvi.Items.Count > 0)
            {
                int executeTime = 0;//执行time误差
                int durationTime = 300;
                double targetHeight = 0;
                int expandNode = 0;
                //添加动画
                foreach (var item in tvi.Items)
                {
                    AyTreeViewItemModel temp = item as AyTreeViewItemModel;
                    temp.ParentCategory.IsExpanded = true;

                    if (temp.RelativeItem == null)
                    {
                        temp.RelativeItem = TreeViewHelper.GetTreeViewItem2(tvi, temp);
                    }
                    expandNode += GetTreeViewItemCount(temp);


                    if (temp.RelativeItem != null)
                    {
                        temp.RelativeItem.Opacity = 0;
                    }
                }

                targetHeight += (TreeViewItemHeight + 2) * expandNode;//计算当前展开的有多少个item

                //set itemhost的高度
                var itemhost = WpfTreeHelper.GetChildObject<ItemsPresenter>(tvi, "ItemsHost");
                if (itemhost != null)
                {
                    itemhost.Visibility = Visibility.Visible;
                    DoubleAnimationUsingKeyFrames HeightKey = new DoubleAnimationUsingKeyFrames();

                    HeightKey.FillBehavior = FillBehavior.Stop;
                    EasingDoubleKeyFrame HeightKey0 = new EasingDoubleKeyFrame(0, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(0)));
                    EasingDoubleKeyFrame HeightKey1 = new EasingDoubleKeyFrame(targetHeight, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(ExpandedTime)), easyOut);
                    HeightKey.KeyFrames.Add(HeightKey0);
                    HeightKey.KeyFrames.Add(HeightKey1);
                    itemhost.BeginAnimation(ItemsPresenter.HeightProperty, null);
                    itemhost.BeginAnimation(ItemsPresenter.HeightProperty, HeightKey);
                }

                int index = 0;
                int endIndex = tvi.Items.Count;
                //添加动画
                foreach (var item in tvi.Items)
                {
                    AyTreeViewItemModel temp = item as AyTreeViewItemModel;
                    if (temp.RelativeItem != null)
                    {
                        index++;
                        DoubleAnimationUsingKeyFrames OpacityKey = new DoubleAnimationUsingKeyFrames();
                        EasingDoubleKeyFrame opacityKey10 = new EasingDoubleKeyFrame(0, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(0)));
                        EasingDoubleKeyFrame opacityKey0 = new EasingDoubleKeyFrame(0, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(executeTime)));
                        EasingDoubleKeyFrame opacityKey1 = new EasingDoubleKeyFrame(1, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(executeTime + durationTime)));
                        opacityKey1.EasingFunction = easyIn;
                        OpacityKey.KeyFrames.Add(opacityKey0);
                        OpacityKey.KeyFrames.Add(opacityKey1);

                        ThicknessAnimationUsingKeyFrames MarginKey = new ThicknessAnimationUsingKeyFrames();

                        var tempThickness = GetTargetThickness(temp.Depth);

                        MarginKey.KeyFrames.Add(new EasingThicknessKeyFrame(new Thickness(0, 0, 0, 0), KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(0))));
                        MarginKey.KeyFrames.Add(new EasingThicknessKeyFrame(new Thickness(0, 0, 0, 0), KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(executeTime))));
                        MarginKey.KeyFrames.Add(new EasingThicknessKeyFrame(tempThickness, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(executeTime + durationTime))));
                        opacityKey1.EasingFunction = easyIn;

                        temp.RelativeItem.BeginAnimation(TreeViewItem.OpacityProperty, null);
                        temp.RelativeItem.BeginAnimation(TreeViewItem.OpacityProperty, OpacityKey);
                        temp.RelativeItem.BeginAnimation(TreeViewItem.PaddingProperty, null);
                        temp.RelativeItem.BeginAnimation(TreeViewItem.PaddingProperty, MarginKey);
                        OpacityKey = null;
                        MarginKey = null;
                        executeTime += 44;
                        if (endIndex == index)
                        {
                            temp.RelativeItem.BringIntoView();
                        }
                    }
                }
                executeTime = 0;

            }
            e.Handled = true;
        }


        private static TreeViewItem FindTreeViewItem(ItemsControl item, object data)
        {
            TreeViewItem findItem = null;
            bool itemIsExpand = false;
            if (item is TreeViewItem)
            {
                TreeViewItem tviCurrent = item as TreeViewItem;
                itemIsExpand = tviCurrent.IsExpanded;
                if (!tviCurrent.IsExpanded)
                {
                    //如果这个TreeViewItem未展开过，则不能通过ItemContainerGenerator来获得TreeViewItem
                    tviCurrent.SetValue(TreeViewItem.IsExpandedProperty, true);
                    //必须使用UpdaeLayour才能获取到TreeViewItem
                    tviCurrent.UpdateLayout();
                }
            }
            for (int i = 0; i < item.Items.Count; i++)
            {
                TreeViewItem tvItem = (TreeViewItem)item.ItemContainerGenerator.ContainerFromIndex(i);
                if (tvItem == null)
                    continue;
                object itemData = item.Items[i];
                if (itemData == data)
                {
                    findItem = tvItem;
                    break;
                }
                else if (tvItem.Items.Count > 0)
                {
                    findItem = FindTreeViewItem(tvItem, data);
                    if (findItem != null)
                        break;
                }

            }
            if (findItem == null)
            {
                TreeViewItem tviCurrent = item as TreeViewItem;
                tviCurrent.SetValue(TreeViewItem.IsExpandedProperty, itemIsExpand);
                tviCurrent.UpdateLayout();
            }
            return findItem;
        }


    }

    public class IndentConverter : IValueConverter
    {
        public double Indent { get; set; }
        public double MarginLeft { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int depth = CommonHelper.GetInt(value);
            if (depth == 0)
            {
                return new Thickness(0);
            }
            return new Thickness(this.MarginLeft + this.Indent * depth, 0, 0, 0);
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }



}
