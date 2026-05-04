using Application.Common.Dtos.Base;

namespace Application.Common.Dtos.Errors
{
    public class ValidationErrorDto : BaseDto
    {
        public string PropertyName { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public ValidationErrorDto()
        {
            Errors = new List<string>();
        }
    }
}
