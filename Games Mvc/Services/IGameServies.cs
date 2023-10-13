using Games_Mvc.Models;

namespace Games_Mvc.Services
{
    public interface IGameServies
    {
        public Task Create(CreateGameViewModel game);
    }
}
