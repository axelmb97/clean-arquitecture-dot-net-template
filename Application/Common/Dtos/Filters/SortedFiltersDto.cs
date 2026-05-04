namespace Application.Common.Dtos.Filters
{
    public class SortedFiltersDto : IdsFiltersDto
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Order { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SortedFiltersDto model &&
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
