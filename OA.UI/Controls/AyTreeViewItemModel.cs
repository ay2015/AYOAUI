using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Ay.Framework.WPF.Controls
{
    /// <summary>
    /// 基本tree 杨洋
    /// 2015-5-20 17:17:58  增加深度Depth 从0开始
    /// </summary>
    public class AyTreeViewItemModel : AyPropertyChanged
    {
        public AyTreeViewItemModel() { }
        private readonly ObservableCollection<AyTreeViewItemModel> children = new ObservableCollection<AyTreeViewItemModel>();

        private string text = String.Empty;

        private AyTreeViewItemModel parent;


        private Guid uid;
        /// <summary>
        /// 默认生成的guid，唯一标识符
        /// </summary>
        public Guid Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        private bool isSpecParentNode=false;
        /// <summary>
        /// 是不是特殊节点，是的话，指定特殊节点图标
        /// </summary>
        public bool IsSpecParentNode
        {
            get { return isSpecParentNode; }
            set
            {
                isSpecParentNode = value;
                OnPropertyChanged("IsSpecParentNode");
            }
        }



        public ObservableCollection<AyTreeViewItemModel> Children
        {
            get { return children; }
        }
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }

        private bool subIsSelected;

        /// <summary>
        /// 子类中是否有选中的
        /// </summary>
        public bool SubIsSelected
        {
            get { return subIsSelected; }
            set
            {
                subIsSelected = value;
                OnPropertyChanged("SubIsSelected");
            }
        }

        private bool parentIsSelf;
        /// <summary>
        /// 父节点是不是自己，如果是自己，则自己是选中的状态，当然选中状态不是selected的触发器触发的，是自己的这个属性触发
        /// </summary>
        public bool ParentIsSelf
        {
            get { return parentIsSelf; }
            set
            {

                parentIsSelf = value;
                OnPropertyChanged("ParentIsSelf");
            }
        }


        public AyTreeViewItemModel ParentCategory
        {
            get { return parent; }
            set
            {
                parent = value;

            }
        }

        public AyTreeViewItemModel(string text)
            : this(text, null, null)
        {
            if (parent != null)
            {
                this.Depth = parent.Depth + 1;
            }
            Uid = Guid.NewGuid();

        }
        public AyTreeViewItemModel(string text, string icon)
            : this(text, icon, null)
        {
            if (parent != null)
            {
                this.Depth = parent.Depth + 1;
            }
            Uid = Guid.NewGuid();
        }
        public AyTreeViewItemModel(string text, AyTreeViewItemModel parent)
            : this(text, null, parent)
        {
            if (parent != null)
            {
                this.Depth = parent.Depth + 1;
                if (parent.children.Count > 0)
                {
                    parent.IsCatagory = true;
                }

                parent.children.Add(this);
            }
            Uid = Guid.NewGuid();
        }
        public AyTreeViewItemModel(string text, string icon, AyTreeViewItemModel parent)
        {
            this.text = text;
            this.parent = parent;
            this.Icon = icon;
            if (parent != null)
            {
                parent.children.Add(this);
                if (parent.children.Count > 0)
                {
                    parent.IsCatagory = true;
                }

                this.Depth = parent.Depth + 1;
            }
            Uid = Guid.NewGuid();
        }
        public AyTreeViewItemModel(string text, string icon, AyTreeViewItemModel parent, bool isExpanded)
        {
            this.text = text;
            this.parent = parent;
            this.Icon = icon;
            this.IsExpanded = isExpanded;
            if (parent != null)
            {
                parent.children.Add(this);
                if (parent.children.Count > 0)
                {
                    parent.IsCatagory = true;
                }

                this.Depth = parent.Depth + 1;
            }
            Uid = Guid.NewGuid();
        }
        public AyTreeViewItemModel(string text, string icon, AyTreeViewItemModel parent, bool isExpanded,bool isSpecParentN)
        {
            this.text = text;
            this.parent = parent;
            this.Icon = icon;
            this.IsExpanded = isExpanded;
            this.IsSpecParentNode = isSpecParentN;
            if (parent != null)
            {
                parent.children.Add(this);
                if (parent.children.Count > 0)
                {
                    parent.IsCatagory = true;
                }

                this.Depth = parent.Depth + 1;
            }
            Uid = Guid.NewGuid();
        }

        public AyTreeViewItemModel(string text, string icon, AyTreeViewItemModel parent, bool isExpanded, object extValue)
        {
            this.text = text;
            this.parent = parent;

            this.Icon = icon;
            this.IsExpanded = isExpanded;
            if (parent != null)
            {
                parent.children.Add(this);
                if (parent.children.Count > 0)
                {
                    parent.IsCatagory = true;
                }

                this.Depth = parent.Depth + 1;
            }
            this.ExtValue = extValue;
            Uid = Guid.NewGuid();
        }
        public AyTreeViewItemModel(string text, string icon, AyTreeViewItemModel parent, bool isExpanded, object extValue, object[] extValues)
        {
            this.text = text;
            this.parent = parent;
            this.Icon = icon;
            this.IsExpanded = isExpanded;
            if (parent != null)
            {
                parent.children.Add(this);
                if (parent.children.Count > 0)
                {
                    parent.IsCatagory = true;
                }

                this.Depth = parent.Depth + 1;
            }
            this.ExtValue = extValue;
            this.ExtValues = extValues;
            Uid = Guid.NewGuid();
        }
        public AyTreeViewItemModel(string text, string icon, AyTreeViewItemModel parent, bool isExpanded, object[] extValues)
        {
            this.text = text;
            this.parent = parent;
            this.Icon = icon;
            this.IsExpanded = isExpanded;
            if (parent != null)
            {
                parent.children.Add(this);
                if (parent.children.Count > 0)
                {
                    parent.IsCatagory = true;
                }

                this.Depth = parent.Depth + 1;
            }
            this.ExtValues = extValues;
            Uid = Guid.NewGuid();
        }


        public override string ToString()
        {
            return "aytree: " + text;
        }


        #region 其他补充

        private string icon = null;
        /// <summary>
        /// 头像, AyIconAll结构
        /// </summary>
        public string Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                OnPropertyChanged("Icon");
            }
        }

        private bool isCatagory;

        public bool IsCatagory
        {
            get { return isCatagory; }
            set
            {
                isCatagory = value;
                OnPropertyChanged("IsCatagory");
            }
        }




        private int depth = 0;

        public int Depth
        {
            get { return depth; }
            set
            {
                depth = value;
                OnPropertyChanged("Depth");
            }
        }


        //    //展开时候,从集合拿数据
        private bool _isExpanded;
        public bool IsExpanded
        {
            get { return _isExpanded; }
            set
            {
                if (value != _isExpanded)
                {
                    _isExpanded = value;
                    OnPropertyChanged("IsExpanded");
                }

                //if (!HasChildren())
                //{
                //    Children.Remove(_temp);
                //    //LoadChildren();
                //}
            }
        }


        private bool isSelected = false;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                if (isSelected && !value && Depth > 0)
                {
                    //如果原来选中，现在取消
                    this.ParentCategory.SubIsSelected = value;
                }
                if (!isSelected && value && Depth > 0)
                {
                    //如果原来未选中，现在选中
                    this.ParentCategory.SubIsSelected = value;
                }


                isSelected = value;

                OnPropertyChanged("IsSelected");
            }
        }




        private TreeViewItem relativeItem;

        /// <summary>
        /// 相关item对象
        /// </summary>
        public TreeViewItem RelativeItem
        {
            get { return relativeItem; }
            set { relativeItem = value; }
        }



        #endregion

        #region 拓展属性 2015-6-12 13:56:12 增加
        private object extValue;
        /// <summary>
        /// 用于放置单个属性值
        /// </summary>
        public object ExtValue
        {
            get { return extValue; }
            set
            {
                extValue = value;
                //if (ParentCategory!=null && ParentCategory.ExtValue == ExtValue)
                //{
                //    this.IsSelected = true;
                //}
                OnPropertyChanged("ExtValue");
            }
        }


        private object[] extValues;
        /// <summary>
        /// 用于放置多个值
        /// </summary>
        public object[] ExtValues
        {
            get { return extValues; }
            set
            {
                extValues = value;
                OnPropertyChanged("ExtValues");
            }
        }

        #endregion
    }




    public class TreeModelBase : AyPropertyChanged
    {

        private ObservableCollection<AyTreeViewItemModel> nodes;

        public ObservableCollection<AyTreeViewItemModel> Nodes
        {
            get { return nodes; }
            set
            {
                nodes = value;
                OnPropertyChanged("Nodes");
            }
        }
        public delegate ObservableCollection<AyTreeViewItemModel> AyTreeViewItemModelSource();
        public AyTreeViewItemModelSource RefreshDataDelegate;


        /// <summary>
        /// 更新数据
        /// </summary>
        public void RefreshData()
        {
            if (RefreshDataDelegate != null)
            {
                Nodes = RefreshDataDelegate();
            }
        }

        public TreeModelBase()
        {
            RefreshData();
        }

        public AyTreeViewItemModel TryFindNodeByName(string text)
        {
            return TryFindNodeByName(null, text);
        }


        public AyTreeViewItemModel TryFindNodeByName(AyTreeViewItemModel parent, string text)
        {
            ObservableCollection<AyTreeViewItemModel> cats;
            cats = parent == null ? nodes : parent.Children;
            foreach (AyTreeViewItemModel category in cats)
            {
                if (category.Text == text)
                {
                    return category;
                }
                else
                {
                    AyTreeViewItemModel cat = TryFindNodeByName(category, text);
                    if (cat != null) return cat;
                }
            }

            return null;
        }
    }






}
