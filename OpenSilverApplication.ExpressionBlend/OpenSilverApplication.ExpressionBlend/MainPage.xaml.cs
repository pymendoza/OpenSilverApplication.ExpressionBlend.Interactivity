using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverApplication.ExpressionBlend
{
    public partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
            Label = "No background";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string label = string.Empty;
        public string Label
        { 
            get
            {
                return label;
            }
            set
            {
                label = value;
                RaisePropertyChangedEvent("Label");
            }
        }

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (label == "Green background")
            {
                this.Label = "Orange background";
            }
            else
            {
                this.Label = "Green background";
            }
        }
    }
}
