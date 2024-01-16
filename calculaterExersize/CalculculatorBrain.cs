using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculaterExersize
{
    internal class CalculculatorBrain : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public CalculculatorBrain()
        {
            ButtonCommand = new Command<string>((p) => Calculator(p));
        }

        private string calculatorResult;
        public string CalculatorResult
        {
            get
            {
                return this.calculatorResult;
            }
            set
            {
                this.calculatorResult = value;
                OnPropertyChanged();
            }
        }
        public Command<string>ButtonCommand { get; set; }   
        private void Calculator(string p)
        {
            calculatorResult = p;
        }
    }
}
