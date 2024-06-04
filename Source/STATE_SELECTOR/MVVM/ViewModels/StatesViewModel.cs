using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace STATE_SELECTOR.MVVM.ViewModels
{
    internal class StatesViewModel : ViewModelBase
    {
        private ObservableCollection<string>? stateNames;
        private readonly ICollectionView stateEntries;

        private string selectedStateItem;

        public string SelectedStateItem 
        { 
            get => selectedStateItem; 
            set
            {
                selectedStateItem = value;
                Debug.WriteLine($"SELECTED ITEM: {SelectedStateItem}");
            }
        }

        public StatesViewModel()
        {
            SetDefaultValues();
            stateEntries = CollectionViewSource.GetDefaultView(stateNames);
        }

        private void SetDefaultValues()
        {
            stateNames = new ObservableCollection<string>()
            {
                "ALABAMA",
                "ALASKA",
                "ALBERTA",
                "AMERICAN SAMOA",
                "ARIZONA",
                "ARKANSAS",
                "BRITISH COLUMBIA",
                "CALIFORNIA",
                "COLORADO",
                "CONNECTICUT",
                "DELAWARE",
                "DISTRICT OF COLUMBIA",
                "FLORIDA",
                "GEORGIA",
                "GUAM",
                "HAWAII",
                "IDAHO",
                "ILLINOIS",
                "INDIANA",
                "IOWA",
                "KANSAS",
                "KENTUCKY",
                "LOUISIANA",
                "MAINE",
                "MANITOBA",
                "MARYLAND",
                "MASSACHUSETTS",
                "MICHIGAN",
                "MINNESOTA",
                "MISSISSIPPI",
                "MISSOURI",
                "MONTANA",
                "NEBRASKA",
                "NEVADA",
                "NEW BRUNSWICK",
                "NEW HAMPSHIRE",
                "NEW JERSEY",
                "NEW MEXICO",
                "NEW YORK",
                "NEWFOUNDLAND",
                "NORTH CAROLINA",
                "NORTH DAKOTA",
                "NORTHERN MARIANA ISLANDS",
                "NORTHWEST TERRITORIES",
                "NOVA SCOTIA",
                "NUNAVUT",
                "OHIO",
                "OKLAHOMA",
                "ONTARIO",
                "OREGON",
                "PENNSYLVANIA",
                "PUERTO RICO",
                "QUEBEC",
                "RHODE ISLAND",
                "SASKATCHEWAN",
                "SOUTH CAROLINA",
                "SOUTH DAKOTA",
                "TENNESSEE",
                "TEXAS",
                "UNITED STATES GOVERNMENT",
                "UNITED STATES MILITARY",
                "UTAH",
                "VERMONT",
                "VIRGINIA",
                "WASHINGTON",
                "WEST VIRGINIA",
                "WISCONSIN",
                "WYOMING",
                "YUKON"
            };
        }

        public ObservableCollection<string> StateNames
        {
            get => stateNames;
            set
            {
                stateNames = value;
                OnPropertyChanged("StateNames");
            }
        }

        public ICollectionView StateEntries
        {
            get { return stateEntries; }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        internal void OnPropertyChanged([CallerMemberName] string propName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
