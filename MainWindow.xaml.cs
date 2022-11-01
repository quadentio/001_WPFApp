using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _001_WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is {this.descriptionTB.Text}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            this.weldCheckbox.IsChecked = this.assemblyCheckbox.IsChecked = this.plasmaCheckbox.IsChecked = this.laserCheckbox.IsChecked = this.purchaseCheckbox.IsChecked = this.latheCheckbox.IsChecked = this.drillCheckbox.IsChecked = this.foldCheckbox.IsChecked = this.rollCheckbox.IsChecked = this.sawCheckbox.IsChecked = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.lengthTextBox.Text += ((CheckBox)(sender)).Content.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.noteTextBox == null) return;

            var finishCmb = (ComboBox)sender;
            var cmbSelItem = ((ComboBoxItem)finishCmb.SelectedValue);
            string value = cmbSelItem.Content.ToString();

            this.noteTextBox.Text = value;
        }

        /// <summary>
        /// This event will fire after all control is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishComboBox_SelectionChanged(this.finishCmb, null);
        }
    }
}
