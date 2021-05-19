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

CREATE TABLE [stakeholders] (
    [Id] uniqueidentifier NOT NULL,
    [Code] nvarchar(50) NULL,
    [Name] nvarchar(50) NULL,
    [InfluenceOther] int NOT NULL,
    [DirectResourceControl] int NOT NULL,
    [InterestLevelTechnical] int NOT NULL,
    [InterestLevelNonTechnical] int NOT NULL,
    [PowerInProduct] int NOT NULL,
    [Knowledge] int NOT NULL,
    [Accessibility] int NOT NULL,
    CONSTRAINT [PK_stakeholders] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210508020857_initStakeholderConfig', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [stakeholders] ADD [InterestInProject] real NOT NULL DEFAULT CAST(0 AS real);
GO

ALTER TABLE [stakeholders] ADD [PowerInProject] real NOT NULL DEFAULT CAST(0 AS real);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210518023808_newColumns-PowerInProject-InterestInProject', N'5.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[stakeholders]') AND [c].[name] = N'InterestInProject');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [stakeholders] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [stakeholders] DROP COLUMN [InterestInProject];
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[stakeholders]') AND [c].[name] = N'PowerInProject');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [stakeholders] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [stakeholders] DROP COLUMN [PowerInProject];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210518030640_removeColumns-PowerInProject-InterestInProject', N'5.0.5');
GO

COMMIT;
GO

