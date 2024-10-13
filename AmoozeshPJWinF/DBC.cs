﻿using Amozesh;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;
using System.Drawing;

namespace AmoozeshPJWinF
{
    internal class DBC
    {
        private string globalcon;
        public Image returnImage;
        
        //"Host=localhost; Port=5432; Username=postgres; password=nazanin1381; database=test"
        //"Host=localhost; Port=5432; Username=postgres; password=Ara41148; database=test"
        public DBC()
        {
            globalcon = ReadDbConfigFromIni("dbconfig.ini");

        }
        public string ReadDbConfigFromIni(string filePath)
        {
            
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(filePath);

                string host = data["Database"]["Host"];
                int port = int.Parse(data["Database"]["Port"]);
                string username = data["Database"]["Username"];
                string password = data["Database"]["Password"];
                string database = data["Database"]["Database"];

                return $"Host={host}; Port={port}; Username={username}; Password={password}; Database={database}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در خواندن فایل کانفیگ !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public database readDBconfigfromIni2(string filePath)
        {
            try
            {
                database d1 = new database();
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(filePath);
                d1.host = data["Database"]["Host"];

                d1.port = Convert.ToString(int.Parse(data["Database"]["Port"]));
                d1.user = data["Database"]["Username"];
                d1.password = data["Database"]["Password"];
                d1.databaseName = data["Database"]["Database"];

                return d1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در خواندن فایل کانفیگ !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void clear_textbox(TextBox t1)
        {
            t1.Text = string.Empty;
        }
        
        public void DisplayAutoCompleteSuggestions(List<string> suggestions, TextBox t1)
        {
            t1.AutoCompleteCustomSource.Clear();
            t1.AutoCompleteCustomSource.AddRange(suggestions.ToArray());
        }
        public bool id_check(string thisid)
        {
            try
            {
                var con = new NpgsqlConnection(connectionString: globalcon);
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM users WHERE id = {thisid};";
                bool msg;
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        msg = true;
                    }
                    else
                    {
                        msg = false;
                    }
                }
                cmd.ExecuteNonQueryAsync();
                return msg;
            }
            catch
            {
                MessageBox.Show("خطا در چک کردن کد ملی !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public bool teacherid_check(string thisid)
        {
            try
            {
                var con = new NpgsqlConnection(connectionString: globalcon);
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM teacher WHERE id = {thisid};";
                bool msg;
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        msg = true;
                    }
                    else
                    {
                        msg = false;
                    }
                }
                cmd.ExecuteNonQueryAsync();
                return msg;
            }
            catch
            {
                MessageBox.Show("خطا در چک کردن کد ملی استاد !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

       


        public bool courseid_check(string thisid)
        {
            try
            {
                var con = new NpgsqlConnection(connectionString: globalcon);
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM course WHERE id = '{thisid}';";
                bool msg;
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        msg = true;
                    }
                    else
                    {
                        msg = false;
                    }
                }
                cmd.ExecuteNonQueryAsync();
                return msg;
            }
            catch
            {
                MessageBox.Show("خطا در چک کردن آی دی کلاس !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
        public bool studentid_check(string thisid)
        {
            try
            {
                var con = new NpgsqlConnection(connectionString: globalcon);
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM student WHERE id = {thisid};";
                bool msg;
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        msg = true;
                    }
                    else
                    {
                        msg = false;
                    }
                }
                cmd.ExecuteNonQueryAsync();
                return msg;
            }
            catch
            {
                MessageBox.Show("خطا در چک کردن کد ملی دانشجو !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }


        public string st_set(student s1)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                string g1;
                string g2;
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                using var cmd2 = new NpgsqlCommand();
                cmd.Connection = con;
                cmd2.Connection = con;
                cmd.CommandText = $"INSERT INTO users(id, firstname, lastname, age, phone_num, whatsapp_num, pict) VALUES ({s1.personalcode}, '{s1.firstname}', '{s1.lastname}', {s1.age}, {s1.number}, {s1.whatsappnumber},@Image);";
                cmd2.CommandText = $"INSERT INTO student(id, level_of_education, fieled_of_study, marital_status, job, city, class_type) VALUES ({s1.personalcode}, {s1.education}, '{s1.fieled_of_study}', {s1.maritalstatus}, '{s1.job}', '{s1.city}', {s1.classtype});";
                NpgsqlParameter param = cmd.CreateParameter();
                param.ParameterName = "@Image";
                param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
                param.Value = s1.profilepicture;
                cmd.Parameters.Add(param);
                g1 = cmd.ExecuteNonQuery().ToString();
                g2 = cmd2.ExecuteNonQuery().ToString();
                con.Close();
                return g1 + g2;
            }
            catch
            {
                MessageBox.Show("خطا در ثبت دانشجو !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "00";
            }
            
        }

        public string st_edit(student s1, string id)
        {
            try
            {
                var con = new NpgsqlConnection(
            connectionString: globalcon);

                string g1 = "";
                string g2 = "";
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                using var cmd2 = new NpgsqlCommand();
                cmd.Connection = con;
                cmd2.Connection = con;
                cmd.CommandText = $"UPDATE users SET id = {s1.personalcode},firstname = '{s1.firstname}',lastname = '{s1.lastname}',age = {s1.age},phone_num = {s1.number},whatsapp_num = {s1.whatsappnumber},pict = @Image WHERE id = {id};";
                cmd2.CommandText = $"UPDATE student SET id = {s1.personalcode},level_of_education = {s1.education},fieled_of_study = '{s1.fieled_of_study}',marital_status = {s1.maritalstatus},job = '{s1.job}',city = '{s1.city}',class_type = {s1.classtype} WHERE id = {id};";
                NpgsqlParameter param = cmd.CreateParameter();
                param.ParameterName = "@Image";
                param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
                param.Value = s1.profilepicture;
                cmd.Parameters.Add(param);
                g1 = cmd.ExecuteNonQuery().ToString();
                g2 = cmd2.ExecuteNonQuery().ToString();
                con.Close();
                return g1 + g2;
            }
            catch
            {
                MessageBox.Show("خطا در ویرایش دانشجو !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "00";
            }
            
        }

        public string pr_set(teacher p1)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);

                string g1;
                string g2;
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                using var cmd2 = new NpgsqlCommand();
                cmd.Connection = con;
                cmd2.Connection = con;
                cmd.CommandText = $"INSERT INTO users(id, firstname, lastname, age, phone_num, whatsapp_num, pict) VALUES ({p1.personalcode}, '{p1.firstname}', '{p1.lastname}', {p1.age}, {p1.number}, {p1.whatsappnumber}, @Image);";
                cmd2.CommandText = $"INSERT INTO teacher VALUES ({p1.personalcode}, '{p1.fieled_of_study}', {p1.degree_of_education}, {p1.presence_record}, '{p1.date_of_entry.Year}-{p1.date_of_entry.Month}-{p1.date_of_entry.Day}');";
                NpgsqlParameter param = cmd.CreateParameter();
                param.ParameterName = "@Image";
                param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
                param.Value = p1.profilepicture;
                cmd.Parameters.Add(param);
                g1 = cmd.ExecuteNonQuery().ToString();
                g2 = cmd2.ExecuteNonQuery().ToString();
                con.Close();
                return g1 + g2;
            }
            catch
            {
                MessageBox.Show("خطا در ثبت استاد !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "00";
            }
            
        }

        public string pr_edit(teacher s1, string id)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);

                string g1 = "";
                string g2 = "";
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                using var cmd2 = new NpgsqlCommand();
                cmd.Connection = con;
                cmd2.Connection = con;
                cmd.CommandText = $"UPDATE users SET id = {s1.personalcode},firstname = '{s1.firstname}',lastname = '{s1.lastname}',age = {s1.age},phone_num = {s1.number},whatsapp_num = {s1.whatsappnumber},pict = @Image WHERE id = {id};";
                cmd2.CommandText = $"UPDATE teacher SET id = {s1.personalcode} ,fieled_of_study = '{s1.fieled_of_study}' ,degree_of_education = {s1.degree_of_education} ,presence_record = {s1.presence_record} ,date_of_entry = '{s1.date_of_entry.Year}-{s1.date_of_entry.Month}-{s1.date_of_entry.Day}' WHERE id = {id};";
                NpgsqlParameter param = cmd.CreateParameter();
                param.ParameterName = "@Image";
                param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
                param.Value = s1.profilepicture;
                cmd.Parameters.Add(param);
                g1 = cmd.ExecuteNonQuery().ToString();
                g2 = cmd2.ExecuteNonQuery().ToString();
                con.Close();
                return g1 + g2;
            }
            catch
            {
                MessageBox.Show("خطا در ویرایش استاد !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "00";
            }
            
        }

        public string pay_set(Payment p1, string sym="+")
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                con.Open();
                string g1 = "";
                string g2 = "";
                using var cmd = new NpgsqlCommand();
                using var cmd2 = new NpgsqlCommand();
                cmd.Connection = con;
                cmd2.Connection = con;
                cmd.CommandText = $"INSERT INTO payment(user_id, date_of_payment, term, amount, transaction_status, tracking_code,tracking_time , description) VALUES ({p1.userid}, '{p1.dateofpayment}', '{p1.term}', {p1.amount}, '{p1.transactionstatus}', '{p1.trackingcode}', '{p1.tarckingtime}' , '{p1.description}');";
                cmd2.CommandText = $"UPDATE users SET account_balance = account_balance {sym} {p1.amount} WHERE id =  {p1.userid};";
                g1 = cmd.ExecuteNonQuery().ToString();
                g2 = cmd2.ExecuteNonQuery().ToString();
                return g1 + g2;
            }
            catch
            {
                MessageBox.Show("خطا در ثبت تراکنش !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }




        }

        public string enrollment_pay(long id, long cost, string sym = "+")
        {
            string g1 = "";
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                con.Open();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                
                cmd.CommandText = $"UPDATE users SET account_balance = account_balance {sym} {cost} WHERE id = {id};";
                g1 = cmd.ExecuteNonQuery().ToString();
                return g1;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "0";
            }


        }

        public string course_set(Course c1)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                con.Open();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO course(id,teacher_id, course_name, cost, date_of_start) VALUES ('{c1.courseid}', {c1.teacherid}, '{c1.coursename}', {c1.cost}, '{c1.dateofstart.Year}-{c1.dateofstart.Month}-{c1.dateofstart.Day}');";
                string result = "";
                result = cmd.ExecuteNonQuery().ToString();
                return result;
            }
            catch
            {
                MessageBox.Show("خطا در ثبت کلاس !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }
            

        }

        public string course_holding_set(Course_holding c1)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                con.Open();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO course_holding(course_id, date_of_sections, teacher_id, holding_status) VALUES ('{c1.courseid}', '{c1.dateOfsection}', {c1.teacherid}, {c1.holding_state});";
                string result = "";
                result = cmd.ExecuteNonQuery().ToString();
                return result;
            }
            catch
            {
                MessageBox.Show("خطا در ثبت جلسات کلاس !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }
            
        }

        public string course_holding_update(string id,DateTime d1, bool b1,DateTime dremedical= default)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);

                string g1 = "";

                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();

                cmd.Connection = con;
                if (b1 == true)
                {
                    cmd.CommandText = $"UPDATE course_holding SET holding_status = {b1}, date_of_remedical = null WHERE course_id = '{id}' and date_of_sections = '{d1}';";
                }
                else if (b1 == false && dremedical == default)
                {
                    cmd.CommandText = $"UPDATE course_holding SET holding_status = {b1}, date_of_remedical = null WHERE course_id = '{id}' and date_of_sections = '{d1}';";
                }
                else
                {
                    cmd.CommandText = $"UPDATE course_holding SET holding_status = {b1}, date_of_remedical = '{dremedical}' WHERE course_id = '{id}' and date_of_sections = '{d1}';";
                }

                g1 = cmd.ExecuteNonQuery().ToString();
                con.Close();
                return g1;
            }
            catch
            {
                MessageBox.Show("خطا در بروزرسانی اطلاعات کلاس !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }
            
        }
        public long get_cost(string id)
        {
            
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            con.Open();
            long cost = 0;
            using var cmd2 = new NpgsqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = $"SELECT cost FROM course WHERE id = '{id}';";
            try
            {
                using (var reader2 = cmd2.ExecuteReader())
                {
                    reader2.Read();

                    cost = Convert.ToInt64(reader2.GetInt64(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cost;
            
        }
        public string enrollment_set(Enrollment e1)
        {
            string g1 = "";
            string g2 = "";
            long cost = 0;
            var con = new NpgsqlConnection(
                connectionString: globalcon);
            con.Open();
            try
            {

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO enrollment(course_id,student_id, whatsapp_gp, date_of_enrollment) VALUES ('{e1.courseid}', {e1.studentid}, '{e1.whatsappgp}','{e1.dateofenrollment}');";
                g1 = cmd.ExecuteNonQuery().ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "0";
            }
            catch
            {

                MessageBox.Show("خطا در ثبت نام !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0";
            }
            cost = get_cost(e1.courseid);
            g2 = enrollment_pay(e1.studentid, cost, "-");
            return g1+ g2;
        }

        public GetStudent St_Reader(string thisid)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                GetStudent s1 = new GetStudent();
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM users WHERE id = {thisid};";


                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    s1.personalcode = Convert.ToString(reader[0]);
                    s1.firstname = Convert.ToString(reader[1]);
                    s1.lastname = Convert.ToString(reader[2]);
                    s1.age = Convert.ToInt32(reader[3]);
                    s1.number = Convert.ToInt64(reader[4]);
                    s1.whatsappnumber = Convert.ToInt64(reader[5]);
                    s1.account_balance = Convert.ToInt64(reader[7]);


                }
                using var cmd2 = new NpgsqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = $"SELECT * FROM student WHERE id = {thisid};";
                using (var reader = cmd2.ExecuteReader())
                {
                    reader.Read();
                    s1.education = Convert.ToInt16(reader[1]);
                    s1.fieled_of_study = Convert.ToString(reader[2]);
                    s1.maritalstatus = Convert.ToBoolean(reader[3]);
                    s1.job = Convert.ToString(reader[4]);
                    s1.city = Convert.ToString(reader[5]);
                    s1.classtype = Convert.ToBoolean(reader[6]);
                }

                return s1;
            }
            catch
            {
                MessageBox.Show("خطا در خواندن اطلاعات دانشجو !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            //cmd.ExecuteNonQueryAsync();
        }

        public GetTeacher Pr_Reader(string thisid)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                GetTeacher p1 = new GetTeacher();
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM users WHERE id = {thisid};";


                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    p1.personalcode = Convert.ToString(reader[0]);
                    p1.firstname = Convert.ToString(reader[1]);
                    p1.lastname = Convert.ToString(reader[2]);
                    p1.age = Convert.ToInt32(reader[3]);
                    p1.number = Convert.ToInt64(reader[4]);
                    p1.whatsappnumber = Convert.ToInt64(reader[5]);
                    p1.account_balance = Convert.ToInt64(reader[7]);
                }
                using var cmd2 = new NpgsqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = $"SELECT * FROM teacher WHERE id = {thisid};";
                using (var reader = cmd2.ExecuteReader())
                {
                    reader.Read();

                    p1.fieled_of_study = Convert.ToString(reader[1]);
                    p1.degree_of_education = Convert.ToInt32(reader[2]);
                    p1.presence_record = Convert.ToInt32(reader[3]);
                    p1.date_of_entry = Convert.ToDateTime(reader[4]);
                }
                con.Close();
                return p1;
            }
            catch
            {
                MessageBox.Show("خطا در خواندن اطلاعات استاد !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            //cmd.ExecuteNonQueryAsync();
        }

        

        public List<string> Course_holding_id_Reader_by_date(DateTime tod)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                List<string> list = new List<string>();

                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();

                cmd.Connection = con;

                cmd.CommandText = $"SELECT course_id FROM course_holding WHERE date_of_sections = '{tod.Year}-{tod.Month}-{tod.Day}';";
                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        string id = Convert.ToString(reader.GetString(0));
                        list.Add(id);
                    }
                }
                return list;
            }
            catch
            {
                MessageBox.Show("خطا در خواندن اطلاعات کلاس !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            //cmd.ExecuteNonQueryAsync();
        }

        public bool check_course_holding_status(string id, DateTime d1)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                bool ids;

                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();

                cmd.Connection = con;
                cmd.CommandText = $"SELECT holding_status FROM course_holding WHERE course_id = '{id}' and date_of_sections = '{d1}';";
                using (var reader = cmd.ExecuteReader())
                {

                    reader.Read();

                    ids = Convert.ToBoolean(reader.GetBoolean(0));
                }
                return ids;
            }
            catch
            {
                MessageBox.Show("خطا در خواندن وضعیت !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public GetCourse GetCourse_Reader_by_id(string id,DateTime d1)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);

                GetCourse g1 = new GetCourse();
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();

                cmd.Connection = con;

                cmd.CommandText = $"SELECT * FROM course WHERE id = '{id}';";
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    g1.آی_دی_کلاس = Convert.ToString(reader.GetString(0));
                    g1.کد_ملی_استاد = Convert.ToInt64(reader.GetInt64(1));
                    g1.نام_کلاس = Convert.ToString(reader.GetString(2));
                    g1.ساعت = Convert.ToString(reader.GetString(0).Substring(4, 2) + ":" + reader.GetString(0).Substring(6, 2));
                }
                using var cmd2 = new NpgsqlCommand();

                cmd2.Connection = con;
                cmd2.CommandText = $"SELECT holding_status FROM course_holding WHERE course_id = '{id}' and date_of_sections = '{d1}';";
                using (var reader = cmd2.ExecuteReader())
                {
                    reader.Read();
                    g1.وضعیت_برگذاری = Convert.ToString(reader.GetBoolean(0));
                }
                return g1;
            }
            catch
            {
                MessageBox.Show("خطا در خواندن اطلاعات کلاس !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            //cmd.ExecuteNonQueryAsync();
        }

        public List<GetTeacher> All_teacher_reader()
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                List<GetTeacher> list = new List<GetTeacher>();
                List<long> ids = new List<long>();

                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM teacher;";
                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {


                        ids.Add(Convert.ToInt64(reader.GetInt64(0)));
                    }
                }
                using var cmd2 = new NpgsqlCommand();
                cmd2.Connection = con;
                foreach (var id in ids)
                {
                    cmd2.CommandText = $"SELECT * FROM users WHERE id = {id};";
                    using (var reader = cmd2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GetTeacher g1 = new GetTeacher();
                            g1.personalcode = id.ToString();
                            g1.firstname = Convert.ToString(reader.GetString(1));
                            g1.lastname = Convert.ToString(reader.GetString(2));
                            list.Add(g1);
                        }
                    }
                }
                return list;
            }
            catch
            {
                MessageBox.Show("خطا در خواندن اطلاعات استاد !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }


        public byte[] ImageToByteArray(System.Drawing.Image img)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(img, typeof(byte[]));
            }
            catch
            {
                MessageBox.Show("خطا در تبدیل فرمت تصویر !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public void SaveImage(Image image, string name)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp";
                    saveFileDialog.Title = "Save an Image File";
                    saveFileDialog.FileName = $"{name}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // تشخیص فرمت تصویر از پسوند فایل
                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1:
                                image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case 2:
                                image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            case 3:
                                image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                        }

                        MessageBox.Show("Image saved successfully!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("خطا در ذخیره تصویر !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //public void testt()
        //{
        //    using (var conn = new NpgsqlConnection(globalcon))
        //    {
        //        string sQL = "insert into picturetable (id, photo) VALUES(65, @Image)";
        //        using (var command = new NpgsqlCommand(sQL, conn))
        //        {
        //            NpgsqlParameter param = command.CreateParameter();
        //            param.ParameterName = "@Image";
        //            param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
        //            param.Value = ImgByteA;
        //            command.Parameters.Add(param);

        //            conn.Open();
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
        public Image pic_reader(string id)
        {
            using (var conn = new NpgsqlConnection(globalcon))
            {
                try
                {


                    string sQL = $"SELECT pict FROM users WHERE id = {id};";
                    using (var command = new NpgsqlCommand(sQL, conn))
                    {
                        byte[] productImageByte = null;
                        conn.Open();
                        var rdr = command.ExecuteReader();
                        if (rdr.Read())
                        {
                            productImageByte = (byte[])rdr[0];
                        }
                        rdr.Close();


                        using (MemoryStream productImageStream = new System.IO.MemoryStream(productImageByte))
                        {
                            ImageConverter imageConverter = new System.Drawing.ImageConverter();
                            try
                            {
                                Image a1 = imageConverter.ConvertFrom(productImageByte) as System.Drawing.Image;
                                if (a1 != null)
                                {
                                    return a1;
                                }
                                else
                                {
                                    a1 = Properties.Resources.nullimage;
                                    return a1;
                                }
                            }
                            catch
                            {
                                Image a1;
                                a1 = Properties.Resources.nullimage;
                                return a1;
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Image a1;
                    a1 = Properties.Resources.nullimage;
                    return a1;
                    
                }
            }
        }

        public DateTime cul_converter(DateTime d1)
        {
            DateTime result1 = new DateTime(1000,01,01);
            try
            {
                PersianCalendar pc = new PersianCalendar();
                DateTime result = new DateTime(pc.GetYear(d1), pc.GetMonth(d1), pc.GetDayOfMonth(d1));

                return result;
            }
            catch
            {
                MessageBox.Show("خطا در تبدیل تاریخ به شمسی !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result1;
            }
            
        }

        public List<DateTime> data_course_creator(DateTime d1, int d)
        {
            try
            {
                List<DateTime> list = new List<DateTime>();
                DateTime dateTime = d1;
                for (int i = 0; i < d; i++)
                {
                    if (i != 0)
                    {
                        dateTime = dateTime.AddDays(7);

                        list.Add(dateTime);
                    }
                    else
                    {
                        list.Add(dateTime);
                    }
                }
                return list;
            }
            catch
            {
                MessageBox.Show("خطا در تشکیل تاریخ های کلاس !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }
        public List<string> get_all_users()
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                string p1 = "";
                string p11 = "";
                List<string> p2 = new List<string>();
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT id, firstname, lastname FROM users;";


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        p1 = Convert.ToString(reader.GetInt64(0)) + " " + Convert.ToString(reader.GetString(1) + " " + Convert.ToString(reader.GetString(2)));
                        p11 = Convert.ToString(reader.GetString(1) + " " + Convert.ToString(reader.GetString(2))) + " " + Convert.ToString(reader.GetInt64(0));

                        p2.Add(p1);
                        p2.Add(p11);
                    }
                }
                return p2;
            }
            catch
            {
                MessageBox.Show("خطا در دریافت اطلاعات کاربران !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public List<string> get_all_students()
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: globalcon);
                string p1 = "";
                string p11 = "";
                List<string> p2 = new List<string>();
                con.Open();
                //-----
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT student.id, users.firstname, users.lastname FROM student JOIN users ON student.id = users.id;";


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        p1 = Convert.ToString(reader.GetInt64(0)) + " " + Convert.ToString(reader.GetString(1)) + " " + Convert.ToString(reader.GetString(2));
                        p11 = Convert.ToString(reader.GetString(1)) + " " + Convert.ToString(reader.GetString(2)) + " " + Convert.ToString(reader.GetInt64(0));
                        p2.Add(p1);
                        p2.Add (p11);
                    }
                }
                return p2;
            }
            catch
            {
                MessageBox.Show("خطا در دریافت اطلاعات کاربران !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public showcourse show_course(string id)
        {
            
            showcourse s1 = new showcourse();
            
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            long teacherid = 0;
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT * FROM course WHERE id = '{id}';";
            try
            {
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    string courseid = Convert.ToString(reader.GetString(0));
                    teacherid = Convert.ToInt64(reader.GetInt64(1));
                    s1.courseid = courseid;
                    s1.teacherid = teacherid;
                    s1.coursename = Convert.ToString(reader.GetString(2));
                    s1.term = courseid[2].ToString();
                    s1.start_date = Convert.ToDateTime(reader.GetDateTime(4));
                    s1.cost = Convert.ToInt64(reader.GetInt64(3));
                    s1.clock = courseid.Substring(4, 2) + ":" + courseid.Substring(6, 2);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using var cmd2 = new NpgsqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = $"SELECT firstname, lastname FROM users WHERE id = {teacherid};";
            try
            {
                using (var reader2 = cmd2.ExecuteReader())
                {
                    reader2.Read();
                        
                    string fname = Convert.ToString(reader2.GetString(0));
                    string lname = Convert.ToString(reader2.GetString(1));
                    s1.teachername = fname + " " + lname;
                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            return s1;
        }
        public List<showcourse> show_all_courseid_name()
        {
            List<showcourse> result = new List<showcourse>();
            try
            {
                

                var con = new NpgsqlConnection(
                connectionString: globalcon);
                long teacherid = 0;
                con.Open();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT id, course_name FROM course;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            showcourse s1 = new showcourse();
                            string courseid = Convert.ToString(reader.GetString(0));
                            s1.courseid = courseid;
                            s1.coursename = Convert.ToString(reader.GetString(1));
                            result.Add(s1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                return result;
            }
            catch
            {
                MessageBox.Show("خطا در دریافت آی دی کلاس !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            
            
        }


        public List<string> search_user_by_id(string thisid)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            string p1 = "";
            List<string> p2 = new List<string>();
            con.Open();
            //-----
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT id FROM users WHERE CAST(id AS TEXT) LIKE '%{thisid}%';";


            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    p1 = Convert.ToString(reader.GetInt64(0));
                    
                    p2.Add(p1);
                }
            }
            //using var cmd2 = new NpgsqlCommand();
            //cmd2.Connection = con;
            //cmd2.CommandText = $"SELECT * FROM teacher WHERE id = {thisid};";
            //using (var reader = cmd2.ExecuteReader())
            //{
            //    reader.Read();

            //    p1.fieled_of_study = Convert.ToString(reader[1]);
            //    p1.degree_of_education = Convert.ToInt32(reader[2]);
            //    p1.presence_record = Convert.ToInt32(reader[3]);
            //    p1.date_of_entry = Convert.ToDateTime(reader[4]);
            //}

            return p2;
            //cmd.ExecuteNonQueryAsync();
        }

        public DataTable get_nonzero_balance()
        {
            try
            {
                DataTable result = new DataTable();

                string sql = $"SELECT id,firstname,lastname,account_balance FROM users WHERE account_balance > 0 or account_balance < 0;";
                using (NpgsqlConnection con = new NpgsqlConnection(globalcon))
                {
                    con.Open();
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, con);
                    adapter.Fill(result);
                    return result;
                }
            }
            catch
            {
                MessageBox.Show("خطا در دریافت اطلاعات مالی !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }
    }
}
