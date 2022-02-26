using System;
using System.Data;
using System.Linq.Expressions;

namespace CourseSheduleManagement.Library
{
    public static class DataTableExtensions
    {
        public static T GetValue<T>(this DataTable dt, string fieldName)
        {

            T result = default(T);
            if (dt.Rows.Count == 0 || !dt.Columns.Contains(fieldName) || dt.Rows[0][fieldName] == DBNull.Value || dt.Rows[0].IsNull(fieldName))
            {
                return default(T);
            }
            if (typeof(T) == typeof(string))
            {
                result = (T)Convert.ChangeType(dt.Rows[0].Field<string>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(int))
            {
                result = (T)Convert.ChangeType(dt.Rows[0].Field<int>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(long))
            {
                result = (T)Convert.ChangeType(dt.Rows[0].Field<long>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(float))
            {
                result = (T)Convert.ChangeType(dt.Rows[0].Field<double>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(DateTime))
            {
                result = (T)Convert.ChangeType(dt.Rows[0].Field<DateTime>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(bool))
            {
                result = (T)Convert.ChangeType(dt.Rows[0].Field<bool>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(decimal))
            {
                result = (T)Convert.ChangeType(dt.Rows[0].Field<decimal>(fieldName), typeof(T));
            }
            if (typeof(T) == typeof(double))
            {
                result = (T)Convert.ChangeType(dt.Rows[0].Field<double>(fieldName), typeof(T));
            }
            return result;
        }
    }
}