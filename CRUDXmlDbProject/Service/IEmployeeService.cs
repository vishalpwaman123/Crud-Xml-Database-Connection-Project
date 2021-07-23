using CRUDXmlDbProject.Common.RequestModel;
using CRUDXmlDbProject.Common.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDXmlDbProject.Service
{
    public interface IEmployeeService
    {
        public Task<AddDataResponse> AddEmployeeData(AddDataRequest request);
    }
}
