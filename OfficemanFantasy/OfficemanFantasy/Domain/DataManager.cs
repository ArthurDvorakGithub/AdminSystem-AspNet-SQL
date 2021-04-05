using OfficemanFantasy.Domain.Repositories.Abstract;

namespace OfficemanFantasy.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public INpcRepository Npcs { get; set; }

        public IUnitRepository Units { get; set; }

        public IUserRepository Users { get; set; }



        public DataManager(ITextFieldsRepository textFieldsRepository, INpcRepository npcRepository, IUnitRepository unitRepository, IUserRepository userRepository)
        {
            TextFields = textFieldsRepository;
            Npcs = npcRepository;
            Units = unitRepository;
            Users = userRepository;
        }
    }
}
