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
                batch.Code =  dt.Rows[0]["Code"].ToString();
            }
            return batch;
        }
        public void AddOrEditBatch(int batchId, int year, int courseId, string code)
        {
            _batchDataAccess.AddOrEditBatch(batchId, year, courseId, code);
        }

        public void DeleteBatch(int batchId)
        {
            _batchDataAccess.DeleteBatch(batchId);
        }
    }
}
