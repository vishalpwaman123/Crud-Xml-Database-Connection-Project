using CRUDXmlDbProject.Common.RequestModel;
using CRUDXmlDbProject.Common.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDXmlDbProject.DataAccess
{
    public interface IEmployeeDataAccess
    {
        public Task<AddDataResponse> AddEmployeeData(AddDataRequest request);
    }
}
