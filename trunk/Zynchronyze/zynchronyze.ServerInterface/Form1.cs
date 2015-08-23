using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zynchronyze.ServerInterface
{
    public partial class frmPublish : Form
    {
        public frmPublish()
        {
            InitializeComponent();
        }

        private void btnSearchFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog.SelectedPath;    
            }
        }

        private void frmPublish_Load(object sender, EventArgs e)
        {
           // Load Items
            LoadFolders();
        }

        private void LoadFolders()
        {
            // Clear items first
            lvPublishedFolders.Items.Clear();

            System.Xml.XmlDocument objXmlDocument = new System.Xml.XmlDocument();
            // Load XML
            objXmlDocument.Load(@".\Data\PublishedFolders.xml");
            // Get all Folders Tag
            System.Xml.XmlNodeList objXmlNodeList = objXmlDocument.GetElementsByTagName("Folder");

            // Iterate
            foreach (System.Xml.XmlNode item in objXmlNodeList)
            {
                string Name = item.Attributes["Name"].Value;
                string Status = item.Attributes["Status"].Value;
                string Path = item.Attributes["Path"].Value;

                // Create a Item for ListItem
                ListViewItem objListViewItem = new ListViewItem(new string[] {Name,Status,Path});
                objListViewItem.Selected = true;
                lvPublishedFolders.Items.Add(objListViewItem);
            }
        }

        private void btnPublishFolder_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFolderPath.Text))
            {
                //To Publish Folder, add Data to XML
                System.Xml.XmlDocument objXmlDocument = new System.Xml.XmlDocument();
                // Load XML
                objXmlDocument.Load(@".\Data\PublishedFolders.xml");
                System.Xml.XmlNode objXmlNode = objXmlDocument.CreateNode(System.Xml.XmlNodeType.Element,"Folder", "Folder");
                
                // Attribute Name
                System.Xml.XmlAttribute objXmlAttribute = objXmlDocument.CreateAttribute("Name");
                objXmlAttribute.Value = "Carpeta";
                objXmlNode.Attributes.Append(objXmlAttribute);
                // Attribute Status
                objXmlAttribute = objXmlDocument.CreateAttribute("Status");
                objXmlAttribute.Value = "Enabled";
                objXmlNode.Attributes.Append(objXmlAttribute);
                // Attribute Path
                objXmlAttribute = objXmlDocument.CreateAttribute("Path");
                objXmlAttribute.Value = txtFolderPath.Text;
                objXmlNode.Attributes.Append(objXmlAttribute);

                // Add Node
                objXmlDocument.SelectSingleNode("/PublishedFolders").AppendChild(objXmlNode);
                // Update File
                objXmlDocument.Save(@".\Data\PublishedFolders.xml");

                // Refresh List
                LoadFolders();
            }
        }
    }
}
