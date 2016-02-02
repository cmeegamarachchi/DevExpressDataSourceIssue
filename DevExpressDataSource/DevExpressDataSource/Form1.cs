using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NorthwindBusinessServices.Products;
using NorthwindDataAccess.DataContext;

namespace DevExpressDataSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IEnumerable<ProductDetails> ProductDetails { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            // you need to have northwind database configured and pointed via app config
            // for the following two lined to work
            var service = new ProductsService(new NorthwindUnitOfWork());
            ProductDetails = service.GetProducts(int.MaxValue, 1).Data;
        }
    }
}