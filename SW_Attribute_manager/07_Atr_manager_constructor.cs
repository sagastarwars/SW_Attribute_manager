using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Attribute_libs
{
    public partial class Attribute_manager
    {
        public Attribute_manager()
        {
            SQLite_connection_string = @"Data Source=D:\STAR WARS Saga\Character_creation\Atributes_Libs\Attributes.db;Version=3;";
            SQLite_connection = new SQLiteConnection(SQLite_connection_string);

            Attribute_general_coloumn_name = new List<string>();
            Attribute_general_description = new List<string>();
            Attributes_description = new List<List<string>>();
            Attributes_description.Add(Attribute_general_description);
        }
    }
}
