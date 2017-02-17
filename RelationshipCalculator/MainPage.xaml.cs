using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace RelationshipCalculator
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string welcome = "欢迎使用亲戚称呼计算器...";
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Pane_Click01(object sender, RoutedEventArgs e)
        {
            MySplit.IsPaneOpen = !MySplit.IsPaneOpen;
        }

        private void Pane_click2(object sender, RoutedEventArgs e)
        {
            MySplit.IsPaneOpen = !MySplit.IsPaneOpen;
        }

        private void Clear_click(object sender, RoutedEventArgs e)
        {
            Input_text.Text = "";
            Result_text.Text = "";
        }
        string Inputs = "";

        private void father(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "f,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if(Input_text.Text!="")
            {
                Input_text.Text += "的爸爸";
            }
            else
            {
                Input_text.Text += "爸爸";
            }

        }
        private void o_bro(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "ob,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if (Input_text.Text != "")
            {
                Input_text.Text += "的哥哥";
            }
            else
            {
                Input_text.Text += "哥哥";
            }

        }
        private void l_bro(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "lb,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if (Input_text.Text != "")
            {
                Input_text.Text += "的弟弟";
            }
            else
            {
                Input_text.Text += "弟弟";
            }

        }
        private void mother(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "m,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if (Input_text.Text != "")
            {
                Input_text.Text += "的妈妈";
            }
            else
            {
                Input_text.Text += "妈妈";
            }

        }
        private void o_sis(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "os,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if (Input_text.Text != "")
            {
                Input_text.Text += "的姐姐";
            }
            else
            {
                Input_text.Text += "姐姐";
            }

        }
        private void l_sis(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "ls,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if (Input_text.Text != "")
            {
                Input_text.Text += "的妹妹";
            }
            else
            {
                Input_text.Text += "妹妹";
            }

        }
        private void husband(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "h,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if (Input_text.Text != "")
            {
                Input_text.Text += "的丈夫";
            }
            else
            {
                Input_text.Text += "丈夫";
            }

        }
        private void wife(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "w,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if (Input_text.Text != "")
            {
                Input_text.Text += "的妻子";
            }
            else
            {
                Input_text.Text += "妻子";
            }

        }
        private void son(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "s,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if (Input_text.Text != "")
            {
                Input_text.Text += "的儿子";
            }
            else
            {
                Input_text.Text += "儿子";
            }

        }
        private void daughter(object sender, RoutedEventArgs e)
        {
            if (Inputs == "") Input_text.Text = "";
            Inputs += "d,";
            if (Input_text.Text == welcome) Input_text.Text = "";
            if (Input_text.Text != "")
            {
                Input_text.Text += "的女儿";
            }
            else
            {
                Input_text.Text += "女儿";
            }

        }

        private void Calculate_click(object sender, RoutedEventArgs e)
        {
            SpecialProcess sp = new SpecialProcess();
            string inputStr = Inputs.Substring(0, Inputs.Length - 1);
            Result_text.Text=sp.SearchId(inputStr);
            Inputs = "";
        }
    }
}
