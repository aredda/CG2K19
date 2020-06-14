
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/14/2020 21:56:04
-- Generated from EDMX file: C:\Users\aredd\Dropbox\VS Projects\CG2019-Areda_Ibrahim-TDI203\Concours2019\CGModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CG_Regional_2019];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Accomdati__Accom__182C9B23]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccomdationData] DROP CONSTRAINT [FK__Accomdati__Accom__182C9B23];
GO
IF OBJECT_ID(N'[dbo].[FK__Accomdati__Added__1920BF5C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccomdationData] DROP CONSTRAINT [FK__Accomdati__Added__1920BF5C];
GO
IF OBJECT_ID(N'[dbo].[FK__Accomdati__UserE__1A14E395]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccomdationData] DROP CONSTRAINT [FK__Accomdati__UserE__1A14E395];
GO
IF OBJECT_ID(N'[dbo].[FK__Accomndat__Accom__1B0907CE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccomndationPictures] DROP CONSTRAINT [FK__Accomndat__Accom__1B0907CE];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_User_Role];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AccomdationData]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccomdationData];
GO
IF OBJECT_ID(N'[dbo].[AccomdationType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccomdationType];
GO
IF OBJECT_ID(N'[dbo].[AccomndationPictures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccomndationPictures];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AccomdationDatas'
CREATE TABLE [dbo].[AccomdationDatas] (
    [AccomdationID] int IDENTITY(1,1) NOT NULL,
    [UserEmail] varchar(100)  NULL,
    [StarDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [AddedByEmail] varchar(100)  NULL,
    [AccomdationTypeID] int  NULL
);
GO

-- Creating table 'AccomdationTypes'
CREATE TABLE [dbo].[AccomdationTypes] (
    [AccomndationTypeID] int IDENTITY(1,1) NOT NULL,
    [AccomndationType] varchar(250)  NULL,
    [AccomndationPricePerNight] float  NULL
);
GO

-- Creating table 'AccomndationPictures'
CREATE TABLE [dbo].[AccomndationPictures] (
    [PictureID] int IDENTITY(1,1) NOT NULL,
    [AccomndationTypeID] int  NULL,
    [PicturePath] varchar(250)  NULL,
    [PictureTitle] varchar(250)  NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [RoleID] nvarchar(2)  NOT NULL,
    [RoleName] varchar(50)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Email] varchar(100)  NOT NULL,
    [Password] varchar(100)  NOT NULL,
    [FullName] varchar(200)  NULL,
    [Gender] varchar(10)  NULL,
    [DateOfBirth] datetime  NOT NULL,
    [MobileNo] varchar(20)  NOT NULL,
    [Photo] varchar(100)  NULL,
    [RoleID] nvarchar(2)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AccomdationID] in table 'AccomdationDatas'
ALTER TABLE [dbo].[AccomdationDatas]
ADD CONSTRAINT [PK_AccomdationDatas]
    PRIMARY KEY CLUSTERED ([AccomdationID] ASC);
GO

-- Creating primary key on [AccomndationTypeID] in table 'AccomdationTypes'
ALTER TABLE [dbo].[AccomdationTypes]
ADD CONSTRAINT [PK_AccomdationTypes]
    PRIMARY KEY CLUSTERED ([AccomndationTypeID] ASC);
GO

-- Creating primary key on [PictureID] in table 'AccomndationPictures'
ALTER TABLE [dbo].[AccomndationPictures]
ADD CONSTRAINT [PK_AccomndationPictures]
    PRIMARY KEY CLUSTERED ([PictureID] ASC);
GO

-- Creating primary key on [RoleID] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([RoleID] ASC);
GO

-- Creating primary key on [Email] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Email] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AccomdationTypeID] in table 'AccomdationDatas'
ALTER TABLE [dbo].[AccomdationDatas]
ADD CONSTRAINT [FK__Accomdati__Accom__182C9B23]
    FOREIGN KEY ([AccomdationTypeID])
    REFERENCES [dbo].[AccomdationTypes]
        ([AccomndationTypeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Accomdati__Accom__182C9B23'
CREATE INDEX [IX_FK__Accomdati__Accom__182C9B23]
ON [dbo].[AccomdationDatas]
    ([AccomdationTypeID]);
GO

-- Creating foreign key on [AddedByEmail] in table 'AccomdationDatas'
ALTER TABLE [dbo].[AccomdationDatas]
ADD CONSTRAINT [FK__Accomdati__Added__1920BF5C]
    FOREIGN KEY ([AddedByEmail])
    REFERENCES [dbo].[Users]
        ([Email])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Accomdati__Added__1920BF5C'
CREATE INDEX [IX_FK__Accomdati__Added__1920BF5C]
ON [dbo].[AccomdationDatas]
    ([AddedByEmail]);
GO

-- Creating foreign key on [UserEmail] in table 'AccomdationDatas'
ALTER TABLE [dbo].[AccomdationDatas]
ADD CONSTRAINT [FK__Accomdati__UserE__1A14E395]
    FOREIGN KEY ([UserEmail])
    REFERENCES [dbo].[Users]
        ([Email])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Accomdati__UserE__1A14E395'
CREATE INDEX [IX_FK__Accomdati__UserE__1A14E395]
ON [dbo].[AccomdationDatas]
    ([UserEmail]);
GO

-- Creating foreign key on [AccomndationTypeID] in table 'AccomndationPictures'
ALTER TABLE [dbo].[AccomndationPictures]
ADD CONSTRAINT [FK__Accomndat__Accom__1B0907CE]
    FOREIGN KEY ([AccomndationTypeID])
    REFERENCES [dbo].[AccomdationTypes]
        ([AccomndationTypeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Accomndat__Accom__1B0907CE'
CREATE INDEX [IX_FK__Accomndat__Accom__1B0907CE]
ON [dbo].[AccomndationPictures]
    ([AccomndationTypeID]);
GO

-- Creating foreign key on [RoleID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_User_Role]
    FOREIGN KEY ([RoleID])
    REFERENCES [dbo].[Roles]
        ([RoleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_Role'
CREATE INDEX [IX_FK_User_Role]
ON [dbo].[Users]
    ([RoleID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------