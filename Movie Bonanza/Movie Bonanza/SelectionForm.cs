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
        decimal[,] DownloadCost = new decimal[,] 
        { {1.99m, 1.99m, 2.99m, 2.99m, 2.99m, 1.99m, 0.99m, 4.99m } };

        string[] category = new string[] {"Comedy" };

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
            int comedyIndexInteger, dramaIndexInteger, actioinIndexInteger, scifiIndexInteger, horrorIndexInteger, thrillerIndexInteger,
                familyIndexInteger, newReleaseIndexInteger = MoviesListBox.SelectedIndex; 
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryIndexInteger = CategoryListBox.SelectedIndex;
            if (categoryIndexInteger == 0)
            {
                MoviesListBox.Items.Clear(); 
                MoviesListBox.Items.AddRange(comedyMovies);
            }
            if (categoryIndexInteger == 1) {
                MoviesListBox.Items.Clear(); 
                MoviesListBox.Items.AddRange(dramaMovies); 
            }
            if (categoryIndexInteger == 2)
            {
                MoviesListBox.Items.Clear(); 
                MoviesListBox.Items.AddRange(actionMovies);
            }
            if (categoryIndexInteger == 3)
            {
                MoviesListBox.Items.Clear(); 
                MoviesListBox.Items.AddRange(scifiMovies);
            }
            if (categoryIndexInteger == 4)
            {
                MoviesListBox.Items.Clear(); 
                MoviesListBox.Items.AddRange(horrorMovies);
            }
            if (categoryIndexInteger == 5)
            {
                MoviesListBox.Items.Clear(); 
                MoviesListBox.Items.AddRange(thrillerMovies);
            }
            if (categoryIndexInteger == 6)
            {
                MoviesListBox.Items.Clear(); 
                MoviesListBox.Items.AddRange(familyMovies);
            }
            if (categoryIndexInteger == 7)
            {
                MoviesListBox.Items.Clear(); 
                MoviesListBox.Items.AddRange(newReleaseMovies);
            }
        }
    }
}
