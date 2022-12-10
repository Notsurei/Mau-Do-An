namespace MusicPlayer
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.button_control = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_file_loader = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.trackBar_progress = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_re_load = new System.Windows.Forms.Button();
            this.button_shuffle = new System.Windows.Forms.Button();
            this.listBox_playlist = new System.Windows.Forms.ListBox();
            this.button_close = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // button_control
            // 
            this.button_control.BackColor = System.Drawing.Color.Transparent;
            this.button_control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_control.BackgroundImage")));
            this.button_control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_control.Location = new System.Drawing.Point(367, 307);
            this.button_control.Name = "button_control";
            this.button_control.Size = new System.Drawing.Size(75, 64);
            this.button_control.TabIndex = 0;
            this.button_control.Text = "\r\n";
            this.button_control.UseVisualStyleBackColor = false;
            this.button_control.Click += new System.EventHandler(this.control_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_next.BackgroundImage")));
            this.button_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_next.Location = new System.Drawing.Point(448, 322);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(78, 49);
            this.button_next.TabIndex = 1;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.BackColor = System.Drawing.Color.Transparent;
            this.button_prev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_prev.BackgroundImage")));
            this.button_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_prev.Location = new System.Drawing.Point(283, 322);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(78, 49);
            this.button_prev.TabIndex = 2;
            this.button_prev.UseVisualStyleBackColor = false;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_file_loader
            // 
            this.button_file_loader.BackColor = System.Drawing.Color.Transparent;
            this.button_file_loader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_file_loader.BackgroundImage")));
            this.button_file_loader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_file_loader.Location = new System.Drawing.Point(716, 3);
            this.button_file_loader.Name = "button_file_loader";
            this.button_file_loader.Size = new System.Drawing.Size(37, 32);
            this.button_file_loader.TabIndex = 3;
            this.button_file_loader.Text = "\r\n";
            this.button_file_loader.UseVisualStyleBackColor = false;
            this.button_file_loader.Click += new System.EventHandler(this.FileLoader);
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.BackColor = System.Drawing.Color.Black;
            this.trackBar_volume.Location = new System.Drawing.Point(634, 343);
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(60, 45);
            this.trackBar_volume.TabIndex = 5;
            this.trackBar_volume.Scroll += new System.EventHandler(this.trackBar_volume_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "00:00";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 348);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "00:00";
            // 
            // trackBar_progress
            // 
            this.trackBar_progress.BackColor = System.Drawing.Color.Black;
            this.trackBar_progress.Location = new System.Drawing.Point(128, 377);
            this.trackBar_progress.Name = "trackBar_progress";
            this.trackBar_progress.Size = new System.Drawing.Size(575, 45);
            this.trackBar_progress.TabIndex = 8;
            this.trackBar_progress.Scroll += new System.EventHandler(this.trackBar_progress_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(568, 348);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Volume:50%";
            // 
            // button_re_load
            // 
            this.button_re_load.BackColor = System.Drawing.Color.Transparent;
            this.button_re_load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_re_load.BackgroundImage")));
            this.button_re_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_re_load.Location = new System.Drawing.Point(247, 343);
            this.button_re_load.Name = "button_re_load";
            this.button_re_load.Size = new System.Drawing.Size(30, 28);
            this.button_re_load.TabIndex = 10;
            this.button_re_load.UseVisualStyleBackColor = false;
            this.button_re_load.Click += new System.EventHandler(this.button_re_load_Click);
            // 
            // button_shuffle
            // 
            this.button_shuffle.BackColor = System.Drawing.Color.Transparent;
            this.button_shuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_shuffle.BackgroundImage")));
            this.button_shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_shuffle.Location = new System.Drawing.Point(532, 343);
            this.button_shuffle.Name = "button_shuffle";
            this.button_shuffle.Size = new System.Drawing.Size(30, 28);
            this.button_shuffle.TabIndex = 11;
            this.button_shuffle.UseVisualStyleBackColor = false;
            this.button_shuffle.Click += new System.EventHandler(this.button_shuffle__Click);
            // 
            // listBox_playlist
            // 
            this.listBox_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox_playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_playlist.FormattingEnabled = true;
            this.listBox_playlist.Location = new System.Drawing.Point(1, 3);
            this.listBox_playlist.Name = "listBox_playlist";
            this.listBox_playlist.Size = new System.Drawing.Size(190, 91);
            this.listBox_playlist.TabIndex = 13;
            this.listBox_playlist.SelectedIndexChanged += new System.EventHandler(this.listBox_playlist_SelectedIndexChanged_1);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_close.Location = new System.Drawing.Point(759, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(33, 32);
            this.button_close.TabIndex = 14;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(638, -18);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(10, 10);
            this.player.TabIndex = 12;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(33, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 12);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "Danh sách nhạc";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.listBox_playlist);
            this.Controls.Add(this.player);
            this.Controls.Add(this.button_shuffle);
            this.Controls.Add(this.button_re_load);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.trackBar_progress);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar_volume);
            this.Controls.Add(this.button_file_loader);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_progress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_control;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_file_loader;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TrackBar trackBar_progress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_re_load;
        private System.Windows.Forms.Button button_shuffle;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox listBox_playlist;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox4;
    }
}

