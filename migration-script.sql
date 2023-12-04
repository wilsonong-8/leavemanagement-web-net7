IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(128) NOT NULL,
    [ProviderKey] nvarchar(128) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(128) NOT NULL,
    [Name] nvarchar(128) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231124104826_CreateIdentitySchema', N'7.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [AspNetUsers] ADD [DateJoined] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [AspNetUsers] ADD [DateOfBirth] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [AspNetUsers] ADD [FirstName] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [AspNetUsers] ADD [LastName] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [AspNetUsers] ADD [TaxId] nvarchar(max) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231124110419_ExtendedUserTable', N'7.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'TaxId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [AspNetUsers] ALTER COLUMN [TaxId] nvarchar(max) NULL;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'LastName');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [AspNetUsers] ALTER COLUMN [LastName] nvarchar(max) NULL;
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'FirstName');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [AspNetUsers] ALTER COLUMN [FirstName] nvarchar(max) NULL;
GO

CREATE TABLE [LeaveTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [DefaultDays] int NOT NULL,
    [DateCreated] datetime2 NOT NULL,
    [DateModified] datetime2 NOT NULL,
    CONSTRAINT [PK_LeaveTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [LeaveAllocations] (
    [Id] int NOT NULL IDENTITY,
    [NumberOfDays] nvarchar(max) NOT NULL,
    [LeaveTypeId] int NOT NULL,
    [EmployeeId] nvarchar(max) NOT NULL,
    [DateCreated] datetime2 NOT NULL,
    [DateModified] datetime2 NOT NULL,
    CONSTRAINT [PK_LeaveAllocations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_LeaveAllocations_LeaveTypes_LeaveTypeId] FOREIGN KEY ([LeaveTypeId]) REFERENCES [LeaveTypes] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_LeaveAllocations_LeaveTypeId] ON [LeaveAllocations] ([LeaveTypeId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231124122354_AddedLeaveTables', N'7.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'69d10e4c-0427-4448-a13e-104c439ae422', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'69d10e4c-0427-4ee6-a13e-104c439aebba', NULL, N'User', N'USER');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'DateJoined', N'DateOfBirth', N'Email', N'EmailConfirmed', N'FirstName', N'LastName', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TaxId', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] ON;
INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [DateJoined], [DateOfBirth], [Email], [EmailConfirmed], [FirstName], [LastName], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TaxId], [TwoFactorEnabled], [UserName])
VALUES (N'69d10e4c-0427-4ee6-a13e-104c439ae888', 0, N'7fac0ffc-6159-4487-9c13-6a2e75036498', '0001-01-01T00:00:00.0000000', '0001-01-01T00:00:00.0000000', N'admin@gmail.com', CAST(0 AS bit), N'System', N'Admin', CAST(0 AS bit), NULL, N'ADMIN@GMAIL.COM', NULL, N'AQAAAAIAAYagAAAAEMf9Pi9TZcxU0gPpaIvT+1cg191/SHd8MLjpaIoKiCNMrVhVMbpDqawlyVhcx/8Bzg==', NULL, CAST(0 AS bit), N'fb672980-fddb-4003-aeba-1fc9a123c0b3', NULL, CAST(0 AS bit), NULL),
(N'f536c75a-a460-4ecb-a949-58305ba11968', 0, N'463ee51b-9958-4ce8-a782-5c9904205101', '0001-01-01T00:00:00.0000000', '0001-01-01T00:00:00.0000000', N'user@gmail.com', CAST(0 AS bit), N'System', N'User', CAST(0 AS bit), NULL, N'USER@GMAIL.COM', NULL, N'AQAAAAIAAYagAAAAEEm/X5CspqFA3+3AAlDmx9pdaY4aHIYTUcY6U7RtR2Wgt/nKwImj9FyYseVZnW2IGQ==', NULL, CAST(0 AS bit), N'14d7dc13-e646-40a3-846d-3d350edfcc0b', NULL, CAST(0 AS bit), NULL);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'DateJoined', N'DateOfBirth', N'Email', N'EmailConfirmed', N'FirstName', N'LastName', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TaxId', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] ON;
INSERT INTO [AspNetUserRoles] ([RoleId], [UserId])
VALUES (N'69d10e4c-0427-4448-a13e-104c439ae422', N'69d10e4c-0427-4ee6-a13e-104c439ae888'),
(N'69d10e4c-0427-4ee6-a13e-104c439aebba', N'f536c75a-a460-4ecb-a949-58305ba11968');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231127115506_AddedDefaultUsersAndRoles', N'7.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'01542898-aa80-466f-9137-8d14cdcc571a', [EmailConfirmed] = CAST(1 AS bit), [NormalizedUserName] = N'ADMIN@GMAIL.COM', [PasswordHash] = N'AQAAAAIAAYagAAAAELRvStv06NzIo1oI7RP3ajnB1KylMJ3W39rCDnnCKm251hyUnyyzscbIRJkHzAhDVA==', [SecurityStamp] = N'adbaae5f-9014-451c-8d1b-ab5f4c2701b0', [UserName] = N'admin@gmail.com'
WHERE [Id] = N'69d10e4c-0427-4ee6-a13e-104c439ae888';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'806bf10a-0e08-4e0a-a759-da46b7e542e2', [EmailConfirmed] = CAST(1 AS bit), [NormalizedUserName] = N'USER@GMAIL.COM', [PasswordHash] = N'AQAAAAIAAYagAAAAENcYOdrW4LefWRhO5RFIz5IyuvfB2/6GMazDb32H+SjaCD4PJBXrJ0stnS8xt7u+BQ==', [SecurityStamp] = N'2e1f8f61-9ad0-4265-8cfa-23dee43d8b77', [UserName] = N'user@gmail.com'
WHERE [Id] = N'f536c75a-a460-4ecb-a949-58305ba11968';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231127115922_AddedDefaultUsersAndRoles2', N'7.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'9104faef-46c0-4df0-89a0-ed612c9ce864', [PasswordHash] = N'AQAAAAIAAYagAAAAEK2//NsZOe1FvS2AxJzY0qHfwpsc/QgdqfbHM3ey7clzersyqQsyBwKT8eiy+nqi3Q==', [SecurityStamp] = N'bec82117-b93f-4f33-aac8-f47cfc577052'
WHERE [Id] = N'69d10e4c-0427-4ee6-a13e-104c439ae888';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'066759a2-602e-46b4-82db-268cac9faf01', [PasswordHash] = N'AQAAAAIAAYagAAAAECx/ZdBoe14nrLCLeAjVPKcvcW8FxLwqgqiu7k2kTspNUPEcUd4K9BeYy6h6HsJF/Q==', [SecurityStamp] = N'9b3a580c-152c-45ee-b893-19f865792dac'
WHERE [Id] = N'f536c75a-a460-4ecb-a949-58305ba11968';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231128063845_AddingPeriodToAllocation', N'7.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[LeaveAllocations]') AND [c].[name] = N'NumberOfDays');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [LeaveAllocations] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [LeaveAllocations] ALTER COLUMN [NumberOfDays] int NOT NULL;
GO

ALTER TABLE [LeaveAllocations] ADD [Period] int NOT NULL DEFAULT 0;
GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'42d8f3c0-9977-4f27-bf34-2199971fff20', [PasswordHash] = N'AQAAAAIAAYagAAAAEGE7A6qrEm2bsMWjV6ZIb0IAoVdF4CWqEbv6oKUeBSDBCXekSPfZnl6VWAZSQPxd8Q==', [SecurityStamp] = N'2c854066-3fc2-4995-b163-3ff5581bb058'
WHERE [Id] = N'69d10e4c-0427-4ee6-a13e-104c439ae888';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'91e6db27-fe79-4f10-aa3a-693b08d76d4b', [PasswordHash] = N'AQAAAAIAAYagAAAAEPJ6FdEqm8BzzdK5u6WtaBBnzAtK7HCctWbq1+8bDgpI/OlXZ4Kx9X2ntyFvaU3N3w==', [SecurityStamp] = N'ba8e56d4-12dc-4dfe-ade3-bcfbd7ea8dc4'
WHERE [Id] = N'f536c75a-a460-4ecb-a949-58305ba11968';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231128074835_AddingPeriodToAllocation2', N'7.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [LeaveRequests] (
    [Id] int NOT NULL IDENTITY,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [LeaveTypeId] int NOT NULL,
    [DateRequested] datetime2 NOT NULL,
    [RequestComments] nvarchar(max) NOT NULL,
    [Approved] bit NULL,
    [Cancelled] bit NOT NULL,
    [RequestEmployeeId] nvarchar(max) NOT NULL,
    [DateCreated] datetime2 NOT NULL,
    [DateModified] datetime2 NOT NULL,
    CONSTRAINT [PK_LeaveRequests] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_LeaveRequests_LeaveTypes_LeaveTypeId] FOREIGN KEY ([LeaveTypeId]) REFERENCES [LeaveTypes] ([Id]) ON DELETE NO ACTION
);
GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'2eebb70c-2624-4508-b385-6f6daa8defc7', [PasswordHash] = N'AQAAAAIAAYagAAAAEI7qS8RE8joDOId4lIS8yoDKcdINcB2letPL/QWz3JtV1jxxB1RFiyo/rP/3UGEkAw==', [SecurityStamp] = N'23e98cdf-067a-4356-bc27-0364441b21d8'
WHERE [Id] = N'69d10e4c-0427-4ee6-a13e-104c439ae888';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'52bc7124-7b0c-4362-b075-598bd709077a', [PasswordHash] = N'AQAAAAIAAYagAAAAEChpRb8KwokJ9ZZJGvR6cuMj3N3tMc+pEnqwf+b/m81MJxx48lcyxcZvAqOpGAdnUQ==', [SecurityStamp] = N'1161774a-49d5-4870-952d-58e70d3417c1'
WHERE [Id] = N'f536c75a-a460-4ecb-a949-58305ba11968';
SELECT @@ROWCOUNT;

