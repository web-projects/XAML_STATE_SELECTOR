using System.Collections;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace STATE_SELECTOR.MVVM.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        protected ConcurrentDictionary<string, string> propertyErrors = new ConcurrentDictionary<string, string>();

        public bool HasErrors
            => !propertyErrors.IsEmpty;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand DecodeCommand { get; private set; }

        public ViewModelBase()
        {
            DecodeCommand = new RelayCommand(DecodeTVRExecuted);
        }

        public IEnumerable GetErrors([CallerMemberName] string propertyName = null)
        {
            if (propertyErrors.TryGetValue(propertyName, out string errorValue))
            {
                return new List<string>() { errorValue };
            }

            return null;
        }

        internal virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DecodeTVRExecuted(object obj)
        {
        }
    }
}
