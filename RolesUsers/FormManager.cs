using System;
using System.Windows.Forms;
using RolesUsers.ADO.NET;

namespace RolesUsers
{
    public partial class FormManager : FormParent
    {
        public FormManager()
        {
            InitializeComponent();
            labelTitle.Text = "Форма Менеджера";
        }
    }
}
