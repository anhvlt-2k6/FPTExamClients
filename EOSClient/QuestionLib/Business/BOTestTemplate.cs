using NHibernate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuestionLib.Business
{
    // Token: 0x0200002A RID: 42
    public class BOTestTemplate : BOBase
    {
        // Token: 0x060001C3 RID: 451 RVA: 0x00004597 File Offset: 0x00003597
        public BOTestTemplate(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x060001C4 RID: 452 RVA: 0x00007800 File Offset: 0x00006800
        public bool IsTestTemplateExists(string testTemplateName)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from TestTemplate t Where TestTemplateName=:testTemplateName";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("testTemplateName", testTemplateName);
                result = q.List();
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            bool flag = result.Count == 0;
            return !flag;
        }

        // Token: 0x060001C5 RID: 453 RVA: 0x00007894 File Offset: 0x00006894
        public static DataTable LoadTestTemplate(string CID, string conStr)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "SELECT tt.TestTemplateID, tt.TestTemplateName AS 'Template name', tt.CID, c.Name AS 'Course name', tt.CreatedBy, tt.CreatedDate, tt.DistinctWithLastTest AS 'Distinct last tests',tt.Duration, tt.Note FROM TestTemplate AS tt INNER JOIN Course AS c ON tt.CID = c.CID WHERE tt.CID = @CID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("CID", SqlDbType.NVarChar);
            cmd.Parameters["CID"].Value = CID;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Token: 0x060001C6 RID: 454 RVA: 0x00007910 File Offset: 0x00006910
        public static bool Delete(int testTemplateID, string conStr)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlTransaction tran = con.BeginTransaction();
            string sqlTTD = "DELETE FROM TestTemplateDetails WHERE TestTemplateID = @testTemplateID";
            string sqlTT = "DELETE FROM TestTemplate WHERE TestTemplateID = @testTemplateID";
            SqlCommand cmdTTD = new SqlCommand(sqlTTD, con);
            cmdTTD.Parameters.Add("testTemplateID", SqlDbType.Int);
            cmdTTD.Parameters["testTemplateID"].Value = testTemplateID;
            cmdTTD.Transaction = tran;
            SqlCommand cmdTT = new SqlCommand(sqlTT, con);
            cmdTT.Parameters.Add("testTemplateID", SqlDbType.Int);
            cmdTT.Parameters["testTemplateID"].Value = testTemplateID;
            cmdTT.Transaction = tran;
            bool result;
            try
            {
                cmdTTD.ExecuteNonQuery();
                cmdTT.ExecuteNonQuery();
                tran.Commit();
                con.Close();
                result = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                con.Close();
                throw ex;
            }
            return result;
        }

        // Token: 0x060001C7 RID: 455 RVA: 0x00007A10 File Offset: 0x00006A10
        public static List<string> GetDistinctTestIds(string courseID, int testTemplateID, string conStr)
        {
            List<string> list = new List<string>();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "SELECT DistinctWithLastTest FROM TestTemplate WHERE TestTemplateID = @testTemplateID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("testTemplateID", SqlDbType.Int);
            cmd.Parameters["testTemplateID"].Value = testTemplateID;
            object obj = cmd.ExecuteScalar();
            int numOfDistinctTests = Convert.ToInt32(obj.ToString());
            sql = "SELECT TOP " + numOfDistinctTests + " TestID FROM Test WHERE CourseID=@courseID ORDER BY InsertOrder DESC";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("courseID", SqlDbType.NVarChar);
            cmd.Parameters["courseID"].Value = courseID;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetString(0));
            }
            dr.Close();
            con.Close();
            return list;
        }
    }
}
