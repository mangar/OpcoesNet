using MySql.Data.MySqlClient;

namespace OpcoesNet.Database
{

    class DBFactory
    {

        private MySqlConnection myConn = null;
        private static DBFactory instance = null;

        private static AcoesDB acoesDB = null;

        private DBFactory()
        {
            this.myConn = DB.ConexaoBD();
        }


        public static DBFactory create()
        {
            if (DBFactory.instance == null)
            {
                DBFactory.instance = new DBFactory();
            }

            return DBFactory.instance;
        }


        /**
         * 
         * 
         */
        public AcoesDB getAcoesDB() {
            if (DBFactory.acoesDB == null)
            {
                DBFactory.acoesDB = new AcoesDB(myConn);
            }

            return DBFactory.acoesDB;
        }





    }

    


}
