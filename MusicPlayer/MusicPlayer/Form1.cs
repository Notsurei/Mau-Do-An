using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        //global vars
        private static bool isPlaying = false;
        private static bool isRepeat = false;
        private static bool isRandom = false;
        private static dLinkedList playList = new dLinkedList();
        private static FolderBrowserDialog browser = new FolderBrowserDialog();
        private static dNode curSongNode;
        private static string curDir = TryGetSolutionDirectoryInfo().FullName;
        private static int curSongIndex = 0;     
        private static Random rnd = new Random();



        public MusicPlayer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        
    // events sp
        private static DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }

        private void shuffle()
        {
            int randomSong = rnd.Next(0, playList.getLen());
            while (randomSong == curSongIndex)
            {
                randomSong = rnd.Next(0, playList.getLen());
            }
            curSongIndex = randomSong;
        }

        
        private void loadCurrentSong(string url)
        {

            player.URL = url;
            trackBar_progress.Value = 0;
        }

        private void playCurrentSong()
        {
            isPlaying = true;
            button_control.BackgroundImage = new Bitmap(@curDir + "\\assets\\icons\\button_pause.png");
            player.Ctlcontrols.play();
        }

        private void stopCurrentSong()
        {
            isPlaying = false;
            button_control.BackgroundImage = new Bitmap(@curDir + "\\assets\\icons\\button_play.png");
            player.Ctlcontrols.pause();


        }

        private void selectSong()
        {
 
            string selectSongUrl = browser.SelectedPath + "\\" + listBox_playlist.SelectedItem.ToString();

            loadCurrentSong(selectSongUrl);
            while (curSongNode.data.getUrl()!= selectSongUrl)
            {
                dNode fw = curSongNode;
                dNode bw = curSongNode;
                while (true)
                {
                    if (fw.next == null)
                    {
                        fw = playList.head;
                    }
                    else fw = fw.next;
                    if (fw.data.getUrl() == selectSongUrl)
                    {
                        curSongNode = fw;
                        break;
                    }
                    if (bw.prev == null)
                    {
                        bw = playList.tail;
                    }
                    else bw = bw.prev;
                    if (bw.data.getUrl() == selectSongUrl)
                    {
                        curSongNode = bw;
                        break;
                    }
                }


            }

        }








        //events
        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar_volume.Maximum = 100;
            trackBar_volume.Value = 50;
        }

        private void FileLoader(object sender, EventArgs e)
        {
            if (playList.getLen() > 0)
            {
                stopCurrentSong();
                listBox_playlist.Items.Clear();
                player.URL = null;
                player.close();
                playList = new dLinkedList();
                curSongIndex = 0;
                curSongNode = playList.head;
            }
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(browser.SelectedPath, "*.mp3");
                if (files.Length > 0)
                {
                    foreach (string path in files)
                    {
                        string[] songName = path.Split('\\');
                        Song newSong = new Song(path,songName[songName.Length-1]);
                        playList.addNode(newSong);
                        listBox_playlist.Items.Add(newSong.getTitle());
                    }
                    curSongNode = playList.head;
                    dNode temp = playList.head;

                    
                    listBox_playlist.SelectedIndex = curSongIndex;
                }
                else
                {
                    MessageBox.Show("No mp3 Files Found in this folder");
                    button_file_loader.PerformClick();
                }

            }

        }

        private void control_Click(object sender, EventArgs e)
        { 
            if (isPlaying == false)
            {

                playCurrentSong();
            }
            else
            {
                stopCurrentSong();

            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (playList.getLen() == 0)
            {
                button_file_loader.PerformClick();
            }
            else
            {
                if (isRandom == false)
                {
                    if (curSongNode.next == null)
                    {
                        curSongNode = playList.head;
                        curSongIndex = 0;
                    }
                    else
                    {
                        curSongNode = curSongNode.next;
                        curSongIndex++;
                    }
                }
                else
                {
                    shuffle();
                }
                listBox_playlist.SelectedIndex = curSongIndex;
            }
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            if (playList.getLen() == 0)
            {
                button_file_loader.PerformClick();
            }
            else
            {
                if (isRandom == false)
                {
                    if (curSongNode.prev == null)
                    {
                        curSongNode = playList.tail;
                        curSongIndex = playList.getLen() - 1;

                    }
                    else
                    {
                        curSongNode = curSongNode.prev;
                        curSongIndex--;
                    }
                }
                else
                {
                    shuffle();
                }
                listBox_playlist.SelectedIndex = curSongIndex;
            }
        }

        private void button_re_load_Click(object sender, EventArgs e)
        {
            isRepeat = !isRepeat;
            if (isRepeat == true)
                button_re_load.BackColor = Color.Pink;
            else button_re_load.BackColor = Color.White;
        }

        private void button_shuffle__Click(object sender, EventArgs e)
        {
            isRandom = !isRandom;
            if (isRandom == true)
                button_shuffle.BackColor = Color.Pink;
            else button_shuffle.BackColor = Color.White;
        }


        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar_volume.Value;
            textBox3.Text = "Volume:" + trackBar_volume.Value + "%";
        }

        private void trackBar_progress_Scroll(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition = trackBar_progress.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playCurrentSong();
            textBox1.Text = player.Ctlcontrols.currentPositionString;
            textBox2.Text = player.currentMedia.durationString;
            trackBar_progress.Value = (int)player.Ctlcontrols.currentPosition;
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (e.newState == 2)
            {
                timer1.Stop();

            }
            else if (e.newState == 3)
            {
                trackBar_progress.Maximum = (int)player.currentMedia.duration;
                timer1.Start();
            }
            else if (e.newState == 8)
            {
                if (isRepeat == true)
                {
                    listBox_playlist.SelectedIndex = curSongIndex;
                }
                else
                {
                    button_next.PerformClick();
                }
            }
            else if (e.newState == 10)
            {

                timer1.Start();

            }
        }

        private void listBox_playlist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectSong();
            playCurrentSong();

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}