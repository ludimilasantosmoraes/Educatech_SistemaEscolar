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
using System.Windows.Shapes;

namespace EducaTech.Telas
{
    /// <summary>
    /// Lógica interna para Alunos.xaml
    /// </summary>
    public partial class Alunos : Window
    {
        public Alunos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Telas.MatriculaAluno matriculaAluno = new Telas.MatriculaAluno();
            this.Close();
            matriculaAluno.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.ShowDialog();
        }
    }
}
