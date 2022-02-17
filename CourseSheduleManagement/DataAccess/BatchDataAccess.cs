﻿using System.Data;
using System.Data.SqlClient;

namespace CourseSheduleManagement.DataAccess
{
    public class BatchDataAccess : DataAccessBase
    {
        public DataTable GetBatches()
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {

                    };
            return RunProcedureQueryText("GetBatches", parameters).Tables[0];
        }

        public DataTable GetBatchById(int id)
        {
            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Id",id),
                    };
            return RunProcedureQueryText("select * from Batch where BatchId=@Id", parameters).Tables[0];
        }

        public void AddOrEditBatch(int batchId, int year, int courseId,string code)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@BatchId",batchId),
            new SqlParameter("@Year",year),
            new SqlParameter("@CourseId",courseId),
            new SqlParameter("@Code",code)
            };
            RunProcedureQuery("AddorEditBatch", parameters);
        }

        public void DeleteBatch(int batchId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@BatchId",batchId)

            };
            RunProcedureQuery("DeleteBatch", parameters);
        }
    }
}
