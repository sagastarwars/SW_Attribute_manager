using System;


namespace Attribute_libs
{
    public partial class Attribute_manager
    {
        public void Run_download_and_upload_data()
        {
            SQLite_connection.Open();


            Run_download_from_SQLite("SELECT * FROM Attributes_general ORDER BY ID",
                                      SQLite_connection,
                                      Attribute_general_coloumn_name,
                                      Attributes_description,
                                      (int)Type_of_var.string_type);

            SQLite_connection.Close();
        }
    }
}
