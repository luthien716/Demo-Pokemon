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
using PokemonRoad;
using EasyMathLibrary;
using StageLibrary;


namespace PokemonRoad
{
    public partial class MeetCharmander : Form
    {
        public Pikachu userspikachu;
        public Charmander _charmander = new Charmander();

        public MeetCharmander(Pikachu _UsersPikachu)
        {
            userspikachu = _UsersPikachu;
            InitializeComponent();
            //SelfHp.Text = "HP" + _UsersPikachu.pokemon.CurrentHp.ToString() + "/" + _UsersPikachu.pokemon.Hp.ToString();
            //EnemyHp.Text = "HP" + _bulbasaur.pokemon.CurrentHp.ToString() + "/" + _bulbasaur.pokemon.Hp.ToString();
            
        }

        private void MeetCharmander_Load(object sender, EventArgs e)
        {
            Attack.BackColor = Color.Transparent;
            Attack.FlatStyle = FlatStyle.Popup;

            Defend.BackColor = Color.Transparent;
            Defend.FlatStyle = FlatStyle.Popup;

            Super.BackColor = Color.Transparent;
            Super.FlatStyle = FlatStyle.Popup;
        }
    }
}
