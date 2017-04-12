using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGrid_test
{
    public class UserDatabase
    {
        #region Memmbers
        public string[] id_data = { "001", "002", "003", "004", "005", "006", "007", "008", "009", "010"};
        public string[] name_data = { "Name1", "Name2", "Name3", "Name4", "Name5", "Name6", "Name7", "Name8", "Name9", "Name10" };
        #endregion

        #region Properties
        public string[] ShowUserID
        {
            get { return id_data; }
        }
        public string[] ShowUserName
        {
            get { return name_data; }
        }
        public int getLength_id
        {
            get { return id_data.Length-1; }
        }
        public int getLength_name
        {
            get { return name_data.Length-1; }
        }
        #endregion
    }
}
