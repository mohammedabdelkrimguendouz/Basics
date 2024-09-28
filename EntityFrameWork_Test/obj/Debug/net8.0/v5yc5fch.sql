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

CREATE TABLE [Students] (
    [StudentID] int NOT NULL IDENTITY,
    [FullName] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NULL,
    [Phone] nvarchar(max) NOT NULL,
    [DateOfBirth] datetime2 NOT NULL,
    [Age] int NOT NULL,
    [Grade] smallint NOT NULL,
    [Gender] tinyint NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([StudentID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240916142725_StudentTable', N'8.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Departments] (
    [DepartmentID] int NOT NULL IDENTITY,
    [DepartmentName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY ([DepartmentID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240916172440_DepartmentTable', N'8.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Grades] (
    [GradeID] int NOT NULL IDENTITY,
    [DataBase] decimal(18,2) NOT NULL,
    [Algorithm] decimal(18,2) NOT NULL,
    [React] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Grades] PRIMARY KEY ([GradeID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240916174649_GradeTable', N'8.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Grade');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Students] DROP COLUMN [Grade];
GO

ALTER TABLE [Students] ADD [GradeID] int NOT NULL DEFAULT 0;
GO

CREATE INDEX [IX_Students_GradeID] ON [Students] ([GradeID]);
GO

ALTER TABLE [Students] ADD CONSTRAINT [FK_Students_Grades_GradeID] FOREIGN KEY ([GradeID]) REFERENCES [Grades] ([GradeID]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240916175519_OneToOneRelation', N'8.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Students] ADD [CountryID] int NOT NULL DEFAULT 0;
GO

CREATE TABLE [Countries] (
    [CountryID] int NOT NULL IDENTITY,
    [CountryName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY ([CountryID])
);
GO

CREATE INDEX [IX_Students_CountryID] ON [Students] ([CountryID]);
GO

ALTER TABLE [Students] ADD CONSTRAINT [FK_Students_Countries_CountryID] FOREIGN KEY ([CountryID]) REFERENCES [Countries] ([CountryID]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240916180802_OneToManyRelation', N'8.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Courses] (
    [CoursID] int NOT NULL IDENTITY,
    [CoursName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Courses] PRIMARY KEY ([CoursID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240916181940_CoursesTable', N'8.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [StudentsCourses] (
    [StudentCoursID] int NOT NULL IDENTITY,
    [StudentID] int NOT NULL,
    [CoursID] int NOT NULL,
    CONSTRAINT [PK_StudentsCourses] PRIMARY KEY ([StudentCoursID]),
    CONSTRAINT [FK_StudentsCourses_Courses_CoursID] FOREIGN KEY ([CoursID]) REFERENCES [Courses] ([CoursID]) ON DELETE CASCADE,
    CONSTRAINT [FK_StudentsCourses_Students_StudentID] FOREIGN KEY ([StudentID]) REFERENCES [Students] ([StudentID]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_StudentsCourses_CoursID] ON [StudentsCourses] ([CoursID]);
GO

CREATE INDEX [IX_StudentsCourses_StudentID] ON [StudentsCourses] ([StudentID]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240916182220_StudentCoursTable', N'8.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Phone');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Students] ALTER COLUMN [Phone] nvarchar(20) NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240918095140_updatestudent', N'8.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Countries]') AND [c].[name] = N'CountryName');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Countries] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Countries] ALTER COLUMN [CountryName] nvarchar(15) NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240918143256_update', N'8.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE UNIQUE INDEX [IX_Countries_CountryName] ON [Countries] ([CountryName]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240918173241_update2', N'8.0.8');
GO

COMMIT;
GO

