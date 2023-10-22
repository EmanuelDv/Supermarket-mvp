using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductModel> productsList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProducts;
            this.view.AddNewEvent += AddNewProducts;
            this.view.EditEvent += LoadSelectProductsToEdit;
            this.view.DeleteEvent += DeleteSelectedProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildingSource(productsBindingSource);
            LoadAllProductsList();
            this.view.Show();
        }

        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            try
            {
                var products = (ProductModel)productsBindingSource.Current;
                repository.Delete(products.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted succesfuly";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "A error ocurred, could not delete product";
            }
        }

        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            var products = (ProductModel)productsBindingSource.Current;

            view.ProductsId = products.Id.ToString();
            view.ProductsName = products.Name.ToString();
            view.ProductsPrice = products.Price.ToString();
            view.ProductsStock = products.Stock.ToString();
            view.Category_Id = products.Category_id.ToString();
            view.IsEdit = true;
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productsList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productsList = repository.GetAll();
            }
            productsBindingSource.DataSource = productsList;
        }


        private void LoadAllProductsList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
        }
        private void CleanViewFields()
        {
            view.ProductsId = "0";
            view.ProductsName = "";
            view.ProductsPrice = "";
            view.ProductsStock = "";
            view.Category_Id = "";//movi aqui 
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            var product = new ProductModel();
            product.Id = Convert.ToInt32(view.ProductsId);
            product.Name = view.ProductsName;
            product.Price = Convert.ToInt32(view.ProductsPrice);
            product.Stock = Convert.ToInt32(view.ProductsStock);
            product.Category_id = Convert.ToInt32(view.Category_Id);
            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "PayMode Edited Successfuly";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "PayMode added Successfuly";
                }
                view.IsSuccessful = true;

                CleanViewFields();
                LoadAllProductList();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred, Could not delete pay mode";

            }



        }

        private void LoadAllProductList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
        }


    }
}
