using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_04
{
    internal class Faculty : Employee
    {
        public string OfficeHours { get; set; }
        public string Rank { get; set; }

        public Faculty(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHired, string officeHours, string rank)
            : base(name, phoneNumber, emailAddress, department, salary, dateHired)
        {
            OfficeHours = officeHours;
            Rank = rank;
        }

        // Triển khai tính thưởng cho Faculty
        public override double CalculateBonus()
        {
            return 1000 + (0.05 * Salary);
        }

        // Triển khai tính ngày nghỉ phép cho Faculty
        public override int CalculateVacation()
        {
            int yearsEmployed = DateTime.Now.Year - DateHired.Year;
            if (yearsEmployed > 3)
            {
                return 5; // 5 tuần nghỉ phép
            }
            return 4; // Mặc định nếu <= 3 năm
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Rank: {Rank}, Office Hours: {OfficeHours}";
        }
    }
}
