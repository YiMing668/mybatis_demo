using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.ibatis
{

    public static class BaseDA
    {
        public static void Insert<T>(string statementName, T t)
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
               iSqlMapper.Insert(statementName, t);
            }

        }

        public static int Update<T>(string statementName, T t)
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
                return iSqlMapper.Update(statementName, t);
            }
            return 0;
        }

        public static int Delete(string statementName, object primaryKeyId)
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
                return iSqlMapper.Delete(statementName, primaryKeyId);
            }
            return 0;
        }

        public static T Get<T>(string statementName, int primaryKeyId) where T : class
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
                return iSqlMapper.QueryForObject<T>(statementName, primaryKeyId);
            }
            return null;
        }

        public static IList<T> QueryForList<T>(string statementName, object parameterObject = null)
        {
            ISqlMapper iSqlMapper = Mapper.Instance();
            if (iSqlMapper != null)
            {
                return iSqlMapper.QueryForList<T>(statementName, parameterObject);
                //分页，跳过多少，获取多少条
                return iSqlMapper.QueryForList<T>(statementName, parameterObject,5,10);

            }
            return null;
        }
    }
}
