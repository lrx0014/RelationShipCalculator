﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RelationshipCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RelationshipCalculator.ViewModel
{
    public class SearchViewModel : ViewModelBase
    {
        private SearchModel searchModel = new SearchModel();
        private string resultDisplay;

        public SearchViewModel()
        {
            this.Keyword       = string.Empty;
        }

        public string Keyword { get { return searchModel.Keyword; } set { searchModel.Keyword = value; } }

        public string ResultDisplay
        {
            get { return searchModel.Result; }
            set
            {
                this.resultDisplay = value;
                RaisePropertyChanged("ResultDisplay");
            }
        }

        private void RunSearch()
        {
            try
            {
                if(Keyword!=string.Empty)
                {
                    searchModel.GetChain();
                    ResultDisplay = searchModel.Result;
                }
                else
                {
                    ResultDisplay = "请输入要查询的称谓";
                }
            }catch(Exception e)
            {
                ResultDisplay = e.Message;
            }
        }

        public ICommand RunSearchCommand
        {
            get
            {
                return new RelayCommand(RunSearch);
            }
        }



    }
}
