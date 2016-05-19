using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameMover2000
{
    class Location
    {
        private TextBox tb_location;
        private ListBox lb_location;
        private Label lbl_folder;
        private string location;

        public Location(TextBox tb_location, ListBox lb_location, Label lbl_folder)
        {
            this.tb_location = tb_location;
            this.lb_location = lb_location;
            this.lbl_folder = lbl_folder;
        }

        public bool setLocation(string path)
        {
            if(path.Substring(path.Length-1, 1) != "\\")
            {
                path += "\\";
            }

            if(validateLocation(path))
            {
                try
                {
                    //Update the ListBox
                    updateListBox(path);
                    //Update the TextBox
                    tb_location.Text = path;
                    //Update the folder label
                    lbl_folder.Text = getParrentName(path) + "    —    " + getFreeSpace(path) + " GB free";
                    //Set the path
                    this.location = path;

                    return true;
                }
                catch(UnauthorizedAccessException)
                {
                    MessageBox.Show("Holy Fuck!!1\nAcess Denied\nRestart as admin pls!", "oh noes");
                    return false;
                }
            }
            return false;
        }

        private void updateListBox(string path)
        {
            DirectoryInfo[] folders = new DirectoryInfo(path).GetDirectories();
            IEnumerable<DirectoryInfo> noHidden = folders.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
            IEnumerable<DirectoryInfo> noLink = noHidden.Where(f => !f.Attributes.HasFlag(FileAttributes.ReparsePoint));
            IEnumerable<string> noPath = noLink.Select(f => Path.GetFileName(f.ToString()));

            lb_location.BeginUpdate();
            lb_location.Items.Clear();
            lb_location.Items.AddRange(noPath.ToArray());
            if (Directory.GetParent(path) != null)
            {
                lb_location.Items.Insert(0, "..");
            }
            lb_location.EndUpdate();
        }

        public bool appendLocation(string path)
        {
            string newLocation = this.location + path;
            if(validateLocation(newLocation))
            {
                return this.setLocation(newLocation);
            }
            return false;
        }

        private bool validateLocation(string path)
        {
            return Directory.Exists(path);
        }

        public string getPath()
        {
            return location;
        }

        public void goToParent()
        {
            DirectoryInfo di = new DirectoryInfo(this.location);
            this.setLocation(di.Parent.FullName);
        }

        private decimal getFreeSpace(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if ((drive.IsReady) && (drive.Name == driveName.Split('\\')[0]+"\\"))
                {
                    return Math.Round((decimal)drive.TotalFreeSpace/1073741824, 1);
                }
            }
            return -1;
        }

        private string getParrentName(string path)
        {
            return path.Split('\\')[(path.Split('\\').Length-2)];
        }
    }
}
