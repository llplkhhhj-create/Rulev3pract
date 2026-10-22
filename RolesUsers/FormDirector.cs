using System;
using System.Windows.Forms;
using RolesUsers.ADO.NET;

namespace RolesUsers
{
    public partial class FormDirector : FormParent
    {
        public FormDirector()
        {
            InitializeComponent();
            labelTitle.Text = "Форма Директора";
        }
    }
}
