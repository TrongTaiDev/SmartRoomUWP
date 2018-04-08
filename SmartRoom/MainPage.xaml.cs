using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SmartRoom
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BtnBaseSetting_Click(new object(), new RoutedEventArgs());
        }

       public List<Grid> GetAllSettingGrids()
        {
            List<Grid> temp = new List<Grid>();
            temp.Add(BaseSetting);
            temp.Add(GroupwareInformation);
            temp.Add(MeetingSetting);
            temp.Add(IndividualSetting);
            temp.Add(SuportSetting);
            return temp;
        }
        private void BtnBaseSetting_Click(object sender, RoutedEventArgs e)
        {
            foreach(Grid pt in GetAllSettingGrids())
            {
                if(GetAllSettingGrids().IndexOf(pt) == 0)
                {
                    pt.Visibility = Visibility.Visible;
                }
                else
                {
                    pt.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void btnGroupwareInformation_Click(object sender, RoutedEventArgs e)
        {
            foreach (Grid pt in GetAllSettingGrids())
            {
                if (GetAllSettingGrids().IndexOf(pt) == 1)
                {
                    pt.Visibility = Visibility.Visible;
                }
                else
                {
                    pt.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void btnMeetingInformation_Click(object sender, RoutedEventArgs e)
        {
            foreach (Grid pt in GetAllSettingGrids())
            {
                if (GetAllSettingGrids().IndexOf(pt) == 2)
                {
                    pt.Visibility = Visibility.Visible;
                }
                else
                {
                    pt.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void btnIndividualSetting_Click(object sender, RoutedEventArgs e)
        {
            foreach (Grid pt in GetAllSettingGrids())
            {
                if (GetAllSettingGrids().IndexOf(pt) == 3)
                {
                    pt.Visibility = Visibility.Visible;
                }
                else
                {
                    pt.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void btnSupportSetting_Click(object sender, RoutedEventArgs e)
        {
            foreach (Grid pt in GetAllSettingGrids())
            {
                if (GetAllSettingGrids().IndexOf(pt) == 4)
                {
                    pt.Visibility = Visibility.Visible;
                }
                else
                {
                    pt.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
