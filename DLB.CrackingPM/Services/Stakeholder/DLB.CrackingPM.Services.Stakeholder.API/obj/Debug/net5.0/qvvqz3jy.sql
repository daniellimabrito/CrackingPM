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

