using Amozesh;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmoozeshPJWinF
{
    internal class DBC
    {
        private string globalcon = "Host=localhost; Port=5432; Username=postgres; password=nazanin1381; database=test";
        public Image returnImage;
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
            connectionString: "Host=localhost; Port=5432; Username=postgres; password=nazanin1381; database=test");
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"INSERT INTO payment(user_id, date_of_payment, term, amount, transaction_status, tracking_code,tracking_time , description) VALUES ({p1.userid}, '{p1.dateofpayment}', '{p1.term}', {p1.amount}, '{p1.transactionstatus}', '{p1.trackingcode}', '{p1.tarckingtime}' , '{p1.description}');";
            cmd.ExecuteNonQueryAsync();
            Thread.Sleep(500);

        }

        public string Id_Reader(string thisid, int ind)
        {
            var con = new NpgsqlConnection(
            connectionString: globalcon);
            con.Open();
            //-----
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT * FROM users WHERE id = {thisid};";


            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                return Convert.ToString(reader[ind]);
            }
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


    }
}
