using NHibernate;
using QuestionLib.Entity;
using System;
using System.Collections;
using System.Data.SqlClient;

namespace QuestionLib.Business
{
    // Token: 0x0200001E RID: 30
    public class BOBase
    {
        // Token: 0x0600017C RID: 380 RVA: 0x000037C2 File Offset: 0x000027C2
        public BOBase()
        {
        }

        // Token: 0x0600017D RID: 381 RVA: 0x00004F7A File Offset: 0x00003F7A
        public BOBase(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        // Token: 0x0600017E RID: 382 RVA: 0x00004F8C File Offset: 0x00003F8C
        public object SaveOrUpdate(object obj)
        {
            this.session = this.sessionFactory.OpenSession();
            using (ITransaction tx = this.session.BeginTransaction())
            {
                try
                {
                    this.session.SaveOrUpdate(obj);
                    this.session.Flush();
                    tx.Commit();
                    this.session.Close();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    this.session.Close();
                    throw ex;
                }
            }
            return obj;
        }

        // Token: 0x0600017F RID: 383 RVA: 0x00005028 File Offset: 0x00004028
        public object Save(object obj)
        {
            this.session = this.sessionFactory.OpenSession();
            using (ITransaction tx = this.session.BeginTransaction())
            {
                try
                {
                    this.session.Save(obj);
                    this.session.Flush();
                    tx.Commit();
                    this.session.Close();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    this.session.Close();
                    throw ex;
                }
            }
            return obj;
        }

        // Token: 0x06000180 RID: 384 RVA: 0x000050C4 File Offset: 0x000040C4
        public object Save(object obj, ISession mySession)
        {
            try
            {
                mySession.Save(obj);
                mySession.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        // Token: 0x06000181 RID: 385 RVA: 0x000050FC File Offset: 0x000040FC
        public object Update(object obj)
        {
            this.session = this.sessionFactory.OpenSession();
            using (ITransaction tx = this.session.BeginTransaction())
            {
                try
                {
                    this.session.Update(obj);
                    this.session.Flush();
                    tx.Commit();
                    this.session.Close();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    this.session.Close();
                    throw ex;
                }
            }
            return obj;
        }

        // Token: 0x06000182 RID: 386 RVA: 0x00005198 File Offset: 0x00004198
        public object Update(object obj, ISession mySession)
        {
            try
            {
                mySession.Update(obj);
                mySession.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        // Token: 0x06000183 RID: 387 RVA: 0x000051D0 File Offset: 0x000041D0
        public void Load(object obj, object id)
        {
            this.session = this.sessionFactory.OpenSession();
            try
            {
                this.session.Load(obj, id);
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
        }

        // Token: 0x06000184 RID: 388 RVA: 0x00005230 File Offset: 0x00004230
        public void Delete(object obj)
        {
            this.session = this.sessionFactory.OpenSession();
            using (ITransaction tx = this.session.BeginTransaction())
            {
                try
                {
                    this.session.Delete(obj);
                    this.session.Flush();
                    tx.Commit();
                    this.session.Close();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    this.session.Close();
                    throw ex;
                }
            }
        }

        // Token: 0x06000185 RID: 389 RVA: 0x000052D0 File Offset: 0x000042D0
        public IList List(string typeName)
        {
            IList result = null;
            this.session = this.sessionFactory.OpenSession();
            using (ITransaction tx = this.session.BeginTransaction())
            {
                IQuery q = this.session.CreateQuery("from " + typeName);
                result = q.List();
                tx.Commit();
                this.session.Close();
            }
            return result;
        }

        // Token: 0x06000186 RID: 390 RVA: 0x00005354 File Offset: 0x00004354
        public IList ListID(string typeName, QuestionType qt, int chapterID)
        {
            IList result = null;
            bool flag = qt == QuestionType.READING;
            string id;
            string qType;
            if (flag)
            {
                id = "pid";
                qType = "=0";
            }
            else
            {
                bool flag2 = qt == QuestionType.MULTIPLE_CHOICE;
                if (flag2)
                {
                    id = "qid";
                    qType = "=1";
                }
                else
                {
                    bool flag3 = qt == QuestionType.INDICATE_MISTAKE;
                    if (flag3)
                    {
                        id = "qid";
                        qType = "=2";
                    }
                    else
                    {
                        bool flag4 = qt == QuestionType.MATCH;
                        if (flag4)
                        {
                            id = "mid";
                            qType = "=3";
                        }
                        else
                        {
                            id = "qid";
                            qType = ">3";
                        }
                    }
                }
            }
            string sql = string.Concat(new object[]
            {
                "SELECT ",
                id,
                " FROM ",
                typeName,
                " WHERE chapterId=",
                chapterID,
                " AND qType=",
                qType
            });
            SqlConnection con = (SqlConnection)this.sessionFactory.ConnectionProvider.GetConnection();
            return result;
        }

        // Token: 0x06000187 RID: 391 RVA: 0x00005448 File Offset: 0x00004448
        public IList ListID(string typeName, QuestionType qt, string courseID)
        {
            return null;
        }

        // Token: 0x040000B6 RID: 182
        protected ISessionFactory sessionFactory;

        // Token: 0x040000B7 RID: 183
        protected ISession session;
    }
}
