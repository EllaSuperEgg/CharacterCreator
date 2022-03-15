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

namespace CharacterCreator_Luo
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

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            Brown.Visibility = Visibility.Collapsed;
            Grey.Visibility = Visibility.Collapsed;
            Pink.Visibility = Visibility.Collapsed;
            MiniEye.Visibility = Visibility.Collapsed;
            BigEyes.Visibility = Visibility.Collapsed;
            sunGlasses.Visibility = Visibility.Collapsed;
            Tree.Visibility = Visibility.Collapsed;
            Bamboo.Visibility = Visibility.Collapsed;
            Wine.Visibility = Visibility.Collapsed;
          
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            string color = "brown";
            string eye = "miniEyes";
            string food = "tree";
        }

        private void buttonBrownClick(object sender, RoutedEventArgs e)
        {
            Brown.Visibility = Visibility.Visible;
            Grey.Visibility = Visibility.Collapsed;
            Pink.Visibility = Visibility.Collapsed;
            MiniEye.Visibility = Visibility.Collapsed;
            BigEyes.Visibility = Visibility.Collapsed;
            sunGlasses.Visibility = Visibility.Collapsed;
            Tree.Visibility = Visibility.Collapsed;
            Bamboo.Visibility = Visibility.Collapsed;
            Wine.Visibility = Visibility.Collapsed;

        }
        private void ColorGrey_Click(object sender, RoutedEventArgs e)
        {
            Brown.Visibility = Visibility.Collapsed;
            Grey.Visibility = Visibility.Visible;
            Pink.Visibility = Visibility.Collapsed;
            MiniEye.Visibility = Visibility.Collapsed;
            BigEyes.Visibility = Visibility.Collapsed;
            sunGlasses.Visibility = Visibility.Collapsed;
            Tree.Visibility = Visibility.Collapsed;
            Bamboo.Visibility = Visibility.Collapsed;
            Wine.Visibility = Visibility.Collapsed;


        }

        private void Color_Pink_Click(object sender, RoutedEventArgs e)
        {
            Brown.Visibility = Visibility.Collapsed;
            Grey.Visibility = Visibility.Collapsed;
            Pink.Visibility = Visibility.Visible;
            MiniEye.Visibility = Visibility.Collapsed;
            BigEyes.Visibility = Visibility.Collapsed;
            sunGlasses.Visibility = Visibility.Collapsed;
            Tree.Visibility = Visibility.Collapsed;
            Bamboo.Visibility = Visibility.Collapsed;
            Wine.Visibility = Visibility.Collapsed;
        }


        private void MiniEyeClick(object sender, RoutedEventArgs e)
        {
            Brown.Visibility = Visibility.Visible;
            Grey.Visibility = Visibility.Collapsed;
            Pink.Visibility = Visibility.Collapsed;
            MiniEye.Visibility = Visibility.Visible;
            BigEyes.Visibility = Visibility.Collapsed;
            sunGlasses.Visibility = Visibility.Collapsed;
            Tree.Visibility = Visibility.Collapsed;
            Bamboo.Visibility = Visibility.Collapsed;
            Wine.Visibility = Visibility.Collapsed;

        }

        private void Bamboo_Click(object sender, RoutedEventArgs e)
        {
            Brown.Visibility = Visibility.Visible;
            Grey.Visibility = Visibility.Collapsed;
            Pink.Visibility = Visibility.Collapsed;
            MiniEye.Visibility = Visibility.Collapsed;
            BigEyes.Visibility = Visibility.Collapsed;
            sunGlasses.Visibility = Visibility.Collapsed;
            Tree.Visibility = Visibility.Collapsed;
            Bamboo.Visibility = Visibility.Visible;
            Wine.Visibility = Visibility.Collapsed;

        }
        private void BigEyes_Click(object sender, RoutedEventArgs e)
        {
            Brown.Visibility = Visibility.Collapsed;
            Grey.Visibility = Visibility.Collapsed;
            Pink.Visibility = Visibility.Collapsed;
            MiniEye.Visibility = Visibility.Collapsed;
            BigEyes.Visibility = Visibility.Visible;
            sunGlasses.Visibility = Visibility.Collapsed;
            Tree.Visibility = Visibility.Collapsed;
            Bamboo.Visibility = Visibility.Collapsed;
            Wine.Visibility = Visibility.Collapsed;

        }

        private void SunGlasses_Click(object sender, RoutedEventArgs e)
        {
            
                Brown.Visibility = Visibility.Collapsed;
                Grey.Visibility = Visibility.Collapsed;
                Pink.Visibility = Visibility.Collapsed;
                MiniEye.Visibility = Visibility.Collapsed;
                BigEyes.Visibility = Visibility.Collapsed;
                sunGlasses.Visibility = Visibility.Visible;
                Tree.Visibility = Visibility.Collapsed;
                Bamboo.Visibility = Visibility.Collapsed;
                Wine.Visibility = Visibility.Collapsed;

            }

        

        private void WineIcon_Click(object sender, RoutedEventArgs e)
        {
            
           
                Brown.Visibility = Visibility.Collapsed;
                Grey.Visibility = Visibility.Collapsed;
                Pink.Visibility = Visibility.Collapsed;
                MiniEye.Visibility = Visibility.Collapsed;
                BigEyes.Visibility = Visibility.Collapsed;
                sunGlasses.Visibility = Visibility.Collapsed;
                Tree.Visibility = Visibility.Collapsed;
                Bamboo.Visibility = Visibility.Collapsed;
                Wine.Visibility = Visibility.Visible;

            }

        }
    }
