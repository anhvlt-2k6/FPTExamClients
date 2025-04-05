using NHibernate;
using QuestionLib.Entity;
using System;
using System.Collections;
using System.Data.SqlClient;

namespace QuestionLib.Business
{
    // Token: 0x02000024 RID: 36
    public class BOMatchQuestion : BOBase
    {
        // Token: 0x060001A4 RID: 420 RVA: 0x00004597 File Offset: 0x00003597
        public BOMatchQuestion(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x060001A5 RID: 421 RVA: 0x00006308 File Offset: 0x00005308
        public MatchQuestion LoadMatch(int mid)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from MatchQuestion mq Where  mq.MID=:mid";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("mid", mid);
                result = q.List();
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return (result.Count > 0) ? ((MatchQuestion)result[0]) : null;
        }

        // Token: 0x060001A6 RID: 422 RVA: 0x000063A4 File Offset: 0x000053A4
        public IList LoadMatchOfCourse(string courseId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from MatchQuestion mq Where  mq.CourseId=:courseId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("courseId", courseId);
                result = q.List();
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return result;
        }

        // Token: 0x060001A7 RID: 423 RVA: 0x00006424 File Offset: 0x00005424
        public bool SaveList(IList list)
        {
            ISession session = this.sessionFactory.OpenSession();
            ITransaction tran = session.BeginTransaction();
            bool result;
            try
            {
                foreach (object obj in list)
                {
                    MatchQuestion q = (MatchQuestion)obj;
                    session.Save(q);
                    q.QuestionLOs = BOLO.RemoveDupLO(q.QuestionLOs);
                    foreach (object obj2 in q.QuestionLOs)
                    {
                        QuestionLO qlo = (QuestionLO)obj2;
                        qlo.QID = q.MID;
                        qlo.QType = QuestionType.MATCH;
                        session.Save(qlo);
                    }
                }
                tran.Commit();
                result = true;
            }
            catch
            {
                tran.Rollback();
                result = false;
            }
            return result;
        }

        // Token: 0x060001A8 RID: 424 RVA: 0x00006544 File Offset: 0x00005544
        public bool Delete(int chapterID, string conStr)
        {
            int qt = 3;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlTransaction tran = con.BeginTransaction();
            string sqlLO = string.Concat(new object[]
            {
                "DELETE FROM QuestionLO WHERE QType = ",
                qt,
                " AND qid IN (SELECT mid FROM MatchQuestion WHERE chapterID=",
                chapterID,
                ")"
            });
            string sqlMQ = "DELETE FROM MatchQuestion WHERE chapterID=" + chapterID;
            SqlCommand cmdLO = new SqlCommand(sqlLO, con);
            cmdLO.Transaction = tran;
            SqlCommand cmdMQ = new SqlCommand(sqlMQ, con);
            cmdMQ.Transaction = tran;
            bool result;
            try
            {
                cmdLO.ExecuteNonQuery();
                cmdMQ.ExecuteNonQuery();
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

        // Token: 0x060001A9 RID: 425 RVA: 0x00006620 File Offset: 0x00005620
        public void Delete(MatchQuestion m)
        {
            int mid = m.MID;
            this.session = this.sessionFactory.OpenSession();
            ITransaction tran = this.session.BeginTransaction();
            try
            {
                string qry = "from MatchQuestion mq Where mq.MID=" + mid.ToString();
                this.session.Delete(qry);
                int qT = 3;
                qry = string.Concat(new object[]
                {
                    "from QuestionLO qlo Where qlo.QType=",
                    qT,
                    " and qlo.QID=",
                    mid
                });
                this.session.Delete(qry);
                tran.Commit();
                this.session.Close();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                this.session.Close();
                throw ex;
            }
        }
    }
}
