
using _01UserControls.Views;
using System.Windows;


namespace _01UserControls;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
 
    }

    private void MenuItemRote_Click(object sender, RoutedEventArgs e)
    {
       
        MainContent.Content = new RedBoxControl();
    }
    private void MenuItemBlaue_Click(object sender, RoutedEventArgs e)
    {
       
        MainContent.Content = new BlueBoxControl();
    }

    private void MenuItemBlack_Click(object sender, RoutedEventArgs e)
    {
     
        MainContent.Content = new BlackBoxControl1();
    }

   
}