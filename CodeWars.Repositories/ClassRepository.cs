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
    public class ClassRepository : IClassRepository
    {
        private readonly IDbConnection _conn;

        public ClassRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public int AddClass(Class cls)
        {
            StringBuilder addClass = new StringBuilder();
            addClass.Append("INSERT INTO `CODE_WARS`.`CLASS` ");
            addClass.Append("(`ClassName`,");
            addClass.Append("`ClassDescription`");
            addClass.Append(") VALUES ");
            addClass.Append("(@ClassName,");
            addClass.Append("@ClassDescription)");
            try
            {
                using (var conn = _conn)
                {
                    conn.Open();
                    return conn.Execute(addClass.ToString(), cls);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int DeleteClass(int id)
        {
            try
            {
                using (var conn = _conn)
                {
                    conn.Open();
                    return conn.Execute("DELETE FROM `CODE_WARS`.`CLASS` WHERE Id = @id", new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int UpdateClass(Class cls)
        {
            StringBuilder updateClass = new StringBuilder();
            updateClass.Append("UPDATE `CODE_WARS`.`CLASS` SET ");
            updateClass.Append("(`ClassName` = @ClassName,");
            updateClass.Append("`ClassDescription` = @ClassDescription");
            updateClass.Append(");");
            updateClass.Append("WHERE Id = @Id");
            try
            {
                using (var conn = _conn)
                {
                    conn.Open();
                    return conn.Execute(updateClass.ToString(), cls);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<Class> GetClass(int id)
        {
            try
            {
                using (var conn = _conn)
                {
                    conn.Open();
                    return conn.Query<Task<Class>>("SELECT ProductId AS Id, Name FROM product WHERE ProductId = @Id", new { id }).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<IEnumerable<Class>> GetClasses()
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.QueryAsync<Class>("SELECT * FROM `CODE_WARS`.`CLASS` ORDER BY `ClassName`;");
            }
        }
        public int CreateClassTable()
        {
            StringBuilder createClassTable = new StringBuilder();
            createClassTable.Append("CREATE TABLE IF NOT EXISTS `CODE_WARS`.`CLASS`");
            createClassTable.Append("(`Id` int not null auto_increment,");
            createClassTable.Append("`ClassName` varchar(255) not null,");
            createClassTable.Append("`ClassDescription` varchar(255) not null,");
            createClassTable.Append("Primary Key(`Id`)");
            createClassTable.Append(");");
            try
            {
                using (var conn = _conn)
                {
                    conn.Open();
                    return conn.Execute(createClassTable.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
