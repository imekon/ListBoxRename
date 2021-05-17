namespace ListBoxRename
{
    public class ItemViewModel : ViewModelBase
    {
        private string m_name;

        public ItemViewModel(string name)
        {
            m_name = name;
        }

        public string Name
        {
            get => m_name;
            set
            {
                m_name = value;
                OnPropertyChanged();
            }
        }

        public void Rename(string newName)
        {
            m_name = newName;
            OnPropertyChanged(nameof(Name));
        }

        public override string ToString()
        {
            return m_name;
        }
    }
}
