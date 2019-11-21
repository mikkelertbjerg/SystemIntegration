using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcServer.Database;
using Microsoft.Extensions.Logging;

namespace GrpcServer.Services
{
    public class StudentsService : Student.StudentBase
    {
        private readonly ILogger<StudentsService> _logger;
        private readonly DatabaseConnection _db;

        public StudentsService(ILogger<StudentsService> logger)
        {
            _logger = logger;
            _db = new DatabaseConnection();
        }

        public override Task<StudentModel> GetStudentInfo(StudentLookupModel request, ServerCallContext context)
        {
            StudentModel student = _db.GetStudent(request.Id);
            return Task.FromResult(student);
        }

        public override async Task GetAllStudents(EmptyRequest request, IServerStreamWriter<StudentModel> responseStream, ServerCallContext context)
        {
            List<StudentModel> students = _db.GetAllStudents();

            foreach (StudentModel student in students)
            {
                await responseStream.WriteAsync(student);
            }
        }

        public override async Task GetAllStudentIds(EmptyRequest request, IServerStreamWriter<StudentLookupModel> responseStream, ServerCallContext context)
        {
            List<StudentLookupModel> ids = _db.GetAllStudentIds();

            foreach (StudentLookupModel id in ids)
            {
                await responseStream.WriteAsync(id);
            }
        }
    }
}
