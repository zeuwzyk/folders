namespace EmployeeDataBase
{
    static class FileHelper
    {
        public static void SaveFile()//теоретически, я должна вызвать метод с другого места
        {
            using DataBaseManager db = new DataBaseManager();//{}
            { db.SaveChanges(); }
        }

        public static string fileName = "";

        //public static void OpenFile()
        //{
        //    FileManager.OpenDataBase();
        //}
    }
}

