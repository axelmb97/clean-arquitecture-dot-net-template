namespace Domain.Models.Filters
{
    public class SortedFiltersModel : IdsFiltersModel
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Order { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SortedFiltersModel model &&
                   base.Equals(obj) &&
                   Page == model.Page &&
                   PageSize == model.PageSize &&
                   Order == model.Order;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Page, PageSize, Order);
        }
    }
}
