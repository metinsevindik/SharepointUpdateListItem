using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SP = Microsoft.SharePoint.Client;
using Microsoft.SharePoint;
using System.Net;

namespace EkipUyesiDegistirForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SP.ClientContext clientContext = null;

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(siteurltxt.Text) ||
                string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(pass.Text) ||
                string.IsNullOrWhiteSpace(domain.Text) ||
                string.IsNullOrWhiteSpace(listname.Text) ||
                string.IsNullOrWhiteSpace(hedefno.Text) ||
                string.IsNullOrWhiteSpace(HedefNoFieldName.Text) ||
                string.IsNullOrWhiteSpace(EkipuyesiFieldNAme.Text) ||
                string.IsNullOrWhiteSpace(sorumluEkipUyesi.Text))
            {
                MessageBox.Show("Fill must all textboxes");
                return;
            }

            clientContext = new SP.ClientContext(siteurltxt.Text.Trim());
            clientContext.Credentials = new NetworkCredential(username.Text, pass.Text, domain.Text);
            UpdateList();
        }

        private void UpdateList()
        {
            SP.List oList = clientContext.Web.Lists.GetByTitle(listname.Text);
            SP.CamlQuery camlQuery = new SP.CamlQuery();
            camlQuery.ViewXml = @"<View>" +
                "<Query> <Where><BeginsWith><FieldRef Name='" + HedefNoFieldName.Text + "' /><Value Type='Computed'>" + hedefno.Text + "</Value></BeginsWith></Where><OrderBy><FieldRef Name='ID' /></OrderBy>  </Query>" +
            "</View>";
            SP.ListItemCollection collListItem = oList.GetItems(camlQuery);
            oList.EnableVersioning = false;
            clientContext.Load(collListItem);
            clientContext.ExecuteQuery();

            foreach (var listItem in collListItem)
            {
                listItem[EkipuyesiFieldNAme.Text] = sorumluEkipUyesi.Text;
                listItem.Update();
                clientContext.ExecuteQuery();
            }
        }
    }
}
