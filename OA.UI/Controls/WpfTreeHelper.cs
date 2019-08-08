using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xml;


namespace Ay.Framework.WPF
{


    /// <summary>
    /// 用户画刷辅助类
    /// </summary>
    public class SolidColorBrushConverter
    {

        public static System.Windows.Media.Brush From16JinZhi(string color)
        {
            BrushConverter converter = new BrushConverter();
            return (System.Windows.Media.Brush)converter.ConvertFromString(color);
        }


        public static System.Windows.Media.Color ToColor(string colorName)
        {
            if (colorName.StartsWith("#"))
                colorName = colorName.Replace("#", string.Empty);
            int v = int.Parse(colorName, System.Globalization.NumberStyles.HexNumber);
            return new System.Windows.Media.Color()
            {
                A = Convert.ToByte((v >> 24) & 255),
                R = Convert.ToByte((v >> 16) & 255),
                G = Convert.ToByte((v >> 8) & 255),
                B = Convert.ToByte((v >> 0) & 255)
            };
        }
    }

    public class WpfTreeHelper
    {
        public static T FindParentControl<T>(DependencyObject outerDepObj) where T : DependencyObject
        {
            DependencyObject dObj = VisualTreeHelper.GetParent(outerDepObj);
            if (dObj == null)
                return null;

            if (dObj is T)
                return dObj as T;

            while ((dObj = VisualTreeHelper.GetParent(dObj)) != null)
            {
                if (dObj is T)
                    return dObj as T;
            }

            return null;
        }

        /// <summary>
        /// 查找某种类型的子控件，并返回一个List集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="typename"></param>
        /// <returns></returns>
        public static List<T> GetChildObjects<T>(DependencyObject obj, Type typename) where T : FrameworkElement
        {
            DependencyObject child = null;
            List<T> childList = new List<T>();

            for (int i = 0; i <= VisualTreeHelper.GetChildrenCount(obj) - 1; i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);

                if (child is T && (((T)child).GetType() == typename))
                {
                    childList.Add((T)child);
                }
                childList.AddRange(GetChildObjects<T>(child, typename));
            }

            return childList;
        }
        /// <summary>
        /// 通过名称查找子控件，并返回一个List集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<T> GetChildObjects<T>(DependencyObject obj, string name) where T : FrameworkElement
        {
            DependencyObject child = null;
            List<T> childList = new List<T>();

            for (int i = 0; i <= VisualTreeHelper.GetChildrenCount(obj) - 1; i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);

                if (child is T && (((T)child).GetType().ToString() == name | string.IsNullOrEmpty(name)))
                {
                    childList.Add((T)child);
                }
                childList.AddRange(GetChildObjects<T>(child, name));
            }
            return childList;
        }

        /// <summary>
        /// 通过名称查找某子控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static T GetChildObject<T>(DependencyObject obj, string name) where T : FrameworkElement
        {
            DependencyObject child = null;
            T grandChild = null;

            for (int i = 0; i <= VisualTreeHelper.GetChildrenCount(obj) - 1; i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);

                if (child is T && (((T)child).Name == name | string.IsNullOrEmpty(name)))
                {
                    return (T)child;
                }
                else
                {
                    grandChild = GetChildObject<T>(child, name);
                    if (grandChild != null)
                        return grandChild;
                }
            }
            return null;
        }
        /// <summary>
        /// 通过名称查找父控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static T GetParentObject<T>(DependencyObject obj, string name) where T : FrameworkElement
        {
            DependencyObject parent = VisualTreeHelper.GetParent(obj);

            while (parent != null)
            {
                if (parent is T && (((T)parent).Name == name | string.IsNullOrEmpty(name)))
                {
                    return (T)parent;
                }

                parent = VisualTreeHelper.GetParent(parent);
            }

            return null;
        }

        /// <summary>
        /// 复制一个节点
        /// </summary>
        /// <param name="elementToClone"></param>
        /// <returns></returns>
        public static object CloneElement(object elementToClone)
        {
            string xaml = XamlWriter.Save(elementToClone);
            return XamlReader.Load(new XmlTextReader(new StringReader(xaml)));
        }

        /// <summary>
        /// 查找可视子元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="visual"></param>
        /// <returns></returns>
        public static T FindVisualChild<T>(Visual visual) where T : Visual
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(visual); i++)
            {
                Visual child = (Visual)VisualTreeHelper.GetChild(visual, i);
                if (child != null)
                {
                    T correctlyTyped = child as T;
                    if (correctlyTyped != null)
                    {
                        return correctlyTyped;
                    }
                    T descendent = FindVisualChild<T>(child);
                    if (descendent != null)
                    {
                        return descendent;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 从数据模板中获得数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="childName"></param>
        /// <returns></returns>
        public T FindFirstVisualChildFromDataTemplate<T>(DependencyObject obj, string childName) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T && child.GetValue(FrameworkElement.NameProperty).ToString() == childName)
                {
                    return (T)child;
                }
                else
                {
                    T childOfChild = FindFirstVisualChildFromDataTemplate<T>(child, childName);
                    if (childOfChild != null)
                    {
                        return childOfChild;
                    }
                }
            }
            return null;
        }

        ///遍历Listbox绑定模板中的控件
        //var lbCurrent = Template.FindName("lb_ConfigViewPropertys", this) as ListBox;

              //      if (lbCurrent != null)
              //      {
              //          foreach (object o in lbCurrent.Items)
              //          {
              //              ListBoxItem lbi = lbCurrent.ItemContainerGenerator.ContainerFromItem(o) as ListBoxItem;
              //              if (lbi != null)
              //              {
              //                  Button btnSendValue = FindFirstVisualChild2<Button>(lbi, "btnSendValue");
              //                  if (btnSendValue != null)
              //                  {
              //                      btnSendValue.Click += btnSendValue_Click;
              //                  }

              //              }
              //          }
              //      }

    }
}
