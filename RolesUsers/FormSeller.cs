using System;
using System.Windows.Forms;
using RolesUsers.ADO.NET;

namespace RolesUsers
{
    public partial class FormSeller : FormParent
    {
        public FormSeller()
        {
            InitializeComponent();
            labelTitle.Text = "Форма Продавца";
        }
    }
}
