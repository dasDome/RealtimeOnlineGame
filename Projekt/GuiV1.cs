using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace Projekt
{
    public delegate void emptyFunction();
    public delegate void helpFunction();
    public delegate void dragonFunction();
    public partial class GuiV1 : Form
    {
        private IContainer components = null;
        private Panel map;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private String s = "";
        private Connector c;
        //public List<PictureBox> picBoxListPlayer = new List<PictureBox>();
        public Dictionary<int, PictureBox> picBoxListPlayer = new Dictionary<int, PictureBox>();
        public PictureBox tempPlayerBox = new PictureBox()
            {
                BackColor = System.Drawing.Color.Transparent,
                Location = new System.Drawing.Point(0,0),
                Name = "playerBox",
                Size = new System.Drawing.Size(24, 24),
                TabIndex = 4,
                TabStop = false,
                ImageLocation = "figur-front.gif"
            };
        //List<PictureBox> picBoxListDragon
        public Dictionary<int, PictureBox> picBoxListDragon = new Dictionary<int, PictureBox>();
        PictureBox tempDragonBox = new PictureBox()
            {
                BackColor = System.Drawing.Color.Transparent,
                Location = new System.Drawing.Point(0, 0),
                Name = "dragonBox",
                Size = new System.Drawing.Size(24, 24),
                TabIndex = 4,
                TabStop = false,
                ImageLocation = "draqgon2.gif"
            };
        public List<Panel> picBoxList = new List<Panel>();
        public event KeyEventHandler KeyDown;
        int xmap = 0;
        int ymap = 0;
        int Pxmap = 0;
        int Pymap = 0;
        int Pid;
        int Did;
        private Label Koordinaten;
        private Boolean tf1Enabled = true;

        public GuiV1()
        {
            InitializeComponent();
            InitializeControls();
            c = new Connector(this);
            textBox1.WordWrap = false;
            textBox1.Multiline = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.map = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Koordinaten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.AutoScroll = true;
            this.map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.map.Location = new System.Drawing.Point(210, 12);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(500, 500);
            this.map.TabIndex = 0;
            this.map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.map_MouseDown);
            this.map.MouseEnter += new System.EventHandler(this.map_MouseEnter);
            this.map.MouseHover += new System.EventHandler(this.map_MouseHover);
            this.map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map_MouseMove);
            this.map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.map_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(210, 530);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(500, 140);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 676);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 20);
            this.textBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "msg";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 676);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "cmd";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Koordinaten
            // 
            this.Koordinaten.AutoSize = true;
            this.Koordinaten.Location = new System.Drawing.Point(12, 699);
            this.Koordinaten.Name = "Koordinaten";
            this.Koordinaten.Size = new System.Drawing.Size(0, 13);
            this.Koordinaten.TabIndex = 3;
            // 
            // GuiV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(904, 721);
            this.Controls.Add(this.Koordinaten);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.map);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "GuiV1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GuiV1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void InitializeControls()
        {
            
            //textBox1.KeyDown += new KeyEventHandler(key_down);
            //this.KeyPress += new KeyPressEventHandler(key_press);
            //KeyDown += new KeyEventHandler(key_down);
            button1.Text = "msg!";
            button1.Click += new EventHandler(button1_Click);
            button2.Text = "cmd!";
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
        }

        private void GuiV1_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(key_down);
        }

        private void map_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sender s = getConnector().getSender();
            s.sendtext("ask:say:"+textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sender s = getConnector().getSender();
            s.sendtext(textBox2.Text);
        }
        private Connector getConnector ()
        {
            return c;
        }

        public void setTextBox1(String s)
        {
            Thread x = new Thread(new ThreadStart(thread_startmsg));
            x.IsBackground = true;
            x.Start();
            this.s = s;
        }

        public void setTextBox2(String s)
        {
            textBox2.Text += s;
        }

        public void setPlayerPanel(Player p)
        {
            Thread x = new Thread(new ThreadStart(thread_start));
            x.IsBackground = true;
            x.Start();
            /*tempPlayerBox = new PictureBox()
            {
                BackColor = System.Drawing.Color.Transparent,
                Location = new System.Drawing.Point(0, 0),
                Name = "playerBox" + p.getX() + p.getY(),
                Size = new System.Drawing.Size(24, 24),
                TabIndex = 4,
                TabStop = false,
                ImageLocation = "figur-front.gif"
            };*/
            if (picBoxListPlayer.ContainsKey(p.getId()))
            {

            }
            else
            {
                picBoxListPlayer.Add(p.getId(), new PictureBox()
                {
                    BackColor = System.Drawing.Color.Transparent,
                    Location = new System.Drawing.Point(0, 0),
                    Name = "playerBox",
                    Size = new System.Drawing.Size(24, 24),
                    TabIndex = 4,
                    TabStop = false,
                    ImageLocation = "figur-front.gif",
                    SizeMode = PictureBoxSizeMode.Zoom
                });
            }

            Pxmap = p.getX();
            Pymap = p.getY();
            Pid = p.getId();
            tempPlayerBox.SizeMode = PictureBoxSizeMode.Zoom;
            //picBoxListPlayer.Add(tempPlayerBox);
        }

        public void setDragonPanel (Dragon d)
        {
            Thread x = new Thread(new ThreadStart(thread_startd));
            x.IsBackground = true;
            x.Start();

            if (picBoxListDragon.ContainsKey(d.getId()))
            {

            }
            else
            {
                picBoxListDragon.Add(d.getId(), new PictureBox()
                {
                    BackColor = System.Drawing.Color.Transparent,
                    Location = new System.Drawing.Point(0, 0),
                    Name = "dragonBox",
                    Size = new System.Drawing.Size(24, 24),
                    TabIndex = 4,
                    TabStop = false,
                    ImageLocation = "draqgon2.gif",
                    SizeMode = PictureBoxSizeMode.Zoom
                });
            }

            Did = d.getId();
            /*
            picBoxListDragon = new List<PictureBox>();
            tempDragonBox = new PictureBox()
            {
                BackColor = System.Drawing.Color.Transparent,
                Location = new System.Drawing.Point(0, 0),
                Name = "dragonBox" + d.getX() + d.getY(),
                Size = new System.Drawing.Size(24, 24),
                TabIndex = 4,
                TabStop = false,
                ImageLocation = "draqgon2.gif"
            };*/
            xmap = d.getX();
            ymap = d.getY();
            tempDragonBox.SizeMode = PictureBoxSizeMode.Zoom;
            //picBoxListDragon.Add(tempDragonBox);
        }

        public void setMapPanel(Map map2)
        {
            int i = 0;
            int j = 0;
            List<List<Mapcell>> cells = map2.getCells();
            for (i = 0; i < map2.getWidth(); i++)
            {
                for (j = 0; j < map2.getHeight(); j++)
                {
                    String img = cells[i][j].getProp();
                    String name="";
                    string pattern = @",";
                    Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                    if (rgx.IsMatch(img))
                    {
                        String[] imgary = img.Split(',');
                        if(imgary[1]=="WALKABLE")
                            name = imgary[0];
                        else
                            name = imgary[0]+"-nowalk";
                        
                    }
                    if(name=="")
                    {
                        name = img;
                        if (name == "WALKABLE")
                        {
                            name = "normal";
                        }
                    }
                    //Console.WriteLine("###"+name+"###");
                    Bitmap bmp = new Bitmap(name + ".jpg");
                    Panel tempPictureBox = new Panel()
                    {
                        Location = new System.Drawing.Point((i * 24) + 1, (j * 24) + 1),
                        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom,
                        Name = "pictureBox" + i +"|"+ j,
                        Size = new System.Drawing.Size(25, 25),
                        TabIndex = 3,
                        TabStop = false,
                        BackgroundImage=bmp
                    };
                    tempPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.map_MouseDown);
                    picBoxList.Add(tempPictureBox);
                    map.Controls.Add(tempPictureBox);
                }
            
            }

        }



        public Boolean swapEnabled()
        {
            if (tf1Enabled == true)
            {
                tf1Enabled = false;
            }
            else
            {
                tf1Enabled = true;
                textBox2.Enabled = true;
                textBox2.Select();
                textBox2.Text = "";
            }
            return tf1Enabled;
        }
        

        public void key_down(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.textBox2.Enabled = swapEnabled();
            }
            if ((e.KeyChar.Equals('w') || e.KeyChar.Equals('W')) && tf1Enabled==false)
            {
                Sender s = getConnector().getSender();
                s.sendtext("ask:mv:up");
            }
            if ((e.KeyChar.Equals('a') || e.KeyChar.Equals('A')) && tf1Enabled==false)
            {
                Sender s = getConnector().getSender();
                s.sendtext("ask:mv:lft");
            }
            if ((e.KeyChar.Equals('s') || e.KeyChar.Equals('S')) && tf1Enabled == false)
            {
                Sender s = getConnector().getSender();
                s.sendtext("ask:mv:dwn");
            }
            if ((e.KeyChar.Equals('d') || e.KeyChar.Equals('D')) && tf1Enabled == false)
            {
                Sender s = getConnector().getSender();
                s.sendtext("ask:mv:rgt");
            }
        }



        private void map_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) 
        {


        }

        private void map_MouseEnter(object sender, System.EventArgs e) 
        {

        }
        private void map_MouseHover(object sender, System.EventArgs e) 
        {

        }
        private void map_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
           
        }
        private void map_MouseLeave(object sender, System.EventArgs e) 
        {
            
        }
        private void map_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path with the mouse information
            Point mouseDownLocation = new Point(e.X, e.Y);
            Point p = new Point(e.X, e.Y);
            Panel b = (Panel)sender;
            
            String[] coords = b.Name.Replace("pictureBox", "").Split('|');
            Koordinaten.Text = b.Name.Replace("pictureBox", "");
            //int tempo = int.Parse(b.Name.Replace("pictureBox", ""));
        }












        private void thread_startmsg()
        {
            Invoke(new emptyFunction(delegate() { textBox1.Text += (s + "\r\n"); }));
        }
        private void thread_start()
        {
            Invoke(new helpFunction(delegate()
            {
                //picBoxListPlayer.Add(tempPlayerBox);
                int ind = Pxmap * 20 + Pymap;
                //Console.WriteLine("BGIMAGE: " + picBoxList[ind].Name + " type: " + picBoxList[22].GetType());
                //this.picBoxList[ind].Controls.Remove(tempPlayerBox);
                
                this.picBoxList[ind].Controls.Add(picBoxListPlayer[Pid]);
                //tempPlayerBox.Location = new Point(300,200);// this.tempPlayerBox.Location.Y + 24);
                //this.Controls.Add(trans);
                //tempPlayerBox.BringToFront();
            }));
        }
        private void thread_startd()
        {
            Invoke(new dragonFunction(delegate()
            {
                //picBoxListDragon.Add(tempDragonBox);
                int ind = xmap * 20 + ymap;
                this.picBoxList[ind].Controls.Add(picBoxListDragon[Did]);
                //map.Controls.Add(tempDragonBox);
                //tempDragonBox.BringToFront();
            }));
        }
    }
}
