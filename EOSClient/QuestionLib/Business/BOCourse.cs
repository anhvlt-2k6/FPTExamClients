using NHibernate;
using System;
using System.Collections;

namespace QuestionLib.Business
{
    // Token: 0x02000020 RID: 32
    public class BOCourse : BOBase
    {
        // Token: 0x0600018D RID: 397 RVA: 0x00004597 File Offset: 0x00003597
        public BOCourse(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        // Token: 0x0600018E RID: 398 RVA: 0x000056CC File Offset: 0x000046CC
        public IList LoadChapterByCourse(string courseId)
        {
            this.session = this.sessionFactory.OpenSession();
            IList result;
            try
            {
                string query = "from Chapter ch Where CID=:courseId";
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

        // Token: 0x0600018F RID: 399 RVA: 0x0000574C File Offset: 0x0000474C
        public bool IsCourseExists(string courseId)
        {
            bool exists = false;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from Course c Where CID=:courseId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("courseId", courseId);
                IList result = q.List();
                this.session.Close();
                bool flag = result.Count > 0;
                if (flag)
                {
                    exists = true;
                }
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return exists;
        }

        // Token: 0x06000190 RID: 400 RVA: 0x000057E0 File Offset: 0x000047E0
        public bool IsCourseImage(string courseId)
        {
            bool exists = false;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "from Course c Where CID=:courseId and ImageSize != 0";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("courseId", courseId);
                IList result = q.List();
                this.session.Close();
                bool flag = result.Count > 0;
                if (flag)
                {
                    exists = true;
                }
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return exists;
        }

        // Token: 0x06000191 RID: 401 RVA: 0x00005874 File Offset: 0x00004874
        public byte[] GetImageDataByCourse(string courseId)
        {
            byte[] imageData = null;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "select c.ImageData from Course c Where c.CID = :courseId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("courseId", courseId);
                object result = q.UniqueResult();
                bool flag = result != null;
                if (flag)
                {
                    imageData = (result as byte[]);
                }
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return imageData;
        }

        // Token: 0x06000192 RID: 402 RVA: 0x00005908 File Offset: 0x00004908
        public int GetImageSizeByCourse(string courseId)
        {
            int imageSize = 0;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "select c.ImageSize from Course c Where c.CID = :courseId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("courseId", courseId);
                object result = q.UniqueResult();
                bool flag = result != null;
                if (flag)
                {
                    imageSize = (int)result;
                }
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return imageSize;
        }

        // Token: 0x06000193 RID: 403 RVA: 0x0000599C File Offset: 0x0000499C
        public int GetImageNumberOfPageByCourse(string courseId)
        {
            int numberOfPage = 0;
            this.session = this.sessionFactory.OpenSession();
            try
            {
                string query = "select c.NumberOfPage from Course c Where c.CID = :courseId";
                IQuery q = this.session.CreateQuery(query);
                q.SetParameter("courseId", courseId);
                object result = q.UniqueResult();
                bool flag = result != null;
                if (flag)
                {
                    numberOfPage = (int)result;
                }
                this.session.Close();
            }
            catch (Exception ex)
            {
                this.session.Close();
                throw ex;
            }
            return numberOfPage;
        }
    }
}
