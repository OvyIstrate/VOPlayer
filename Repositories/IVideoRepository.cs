using System.Collections.Generic;
using VOPlayer.Models;

namespace VOPlayer.Repositories
{
    public interface IVideoRepository
    {
        List<VideoRegistrationModel> GetAll();

    }
}