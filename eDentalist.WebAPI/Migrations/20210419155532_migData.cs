using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalist.WebAPI.Migrations
{
    public partial class migData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppointmentStatus",
                columns: new[] { "AppointmentStatusID", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Done" },
                    { 3, "Cancelled" },
                    { 4, "Approved" },
                    { 5, "Declined" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "Name" },
                values: new object[,]
                {
                    { 13, "South Korea" },
                    { 12, "China" },
                    { 10, "Spain" },
                    { 9, "Denmark" },
                    { 8, "Norway" },
                    { 7, "Sweden" },
                    { 11, "Japan" },
                    { 5, "France" },
                    { 4, "United States of America" },
                    { 3, "Serbia" },
                    { 2, "Croatia" },
                    { 1, "Bosnia and Herzegovina" },
                    { 6, "Germany" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentType",
                columns: new[] { "EquipmentTypeID", "Name" },
                values: new object[,]
                {
                    { 5, "Dental Laser" },
                    { 3, "Miscellaneous" },
                    { 4, "X-Ray Machine" },
                    { 1, "Dental Chair" },
                    { 2, "Dental Engine" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderID", "Name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Other" },
                    { 4, "Unassigned" }
                });

            migrationBuilder.InsertData(
                table: "HygieneProcessType",
                columns: new[] { "HygieneProcessTypeID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Sterilization refers to any process that removes, kills, or deactivates all forms of life (in particular referring to microorganisms such as fungi, bacteria, spores, unicellular eukaryotic organisms such as Plasmodium, etc.) and other biological agents like prions present in a specific surface, object or fluid, for example food or biological culture media.", "Sterilization" },
                    { 2, "Disinfection describes a process that eliminates many or all pathogenic microorganisms, except bacterial spores, on inanimate objects.", "Disinfection" }
                });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "MaterialID", "Amount", "DateAdded", "Description", "LastUsed", "Name" },
                values: new object[,]
                {
                    { 6, 1000, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2825), "Dispersed phase Non Gamma 2 amalgam with a high silver content that guarantees an excellent marginal seal.", new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2828), "Ventura High Alloy" },
                    { 7, 123, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2830), "GC Fuji IX GP EXTRA is a conventional glass ionomer restorative that chemically bonds to both enamel and dentin.", new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2833), "GC Fuji IX GP EXTRA" },
                    { 5, 1, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2820), "Lucitone 199 denture resin is an acrylic base material used for fabricating dentures.", new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2822), "Lucitone 199" },
                    { 1, 3, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2155), "Coltosol F is a temporary, eugenol-free filling material.", new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2363), "Coltosol F" },
                    { 3, 1, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2810), "DeTrey Zinc is a fine grain zinc phosphate cement.", new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2812), "DeTrey Zinc Cement" },
                    { 2, 4, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2763), "Helioseal F Plus is a lightcuring, white-pigmented, fluoride-releasing fissure sealant. Helioseal F Plus is flowable and it is easy to distribute on intricate surfaces – even in the upper jaw. The tight marginal seal provides protection against cariogenic germs.", new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2797), "Helioseal F Plus" },
                    { 4, 13, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2815), "Venus Diamond is a nano-hybrid universal composite that combines low shrinkage and high strength in a unique way.", new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(2818), "Venus Diamond" }
                });

            migrationBuilder.InsertData(
                table: "Procedure",
                columns: new[] { "ProcedureID", "Description", "Duration", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 2, "Sample Text 1", new TimeSpan(0, 0, 45, 0, 0), "Direct Dental Bonding", 50m, false },
                    { 3, "Sample Text 2", new TimeSpan(0, 0, 30, 0, 0), "Composite Dental Bonding", 50m, true },
                    { 4, "Sample Text 3", new TimeSpan(0, 0, 30, 0, 0), "Composite Veneer Bonding", 30m, true },
                    { 5, "The Traditional type of bridge is composed of one dental crown adhered to both the surrounding teeth with a fake tooth or teeth in the between.  With this, the dental crowns provide anchor points, while the fake tooth “bridges” the gap.", new TimeSpan(0, 0, 30, 0, 0), "Traditional Dental Bridge", 45m, true },
                    { 6, "Cantilever dental bridges deviate in structure from traditional dental bridges and only use a single anchor tooth.", new TimeSpan(0, 0, 30, 0, 0), "Cantilever Dental Bridge", 50m, true },
                    { 7, "A Maryland bonded bridge uses the same structure as a traditional dental bridge, however instead of using dental crowns as anchors, a metal or porcelain framework is used.", new TimeSpan(0, 0, 30, 0, 0), "Maryland Bonded Bridge", 100m, true }
                });

            migrationBuilder.InsertData(
                table: "Procedure",
                columns: new[] { "ProcedureID", "Description", "Duration", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 8, "Implant-supported dental bridges use the same structure as traditional bridges, however they are anchored in place with dental implants.", new TimeSpan(0, 0, 30, 0, 0), "Implant-Supported Bridge", 20m, true },
                    { 9, "Dental sealants, usually applied to the chewing surface of teeth, act as a barrier against decay-causing bacteria.", new TimeSpan(0, 0, 30, 0, 0), "Dental Sealant", 50m, true },
                    { 10, "Tooth whitening or tooth bleaching is the process of lightening the color of human teeth.", new TimeSpan(0, 0, 40, 0, 0), "Teeth Whitening", 45m, true }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "ShiftID", "From", "ShiftNumber", "To" },
                values: new object[,]
                {
                    { 6, new TimeSpan(0, 15, 0, 0, 0), 2, new TimeSpan(0, 23, 0, 0, 0) },
                    { 5, new TimeSpan(0, 7, 0, 0, 0), 1, new TimeSpan(0, 15, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Administrative role that has access to all functionalities that the application offers.", "Administrator" },
                    { 2, "Sample text.", "Dentist" },
                    { 3, "Sample text.", "Patient" }
                });

            migrationBuilder.InsertData(
                table: "Workday",
                columns: new[] { "WorkdayID", "Date" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 16, 17, 55, 31, 774, DateTimeKind.Local).AddTicks(4090) },
                    { 2, new DateTime(2021, 4, 17, 17, 55, 31, 776, DateTimeKind.Local).AddTicks(7155) },
                    { 3, new DateTime(2021, 4, 18, 17, 55, 31, 776, DateTimeKind.Local).AddTicks(7186) },
                    { 4, new DateTime(2021, 4, 19, 17, 55, 31, 776, DateTimeKind.Local).AddTicks(7191) },
                    { 5, new DateTime(2021, 4, 20, 17, 55, 31, 776, DateTimeKind.Local).AddTicks(7194) },
                    { 6, new DateTime(2021, 4, 21, 17, 55, 31, 776, DateTimeKind.Local).AddTicks(7196) },
                    { 7, new DateTime(2021, 4, 22, 17, 55, 31, 776, DateTimeKind.Local).AddTicks(7198) },
                    { 8, new DateTime(2021, 4, 29, 17, 55, 31, 776, DateTimeKind.Local).AddTicks(7201) },
                    { 9, new DateTime(2021, 5, 9, 17, 55, 31, 776, DateTimeKind.Local).AddTicks(7204) }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CountryID", "Name", "ZIPCode" },
                values: new object[,]
                {
                    { 1, 1, "Mostar", "88000" },
                    { 2, 1, "Sarajevo", "71000" },
                    { 3, 1, "Banja Luka", "78000" },
                    { 4, 1, "Unassigned", "00000" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "EquipmentID", "Amount", "Condition", "DateAdded", "Description", "EquipmentTypeID", "LastUsed", "Name" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(92), "The Elevance Dental Chair comes standard with programmable chair controls and a hydraulic drive system for smooth, quiet, precise operation.", 1, new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(315), "Midmark Elevance" },
                    { 2, 1, true, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(1196), "Sample Description 1", 1, new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(1212), "Belmont Quolis Q-5000" },
                    { 4, 1, false, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(1243), "Sample Description 2", 2, new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(1246), "FIMET F1" },
                    { 5, 4, true, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(1249), "Sample Description 3", 3, new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(1251), "EdgeMaker2000 Surgical Sharpening System" },
                    { 6, 1, true, new DateTime(2021, 1, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(1254), "Sample Description 4", 5, new DateTime(2021, 4, 19, 17, 55, 31, 777, DateTimeKind.Local).AddTicks(1256), "Mercury 3 Dental Laser System" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Address", "CityID", "DateOfBirth", "Email", "FirstName", "GenderID", "Image", "JMBG", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UserRoleID", "Username" },
                values: new object[,]
                {
                    { 1, "Sample Address 1", 1, new DateTime(1997, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail1@hotmail.com", "Toni", 1, null, "123456789101", "Buconjić", "rGSytp3E0Hl2uvmU+53Dp8fU4ien7zhi1sP4s//eHPY27FZlS2G2F1ZBkmR/+rW7Bils/77izkhqLkBltf7IOQ==", "shA6VH2F5Qs+8lWDXPXcLA==", "123-456-789", 1, "toniAdministrator" },
                    { 3, "Sample Address 3", 1, new DateTime(1986, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail3@hotmail.com", "Miss", 2, null, "123123123123", "Patient", "6S5M0uh9quIfedWFlkj40MtRccKDDPQ+fYGEsSsFIhZfkmxEQwuNglSgFYtPSKOOQQ8tE2B50YMQr/J7G0PXKg==", "lvBceA28cek8WqfBpjhb4w==", "123-456-112", 3, "patientUser1" },
                    { 4, "Sample Address 4", 1, new DateTime(1981, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail4@hotmail.com", "Mister", 1, null, "1234567123111", "Dentist", "HNoTAmgSr8pIWUBSyhLsSBagMiRs8RtJXhf7xiF8WsGPzkAqMm/U22GAq633m4AjKjsRNxQ998M4rS3hgzoEJA==", "uQxEPQSUR1XN1qA/2ZddKQ==", "123-456-113", 2, "dentistUser1" },
                    { 5, "Sample Address 5", 1, new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail5@hotmail.com", "Robert", 1, null, "1234567123114", "Robertson", "NvvsX3czaEeQG+7SApP33xWJxdDTRGV4G+SggreZMrafxZQaGFM+Odd5pMPcp0B3kRvF05LtB/7/T4PetQ6sAg==", "h+Zc2PyiFgkjJlMpLChjAg==", "123-456-114", 2, "dentistUser2" },
                    { 6, "Sample Address 6", 1, new DateTime(1971, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail6@hotmail.com", "Rick", 1, null, "4234525123454", "Astley", "w3VKqA5LC68SyZ3uQZys9jhFNOSDylurW0I1J+G7ywFNfv4a07aMl2WuYdmQiI94fWRJ9UcfDAbbtKHbLZd5Vw==", "AHS3v4ZONtqfXUI/I9cAHg==", "123-456-115", 2, "dentistUser3" },
                    { 7, "Sample Address 7", 1, new DateTime(1961, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail7@hotmail.com", "Michael", 3, null, "5656565656565", "Jackson", "5Mt9EFAxlUMklBDGXL85G+K/dJtFYYj9N44sFXJyo1bZaGBPl+tmRoM3mIsZe8YCQgl+B8p5Zz5QEA1m2ef3wQ==", "m4nlzGtdTES0VdY5KuBiTA==", "123-456-116", 3, "patientUser2" },
                    { 8, "Sample Address 8", 1, new DateTime(1959, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail8@hotmail.com", "Luke", 1, null, "1010101010101", "Skywalker", "C/V1Jk5mFuGNNn3Mb7KGEvD/AfYvdydOPzuIKLa9SKHuffSp2wl6dF6mzQuPxF6X15BG8nD27zv5gZqEIlIRgA==", "91pxTS0BD74rnRa1aaaQfw==", "123-456-117", 2, "dentist" },
                    { 2, "Sample Address 2", 2, new DateTime(1977, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail2@hotmail.com", "John", 1, null, "2222222222222", "Smith", "k4vYDitQ/4atIshu6rIcvIi3FUai/rJXqttYljS12mIqwknM57o0maHdAJ9owdCz5O8RRSF1qBf6EKLu4T9HuA==", "htC9d7x2gjqkyvMfuoisQA==", "123-456-111", 1, "smithAdministrator" },
                    { 9, "Sample Address 9", 2, new DateTime(1984, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail9@hotmail.com", "John", 1, null, "1234123412341", "Doe", "g2UAVTHQd3nn8RZCPqo2sBkec6IXLCMi426vN9u3/GobI3dkuKmyTbmBrnv7+8y7quLl+3LEDrOSBa5Sv9wnQA==", "SOVoL/QZ50aDUF2DmXzNSw==", "123-456-118", 1, "admin" },
                    { 10, "Sample Address 10", 3, new DateTime(1994, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "sampleEmail10@hotmail.com", "Peter", 1, null, "1234123412342", "Parker", "sjfNOhItWD5rSo/drRe2UAdZphjWH9PONk7g4CIFxtkxZyRL5o8/+3t20dNhYF6WTQivmFy1m7ntcuD4Yf5VfQ==", "XWSd/kaTqdmQX8WdlHv4YQ==", "123-456-119", 3, "patient" }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppointmentID", "AppointmentStatusID", "DentistID", "From", "PatientID", "ProcedureID", "To", "WorkdayID" },
                values: new object[,]
                {
                    { 16, 1, 8, new TimeSpan(0, 10, 30, 0, 0), 3, 5, new TimeSpan(0, 11, 0, 0, 0), 8 },
                    { 14, 4, 6, new TimeSpan(0, 7, 30, 0, 0), 7, 4, new TimeSpan(0, 8, 0, 0, 0), 7 },
                    { 17, 1, 4, new TimeSpan(0, 16, 30, 0, 0), 7, 8, new TimeSpan(0, 17, 0, 0, 0), 8 },
                    { 9, 4, 6, new TimeSpan(0, 19, 30, 0, 0), 3, 4, new TimeSpan(0, 20, 0, 0, 0), 5 },
                    { 3, 2, 6, new TimeSpan(0, 10, 30, 0, 0), 3, 6, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 4, 2, 8, new TimeSpan(0, 17, 30, 0, 0), 7, 4, new TimeSpan(0, 18, 0, 0, 0), 2 },
                    { 18, 1, 5, new TimeSpan(0, 10, 30, 0, 0), 3, 5, new TimeSpan(0, 11, 0, 0, 0), 9 },
                    { 11, 4, 8, new TimeSpan(0, 18, 0, 0, 0), 3, 6, new TimeSpan(0, 18, 30, 0, 0), 5 },
                    { 6, 2, 4, new TimeSpan(0, 18, 30, 0, 0), 7, 5, new TimeSpan(0, 19, 0, 0, 0), 3 },
                    { 20, 1, 8, new TimeSpan(0, 16, 30, 0, 0), 7, 8, new TimeSpan(0, 17, 0, 0, 0), 9 },
                    { 5, 2, 8, new TimeSpan(0, 18, 30, 0, 0), 10, 5, new TimeSpan(0, 19, 0, 0, 0), 2 },
                    { 2, 2, 5, new TimeSpan(0, 16, 0, 0, 0), 7, 7, new TimeSpan(0, 16, 30, 0, 0), 1 },
                    { 15, 1, 8, new TimeSpan(0, 9, 30, 0, 0), 10, 5, new TimeSpan(0, 10, 0, 0, 0), 8 },
                    { 13, 4, 5, new TimeSpan(0, 18, 0, 0, 0), 10, 3, new TimeSpan(0, 18, 30, 0, 0), 6 },
                    { 19, 1, 8, new TimeSpan(0, 15, 30, 0, 0), 10, 6, new TimeSpan(0, 16, 0, 0, 0), 9 },
                    { 12, 4, 4, new TimeSpan(0, 8, 0, 0, 0), 3, 6, new TimeSpan(0, 8, 30, 0, 0), 6 },
                    { 1, 2, 4, new TimeSpan(0, 12, 0, 0, 0), 3, 4, new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { 8, 2, 5, new TimeSpan(0, 9, 30, 0, 0), 10, 7, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 7, 2, 4, new TimeSpan(0, 19, 30, 0, 0), 10, 8, new TimeSpan(0, 20, 0, 0, 0), 3 },
                    { 10, 4, 8, new TimeSpan(0, 17, 30, 0, 0), 10, 5, new TimeSpan(0, 18, 0, 0, 0), 5 }
                });

            migrationBuilder.InsertData(
                table: "HygieneProcess",
                columns: new[] { "HygieneProcessID", "DateOfPerformance", "Description", "HygieneProcessTypeID", "Status", "UserID" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 4, 14, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(2949), "Sample Description 5", 1, true, 4 },
                    { 6, new DateTime(2021, 4, 13, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(2951), "Sample Description 6", 2, true, 5 },
                    { 2, new DateTime(2021, 4, 17, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(2906), "Sample Description 2", 2, true, 5 },
                    { 1, new DateTime(2021, 4, 18, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(2012), "Sample Description 1", 1, true, 4 },
                    { 4, new DateTime(2021, 4, 15, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(2946), "Sample Description 4", 1, true, 8 },
                    { 9, new DateTime(2021, 4, 11, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(2956), "Sample Description 8", 1, true, 8 },
                    { 3, new DateTime(2021, 4, 16, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(2942), "Sample Description 3", 1, true, 6 },
                    { 7, new DateTime(2021, 4, 12, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(2954), "Sample Description 7", 1, true, 6 }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingID", "Comment", "Date", "Grade", "ProcedureID", "UserID" },
                values: new object[,]
                {
                    { 1, "Sample Rating Comment 1", new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(1551), 5, 5, 10 },
                    { 8, "Sample Rating Comment 8", new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(2160), 3, 5, 7 },
                    { 7, "Sample Rating Comment 7", new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(2157), 4, 4, 7 },
                    { 5, "Sample Rating Comment 5", new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(2152), 2, 7, 7 },
                    { 4, "Sample Rating Comment 4", new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(2150), 3, 4, 3 },
                    { 3, "Sample Rating Comment 3", new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(2147), 4, 8, 10 },
                    { 2, "Sample Rating Comment 2", new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(2121), 3, 7, 10 },
                    { 6, "Sample Rating Comment 6", new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(2155), 5, 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Requisition",
                columns: new[] { "RequisitionID", "Amount", "DateRequisitioned", "EquipmentID", "MaterialID", "Status", "UserID" },
                values: new object[,]
                {
                    { 3, 4, new DateTime(2021, 4, 18, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(3715), null, 1, true, 3 },
                    { 4, 1, new DateTime(2021, 4, 17, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(4673), 1, null, true, 3 },
                    { 8, 14, new DateTime(2021, 4, 14, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(4712), null, 2, false, 3 },
                    { 11, 1, new DateTime(2021, 3, 20, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(4721), 1, null, true, 3 },
                    { 12, 2, new DateTime(2021, 3, 20, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(4724), null, 7, true, 3 },
                    { 6, 1, new DateTime(2021, 3, 30, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(4709), 1, null, false, 4 }
                });

            migrationBuilder.InsertData(
                table: "Requisition",
                columns: new[] { "RequisitionID", "Amount", "DateRequisitioned", "EquipmentID", "MaterialID", "Status", "UserID" },
                values: new object[,]
                {
                    { 9, 10, new DateTime(2021, 3, 25, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(4715), null, 2, true, 4 },
                    { 10, 3, new DateTime(2021, 2, 28, 17, 55, 31, 778, DateTimeKind.Local).AddTicks(4718), null, 2, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "UserWorkday",
                columns: new[] { "UserWorkdayID", "ShiftID", "UserID", "WorkdayID" },
                values: new object[,]
                {
                    { 7, 6, 6, 5 },
                    { 15, 6, 8, 9 },
                    { 12, 5, 8, 8 },
                    { 8, 6, 8, 5 },
                    { 4, 6, 8, 2 },
                    { 1, 5, 4, 1 },
                    { 5, 6, 4, 3 },
                    { 9, 5, 4, 6 },
                    { 13, 6, 4, 8 },
                    { 2, 6, 5, 1 },
                    { 6, 5, 5, 4 },
                    { 10, 6, 5, 6 },
                    { 14, 5, 5, 9 },
                    { 11, 5, 6, 7 },
                    { 3, 5, 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Anamnesis",
                columns: new[] { "AnamnesisID", "AdditionalNotes", "AnamnesisContent", "AppointmentID", "Therapy" },
                values: new object[,]
                {
                    { 4, "Sample Anamnesis Additional Notes 4", "Sample Anamnesis Content 4", 1, "Sample Anamnesis Therapy 4" },
                    { 6, "Sample Anamnesis Additional Notes 6", "Sample Anamnesis Content 6", 3, "Sample Anamnesis Therapy 6" },
                    { 5, "Sample Anamnesis Additional Notes 5", "Sample Anamnesis Content 5", 2, "Sample Anamnesis Therapy 5" },
                    { 8, "Sample Anamnesis Additional Notes 8", "Sample Anamnesis Content 8", 6, "Sample Anamnesis Therapy 8" },
                    { 7, "Sample Anamnesis Additional Notes 7", "Sample Anamnesis Content 7", 4, "Sample Anamnesis Therapy 7" },
                    { 1, "Sample Anamnesis Additional Notes 1", "Sample Anamnesis Content 1", 5, "Sample Anamnesis Therapy 1" },
                    { 2, "Sample Anamnesis Additional Notes 2", "Sample Anamnesis Content 2", 7, "Sample Anamnesis Therapy 2" },
                    { 3, "Sample Anamnesis Additional Notes 3", "Sample Anamnesis Content 3", 8, "Sample Anamnesis Therapy 3" }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "BillID", "AppointmentID", "Date", "IsPaid", "PaymentAmount" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(670), true, 30m },
                    { 6, 3, new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(676), true, 50m },
                    { 5, 2, new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(673), true, 100m },
                    { 8, 6, new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(681), true, 45m },
                    { 7, 4, new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(678), true, 30m },
                    { 1, 5, new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(2), true, 45m },
                    { 2, 7, new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(640), true, 20m },
                    { 3, 8, new DateTime(2021, 4, 19, 17, 55, 31, 779, DateTimeKind.Local).AddTicks(667), false, 100m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Anamnesis",
                keyColumn: "AnamnesisID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Anamnesis",
                keyColumn: "AnamnesisID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Anamnesis",
                keyColumn: "AnamnesisID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Anamnesis",
                keyColumn: "AnamnesisID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Anamnesis",
                keyColumn: "AnamnesisID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Anamnesis",
                keyColumn: "AnamnesisID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Anamnesis",
                keyColumn: "AnamnesisID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Anamnesis",
                keyColumn: "AnamnesisID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AppointmentStatus",
                keyColumn: "AppointmentStatusID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppointmentStatus",
                keyColumn: "AppointmentStatusID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "BillID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "BillID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "BillID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "BillID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "BillID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "BillID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "BillID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "BillID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "EquipmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "EquipmentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "EquipmentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "EquipmentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EquipmentType",
                keyColumn: "EquipmentTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HygieneProcess",
                keyColumn: "HygieneProcessID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HygieneProcess",
                keyColumn: "HygieneProcessID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HygieneProcess",
                keyColumn: "HygieneProcessID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HygieneProcess",
                keyColumn: "HygieneProcessID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HygieneProcess",
                keyColumn: "HygieneProcessID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HygieneProcess",
                keyColumn: "HygieneProcessID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HygieneProcess",
                keyColumn: "HygieneProcessID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HygieneProcess",
                keyColumn: "HygieneProcessID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Procedure",
                keyColumn: "ProcedureID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Procedure",
                keyColumn: "ProcedureID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Procedure",
                keyColumn: "ProcedureID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "RatingID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Requisition",
                keyColumn: "RequisitionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Requisition",
                keyColumn: "RequisitionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Requisition",
                keyColumn: "RequisitionID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Requisition",
                keyColumn: "RequisitionID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Requisition",
                keyColumn: "RequisitionID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Requisition",
                keyColumn: "RequisitionID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Requisition",
                keyColumn: "RequisitionID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Requisition",
                keyColumn: "RequisitionID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserWorkday",
                keyColumn: "UserWorkdayID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppointmentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AppointmentStatus",
                keyColumn: "AppointmentStatusID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppointmentStatus",
                keyColumn: "AppointmentStatusID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "EquipmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EquipmentType",
                keyColumn: "EquipmentTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipmentType",
                keyColumn: "EquipmentTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EquipmentType",
                keyColumn: "EquipmentTypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HygieneProcessType",
                keyColumn: "HygieneProcessTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HygieneProcessType",
                keyColumn: "HygieneProcessTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Procedure",
                keyColumn: "ProcedureID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "ShiftID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "ShiftID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workday",
                keyColumn: "WorkdayID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Workday",
                keyColumn: "WorkdayID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Workday",
                keyColumn: "WorkdayID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Workday",
                keyColumn: "WorkdayID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Workday",
                keyColumn: "WorkdayID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AppointmentStatus",
                keyColumn: "AppointmentStatusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipmentType",
                keyColumn: "EquipmentTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Procedure",
                keyColumn: "ProcedureID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Procedure",
                keyColumn: "ProcedureID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Procedure",
                keyColumn: "ProcedureID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Procedure",
                keyColumn: "ProcedureID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Procedure",
                keyColumn: "ProcedureID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Workday",
                keyColumn: "WorkdayID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workday",
                keyColumn: "WorkdayID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workday",
                keyColumn: "WorkdayID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Workday",
                keyColumn: "WorkdayID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1);
        }
    }
}
