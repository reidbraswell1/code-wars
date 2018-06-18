using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWars.Shared;
using Dapper;
using System.Text;
using System;

namespace CodeWars.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDbConnection _conn;

        public StudentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public int AddStudent(Student student)
        {
            StringBuilder addStudent = new StringBuilder();
            addStudent.Append("INSERT INTO `CODE_WARS`.`STUDENT` ");
            addStudent.Append("(`LastName`,");
            addStudent.Append("`FirstName`,");
            addStudent.Append("`ClassId`,");
            addStudent.Append("`CodeWarsApiKey`,");
            addStudent.Append("`CodeWarsOverallScore`");
            addStudent.Append(") VALUES ");
            addStudent.Append("(@LastName,");
            addStudent.Append("@FirstName,");
            addStudent.Append("@ClassId,");
            addStudent.Append("@CodeWarsApiKey,");
            addStudent.Append("@CodeWarsOverallScore)");
            try
            {
                using (var conn = _conn)
                {
                    conn.Open();
                    return conn.Execute(addStudent.ToString(), student);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int DeleteStudent(int id)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Execute("DELETE FROM `CODE_WARS`.`STUDENT` WHERE Id = @id", new { id });
            }
        }

        public int UpdateStudent(Student student)
        {
            StringBuilder updateStudent = new StringBuilder();
            updateStudent.Append("UPDATE `CODE_WARS`.`STUDENT` SET ");
            updateStudent.Append("(`LastName` = @LastName,");
            updateStudent.Append("`FirstName` = @FirstName,");
            updateStudent.Append("`ClassId` = @ClassId,");
            updateStudent.Append("`CodeWarsApiKey` = @CodeWarsApiKey,");
            updateStudent.Append("`CodeWarsOverallScore` = @CodeWarsOverallScore");
            updateStudent.Append(");");
            updateStudent.Append("WHERE Id = @Id");
            try
            {
                using (var conn = _conn)
                {
                    conn.Open();
                    return conn.Execute(updateStudent.ToString(), student);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<Student> GetStudent(int id)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Query<Task<Student>>("SELECT * FROM `CODE_WARS`.`STUDENT` WHERE Id = @Id", new { id }).FirstOrDefault();
            }
        }

        public Task<IEnumerable<Student>> GetStudents()
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.QueryAsync<Student>("SELECT * FROM `CODE_WARS`.`STUDENT` ORDER BY LastName");
            }
        }
        public int CreateStudentTable()
        {
            StringBuilder createStudentTable = new StringBuilder();
            createStudentTable.Append("CREATE TABLE IF NOT EXISTS `CODE_WARS`.`STUDENT`");
            createStudentTable.Append("(`Id` int not null auto_increment,");
            createStudentTable.Append("`LastName` varchar(255) not null,");
            createStudentTable.Append("`FirstName` varchar(255) not null,");
            createStudentTable.Append("`ClassId` varchar(255) not null,");
            createStudentTable.Append("`CodeWarsApiKey` varchar(255),");
            createStudentTable.Append("`CodeWarsOverallScore` int not null,");
            createStudentTable.Append("Primary Key(`Id`)");
            createStudentTable.Append(");");

            try
            {
                using (var conn = _conn)
                {
                    conn.Open();
                    return conn.Execute(createStudentTable.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
