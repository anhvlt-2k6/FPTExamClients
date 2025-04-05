using NHibernate;
using QuestionLib.Entity;
using System;
using System.Collections;

namespace QuestionLib.Business
{
    // Token: 0x02000021 RID: 33
    public class BOEssayQuestion : BOBase
    {
        // Token: 0x06000194 RID: 404 RVA: 0x00004597 File Offset: 0x00003597
        public BOEssayQuestion(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x06000195 RID: 405 RVA: 0x00005A30 File Offset: 0x00004A30
        public EssayQuestion Load(int eqid)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from EssayQuestion q Where q.EQID=:eqid";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("eqid", eqid);
                result = q.List();
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return (result.Count > 0) ? ((EssayQuestion)result[0]) : null;
        }

        // Token: 0x06000196 RID: 406 RVA: 0x00005AD0 File Offset: 0x00004AD0
        public IList LoadByCourse(string courseId)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from EssayQuestion q Where CourseId=:courseId";
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

        // Token: 0x06000197 RID: 407 RVA: 0x00005B54 File Offset: 0x00004B54
        public IList LoadByChapter(int chapterId)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from EssayQuestion q Where ChapterId=:chapterId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("chapterId", chapterId);
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

        // Token: 0x06000198 RID: 408 RVA: 0x00005BDC File Offset: 0x00004BDC
        public void Delete(int eqid)
        {
            this.session = this.sessionFactory.OpenSession();
            ITransaction tran = this.session.BeginTransaction();
            try
            {
                string qry = "from EssayQuestion q Where q.EQID=" + eqid.ToString();
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

        // Token: 0x06000199 RID: 409 RVA: 0x00005C64 File Offset: 0x00004C64
        public bool SaveList(IList list)
        {
            ISession session = this.sessionFactory.OpenSession();
            ITransaction tran = session.BeginTransaction();
            bool result;
            try
            {
                foreach (object obj in list)
                {
                    EssayQuestion q = (EssayQuestion)obj;
                    session.Save(q);
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

        // Token: 0x0600019A RID: 410 RVA: 0x00005D00 File Offset: 0x00004D00
        public void DeleteQuestionInChapter(int chapterId)
        {
            this.session = this.sessionFactory.OpenSession();
            ITransaction tran = this.session.BeginTransaction();
            try
            {
                string qry = "from EssayQuestion q Where q.ChapterId=" + chapterId.ToString();
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
