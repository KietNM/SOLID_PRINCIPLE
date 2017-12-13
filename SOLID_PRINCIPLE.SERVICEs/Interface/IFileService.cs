namespace SOLID_PRINCIPLE.SERVICEs.Interface
{
    using CORE.Results;
    using System.Web;

    public interface IFileService
    {
        ActionServiceResult SaveFileToDir(HttpPostedFileBase file, string dirPath, out string fileName);
    }
}
