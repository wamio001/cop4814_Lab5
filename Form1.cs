using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;
using System.IO;
using System.Xml.Serialization;

namespace GameFactory
{
    public partial class Form1 : Form
    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Game> gameList;
        const string Games_FileName = @"..\..\games.xml";

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            gameList = new List<Game>();
            Game g = new Game("Team1", "Team2", 10, 20);
            gameList.Add(g);
            //label2.Text = g.ToString();

            g = new Game("Eagles", "Bears", 5, 10);
            gameList.Add(g);

            g = new Game("Crabs", "Deers", 1, 2);
            gameList.Add(g);

            g = new Game("Hawks", "Tigers", 42, 22);
            gameList.Add(g);

            g = new Game("Bucks", "Wolves", 30, 25);
            gameList.Add(g);

            g = new Game("Raptors", "Wizards", 12, 21);
            gameList.Add(g);

            serial = new XmlSerializer(gameList.GetType());
            //sw = new StreamWriter(Games_FileName); 
            serial.Serialize(sw, gameList);
            sw.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw = new StreamWriter(Games_FileName);
            gameList = new List<Game>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameList = new List<Game>();
            StreamReader sr = new StreamReader(Games_FileName);
            serial = new XmlSerializer(gameList.GetType());
            gameList = (List<Game>)serial.Deserialize(sr);
            sr.Close();

            foreach(Game g in gameList)
            {
                listBox1.Items.Add(g.ToString());
            }

        }
    }
}
