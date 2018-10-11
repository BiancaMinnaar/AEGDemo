using BaseBonsai.DataContracts;
using AEGDemo.Interface.Repository;

namespace AEGDemo.Root.Repository
{
    public class ProjectBaseRepository : BaseRepository
    {
        protected IMasterRepository _MasterRepo;

        public ProjectBaseRepository(IMasterRepository masterRepository)
        {
            _MasterRepo = masterRepository;
        }
    }
}

