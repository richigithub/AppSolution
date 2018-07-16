namespace Lands.Infraestructure
{
    using ViewsModels;
    #region Properties
    public class InstanceLocator
    {
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
