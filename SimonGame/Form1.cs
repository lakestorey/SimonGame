using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace SimonGame
{
    public partial class Form1 : Form
    {
        public static List<int> pattern = new List<int>();

        public static int progress;

        //sounds
        public static SoundPlayer greenSound = new SoundPlayer(Properties.Resources.green);
        public static SoundPlayer redSound = new SoundPlayer(Properties.Resources.red);
        public static SoundPlayer blueSound = new SoundPlayer(Properties.Resources.blue);
        public static SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.yellow);
        public static SoundPlayer mistakeSound = new SoundPlayer(Properties.Resources.mistake);

        public Form1()
        {
            InitializeComponent();

            //launch mainscreen
            MainScreen ms = new MainScreen();

            this.Controls.Add(ms);
        }
    }
}
