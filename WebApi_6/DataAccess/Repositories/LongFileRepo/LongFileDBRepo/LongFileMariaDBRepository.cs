using Entities.LongFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.LongFileRepo.LongFileDBRepo
{
    public class LongFileMariaDBRepository : ILongFileMariaDBRepository
    {
        public List<LongFile> GetAll(MariaDB_Context context)
        {
            return context.LongFile.ToList();
        }

        public MariaDB_Context PostLongFile(MariaDB_Context context, LongFile longFile)
        {
            context.Add(longFile);
            return context; 
        }

    }
}
