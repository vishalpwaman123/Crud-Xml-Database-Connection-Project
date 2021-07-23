using CRUDXmlDbProject.Common.RequestModel;
using CRUDXmlDbProject.Common.ResponseModel;
using CRUDXmlDbProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDXmlDbProject.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeDataAccess employeeDataAccess;
        public async Task<AddDataResponse> AddEmployeeData(AddDataRequest request)
        {
            AddDataResponse response = null;
            response = await this.employeeDataAccess.AddEmployeeData(request);
            
            return response;
            
        }
    }
}
