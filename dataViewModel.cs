using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Windows.Input;
using System.Windows;

using System.Collections.ObjectModel;

namespace dataGrid_test
{
    public class dataViewModel : BaseViewModel
    {
        #region Memmbers
        //add user database
        private UserDatabase _database = new UserDatabase();
        //add data row is tracedata
        private ObservableCollection<TraceData> _tracedata = new ObservableCollection<TraceData>();
        //get id and name value for add
        public string get_id;
        public string get_name;
        //get select item to delete
        private TraceData _SelectedItem;       
        #endregion

        #region Properties
        public ObservableCollection<TraceData> TraceData
        {
            get { return _tracedata; }
            set 
            { 
                _tracedata = value;
                RaisePropertyChanged("TraceData");
            }
        }
        public string getID
        {
            get { return get_id; }
            set
            {
                if (get_id != value)
                {
                    get_id = value;
                    RaisePropertyChanged("getID");
                }
            }
        }
        public string getName
        {
            get { return get_name; }
            set
            {
                if (get_name != value)
                {
                    get_name = value;
                    RaisePropertyChanged("getName");
                }
            }
        }
        public TraceData SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }
        #endregion

        #region Constructors
        public dataViewModel ()
        {
            showinitdata();
        }
        void showinitdata()
        {
            for (int i = 0; i <= _database.getLength_id; i++)
            {
                _tracedata.Add(new TraceData(_database.id_data[i], _database.name_data[i]));
            }
        }
        #endregion

        #region Commands
        //play
        void ShowAllDataExecute()
        {
            //reset view and show list
            _tracedata.Clear();
            showinitdata();
        }
        bool CanShowAllDataExecute()
        {
            return true;
        }
        public ICommand ShowAllData { get { return new RelayCommand(ShowAllDataExecute, CanShowAllDataExecute); } }
        //add id + name
        void AddIdNameExecute()
        {
            if (getID != null && getName != null) 
            {
                //add new record
                _tracedata.Add(new TraceData(getID, getName));
            } 
            else
            {
                MessageBox.Show(string.Format("Data is not complete! Please check and fill it."));
            }
        }
        bool CanAddIdNameExecute()
        {
            return true;
        }
        public ICommand AddIdName { get { return new RelayCommand(AddIdNameExecute, CanAddIdNameExecute); } }
        //remove id + name
        void RemoveIdNameExecute()
        {
            //remove record
            _tracedata.Remove(_SelectedItem);
        }
        bool CanRemoveIdNameExecute()
        {
            return true;
        }
        public ICommand RemoveIdName { get { return new RelayCommand(RemoveIdNameExecute, CanRemoveIdNameExecute); } }
        #endregion
    }
}
