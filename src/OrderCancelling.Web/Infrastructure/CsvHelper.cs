using System.Configuration;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OrderCancelling.Web.Infrastructure
{
    public static class CsvHelper
    {
        private static string Folder = ConfigurationManager.AppSettings["CsvLocalPath"];

        public static async Task Append(string name, params string[] values)
        {
            using (var fs = File.OpenRead(Folder + name))
            {
                var buffer = GetBuffer(values);
                await fs.WriteAsync(buffer, 0, buffer.Length);
            }
        }

        private static byte[] GetBuffer(params string[] values)
        {
            var row = string.Join(",", values);
            return Encoding.UTF8.GetBytes(row);
        }
    }
}
