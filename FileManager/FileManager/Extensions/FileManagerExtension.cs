using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Extensions
{
    public static class FileManagerExtension
    {
        public static List<string> GetFilesName(this List<string> pathFiles)
        {
            var response = pathFiles.Select(fl => fl.Split("\\").Last()).ToList();
            return response;
        }
    }
}
