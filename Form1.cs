using CatProject.Models;

namespace CatProject
{
    public partial class Form1 : Form
    {
        Models.CatDbContext catDbContext;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
            var breed = catDbContext.Breeds.ToList();
            var colors = catDbContext.Colors.ToList();
            var play = catDbContext.Playfullnesses.ToList();
            var activities = catDbContext.ActivityLevels.ToList();

            comboBox1.DataSource = breed;
            comboBox1.DisplayMember = "Breed1";
            comboBox1.ValueMember = "BreedID";

            comboBox2.DataSource = colors;
            comboBox2.DisplayMember = "ColorValue";
            comboBox2.ValueMember = "ColorID";

            comboBox3.DataSource = play;
            comboBox3.DisplayMember = "PlayfullnessValue";
            comboBox3.ValueMember = "PlayfullnessId";

            comboBox4.DataSource = activities;
            comboBox4.DisplayMember = "ActivityLevelValue";
            comboBox4.ValueMember = "ActivityLevelId";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonShowSelectedBreed_Click(object sender, EventArgs e)
        {
            string breed = comboBox1.Text;
            Display(breed);


        }

        private void buttonShowBreedColor_Click(object sender, EventArgs e)
        {
            string breed = comboBox1.Text;
            string color = comboBox2.Text;
            Display(breed, color);
        }

        private void buttonAllfourCriteria_Click(object sender, EventArgs e)
        {
            string breed = comboBox1.Text;
            string color = comboBox2.Text;
            string playful = comboBox3.Text;
            string activity = comboBox4.Text;
            Display(breed, color, playful, activity);
        }

        public void Display()
        {
            catDbContext = new Models.CatDbContext();
            var qry = from inventory in catDbContext.Inventories
                      select new
                      {
                          inventory.InventoryId,
                          inventory.Breed.Breed1,
                          inventory.Color.ColorValue,
                          inventory.Playfullness.PlayfullnessValue,
                          inventory.ActivityLevel.ActivityLevelValue
                      };

            dataGridView1.DataSource = qry.ToList();
            dataGridView1.AutoResizeColumns();
        }
        public void Display(string val)
        {
            catDbContext = new Models.CatDbContext();
            var qry = from inventory in catDbContext.Inventories
                      where inventory.Breed.Breed1 == val
                      select new
                      {
                          inventory.InventoryId,
                          inventory.Breed.Breed1,
                          inventory.Color.ColorValue,
                          inventory.Playfullness.PlayfullnessValue,
                          inventory.ActivityLevel.ActivityLevelValue
                      };

            dataGridView1.DataSource = qry.ToList();
            dataGridView1.AutoResizeColumns();
        }
        public void Display(string val, string val2)
        {
            catDbContext = new Models.CatDbContext();
            var qry = from inventory in catDbContext.Inventories
                      where inventory.Breed.Breed1 == val && inventory.Color.ColorValue == val2
                      select new
                      {
                          inventory.InventoryId,
                          inventory.Breed.Breed1,
                          inventory.Color.ColorValue,
                          inventory.Playfullness.PlayfullnessValue,
                          inventory.ActivityLevel.ActivityLevelValue
                      };

            dataGridView1.DataSource = qry.ToList();
            dataGridView1.AutoResizeColumns();
        }
        public void Display(string val, string val2, string val3, string val4)
        {
            catDbContext = new Models.CatDbContext();
            var qry = from inventory in catDbContext.Inventories
                      where inventory.Breed.Breed1 == val &&
                      inventory.Color.ColorValue == val2 && 
                      inventory.Playfullness.PlayfullnessValue == val3 &&
                      inventory.ActivityLevel.ActivityLevelValue == val4
                      select new
                      {
                          inventory.InventoryId,
                          inventory.Breed.Breed1,
                          inventory.Color.ColorValue,
                          inventory.Playfullness.PlayfullnessValue,
                          inventory.ActivityLevel.ActivityLevelValue
                      };

            dataGridView1.DataSource = qry.ToList();
            dataGridView1.AutoResizeColumns();
        }
    }
}

