﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Data.Migrations.ApiDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AccountClass",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalBalance = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditableEntity",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnableAudit = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditableEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditLog",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditEventDateUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuditEventType = table.Column<int>(type: "int", nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialYear",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FiscalYearCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FiscalYearName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialYear", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralLedgerHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralLedgerHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTaxGroup",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFullyExempt = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTaxGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thread = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StackTrace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Measurement",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Party",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartyType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Party", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTerm",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<int>(type: "int", nullable: false),
                    DueAfterDays = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityGroups",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityRole",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SysAdmin = table.Column<bool>(type: "bit", nullable: false),
                    System = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SequenceNumber",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SequenceNumberType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextNumber = table.Column<int>(type: "int", nullable: false),
                    UsePrefix = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SequenceNumber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxGroup",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxAppliedToShipping = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditableAttribute",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditableEntityId = table.Column<int>(type: "int", nullable: false),
                    AttributeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnableAudit = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditableAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditableAttribute_AuditableEntity_AuditableEntityId",
                        column: x => x.AuditableEntityId,
                        principalSchema: "dbo",
                        principalTable: "AuditableEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountClassId = table.Column<int>(type: "int", nullable: false),
                    ParentAccountId = table.Column<int>(type: "int", nullable: true),
                    DrOrCrSide = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    AccountCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsCash = table.Column<bool>(type: "bit", nullable: false),
                    IsContraAccount = table.Column<bool>(type: "bit", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "timestamp", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Account_ParentAccountId",
                        column: x => x.ParentAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Account_AccountClass_AccountClassId",
                        column: x => x.AccountClassId,
                        principalSchema: "dbo",
                        principalTable: "AccountClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Account_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "CompanySetting",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanySetting_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactType = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Party_PartyId",
                        column: x => x.PartyId,
                        principalSchema: "dbo",
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "JournalEntryHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralLedgerHeaderId = table.Column<int>(type: "int", nullable: true),
                    PartyId = table.Column<int>(type: "int", nullable: true),
                    VoucherType = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Memo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntryHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalEntryHeader_GeneralLedgerHeader_GeneralLedgerHeaderId",
                        column: x => x.GeneralLedgerHeaderId,
                        principalSchema: "dbo",
                        principalTable: "GeneralLedgerHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JournalEntryHeader_Party_PartyId",
                        column: x => x.PartyId,
                        principalSchema: "dbo",
                        principalTable: "Party",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SecurityPermission",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecurityPermission_SecurityGroups_SecurityGroupId",
                        column: x => x.SecurityGroupId,
                        principalSchema: "dbo",
                        principalTable: "SecurityGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "SecurityUserRole",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SecurityRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityUserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecurityUserRole_SecurityRole_SecurityRoleId",
                        column: x => x.SecurityRoleId,
                        principalSchema: "dbo",
                        principalTable: "SecurityRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SecurityUserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bank_Account_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GeneralLedgerLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralLedgerHeaderId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    DrCr = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralLedgerLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralLedgerLine_Account_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_GeneralLedgerLine_GeneralLedgerHeader_GeneralLedgerHeaderId",
                        column: x => x.GeneralLedgerHeaderId,
                        principalSchema: "dbo",
                        principalTable: "GeneralLedgerHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "GeneralLedgerSetting",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    PayableAccountId = table.Column<int>(type: "int", nullable: true),
                    PurchaseDiscountAccountId = table.Column<int>(type: "int", nullable: true),
                    GoodsReceiptNoteClearingAccountId = table.Column<int>(type: "int", nullable: true),
                    SalesDiscountAccountId = table.Column<int>(type: "int", nullable: true),
                    ShippingChargeAccountId = table.Column<int>(type: "int", nullable: true),
                    PermanentAccountId = table.Column<int>(type: "int", nullable: true),
                    IncomeSummaryAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralLedgerSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralLedgerSetting_Account_GoodsReceiptNoteClearingAccountId",
                        column: x => x.GoodsReceiptNoteClearingAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GeneralLedgerSetting_Account_IncomeSummaryAccountId",
                        column: x => x.IncomeSummaryAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GeneralLedgerSetting_Account_PayableAccountId",
                        column: x => x.PayableAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GeneralLedgerSetting_Account_PermanentAccountId",
                        column: x => x.PermanentAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GeneralLedgerSetting_Account_PurchaseDiscountAccountId",
                        column: x => x.PurchaseDiscountAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GeneralLedgerSetting_Account_SalesDiscountAccountId",
                        column: x => x.SalesDiscountAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GeneralLedgerSetting_Account_ShippingChargeAccountId",
                        column: x => x.ShippingChargeAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GeneralLedgerSetting_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "dbo",
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemCategory",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: true),
                    SalesAccountId = table.Column<int>(type: "int", nullable: true),
                    InventoryAccountId = table.Column<int>(type: "int", nullable: true),
                    CostOfGoodsSoldAccountId = table.Column<int>(type: "int", nullable: true),
                    AdjustmentAccountId = table.Column<int>(type: "int", nullable: true),
                    AssemblyAccountId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCategory_Account_AdjustmentAccountId",
                        column: x => x.AdjustmentAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemCategory_Account_AssemblyAccountId",
                        column: x => x.AssemblyAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemCategory_Account_CostOfGoodsSoldAccountId",
                        column: x => x.CostOfGoodsSoldAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemCategory_Account_InventoryAccountId",
                        column: x => x.InventoryAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemCategory_Account_SalesAccountId",
                        column: x => x.SalesAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemCategory_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MainContraAccount",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAccountId = table.Column<int>(type: "int", nullable: false),
                    RelatedContraAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainContraAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainContraAccount_Account_MainAccountId",
                        column: x => x.MainAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id"
                        //onDelete: ReferentialAction.Restrict /*cascade?*/
                        );
                    table.ForeignKey(
                        name: "FK_MainContraAccount_Account_RelatedContraAccountId",
                        column: x => x.RelatedContraAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id"
                        //onDelete: ReferentialAction.Restrict /*cascade?*/
                        );
                });

            migrationBuilder.CreateTable(
                name: "Tax",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesAccountId = table.Column<int>(type: "int", nullable: true),
                    PurchasingAccountId = table.Column<int>(type: "int", nullable: true),
                    TaxName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TaxCode = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tax_Account_PurchasingAccountId",
                        column: x => x.PurchasingAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tax_Account_SalesAccountId",
                        column: x => x.SalesAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyId = table.Column<int>(type: "int", nullable: true),
                    PrimaryContactId = table.Column<int>(type: "int", nullable: true),
                    TaxGroupId = table.Column<int>(type: "int", nullable: true),
                    AccountsReceivableAccountId = table.Column<int>(type: "int", nullable: true),
                    SalesAccountId = table.Column<int>(type: "int", nullable: true),
                    SalesDiscountAccountId = table.Column<int>(type: "int", nullable: true),
                    PromptPaymentDiscountAccountId = table.Column<int>(type: "int", nullable: true),
                    PaymentTermId = table.Column<int>(type: "int", nullable: true),
                    CustomerAdvancesAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Account_AccountsReceivableAccountId",
                        column: x => x.AccountsReceivableAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_Account_CustomerAdvancesAccountId",
                        column: x => x.CustomerAdvancesAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_Account_PromptPaymentDiscountAccountId",
                        column: x => x.PromptPaymentDiscountAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_Account_SalesAccountId",
                        column: x => x.SalesAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_Account_SalesDiscountAccountId",
                        column: x => x.SalesDiscountAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_Contact_PrimaryContactId",
                        column: x => x.PrimaryContactId,
                        principalSchema: "dbo",
                        principalTable: "Contact",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_Party_PartyId",
                        column: x => x.PartyId,
                        principalSchema: "dbo",
                        principalTable: "Party",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_PaymentTerm_PaymentTermId",
                        column: x => x.PaymentTermId,
                        principalSchema: "dbo",
                        principalTable: "PaymentTerm",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_TaxGroup_TaxGroupId",
                        column: x => x.TaxGroupId,
                        principalSchema: "dbo",
                        principalTable: "TaxGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyId = table.Column<int>(type: "int", nullable: true),
                    AccountsPayableAccountId = table.Column<int>(type: "int", nullable: true),
                    PurchaseAccountId = table.Column<int>(type: "int", nullable: true),
                    PurchaseDiscountAccountId = table.Column<int>(type: "int", nullable: true),
                    PrimaryContactId = table.Column<int>(type: "int", nullable: true),
                    PaymentTermId = table.Column<int>(type: "int", nullable: true),
                    TaxGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendor_Account_AccountsPayableAccountId",
                        column: x => x.AccountsPayableAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vendor_Account_PurchaseAccountId",
                        column: x => x.PurchaseAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vendor_Account_PurchaseDiscountAccountId",
                        column: x => x.PurchaseDiscountAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vendor_Contact_PrimaryContactId",
                        column: x => x.PrimaryContactId,
                        principalSchema: "dbo",
                        principalTable: "Contact",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vendor_Party_PartyId",
                        column: x => x.PartyId,
                        principalSchema: "dbo",
                        principalTable: "Party",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vendor_PaymentTerm_PaymentTermId",
                        column: x => x.PaymentTermId,
                        principalSchema: "dbo",
                        principalTable: "PaymentTerm",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vendor_TaxGroup_TaxGroupId",
                        column: x => x.TaxGroupId,
                        principalSchema: "dbo",
                        principalTable: "TaxGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JournalEntryLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JournalEntryHeaderId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    DrCr = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Memo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntryLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalEntryLine_Account_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/
                        );
                    table.ForeignKey(
                        name: "FK_JournalEntryLine_JournalEntryHeader_JournalEntryHeaderId",
                        column: x => x.JournalEntryHeaderId,
                        principalSchema: "dbo",
                        principalTable: "JournalEntryHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "SecurityRolePermission",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityRoleId = table.Column<int>(type: "int", nullable: false),
                    SecurityPermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityRolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecurityRolePermission_SecurityPermission_SecurityPermissionId",
                        column: x => x.SecurityPermissionId,
                        principalSchema: "dbo",
                        principalTable: "SecurityPermission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SecurityRolePermission_SecurityRole_SecurityRoleId",
                        column: x => x.SecurityRoleId,
                        principalSchema: "dbo",
                        principalTable: "SecurityRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "ItemTaxGroupTax",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxId = table.Column<int>(type: "int", nullable: false),
                    ItemTaxGroupId = table.Column<int>(type: "int", nullable: false),
                    IsExempt = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTaxGroupTax", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemTaxGroupTax_ItemTaxGroup_ItemTaxGroupId",
                        column: x => x.ItemTaxGroupId,
                        principalSchema: "dbo",
                        principalTable: "ItemTaxGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_ItemTaxGroupTax_Tax_TaxId",
                        column: x => x.TaxId,
                        principalSchema: "dbo",
                        principalTable: "Tax",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "TaxGroupTax",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxId = table.Column<int>(type: "int", nullable: false),
                    TaxGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxGroupTax", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxGroupTax_Tax_TaxId",
                        column: x => x.TaxId,
                        principalSchema: "dbo",
                        principalTable: "Tax",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_TaxGroupTax_TaxGroup_TaxGroupId",
                        column: x => x.TaxGroupId,
                        principalSchema: "dbo",
                        principalTable: "TaxGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "CustomerContact",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerContact_Contact_ContactId",
                        column: x => x.ContactId,
                        principalSchema: "dbo",
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_CustomerContact_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "SalesDeliveryHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTermId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    GeneralLedgerHeaderId = table.Column<int>(type: "int", nullable: true),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDeliveryHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesDeliveryHeader_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesDeliveryHeader_GeneralLedgerHeader_GeneralLedgerHeaderId",
                        column: x => x.GeneralLedgerHeaderId,
                        principalSchema: "dbo",
                        principalTable: "GeneralLedgerHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesDeliveryHeader_PaymentTerm_PaymentTermId",
                        column: x => x.PaymentTermId,
                        principalSchema: "dbo",
                        principalTable: "PaymentTerm",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    GeneralLedgerHeaderId = table.Column<int>(type: "int", nullable: true),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingHandlingCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentTermId = table.Column<int>(type: "int", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_GeneralLedgerHeader_GeneralLedgerHeaderId",
                        column: x => x.GeneralLedgerHeaderId,
                        principalSchema: "dbo",
                        principalTable: "GeneralLedgerHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    PaymentTermId = table.Column<int>(type: "int", nullable: true),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_PaymentTerm_PaymentTermId",
                        column: x => x.PaymentTermId,
                        principalSchema: "dbo",
                        principalTable: "PaymentTerm",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesQuoteHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PaymentTermId = table.Column<int>(type: "int", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesQuoteHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesQuoteHeader_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "SalesReceiptHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    GeneralLedgerHeaderId = table.Column<int>(type: "int", nullable: true),
                    AccountToDebitId = table.Column<int>(type: "int", nullable: true),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReceiptHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReceiptHeader_Account_AccountToDebitId",
                        column: x => x.AccountToDebitId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesReceiptHeader_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesReceiptHeader_GeneralLedgerHeader_GeneralLedgerHeaderId",
                        column: x => x.GeneralLedgerHeaderId,
                        principalSchema: "dbo",
                        principalTable: "GeneralLedgerHeader",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Item",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemCategoryId = table.Column<int>(type: "int", nullable: true),
                    SmallestMeasurementId = table.Column<int>(type: "int", nullable: true),
                    SellMeasurementId = table.Column<int>(type: "int", nullable: true),
                    PurchaseMeasurementId = table.Column<int>(type: "int", nullable: true),
                    PreferredVendorId = table.Column<int>(type: "int", nullable: true),
                    ItemTaxGroupId = table.Column<int>(type: "int", nullable: true),
                    SalesAccountId = table.Column<int>(type: "int", nullable: true),
                    InventoryAccountId = table.Column<int>(type: "int", nullable: true),
                    CostOfGoodsSoldAccountId = table.Column<int>(type: "int", nullable: true),
                    InventoryAdjustmentAccountId = table.Column<int>(type: "int", nullable: true),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Account_CostOfGoodsSoldAccountId",
                        column: x => x.CostOfGoodsSoldAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Account_InventoryAccountId",
                        column: x => x.InventoryAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Account_InventoryAdjustmentAccountId",
                        column: x => x.InventoryAdjustmentAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Account_SalesAccountId",
                        column: x => x.SalesAccountId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_ItemCategory_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalSchema: "dbo",
                        principalTable: "ItemCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_ItemTaxGroup_ItemTaxGroupId",
                        column: x => x.ItemTaxGroupId,
                        principalSchema: "dbo",
                        principalTable: "ItemTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Measurement_PurchaseMeasurementId",
                        column: x => x.PurchaseMeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Measurement_SellMeasurementId",
                        column: x => x.SellMeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Measurement_SmallestMeasurementId",
                        column: x => x.SmallestMeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Vendor_PreferredVendorId",
                        column: x => x.PreferredVendorId,
                        principalSchema: "dbo",
                        principalTable: "Vendor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    GeneralLedgerHeaderId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentTermId = table.Column<int>(type: "int", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceHeader_GeneralLedgerHeader_GeneralLedgerHeaderId",
                        column: x => x.GeneralLedgerHeaderId,
                        principalSchema: "dbo",
                        principalTable: "GeneralLedgerHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceHeader_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalSchema: "dbo",
                        principalTable: "Vendor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReceiptHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    GeneralLedgerHeaderId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReceiptHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseReceiptHeader_GeneralLedgerHeader_GeneralLedgerHeaderId",
                        column: x => x.GeneralLedgerHeaderId,
                        principalSchema: "dbo",
                        principalTable: "GeneralLedgerHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchaseReceiptHeader_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalSchema: "dbo",
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "VendorContact",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorContact_Contact_ContactId",
                        column: x => x.ContactId,
                        principalSchema: "dbo",
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_VendorContact_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalSchema: "dbo",
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAllocation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SalesInvoiceHeaderId = table.Column<int>(type: "int", nullable: false),
                    SalesReceiptHeaderId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAllocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAllocation_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_CustomerAllocation_SalesInvoiceHeader_SalesInvoiceHeaderId",
                        column: x => x.SalesInvoiceHeaderId,
                        principalSchema: "dbo",
                        principalTable: "SalesInvoiceHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_CustomerAllocation_SalesReceiptHeader_SalesReceiptHeaderId",
                        column: x => x.SalesReceiptHeaderId,
                        principalSchema: "dbo",
                        principalTable: "SalesReceiptHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "InventoryControlJournal",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    INQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OUTQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsReverse = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryControlJournal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryControlJournal_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dbo",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_InventoryControlJournal_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesOrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderLine_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dbo",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesOrderLine_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesOrderLine_SalesOrderHeader_SalesOrderHeaderId",
                        column: x => x.SalesOrderHeaderId,
                        principalSchema: "dbo",
                        principalTable: "SalesOrderHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "SalesQuoteLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesQuoteHeaderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesQuoteLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesQuoteLine_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dbo",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesQuoteLine_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesQuoteLine_SalesQuoteHeader_SalesQuoteHeaderId",
                        column: x => x.SalesQuoteHeaderId,
                        principalSchema: "dbo",
                        principalTable: "SalesQuoteHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderHeader",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentTermId = table.Column<int>(type: "int", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    PurchaseInvoiceHeaderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderHeader_PurchaseInvoiceHeader_PurchaseInvoiceHeaderId",
                        column: x => x.PurchaseInvoiceHeaderId,
                        principalSchema: "dbo",
                        principalTable: "PurchaseInvoiceHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchaseOrderHeader_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalSchema: "dbo",
                        principalTable: "Vendor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VendorPayment",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    PurchaseInvoiceHeaderId = table.Column<int>(type: "int", nullable: true),
                    GeneralLedgerHeaderId = table.Column<int>(type: "int", nullable: true),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorPayment_GeneralLedgerHeader_GeneralLedgerHeaderId",
                        column: x => x.GeneralLedgerHeaderId,
                        principalSchema: "dbo",
                        principalTable: "GeneralLedgerHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VendorPayment_PurchaseInvoiceHeader_PurchaseInvoiceHeaderId",
                        column: x => x.PurchaseInvoiceHeaderId,
                        principalSchema: "dbo",
                        principalTable: "PurchaseInvoiceHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VendorPayment_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalSchema: "dbo",
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesInvoiceHeaderId = table.Column<int>(type: "int", nullable: false),
                    SalesOrderLineId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    InventoryControlJournalId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceLine_InventoryControlJournal_InventoryControlJournalId",
                        column: x => x.InventoryControlJournalId,
                        principalSchema: "dbo",
                        principalTable: "InventoryControlJournal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesInvoiceLine_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dbo",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceLine_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceLine_SalesInvoiceHeader_SalesInvoiceHeaderId",
                        column: x => x.SalesInvoiceHeaderId,
                        principalSchema: "dbo",
                        principalTable: "SalesInvoiceHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceLine_SalesOrderLine_SalesOrderLineId",
                        column: x => x.SalesOrderLineId,
                        principalSchema: "dbo",
                        principalTable: "SalesOrderLine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderLine_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dbo",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderLine_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderLine_PurchaseOrderHeader_PurchaseOrderHeaderId",
                        column: x => x.PurchaseOrderHeaderId,
                        principalSchema: "dbo",
                        principalTable: "PurchaseOrderHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "SalesDeliveryLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesDeliveryHeaderId = table.Column<int>(type: "int", nullable: false),
                    SalesInvoiceLineId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    MeasurementId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDeliveryLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesDeliveryLine_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dbo",
                        principalTable: "Item",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesDeliveryLine_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesDeliveryLine_SalesDeliveryHeader_SalesDeliveryHeaderId",
                        column: x => x.SalesDeliveryHeaderId,
                        principalSchema: "dbo",
                        principalTable: "SalesDeliveryHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_SalesDeliveryLine_SalesInvoiceLine_SalesInvoiceLineId",
                        column: x => x.SalesInvoiceLineId,
                        principalSchema: "dbo",
                        principalTable: "SalesInvoiceLine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SalesReceiptLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesReceiptHeaderId = table.Column<int>(type: "int", nullable: false),
                    SalesInvoiceLineId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    AccountToCreditId = table.Column<int>(type: "int", nullable: true),
                    MeasurementId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReceiptLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReceiptLine_Account_AccountToCreditId",
                        column: x => x.AccountToCreditId,
                        principalSchema: "dbo",
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesReceiptLine_SalesInvoiceLine_SalesInvoiceLineId",
                        column: x => x.SalesInvoiceLineId,
                        principalSchema: "dbo",
                        principalTable: "SalesInvoiceLine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesReceiptLine_SalesReceiptHeader_SalesReceiptHeaderId",
                        column: x => x.SalesReceiptHeaderId,
                        principalSchema: "dbo",
                        principalTable: "SalesReceiptHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseInvoiceHeaderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    InventoryControlJournalId = table.Column<int>(type: "int", nullable: true),
                    PurchaseOrderLineId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceLine_InventoryControlJournal_InventoryControlJournalId",
                        column: x => x.InventoryControlJournalId,
                        principalSchema: "dbo",
                        principalTable: "InventoryControlJournal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceLine_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dbo",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceLine_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceLine_PurchaseInvoiceHeader_PurchaseInvoiceHeaderId",
                        column: x => x.PurchaseInvoiceHeaderId,
                        principalSchema: "dbo",
                        principalTable: "PurchaseInvoiceHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceLine_PurchaseOrderLine_PurchaseOrderLineId",
                        column: x => x.PurchaseOrderLineId,
                        principalSchema: "dbo",
                        principalTable: "PurchaseOrderLine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReceiptLine",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseReceiptHeaderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    InventoryControlJournalId = table.Column<int>(type: "int", nullable: true),
                    PurchaseInvoiceLineId = table.Column<int>(type: "int", nullable: true),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReceiptLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseReceiptLine_InventoryControlJournal_InventoryControlJournalId",
                        column: x => x.InventoryControlJournalId,
                        principalSchema: "dbo",
                        principalTable: "InventoryControlJournal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchaseReceiptLine_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dbo",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_PurchaseReceiptLine_Measurement_MeasurementId",
                        column: x => x.MeasurementId,
                        principalSchema: "dbo",
                        principalTable: "Measurement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                    table.ForeignKey(
                        name: "FK_PurchaseReceiptLine_PurchaseInvoiceLine_PurchaseInvoiceLineId",
                        column: x => x.PurchaseInvoiceLineId,
                        principalSchema: "dbo",
                        principalTable: "PurchaseInvoiceLine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchaseReceiptLine_PurchaseReceiptHeader_PurchaseReceiptHeaderId",
                        column: x => x.PurchaseReceiptHeaderId,
                        principalSchema: "dbo",
                        principalTable: "PurchaseReceiptHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict /*cascade?*/);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountClassId",
                schema: "dbo",
                table: "Account",
                column: "AccountClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_CompanyId",
                schema: "dbo",
                table: "Account",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_ParentAccountId",
                schema: "dbo",
                table: "Account",
                column: "ParentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditableAttribute_AuditableEntityId",
                schema: "dbo",
                table: "AuditableAttribute",
                column: "AuditableEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_AccountId",
                schema: "dbo",
                table: "Bank",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySetting_CompanyId",
                schema: "dbo",
                table: "CompanySetting",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PartyId",
                schema: "dbo",
                table: "Contact",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AccountsReceivableAccountId",
                schema: "dbo",
                table: "Customer",
                column: "AccountsReceivableAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerAdvancesAccountId",
                schema: "dbo",
                table: "Customer",
                column: "CustomerAdvancesAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PartyId",
                schema: "dbo",
                table: "Customer",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PaymentTermId",
                schema: "dbo",
                table: "Customer",
                column: "PaymentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PrimaryContactId",
                schema: "dbo",
                table: "Customer",
                column: "PrimaryContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PromptPaymentDiscountAccountId",
                schema: "dbo",
                table: "Customer",
                column: "PromptPaymentDiscountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_SalesAccountId",
                schema: "dbo",
                table: "Customer",
                column: "SalesAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_SalesDiscountAccountId",
                schema: "dbo",
                table: "Customer",
                column: "SalesDiscountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_TaxGroupId",
                schema: "dbo",
                table: "Customer",
                column: "TaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAllocation_CustomerId",
                schema: "dbo",
                table: "CustomerAllocation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAllocation_SalesInvoiceHeaderId",
                schema: "dbo",
                table: "CustomerAllocation",
                column: "SalesInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAllocation_SalesReceiptHeaderId",
                schema: "dbo",
                table: "CustomerAllocation",
                column: "SalesReceiptHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContact_ContactId",
                schema: "dbo",
                table: "CustomerContact",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContact_CustomerId",
                schema: "dbo",
                table: "CustomerContact",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerLine_AccountId",
                schema: "dbo",
                table: "GeneralLedgerLine",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerLine_GeneralLedgerHeaderId",
                schema: "dbo",
                table: "GeneralLedgerLine",
                column: "GeneralLedgerHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerSetting_CompanyId",
                schema: "dbo",
                table: "GeneralLedgerSetting",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerSetting_GoodsReceiptNoteClearingAccountId",
                schema: "dbo",
                table: "GeneralLedgerSetting",
                column: "GoodsReceiptNoteClearingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerSetting_IncomeSummaryAccountId",
                schema: "dbo",
                table: "GeneralLedgerSetting",
                column: "IncomeSummaryAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerSetting_PayableAccountId",
                schema: "dbo",
                table: "GeneralLedgerSetting",
                column: "PayableAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerSetting_PermanentAccountId",
                schema: "dbo",
                table: "GeneralLedgerSetting",
                column: "PermanentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerSetting_PurchaseDiscountAccountId",
                schema: "dbo",
                table: "GeneralLedgerSetting",
                column: "PurchaseDiscountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerSetting_SalesDiscountAccountId",
                schema: "dbo",
                table: "GeneralLedgerSetting",
                column: "SalesDiscountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLedgerSetting_ShippingChargeAccountId",
                schema: "dbo",
                table: "GeneralLedgerSetting",
                column: "ShippingChargeAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryControlJournal_ItemId",
                schema: "dbo",
                table: "InventoryControlJournal",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryControlJournal_MeasurementId",
                schema: "dbo",
                table: "InventoryControlJournal",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CostOfGoodsSoldAccountId",
                schema: "dbo",
                table: "Item",
                column: "CostOfGoodsSoldAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_InventoryAccountId",
                schema: "dbo",
                table: "Item",
                column: "InventoryAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_InventoryAdjustmentAccountId",
                schema: "dbo",
                table: "Item",
                column: "InventoryAdjustmentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemCategoryId",
                schema: "dbo",
                table: "Item",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemTaxGroupId",
                schema: "dbo",
                table: "Item",
                column: "ItemTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PreferredVendorId",
                schema: "dbo",
                table: "Item",
                column: "PreferredVendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PurchaseMeasurementId",
                schema: "dbo",
                table: "Item",
                column: "PurchaseMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SalesAccountId",
                schema: "dbo",
                table: "Item",
                column: "SalesAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SellMeasurementId",
                schema: "dbo",
                table: "Item",
                column: "SellMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SmallestMeasurementId",
                schema: "dbo",
                table: "Item",
                column: "SmallestMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategory_AdjustmentAccountId",
                schema: "dbo",
                table: "ItemCategory",
                column: "AdjustmentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategory_AssemblyAccountId",
                schema: "dbo",
                table: "ItemCategory",
                column: "AssemblyAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategory_CostOfGoodsSoldAccountId",
                schema: "dbo",
                table: "ItemCategory",
                column: "CostOfGoodsSoldAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategory_InventoryAccountId",
                schema: "dbo",
                table: "ItemCategory",
                column: "InventoryAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategory_MeasurementId",
                schema: "dbo",
                table: "ItemCategory",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategory_SalesAccountId",
                schema: "dbo",
                table: "ItemCategory",
                column: "SalesAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTaxGroupTax_ItemTaxGroupId",
                schema: "dbo",
                table: "ItemTaxGroupTax",
                column: "ItemTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTaxGroupTax_TaxId",
                schema: "dbo",
                table: "ItemTaxGroupTax",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntryHeader_GeneralLedgerHeaderId",
                schema: "dbo",
                table: "JournalEntryHeader",
                column: "GeneralLedgerHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntryHeader_PartyId",
                schema: "dbo",
                table: "JournalEntryHeader",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntryLine_AccountId",
                schema: "dbo",
                table: "JournalEntryLine",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntryLine_JournalEntryHeaderId",
                schema: "dbo",
                table: "JournalEntryLine",
                column: "JournalEntryHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_MainContraAccount_MainAccountId",
                schema: "dbo",
                table: "MainContraAccount",
                column: "MainAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_MainContraAccount_RelatedContraAccountId",
                schema: "dbo",
                table: "MainContraAccount",
                column: "RelatedContraAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceHeader_GeneralLedgerHeaderId",
                schema: "dbo",
                table: "PurchaseInvoiceHeader",
                column: "GeneralLedgerHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceHeader_VendorId",
                schema: "dbo",
                table: "PurchaseInvoiceHeader",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceLine_InventoryControlJournalId",
                schema: "dbo",
                table: "PurchaseInvoiceLine",
                column: "InventoryControlJournalId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceLine_ItemId",
                schema: "dbo",
                table: "PurchaseInvoiceLine",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceLine_MeasurementId",
                schema: "dbo",
                table: "PurchaseInvoiceLine",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceLine_PurchaseInvoiceHeaderId",
                schema: "dbo",
                table: "PurchaseInvoiceLine",
                column: "PurchaseInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceLine_PurchaseOrderLineId",
                schema: "dbo",
                table: "PurchaseInvoiceLine",
                column: "PurchaseOrderLineId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderHeader_PurchaseInvoiceHeaderId",
                schema: "dbo",
                table: "PurchaseOrderHeader",
                column: "PurchaseInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderHeader_VendorId",
                schema: "dbo",
                table: "PurchaseOrderHeader",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLine_ItemId",
                schema: "dbo",
                table: "PurchaseOrderLine",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLine_MeasurementId",
                schema: "dbo",
                table: "PurchaseOrderLine",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLine_PurchaseOrderHeaderId",
                schema: "dbo",
                table: "PurchaseOrderLine",
                column: "PurchaseOrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceiptHeader_GeneralLedgerHeaderId",
                schema: "dbo",
                table: "PurchaseReceiptHeader",
                column: "GeneralLedgerHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceiptHeader_VendorId",
                schema: "dbo",
                table: "PurchaseReceiptHeader",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceiptLine_InventoryControlJournalId",
                schema: "dbo",
                table: "PurchaseReceiptLine",
                column: "InventoryControlJournalId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceiptLine_ItemId",
                schema: "dbo",
                table: "PurchaseReceiptLine",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceiptLine_MeasurementId",
                schema: "dbo",
                table: "PurchaseReceiptLine",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceiptLine_PurchaseInvoiceLineId",
                schema: "dbo",
                table: "PurchaseReceiptLine",
                column: "PurchaseInvoiceLineId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReceiptLine_PurchaseReceiptHeaderId",
                schema: "dbo",
                table: "PurchaseReceiptLine",
                column: "PurchaseReceiptHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDeliveryHeader_CustomerId",
                schema: "dbo",
                table: "SalesDeliveryHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDeliveryHeader_GeneralLedgerHeaderId",
                schema: "dbo",
                table: "SalesDeliveryHeader",
                column: "GeneralLedgerHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDeliveryHeader_PaymentTermId",
                schema: "dbo",
                table: "SalesDeliveryHeader",
                column: "PaymentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDeliveryLine_ItemId",
                schema: "dbo",
                table: "SalesDeliveryLine",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDeliveryLine_MeasurementId",
                schema: "dbo",
                table: "SalesDeliveryLine",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDeliveryLine_SalesDeliveryHeaderId",
                schema: "dbo",
                table: "SalesDeliveryLine",
                column: "SalesDeliveryHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDeliveryLine_SalesInvoiceLineId",
                schema: "dbo",
                table: "SalesDeliveryLine",
                column: "SalesInvoiceLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_CustomerId",
                schema: "dbo",
                table: "SalesInvoiceHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_GeneralLedgerHeaderId",
                schema: "dbo",
                table: "SalesInvoiceHeader",
                column: "GeneralLedgerHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceLine_InventoryControlJournalId",
                schema: "dbo",
                table: "SalesInvoiceLine",
                column: "InventoryControlJournalId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceLine_ItemId",
                schema: "dbo",
                table: "SalesInvoiceLine",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceLine_MeasurementId",
                schema: "dbo",
                table: "SalesInvoiceLine",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceLine_SalesInvoiceHeaderId",
                schema: "dbo",
                table: "SalesInvoiceLine",
                column: "SalesInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceLine_SalesOrderLineId",
                schema: "dbo",
                table: "SalesInvoiceLine",
                column: "SalesOrderLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_CustomerId",
                schema: "dbo",
                table: "SalesOrderHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_PaymentTermId",
                schema: "dbo",
                table: "SalesOrderHeader",
                column: "PaymentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLine_ItemId",
                schema: "dbo",
                table: "SalesOrderLine",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLine_MeasurementId",
                schema: "dbo",
                table: "SalesOrderLine",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLine_SalesOrderHeaderId",
                schema: "dbo",
                table: "SalesOrderLine",
                column: "SalesOrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesQuoteHeader_CustomerId",
                schema: "dbo",
                table: "SalesQuoteHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesQuoteLine_ItemId",
                schema: "dbo",
                table: "SalesQuoteLine",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesQuoteLine_MeasurementId",
                schema: "dbo",
                table: "SalesQuoteLine",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesQuoteLine_SalesQuoteHeaderId",
                schema: "dbo",
                table: "SalesQuoteLine",
                column: "SalesQuoteHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceiptHeader_AccountToDebitId",
                schema: "dbo",
                table: "SalesReceiptHeader",
                column: "AccountToDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceiptHeader_CustomerId",
                schema: "dbo",
                table: "SalesReceiptHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceiptHeader_GeneralLedgerHeaderId",
                schema: "dbo",
                table: "SalesReceiptHeader",
                column: "GeneralLedgerHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceiptLine_AccountToCreditId",
                schema: "dbo",
                table: "SalesReceiptLine",
                column: "AccountToCreditId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceiptLine_SalesInvoiceLineId",
                schema: "dbo",
                table: "SalesReceiptLine",
                column: "SalesInvoiceLineId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceiptLine_SalesReceiptHeaderId",
                schema: "dbo",
                table: "SalesReceiptLine",
                column: "SalesReceiptHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityPermission_SecurityGroupId",
                schema: "dbo",
                table: "SecurityPermission",
                column: "SecurityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityRolePermission_SecurityPermissionId",
                schema: "dbo",
                table: "SecurityRolePermission",
                column: "SecurityPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityRolePermission_SecurityRoleId",
                schema: "dbo",
                table: "SecurityRolePermission",
                column: "SecurityRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityUserRole_SecurityRoleId",
                schema: "dbo",
                table: "SecurityUserRole",
                column: "SecurityRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityUserRole_UserId",
                schema: "dbo",
                table: "SecurityUserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_PurchasingAccountId",
                schema: "dbo",
                table: "Tax",
                column: "PurchasingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_SalesAccountId",
                schema: "dbo",
                table: "Tax",
                column: "SalesAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxGroupTax_TaxGroupId",
                schema: "dbo",
                table: "TaxGroupTax",
                column: "TaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxGroupTax_TaxId",
                schema: "dbo",
                table: "TaxGroupTax",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_AccountsPayableAccountId",
                schema: "dbo",
                table: "Vendor",
                column: "AccountsPayableAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_PartyId",
                schema: "dbo",
                table: "Vendor",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_PaymentTermId",
                schema: "dbo",
                table: "Vendor",
                column: "PaymentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_PrimaryContactId",
                schema: "dbo",
                table: "Vendor",
                column: "PrimaryContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_PurchaseAccountId",
                schema: "dbo",
                table: "Vendor",
                column: "PurchaseAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_PurchaseDiscountAccountId",
                schema: "dbo",
                table: "Vendor",
                column: "PurchaseDiscountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_TaxGroupId",
                schema: "dbo",
                table: "Vendor",
                column: "TaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorContact_ContactId",
                schema: "dbo",
                table: "VendorContact",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorContact_VendorId",
                schema: "dbo",
                table: "VendorContact",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorPayment_GeneralLedgerHeaderId",
                schema: "dbo",
                table: "VendorPayment",
                column: "GeneralLedgerHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorPayment_PurchaseInvoiceHeaderId",
                schema: "dbo",
                table: "VendorPayment",
                column: "PurchaseInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorPayment_VendorId",
                schema: "dbo",
                table: "VendorPayment",
                column: "VendorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AuditableAttribute",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AuditLog",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Bank",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CompanySetting",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustomerAllocation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustomerContact",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FinancialYear",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GeneralLedgerLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GeneralLedgerSetting",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ItemTaxGroupTax",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "JournalEntryLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Log",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MainContraAccount",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PurchaseReceiptLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesDeliveryLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesQuoteLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesReceiptLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SecurityRolePermission",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SecurityUserRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SequenceNumber",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TaxGroupTax",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "VendorContact",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "VendorPayment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AuditableEntity",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "JournalEntryHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PurchaseReceiptHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesDeliveryHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesQuoteHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesInvoiceLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesReceiptHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SecurityPermission",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SecurityRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "User",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Tax",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PurchaseOrderLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "InventoryControlJournal",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesInvoiceHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesOrderLine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SecurityGroups",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PurchaseOrderHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Item",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SalesOrderHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ItemCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ItemTaxGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GeneralLedgerHeader",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Vendor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Measurement",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Account",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Contact",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PaymentTerm",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TaxGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AccountClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Company",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Party",
                schema: "dbo");
        }
    }
}
