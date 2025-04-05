using NHibernate;
using QuestionLib.Entity;
using System;
using System.Collections;
using System.Data.SqlClient;

namespace QuestionLib.Business
{
    // Token: 0x02000026 RID: 38
    public class BOQuestion : BOBase
    {
        // Token: 0x060001B0 RID: 432 RVA: 0x00004597 File Offset: 0x00003597
        public BOQuestion(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x060001B1 RID: 433 RVA: 0x00006CA0 File Offset: 0x00005CA0
        public IList LoadPassageQuestion(int pid)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from Question q Where q.PID=:pid";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("pid", pid);
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

        // Token: 0x060001B2 RID: 434 RVA: 0x00006D28 File Offset: 0x00005D28
        public Question Load(int qid)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from Question q Where q.QID=:qid";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("qid", qid);
                result = q.List();
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return (result.Count > 0) ? ((Question)result[0]) : null;
        }

        // Token: 0x060001B3 RID: 435 RVA: 0x00006DC8 File Offset: 0x00005DC8
        public IList LoadByType(QuestionType type)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from Question q Where q.QType=:type";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("type", type);
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

        // Token: 0x060001B4 RID: 436 RVA: 0x00006E50 File Offset: 0x00005E50
        public IList LoadByTypeOfCourse(QuestionType type, string courseId)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from Question q Where q.QType=:type and CourseId=:courseId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("type", type);
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

        // Token: 0x060001B5 RID: 437 RVA: 0x00006EE4 File Offset: 0x00005EE4
        public IList LoadFillBlankByTypeOfCourse(string courseId)
        {
            IList result = null;
            QuestionType type = QuestionType.FILL_BLANK_ALL;
            QuestionType type2 = QuestionType.FILL_BLANK_EMPTY;
            QuestionType type3 = QuestionType.FILL_BLANK_GROUP;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from Question q Where (q.QType=:type1 OR q.QType=:type2 OR q.QType=:type3) and CourseId=:courseId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("type1", type);
                q.SetParameter("type2", type2);
                q.SetParameter("type3", type3);
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

        // Token: 0x060001B6 RID: 438 RVA: 0x00006FAC File Offset: 0x00005FAC
        public void Delete(int qid, QuestionType qt)
        {
            this.session = this.sessionFactory.OpenSession();
            ITransaction tran = this.session.BeginTransaction();
            try
            {
                string qry = "from Question q Where q.QID=" + qid.ToString();
                this.session.Delete(qry);
                qry = "from QuestionAnswer qa Where qa.QID=" + qid.ToString();
                this.session.Delete(qry);
                qry = string.Concat(new object[]
                {
                    "from QuestionLO qlo Where qlo.QType=",
                    (int)qt,
                    " and qlo.QID=",
                    qid
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

        // Token: 0x060001B7 RID: 439 RVA: 0x00007090 File Offset: 0x00006090
        public bool SaveList(IList list)
        {
            ISession session = this.sessionFactory.OpenSession();
            ITransaction tran = session.BeginTransaction();
            bool result;
            try
            {
                foreach (object obj in list)
                {
                    Question q = (Question)obj;
                    session.Save(q);
                    foreach (object obj2 in q.QuestionAnswers)
                    {
                        QuestionAnswer qa = (QuestionAnswer)obj2;
                        qa.QID = q.QID;
                        session.Save(qa);
                    }
                    q.QuestionLOs = BOLO.RemoveDupLO(q.QuestionLOs);
                    foreach (object obj3 in q.QuestionLOs)
                    {
                        QuestionLO qlo = (QuestionLO)obj3;
                        qlo.QID = q.QID;
                        qlo.QType = q.QType;
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

        // Token: 0x060001B8 RID: 440 RVA: 0x00007248 File Offset: 0x00006248
        public bool Delete(int chapterID, QuestionType qt, string conStr)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlTransaction tran = con.BeginTransaction();
            string sqlA = string.Concat(new object[]
            {
                "DELETE FROM QuestionAnswer WHERE qid in (SELECT qid FROM Question WHERE QType=",
                (int)qt,
                " AND chapterId=",
                chapterID,
                ")"
            });
            string sqlQLO = string.Concat(new object[]
            {
                "DELETE FROM QuestionLO WHERE qid in (SELECT qid FROM Question WHERE QType=",
                (int)qt,
                " AND chapterId=",
                chapterID,
                ")"
            });
            string sqlQ = string.Concat(new object[]
            {
                "DELETE FROM Question WHERE QType=",
                (int)qt,
                " AND chapterID=",
                chapterID
            });
            SqlCommand cmdA = new SqlCommand(sqlA, con);
            cmdA.Transaction = tran;
            SqlCommand cmdQLO = new SqlCommand(sqlQLO, con);
            cmdQLO.Transaction = tran;
            SqlCommand cmdQ = new SqlCommand(sqlQ, con);
            cmdQ.Transaction = tran;
            bool result;
            try
            {
                cmdA.ExecuteNonQuery();
                cmdQLO.ExecuteNonQuery();
                cmdQ.ExecuteNonQuery();
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
    }
}
