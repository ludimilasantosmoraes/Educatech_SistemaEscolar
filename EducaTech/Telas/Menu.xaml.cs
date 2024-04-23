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

namespace EducaTech
{
    /// <summary>
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Telas.Escolas escolas = new Telas.Escolas();
            this.Close();
            escolas.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           Telas.Alunos alunos = new Telas.Alunos();
            this.Close();
            alunos.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Telas.Cursos cursos = new Telas.Cursos();
            this.Close();
            cursos.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Telas.Turmas turmas = new Telas.Turmas();
            this.Close();
            turmas.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.ShowDialog();
        }
    }
}
