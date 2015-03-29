using System.Collections.Generic;
using System.Windows.Input;
using Interfaces.Commands;
using Interfaces.VMBased;
using Register.UI.Commands;
using Register.UI.Commands.NavigationCommands.CommandViewModels;
using Register.UI.Interfaces.Commands.CommandContexts;
using Register.UI.Models;

namespace Register.UI.MainWindow.Header
{
    public class HeaderVM : BaseVM<IBaseVM>, ICommandContext
    {
        public HeaderVM(IHeaderCommandContext headerCommandContext)
        {
            HeaderCommandContext = headerCommandContext;
            NavigationLinks = headerCommandContext.NavigationLinks;
        }


        public List<IUICommand> NavigationLinks { get; set; }
        public IHeaderCommandContext HeaderCommandContext { get; set; }

        public ICommand NavigateBackCommand
        {
            get { return new NavigateBackCommandVM(HeaderCommandContext); }
        }

        public ICommand NavigateForwardCommand
        {
            get { return new NavigateForwardCommandVM(HeaderCommandContext); }
        }

        public ICommand CloseWorkspaceCommand
        {
            get { return new CloseCommandVMVM(HeaderCommandContext); }
        }

        public void Update()
        {
            OnPropertyChanged("NavigateForwardCommand");
            OnPropertyChanged("CloseWorkspaceCommand");
            OnPropertyChanged("NavigateBackCommand");
        }
    }
}