﻿using System;
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
    public partial class PokemonRoad : Form
    {
        public Pikachu _UsersPikachu = new Pikachu();
        public Bulbasaur _Bulbasaur = new Bulbasaur();
        public int CurrentSeq;

        public PokemonRoad(Pikachu defaultspokemon, int seq)
        {
            _UsersPikachu = defaultspokemon;
            CurrentSeq = seq;
            CurrentStage.Text = CheckStage().ToString();
            InitializeComponent();
        }


        List<StageInfo> stageList = new List<StageInfo>();
        public PokemonRoad()
        {
           var _bossbulbasaur = _Bulbasaur.pokemon;
            InitializeComponent();
            stageList.Add(new StageInfo()
            { StageName = "MeetBulbasaur",
              success = false, pokemon = _bossbulbasaur, Seq = 1});

            stageList.Add(new StageInfo()
            {
                StageName = "MeetCharmander",
              success = false, pokemon = _bossbulbasaur, Seq = 2 });

            stageList.Add(new StageInfo()
            { StageName = "MeetSquirtle",
              success = false, pokemon = _bossbulbasaur, Seq = 3 });

        }

        //檢查目前關卡
        public int CheckStage()
        {
            
            int currentStage = 0;

            foreach (var stage in stageList)
            {
                if (!stage.success)
                {
                    currentStage = stage.Seq;
                    break;
                }
            }
            return currentStage;           
        }
  
        private void button1_Click(object sender, EventArgs e)
        {

            //fighting(_pika, stageList[currentStage]);

            MeetBulbasaur MeetBulbasaur = new MeetBulbasaur(_UsersPikachu);//產生Form2的物件，才可以使用它所提供的Method
            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            MeetBulbasaur.Visible = true;

        }

        //Button顯示透明
        private void PokemonRoad_Load(object sender, EventArgs e)
        {
            PalletTown.BackColor = Color.Transparent;
            PalletTown.FlatStyle = FlatStyle.Popup;

            ViridianCity.BackColor = Color.Transparent;
            ViridianCity.FlatStyle = FlatStyle.Popup;

            PewterCity.BackColor = Color.Transparent;
            PewterCity.FlatStyle = FlatStyle.Popup;

            MtMoon.BackColor = Color.Transparent;
            MtMoon.FlatStyle = FlatStyle.Popup;

            CeruleanCity.BackColor = Color.Transparent;
            CeruleanCity.FlatStyle = FlatStyle.Popup;

            VermilionCity.BackColor = Color.Transparent;
            VermilionCity.FlatStyle = FlatStyle.Popup;

        }
    }
}
