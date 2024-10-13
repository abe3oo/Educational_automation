﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmoozeshPJWinF
{
    public partial class Setting : Form
    {
        string selectedPath = "";
        public Setting()
        {
            InitializeComponent();
            showpath.Text = selectedPath;
        }

        private async void backup(string filepath)
        {
            DBC dBC = new DBC();
            database d1 = new database();
            d1 = dBC.readDBconfigfromIni2("dbconfig.ini");

            string host = d1.host; // آدرس سرور
            string port = d1.port; // پورت دیتابیس
            string databaseName = d1.databaseName; // نام دیتابیس
            string user = d1.user; // نام کاربری
            string password = d1.password; // رمز عبور
            string backupFilePath = filepath;

            // ایجاد فرایند جدید برای اجرای pg_dump
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Program Files\PostgreSQL\16\bin\pg_dump.exe"; // فراخوانی pg_dump
            startInfo.Arguments = $"--file \"{backupFilePath}\" --host {host} --port {port} --username {user} --format=c --large-objects --section=data --verbose \"{databaseName}\"";
            startInfo.EnvironmentVariables["PGPASSWORD"] = password;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = false;

            // ارسال رمز عبور
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            

            // خواندن خروجی‌ها به صورت غیرمسدودکننده
            Task<string> outputTask = process.StandardOutput.ReadToEndAsync();
            Task<string> errorTask = process.StandardError.ReadToEndAsync();

            // منتظر پایان اجرای فرآیند
            await process.WaitForExitAsync();

            // نمایش نتایج
            string result = await outputTask;
            string error = await errorTask;

            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                MessageBox.Show("Backup completed successfully.");
                set.Enabled = false;
                selectedPath = "";
            }
            else
            {
                MessageBox.Show("Backup failed with exit code: " + process.ExitCode);
            }
            //MessageBox.Show($"Result: {result}");
            //MessageBox.Show($"Result: {error}");
        }
        private void set_Click(object sender, EventArgs e)
        {
            string path = $@"{selectedPath}" + "\\sql.sql";
            backup(path);

        }

        private void pathbot_Click(object sender, EventArgs e)
        {
            // ایجاد یک دیالوگ انتخاب پوشه
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // نمایش دیالوگ
                DialogResult result = folderDialog.ShowDialog();

                // اگر کاربر مسیری را انتخاب کرد
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    // انتقال مسیر انتخاب‌شده به متغیر
                    selectedPath = folderDialog.SelectedPath;

                    // نمایش مسیر در یک لیبل
                    showpath.Text = "مسیر: " + selectedPath;
                    set.Enabled = true;
                }
            }
        }
    }
}
