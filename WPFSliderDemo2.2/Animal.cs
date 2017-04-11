using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSliderDemo2._2
{
    class Animal : INotifyPropertyChanged
    {
        private int happiness;

        public int Happiness
        {
            get { return happiness; }
            set
            {
                if (value != happiness)
                {
                    happiness = value;
                    // TODO TRigger eventhandler
                    RaisePropertyChanged("Happiness");
                }
            }
        }
        public string Name { get; set; }
        // ohjelmoidaan olio ilmoittamaan ominaisuutensa muuttumisesta
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
