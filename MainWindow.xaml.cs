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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BrunoMaia_d7_avaliacao.Data;

namespace BrunoMaia_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context context;
        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            bool authorized = false;

            List<User> users = this.context.Users.ToList();

            foreach(User user in users)
            {
                if(user.Username == txtUsername.Text && user.Password == txtPassword.Password)
                {
                    authorized = true;
                }
            }

            if(authorized)
            {
                MessageBox.Show("Usuário autenticado!");
            } else {
                MessageBox.Show("Credenciais inválidas!");
            }
        }
    }
}
