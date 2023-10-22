namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnCategory.Click += delegate { ShowCategoryView?.Invoke(this, EventArgs.Empty); };
            BtnExit.Click += delegate { this.Close(); };
        }
        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowCustomerView;
        public event EventHandler ShowCategoryView;
    }
}