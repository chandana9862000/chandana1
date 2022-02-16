using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_demo
{
    class DBconnection
    {
        public DBconnection(string name)
        {
            this.name = name;
        }
        protected string Name;
        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
         
    }
    class DBManager
    {
        static DBconnection[] activeconnections;
        public void Addconnections()
        {
            activeconnections = new DBconnection[5];
            for (int i=0;i<5;i++)
            { 
                   activeconnections[i] = new DBconnection("DBconnection" + (i + 1));
            }
        }
        public delegate void EnumConnectionsCallback(DBconnection connection);
        public static void Enumconnections(EnumConnectionsCallback callback)
        {
            foreach (DBconnection connection in activeconnections)
            {
                callback(connection);
            }
        }
    }
    class Delegate1App
    {
        public static void ActiveConnectionscallback(DBconnection connection)
        {
            Console.WriteLine("callback method called for" + connection.name);
        }
        public static void Main()
        {
            DBManager dbMgr = new DBManager();
            dbMgr.Addconnections();
            DBManager.EnumConnectionsCallback myCallback = new DBManager.EnumConnectionsCallback(ActiveConnectionscallback);
            DBManager.Enumconnections(myCallback);
        }
    }
    public delegate void mydata(int x, string y);
    class DelegateDemo
    {
        public void data(int a,string b)
        {

        }
        public void data(DelegateDemo delegateDemo)
        {
            DelegateDemo obj1 = new DelegateDemo();
            mydata mydataobj = new mydata(obj1.data);
            mydataobj(10, "G");


        }
        public void data (DelegateDemo[] delegateDemo)
        {

        }

    }
    
        
        
    
}
