using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoApp.ViewModel
{
    public class ConverterByTenViewModel : ViewModelBase, IConverter<string, string>
    {

        private readonly DelegateCommand _changeNameCommand;
        public ICommand ChangeNameCommand => _changeNameCommand;

        public ConverterByTenViewModel()
        {
            _changeNameCommand = new DelegateCommand(OnChangeName);
        }

        private void OnChangeName(object commandParameter)
        {
            Data = Convert(Data);

        }

        public string Convert(string input)
        {
            var value = System.Convert.ToInt32(input);
            value *= 10;
            return value.ToString();
        }

       

        private string _data;
        public string Data
        {
            get => _data;
            set => SetProperty(ref _data, value);
        }


    }
}
