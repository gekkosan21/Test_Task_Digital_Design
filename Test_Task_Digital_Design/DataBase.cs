using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Test_Task_Digital_Design;

namespace Test_Task_Digital_Design
{
    partial class Accounts
    {
        public Accounts() { }

        public Accounts(string login, string pwd)
        {
            login_user = login;
            password_user = pwd;
        }
    }

    partial class Files
    {
        public Files() { }

        public Files(string name, int size, string path)
        {
             file_name= name;
            file_size = size;
            file_path = path;
        }
    }
    
    internal class DataBase
    {
        public Test_Task_Digital_DesignEntities model = new Test_Task_Digital_DesignEntities();

        public void add_user(string login, string pwd)
        {
            model.Accounts.Add( new Accounts(login, pwd));
            model.SaveChanges();
        }

        public bool add_file(string name, int size, string path)
        {
            model.Files.Add( new Files(name, size, path));
            model.SaveChanges();
            return true;
        }

        public bool remove_file(int id)
        {
            Files fileToDelete = model.Files.Where(x => x.file_id==id).Single();
            model.Files.Remove( fileToDelete);
            model.SaveChanges();
            return true;
        }

    }
}
