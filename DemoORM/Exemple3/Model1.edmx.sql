
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/08/2017 15:11:27
-- Generated from EDMX file: C:\Users\frc\Desktop\DL2016\DemoORM\Exemple3\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DemoORMExemple3];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_StagiaireFormation_Stagiaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StagiaireFormation] DROP CONSTRAINT [FK_StagiaireFormation_Stagiaire];
GO
IF OBJECT_ID(N'[dbo].[FK_StagiaireFormation_Formation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StagiaireFormation] DROP CONSTRAINT [FK_StagiaireFormation_Formation];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[StagiaireSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StagiaireSet];
GO
IF OBJECT_ID(N'[dbo].[FormationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormationSet];
GO
IF OBJECT_ID(N'[dbo].[StagiaireFormation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StagiaireFormation];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'StagiaireSet'
CREATE TABLE [dbo].[StagiaireSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Stagiaire2_Id] int  NULL
);
GO

-- Creating table 'FormationSet'
CREATE TABLE [dbo].[FormationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Niveau] nvarchar(max)  NOT NULL,
    [Libelle] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StagiaireFormation'
CREATE TABLE [dbo].[StagiaireFormation] (
    [Stagiaire_Id] int  NOT NULL,
    [Formation_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'StagiaireSet'
ALTER TABLE [dbo].[StagiaireSet]
ADD CONSTRAINT [PK_StagiaireSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormationSet'
ALTER TABLE [dbo].[FormationSet]
ADD CONSTRAINT [PK_FormationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Stagiaire_Id], [Formation_Id] in table 'StagiaireFormation'
ALTER TABLE [dbo].[StagiaireFormation]
ADD CONSTRAINT [PK_StagiaireFormation]
    PRIMARY KEY CLUSTERED ([Stagiaire_Id], [Formation_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Stagiaire_Id] in table 'StagiaireFormation'
ALTER TABLE [dbo].[StagiaireFormation]
ADD CONSTRAINT [FK_StagiaireFormation_Stagiaire]
    FOREIGN KEY ([Stagiaire_Id])
    REFERENCES [dbo].[StagiaireSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Formation_Id] in table 'StagiaireFormation'
ALTER TABLE [dbo].[StagiaireFormation]
ADD CONSTRAINT [FK_StagiaireFormation_Formation]
    FOREIGN KEY ([Formation_Id])
    REFERENCES [dbo].[FormationSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StagiaireFormation_Formation'
CREATE INDEX [IX_FK_StagiaireFormation_Formation]
ON [dbo].[StagiaireFormation]
    ([Formation_Id]);
GO

-- Creating foreign key on [Stagiaire2_Id] in table 'StagiaireSet'
ALTER TABLE [dbo].[StagiaireSet]
ADD CONSTRAINT [FK_StagiaireStagiaire]
    FOREIGN KEY ([Stagiaire2_Id])
    REFERENCES [dbo].[StagiaireSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StagiaireStagiaire'
CREATE INDEX [IX_FK_StagiaireStagiaire]
ON [dbo].[StagiaireSet]
    ([Stagiaire2_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------