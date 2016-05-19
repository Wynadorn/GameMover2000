using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.InteropServices;

namespace GameMover2000
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymbolicLink dwFlags);
        enum SymbolicLink
        {
            File = 0,
            Directory = 1
        }

        private Location location1;
        private Location location2;

        public Form1()
        {
            InitializeComponent();

            location1 = new Location(tb_pathLoc1, lb_loc1, lbl_loc1Folder);
            location2 = new Location(tb_pathLoc2, lb_loc2, lbl_loc2Folder);

            setDefaults();    
        }

        private void setDefaults()
        {
            //Get the names and number of logical drives
            string[] logicalDrives = Directory.GetLogicalDrives();

            //If there's more than just 1 drive
            if (logicalDrives.Length >= 1)
            {
                //Set the 2nd location to the 2nd drive
                location2.setLocation(logicalDrives[1] + "Games");
            }
            else
            {
                location2.setLocation(logicalDrives[0]);
            }
            location1.setLocation(logicalDrives[0]+ "Games");
            
        }

        private void lb_loc1_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if(lb_loc1.SelectedItem != null)
            {
                if(listBox.SelectedItem.ToString() == "..")
                {
                    location1.goToParent();
                }
                else
                {
                    location1.appendLocation(listBox.SelectedItem.ToString());
                }
            }
        }

        private void lb_loc2_DoubleClick(object sender, EventArgs e)
        {
            if (lb_loc2.SelectedItem != null)
            {
                ListBox listBox = (ListBox)sender;
                if(listBox.SelectedItem.ToString() == "..")
                {
                    location2.goToParent();
                }
                else
                {
                    location2.appendLocation(listBox.SelectedItem.ToString());
                }
            }
        }

        private void tb_pathLoc1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(location1.setLocation(tb_pathLoc1.Text))
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    tb_pathLoc1.Text = location1.getPath();
                }
                tb_pathLoc1.SelectionStart = tb_pathLoc1.Text.Length;
            }
        }

        private void btn_refreshLoc1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_refreshLoc2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            location1.setLocation(location1.getPath());
            location2.setLocation(location2.getPath());
        }

        private void tb_pathLoc2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (location2.setLocation(tb_pathLoc2.Text))
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    tb_pathLoc2.Text = location2.getPath();
                }
                tb_pathLoc2.SelectionStart = tb_pathLoc2.Text.Length;
            }
        }

        private void btn_toRight_Click(object sender, EventArgs e)
        {
            if (lb_loc1.SelectedItem != null && lb_loc1.SelectedItem.ToString() != "..")
            {
                //Directory exists
                if (Directory.Exists(location1.getPath() + lb_loc1.SelectedItem.ToString()))
                {
                    //Directory does not exist on location2
                    if (!Directory.Exists(location2.getPath() + lb_loc1.SelectedItem.ToString()))
                    {
                        FileSystem.MoveDirectory(location1.getPath() + lb_loc1.SelectedItem.ToString(),
                                                 location2.getPath() + lb_loc1.SelectedItem.ToString(),
                                                 UIOption.AllDialogs
                                                );
                        CreateSymbolicLink(location1.getPath() + lb_loc1.SelectedItem.ToString(),
                                           location2.getPath() + lb_loc1.SelectedItem.ToString(),
                                           SymbolicLink.Directory
                                          );

                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Directory already exists in location 2.");
                    }
                }
                else
                {
                    MessageBox.Show("Directory not found.");
                }
            }
            else
            {
                MessageBox.Show("Tried to copy nothing or \"..\"");
            }
        }

        private void btn_toLeft_Click(object sender, EventArgs e)
        {
            //If the selected item is valid
            if (lb_loc2.SelectedItem != null && lb_loc2.SelectedItem.ToString() != "..")
            {
                //If the selected directory exists on loc 2
                if(Directory.Exists(location2.getPath() + lb_loc2.SelectedItem.ToString()))
                {
                    //If directory exists on loc 1
                    if (Directory.Exists(location1.getPath() + lb_loc2.SelectedItem.ToString()))
                    {
                        //If the directory in loc 1 is a system link
                        if(new DirectoryInfo(location1.getPath() + lb_loc2.SelectedItem.ToString()).Attributes.HasFlag(FileAttributes.ReparsePoint))
                        {
                            FileSystem.DeleteDirectory(location1.getPath() + lb_loc2.SelectedItem.ToString(), Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty);
                            FileSystem.MoveDirectory(location2.getPath() + lb_loc2.SelectedItem.ToString(),
                                                     location1.getPath() + lb_loc2.SelectedItem.ToString(),
                                                     UIOption.AllDialogs
                                                    );
                            refresh();
                        }
                    }
                }
                else
                {

                }
             }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximised = true;
                Properties.Settings.Default.Minimised = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = Location;
                Properties.Settings.Default.Size = Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = false;
            }
            else
            {
                Properties.Settings.Default.Location = RestoreBounds.Location;
                Properties.Settings.Default.Size = RestoreBounds.Size;
                Properties.Settings.Default.Maximised = false;
                Properties.Settings.Default.Minimised = true;
            }
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Maximised)
            {
                WindowState = FormWindowState.Maximized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
            else if (Properties.Settings.Default.Minimised)
            {
                WindowState = FormWindowState.Minimized;
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
            else
            {
                Location = Properties.Settings.Default.Location;
                Size = Properties.Settings.Default.Size;
            }
        }
    }
}
