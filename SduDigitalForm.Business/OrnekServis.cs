using SduDigitalForm.Business.Dto;
using SduDigitalForm.Data;
using SduDigitalForm.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace SduDigitalForm.Business
{
    public class OrnekServis
    {
        private readonly ApplicationDbContext dbContext;
        public List<UsersDto> sorguparam;
        public string mailcek;
        private readonly string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-SduDigitalForm-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";
        public OrnekServis()
        {
            dbContext = new ApplicationDbContext(ConnectionString);
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
                DisplayName= s.DisplayName,
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
        public List<UsersDto> GetUsersDto()
        {
           List<UsersDto> auser = dbContext.AspNetUsers.Select(s => new UsersDto()
            {
                Name = s.Name,
                Surname=s.Surname,
                Title=s.Title,
               OrganizationUnitId=s.OrganizationUnitId
            }).ToList();
            return auser;
        }
        public List<IssueDto> GetIssues()
        {
            List<IssueDto> IssueList = dbContext.Tbl_Issues.Select(s => new IssueDto()
            {
                Id = s.Id,
                UserId = s.UserId,
                TypeDeviceId = s.TypeDeviceId,
                Address = s.Address,
                Delivered = s.Delivered,
                DeliveryDate = s.DeliveryDate,
                Giver = s.Giver,
                Mail = s.Mail,
                Note = s.Note,
                Phone = s.Phone,
                RepairCustomer = s.RepairCustomer,
                RepairDate = s.RepairDate,
            }).ToList();

            return IssueList;
        }

        public void PostIssue(IssueDto model) {
            var entity = new Tbl_Issue()
            {
                Id = model.Id,
                RepairDate = model.RepairDate,
                Address = model.Address,
                Delivered = model.Delivered,
                DeliveryDate = DateTime.Now,
                Giver = model.Giver,
                Mail = model.Mail,
                Note = model.Note,
                Phone = model.Phone,
                RepairCustomer = model.RepairCustomer,
                TypeDeviceId = model.TypeDeviceId,
                TypeIssueId = model.TypeIssueId,
                UserId = model.UserId
            };
            
            dbContext.Tbl_Issues.Add(entity);
            dbContext.SaveChanges();
            mailcek = entity.Mail;

            sorguparam = dbContext.AspNetUsers.Where(s => s.Email == entity.Mail).Select(s => new UsersDto() {
                Name = s.Name,
                Surname = s.Surname,
                OrganizationUnitId = s.OrganizationUnitId,
                Title = s.Title
            }).ToList();
  
        }
       
        public string UserCall(string? mail)
        {
            if (mail != null)
            {
                sorguparam = dbContext.AspNetUsers.Where(s => s.Email == mail).Select(s => new UsersDto()
                {
                    Name = s.Name,
                    Surname = s.Surname,
                    OrganizationUnitId = s.OrganizationUnitId,
                    Title = s.Title

                }).ToList();

                return sorguparam.Select(s => s.Name).FirstOrDefault();
            }
            
            var x = sorguparam;
            var ret = dbContext.AspNetUsers.Select(s => s.Name).FirstOrDefault();
            

            return ret;
        }
        public void PostUser(UsersDto umdl)
        {
            var ent = new Tbl_User()
            {
                Name = umdl.Name,
                Surname=umdl.Surname,
                OrganizationUnitId=umdl.OrganizationUnitId,
                Title=umdl.Title
            };

            dbContext.AspNetUsers.Add(ent);
            dbContext.SaveChanges();
        }
    }
}
