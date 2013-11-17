using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Bonanza
{
    public partial class OrderForm : Form
    {
        private string title, category, cost;

        

        public string titleValue {
            get { return title; }
            set { title = value; }
        }
        public string categoryValue
        {
            get { return category; }
            set { category = value; }
        }
        public string costValue
        {
            get { return cost; }
            set { cost = value; }
        }

        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(System.Drawing.Image i)
        {
            InitializeComponent();
            MoviePictureBox.Image = i; 
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            SelectionForm aSelectionForm = new SelectionForm();
            aSelectionForm.ShowDialog(); 
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = title;
            CategoryTextBox.Text = category;
            CostTextBox.Text = cost; 
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            StreamForm aStreamForm = new StreamForm();
            aStreamForm.ShowDialog(); 
        }
    }
}