GO

CREATE INDEX [IX_LeaveRequests_LeaveTypeId] ON [LeaveRequests] ([LeaveTypeId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231130053315_AddingLeaveRequestTable', N'7.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'2293fbe3-7f47-4742-943f-3b244413f143', [PasswordHash] = N'AQAAAAIAAYagAAAAEOuW8BIDqqN0jHFOGeNXoSRUI4kWx4DTNgnK1N+Lo5V4V9HiWurwimD/AiOVK0DoOQ==', [SecurityStamp] = N'e4b7042c-adc4-4239-a906-3d5f26137912'
WHERE [Id] = N'69d10e4c-0427-4ee6-a13e-104c439ae888';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'0e3795b7-c7e4-4bef-9132-028c21fcb9b6', [PasswordHash] = N'AQAAAAIAAYagAAAAEBa1vencLkiYrIh1uP1+pmaCtcEZ/iJ4VOKxe9ZaOUqFEBbhRD3frnxnbpXGe/U7MA==', [SecurityStamp] = N'2cc1a969-8e4c-4c28-aead-6bf2152a7889'
WHERE [Id] = N'f536c75a-a460-4ecb-a949-58305ba11968';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231201072626_UpdatedRequestComments', N'7.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[LeaveRequests]') AND [c].[name] = N'RequestComments');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [LeaveRequests] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [LeaveRequests] ALTER COLUMN [RequestComments] nvarchar(max) NULL;
GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'd91bb8f8-a803-4571-9663-302c8c2cebfc', [PasswordHash] = N'AQAAAAIAAYagAAAAEBoOzpnx+X5YQSLvjBVH1/2UBoahmyrH6vc5jgqY6XtEj8y9h3AgR2/X73es8WHE/w==', [SecurityStamp] = N'6acc032e-029e-4f6f-8fa9-399cdc3f1cd4'
WHERE [Id] = N'69d10e4c-0427-4ee6-a13e-104c439ae888';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'1b4cb5c7-f859-4891-8c89-74442694e6ab', [PasswordHash] = N'AQAAAAIAAYagAAAAECVNqAyNnC4t5ZIQHJ4ZOBsE6yDiDrPozu/gdulEO32GXdQRiprc1u8WhfuT7yjTAA==', [SecurityStamp] = N'd319f956-2caa-4a8d-9b42-ce9e3470a361'
WHERE [Id] = N'f536c75a-a460-4ecb-a949-58305ba11968';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231201073334_UpdatedRequestComments2', N'7.0.14');
GO

COMMIT;
GO

