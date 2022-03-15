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
        string color;
        string eyes;
        string food;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            Brown.Visibility = Visibility.Collapsed;
            Grey.Visibility = Visibility.Collapsed;
            Pink.Visibility = Visibility.Collapsed;
            MiniEyes.Visibility = Visibility.Collapsed;
            BigEyes.Visibility = Visibility.Collapsed;
            SunGlasses.Visibility = Visibility.Collapsed;
            Tree.Visibility = Visibility.Collapsed;
            Bamboo.Visibility = Visibility.Collapsed;
            Wine.Visibility = Visibility.Collapsed;
            color = "brown";
            eyes = "miniEyes";
            food = "tree";

        }

        private void UpdateColor(string color)
        {

            switch (color)
            {
                case "brown":
                    Brown.Visibility = Visibility.Visible;
                    Grey.Visibility = Visibility.Collapsed;
                    Pink.Visibility = Visibility.Collapsed;
                    break;
                case "grey":
                    Brown.Visibility = Visibility.Collapsed;
                    Grey.Visibility = Visibility.Visible;
                    Pink.Visibility = Visibility.Collapsed;
                    break;
                case "pink":
                    Pink.Visibility = Visibility.Visible;
                    Brown.Visibility = Visibility.Collapsed;
                    Grey.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void UpdateEyes(string eyes)
        {
            switch (eyes)
            {
                case "miniEyes":
                    MiniEyes.Visibility = Visibility.Visible;
                    BigEyes.Visibility = Visibility.Collapsed;
                    SunGlasses.Visibility = Visibility.Collapsed;
                    break;
                case "bigEyes":
                    MiniEyes.Visibility = Visibility.Collapsed;
                    BigEyes.Visibility = Visibility.Visible;
                    SunGlasses.Visibility = Visibility.Collapsed;
                    break;
                case "sunglasses":
                    MiniEyes.Visibility = Visibility.Collapsed;
                    BigEyes.Visibility = Visibility.Collapsed;
                    SunGlasses.Visibility = Visibility.Visible;
                    break;
            }
        }
        private void UpdateFood(string food)
        {

            switch (food)
            {
                case "tree":
                    Tree.Visibility = Visibility.Visible;
                    Bamboo.Visibility = Visibility.Collapsed;
                    Wine.Visibility = Visibility.Collapsed;
                    break;
                case "bamboo":
                    Tree.Visibility = Visibility.Collapsed;
                    Bamboo.Visibility = Visibility.Visible;
                    Wine.Visibility = Visibility.Collapsed;
                    break;
                case "wine":
                    Tree.Visibility = Visibility.Collapsed;
                    Bamboo.Visibility = Visibility.Collapsed;
                    Wine.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void buttonBrownClick(object sender, RoutedEventArgs e)
        {
            color = "brown";
            UpdateColor(color);

        }
        private void ColorGrey_Click(object sender, RoutedEventArgs e)
        {
            //Brown.Visibility = Visibility.Collapsed;
            //Grey.Visibility = Visibility.Visible;
            //Pink.Visibility = Visibility.Collapsed;
            //MiniEye.Visibility = Visibility.Collapsed;
            //BigEyes.Visibility = Visibility.Collapsed;
            //sunGlasses.Visibility = Visibility.Collapsed;
            //Tree.Visibility = Visibility.Collapsed;
            //Bamboo.Visibility = Visibility.Collapsed;
            //Wine.Visibility = Visibility.Collapsed;
            color = "grey";
            UpdateColor(color);

        }

        private void Color_Pink_Click(object sender, RoutedEventArgs e)
        {
            //Brown.Visibility = Visibility.Collapsed;
            //Grey.Visibility = Visibility.Collapsed;
            //Pink.Visibility = Visibility.Visible;
            //MiniEye.Visibility = Visibility.Collapsed;
            //BigEyes.Visibility = Visibility.Collapsed;
            //sunGlasses.Visibility = Visibility.Collapsed;
            //Tree.Visibility = Visibility.Collapsed;
            //Bamboo.Visibility = Visibility.Collapsed;
            //Wine.Visibility = Visibility.Collapsed;
            color = "pink";
            UpdateColor(color);
        }


        private void MiniEyeClick(object sender, RoutedEventArgs e)
        {
            //Brown.Visibility = Visibility.Visible;
            //Grey.Visibility = Visibility.Collapsed;
            //Pink.Visibility = Visibility.Collapsed;
            //MiniEye.Visibility = Visibility.Visible;
            //BigEyes.Visibility = Visibility.Collapsed;
            //sunGlasses.Visibility = Visibility.Collapsed;
            //Tree.Visibility = Visibility.Collapsed;
            //Bamboo.Visibility = Visibility.Collapsed;
            //Wine.Visibility = Visibility.Collapsed;
            eyes = "miniEyes";
            UpdateEyes(eyes);
        }



        private void SunGlasses_Click(object sender, RoutedEventArgs e)
        {

            //Brown.Visibility = Visibility.Collapsed;
            //Grey.Visibility = Visibility.Collapsed;
            //Pink.Visibility = Visibility.Collapsed;
            //MiniEye.Visibility = Visibility.Collapsed;
            //BigEyes.Visibility = Visibility.Collapsed;
            //sunGlasses.Visibility = Visibility.Visible;
            //Tree.Visibility = Visibility.Collapsed;
            //Bamboo.Visibility = Visibility.Collapsed;
            //Wine.Visibility = Visibility.Collapsed;
            eyes = "sunglasses";
            UpdateEyes(eyes);

        }
        private void TreeIcon_Click(object sender, RoutedEventArgs e)
        {
            //Brown.Visibility = Visibility.Collapsed;
            //Grey.Visibility = Visibility.Collapsed;
            //Pink.Visibility = Visibility.Collapsed;
            //MiniEye.Visibility = Visibility.Collapsed;
            //BigEyes.Visibility = Visibility.Collapsed;
            //sunGlasses.Visibility = Visibility.Collapsed;
            //Tree.Visibility = Visibility.Visible;
            //Bamboo.Visibility = Visibility.Visible;
            //Wine.Visibility = Visibility.Collapsed;
            food = "tree";
            UpdateFood(food);
        }

        private void Bamboo_Click(object sender, RoutedEventArgs e)
        {
            //Brown.Visibility = Visibility.Visible;
            //Grey.Visibility = Visibility.Collapsed;
            //Pink.Visibility = Visibility.Collapsed;
            //MiniEye.Visibility = Visibility.Collapsed;
            //BigEyes.Visibility = Visibility.Collapsed;
            //sunGlasses.Visibility = Visibility.Collapsed;
            //Tree.Visibility = Visibility.Collapsed;
            //Bamboo.Visibility = Visibility.Visible;
            //Wine.Visibility = Visibility.Collapsed;
            food = "bamboo";
            UpdateFood(food);
        }

        private void WineIcon_Click(object sender, RoutedEventArgs e)
        {


            //Brown.Visibility = Visibility.Collapsed;
            //Grey.Visibility = Visibility.Collapsed;
            //Pink.Visibility = Visibility.Collapsed;
            //MiniEye.Visibility = Visibility.Collapsed;
            //BigEyes.Visibility = Visibility.Collapsed;
            //sunGlasses.Visibility = Visibility.Collapsed;
            //Tree.Visibility = Visibility.Collapsed;
            //Bamboo.Visibility = Visibility.Collapsed;
            //Wine.Visibility = Visibility.Visible;
            food = "wine";
            UpdateFood(food);
        }

        private void BigEyesIcon_Click(object sender, RoutedEventArgs e)
        {
            eyes = "bigEyes";
            UpdateEyes(eyes);
        }
    }
}
