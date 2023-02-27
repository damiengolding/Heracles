/* 
   Copyright (C) codepoet
   
   This is free software; you can redistribute it and/or
   modify it under the terms of the GNU Library General Public
   License as published by the Free Software Foundation; either
   version 2 of the License, or (at your option) any later version.
   
   This library is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
   Library General Public License for more details.
   
   You should have received a copy of the GNU Library General Public
   License along with this software; if not, write to the Free
   Software Foundation, Inc., 59 Temple Place - Suite 330, Boston,
   MA 02111-1307, USA

  Don't use it to find and eat babies ... unless you're really REALLY hungry ;-)

*/

using System.Security.Cryptography;

namespace Athena
{
    public partial class MainForm
    {
        private void NewMenuClicked(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Athena project files (*.db) | *.db";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ProjectCreated?.Invoke(sender, new MainFormEventArgs(sfd.FileName));
            }

        }

        private void OpenFileClicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Athena project files (*.db) | *.db";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void ExitMenuClicked(object sender, EventArgs e)
        {
            if (TidyUp()) System.Windows.Forms.Application.Exit();
        }

        private void AboutAthenaClicked(object sender, EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog();
        }
    }

}