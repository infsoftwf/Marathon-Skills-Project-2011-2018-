using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonProject.Global
{
    public static class SqlEx
    {
        public static T MyAttributeExists<T>(String param, SqlConnection m_sqlCn)
        {
            T IResult = default(T);
            try
            {
                using (var sqlcm_select = new SqlCommand(param, m_sqlCn))
                {
                    using (SqlDataReader m_DataRead = sqlcm_select.ExecuteReader())
                    {
                        if (m_DataRead != null)
                            if (m_DataRead.Read() && m_DataRead[0] != DBNull.Value)
                                IResult = (T)m_DataRead[0];
                    }
                }
            }
            catch (Exception) { }
            return IResult;
        }

        public static int MyAttributeQuery(String param, SqlConnection m_sqlCn)
        {
            using (var sqlcm = new SqlCommand(param, m_sqlCn))
            {
                return sqlcm.ExecuteNonQuery();
            }
        }

        private static IEnumerable<T> MyAttributeMultiple<T>(String param, SqlConnection m_sqlCn)
        {
            using (var sqlcm_select = new SqlCommand(param, m_sqlCn))
            {
                using (SqlDataReader m_DataRead = sqlcm_select.ExecuteReader())
                {
                    if (m_DataRead != null)
                        while (m_DataRead.Read())
                            yield return (T)m_DataRead[0];
                }
            }
        }
    }
}
