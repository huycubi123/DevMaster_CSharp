using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_04
{
    internal class Staff : Employee
    {
        public string Title { get; set; }

        public Staff(string name, string phoneNumber, string emailAddress, string department, double salary, DateTime dateHired, string title)
            : base(name, phoneNumber, emailAddress, department, salary, dateHired)
        {
            Title = title;
        }

        // Triển khai tính thưởng cho Staff
        public override double CalculateBonus()
        {
            return 0.06 * Salary;
        }

        // Triển khai tính ngày nghỉ phép cho Staff
        public override int CalculateVacation()
        {
            int yearsEmployed = DateTime.Now.Year - DateHired.Year;
            if (yearsEmployed > 5)
            {
                return 4; // 4 tuần nếu trên 5 năm
            }
            return 3; // 3 tuần cho nhân viên bình thường
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Title: {Title}";
        }
    }
}
