namespace Supermarket_mvp.Views
{
    internal interface IProductView
    {
        string ProductsId { get; set; }
        string ProductsName { get; set; }
        string ProductsPrice { get; set; }
        string ProductsStock { get; set; }
        string Category_Id { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductsListBildingSource(BindingSource payModeList);
        void Show();
    }
}
