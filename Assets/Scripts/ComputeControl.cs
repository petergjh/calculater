using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ComputeControl : MonoBehaviour
{
    public InputField InFi_DisplayInfo;

    private int _IntFirstNumber;
    private int _IntSecondNumber;
    private int _IntResultNumber;
    private string _StrOperatorFlag;
    private string strUserPartResult;


    // Start is called before the first frame update
    void Start()
    {
        InFi_DisplayInfo.text = "0";
        _IntFirstNumber = 0;
        _IntSecondNumber = 0;
        _IntResultNumber = 0;
        _StrOperatorFlag = null;
        strUserPartResult = null;
    }


    //显示内容到输出控件
    private void DisplayInfo(string strInfo)
    {
        InFi_DisplayInfo.text = strInfo;
    }
    

    //处理用户后台数据
    private void ProcessNumber(string strUserClick)
    {
        //是否连续按键
        strUserPartResult = strUserPartResult + strUserClick;  //用户点击的部分结果

        //判断第一还是第二个操作数
        if (_StrOperatorFlag!=null)
        {
            _IntSecondNumber = int.Parse(strUserPartResult); //字符串转换为整型
        }
        else
        {
            _IntFirstNumber = int.Parse(strUserPartResult);
        }

        //显示部分结果
        //InFi_DisplayInfo.text = strUserPartResult;
        DisplayInfo(strUserPartResult);
    }


    //定义用户点击数字按钮事件
    public void ClickButtonNumber_1()
    {
        ProcessNumber("1"); //数字处理
    }
    
    public void ClickButtonNumber_2()
    {
        ProcessNumber("2"); //数字处理
    }

    public void ClickButtonNumber_3()
    {
        ProcessNumber("3"); //数字处理
    }

    public void ClickButtonNumber_4()
    {
        ProcessNumber("4"); //数字处理
    }
    
    public void ClickButtonNumber_5()
    {
        ProcessNumber("5"); //数字处理
    }

    public void ClickButtonNumber_6()
    {
        ProcessNumber("6"); //数字处理
    }

    public void ClickButtonNumber_7()
    {
        ProcessNumber("7"); //数字处理
    }
    
    public void ClickButtonNumber_8()
    {
        ProcessNumber("8"); //数字处理
    }

    public void ClickButtonNumber_9()
    {
        ProcessNumber("9"); //数字处理
    }

    public void ClickButtonNumber_0()
    {
        ProcessNumber("0"); //数字处理
    }


    //定义用户点击“操作符”按钮事件
    public void ClickButton_Adding()
    {
        _StrOperatorFlag = "+";
        DisplayInfo("+"); //显示内容
        strUserPartResult = null;
    }

    public void ClickButton_Sube()
    {
        _StrOperatorFlag = "-";
        DisplayInfo("-");
        strUserPartResult = null;
    }

    public void ClickButton_Mult()
    {
        _StrOperatorFlag = "*";
        DisplayInfo("*");
        strUserPartResult = null;
    }
    
    public void ClickButton_Divi()
    {
        _StrOperatorFlag = "/";
        DisplayInfo("/");
        strUserPartResult = null;
    }

    public void ClickButton_Equals()
    {
        if (_StrOperatorFlag!=null)
        {
            switch (_StrOperatorFlag)
            {
                case "+":
                    _IntResultNumber = _IntFirstNumber + _IntSecondNumber;
                    break;

                case "-":
                    _IntResultNumber = _IntFirstNumber - _IntSecondNumber;
                    break;

                case "*":
                    _IntResultNumber = _IntFirstNumber * _IntSecondNumber;
                    break;

                case "/":
                    if (_IntSecondNumber != 0)
                    {
                        _IntResultNumber = _IntFirstNumber / _IntSecondNumber;
                    }
                    else
                    {
                        DisplayInfo("被除数不能为0");
                    }
                    break;

                default:
                    break;

            }
        }

        //显示结果
        if (_IntSecondNumber != 0)
        {
            DisplayInfo(_IntResultNumber.ToString());
        }    

        //结果清除
        _IntFirstNumber = 0;
        _IntSecondNumber = 0;
        _IntResultNumber = 0;
        _StrOperatorFlag = null;
        strUserPartResult = null;
    }

}
