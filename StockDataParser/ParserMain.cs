using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//sk이노 : 096770

namespace StockDataParser
{
    public partial class ParserMain : Form
    {
        const string PART_CODE_TEMP = "096770";
        List<Variables.DetailInfo> StockInfo = new List<Variables.DetailInfo>();
        public ParserMain()
        {
            InitializeComponent();
            SetInit();
        }

        private void SetInit()
        {
            btnParsing.Click += BtnParsing_Click;
        }
        

        private void BtnParsing_Click(object sender, EventArgs e)
        {
            StockInfo = Parser.Instance.GetDetailInfo(PART_CODE_TEMP, 60);
            dgvMain.DataSource = StockInfo;
        }
    }
}
