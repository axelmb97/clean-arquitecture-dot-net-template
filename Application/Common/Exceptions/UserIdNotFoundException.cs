using Application.Common.Exceptions.Base;
using Application.Common.Resources;

namespace Application.Common.Exceptions
{
    public class UserIdNotFoundException : BaseException
    {
        private static string errorMessage = Messages.UserIdNotFoundMessage;
        public UserIdNotFoundException() : base(errorMessage)
        {
        }
    }
}
