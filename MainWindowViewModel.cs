using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace ListBoxRename
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<ItemViewModel> m_items;
        private ItemViewModel m_selected;

        public MainWindowViewModel()
        {
            m_items = new ObservableCollection<ItemViewModel>();

            m_items.Add(new ItemViewModel("First"));
            m_items.Add(new ItemViewModel("Second"));
            m_items.Add(new ItemViewModel("Third"));

            m_selected = m_items[1];
        }

        public ObservableCollection<ItemViewModel> Items => m_items;

        public ItemViewModel Selected
        {
            get => m_selected;
            set
            {
                m_selected = value;
                OnPropertyChanged();
            }
        }

        public ICommand RenameCommand
        {
            get
            {
                return new DelegateCommand(o =>
                {
                    m_items[1].Rename("Second Renamed");
                });
            }
        }

        public ICommand UnrenameCommand
        {
            get
            {
                return new DelegateCommand(o =>
                {
                    m_items[1].Rename("Second");
                });
            }
        }

        public ICommand ListCommand
        {
            get
            {
                return new DelegateCommand(o =>
                {
                    foreach(var item in m_items)
                    {
                        Trace.WriteLine(item.Name);
                    }
                });
            }
        }
    }
}
