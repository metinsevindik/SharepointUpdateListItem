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
using System.IO;
using Newtonsoft.Json;
using UpdateListItem;

namespace EkipUyesiDegistirForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string setFileName = Application.StartupPath + "\\" + "settings.txt";
        SP.ClientContext clientContext = null;

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(siteurltxt.Text) ||
                string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(pass.Text) ||
                string.IsNullOrWhiteSpace(domain.Text) ||
                string.IsNullOrWhiteSpace(listname.Text) ||
                (useCAMLQuery.Checked == false && string.IsNullOrWhiteSpace(SearchFieldValueTxt.Text)) ||
                (useCAMLQuery.Checked == false && string.IsNullOrWhiteSpace(SearchFieldName.Text)) ||
                (useCAMLQuery.Checked == true && string.IsNullOrWhiteSpace(camlQueryText.Text)) ||
                string.IsNullOrWhiteSpace(ReplaceFieldName.Text) ||
                string.IsNullOrWhiteSpace(ReplaceFieldValue.Text))
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
            try
            {
                string datefirst = DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss");
                SP.List oList = clientContext.Web.Lists.GetByTitle(listname.Text);
                SP.CamlQuery camlQuery = new SP.CamlQuery();
                if (useCAMLQuery.Checked)
                {
                    camlQuery.ViewXml = camlQueryText.Text;
                }
                else
                {
                    camlQuery.ViewXml = @"<View>" +
                        "<Query> <Where><BeginsWith><FieldRef Name='" + SearchFieldName.Text + "' /><Value Type='Text'>" + SearchFieldValueTxt.Text + "</Value></BeginsWith></Where><OrderBy><FieldRef Name='ID' /></OrderBy>  </Query>" +
                    "</View>";
                }
                SP.ListItemCollection collListItem = oList.GetItems(camlQuery);
                oList.EnableVersioning = true;
                clientContext.Load(collListItem);
                clientContext.ExecuteQuery();

                foreach (var listItem in collListItem)
                {
                    listItem[ReplaceFieldName.Text] = ReplaceFieldValue.Text;
                    listItem.Update();
                    clientContext.ExecuteQuery();
                }
                infolbl.Text = "Start Time: " + datefirst + ",\n Finish Time: " + DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss");
            }
            catch (Exception ex)
            {
                infolbl.Text = ex.Message;
            }
        }


        private void LoadSetting(string path)
        {
            var str = File.ReadAllText(path);
            var set = JsonConvert.DeserializeObject<setting>(str);
            domain.Text = set.domain;
            listname.Text = set.listname;
            ReplaceFieldName.Text = set.ReplaceFieldName;
            ReplaceFieldValue.Text = set.ReplaceFieldValue;
            SearchFieldName.Text = set.searchfieldName;
            SearchFieldValueTxt.Text = set.searchFieldValue;
            siteurltxt.Text = set.siteURl;
            username.Text = set.username;
            camlQueryText.Text = set.camlquery;
            useCAMLQuery.Checked = set.usecamlquery;
        }

        class setting
        {
            public string siteURl { get; set; }
            public string domain { get; set; }
            public string username { get; set; }
            public string listname { get; set; }
            public string searchfieldName { get; set; }
            public string searchFieldValue { get; set; }
            public string ReplaceFieldName { get; set; }
            public string ReplaceFieldValue { get; set; }
            public string camlquery { get; set; }
            public bool usecamlquery { get; set; }
        }

        private void saveSetting(string path)
        {
            setting set = new setting();
            set.siteURl = siteurltxt.Text;
            set.domain = domain.Text;
            set.username = username.Text;
            set.listname = listname.Text;
            set.ReplaceFieldName = ReplaceFieldName.Text;
            set.ReplaceFieldValue = ReplaceFieldValue.Text;
            set.searchfieldName = SearchFieldName.Text;
            set.searchFieldValue = SearchFieldValueTxt.Text;
            set.camlquery = camlQueryText.Text;
            set.usecamlquery = useCAMLQuery.Checked;
            var settingStr = JsonConvert.SerializeObject(set);

            File.WriteAllText(path, settingStr);
        }

        private void OpenSettingBtn_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = openFileDialog1.ShowDialog(this);
            if (diaResult == System.Windows.Forms.DialogResult.OK)
            {
                LoadSetting(openFileDialog1.FileName.ToString());
            }
        }

        private void saveSettingBtn_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = saveFileDialog1.ShowDialog(this);
            if (diaResult == System.Windows.Forms.DialogResult.OK)
            {
                saveSetting(saveFileDialog1.FileName.ToString());
            }
        }

        private void useCAMLQuery_CheckedChanged(object sender, EventArgs e)
        {
            SearchFieldName.Enabled = !useCAMLQuery.Checked;
            SearchFieldValueTxt.Enabled = !useCAMLQuery.Checked;
            camlQueryText.Enabled = useCAMLQuery.Checked;
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(siteurltxt.Text) ||
               string.IsNullOrWhiteSpace(username.Text) ||
               string.IsNullOrWhiteSpace(pass.Text) ||
               string.IsNullOrWhiteSpace(domain.Text) ||
               string.IsNullOrWhiteSpace(listname.Text) ||
               (useCAMLQuery.Checked == false && string.IsNullOrWhiteSpace(SearchFieldValueTxt.Text)) ||
               (useCAMLQuery.Checked == false && string.IsNullOrWhiteSpace(SearchFieldName.Text)) ||
               (useCAMLQuery.Checked == true && string.IsNullOrWhiteSpace(camlQueryText.Text)) ||
               string.IsNullOrWhiteSpace(ReplaceFieldName.Text) ||
               string.IsNullOrWhiteSpace(ReplaceFieldValue.Text))
            {
                MessageBox.Show("Fill must all textboxes");
                return;
            }

            clientContext = new SP.ClientContext(siteurltxt.Text.Trim());
            clientContext.Credentials = new NetworkCredential(username.Text, pass.Text, domain.Text);
            SP.List oList = clientContext.Web.Lists.GetByTitle(listname.Text);



            SP.CamlQuery camlQuery = new SP.CamlQuery(); 
            if (useCAMLQuery.Checked)
            {
                camlQuery.ViewXml = camlQueryText.Text;
            }
            else
            {
                camlQuery.ViewXml = @"<View>" +
                    "<Query> <Where><BeginsWith><FieldRef Name='" + SearchFieldName.Text + "' /><Value Type='Text'>" + SearchFieldValueTxt.Text + "</Value></BeginsWith></Where><OrderBy><FieldRef Name='ID' /></OrderBy>  </Query>" +
                "</View>";
            }
            SP.ListItemCollection collListItem = oList.GetItems(camlQuery);
          
            clientContext.Load(collListItem);
            clientContext.Load(oList);
            clientContext.Load(oList.Fields);
            clientContext.ExecuteQuery();

            Preview preForm = new Preview(collListItem,oList);
            preForm.Show();
        }
    }
}
