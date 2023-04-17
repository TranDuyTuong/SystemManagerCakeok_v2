using Library.DataTable.TableRole;
using Library.DataTable.TableStaff;
using Library.DataTable.TableUser;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.DataExtestion
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_City>().HasData(
                new T_City() { IDCity = 1, Name = "Tp.Hcm", Status = true },
                new T_City() { IDCity = 2, Name = "Tp.Hà Nội", Status = true },
                new T_City() { IDCity = 3, Name = "Tp.Đà Lạt", Status = true },
                new T_City() { IDCity = 4, Name = "Tp.Cần Thơ", Status = true },
                new T_City() { IDCity = 5, Name = "Tp.Long Xuyên", Status = true },
                new T_City() { IDCity = 6, Name = "Tp.Long Khánh", Status = true },
                new T_City() { IDCity = 7, Name = "Tp.Huế", Status = true }
                );
            modelBuilder.Entity<T_District>().HasData(
                new T_District() { IDDistrict = 1, Name = "Quận 1", IDCity = 1, Status = true },
                new T_District() { IDDistrict = 2, Name = "Quận 2", IDCity = 1, Status = true },
                new T_District() { IDDistrict = 3, Name = "Quận 3", IDCity = 1, Status = true },
                new T_District() { IDDistrict = 4, Name = "Huyện Ba Vì", IDCity = 2, Status = true },
                new T_District() { IDDistrict = 5, Name = "Huyện Xuân Lộc", IDCity = 6, Status = true }
                );
            modelBuilder.Entity<T_Gender>().HasData(
                new T_Gender() { IDGender = 1, Name = "Nam", Status = true },
                new T_Gender() { IDGender = 2, Name = "Nữ", Status = true }
                );
            modelBuilder.Entity<T_Marriage>().HasData(
                new T_Marriage() { IDMarriage = 1, Name = "Độc Thân", Status = true },
                new T_Marriage() { IDMarriage = 2, Name = "Đã Kết Hôn", Status = true },
                new T_Marriage() { IDMarriage = 3, Name = "Đã Ly Hôn", Status = true }
                );
            modelBuilder.Entity<T_CustomerOrStaff>().HasData(
                new T_CustomerOrStaff() { IDCustomerOrStaff = 1, Name = "Khách Hàng", CreateDate = DateTime.UtcNow },
                new T_CustomerOrStaff() { IDCustomerOrStaff = 2, Name = "Nhân Viên", CreateDate = DateTime.UtcNow }
                );

            var IdStaffOrChef_1 = new Guid("B9C709E5-0AE2-4CA2-B5B1-1C6509FBA56C");
            var IdStaffOrChef_2 = new Guid("FB0AD9BD-9BE3-4557-AC8B-1001D48EC3B5");
            modelBuilder.Entity<T_StaffOrChef>().HasData(
                new T_StaffOrChef() { IDStaffOrChef = IdStaffOrChef_1, Name = "Nhân Viên Hỗ Trợ", CreateDate = DateTime.UtcNow, Status = true },
                new T_StaffOrChef() { IDStaffOrChef = IdStaffOrChef_2, Name = "Đầu Bếp Làm Bánh", CreateDate = DateTime.UtcNow, Status = true }
                );

            //Create Role 
            var IdRole_1 = new Guid("D6E0AC8A-7EED-4865-A6F0-3F5A8BA60BDC");
            modelBuilder.Entity<T_Role>().HasData(
                new T_Role() {
                    IDRole = IdRole_1,
                    NameRole = "Admin",
                    Symbol = "AD",
                    Discripttion = "Admin Quản Lý Toàn Bộ Hệ Thống",
                    CreateDate = DateTime.UtcNow
                }
                );

            //Create Account Defaul for Admin and User
            var hasher = new PasswordHasher<T_User>();
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var AccountIdAdmin = new Guid("723D5B79-51FA-45D1-8ED3-14C53580110F");
            var AccountIdUser = new Guid("44E41C5F-9EFE-4AEE-94D9-1361362A0E7E");
            modelBuilder.Entity<T_User>().HasData(
                new T_User()
                {
                    Id = AccountIdAdmin,
                    IDAccount = AccountIdAdmin,
                    UserName = "duytuong0503@gmail.com",
                    Email = "duytuong0503@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "Tuong123$"),
                    PassWord = hasher.HashPassword(null, "Tuong123$"),
                    EmailConfirmed = true,
                    CreateDate = DateTime.UtcNow,
                    IDCustomerOrStaff = 2,
                    PhoneNumber = "0335520146"
                }
                );

            // Create Staff
            var IdStaff_1 = new Guid("D8B14017-6271-4F1C-8C50-C06B06FCD28B");
            var GetDate = new DateTime().Date.ToString();
            var GetMonth = new DateTime().Month.ToString();
            var GetYear = new DateTime().Year.ToString();
            modelBuilder.Entity<T_Staff>().HasData(
                new T_Staff()
                {
                    IDStaff = IdStaff_1,
                    FullName = "Trần Duy Tường",
                    Birthday = new DateTime(2000, 03, 05),
                    Address = "Khu 13, Xã Long Đức, Huyện Long Thành, Tỉnh Đồng Nai",
                    Phone = "0335520146",
                    IDCode = "ID" + GetDate + GetMonth + GetYear + "0335520146",
                    CreateDate = DateTime.UtcNow,
                    IDMarriage = 1,
                    IDAccount = AccountIdAdmin,
                    IDCustomerOrStaff = 2,
                    IDCity = 1,
                    IDDistrict = 1,
                    IDGender = 1,
                    IDStaffOrChef = IdStaffOrChef_1
                }
                );

            //User Role
            modelBuilder.Entity<T_UserRole>().HasData(
                new T_UserRole()
                {
                    IDUserRole = 1,
                    CreateDate = DateTime.UtcNow,
                    Status = true,
                    IDRole = IdRole_1,
                    IDStaff = IdStaff_1
                }
                );


        }
    }
}
