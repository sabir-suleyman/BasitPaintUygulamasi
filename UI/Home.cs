﻿using Esgis_Paint.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esgis_Paint
{
    public partial class Home : Form
    {
        Journal log;

        public Home()
        {
            InitializeComponent();
            log = new Journal();
            log.WriteToLogFile("connect");
        }

        #region Events
        

        private void Home_Shown(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }


        #region MenuTooltip

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void nouveauDessinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDrawWindows();
        }

        private void ouvrirUneImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPicture();
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenJournal();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisconnectApp();
        }
        #endregion

        #region Buttons 

        private void btn_new_Click(object sender, EventArgs e)
        {
            OpenDrawWindows();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            OpenJournal();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DisconnectApp();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenPicture();
        }

        #endregion

        #endregion


        #region Requires methods


        private void OpenDrawWindows()
        {
            drawPic draw_Windows = new drawPic();
            draw_Windows.Show();
        }

        private void OpenPicture()
        {
            OpenFileDialog OpenFile_dialog = new OpenFileDialog();
            OpenFile_dialog.Title = "Choose a picture";
            OpenFile_dialog.Multiselect = false;

            // Set filter options and filter index.
            OpenFile_dialog.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            //Open the file dialog
            if (OpenFile_dialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo choice_info = new FileInfo(OpenFile_dialog.FileName);

                //Calling modifyPic and sending to it the picture info
                editPic modifPage = new editPic();
                modifPage.getImage(choice_info);
                modifPage.Show();
            }
        }


        private void OpenJournal()
        {
            log.openLogFile();
        }

   
        private void DisconnectApp()
        {
            DialogResult exitresult = MessageBox.Show("Paint uygulamasını kapatmak istediğinizden emin misiniz?", "Çıkış ? ", MessageBoxButtons.YesNo);

            if (exitresult == DialogResult.Yes)
            {
                log.WriteToLogFile("disconnect");
                Dispose();
            }
        }


        #endregion

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            DisconnectApp();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
