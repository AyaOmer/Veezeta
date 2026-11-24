using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veezeta_Infrastrucure.Migrations;

/// <inheritdoc />
public partial class _20261123163255_addIntialTables : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "AspNetRoles",
            columns: table => new
            {
                Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUsers",
            columns: table => new
            {
                Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Gender = table.Column<int>(type: "int", nullable: false),
                userType = table.Column<int>(type: "int", nullable: false),
                UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Clinics",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                IsHospital = table.Column<bool>(type: "bit", nullable: false),
                LocationLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                TimeZoneId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Clinics", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Coupons",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                Value = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                DiscountType = table.Column<int>(type: "int", nullable: false),
                MaxUses = table.Column<int>(type: "int", nullable: true),
                UsedCount = table.Column<int>(type: "int", nullable: false),
                ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                IsActive = table.Column<bool>(type: "bit", nullable: false),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Coupons", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "InsuranceProviders",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                Website = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                IsActive = table.Column<bool>(type: "bit", nullable: false),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_InsuranceProviders", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Specialties",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                IsActive = table.Column<bool>(type: "bit", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Specialties", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AspNetRoleClaims",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                table.ForeignKey(
                    name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                    column: x => x.RoleId,
                    principalTable: "AspNetRoles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserClaims",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                table.ForeignKey(
                    name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserLogins",
            columns: table => new
            {
                LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                table.ForeignKey(
                    name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserRoles",
            columns: table => new
            {
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                table.ForeignKey(
                    name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                    column: x => x.RoleId,
                    principalTable: "AspNetRoles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserTokens",
            columns: table => new
            {
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                table.ForeignKey(
                    name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Doctors",
            columns: table => new
            {
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                MedicalLicenseNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Biography = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                IsVerified = table.Column<bool>(type: "bit", nullable: false),
                Image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Doctors", x => x.UserId);
                table.ForeignKey(
                    name: "FK_Doctors_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "ClinicWorkingHours",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                ClinicId = table.Column<int>(type: "int", nullable: false),
                DayOfWeek = table.Column<int>(type: "int", nullable: false),
                OpenTime = table.Column<TimeOnly>(type: "time", nullable: false),
                CloseTime = table.Column<TimeOnly>(type: "time", nullable: false),
                IsClosed = table.Column<bool>(type: "bit", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ClinicWorkingHours", x => x.Id);
                table.ForeignKey(
                    name: "FK_ClinicWorkingHours_Clinics_ClinicId",
                    column: x => x.ClinicId,
                    principalTable: "Clinics",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "PatientInsurances",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                InsuranceProviderId = table.Column<int>(type: "int", nullable: false),
                ExpiryDate = table.Column<DateOnly>(type: "date", nullable: false),
                MedicalCardPhoto = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                IsVerified = table.Column<bool>(type: "bit", nullable: false),
                VerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PatientInsurances", x => x.Id);
                table.ForeignKey(
                    name: "FK_PatientInsurances_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_PatientInsurances_InsuranceProviders_InsuranceProviderId",
                    column: x => x.InsuranceProviderId,
                    principalTable: "InsuranceProviders",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "Appointments",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ClinicId = table.Column<int>(type: "int", nullable: false),
                StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                SlotDurationMinutes = table.Column<int>(type: "int", nullable: false),
                Status = table.Column<int>(type: "int", nullable: false),
                OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                FinalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                BookedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                CancelledAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                CancellationReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Appointments", x => x.Id);
                table.ForeignKey(
                    name: "FK_Appointments_AspNetUsers_PatientId",
                    column: x => x.PatientId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_Appointments_Clinics_ClinicId",
                    column: x => x.ClinicId,
                    principalTable: "Clinics",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_Appointments_Doctors_DoctorId",
                    column: x => x.DoctorId,
                    principalTable: "Doctors",
                    principalColumn: "UserId",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "DoctorClinics",
            columns: table => new
            {
                DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ClinicId = table.Column<int>(type: "int", nullable: false),
                IsActive = table.Column<bool>(type: "bit", nullable: false),
                JoinedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_DoctorClinics", x => new { x.DoctorId, x.ClinicId });
                table.ForeignKey(
                    name: "FK_DoctorClinics_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_DoctorClinics_Clinics_ClinicId",
                    column: x => x.ClinicId,
                    principalTable: "Clinics",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_DoctorClinics_Doctors_DoctorId",
                    column: x => x.DoctorId,
                    principalTable: "Doctors",
                    principalColumn: "UserId",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "DoctorScheduleExceptions",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ClinicId = table.Column<int>(type: "int", nullable: false),
                StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                SlotDurationMinutes = table.Column<int>(type: "int", nullable: true),
                Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_DoctorScheduleExceptions", x => x.Id);
                table.ForeignKey(
                    name: "FK_DoctorScheduleExceptions_Clinics_ClinicId",
                    column: x => x.ClinicId,
                    principalTable: "Clinics",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_DoctorScheduleExceptions_Doctors_DoctorId",
                    column: x => x.DoctorId,
                    principalTable: "Doctors",
                    principalColumn: "UserId",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "DoctorSchedules",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ClinicId = table.Column<int>(type: "int", nullable: false),
                DayOfWeek = table.Column<int>(type: "int", nullable: false),
                StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                SlotDurationMinutes = table.Column<int>(type: "int", nullable: false),
                EffectiveFrom = table.Column<DateOnly>(type: "date", nullable: true),
                EffectiveTo = table.Column<DateOnly>(type: "date", nullable: true),
                IsActive = table.Column<bool>(type: "bit", nullable: false),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_DoctorSchedules", x => x.Id);
                table.ForeignKey(
                    name: "FK_DoctorSchedules_Clinics_ClinicId",
                    column: x => x.ClinicId,
                    principalTable: "Clinics",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_DoctorSchedules_Doctors_DoctorId",
                    column: x => x.DoctorId,
                    principalTable: "Doctors",
                    principalColumn: "UserId",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "DoctorSpecialties",
            columns: table => new
            {
                DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                SpecialtyId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_DoctorSpecialties", x => new { x.DoctorId, x.SpecialtyId });
                table.ForeignKey(
                    name: "FK_DoctorSpecialties_Doctors_DoctorId",
                    column: x => x.DoctorId,
                    principalTable: "Doctors",
                    principalColumn: "UserId",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_DoctorSpecialties_Specialties_SpecialtyId",
                    column: x => x.SpecialtyId,
                    principalTable: "Specialties",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "AppointmentInsurances",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                AppointmentId = table.Column<int>(type: "int", nullable: false),
                PatientInsuranceId = table.Column<int>(type: "int", nullable: false),
                CoverageAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                PatientCopayment = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                AuthorizationNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AppointmentInsurances", x => x.Id);
                table.ForeignKey(
                    name: "FK_AppointmentInsurances_Appointments_AppointmentId",
                    column: x => x.AppointmentId,
                    principalTable: "Appointments",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_AppointmentInsurances_PatientInsurances_PatientInsuranceId",
                    column: x => x.PatientInsuranceId,
                    principalTable: "PatientInsurances",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "CouponRedemptions",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                CouponId = table.Column<int>(type: "int", nullable: false),
                PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                AppointmentId = table.Column<int>(type: "int", nullable: false),
                DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                RedeemedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CouponRedemptions", x => x.Id);
                table.ForeignKey(
                    name: "FK_CouponRedemptions_Appointments_AppointmentId",
                    column: x => x.AppointmentId,
                    principalTable: "Appointments",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_CouponRedemptions_AspNetUsers_PatientId",
                    column: x => x.PatientId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_CouponRedemptions_Coupons_CouponId",
                    column: x => x.CouponId,
                    principalTable: "Coupons",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "Payments",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                AppointmentId = table.Column<int>(type: "int", nullable: false),
                TransactionId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                PaymentGateway = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                PaymentMethod = table.Column<int>(type: "int", nullable: false),
                Status = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                FailureReason = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Payments", x => x.Id);
                table.ForeignKey(
                    name: "FK_Payments_Appointments_AppointmentId",
                    column: x => x.AppointmentId,
                    principalTable: "Appointments",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateIndex(
            name: "IX_AppointmentInsurances_AppointmentId",
            table: "AppointmentInsurances",
            column: "AppointmentId",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_AppointmentInsurances_PatientInsuranceId",
            table: "AppointmentInsurances",
            column: "PatientInsuranceId");

        migrationBuilder.CreateIndex(
            name: "IX_Appointments_ClinicId_StartAt",
            table: "Appointments",
            columns: new[] { "ClinicId", "StartAt" });

        migrationBuilder.CreateIndex(
            name: "IX_Appointments_DoctorId_StartAt",
            table: "Appointments",
            columns: new[] { "DoctorId", "StartAt" });

        migrationBuilder.CreateIndex(
            name: "IX_Appointments_PatientId_StartAt",
            table: "Appointments",
            columns: new[] { "PatientId", "StartAt" });

        migrationBuilder.CreateIndex(
            name: "IX_AspNetRoleClaims_RoleId",
            table: "AspNetRoleClaims",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "RoleNameIndex",
            table: "AspNetRoles",
            column: "NormalizedName",
            unique: true,
            filter: "[NormalizedName] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserClaims_UserId",
            table: "AspNetUserClaims",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserLogins_UserId",
            table: "AspNetUserLogins",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserRoles_RoleId",
            table: "AspNetUserRoles",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "EmailIndex",
            table: "AspNetUsers",
            column: "NormalizedEmail");

        migrationBuilder.CreateIndex(
            name: "UserNameIndex",
            table: "AspNetUsers",
            column: "NormalizedUserName",
            unique: true,
            filter: "[NormalizedUserName] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_ClinicWorkingHours_ClinicId",
            table: "ClinicWorkingHours",
            column: "ClinicId");

        migrationBuilder.CreateIndex(
            name: "IX_CouponRedemptions_AppointmentId",
            table: "CouponRedemptions",
            column: "AppointmentId",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_CouponRedemptions_CouponId_PatientId",
            table: "CouponRedemptions",
            columns: new[] { "CouponId", "PatientId" });

        migrationBuilder.CreateIndex(
            name: "IX_CouponRedemptions_PatientId",
            table: "CouponRedemptions",
            column: "PatientId");

        migrationBuilder.CreateIndex(
            name: "IX_Coupons_Code",
            table: "Coupons",
            column: "Code",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_DoctorClinics_ClinicId",
            table: "DoctorClinics",
            column: "ClinicId");

        migrationBuilder.CreateIndex(
            name: "IX_DoctorClinics_UserId",
            table: "DoctorClinics",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_Doctors_MedicalLicenseNumber",
            table: "Doctors",
            column: "MedicalLicenseNumber",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_DoctorScheduleExceptions_ClinicId",
            table: "DoctorScheduleExceptions",
            column: "ClinicId");

        migrationBuilder.CreateIndex(
            name: "IX_DoctorScheduleExceptions_DoctorId",
            table: "DoctorScheduleExceptions",
            column: "DoctorId");

        migrationBuilder.CreateIndex(
            name: "IX_DoctorSchedules_ClinicId",
            table: "DoctorSchedules",
            column: "ClinicId");

        migrationBuilder.CreateIndex(
            name: "IX_DoctorSchedules_DoctorId",
            table: "DoctorSchedules",
            column: "DoctorId");

        migrationBuilder.CreateIndex(
            name: "IX_DoctorSpecialties_SpecialtyId",
            table: "DoctorSpecialties",
            column: "SpecialtyId");

        migrationBuilder.CreateIndex(
            name: "IX_InsuranceProviders_Name",
            table: "InsuranceProviders",
            column: "Name",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_PatientInsurances_InsuranceProviderId",
            table: "PatientInsurances",
            column: "InsuranceProviderId");

        migrationBuilder.CreateIndex(
            name: "IX_PatientInsurances_UserId",
            table: "PatientInsurances",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_Payments_AppointmentId",
            table: "Payments",
            column: "AppointmentId");

        migrationBuilder.CreateIndex(
            name: "IX_Payments_TransactionId",
            table: "Payments",
            column: "TransactionId",
            unique: true,
            filter: "[TransactionId] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_Specialties_Name",
            table: "Specialties",
            column: "Name",
            unique: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "AppointmentInsurances");

        migrationBuilder.DropTable(
            name: "AspNetRoleClaims");

        migrationBuilder.DropTable(
            name: "AspNetUserClaims");

        migrationBuilder.DropTable(
            name: "AspNetUserLogins");

        migrationBuilder.DropTable(
            name: "AspNetUserRoles");

        migrationBuilder.DropTable(
            name: "AspNetUserTokens");

        migrationBuilder.DropTable(
            name: "ClinicWorkingHours");

        migrationBuilder.DropTable(
            name: "CouponRedemptions");

        migrationBuilder.DropTable(
            name: "DoctorClinics");

        migrationBuilder.DropTable(
            name: "DoctorScheduleExceptions");

        migrationBuilder.DropTable(
            name: "DoctorSchedules");

        migrationBuilder.DropTable(
            name: "DoctorSpecialties");

        migrationBuilder.DropTable(
            name: "Payments");

        migrationBuilder.DropTable(
            name: "PatientInsurances");

        migrationBuilder.DropTable(
            name: "AspNetRoles");

        migrationBuilder.DropTable(
            name: "Coupons");

        migrationBuilder.DropTable(
            name: "Specialties");

        migrationBuilder.DropTable(
            name: "Appointments");

        migrationBuilder.DropTable(
            name: "InsuranceProviders");

        migrationBuilder.DropTable(
            name: "Clinics");

        migrationBuilder.DropTable(
            name: "Doctors");

        migrationBuilder.DropTable(
            name: "AspNetUsers");
    }
}
