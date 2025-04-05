using NHibernate;
using QuestionLib.Entity;
using System;
using System.Collections;

namespace QuestionLib.Business
{
    // Token: 0x0200001F RID: 31
    public class BOChapter : BOBase
    {
        // Token: 0x06000188 RID: 392 RVA: 0x00004597 File Offset: 0x00003597
        public BOChapter(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x06000189 RID: 393 RVA: 0x00005460 File Offset: 0x00004460
        public IList LoadFillBlankQuestionByChapter(int chapterId)
        {
            QuestionType qt = QuestionType.FILL_BLANK_ALL;
            QuestionType qt2 = QuestionType.FILL_BLANK_GROUP;
            QuestionType qt3 = QuestionType.FILL_BLANK_EMPTY;
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from Question q Where (q.QType=:type1 OR q.QType=:type2 OR q.QType=:type3)  AND ChapterId=:chapterId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("type1", qt);
                q.SetParameter("type2", qt2);
                q.SetParameter("type3", qt3);
                q.SetParameter("chapterId", chapterId.ToString());
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

        // Token: 0x0600018A RID: 394 RVA: 0x0000552C File Offset: 0x0000452C
        public IList LoadQuestionByChapter(QuestionType qt, int chapterId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from Question q Where q.QType=:type and ChapterId=:chapterId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("type", qt);
                q.SetParameter("chapterId", chapterId.ToString());
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

        // Token: 0x0600018B RID: 395 RVA: 0x000055C4 File Offset: 0x000045C4
        public IList LoadPassageByChapter(int chapterId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from Passage p Where ChapterId=:chapterId";
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

        // Token: 0x0600018C RID: 396 RVA: 0x00005648 File Offset: 0x00004648
        public IList LoadMatchQuestionByChapter(int chapterId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from MatchQuestion m Where ChapterId=:chapterId";
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
    }
}
