using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGrid_test
{
    public class TraceData : BaseViewModel
    {
        #region Members
        //get value to datagrid column
        string _id;
        string _name;

        //datarow
        public TraceData (string id, string name)
        {
            _id = id;
            _name = name;
        }
        #endregion

        #region Propoties
        public string setID
        {
            get { return this._id; }
            set
            {
                this._id = value;
                RaisePropertyChanged("ID");
            }
        }
        public string setName
        {
            get { return this._name; }
            set
            {
                this._name = value;
                RaisePropertyChanged("Name");
            }
        }
        #endregion
    }
}
