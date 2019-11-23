using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPerfin.Dashboard
{
    public partial class DashboardForm : MainForm
    {
        protected int userId;

        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
    }
}
