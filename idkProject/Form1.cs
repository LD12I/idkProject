using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace idkProject
{
    public partial class Form1 : Form
    {
        DatabaseHandler db = new DatabaseHandler();
        int selecteditem = 1;
        List<game> games = new List<game>();
        int yspace = 0;
        int xspace = 0;
        bool Bottomor = false;
        public Form1()
        {
            InitializeComponent();
            HideAdd();
            games = db.ReadAll();
            Border.BackColor = Color.LightBlue;

            for (int i = 0; i < games.Count; i++)
            {
                GameAdd(games[i].name, games[i].id);
            }


            gameaddB.Click += (s, e) =>{
                ShowAdd();
                game onegame = new game();
                onegame.name = GameNameTB.Text;
                onegame.type = GameTypeTB.Text;
                onegame.price =Convert.ToInt32(GamePriceTB.Text);

                db.insertOneItem(onegame);
            };

            gamedeleteB.Click += (s, e) =>
            {
                if (selecteditem != null)
                {
                    db.deleteOneitem(selecteditem -1);
                    
                }
            };




        }

        void GameAdd(string name, int tagid)
        {
            Button GameP = new Button()
            {
                Location = new Point(0 + xspace, 0 + yspace),
                //BackgroundImage = Image.FromFile("darksouls.jpg"),
                BackColor = Color.White,
                Text = "",
                Width = 250,
                Height = 250,
                BackgroundImageLayout = ImageLayout.Stretch,
                Tag = tagid
                
            };

            Label GamenameL = new Label()
            {
                Location = new Point(50 + xspace, GameP.Width + yspace + 20),
                ForeColor = Color.White,
                Text = name,
                Font = new Font("TimesNewRoman", 20),
                AutoSize = true
            };

            GameP.Click += (s, e) =>
            {
                selecteditem = Convert.ToInt32(GameP.Tag)-1;
                for (int i = 0; i < games.Count; i++)
                {
                    properties.Text = $"Game Name: {games[selecteditem].name} \nGame type: {games[selecteditem].type} \nGame price: {games[selecteditem].price}";
                
                }
            };





            Gamepanel.Controls.Add(GameP); 
            Gamepanel.Controls.Add(GamenameL);

            if (Bottomor)
            {
                yspace += GameP.Height + 80;
                xspace = 0;
            }
            else
            {

                xspace += GameP.Width + 20;

            }




            Bottomor = !Bottomor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        void ShowAdd()
        {
            AddL.Show();
            GameNameTB.Show();
            pictureBox1.Show();
            AddB.Show();
        }

        void HideAdd()
        {
            AddL.Hide();
            GameNameTB.Hide();
            pictureBox1.Hide();
            AddB.Hide();
        }
    }
}
