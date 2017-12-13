namespace SOLID_PRINCIPLE.SERVICEs.Implementation
{
    using Interface;
    using System;
    using CORE.Results;
    using System.Web;
    using System.Text.RegularExpressions;
    using System.IO;

    public class FileService : IFileService
    {
        public ActionServiceResult SaveFileToDir(HttpPostedFileBase file, string dirPath, out string fileName)
        {
            fileName = string.Empty;
            try
            {
                var isValid = ValidateFileUplpad(file.ContentLength, file.ContentType);
                if (isValid == false)
                {
                    return ActionServiceResult.Failed;
                }

                string tempName = Path.GetFileName(file.FileName);
                fileName = CreateUnitName(tempName);
                string path = Path.Combine(HttpContext.Current.Server.MapPath(dirPath), fileName);
                file.SaveAs(path);
                return ActionServiceResult.Succeed;
            }
            catch (Exception)
            {
                return ActionServiceResult.Failed;
            }
        }
        private bool ValidateFileUplpad(int size, string type)
        {
            if (size > 2 * 1024 * 1024)
            {
                return false;
            }
            var validFileTypes = new string[]
            {
                "image/jpeg",
                "image/pjpeg",
                "image/png",
                "application/octet-stream"
            };
            foreach (var item in validFileTypes)
            {
                if (type.ToLower().Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        private string CreateUnitName(string name)
        {
            string nameNoExtent = Regex.Replace(Path.GetFileNameWithoutExtension(name).Trim(), @"[^0-9a-zA-Z]+", "");
            return string.Concat(nameNoExtent,
                DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                Path.GetExtension(name));
        }
    }
}
