using NHibernate;
using QuestionLib.Entity;
using System;
using System.Collections;

namespace QuestionLib.Business
{
    // Token: 0x02000028 RID: 40
    public class BOQuestionLO : BOBase
    {
        // Token: 0x060001BB RID: 443 RVA: 0x00004597 File Offset: 0x00003597
        public BOQuestionLO(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x060001BC RID: 444 RVA: 0x00007414 File Offset: 0x00006414
        public IList LoadLO(QuestionType qType, int qid)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from QuestionLO qlo Where qlo.QType=:qType and qlo.QID=:qid";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("qType", qType);
                q.SetParameter("qid", qid);
                result = q.List();
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            ArrayList listLO = new ArrayList();
            BOLO bolo = new BOLO(NHHelper.GetSessionFactory());
            foreach (object obj in result)
            {
                QuestionLO qlo = (QuestionLO)obj;
                LO lo = bolo.Load(qlo.LOID);
                listLO.Add(lo);
            }
            return listLO;
        }

        // Token: 0x060001BD RID: 445 RVA: 0x00007524 File Offset: 0x00006524
        public void DeleteQuestionLO(int qid, QuestionType qType)
        {
            this.session = this.sessionFactory.OpenSession();
            ITransaction tran = this.session.BeginTransaction();
            try
            {
                string qry = string.Concat(new object[]
                {
                    "from QuestionLO qlo Where qlo.QType=",
                    (int)qType,
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
    }
}
