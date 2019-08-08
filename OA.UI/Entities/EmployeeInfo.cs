using System;
using System.Collections.Generic;

/// <summary>
/// 实体,可以有数据库生成
/// </summary>
public class EmployeeInfo : AyUIEntity
{

    private int id;

    public int Id
    {
        get { return id; }
        set
        {
            id = value;
            OnPropertyChanged("Id");
        }
    }


    private string employeeNo;

    public string EmployeeNo
    {
        get { return employeeNo; }
        set
        {
            employeeNo = value;
            OnPropertyChanged("EmployeeNo");
        }
    }

    private string sex;

    public string Sex
    {
        get { return sex; }
        set
        {
            sex = value;
            OnPropertyChanged("Sex");
        }
    }

    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            name = value;
            OnPropertyChanged("Name");
        }
    }

    private DateTime? workDate;

    public DateTime? WorkDate
    {
        get { return workDate; }
        set
        {
            workDate = value;
            OnPropertyChanged("WorkDate");
        }
    }



    private string degree;

    public string Degree
    {
        get { return degree; }
        set
        {
            degree = value;
            OnPropertyChanged("Degree");
        }

    }



    private DateTime? firstWorkDate;
    /// <summary>
    /// 第一次参加工作时间
    /// </summary>
    public DateTime? FirstWorkDate
    {
        get { return firstWorkDate; }
        set
        {
            firstWorkDate = value;
            OnPropertyChanged("FirstWorkDate");
        }
    }




    private int workMonth;
    /// <summary>
    /// 工龄
    /// </summary>
    public int WorkMonth
    {
        get { return workMonth; }
        set
        {
            workMonth = value;
            OnPropertyChanged("WorkMonth");
        }
    }



}



