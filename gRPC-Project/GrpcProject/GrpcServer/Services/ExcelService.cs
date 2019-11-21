using ExcelDataReader;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class ExcelService : Student.StudentBase
    {
        private readonly ILogger<ExcelService> _logger;

        public ExcelService(ILogger<ExcelService> logger)
        {
            _logger = logger;
        }

        public override async Task GetAllStudentsFromExcel(ExcelRequest request, IServerStreamWriter<StudentModel> responseStream, ServerCallContext context)
        {
            List<StudentModel> students = GetAllStudents(request.FilePath);
            foreach (StudentModel student in students)
            {
                await responseStream.WriteAsync(student);
            } 
        }

        private List<StudentModel> GetAllStudents(string filePath)
        {
            List<StudentModel> students = new List<StudentModel>();
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            students.Add(new StudentModel
                            {
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Gender = reader.GetString(3),
                                Age = reader.GetInt32(4),
                                EmailAddress = reader.GetString(5),
                                School = reader.GetString(6)

                            });
                        }
                    } while (reader.NextResult());
                }
            }
            return students;
        }
    }
}
