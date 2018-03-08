﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RelationshipCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace RelationshipCalculator.ViewModel
{
    public class CalculatorViewModel : ViewModelBase
    {
        private CalculatorModel calculator;

        private string welcome = "欢迎使用亲戚关系计算器...";
        private string inputText;
        private string resultText;
        private string display;
        private bool isWifeBtnEnable;
        private bool isHusbandBtnEnable;
       

        public CalculatorViewModel()
        {
            this.calculator = new CalculatorModel();
            this.inputText = string.Empty;
            this.resultText = string.Empty;
            this.display = welcome;
            this.isHusbandBtnEnable = true;
            this.isWifeBtnEnable = true;
        }

        public string Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
                RaisePropertyChanged("Display");
            }
        }

        public string InputText
        {
            get
            {
                return calculator.InputText;
            }
            set
            {
                calculator.InputText = value;
            }
        }

        public string ResultText
        {
            get
            {
                return calculator.Result;
            }
            set
            {
                calculator.Result = value;
                RaisePropertyChanged("ResultText");
            }
        }

        public bool IsWifeBtnEnable
        {
            get
            {
                return this.isWifeBtnEnable;
            }
            set
            {
                this.isWifeBtnEnable = value;
                RaisePropertyChanged("IsWifeBtnEnable");
            }
        }

        public bool IsHusbandBtnEnable
        {
            get
            {
                return this.isHusbandBtnEnable;
            }
            set
            {
                this.isHusbandBtnEnable = value;
                RaisePropertyChanged("IsHusbandBtnEnable");
            }
        }

        private void cal()
        {
            try
            {
                if (InputText != welcome)
                {
                    calculator.getResult();
                    ResultText = calculator.Result;
                }

            }
            catch (Exception e)
            {
                //Display = error + e.ToString();
                var dialog = new MessageDialog(e.ToString(), e.Message);

                dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
                dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));

                //设置默认按钮，不设置的话默认的确认按钮是第一个按钮
                dialog.DefaultCommandIndex = 0;
                dialog.CancelCommandIndex = 1;
            }
        }

        public ICommand CalculateCommand
        {
            get
            {
                return new RelayCommand(cal);
            }
        }

        private void general(string button)
        {
            if (Display == welcome || Display.Split(',')[0]=="发生错误")
            {
                Display = string.Empty;
            }
            switch(button)
            {
                case "清空":
                    Display    = welcome;
                    ResultText = string.Empty;
                    InputText  = string.Empty;
                    IsWifeBtnEnable = true;
                    IsHusbandBtnEnable = true;
                    break;

                case "父":
                    if(Display == string.Empty)
                    {
                        Display += "爸爸";
                    }
                    else
                    {
                        Display += "的爸爸";
                    }
                    InputText += ",f";
                    IsHusbandBtnEnable = false;
                    IsWifeBtnEnable = true;
                    break;

                case "母":
                    if (Display == string.Empty)
                    {
                        Display += "妈妈";
                    }
                    else
                    {
                        Display += "的妈妈";
                    }
                    InputText += ",m";
                    IsWifeBtnEnable = false;
                    IsHusbandBtnEnable = true;
                    break;

                case "兄":
                    if (Display == string.Empty)
                    {
                        Display += "哥哥";
                    }
                    else
                    {
                        Display += "的哥哥";
                    }
                    InputText += ",ob";
                    IsHusbandBtnEnable = false;
                    IsWifeBtnEnable = true;
                    break;

                case "弟":
                    if (Display == string.Empty)
                    {
                        Display += "弟弟";
                    }
                    else
                    {
                        Display += "的弟弟";
                    }
                    InputText += ",lb";
                    IsWifeBtnEnable = true;
                    IsHusbandBtnEnable = false;
                    break;

                case "姐":
                    if (Display == string.Empty)
                    {
                        Display += "姐姐";
                    }
                    else
                    {
                        Display += "的姐姐";
                    }
                    InputText += ",os";
                    IsHusbandBtnEnable = true;
                    IsWifeBtnEnable = false;
                    break;

                case "妹":
                    if (Display == string.Empty)
                    {
                        Display += "妹妹";
                    }
                    else
                    {
                        Display += "的妹妹";
                    }
                    InputText += ",ls";
                    IsHusbandBtnEnable = true;
                    IsWifeBtnEnable = false;
                    break;

                case "夫":
                    if (Display == string.Empty)
                    {
                        Display += "老公";
                    }
                    else
                    {
                        Display += "的老公";
                    }
                    InputText += ",h";
                    IsWifeBtnEnable = true;
                    IsHusbandBtnEnable = false;
                    break;

                case "妻":
                    if (Display == string.Empty)
                    {
                        Display += "老婆";
                    }
                    else
                    {
                        Display += "的老婆";
                    }
                    InputText += ",w";
                    IsHusbandBtnEnable = true;
                    IsWifeBtnEnable = false;
                    break;

                case "子":
                    if (Display == string.Empty)
                    {
                        Display += "儿子";
                    }
                    else
                    {
                        Display += "的儿子";
                    }
                    InputText += ",s";
                    IsWifeBtnEnable = true;
                    IsHusbandBtnEnable = false;
                    break;

                case "女":
                    if (Display == string.Empty)
                    {
                        Display += "女儿";
                    }
                    else
                    {
                        Display += "的女儿";
                    }
                    InputText += ",d";
                    IsHusbandBtnEnable = true;
                    IsWifeBtnEnable = false;
                    break;
            }
        }

        public ICommand GeneralCommand
        {
            get
            {
                return new RelayCommand<string>(general);
            }
        }



    }
}