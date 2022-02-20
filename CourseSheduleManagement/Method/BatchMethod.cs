using CourseSheduleManagement.DataAccess;
using CourseSheduleManagement.Models;
using System;
using System.Data;

namespace CourseSheduleManagement.Method
{
    public class BatchMethod
    {
        BatchDataAccess _batchDataAccess = new BatchDataAccess();

        public DataTable GetBatches()
        {
            DataTable dt = _batchDataAccess.GetBatches();
            
            return dt;
        }
        public Batch GetBatchById(int id)
        {
            Batch batch = new Batch();
            DataTable dt = _batchDataAccess.GetBatchById(id);
            if (dt.Rows.Count == 1)
            {
                batch.BatchId =Convert.ToInt32(dt.Rows[0]["BatchId"].ToString());
                batch.Year = Convert.ToInt32(dt.Rows[0]["Year"].ToString());
                batch.CourseId = Convert.ToInt32(dt.Rows[0]["CourseId"].ToString());
                batch.BatchCode =  dt.Rows[0]["BatchCode"].ToString();
            }
            return batch;
        }
        public void AddOrEditBatch(int batchId, int year, int courseId, string batchCode)
        {
            _batchDataAccess.AddOrEditBatch(batchId, year, courseId, batchCode);
        }

        public void DeleteBatch(int batchId)
        {
            _batchDataAccess.DeleteBatch(batchId);
        }

        public int GetBatchNo(int courseId, int year)
        {
            return _batchDataAccess.GetBatchNo(courseId, year);

        }
    }
}
