using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDataParser
{
    public partial class ParserMain : Form
    {
        public ParserMain()
        {
            InitializeComponent();
        }

        private void SetInit()
        {
            btnParsing.Click += BtnParsing_Click;
        }

        private void BtnParsing_Click(object sender, EventArgs e)
        {
            
        }
    }
}
