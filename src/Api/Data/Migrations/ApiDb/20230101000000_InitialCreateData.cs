using Core.Domain.Security;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json.Linq;
using System;

namespace Api.Data.Migrations.ApiDb
{
    // ReSharper disable once UnusedMember.Global
    [DbContext(typeof(ApiDbContext))]
    [Migration("2023010100000_InitialCreateData")]
    public class InitialCreateData : Migration
    {
        private void Seed(MigrationBuilder migrationBuilder, string t, string cols, string values)
        {
            migrationBuilder.Sql($"SET IDENTITY_INSERT {t} ON");
            migrationBuilder.Sql($"INSERT INTO {t} ({cols}) VALUES ({values});", false);
            migrationBuilder.Sql($"SET IDENTITY_INSERT {t} OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder) { }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cols = $"{nameof(SecurityGroup.Id)}, {nameof(SecurityGroup.Name)}, {nameof(SecurityGroup.DisplayName)}";
            Seed(migrationBuilder, SecurityGroup.TableName, cols, "1, 'AccountsReceivable', 'Accounts Receivable'");
            Seed(migrationBuilder, SecurityGroup.TableName, cols, "2, 'AccountsPayable', 'Accounts Payable'");
            Seed(migrationBuilder, SecurityGroup.TableName, cols, "3, 'Financial', 'Financial'");
            Seed(migrationBuilder, SecurityGroup.TableName, cols, "4, 'SystemAdministration', 'System Administration'");

            cols = $"{nameof(SecurityRole.Id)}, {nameof(SecurityRole.Name)}, {nameof(SecurityRole.DisplayName)}, {nameof(SecurityRole.SysAdmin)}, {nameof(SecurityRole.System)}";
            Seed(migrationBuilder, SecurityRole.TableName, cols, "1, 'SystemAdministrators', 'System Administrators', 1, 1");
            Seed(migrationBuilder, SecurityRole.TableName, cols, "2, 'GeneralUsers', 'General Users', 0, 1");

            cols = $"{nameof(SecurityPermission.Id)}, {nameof(SecurityPermission.Name)}, {nameof(SecurityPermission.DisplayName)}, {nameof(SecurityPermission.SecurityGroupId)}";
            Seed(migrationBuilder, nameof(SecurityPermission), cols, "1, 'ManageUsers', 'Manage Users', 1");

            cols = $"{nameof(User.Id)}, {nameof(User.Lastname)}, {nameof(User.Firstname)}, {nameof(User.UserName)}, {nameof(User.EmailAddress)}";
            Seed(migrationBuilder, $"[{User.TableName}]", cols, "1, 'System', 'Admin', 'admin@accountgo.ph', 'admin@accountgo.ph'");

            cols = $"Id, AccessFailedCount, ConcurrencyStamp, Email, EmailConfirmed, LockoutEnabled, NormalizedEmail, NormalizedUserName, PasswordHash, PhoneNumberConfirmed, SecurityStamp, TwoFactorEnabled, UserName";
            var values = $"'{Guid.NewGuid()}', 0, '{Guid.NewGuid()}', 'admin@accountgo.ph', 0, 1, 'ADMIN@ACCOUNTGO.PH', 'ADMIN@ACCOUNTGO.PH', 'AQAAAAEAACcQAAAAEOxDmtWUR4F6ZycBAXzB0Wz5c0yduXEQVIgZwGPEOKRdfKq1dmqleAPMjvInBp+xow==', 0, '{Guid.NewGuid()}', 0, 'admin@accountgo.ph'";
            var t = $"[{ApplicationIdentityDbContext.DefaultSchema}].AspNetUsers";
            //Seed(migrationBuilder, t, cols, values); // Table 'AspNetUsers' does not have the identity property. Cannot perform SET operation.
            migrationBuilder.Sql($"INSERT INTO {t} ({cols}) VALUES ({values});", false);

            /*
SET IDENTITY_INSERT [accountgodb].[dbo].[User] ON
INSERT INTO [accountgodb].[dbo].[User] ([Id],[Lastname],[Firstname],[UserName],[EmailAddress]) values (1, 'System', 'Admin', 'admin@accountgo.ph', 'admin@accountgo.ph');
SET IDENTITY_INSERT [accountgodb].[dbo].[User] OFF
             */
        }
    }
}
