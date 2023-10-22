using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providersBindingSource;
        private IEnumerable<ProvidersModel> providersList;
        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProviders;
            this.view.AddNewEvent += AddNewProviders;
            this.view.EditEvent += LoadSelectProvidersToEdit;
            this.view.DeleteEvent += DeleteSelectedProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildingSource(providersBindingSource);
            LoadAllProvidersList();
            this.view.Show();
        }

        private void LoadAllProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
            var providers = new ProvidersModel();
            providers.Id = Convert.ToInt32(view.ProvidersId);
            providers.Name = view.ProvidersName;
            providers.Observation = view.ProvidersObservation;

            try
            {
                new Common.ModelDataValidation().Validate(providers);
                if (view.IsEdit)
                {
                    repository.Edit(providers);
                    view.Message = "providers edited succesfuly";
                }
                else
                {
                    repository.Add(providers);
                    view.Message = "provider added succesfuly";
                }
                view.IsSuccessful = true;
                LoadAllProvidersList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProvidersId = "0";
            view.ProvidersName = "";
            view.ProvidersObservation = "";
        }

        private void DeleteSelectedProviders(object? sender, EventArgs e)
        {
            try
            {
                var providers = (ProvidersModel)providersBindingSource.Current;
                repository.Delete(providers.Id);
                view.IsSuccessful = true;
                view.Message = "Provider deleted succesfuly";
                LoadAllProvidersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "A error ocurred, could not delete provider";
            }
        }

        private void LoadSelectProvidersToEdit(object? sender, EventArgs e)
        {
            var providers = (ProvidersModel)providersBindingSource.Current;

            view.ProvidersId = providers.Id.ToString();
            view.ProvidersName = providers.Name.ToString();
            view.ProvidersObservation = providers.Observation.ToString();
            view.IsEdit = true;
        }

        private void AddNewProviders(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProviders(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providersList = repository.GetAll();
            }
            providersBindingSource.DataSource = providersList;
        }
    }
}
