using System.Collections.Generic;
using System.Windows.Forms;
using THI_HANG_A1.Models;

namespace THI_HANG_A1.Forms
{
    public partial class QuanLyXe : Form
    {
        private List<Moto> xes;
        public QuanLyXe(List<Moto> x)
        {
            InitializeComponent();
            xes = x;
        }
    }
}
