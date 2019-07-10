using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIS实验3_lxy07162801
{
    public partial class Spatialqueryform : Form
    {
        private ESRI.ArcGIS.Controls.AxMapControl m_mapControl;
        public int mQueryModel;
        public int mLayerIndex;
        public Spatialqueryform(ESRI.ArcGIS.Controls.AxMapControl mapControl)
        {

            InitializeComponent();
            this.m_mapControl = mapControl;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Spatialqueryform_Load(object sender, EventArgs e)
        {
            if (m_mapControl.LayerCount <= 0)
                return;
            for(int i=0 ;i<m_mapControl.LayerCount;i++)
            {
                cobLayer.Items.Add(m_mapControl.get_Layer(i).Name);
            }
        this.cobSerchStyle.Items.Add("矩形查询");
        this.cobSerchStyle.Items.Add("圆形查询");
        this.cobSerchStyle.Items.Add("多边形查询");
        cobLayer.SelectedIndex = 0;
        cobSerchStyle.SelectedIndex = 0;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (this.cobLayer.Items.Count <= 0)
            {
                MessageBox.Show("还未添加图层");
                return;
            }
            this.mLayerIndex = cobLayer.SelectedIndex;
            this.mQueryModel = cobSerchStyle.SelectedIndex;
        }
    }
}
