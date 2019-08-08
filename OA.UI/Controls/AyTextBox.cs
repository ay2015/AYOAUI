using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Ay.Framework.WPF.Controls
{

    public class AyTextBox : TextBox
    {

        static AyTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AyTextBox), new FrameworkPropertyMetadata(typeof(AyTextBox)));

            TextProperty.OverrideMetadata(
                typeof(AyTextBox),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(TextPropertyChanged)));
        }


        public string Mask
        {
            get { return (string)GetValue(MaskProperty); }
            set { SetValue(MaskProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Mask.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaskProperty =
            DependencyProperty.Register("Mask", typeof(string), typeof(AyTextBox), new PropertyMetadata(string.Empty));

        
        private static readonly DependencyPropertyKey HasTextPropertyKey = DependencyProperty.RegisterReadOnly(
            "HasText",
            typeof(bool),
            typeof(AyTextBox),
            new FrameworkPropertyMetadata(false));

        public static readonly DependencyProperty HasTextProperty = HasTextPropertyKey.DependencyProperty;

        public bool HasText
        {
            get
            {
                return (bool)GetValue(HasTextProperty);
            }
        }





        public Brush MaskForeground
        {
            get { return (Brush)GetValue(MaskForegroundProperty); }
            set { SetValue(MaskForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaskForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaskForegroundProperty =
            DependencyProperty.Register("MaskForeground", typeof(Brush), typeof(AyTextBox), new PropertyMetadata(new SolidColorBrush(Colors.Gray)));



        public object RightContent
        {
            get { return (object)GetValue(RightContentProperty); }
            set { SetValue(RightContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RightContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RightContentProperty =
            DependencyProperty.Register("RightContent", typeof(object), typeof(AyTextBox), new PropertyMetadata(null));

        
        public 
        static void TextPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
  
            AyTextBox itb = (AyTextBox)sender;

            bool actuallyHasText = itb.Text.Length > 0;
            if (actuallyHasText != itb.HasText)
            {
                itb.SetValue(HasTextPropertyKey, actuallyHasText);
        
            }
           
        }
    }
}
