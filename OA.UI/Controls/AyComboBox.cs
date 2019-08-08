using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;


namespace Ay.Framework.WPF.Controls
{
    /// <summary>
    /// 本代码由Aaronyang www.ayjs.net独家拥有，未经允许不许外传
    /// </summary>
    [TemplatePart(Name = "PART_Popup", Type = typeof(Popup))]
    public class AyComboBox : ComboBox
    {
        Popup popup = null;

      
        public override void OnApplyTemplate()
        {
            var obj = Template.FindName("PART_Popup", this);
            popup = obj as Popup;
            if (popup != null)
            {
                popup.Opened += popup_Opened;

            }
            if (AyComboBoxIco == null)
            {
                IcoVisibility = Visibility.Collapsed;
            }
            else {
                IcoVisibility = Visibility.Visible;
            }

            base.OnApplyTemplate();

        }



        /// <summary>
        /// 下拉区域最大高度
        /// </summary>
        public double PanelMaxHeight
        {
            get { return (double)GetValue(PanelMaxHeightProperty); }
            set { SetValue(PanelMaxHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PanelMaxHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PanelMaxHeightProperty =
            DependencyProperty.Register("PanelMaxHeight", typeof(double), typeof(AyComboBox), new PropertyMetadata(300.00));



        /// <summary>
        /// 下拉区域最小高度
        /// </summary>
        public double PanelMinHeight
        {
            get { return (double)GetValue(PanelMinHeightProperty); }
            set { SetValue(PanelMinHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PanelMinHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PanelMinHeightProperty =
            DependencyProperty.Register("PanelMinHeight", typeof(double), typeof(AyComboBox), new PropertyMetadata(0.00));

        
        
        
        void popup_Opened(object sender, EventArgs e)
        {
            var p = sender as Popup;
            if (p != null)
            {
                popup.Placement = PlacementMode.Bottom;
                UIElement container = VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(p)) as UIElement;
                Point relativeLocation = p.Child.TranslatePoint(new Point(0, 0), container);
                if (relativeLocation.X < 0.5 && relativeLocation.X >= 0)
                {
                    if (relativeLocation.Y < 0)
                    {
                        popup.Placement = PlacementMode.Top;
                    }
                    else
                    {
                        popup.Placement = PlacementMode.Bottom;
                    }

                }
                else if (relativeLocation.X < 0)
                {
                    popup.Placement = PlacementMode.Left;
                }
                else if (relativeLocation.X > 0.2)
                {
                    popup.Placement = PlacementMode.Right;
                }

                //Console.WriteLine(relativeLocation.X + " , " + relativeLocation.Y);

            }
        }




        public Visibility IcoVisibility
        {
            get { return (Visibility)GetValue(IcoVisibilityProperty); }
            set { SetValue(IcoVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IcoVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IcoVisibilityProperty =
            DependencyProperty.Register("IcoVisibility", typeof(Visibility), typeof(AyComboBox), new PropertyMetadata(Visibility.Collapsed));

        

        /// <summary>
        /// 是否是透明背景
        /// </summary>
        public bool IsTransparentBackground
        {
            get { return (bool)GetValue(IsTransparentBackgroundProperty); }
            set { SetValue(IsTransparentBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsTransparentBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsTransparentBackgroundProperty =
            DependencyProperty.Register("IsTransparentBackground", typeof(bool), typeof(AyComboBox), new PropertyMetadata(false));


        

        public ImageSource AyComboBoxIco
        {
            get { return (ImageSource)GetValue(AyComboBoxIcoProperty); }
            set { SetValue(AyComboBoxIcoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AyComboBoxIco.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AyComboBoxIcoProperty =
            DependencyProperty.Register("AyComboBoxIco", typeof(ImageSource), typeof(AyComboBox), new PropertyMetadata(null));

        
    }


    public class AyComboboxHeightConverter : IValueConverter
    {
        public double AddValue { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double a = (double)value;
            return a - AddValue;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double a = (double)value;
            return a + AddValue;
        }
    }

}
