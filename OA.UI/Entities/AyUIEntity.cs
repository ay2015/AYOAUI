using Ay.Framework.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class AyUIEntity : AyPropertyChanged
{
    private bool selected = false;
    /// <summary>
    /// 是否选中
    /// </summary>
    public bool Selected
    {
        get { return selected; }
        set
        {
            selected = value;
            //this.OnPropertyChanged(() => this.Selected);
            OnPropertyChanged("Selected");
        }
    }
}

