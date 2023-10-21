namespace Supermarket_mvp.Models
{
    internal interface IPayModeRepository
    {
        void Add(PayModelModel payModelModel);
        void Edit(PayModelModel payModelModel);
        void Delete(int id);
        IEnumerable<PayModelModel> GetAll();
        IEnumerable<PayModelModel> GetByValue(string value);
    }
}
