using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSheduleManagement.Library
{
    public static class DataRowExtensions
    {
        public static T GetValue<T>(this DataRow row, string fieldName)
        {
            T result = default(T);
            if (!row.Table.Columns.Contains(fieldName) || row[fieldName] == DBNull.Value || row.IsNull(fieldName))
            {
                return default(T);
            }
            if (typeof(T) == typeof(string))
            {
                result = (T)Convert.ChangeType(row.Field<string>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(int))
            {
                result = (T)Convert.ChangeType(row.Field<int>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(long))
            {
                result = (T)Convert.ChangeType(row.Field<long>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(DateTime))
            {
                result = (T)Convert.ChangeType(row.Field<DateTime>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(bool))
            {
                result = (T)Convert.ChangeType(row.Field<bool>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(decimal))
            {
                result = (T)Convert.ChangeType(row.Field<decimal>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(double))
            {
                result = (T)Convert.ChangeType(row.Field<double>(fieldName), typeof(T));
            }
            return result;
        }
    }
}
