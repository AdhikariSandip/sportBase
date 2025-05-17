using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Shared.DataResponse;

namespace Base.Shared.Base.BaseRepository.Interface
{
    interface IBaseRepository<in T> where T : class
    {
        DataResponse<IEnumerable<T>> GetData<T>();
        DataResponse<T> GetDataById<T>(int id);
    }
}
