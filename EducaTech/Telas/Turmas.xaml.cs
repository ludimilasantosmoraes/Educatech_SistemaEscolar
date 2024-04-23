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
    /// Lógica interna para Turmas.xaml
    /// </summary>
    public partial class Turmas : Window
    {
        public Turmas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.ShowDialog();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CadastroTurma cadastroTurma = new CadastroTurma();
            this.Close();
            cadastroTurma.ShowDialog();
        }
    }
}
