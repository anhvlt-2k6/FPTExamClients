using NHibernate;
using QuestionLib.Entity;
using System;
using System.Collections;

namespace QuestionLib.Business
{
    // Token: 0x02000029 RID: 41
    public class BOTest : BOBase
    {
        // Token: 0x060001BE RID: 446 RVA: 0x00004597 File Offset: 0x00003597
        public BOTest(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x060001BF RID: 447 RVA: 0x000075CC File Offset: 0x000065CC
        public IList LoadTest(string courseId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from Test t Where CourseId=:courseId";
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

        // Token: 0x060001C0 RID: 448 RVA: 0x0000764C File Offset: 0x0000664C
        public Test LoadTestByTestId(string testId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from Test t Where TestId=:testId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("testId", testId);
                result = q.List();
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            bool flag = result.Count > 0;
            Test result2;
            if (flag)
            {
                result2 = (Test)result[0];
            }
            else
            {
                result2 = null;
            }
            return result2;
        }

        // Token: 0x060001C1 RID: 449 RVA: 0x000076EC File Offset: 0x000066EC
        public IList LoadTestByCourse(string courseId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from Test t Where CourseId=:courseId";
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

        // Token: 0x060001C2 RID: 450 RVA: 0x0000776C File Offset: 0x0000676C
        public bool IsTestExists(string testId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from Test t Where TestId=:testId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("testId", testId);
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
    }
}
