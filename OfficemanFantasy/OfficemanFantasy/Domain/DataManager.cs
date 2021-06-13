using OfficemanFantasy.Domain.Repositories.Abstract;

namespace OfficemanFantasy.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }

        public INpcRepository Npcs { get; set; }

        public IUserRepository Users { get; set; }

        public ITileRepository Tiles { get; set; }

        public IUnitRepository Units { get; set; }



        public DataManager(ITextFieldsRepository textFieldsRepository, IUnitRepository unitRepository, INpcRepository npcRepository, IUserRepository userRepository, ITileRepository tileRepository)
        {
            TextFields = textFieldsRepository;
            Npcs = npcRepository;
            Users = userRepository;
            Tiles = tileRepository;
            Units = unitRepository;
        }
    }
}
