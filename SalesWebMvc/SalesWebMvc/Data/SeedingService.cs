using Org.BouncyCastle.Security;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department { Id = 1, Name = "Computers" };
            Department d2 = new Department { Id = 2, Name = "Eletronics" };
            Department d3 = new Department { Id = 3, Name = "Fashion" };
            Department d4 = new Department { Id = 4, Name = "Books" };

            Seller s1 = new Seller { Id = 1, Name = "Bob Brown", Email = "bobbrown@gmail.com", BirthDate = new DateTime(1994, 4, 21), BaseSalary = 1000.0, Department = d1 };
            Seller s2 = new Seller { Id = 2, Name = "Maria Green", Email = "mariagreen@gmail.com", BirthDate = new DateTime(1972,1 , 03), BaseSalary = 1000.0, Department = d2 };
            Seller s3 = new Seller { Id = 3, Name = "Alex Grey", Email = "alexgrey@gmail.com", BirthDate = new DateTime(1990, 2, 9), BaseSalary = 2000.0, Department = d3 };
            Seller s4 = new Seller { Id = 4, Name = "Martha Red", Email = "marthared@gmail.com", BirthDate = new DateTime(2002, 8, 15), BaseSalary = 4000.0, Department = d1 };
            Seller s5 = new Seller { Id = 5, Name = "Donald Blue", Email = "donaldblue@gmail.com", BirthDate = new DateTime(1987, 7, 2), BaseSalary = 2000.0, Department = d2 };
            Seller s6 = new Seller { Id = 6, Name = "Alex Pink", Email = "alexpink@gmail.com", BirthDate = new DateTime(1990, 9, 28), BaseSalary = 3000.0, Department = d4 };

            SalesRecord r1 = new SalesRecord { Id = 1, Date = new DateTime(2018, 09, 25), Amount = 11000.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r2 = new SalesRecord { Id = 2, Date = new DateTime(2018, 09, 4), Amount = 7000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r3 = new SalesRecord { Id = 3, Date = new DateTime(2018, 09, 13), Amount = 4000.0, Status = SaleStatus.Canceled, Seller = s4 };
            SalesRecord r4 = new SalesRecord { Id = 4, Date = new DateTime(2018, 09, 1), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r5 = new SalesRecord { Id = 5, Date = new DateTime(2018, 09, 21), Amount = 3000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r6 = new SalesRecord { Id = 6, Date = new DateTime(2018, 09, 15), Amount = 2000.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r7 = new SalesRecord { Id = 7, Date = new DateTime(2018, 09, 28), Amount = 13000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r8 = new SalesRecord { Id = 8, Date = new DateTime(2018, 09, 11), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r9 = new SalesRecord { Id = 9, Date = new DateTime(2018, 09, 14), Amount = 11000.0, Status = SaleStatus.Pending, Seller = s6 };
            SalesRecord r10 = new SalesRecord { Id = 10, Date = new DateTime(2018, 09, 7), Amount = 9000.0, Status = SaleStatus.Billed, Seller = s6 };
            SalesRecord r11 = new SalesRecord { Id = 11, Date = new DateTime(2018, 09, 13), Amount = 6000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r12 = new SalesRecord { Id = 12, Date = new DateTime(2018, 09, 25), Amount = 7000.0, Status = SaleStatus.Pending, Seller = s3 };
            SalesRecord r13 = new SalesRecord { Id = 13, Date = new DateTime(2018, 09, 29), Amount = 10000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r14 = new SalesRecord { Id = 14, Date = new DateTime(2018, 09, 4), Amount = 3000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r15 = new SalesRecord { Id = 15, Date = new DateTime(2018, 09, 12), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r16 = new SalesRecord { Id = 16, Date = new DateTime(2018, 10, 5), Amount = 2000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r17 = new SalesRecord { Id = 17, Date = new DateTime(2018, 10, 1), Amount = 12000.0, Status = SaleStatus.Billed, Seller = s1 };
            SalesRecord r18 = new SalesRecord { Id = 18, Date = new DateTime(2018, 10, 24), Amount = 6000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r19 = new SalesRecord { Id = 19, Date = new DateTime(2018, 10, 22), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r20 = new SalesRecord { Id = 20, Date = new DateTime(2018, 10, 15), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s6 };
            SalesRecord r21 = new SalesRecord { Id = 21, Date = new DateTime(2018, 10, 17), Amount = 9000.0, Status = SaleStatus.Billed, Seller = s2 };
            SalesRecord r22 = new SalesRecord { Id = 22, Date = new DateTime(2018, 10, 24), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r23 = new SalesRecord { Id = 23, Date = new DateTime(2018, 10, 19), Amount = 11000.0, Status = SaleStatus.Canceled, Seller = s2 };
            SalesRecord r24 = new SalesRecord { Id = 24, Date = new DateTime(2018, 10, 12), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r25 = new SalesRecord { Id = 25, Date = new DateTime(2018, 10, 31), Amount = 7000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r26 = new SalesRecord { Id = 26, Date = new DateTime(2018, 10, 6), Amount = 5000.0, Status = SaleStatus.Billed, Seller = s4 };
            SalesRecord r27 = new SalesRecord { Id = 27, Date = new DateTime(2018, 10, 13), Amount = 9000.0, Status = SaleStatus.Pending, Seller = s2 };
            SalesRecord r28 = new SalesRecord { Id = 28, Date = new DateTime(2018, 10, 7), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s3 };
            SalesRecord r29 = new SalesRecord { Id = 29, Date = new DateTime(2018, 10, 23), Amount = 12000.0, Status = SaleStatus.Billed, Seller = s5 };
            SalesRecord r30 = new SalesRecord { Id = 30, Date = new DateTime(2018, 10, 12), Amount = 5000.0, Status = SaleStatus.Billed, Seller = s2 };

            //Inclusão de objetos no banco de dados:

            _context.Department.AddRange(d1, d2, d3, d4 );

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23,
                r24, r25, r26, r27, r28, r29, r30   
                );

            _context.SaveChanges();
        }
    }
}
