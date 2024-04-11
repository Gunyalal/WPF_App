using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{   // Создаю класс договоров
    public class Dogovor
    {
        public int dog_no { get; set; }
        public DateTime dog_date { get; set; }
        public DateTime update_time { get; set; }
        public Boolean actual { get; set; }
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<Dogovor> GetData()
        {
            // Прописываю путь к базе, открываю соединение и запрашиваю данные из таблицы rdogovor
            String connectionString = "Server=bdserv,1433;Database=test_task;Trusted_Connection=True;TrustServerCertificate=True";
            SqlConnection SQLC = new SqlConnection(connectionString);
            SQLC.Open();
            String SQLQuery = "select * from rdogovor order by dog_no;";
            SqlCommand SQLCommand = new SqlCommand(SQLQuery, SQLC);
            SqlDataReader SQLReader = SQLCommand.ExecuteReader();

            // Полученные строки добавляю в список договоров
            List<Dogovor> dogovors = new List<Dogovor>();
            while (SQLReader.Read())
            {
                Dogovor dogovor = new Dogovor();
                dogovor.dog_no = (int)SQLReader.GetValue(0);
                dogovor.dog_date = (DateTime)SQLReader.GetValue(1);
                dogovor.update_time = (DateTime)SQLReader.GetValue(2);
                dogovor.actual = (DateTime.Now - dogovor.update_time).TotalDays < 60;
                dogovors.Add(dogovor);
            }

            return dogovors;
        }



        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
