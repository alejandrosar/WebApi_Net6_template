using Entities.LongFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.LongFileRepo.LongFileDBRepo
{
    public interface ILongFileMariaDBRepository
    {
        public List<LongFile> GetAll(MariaDB_Context context);
        public MariaDB_Context  PostLongFile(MariaDB_Context context, LongFile longFile);
        
    }
}
