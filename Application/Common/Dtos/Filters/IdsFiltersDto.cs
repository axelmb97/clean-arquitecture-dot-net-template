

using Application.Common.Dtos.Base;

namespace Application.Common.Dtos.Filters
{
    public class IdsFiltersDto : BaseDto
    {
        public List<string> Ids { get; set; }

        public IdsFiltersDto()
        {
            Ids = new List<string>();
        }

        public override bool Equals(object obj)
        {
            return obj is IdsFiltersDto model &&
                    EqualIdsComparer(model.Ids);

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Ids);
        }

        private bool EqualIdsComparer(IEnumerable<string> ids)
        {
            return Ids.SequenceEqual(ids);
        }
    }
}
