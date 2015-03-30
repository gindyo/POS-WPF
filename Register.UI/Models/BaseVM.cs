using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using Interfaces.VMBased;

namespace Register.UI.Models
{
    public class BaseVM<T> : IBaseVM
    {
        public BaseVM()
        {
        }

        public BaseVM(T baseInstance)
        {
            Type type = typeof (T);
            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo propertyInfo in props)
            {
                propertyInfo.SetValue(this, propertyInfo.GetValue(baseInstance));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OpenDialog(IBaseVM viewModel)
        {
            Application.Current.MainWindow.ShowDialog();
        }
    }
}