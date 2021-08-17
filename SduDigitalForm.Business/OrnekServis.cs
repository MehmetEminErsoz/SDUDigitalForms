using SduDigitalForm.Business.Dto;
using SduDigitalForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
namespace SduDigitalForm.Business
{
    public class OrnekServis
    {
        private readonly ApplicationDbContext dbContext;
        private readonly string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-SduDigitalForm-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";

        public OrnekServis()
        {
            dbContext = new ApplicationDbContext(ConnectionString);
        }

        public List<OrnekModel> Test()
        {
            var list = new List<OrnekModel>()
            {
                new OrnekModel(){Ad="test1",Yas=10},
                new OrnekModel(){Ad="test2",Yas=10},
                new OrnekModel(){Ad="test3",Yas=10},
            };
            return list;
        }

        public List<TypeDeviceDto> GetTypeDeviceDto()
        {
            List<TypeDeviceDto> list =dbContext.Tbl_TypeDevices.Select(x=> new TypeDeviceDto(){
                Id=x.Id,
                Name=x.Name
            }).ToList();
            return list;
        }

        public List<OrganizationUnitDto> GetOrganizationUnitDto()
        {
            var backList = dbContext.Tbl_OrganizationUnits.Select(s => new OrganizationUnitDto()
            {
                Id=s.Id,
                DisplayName= s.DisplayName.ToString(),
                Parent=s.Parent

            }).ToList();

            return backList;

        }


        public List<TypeIssueDto> GetTypeIssueDto()
        {
            var x = dbContext.Tbl_IssueTypes.Select(s => new TypeIssueDto()
            {
                Idissue=s.Idissue,
                IssueType=s.IssueType


            }).ToList();

            return x;
        }
    }
}
