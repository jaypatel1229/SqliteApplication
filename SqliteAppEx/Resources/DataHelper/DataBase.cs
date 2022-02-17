using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqliteAppEx.Resources.DataHelper
{
    public class DataBase
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.CreateTable<Person>();
                    return true;
                }
            }
            catch (SQLiteException sqle)
            {
                Log.Info("SQLiteEx", sqle.Message);
                return false;
            }
        }

        public bool InsertIntoTablePerson(Person person)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.Insert(person);
                    return true;
                }
            }
            catch (SQLiteException sqle)
            {
                Log.Info("SQLiteEx", sqle.Message);
                return false;
            }
        }

        public List<Person> SelectTablePerson()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    return connection.Table<Person>().ToList();

                }
            }
            catch (SQLiteException sqle)
            {
                Log.Info("SQLiteEx", sqle.Message);
                return null;
            }
        }

        public bool UpdateTablePerson(Person person)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.Query<Person>("Update person set EnrollmentNumber=?,Name=?,Email=?,Password=?",person.EnrollmentNumber,person.Name,person.Email,person.Password);
                    return true;
                }
            }
            catch (SQLiteException sqle)
            {
                Log.Info("SQLiteEx", sqle.Message);
                return false;
            }
        }
        public bool DeleteTablePerson(Person person)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.Delete(person);
                    return true;
                }
            }
            catch (SQLiteException sqle)
            {
                Log.Info("SQLiteEx", sqle.Message);
                return false;
            }
        }

        public bool selectQueryPerson(Person person)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.Query<Person>("SELECT * FROM Person Where ID=?");
                    return true;
                }
            }
            catch (SQLiteException sqle)
            {
                Log.Info("SQLiteEx", sqle.Message);
                return false;
            }
        }
    }
}