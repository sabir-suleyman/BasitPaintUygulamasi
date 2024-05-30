using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esgis_Paint.Models
{
    class Journal
    {
        const string CONNECT_ACTION = "connect";
        const string DISCONNECT_ACTION = "disconnect";
        const string PIC_SAVE_ACTION = "pic_save";
        const string PRINT_ACTION = "print";

        String _separator;
        String _filePath;
        StreamWriter _writer;

        public Journal()
        {
            _separator = " --> ";
            _filePath = @"log.txt";

            if (!File.Exists(_filePath))
                WriteHead();
        }


        public void WriteToLogFile(string action)
        {
            String data;

            switch (action)
            {
                case CONNECT_ACTION:
                    data = "Esgis_Paint started.";
                    InsertToLogFile(data);
                    break;
                case DISCONNECT_ACTION:
                    data = "Esgis_Paint closed.";
                    InsertToLogFile(data);
                    Console.WriteLine(" ");
                    break;
                default:
                    break;
            }
        }



        public void WriteToLogFile(string action, string path)
        {
            String data;

            switch (action)
            {
                case PIC_SAVE_ACTION:
                    data = "Picture " + path + " saved ";
                    InsertToLogFile(data);
                    break;
                case PRINT_ACTION:
                    data = "Picture " + path + " printed ";
                    InsertToLogFile(data);
                    break;
                default:
                    break;
            }
        }

        public void openLogFile()
        {
            System.Diagnostics.Process.Start(_filePath);
        }


        private void WriteHead()
        {
            String head = "DATE      " + " HOUR         " + "ACTION";
            String underline = "----      " + " ----         " + "------";
            try
            {
                using (_writer = new StreamWriter(_filePath, true))
                {
                    _writer.WriteLine(underline);
                    _writer.WriteLine(head);
                    _writer.WriteLine(underline);
                }
            }
            catch (Exception e)
            {
                String error_message = "Failed to write in the log file. Details : " + e;
                System.Windows.Forms.MessageBox.Show(error_message);
            }
        }


        private void InsertToLogFile(String line)
        {


            DateTime currentTime = DateTime.Now;

            try
            {
                using (_writer = new StreamWriter(_filePath, true))
                {
                    _writer.Write(currentTime.ToString() + _separator);
                    _writer.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                String error_message = "Failed to write in the log file. Details : " + e;
                System.Windows.Forms.MessageBox.Show(error_message, "ERROR !");
            }
        }
    }
}
