using AspDotNetCore.Context;
using AspDotNetCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlayerInfo : ControllerBase
    {
        ApplicationDbContext _dbContext;
        public PlayerInfo(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public string GetAllPlayerName() 
        {
          return "Messi";
        }

        [HttpPost]
        public PlayerModel PostPlayerInfo(PlayerModel _playerModel) 
        {
            _dbContext.postPlayerModel.Add(_playerModel);
            bool isSaved = _dbContext.SaveChanges() > 0;
            if (isSaved) 
            {
                return _playerModel;
            }
            return null;
        }
    }
}
