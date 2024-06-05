using MusicLibraryAPI.ApiModels.User;

namespace MusicLibraryAPI.ApiModels;

public class Profile : AutoMapper.Profile
{
    public Profile()
    {
        #region User

        CreateMap<CreateUserModel, Domain.Entities.User>();
        CreateMap<Domain.Entities.User, GetByIdUserModel>();
        CreateMap<Domain.Entities.User, GetUserModel>();
        CreateMap<UpdateUserModel, Domain.Entities.User>();

        #endregion
    }
}