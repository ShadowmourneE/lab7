namespace Lab7Galchenko.Services
{
    using Lab7Galchenko.DTO;
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class ExportService
    {
        public void ExportToTxtFile(ExportFileDTO fileData) {
            using var file = new StreamWriter(
                Path.Combine(Directory.GetCurrentDirectory(), fileData.FileName), 
                false, 
                Encoding.UTF8
            );

            file.WriteLineAsync($"Entered Phone: {fileData.Phone}");
            file.WriteLineAsync($"Entered UserName:  {fileData.UserName}");
        }
    }
}
