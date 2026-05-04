namespace Domain.Models.Filters
{
    public class IdsFiltersModel
    {
        public List<int> Ids { get; set; }

        public IdsFiltersModel()
        {
            Ids = new List<int>();
        }

        public override bool Equals(object obj)
        {
            return obj is IdsFiltersModel model &&
                    EqualIdsComparer(model.Ids);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Ids);
        }

        private bool EqualIdsComparer(IEnumerable<int> ids)
        {
            return Ids.SequenceEqual(ids);
        }
    }
}
