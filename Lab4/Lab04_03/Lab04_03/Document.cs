using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_03
{
    internal class Document : IStorage, IEncryptable
    {
        public string content { get; set; } = "Nội dung mặc định";
        public string Data
        {
            get { return content; }
            set { content = value; }
        }

        // Đọc file 
        public void Read(string filename)
        {
            Console.WriteLine($"Đang đọc tài liệu từ file: {filename}");
            try
            {
                // Mở file thông qua đối tượng FileStream
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    // Đọc file thông qua đối tượng StreamReader
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        content = reader.ReadToEnd();
                        Console.WriteLine("Đọc file thành công.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }
        }
        // Ghi file 
        public void Write(string filename)
        {
            Console.WriteLine($"Đang ghi tài liệu vào file: {filename}");
            try
            {
                // Mở file thông qua đối tượng FileStream
                using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
                {
                    // Ghi file thông qua đối tượng StreamWriter
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.Write(content);
                        Console.WriteLine("Ghi file thành công.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi ghi file: {ex.Message}");
            }
        }

        // Mã hóa và giải mã 
        public void Encrypt()
        {
            Console.WriteLine("Phương thức mã hóa Encrypt() đã được gọi.");
        }

        // Phương thức Decrypt chỉ in ra thông báo
        public void Decrypt()
        {
            Console.WriteLine("Phương thức giải mã Decrypt() đã được gọi.");
        }

    }
}
