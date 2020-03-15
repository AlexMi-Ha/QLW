using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLW {
    public partial class Main : Form {

        public Main() {
            InitializeComponent();
        }

        private void LoadFrame(object sender, EventArgs e) {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int x = width - this.Width;
            Location = new Point(x / 2, 10);

            InitIcons();
            InitNameText();
        }


        private Point mouseOffset;
        private void OnMouseDown(object sender, MouseEventArgs e) {
            // Get offset to origin on mouse press
            mouseOffset = new Point(-e.X, -e.Y);
        }

        private void OnMouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                // move the frame on drag
                Point mousePos = Control.MousePosition;
                //offset it by the mouseOffset 
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }


        private void OnClickWidget(object sender, EventArgs e) {
            Button btn = (Button)sender;
            //open Widget page
            if(btn.Tag.ToString().Equals("1"))
                System.Diagnostics.Process.Start(Properties.Settings.Default.URL1);
            else if (btn.Tag.ToString().Equals("2"))
                System.Diagnostics.Process.Start(Properties.Settings.Default.URL2);
            else if (btn.Tag.ToString().Equals("3"))
                System.Diagnostics.Process.Start(Properties.Settings.Default.URL3);
            else if (btn.Tag.ToString().Equals("4"))
                System.Diagnostics.Process.Start(Properties.Settings.Default.URL4);
        }

        //-----------------Widget 1-------------------

        private void editPage_W1(object sender, EventArgs e) {
            //Edit page to open
            String URL = newPageText(Properties.Settings.Default.URL1);
            if (URL != null) {
                Properties.Settings.Default.URL1 = URL;
                Properties.Settings.Default.Save();
            }
        }

        private void newImage_W1(object sender, EventArgs e) {
            //get New Image
            Image img = setNewImage();
            if (img != null) {
                img.Save("1.png", System.Drawing.Imaging.ImageFormat.Png);
                Image loaded = new Bitmap(img);
                btnW1.Image = loaded;
                img.Dispose();
            }
        }

        private void resetImage_W1(object sender, EventArgs e) {
            //reset the Image
            Console.WriteLine("Reset Image at W1");
            btnW1.Image = QLW.Properties.Resources.widget1;
            File.Delete("1.png");
        }

        private void rename_W1(object sender, EventArgs e) {
            //rename the Button description
            String name = renameName(Properties.Settings.Default.NAME1);
            if (name != null) {
                Properties.Settings.Default.NAME1 = name;
                Properties.Settings.Default.Save();
                if (name.Length > 14) {
                    name = name.Substring(0, 14) + "...";
                }
                name_W1.Text = name;
            }
        }

        //----------------------Widget 2----------------------------


        private void editPage_W2(object sender, EventArgs e) {
            //Edit page to open
            String URL = newPageText(Properties.Settings.Default.URL2);
            if (URL != null) {
                Properties.Settings.Default.URL2 = URL;
                Properties.Settings.Default.Save();
            }
        }

        private void newImage_W2(object sender, EventArgs e) {
            //get New Image
            Image img = setNewImage();
            if (img != null) {
                img.Save("2.png", System.Drawing.Imaging.ImageFormat.Png);
                Image loaded = new Bitmap(img);
                btnW2.Image = loaded;
                img.Dispose();
            }
        }

        private void resetImage_W2(object sender, EventArgs e) {
            //reset the Image
            btnW2.Image = QLW.Properties.Resources.widget2;
            File.Delete("2.png");
        }

        private void rename_W2(object sender, EventArgs e) {
            //rename the Button description
            String name = renameName(Properties.Settings.Default.NAME2);
            if (name != null) {
                Properties.Settings.Default.NAME2 = name;
                Properties.Settings.Default.Save();
                if (name.Length > 14) {
                    name = name.Substring(0, 14) + "...";
                }
                name_W2.Text = name;
            }
        }
        //-----------------------------Widget 3-----------------------


        private void editPage_W3(object sender, EventArgs e) {
            //Edit page to open
            String URL = newPageText(Properties.Settings.Default.URL3);
            if (URL != null) {
                Properties.Settings.Default.URL3 = URL;
                Properties.Settings.Default.Save();
            }
        }

        private void newImage_W3(object sender, EventArgs e) {
            //get New Image
            Image img = setNewImage();
            if (img != null) {
                img.Save("3.png", System.Drawing.Imaging.ImageFormat.Png);
                Image loaded = new Bitmap(img);
                btnW3.Image = loaded;
                img.Dispose();
            }
        }

        private void resetImage_W3(object sender, EventArgs e) {
            //reset the Image
            btnW3.Image = QLW.Properties.Resources.widget3;
            File.Delete("3.png");
        }

        private void rename_W3(object sender, EventArgs e) {
            //rename the Button description
            String name = renameName(Properties.Settings.Default.NAME3);
            if (name != null) {
                Properties.Settings.Default.NAME3 = name;
                Properties.Settings.Default.Save();
                if (name.Length > 14) {
                    name = name.Substring(0, 14) + "...";
                }
                name_W3.Text = name;
            }
        }
        //---------------------Widget 4-------------------------------

        private void editPage_W4(object sender, EventArgs e) {
            //Edit page to open
            String URL = newPageText(Properties.Settings.Default.URL4);
            if (URL != null) {
                Properties.Settings.Default.URL4 = URL;
                Properties.Settings.Default.Save();
            }
        }

        private void newImage_W4(object sender, EventArgs e) {
            //get New Image
            Image img = setNewImage();
            if (img != null) {
                img.Save("4.png", System.Drawing.Imaging.ImageFormat.Png);
                Image loaded = new Bitmap(img);
                btnW4.Image = loaded;
                img.Dispose();
            }
        }

        private void resetImage_W4(object sender, EventArgs e) {
            //reset the Image
            btnW4.Image = QLW.Properties.Resources.widget4;
            File.Delete("4.png");
        }

        private void rename_W4(object sender, EventArgs e) {
            //rename the Button description
            String name = renameName(Properties.Settings.Default.NAME4);
            if (name != null) {
                Properties.Settings.Default.NAME4 = name;
                Properties.Settings.Default.Save();
                if (name.Length > 14) {
                    name = name.Substring(0, 14) + "...";
                }
                name_W4.Text = name;
            }
        }

        //----------------Other Functions-----------------------------

        private String renameName(String initText) {
            PageDialog d = new PageDialog("Input a new Widget Title");
            d.txtPage.Text = initText;

            if (d.ShowDialog(this) == DialogResult.OK) {
                String name = d.txtPage.Text;
                return name;
            }
            d.Dispose();
            return null;
        }

        private Image setNewImage() {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "image files (*.png)|*.png";
            fd.Title = "Wähle ein Bild aus! (55 x 55 px)";

            if (fd.ShowDialog() == DialogResult.OK) {
                Console.WriteLine("open " + fd.FileName);
            }
            try {
                Image img = Image.FromFile(fd.FileName);
                return img;

            } catch (Exception ex) { Console.WriteLine(ex); }
            return null;
        }

        private String newPageText(String initText) {
            String URL;
            PageDialog d = new PageDialog("Input a URL or a Path");
            d.txtPage.Text = initText;

            if (d.ShowDialog(this) == DialogResult.OK) {
                URL = d.txtPage.Text;
                return URL;
            }
            d.Dispose();
            return null;
        }

        //---------------------init Functions-----------------------------
        private void InitIcons() {
            if (File.Exists("1.png")) {
                FileStream img = new FileStream("1.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Image loaded = new Bitmap(img);
                btnW1.Image = loaded;
                img.Dispose();
            }
            if (File.Exists("2.png")) {
                FileStream img = new FileStream("2.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Image loaded = new Bitmap(img);
                btnW2.Image = loaded;
                img.Dispose();
            }
            if (File.Exists("3.png")) {
                FileStream img = new FileStream("3.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Image loaded = new Bitmap(img);
                btnW3.Image = loaded;
                img.Dispose();
            }
            if (File.Exists("4.png")) {
                FileStream img = new FileStream("4.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Image loaded = new Bitmap(img);
                btnW4.Image = loaded;
                img.Dispose();
            }
        }

        private void InitNameText() {
            if (Properties.Settings.Default.NAME1 != "") {
                if (Properties.Settings.Default.NAME1.Length > 14) {
                    String name = Properties.Settings.Default.NAME1.Substring(0, 14) + "...";
                    name_W1.Text = name;
                } else {
                    name_W1.Text = Properties.Settings.Default.NAME1;
                }
            }
            if (Properties.Settings.Default.NAME2 != "") {
                if (Properties.Settings.Default.NAME2.Length > 14) {
                    String name = Properties.Settings.Default.NAME2.Substring(0, 14) + "...";
                    name_W2.Text = name;
                } else {
                    name_W2.Text = Properties.Settings.Default.NAME2;
                }
            }
            if (Properties.Settings.Default.NAME3 != "") {
                if (Properties.Settings.Default.NAME3.Length > 14) {
                    String name = Properties.Settings.Default.NAME3.Substring(0, 14) + "...";
                    name_W3.Text = name;
                } else {
                    name_W3.Text = Properties.Settings.Default.NAME3;
                }
            }
            if (Properties.Settings.Default.NAME4 != "") {
                if (Properties.Settings.Default.NAME4.Length > 14) {
                    String name = Properties.Settings.Default.NAME4.Substring(0, 14) + "...";
                    name_W4.Text = name;
                } else {
                    name_W4.Text = Properties.Settings.Default.NAME4;
                }
            }
        }
    }
}
