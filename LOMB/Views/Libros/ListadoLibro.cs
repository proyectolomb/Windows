using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Dapper;

namespace LOMB.Views
{
    public partial class ListadoLibro : Form
    {
        MaterialSkinManager skinManager;
        public ListadoLibro()
        {
            InitializeComponent();
            /*skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green900, Primary.Green900, Accent.LightBlue200, TextShade.WHITE)*/
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            /*using(IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var data = db.Query<Product>("", commandType: CommandType.Text);

                materialListView1.Items.Clear();

                foreach(Product p in data)
                {
                    ListViewItem item = new ListViewItem(p.ProductID.ToString());
                    item.SubItems.Add(p.ProductName);
                    item.SubItems.Add(p.UnitPrice.ToString());
                    item.SubItems.Add(p.UnitsInStock.ToString());
                    materialListView1.Items.Add(item);
                }
            }*/
        }
    }
}
