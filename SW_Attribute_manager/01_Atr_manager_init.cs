using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Attribute_libs
{
    public partial class Attribute_manager
    {
        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;
        #endregion

        private List<string> Attribute_general_coloumn_name;
        private List<List<string>> Attributes_description;
        private List<string> Attribute_general_description;

        enum Type_of_var
        {
            string_type,
            int_type
        }
    }
}
