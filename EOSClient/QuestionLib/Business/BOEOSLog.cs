using NHibernate;
using System;
using System.Collections;
using System.Globalization;

namespace QuestionLib.Business
{
    // Token: 0x02000022 RID: 34
    public class BOEOSLog : BOBase
    {
        // Token: 0x0600019B RID: 411 RVA: 0x00004597 File Offset: 0x00003597
        public BOEOSLog(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x0600019C RID: 412 RVA: 0x00005D88 File Offset: 0x00004D88
        public IList LoadLog(string username, string fromdate, string todate)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string where = "";
                string query = "from EOSLog t Where 1=1 ";
                bool flag = username != "";
                if (flag)
                {
                    where += " and Log_Account like :username ";
                }
                bool flag2 = fromdate != "";
                if (flag2)
                {
                    where += " and CreatedDate >= :fromdate ";
                }
                bool flag3 = todate != "";
                if (flag3)
                {
                    where += " and CreatedDate <= :todate ";
                }
                query += where;
                IQuery q = this.session.CreateQuery(query);
                bool flag4 = username != "";
                if (flag4)
                {
                    q.SetParameter("username", "%" + username + "%");
                }
                bool flag5 = fromdate != "";
                if (flag5)
                {
                    q.SetParameter("fromdate", DateTime.ParseExact(fromdate + " 00:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
                }
                bool flag6 = todate != "";
                if (flag6)
                {
                    q.SetParameter("todate", DateTime.ParseExact(todate + " 23:59:59", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
                }
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
