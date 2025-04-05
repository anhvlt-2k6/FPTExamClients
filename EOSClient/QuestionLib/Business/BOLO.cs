using NHibernate;
using QuestionLib.Entity;
using System;
using System.Collections;

namespace QuestionLib.Business
{
    // Token: 0x02000023 RID: 35
    public class BOLO : BOBase
    {
        // Token: 0x0600019D RID: 413 RVA: 0x00004597 File Offset: 0x00003597
        public BOLO(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x0600019E RID: 414 RVA: 0x00005F20 File Offset: 0x00004F20
        public LO Load(int loid)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from LO lo Where lo.LOID=:loid";
                IQuery a = this.session.CreateQuery(query);
                a.SetParameter("loid", loid);
                result = a.List();
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return (result.Count > 0) ? ((LO)result[0]) : null;
        }

        // Token: 0x0600019F RID: 415 RVA: 0x00005FC0 File Offset: 0x00004FC0
        public int GetLOID(string lo_name, string CID)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from LO lo Where lo.LO_Name=:lo_name And lo.CID=:CID";
                IQuery a = this.session.CreateQuery(query);
                a.SetParameter("lo_name", lo_name.Trim());
                a.SetParameter("CID", CID);
                result = a.List();
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            LO tmpLO = (LO)result[0];
            return tmpLO.LOID;
        }

        // Token: 0x060001A0 RID: 416 RVA: 0x00006070 File Offset: 0x00005070
        public IList LoadLOByCourse(string courseId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from LO lo Where lo.CID=:courseId";
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

        // Token: 0x060001A1 RID: 417 RVA: 0x000060F0 File Offset: 0x000050F0
        public bool IsLOExists(string CID, string lo_name)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from LO lo Where lo.CID=:CID And lo.LO_Name=:lo_name";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("lo_name", lo_name);
                q.SetParameter("CID", CID);
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

        // Token: 0x060001A2 RID: 418 RVA: 0x00006190 File Offset: 0x00005190
        public bool IsLODescriptionExists(string CID, string lo_desc)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from LO lo Where lo.CID=:CID And lo.LO_Desc=:lo_desc";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("lo_desc", lo_desc);
                q.SetParameter("CID", CID);
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

        // Token: 0x060001A3 RID: 419 RVA: 0x00006230 File Offset: 0x00005230
        public static ArrayList RemoveDupLO(ArrayList listLO)
        {
            ArrayList tmp = new ArrayList();
            foreach (object obj in listLO)
            {
                QuestionLO qlo = (QuestionLO)obj;
                bool exists = false;
                foreach (object obj2 in tmp)
                {
                    QuestionLO qloInTmp = (QuestionLO)obj2;
                    bool flag = qlo.LOID == qloInTmp.LOID;
                    if (flag)
                    {
                        exists = true;
                        break;
                    }
                }
                bool flag2 = !exists;
                if (flag2)
                {
                    tmp.Add(qlo);
                }
            }
            return tmp;
        }
    }
}
