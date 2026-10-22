using System;
using System.Linq;
using System.Windows.Forms;
using RolesUsers.ADO.NET;

namespace RolesUsers
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        //создание статической переменно для хранения данных пользователя
        public static Users Enter_User;

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model1 = new Model1();
            //поиск пользователя по логину и паролю
            Enter_User = model1.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (Enter_User != null)
            {
                switch (Enter_User.RoleID)//переход по формам в зависимости от роли
                {
                    case 1:
                        FormManager formManager = new FormManager();
                        formManager.ShowDialog();
                        break;
                    case 2:
                        FormSeller formSeller = new FormSeller();
                        formSeller.ShowDialog();
                        break;
                    case 3:
                        FormDirector formDirector = new FormDirector();
                        formDirector.ShowDialog();
                        break;
                    default: throw new Exception("Роль не найдена!");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
