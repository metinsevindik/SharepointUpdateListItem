using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateListItem
{
    public partial class Preview : Form
    {
        private Microsoft.SharePoint.Client.ListItemCollection collListItem;
        private Microsoft.SharePoint.Client.List oList;

        public Preview()
        {
            InitializeComponent();
        }

        public Preview(Microsoft.SharePoint.Client.ListItemCollection collListItem, Microsoft.SharePoint.Client.List oList)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.collListItem = collListItem;
            this.oList = oList;

            DataTable dt = new DataTable();
            var fieldList = oList.Fields.ToList().Where(p => p.Hidden == false && p.Group != "_Hidden");
            
            
            dt.Columns.Add(new DataColumn("Baslik"));


            foreach (Microsoft.SharePoint.Client.Field f in fieldList)
            {
                dt.Columns.Add(new DataColumn(f.StaticName.ToString()));
            }
            
            foreach (Microsoft.SharePoint.Client.ListItem item in collListItem)
            {
                DataRow dr = dt.NewRow();
                foreach (Microsoft.SharePoint.Client.Field f in fieldList)
                {
                    try
                    {
                        if (item[f.StaticName.ToString()] != null && !string.IsNullOrEmpty(item[f.StaticName.ToString()].ToString()))
                            dr[f.StaticName.ToString()] = string.IsNullOrEmpty(item[f.StaticName.ToString()].ToString()) ? "-" : item[f.StaticName.ToString()].ToString();
                    }
                    catch (Exception)
                    {
                        dr[f.StaticName.ToString()] = "-";
                    }
                }
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
            //bindingSource.ResetBindings(false);
        }

        private void Preview_Load(object sender, EventArgs e)
        {

        }
    }
}
