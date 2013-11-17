using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Splashscreen threading 
using System.Threading; 
namespace Movie_Bonanza
{
    public partial class SelectionForm : Form
    {
        decimal[] downloadCost = new decimal[] 
        { 1.99m, 1.99m, 2.99m, 2.99m, 2.99m, 1.99m, 0.99m, 4.99m  };

        string[] category = new string[] { "Comedy", "Drama", "Action", "Sci-Fi", "Horror", "Thriller", "Family", "New Release" }; 

        string[] comedyMovies = new string[] { "The Delemma", "No Strings Attached", "Cedar Rapids", "Just Go With it" };
        string[] dramaMovies = new string[] {"Company Men", "The Way Back", "Waiting for Forever"  };
        string[] actionMovies = new string[] {"The Green Hornet", "Death Race 2", "The Mechanic", "Sanctum", "The Other Woman", "The Eagle" };
        string[] scifiMovies = new string[] {"Season of the Witch", "I am Number Four" };
        string[] horrorMovies = new string[] {"The Rite"};
        string[] thrillerMovies = new string[] {"The Roomate" };
        string[] familyMovies = new string[] {"Gnomeo and Juliet" };
        string[] newReleaseMovies = new string[] {"Footloose", "Real Steel" }; 
        


        public SelectionForm()
        {
            //to be added splashscreen
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        /*
        * funciton for splashstart to be called 
        * */
        public void SplashStart()
        {
            Application.Run(new SplashScreenForm());
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = string.Empty; 
           
            foreach (string index in MoviesListBox.SelectedItems) {
                TitleTextBox.Text = index.ToString();
               
            }
           
            

           // MoviesListBox.Text = string.Empty;

            /*StringBuilder sb = new StringBuilder();
            foreach (Object obj in MoviesListBox.SelectedItems)
                sb.AppendFormat("{0} ", ((DataRowView)obj)[0].ToString());

            TitleTextBox.Text = sb.ToString(); 
        
                //MoviesListBox.Items.Count
            
               for (int index = 0; index < MoviesListBox.Items.Count; index++)
               {

                    TitleTextBox.Text = MoviesListBox.SelectedIndex[index].ToString();
                        index++; 
                }*/
             
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryIndexInteger = CategoryListBox.SelectedIndex;

            
                if (categoryIndexInteger == 0)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(comedyMovies);
                    CategoryTextBox.Text = category[0];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 1)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(dramaMovies);
                    CategoryTextBox.Text = category[1];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 2)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(actionMovies);
                    CategoryTextBox.Text = category[2];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 3)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(scifiMovies);
                    CategoryTextBox.Text = category[3];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 4)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(horrorMovies);
                    CategoryTextBox.Text = category[4];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 5)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(thrillerMovies);
                    CategoryTextBox.Text = category[5];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 6)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(familyMovies);
                    CategoryTextBox.Text = category[6];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 7)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(newReleaseMovies);
                    CategoryTextBox.Text = category[7];
                    CostTextBox.Text = downloadCost[7].ToString();
                }
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
