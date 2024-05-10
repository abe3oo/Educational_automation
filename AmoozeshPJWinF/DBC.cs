﻿using Amozesh;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace AmoozeshPJWinF
{
    internal class DBC
    {
        private string globalcon = "Host=localhost; Port=5432; Username=postgres; password=nazanin1381; database=test";
        public Image returnImage;
        //"Host=localhost; Port=5432; Username=postgres; password=nazanin1381; database=test"
        //"Host=localhost; Port=1148; Username=postgres; password=Ara41148; database=test"
        public DBC()
        {


        }
        public bool id_check(string thisid)
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

        public bool teacherid_check(string thisid)
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

       


        public bool courseid_check(string thisid)
        {

            var con = new NpgsqlConnection(connectionString: globalcon);
            con.Open();
            //-----
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT * FROM course WHERE id = {thisid};";
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
        public bool studentid_check(string thisid)
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


        public void st_set(student s1)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            con.Open();
            var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            
            cmd.CommandText = $"INSERT INTO users(id, firstname, lastname, age, phone_num, whatsapp_num, pic) VALUES ({s1.personalcode}, '{s1.firstname}', '{s1.lastname}', {s1.age}, {s1.number}, {s1.whatsappnumber},@Image);";
            cmd.CommandText += $"INSERT INTO student VALUES ({s1.personalcode}, {s1.education}, '{s1.fieled_of_study}', {s1.maritalstatus}, '{s1.job}', '{s1.city}', {s1.classtype});";
            NpgsqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@Image";
            param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
            param.Value = s1.profilepicture;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQueryAsync();
            Thread.Sleep(500);
        }

        public void pr_set(teacher p1)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"INSERT INTO users(id, firstname, lastname, age, phone_num, whatsapp_num) VALUES ({p1.personalcode}, '{p1.firstname}', '{p1.lastname}', {p1.age}, {p1.number}, {p1.whatsappnumber});";
            cmd.CommandText += $"INSERT INTO teacher VALUES ({p1.personalcode}, '{p1.fieled_of_study}', {p1.degree_of_education}, {p1.presence_record}, '{p1.date_of_entry.Year}-{p1.date_of_entry.Month}-{p1.date_of_entry.Day}',@Image);";
            NpgsqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@Image";
            param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
            param.Value = p1.profilepicture;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQueryAsync();
            Thread.Sleep(500);
        }

        public void pay_set(Payment p1)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"INSERT INTO payment(user_id, date_of_payment, term, amount, transaction_status, tracking_code,tracking_time , description) VALUES ({p1.userid}, '{p1.dateofpayment}', '{p1.term}', {p1.amount}, '{p1.transactionstatus}', '{p1.trackingcode}', '{p1.tarckingtime}' , '{p1.description}');";
            cmd.CommandText = $"UPDATE users SET account_balance = {p1.accountbalance} WHERE id =  {p1.userid};";
            cmd.ExecuteNonQueryAsync();
            Thread.Sleep(500); 

        }

        public void course_set(Course c1)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"INSERT INTO course(id,teacher_id, course_name, cost, date_of_start) VALUES ({c1.courseid}, {c1.teacherid}, '{c1.coursename}', {c1.cost}, '{c1.dateofstart}');";
            cmd.ExecuteNonQueryAsync();
            Thread.Sleep(500);

        }

        public void enrollment_set(Enrollment e1)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"INSERT INTO enrollment(course_id,student_id, whatsapp_gp, date_of_enrollment) VALUES ({e1.courseid}, {e1.studentid}, '{e1.whatsappgp}','{e1.dateofenrollment}');";
            cmd.ExecuteNonQueryAsync();
            Thread.Sleep(500);

        }

        public student St_Reader(string thisid)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            student s1 = new student();
            con.Open();
            //-----
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT * FROM users WHERE id = {thisid};";


            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                s1.personalcode = Convert.ToInt32(reader[0]);
                s1.firstname = Convert.ToString(reader[1]);
                s1.lastname = Convert.ToString(reader[2]);
                s1.age = Convert.ToInt32(reader[3]);
                s1.number = Convert.ToInt32(reader[4]);
                s1.whatsappnumber = Convert.ToInt32(reader[5]);
            }
            using var cmd2 = new NpgsqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = $"SELECT * FROM student WHERE id = {thisid};";
            using (var reader = cmd2.ExecuteReader())
            {
                reader.Read();
                s1.education = Convert.ToInt32(reader[1]);
                s1.fieled_of_study = Convert.ToString(reader[2]);
                s1.maritalstatus = Convert.ToBoolean(reader[3]);
                s1.job = Convert.ToString(reader[4]);
                s1.city = Convert.ToString(reader[5]);
                s1.maritalstatus = Convert.ToBoolean(reader[6]);
            }

            return s1;
            //cmd.ExecuteNonQueryAsync();
        }

        public teacher Pr_Reader(string thisid)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            teacher p1 = new teacher();
            con.Open();
            //-----
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT * FROM users WHERE id = {thisid};";


            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                p1.personalcode = Convert.ToInt32(reader[0]);
                p1.firstname = Convert.ToString(reader[1]);
                p1.lastname = Convert.ToString(reader[2]);
                p1.age = Convert.ToInt32(reader[3]);
                p1.number = Convert.ToInt32(reader[4]);
                p1.whatsappnumber = Convert.ToInt32(reader[5]);
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

            return p1;
            //cmd.ExecuteNonQueryAsync();
        }

        public long acc_bl_reader(string thisid)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            Payment p1 = new Payment();
            con.Open();
            //-----
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT account_balance FROM users WHERE id = {thisid};";


            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                p1.accountbalance = Convert.ToInt64(reader[0]);
            }
             return p1.accountbalance;
            
        }

        public List<long> Course_holding_id_Reader_by_date(DateTime tod)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            List<long> list = new List<long>();

            con.Open();
            //-----
            using var cmd = new NpgsqlCommand();

            cmd.Connection = con;

            cmd.CommandText = $"SELECT course_id FROM course_holding WHERE date_of_sections = '{tod.Year}-{tod.Month}-{tod.Day}';";
            using (var reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    long id = Convert.ToInt64(reader.GetInt64(0));
                    list.Add(id);
                }
            }
            return list;
            //cmd.ExecuteNonQueryAsync();
        }

        public GetCourse GetCourse_Reader_by_id(long id)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            
            GetCourse g1 = new GetCourse();
            con.Open();
            //-----
            using var cmd = new NpgsqlCommand();

            cmd.Connection = con;

            cmd.CommandText = $"SELECT * FROM course WHERE id = {id};";
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                
                g1.courseid = Convert.ToInt64(reader.GetInt64(0));
                g1.teacherid = Convert.ToInt64(reader.GetInt64(1));
                g1.coursename = Convert.ToString(reader.GetString(2));
                
            }
            return g1;
            //cmd.ExecuteNonQueryAsync();
        }

        public byte[] ImageToByteArray(System.Drawing.Image img)
        {
            
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return returnImage;
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
        public Image pic_reader(int id)
        {
            using (var conn = new NpgsqlConnection(globalcon))
            {
                string sQL = $"SELECT pic FROM users WHERE id = {id};";
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
                        Image a1 = imageConverter.ConvertFrom(productImageByte) as System.Drawing.Image;
                        return a1;
                    }

                }
            }
        }

        public string cul_converter(DateTime d1)
        {
            PersianCalendar pc = new PersianCalendar();
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }

        public List<DateTime> data_course_creator(DateTime d1, int d)
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
    }
}
