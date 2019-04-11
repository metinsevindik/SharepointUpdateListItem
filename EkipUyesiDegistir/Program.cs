using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SP = Microsoft.SharePoint.Client;
using Microsoft.SharePoint;

namespace EkipUyesiDegistir
{
    class Program
    {

        static string siteUrl = "https://sizdes.saglik.gov.tr/test";
        static SP.ClientContext clientContext = null;

        static void Main(string[] args)
        {
            try
            {
                clientContext = new SP.ClientContext(siteUrl);
                clientContext.Credentials = new NetworkCredential("sgbadminbi", "Sgb123BI", "sbnet");
                UpdateKPIs();
            }
            catch
            {

            }
        }


        private static void UpdateKPIs()
        {
            SP.List oList = clientContext.Web.Lists.GetByTitle("Faaliyetler");
            SP.CamlQuery camlQuery = new SP.CamlQuery();
            camlQuery.ViewXml = "<View>" +
                "<Query>" +
                    "<OrderBy>" +
                        "<FieldRef Name='ID' Ascending='TRUE'/>" +
                     "</OrderBy>" +
                "</Query>" +
            "</View>";
            SP.ListItemCollection collListItem = oList.GetItems(camlQuery);
            oList.EnableVersioning = false;
            clientContext.Load(collListItem);
            clientContext.ExecuteQuery();

            #region Version Pasif
            var item = collListItem[0];
            item["SorumluEkipUyesi"] = "Version Pasif";
            oList.EnableVersioning = false;
            oList.Update();
            item.Update();
            clientContext.ExecuteQuery();
            #endregion

            #region version aktif
            item = collListItem[0];
            item["SorumluEkipUyesi"] = "Version Pasif";
            //oList.EnableVersioning = false;
            oList.Update();
            item.Update();
            clientContext.ExecuteQuery();
            
            #endregion
            //if (collListItem.Count > 0)
            //{
                //foreach (SP.ListItem oListItem in collListItem)
                //{
                //    oListItem["SorumluEkipUyesi"] = "Test";
                //    oListItem.Update();
                //}
            //}
            //oList.Update();
            //clientContext.ExecuteQuery();
        }
    }
}
