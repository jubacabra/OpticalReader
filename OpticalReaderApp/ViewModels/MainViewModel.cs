using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using OpticalReaderApp.Resources;

namespace DataBoundApp1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { ID = "0", LineOne = "Danhostel", LineTwo = "Vindeboder 7, 4000 Roskilde", LineThree = "For The Budget Tourist" });
            this.Items.Add(new ItemViewModel() { ID = "1", LineOne = "Hotel Prindsen", LineTwo = "Algade 13, Roskilde 4000", LineThree = "For The Tourist Who Wants To Feel Royal" });
            this.Items.Add(new ItemViewModel() { ID = "2", LineOne = "Comwell", LineTwo = "Skomagergade 10, Roskilde 4000", LineThree = "For The Modern Tourist" });
            this.Items.Add(new ItemViewModel() { ID = "3", LineOne = "Scandic", LineTwo = "Søndre Ringvej 33, 4000 Roskilde", LineThree = "For The Tourist Who Wants Luxury" });
            this.Items.Add(new ItemViewModel() { ID = "4", LineOne = "Motel Wittrup", LineTwo = "Roskildevej 251, 2620 Albertslund", LineThree = "For The Traveling Tourist" });
            this.Items.Add(new ItemViewModel() { ID = "5", LineOne = "Hotel Viby Kro", LineTwo = "Skolevej 1, 4130 Viby", LineThree = "For The Tourist Who Prefer The Tavern" });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}