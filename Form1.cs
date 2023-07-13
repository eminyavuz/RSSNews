using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RSSNews
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
              
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           List <News> rows= ToXml();
            listBox1.DataSource = rows;
        }

       private  List<News> ToXml ()
        {
            List<News> news = new List<News>();
            XDocument xml = XDocument.Load(textBox1.Text);
            List<XElement> xmlEl = xml.Descendants("item").ToList();
            foreach (XElement el in xmlEl) { 
                News news1 = new News();
                news1.title= el.Element("title").Value;
                news1.desc= el.Element("description").Value;
                news1.link= el.Element("link").Value;  
               news.Add(news1);

            }  
            return news;
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lstb= (ListBox)sender;
         News News2  = (News)lstb.SelectedItem;
            webBrowser1.DocumentText = News2.desc;

        }
        public void InitMyForm()
        {
            // Adds a label to the form.
            Label label1 = new Label();
            label1.Location = new System.Drawing.Point(80, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 80);
            label1.Text = "Start Position Information";
            this.Controls.Add(label1);

            // Changes the border to Fixed3D.
            FormBorderStyle = FormBorderStyle.Fixed3D;

            // Displays the border information.
            label1.Text = "The border is " + FormBorderStyle;
        }
    }
}
