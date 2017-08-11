using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLibrary;
using EasyMathLibrary;
using StageLibrary;

namespace PokemonRoad
{
    public partial class MeetBulbasaur : Form
    {
        public Pokemon userspikachu;
        public Bulbasaur _bulbasaur = new Bulbasaur();

        public MeetBulbasaur(Pokemon _UsersPikachu)
        {
            userspikachu = _UsersPikachu;
            InitializeComponent();
            SelfHp.Text = "HP" + _UsersPikachu.CurrentHp.ToString() + "/" + _UsersPikachu.Hp.ToString();
            EnemyHp.Text = "HP" + _bulbasaur.pokemon.CurrentHp.ToString() + "/" + _bulbasaur.pokemon.Hp.ToString();
        }

        public StageInfo _MeetBulbasaur = new StageInfo()
        {
            StageName = "MeetBulbasaur",
            success = false,
            //pokemon = _bulbasaur.pokemon,
            Seq = 1
        };

        public void FightingStage_Load(object sender, EventArgs e)
        {
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            _bulbasaur.pokemon.CurrentHp -= userspikachu.Attack() + _bulbasaur.pokemon.Defend();
            if (_bulbasaur.pokemon.CurrentHp <= 0)
            {
                _MeetBulbasaur.success = true;
                userspikachu.LvUp();

                PokemonRoad PokemonRoad = new PokemonRoad(userspikachu, _MeetBulbasaur.Seq);//產生Form2的物件，才可以使用它所提供的Method
                this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
                PokemonRoad.Visible = true;
            }
            else
            {
            }
        }


        private void Super_Click(object sender, EventArgs e)
        {
            _MeetBulbasaur.success = true;
            userspikachu.LvUp();

            PokemonRoad PokemonRoad = new PokemonRoad(userspikachu, _MeetBulbasaur.Seq);//產生Form2的物件，才可以使用它所提供的Method
            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            PokemonRoad.Visible = true;
        }

        private void Defend_Click(object sender, EventArgs e)
        {

        }

        private void MeetBulbasaur_Load(object sender, EventArgs e)
        {

        }
    }
}
