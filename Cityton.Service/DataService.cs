using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cityton.Data.Models;
using Cityton.Repository;
using System.IO;
using OfficeOpenXml;

namespace Cityton.Service
{

    public interface IDataService
    {
        MemoryStream GetUsers();
    }

    public class DataService : IDataService
    {

        private IUserRepository userRepository;

        public DataService(
            IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public MemoryStream GetUsers()
        {
            List<User> users = this.userRepository.GetAll().Result;

            MemoryStream stream = new MemoryStream();

            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                workSheet.Cells.LoadFromCollection(users, true);
                package.Save();
            }

            stream.Position = 0;
            
            return stream;
        }

    }
}
