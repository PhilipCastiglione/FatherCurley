using FatherCurley.models;
using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FatherCurley
{
    public class MyData
    {
        public string ColorName { get; set; }
        
        public MyData()
        {
            this.ColorName = "Red";
        }
    };
    /// <summary>
    /// Interaction logic for Characters.xaml
    /// </summary>
    public partial class CharactersList : Page
    {
        public CharactersList()
        {
            //var thomas = new Character();
            //thomas.Name = "Thomas";
            //thomas.Role = "Villainous Mentor";

            //var thomasBinding = new Binding();
            //thomasBinding.Source = thomas;

            InitializeComponent();
        }
    }
}
