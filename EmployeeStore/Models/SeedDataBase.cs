using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace EmployeeStore.Models
{
    public class SeedDataBase
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();
            if (!context.Employees.Any())
            {
                context.AddRangeAsync(
                    new Employee
                    {
                        Name = "Employee-1",
                        Department = "Teacher",
                        Email = "test@mail.com",
                        Description = "男，21岁，本科：浙江大学，专业为计算机科学与技术；",
                        Price = 55
                    },
                    new Employee
                    {
                        Name = "Employee-2",
                        Department = "Doctor",
                        Email = "test@mail.com",
                        Description = "女，25岁，硕士：香港大学 本科：浙江大学，专业为口腔医学；",
                        Price = 120
                    },
                    new Employee
                    {
                        Name = "Employee-3",
                        Department = "Builder",
                        Email = "test@mail.com",
                        Description = "男，23岁，本科：同济大学，专业为土木工程；",
                        Price = 25
                    },
                    new Employee
                    {
                        Name = "Employee-4",
                        Department = "Engineer",
                        Email = "test@mail.com",
                        Description = "男，20岁，本科：电子科技大学，专业为电子工程；",
                        Price = 75
                    },
                    new Employee
                    {
                        Name = "Employee-5",
                        Department = "Driver",
                        Email = "test@mail.com",
                        Description = "男，21岁，本科：蓝翔技工，专业为拖拉机专业；",
                        Price = 20
                    },
                    new Employee
                    {
                        Name = "Employee-6",
                        Department = "Servant",
                        Email = "test@mail.com",
                        Description = "男，29岁，本科：浙江理工大学，专业为会计专业；",
                        Price = 14
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
