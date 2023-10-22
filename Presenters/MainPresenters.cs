using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenters
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;
        public MainPresenters(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCategoryView += ShowCategoryView;
        }

        private void ShowCategoryView(object? sender, EventArgs e)
        {
            ICategoryView view = CategoryView.GetInstance((MainView)mainView);
            ICategoryRepository repository =new CategoryRepository(sqlConnectionString);
            new CategoryPresenter(view, repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModelView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
    }


}
