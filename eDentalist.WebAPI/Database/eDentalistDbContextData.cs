using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public partial class eDentalistDbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentStatus>().HasData(
                new eDentalist.WebAPI.Database.AppointmentStatus() { AppointmentStatusID = 1, Name = "Pending" },
                new eDentalist.WebAPI.Database.AppointmentStatus() { AppointmentStatusID = 2, Name = "Done" },
                new eDentalist.WebAPI.Database.AppointmentStatus() { AppointmentStatusID = 3, Name = "Cancelled" },
                new eDentalist.WebAPI.Database.AppointmentStatus() { AppointmentStatusID = 4, Name = "Approved" },
                new eDentalist.WebAPI.Database.AppointmentStatus() { AppointmentStatusID = 5, Name = "Declined" });

            modelBuilder.Entity<EquipmentType>().HasData(
                new eDentalist.WebAPI.Database.EquipmentType() { EquipmentTypeID = 1, Name = "Dental Chair" },
                new eDentalist.WebAPI.Database.EquipmentType() { EquipmentTypeID = 2, Name = "Dental Engine" },
                new eDentalist.WebAPI.Database.EquipmentType() { EquipmentTypeID = 3, Name = "Miscellaneous" },
                new eDentalist.WebAPI.Database.EquipmentType() { EquipmentTypeID = 4, Name = "X-Ray Machine" },
                new eDentalist.WebAPI.Database.EquipmentType() { EquipmentTypeID = 5, Name = "Dental Laser" });

            modelBuilder.Entity<HygieneProcessType>().HasData(
                new eDentalist.WebAPI.Database.HygieneProcessType() { HygieneProcessTypeID = 1, Name = "Sterilization", Description = "Sterilization refers to any process that removes, kills, or deactivates all forms of life (in particular referring to microorganisms such as fungi, bacteria, spores, unicellular eukaryotic organisms such as Plasmodium, etc.) and other biological agents like prions present in a specific surface, object or fluid, for example food or biological culture media." },
                new eDentalist.WebAPI.Database.HygieneProcessType() { HygieneProcessTypeID = 2, Name = "Disinfection", Description = "Disinfection describes a process that eliminates many or all pathogenic microorganisms, except bacterial spores, on inanimate objects." });

            modelBuilder.Entity<Country>().HasData(
                new eDentalist.WebAPI.Database.Country() { CountryID = 1, Name = "Bosnia and Herzegovina" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 2, Name = "Croatia" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 3, Name = "Serbia" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 4, Name = "United States of America" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 5, Name = "France" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 6, Name = "Germany" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 7, Name = "Sweden" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 8, Name = "Norway" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 9, Name = "Denmark" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 10, Name = "Spain" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 11, Name = "Japan" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 12, Name = "China" },
                new eDentalist.WebAPI.Database.Country() { CountryID = 13, Name = "South Korea" });

            modelBuilder.Entity<City>().HasData(
                new eDentalist.WebAPI.Database.City() { CityID = 1, Name = "Mostar", CountryID = 1, ZIPCode = "88000" },
                new eDentalist.WebAPI.Database.City() { CityID = 2, Name = "Sarajevo", CountryID = 1, ZIPCode = "71000" },
                new eDentalist.WebAPI.Database.City() { CityID = 3, Name = "Banja Luka", CountryID = 1, ZIPCode = "78000" },
                new eDentalist.WebAPI.Database.City() { CityID = 4, Name = "Unassigned", CountryID = 1, ZIPCode = "00000" });

            modelBuilder.Entity<Gender>().HasData(
                new eDentalist.WebAPI.Database.Gender() { GenderID = 1, Name = "Male" },
                new eDentalist.WebAPI.Database.Gender() { GenderID = 2, Name = "Female" },
                new eDentalist.WebAPI.Database.Gender() { GenderID = 3, Name = "Other" },
                new eDentalist.WebAPI.Database.Gender() { GenderID = 4, Name = "Unassigned" });

            modelBuilder.Entity<UserRole>().HasData(
                new eDentalist.WebAPI.Database.UserRole() { UserRoleID = 1, Name = "Administrator", Description = "Administrative role that has access to all functionalities that the application offers." },
                new eDentalist.WebAPI.Database.UserRole() { UserRoleID = 2, Name = "Dentist", Description = "Sample text." },
                new eDentalist.WebAPI.Database.UserRole() { UserRoleID = 3, Name = "Patient", Description = "Sample text." });

            modelBuilder.Entity<Shift>().HasData(
                new eDentalist.WebAPI.Database.Shift() { ShiftID = 5, ShiftNumber = 1, From = TimeSpan.Parse("07:00:00"), To = TimeSpan.Parse("15:00:00") },
                new eDentalist.WebAPI.Database.Shift() { ShiftID = 6, ShiftNumber = 2, From = TimeSpan.Parse("15:00:00"), To = TimeSpan.Parse("23:00:00") });

            modelBuilder.Entity<Workday>().HasData(
                new eDentalist.WebAPI.Database.Workday() { WorkdayID = 1, Date = DateTime.Now.AddDays(-3) },
                new eDentalist.WebAPI.Database.Workday() { WorkdayID = 2, Date = DateTime.Now.AddDays(-2) },
                new eDentalist.WebAPI.Database.Workday() { WorkdayID = 3, Date = DateTime.Now.AddDays(-1) },
                new eDentalist.WebAPI.Database.Workday() { WorkdayID = 4, Date = DateTime.Now },
                new eDentalist.WebAPI.Database.Workday() { WorkdayID = 5, Date = DateTime.Now.AddDays(1) },
                new eDentalist.WebAPI.Database.Workday() { WorkdayID = 6, Date = DateTime.Now.AddDays(2) },
                new eDentalist.WebAPI.Database.Workday() { WorkdayID = 7, Date = DateTime.Now.AddDays(3) },
                new eDentalist.WebAPI.Database.Workday() { WorkdayID = 8, Date = DateTime.Now.AddDays(10) },
                new eDentalist.WebAPI.Database.Workday() { WorkdayID = 9, Date = DateTime.Now.AddDays(20) });

            modelBuilder.Entity<Procedure>().HasData(
               new eDentalist.WebAPI.Database.Procedure()
               {
                   ProcedureID = 2,
                   Name = "Direct Dental Bonding",
                   Description = "Sample Text 1",
                   Duration = TimeSpan.Parse("00:45:00"),
                   Price = 50,
                   Status = false
               },
               new eDentalist.WebAPI.Database.Procedure()
               {
                   ProcedureID = 3,
                   Name = "Composite Dental Bonding",
                   Description = "Sample Text 2",
                   Duration = TimeSpan.Parse("00:30:00"),
                   Price = 50,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Procedure()
               {
                   ProcedureID = 4,
                   Name = "Composite Veneer Bonding",
                   Description = "Sample Text 3",
                   Duration = TimeSpan.Parse("00:30:00"),
                   Price = 30,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Procedure()
               {
                   ProcedureID = 5,
                   Name = "Traditional Dental Bridge",
                   Description = "The Traditional type of bridge is composed of one dental crown adhered to both the surrounding teeth with a fake tooth or teeth in the between.  With this, the dental crowns provide anchor points, while the fake tooth “bridges” the gap.",
                   Duration = TimeSpan.Parse("00:30:00"),
                   Price = 45,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Procedure()
               {
                   ProcedureID = 6,
                   Name = "Cantilever Dental Bridge",
                   Description = "Cantilever dental bridges deviate in structure from traditional dental bridges and only use a single anchor tooth.",
                   Duration = TimeSpan.Parse("00:30:00"),
                   Price = 50,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Procedure()
               {
                   ProcedureID = 7,
                   Name = "Maryland Bonded Bridge",
                   Description = "A Maryland bonded bridge uses the same structure as a traditional dental bridge, however instead of using dental crowns as anchors, a metal or porcelain framework is used.",
                   Duration = TimeSpan.Parse("00:30:00"),
                   Price = 100,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Procedure()
               {
                   ProcedureID = 8,
                   Name = "Implant-Supported Bridge",
                   Description = "Implant-supported dental bridges use the same structure as traditional bridges, however they are anchored in place with dental implants.",
                   Duration = TimeSpan.Parse("00:30:00"),
                   Price = 20,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Procedure()
               {
                   ProcedureID = 9,
                   Name = "Dental Sealant",
                   Description = "Dental sealants, usually applied to the chewing surface of teeth, act as a barrier against decay-causing bacteria.",
                   Duration = TimeSpan.Parse("00:30:00"),
                   Price = 50,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Procedure()
               {
                   ProcedureID = 10,
                   Name = "Teeth Whitening",
                   Description = "Tooth whitening or tooth bleaching is the process of lightening the color of human teeth.",
                   Duration = TimeSpan.Parse("00:40:00"),
                   Price = 45,
                   Status = true
               });

            modelBuilder.Entity<Equipment>().HasData(
               new eDentalist.WebAPI.Database.Equipment()
               {
                   EquipmentID = 1,
                   Name = "Midmark Elevance",
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "The Elevance Dental Chair comes standard with programmable chair controls and a hydraulic drive system for smooth, quiet, precise operation.",
                   Condition = false,
                   Amount = 1,
                   EquipmentTypeID = 1
               },
               new eDentalist.WebAPI.Database.Equipment()
               {
                   EquipmentID = 2,
                   Name = "Belmont Quolis Q-5000",
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "Sample Description 1",
                   Condition = true,
                   Amount = 1,
                   EquipmentTypeID = 1
               },
               new eDentalist.WebAPI.Database.Equipment()
               {
                   EquipmentID = 4,
                   Name = "FIMET F1",
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "Sample Description 2",
                   Condition = false,
                   Amount = 1,
                   EquipmentTypeID = 2
               },
               new eDentalist.WebAPI.Database.Equipment()
               {
                   EquipmentID = 5,
                   Name = "EdgeMaker2000 Surgical Sharpening System",
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "Sample Description 3",
                   Condition = true,
                   Amount = 4,
                   EquipmentTypeID = 3
               },
               new eDentalist.WebAPI.Database.Equipment()
               {
                   EquipmentID = 6,
                   Name = "Mercury 3 Dental Laser System",
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "Sample Description 4",
                   Condition = true,
                   Amount = 1,
                   EquipmentTypeID = 5
               });

            modelBuilder.Entity<Material>().HasData(
               new eDentalist.WebAPI.Database.Material()
               {
                   MaterialID = 1,
                   Name = "Coltosol F",
                   Amount = 3,
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "Coltosol F is a temporary, eugenol-free filling material."
               },
               new eDentalist.WebAPI.Database.Material()
               {
                   MaterialID = 2,
                   Name = "Helioseal F Plus",
                   Amount = 4,
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "Helioseal F Plus is a lightcuring, white-pigmented, fluoride-releasing fissure sealant. Helioseal F Plus is flowable and it is easy to distribute on intricate surfaces – even in the upper jaw. The tight marginal seal provides protection against cariogenic germs."
               },
               new eDentalist.WebAPI.Database.Material()
               {
                   MaterialID = 3,
                   Name = "DeTrey Zinc Cement",
                   Amount = 1,
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "DeTrey Zinc is a fine grain zinc phosphate cement."
               },
               new eDentalist.WebAPI.Database.Material()
               {
                   MaterialID = 4,
                   Name = "Venus Diamond",
                   Amount = 13,
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "Venus Diamond is a nano-hybrid universal composite that combines low shrinkage and high strength in a unique way."
               },
               new eDentalist.WebAPI.Database.Material()
               {
                   MaterialID = 5,
                   Name = "Lucitone 199",
                   Amount = 1,
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "Lucitone 199 denture resin is an acrylic base material used for fabricating dentures."
               },
               new eDentalist.WebAPI.Database.Material()
               {
                   MaterialID = 6,
                   Name = "Ventura High Alloy",
                   Amount = 1000,
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "Dispersed phase Non Gamma 2 amalgam with a high silver content that guarantees an excellent marginal seal."
               },
               new eDentalist.WebAPI.Database.Material()
               {
                   MaterialID = 7,
                   Name = "GC Fuji IX GP EXTRA",
                   Amount = 123,
                   DateAdded = DateTime.Now.AddDays(-90),
                   LastUsed = DateTime.Now,
                   Description = "GC Fuji IX GP EXTRA is a conventional glass ionomer restorative that chemically bonds to both enamel and dentin."
               });

            modelBuilder.Entity<User>().HasData(
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 1,
                   FirstName = "Toni",
                   LastName = "Buconjić",
                   JMBG = "123456789101",
                   DateOfBirth = DateTime.Parse("1997-08-07 00:00:00.0000000"),
                   Address = "Sample Address 1",
                   PhoneNumber = "123-456-789",
                   Email = "sampleEmail1@hotmail.com",
                   UserRoleID = 1,
                   GenderID = 1,
                   Username = "toniAdministrator",
                   PasswordHash = "rGSytp3E0Hl2uvmU+53Dp8fU4ien7zhi1sP4s//eHPY27FZlS2G2F1ZBkmR/+rW7Bils/77izkhqLkBltf7IOQ==",
                   PasswordSalt = "shA6VH2F5Qs+8lWDXPXcLA==",
                   CityID = 1,
                   Image = null
               },
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 2,
                   FirstName = "John",
                   LastName = "Smith",
                   JMBG = "2222222222222",
                   DateOfBirth = DateTime.Parse("1977-09-22 00:00:00.0000000"),
                   Address = "Sample Address 2",
                   PhoneNumber = "123-456-111",
                   Email = "sampleEmail2@hotmail.com",
                   UserRoleID = 1,
                   GenderID = 1,
                   Username = "smithAdministrator",
                   PasswordHash = "k4vYDitQ/4atIshu6rIcvIi3FUai/rJXqttYljS12mIqwknM57o0maHdAJ9owdCz5O8RRSF1qBf6EKLu4T9HuA==",
                   PasswordSalt = "htC9d7x2gjqkyvMfuoisQA==",
                   CityID = 2,
                   Image = null
               },
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 3,
                   FirstName = "Miss",
                   LastName = "Patient",
                   JMBG = "123123123123",
                   DateOfBirth = DateTime.Parse("1986-01-23 00:00:00.0000000"),
                   Address = "Sample Address 3",
                   PhoneNumber = "123-456-112",
                   Email = "sampleEmail3@hotmail.com",
                   UserRoleID = 3,
                   GenderID = 2,
                   Username = "patientUser1",
                   PasswordHash = "6S5M0uh9quIfedWFlkj40MtRccKDDPQ+fYGEsSsFIhZfkmxEQwuNglSgFYtPSKOOQQ8tE2B50YMQr/J7G0PXKg==",
                   PasswordSalt = "lvBceA28cek8WqfBpjhb4w==",
                   CityID = 1,
                   Image = null
               },
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 4,
                   FirstName = "Mister",
                   LastName = "Dentist",
                   JMBG = "1234567123111",
                   DateOfBirth = DateTime.Parse("1981-03-08 00:00:00.0000000"),
                   Address = "Sample Address 4",
                   PhoneNumber = "123-456-113",
                   Email = "sampleEmail4@hotmail.com",
                   UserRoleID = 2,
                   GenderID = 1,
                   Username = "dentistUser1",
                   PasswordHash = "HNoTAmgSr8pIWUBSyhLsSBagMiRs8RtJXhf7xiF8WsGPzkAqMm/U22GAq633m4AjKjsRNxQ998M4rS3hgzoEJA==",
                   PasswordSalt = "uQxEPQSUR1XN1qA/2ZddKQ==",
                   CityID = 1,
                   Image = null
               },
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 5,
                   FirstName = "Robert",
                   LastName = "Robertson",
                   JMBG = "1234567123114",
                   DateOfBirth = DateTime.Parse("1982-02-01 00:00:00.0000000"),
                   Address = "Sample Address 5",
                   PhoneNumber = "123-456-114",
                   Email = "sampleEmail5@hotmail.com",
                   UserRoleID = 2,
                   GenderID = 1,
                   Username = "dentistUser2",
                   PasswordHash = "NvvsX3czaEeQG+7SApP33xWJxdDTRGV4G+SggreZMrafxZQaGFM+Odd5pMPcp0B3kRvF05LtB/7/T4PetQ6sAg==",
                   PasswordSalt = "h+Zc2PyiFgkjJlMpLChjAg==",
                   CityID = 1,
                   Image = null
               },
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 6,
                   FirstName = "Rick",
                   LastName = "Astley",
                   JMBG = "4234525123454",
                   DateOfBirth = DateTime.Parse("1971-03-05 00:00:00.0000000"),
                   Address = "Sample Address 6",
                   PhoneNumber = "123-456-115",
                   Email = "sampleEmail6@hotmail.com",
                   UserRoleID = 2,
                   GenderID = 1,
                   Username = "dentistUser3",
                   PasswordHash = "w3VKqA5LC68SyZ3uQZys9jhFNOSDylurW0I1J+G7ywFNfv4a07aMl2WuYdmQiI94fWRJ9UcfDAbbtKHbLZd5Vw==",
                   PasswordSalt = "AHS3v4ZONtqfXUI/I9cAHg==",
                   CityID = 1,
                   Image = null
               },
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 7,
                   FirstName = "Michael",
                   LastName = "Jackson",
                   JMBG = "5656565656565",
                   DateOfBirth = DateTime.Parse("1961-11-01 00:00:00.0000000"),
                   Address = "Sample Address 7",
                   PhoneNumber = "123-456-116",
                   Email = "sampleEmail7@hotmail.com",
                   UserRoleID = 3,
                   GenderID = 3,
                   Username = "patientUser2",
                   PasswordHash = "5Mt9EFAxlUMklBDGXL85G+K/dJtFYYj9N44sFXJyo1bZaGBPl+tmRoM3mIsZe8YCQgl+B8p5Zz5QEA1m2ef3wQ==",
                   PasswordSalt = "m4nlzGtdTES0VdY5KuBiTA==",
                   CityID = 1,
                   Image = null
               },
               //main user accounts for testing below
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 8,
                   FirstName = "Luke",
                   LastName = "Skywalker",
                   JMBG = "1010101010101",
                   DateOfBirth = DateTime.Parse("1959-12-20 00:00:00.0000000"),
                   Address = "Sample Address 8",
                   PhoneNumber = "123-456-117",
                   Email = "sampleEmail8@hotmail.com",
                   UserRoleID = 2,
                   GenderID = 1,
                   Username = "dentist",
                   PasswordHash = "C/V1Jk5mFuGNNn3Mb7KGEvD/AfYvdydOPzuIKLa9SKHuffSp2wl6dF6mzQuPxF6X15BG8nD27zv5gZqEIlIRgA==",
                   PasswordSalt = "91pxTS0BD74rnRa1aaaQfw==",
                   CityID = 1,
                   Image = null
               },
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 9,
                   FirstName = "John",
                   LastName = "Doe",
                   JMBG = "1234123412341",
                   DateOfBirth = DateTime.Parse("1984-07-12 00:00:00.0000000"),
                   Address = "Sample Address 9",
                   PhoneNumber = "123-456-118",
                   Email = "sampleEmail9@hotmail.com",
                   UserRoleID = 1,
                   GenderID = 1,
                   Username = "admin",
                   PasswordHash = "g2UAVTHQd3nn8RZCPqo2sBkec6IXLCMi426vN9u3/GobI3dkuKmyTbmBrnv7+8y7quLl+3LEDrOSBa5Sv9wnQA==",
                   PasswordSalt = "SOVoL/QZ50aDUF2DmXzNSw==",
                   CityID = 2,
                   Image = null
               },
               new eDentalist.WebAPI.Database.User()
               {
                   UserID = 10,
                   FirstName = "Peter",
                   LastName = "Parker",
                   JMBG = "1234123412342",
                   DateOfBirth = DateTime.Parse("1994-07-23 00:00:00.0000000"),
                   Address = "Sample Address 10",
                   PhoneNumber = "123-456-119",
                   Email = "sampleEmail10@hotmail.com",
                   UserRoleID = 3,
                   GenderID = 1,
                   Username = "patient",
                   PasswordHash = "sjfNOhItWD5rSo/drRe2UAdZphjWH9PONk7g4CIFxtkxZyRL5o8/+3t20dNhYF6WTQivmFy1m7ntcuD4Yf5VfQ==",
                   PasswordSalt = "XWSd/kaTqdmQX8WdlHv4YQ==",
                   CityID = 3,
                   Image = null
               });

            modelBuilder.Entity<HygieneProcess>().HasData(
                new eDentalist.WebAPI.Database.HygieneProcess()
                {
                    HygieneProcessID = 1,
                    DateOfPerformance = DateTime.Now.AddDays(-1),
                    Description = "Sample Description 1",
                    UserID = 4,
                    HygieneProcessTypeID = 1,
                    Status = true
                },
                new eDentalist.WebAPI.Database.HygieneProcess()
                {
                    HygieneProcessID = 2,
                    DateOfPerformance = DateTime.Now.AddDays(-2),
                    Description = "Sample Description 2",
                    UserID = 5,
                    HygieneProcessTypeID = 2,
                    Status = true
                },
                new eDentalist.WebAPI.Database.HygieneProcess()
                {
                    HygieneProcessID = 3,
                    DateOfPerformance = DateTime.Now.AddDays(-3),
                    Description = "Sample Description 3",
                    UserID = 6,
                    HygieneProcessTypeID = 1,
                    Status = true
                },
                new eDentalist.WebAPI.Database.HygieneProcess()
                {
                    HygieneProcessID = 4,
                    DateOfPerformance = DateTime.Now.AddDays(-4),
                    Description = "Sample Description 4",
                    UserID = 8,
                    HygieneProcessTypeID = 1,
                    Status = true
                },
                new eDentalist.WebAPI.Database.HygieneProcess()
                {
                    HygieneProcessID = 5,
                    DateOfPerformance = DateTime.Now.AddDays(-5),
                    Description = "Sample Description 5",
                    UserID = 4,
                    HygieneProcessTypeID = 1,
                    Status = true
                },
                new eDentalist.WebAPI.Database.HygieneProcess()
                {
                    HygieneProcessID = 6,
                    DateOfPerformance = DateTime.Now.AddDays(-6),
                    Description = "Sample Description 6",
                    UserID = 5,
                    HygieneProcessTypeID = 2,
                    Status = true
                },
                new eDentalist.WebAPI.Database.HygieneProcess()
                {
                    HygieneProcessID = 7,
                    DateOfPerformance = DateTime.Now.AddDays(-7),
                    Description = "Sample Description 7",
                    UserID = 6,
                    HygieneProcessTypeID = 1,
                    Status = true
                },
                new eDentalist.WebAPI.Database.HygieneProcess()
                {
                    HygieneProcessID = 9,
                    DateOfPerformance = DateTime.Now.AddDays(-8),
                    Description = "Sample Description 8",
                    UserID = 8,
                    HygieneProcessTypeID = 1,
                    Status = true
                });

            modelBuilder.Entity<Requisition>().HasData(
               new eDentalist.WebAPI.Database.Requisition()
               {
                   RequisitionID = 3,
                   Amount = 4,
                   DateRequisitioned = DateTime.Now.AddDays(-1),
                   UserID = 3,
                   MaterialID = 1,
                   EquipmentID = null,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Requisition()
               {
                   RequisitionID = 4,
                   Amount = 1,
                   DateRequisitioned = DateTime.Now.AddDays(-2),
                   UserID = 3,
                   MaterialID = null,
                   EquipmentID = 1,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Requisition()
               {
                   RequisitionID = 6,
                   Amount = 1,
                   DateRequisitioned = DateTime.Now.AddDays(-20),
                   UserID = 4,
                   MaterialID = null,
                   EquipmentID = 1,
                   Status = false
               },
               new eDentalist.WebAPI.Database.Requisition()
               {
                   RequisitionID = 8,
                   Amount = 14,
                   DateRequisitioned = DateTime.Now.AddDays(-5),
                   UserID = 3,
                   MaterialID = 2,
                   EquipmentID = null,
                   Status = false
               },
               new eDentalist.WebAPI.Database.Requisition()
               {
                   RequisitionID = 9,
                   Amount = 10,
                   DateRequisitioned = DateTime.Now.AddDays(-25),
                   UserID = 4,
                   MaterialID = 2,
                   EquipmentID = null,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Requisition()
               {
                   RequisitionID = 10,
                   Amount = 3,
                   DateRequisitioned = DateTime.Now.AddDays(-50),
                   UserID = 4,
                   MaterialID = 2,
                   EquipmentID = null,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Requisition()
               {
                   RequisitionID = 11,
                   Amount = 1,
                   DateRequisitioned = DateTime.Now.AddDays(-30),
                   UserID = 3,
                   MaterialID = null,
                   EquipmentID = 1,
                   Status = true
               },
               new eDentalist.WebAPI.Database.Requisition()
               {
                   RequisitionID = 12,
                   Amount = 2,
                   DateRequisitioned = DateTime.Now.AddDays(-30),
                   UserID = 3,
                   MaterialID = 7,
                   EquipmentID = null,
                   Status = true
               });

            modelBuilder.Entity<UserWorkday>().HasData(
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 1, WorkdayID = 1, UserID = 4, ShiftID = 5 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 2, WorkdayID = 1, UserID = 5, ShiftID = 6 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 3, WorkdayID = 2, UserID = 6, ShiftID = 5 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 4, WorkdayID = 2, UserID = 8, ShiftID = 6 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 5, WorkdayID = 3, UserID = 4, ShiftID = 6 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 6, WorkdayID = 4, UserID = 5, ShiftID = 5 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 7, WorkdayID = 5, UserID = 6, ShiftID = 6 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 8, WorkdayID = 5, UserID = 8, ShiftID = 6 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 9, WorkdayID = 6, UserID = 4, ShiftID = 5 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 10, WorkdayID = 6, UserID = 5, ShiftID = 6 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 11, WorkdayID = 7, UserID = 6, ShiftID = 5 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 12, WorkdayID = 8, UserID = 8, ShiftID = 5 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 13, WorkdayID = 8, UserID = 4, ShiftID = 6 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 14, WorkdayID = 9, UserID = 5, ShiftID = 5 },
               new eDentalist.WebAPI.Database.UserWorkday() { UserWorkdayID = 15, WorkdayID = 9, UserID = 8, ShiftID = 6 });

            modelBuilder.Entity<Appointment>().HasData(
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 1,
                   From = TimeSpan.Parse("12:00:00"),
                   To = TimeSpan.Parse("12:30:00"),
                   DentistID = 4,
                   PatientID = 3,
                   ProcedureID = 4,
                   AppointmentStatusID = 2,
                   WorkdayID = 1
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 2,
                   From = TimeSpan.Parse("16:00:00"),
                   To = TimeSpan.Parse("16:30:00"),
                   DentistID = 5,
                   PatientID = 7,
                   ProcedureID = 7,
                   AppointmentStatusID = 2,
                   WorkdayID = 1
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 3,
                   From = TimeSpan.Parse("10:30:00"),
                   To = TimeSpan.Parse("11:00:00"),
                   DentistID = 6,
                   PatientID = 3,
                   ProcedureID = 6,
                   AppointmentStatusID = 2,
                   WorkdayID = 2
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 4,
                   From = TimeSpan.Parse("17:30:00"),
                   To = TimeSpan.Parse("18:00:00"),
                   DentistID = 8,
                   PatientID = 7,
                   ProcedureID = 4,
                   AppointmentStatusID = 2,
                   WorkdayID = 2
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 5,
                   From = TimeSpan.Parse("18:30:00"),
                   To = TimeSpan.Parse("19:00:00"),
                   DentistID = 8,
                   PatientID = 10,
                   ProcedureID = 5,
                   AppointmentStatusID = 2,
                   WorkdayID = 2
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 6,
                   From = TimeSpan.Parse("18:30:00"),
                   To = TimeSpan.Parse("19:00:00"),
                   DentistID = 4,
                   PatientID = 7,
                   ProcedureID = 5,
                   AppointmentStatusID = 2,
                   WorkdayID = 3
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 7,
                   From = TimeSpan.Parse("19:30:00"),
                   To = TimeSpan.Parse("20:00:00"),
                   DentistID = 4,
                   PatientID = 10,
                   ProcedureID = 8,
                   AppointmentStatusID = 2,
                   WorkdayID = 3
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 8,
                   From = TimeSpan.Parse("9:30:00"),
                   To = TimeSpan.Parse("10:00:00"),
                   DentistID = 5,
                   PatientID = 10,
                   ProcedureID = 7,
                   AppointmentStatusID = 2,
                   WorkdayID = 4
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 9,
                   From = TimeSpan.Parse("19:30:00"),
                   To = TimeSpan.Parse("20:00:00"),
                   DentistID = 6,
                   PatientID = 3,
                   ProcedureID = 4,
                   AppointmentStatusID = 4,
                   WorkdayID = 5
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 10,
                   From = TimeSpan.Parse("17:30:00"),
                   To = TimeSpan.Parse("18:00:00"),
                   DentistID = 8,
                   PatientID = 10,
                   ProcedureID = 5,
                   AppointmentStatusID = 4,
                   WorkdayID = 5
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 11,
                   From = TimeSpan.Parse("18:00:00"),
                   To = TimeSpan.Parse("18:30:00"),
                   DentistID = 8,
                   PatientID = 3,
                   ProcedureID = 6,
                   AppointmentStatusID = 4,
                   WorkdayID = 5
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 12,
                   From = TimeSpan.Parse("08:00:00"),
                   To = TimeSpan.Parse("08:30:00"),
                   DentistID = 4,
                   PatientID = 3,
                   ProcedureID = 6,
                   AppointmentStatusID = 4,
                   WorkdayID = 6
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 13,
                   From = TimeSpan.Parse("18:00:00"),
                   To = TimeSpan.Parse("18:30:00"),
                   DentistID = 5,
                   PatientID = 10,
                   ProcedureID = 3,
                   AppointmentStatusID = 4,
                   WorkdayID = 6
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 14,
                   From = TimeSpan.Parse("07:30:00"),
                   To = TimeSpan.Parse("08:00:00"),
                   DentistID = 6,
                   PatientID = 7,
                   ProcedureID = 4,
                   AppointmentStatusID = 4,
                   WorkdayID = 7
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 15,
                   From = TimeSpan.Parse("09:30:00"),
                   To = TimeSpan.Parse("10:00:00"),
                   DentistID = 8,
                   PatientID = 10,
                   ProcedureID = 5,
                   AppointmentStatusID = 1,
                   WorkdayID = 8
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 16,
                   From = TimeSpan.Parse("10:30:00"),
                   To = TimeSpan.Parse("11:00:00"),
                   DentistID = 8,
                   PatientID = 3,
                   ProcedureID = 5,
                   AppointmentStatusID = 1,
                   WorkdayID = 8
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 17,
                   From = TimeSpan.Parse("16:30:00"),
                   To = TimeSpan.Parse("17:00:00"),
                   DentistID = 4,
                   PatientID = 7,
                   ProcedureID = 8,
                   AppointmentStatusID = 1,
                   WorkdayID = 8
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 18,
                   From = TimeSpan.Parse("10:30:00"),
                   To = TimeSpan.Parse("11:00:00"),
                   DentistID = 5,
                   PatientID = 3,
                   ProcedureID = 5,
                   AppointmentStatusID = 1,
                   WorkdayID = 9
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 19,
                   From = TimeSpan.Parse("15:30:00"),
                   To = TimeSpan.Parse("16:00:00"),
                   DentistID = 8,
                   PatientID = 10,
                   ProcedureID = 6,
                   AppointmentStatusID = 1,
                   WorkdayID = 9
               },
               new eDentalist.WebAPI.Database.Appointment()
               {
                   AppointmentID = 20,
                   From = TimeSpan.Parse("16:30:00"),
                   To = TimeSpan.Parse("17:00:00"),
                   DentistID = 8,
                   PatientID = 7,
                   ProcedureID = 8,
                   AppointmentStatusID = 1,
                   WorkdayID = 9
               });

            modelBuilder.Entity<Anamnesis>().HasData(
               new eDentalist.WebAPI.Database.Anamnesis()
               {
                   AnamnesisID = 1,
                   AnamnesisContent = "Sample Anamnesis Content 1",
                   Therapy = "Sample Anamnesis Therapy 1",
                   AdditionalNotes = "Sample Anamnesis Additional Notes 1",
                   AppointmentID = 5
               },
               new eDentalist.WebAPI.Database.Anamnesis()
               {
                   AnamnesisID = 2,
                   AnamnesisContent = "Sample Anamnesis Content 2",
                   Therapy = "Sample Anamnesis Therapy 2",
                   AdditionalNotes = "Sample Anamnesis Additional Notes 2",
                   AppointmentID = 7
               },
               new eDentalist.WebAPI.Database.Anamnesis()
               {
                   AnamnesisID = 3,
                   AnamnesisContent = "Sample Anamnesis Content 3",
                   Therapy = "Sample Anamnesis Therapy 3",
                   AdditionalNotes = "Sample Anamnesis Additional Notes 3",
                   AppointmentID = 8
               },
               new eDentalist.WebAPI.Database.Anamnesis()
               {
                   AnamnesisID = 4,
                   AnamnesisContent = "Sample Anamnesis Content 4",
                   Therapy = "Sample Anamnesis Therapy 4",
                   AdditionalNotes = "Sample Anamnesis Additional Notes 4",
                   AppointmentID = 1
               },
               new eDentalist.WebAPI.Database.Anamnesis()
               {
                   AnamnesisID = 5,
                   AnamnesisContent = "Sample Anamnesis Content 5",
                   Therapy = "Sample Anamnesis Therapy 5",
                   AdditionalNotes = "Sample Anamnesis Additional Notes 5",
                   AppointmentID = 2
               },
               new eDentalist.WebAPI.Database.Anamnesis()
               {
                   AnamnesisID = 6,
                   AnamnesisContent = "Sample Anamnesis Content 6",
                   Therapy = "Sample Anamnesis Therapy 6",
                   AdditionalNotes = "Sample Anamnesis Additional Notes 6",
                   AppointmentID = 3
               },
               new eDentalist.WebAPI.Database.Anamnesis()
               {
                   AnamnesisID = 7,
                   AnamnesisContent = "Sample Anamnesis Content 7",
                   Therapy = "Sample Anamnesis Therapy 7",
                   AdditionalNotes = "Sample Anamnesis Additional Notes 7",
                   AppointmentID = 4
               },
               new eDentalist.WebAPI.Database.Anamnesis()
               {
                   AnamnesisID = 8,
                   AnamnesisContent = "Sample Anamnesis Content 8",
                   Therapy = "Sample Anamnesis Therapy 8",
                   AdditionalNotes = "Sample Anamnesis Additional Notes 8",
                   AppointmentID = 6
               });

            modelBuilder.Entity<Bill>().HasData(
               new eDentalist.WebAPI.Database.Bill()
               {
                   BillID = 1,
                   AppointmentID = 5,
                   Date = DateTime.Now,
                   IsPaid = true,
                   PaymentAmount = 45
               },
               new eDentalist.WebAPI.Database.Bill()
               {
                   BillID = 2,
                   AppointmentID = 7,
                   Date = DateTime.Now,
                   IsPaid = true,
                   PaymentAmount = 20
               },
               new eDentalist.WebAPI.Database.Bill()
               {
                   BillID = 3,
                   AppointmentID = 8,
                   Date = DateTime.Now,
                   IsPaid = false,
                   PaymentAmount = 100
               },
               new eDentalist.WebAPI.Database.Bill()
               {
                   BillID = 4,
                   AppointmentID = 1,
                   Date = DateTime.Now,
                   IsPaid = true,
                   PaymentAmount = 30
               }
               ,
               new eDentalist.WebAPI.Database.Bill()
               {
                   BillID = 5,
                   AppointmentID = 2,
                   Date = DateTime.Now,
                   IsPaid = true,
                   PaymentAmount = 100
               },
               new eDentalist.WebAPI.Database.Bill()
               {
                   BillID = 6,
                   AppointmentID = 3,
                   Date = DateTime.Now,
                   IsPaid = true,
                   PaymentAmount = 50
               },
               new eDentalist.WebAPI.Database.Bill()
               {
                   BillID = 7,
                   AppointmentID = 4,
                   Date = DateTime.Now,
                   IsPaid = true,
                   PaymentAmount = 30
               },
               new eDentalist.WebAPI.Database.Bill()
               {
                   BillID = 8,
                   AppointmentID = 6,
                   Date = DateTime.Now,
                   IsPaid = true,
                   PaymentAmount = 45
               });

            modelBuilder.Entity<Rating>().HasData(
               new eDentalist.WebAPI.Database.Rating()
               {
                   RatingID = 1,
                   ProcedureID = 5,
                   UserID = 10,
                   Date = DateTime.Now,
                   Grade = 5,
                   Comment = "Sample Rating Comment 1"
               },
               new eDentalist.WebAPI.Database.Rating()
               {
                   RatingID = 2,
                   ProcedureID = 7,
                   UserID = 10,
                   Date = DateTime.Now,
                   Grade = 3,
                   Comment = "Sample Rating Comment 2"
               },
               new eDentalist.WebAPI.Database.Rating()
               {
                   RatingID = 3,
                   ProcedureID = 8,
                   UserID = 10,
                   Date = DateTime.Now,
                   Grade = 4,
                   Comment = "Sample Rating Comment 3"
               },
               new eDentalist.WebAPI.Database.Rating()
               {
                   RatingID = 4,
                   ProcedureID = 4,
                   UserID = 3,
                   Date = DateTime.Now,
                   Grade = 3,
                   Comment = "Sample Rating Comment 4"
               },
               new eDentalist.WebAPI.Database.Rating()
               {
                   RatingID = 5,
                   ProcedureID = 7,
                   UserID = 7,
                   Date = DateTime.Now,
                   Grade = 2,
                   Comment = "Sample Rating Comment 5"
               },
               new eDentalist.WebAPI.Database.Rating()
               {
                   RatingID = 6,
                   ProcedureID = 6,
                   UserID = 3,
                   Date = DateTime.Now,
                   Grade = 5,
                   Comment = "Sample Rating Comment 6"
               },
               new eDentalist.WebAPI.Database.Rating()
               {
                   RatingID = 7,
                   ProcedureID = 4,
                   UserID = 7,
                   Date = DateTime.Now,
                   Grade = 4,
                   Comment = "Sample Rating Comment 7"
               },
               new eDentalist.WebAPI.Database.Rating()
               {
                   RatingID = 8,
                   ProcedureID = 5,
                   UserID = 7,
                   Date = DateTime.Now,
                   Grade = 3,
                   Comment = "Sample Rating Comment 8"
               });
        }
    }
}
