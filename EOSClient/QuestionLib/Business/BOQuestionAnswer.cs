using NHibernate;
using System;
using System.Collections;

namespace QuestionLib.Business
{
    // Token: 0x02000027 RID: 39
    public class BOQuestionAnswer : BOBase
    {
        // Token: 0x060001B9 RID: 441 RVA: 0x00004597 File Offset: 0x00003597
        public BOQuestionAnswer(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x060001BA RID: 442 RVA: 0x00007390 File Offset: 0x00006390
        public IList LoadAnswer(int qid)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from QuestionAnswer qa Where qa.QID=:qid";
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
            return result;
        }
    }
}
