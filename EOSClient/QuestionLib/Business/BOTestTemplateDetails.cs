using NHibernate;
using QuestionLib.Entity;
using System.Data;
using System.Data.SqlClient;

namespace QuestionLib.Business
{
    // Token: 0x0200002B RID: 43
    public class BOTestTemplateDetails : BOBase
    {
        // Token: 0x060001C8 RID: 456 RVA: 0x00004597 File Offset: 0x00003597
        public BOTestTemplateDetails(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x060001C9 RID: 457 RVA: 0x00007B0C File Offset: 0x00006B0C
        public static DataTable LoadTestTemplateDetails(string testTemplateID, string conStr)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "SELECT tt.TestTemplateName AS 'Test template name', tt.CID, ch.Name AS 'Chapter', ttd.NoQInTest, tmp.QString AS 'Question type' FROM TestTemplateDetails AS ttd INNER JOIN TestTemplate AS tt ON tt.TestTemplateID = ttd.TestTemplateID INNER JOIN Chapter AS ch ON ch.ChID = ttd.ChapterID INNER JOIN (SELECT 0 AS QType, 'Reading' AS QString UNION SELECT 1 AS QType, 'Multiple choice' AS QString UNION SELECT 2 AS QType, 'Indicate mistake' AS QString UNION SELECT 3 AS QType, 'Match' AS QString UNION SELECT 4 AS QType, 'Fill blank' AS QString ) AS tmp ON ttd.QuestionType = tmp.QType WHERE tt.TestTemplateID = @testTemplateID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("testTemplateID", SqlDbType.Int);
            cmd.Parameters["testTemplateID"].Value = testTemplateID;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Token: 0x060001CA RID: 458 RVA: 0x00007B88 File Offset: 0x00006B88
        public static DataTable LoadTestTemplateDetails(QuestionType questionType, int testTemplateID, string conStr)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "SELECT ChapterId,QuestionType,NoQInTest FROM TestTemplateDetails WHERE TestTemplateID = @testTemplateID AND QuestionType = @questionType ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("testTemplateID", SqlDbType.Int);
            cmd.Parameters["testTemplateID"].Value = testTemplateID;
            cmd.Parameters.Add("questionType", SqlDbType.Int);
            cmd.Parameters["questionType"].Value = questionType;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
