using RMDesktopUI.Models;
using System.Threading.Tasks;

namespace RMDesktopUI.Helpers
{
    public interface IAPIHlelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}