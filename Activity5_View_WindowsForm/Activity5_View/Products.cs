using Activity5_View.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity5_View
{
    public partial class Products : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Products()
        {
            InitializeComponent();
        }

        private async Task<List<Product>> GetProductsAsync()
        {
            try
            {
                string url = "http://localhost:5142/api/Product";
                var response = await client.GetStringAsync(url);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(response); // Use the Product class
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
                return null;
            }
        }
        private void Products_Load(object sender, EventArgs e)
        {

        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            var products = await GetProductsAsync();
            if (products != null)
            {
                dgvProducts.DataSource = products; // Set the DataSource to the product list
            }
        }
    }
}
