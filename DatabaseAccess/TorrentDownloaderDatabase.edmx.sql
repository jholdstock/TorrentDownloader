
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/09/2013 22:50:55
-- Generated from EDMX file: C:\Users\jholdstock\Desktop\DailyTvTorrentsAPI-master\DatabaseAccess\TorrentDownloaderDatabase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TorrentDownloader];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ShowEpisode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Episodes] DROP CONSTRAINT [FK_ShowEpisode];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Shows]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Shows];
GO
IF OBJECT_ID(N'[dbo].[Episodes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Episodes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Shows'
CREATE TABLE [dbo].[Shows] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NULL,
    [prettyName] nvarchar(max)  NULL,
    [genre] nvarchar(max)  NULL,
    [link] nvarchar(max)  NULL
);
GO

-- Creating table 'Episodes'
CREATE TABLE [dbo].[Episodes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [torrentFile720] nvarchar(max)  NULL,
    [torrentFile1080] nvarchar(max)  NULL,
    [torrentFileHD] nvarchar(max)  NULL,
    [num] nvarchar(max)  NULL,
    [title] nvarchar(max)  NULL,
    [age] int  NULL,
    [Downloaded] bit  NOT NULL,
    [Show_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Shows'
ALTER TABLE [dbo].[Shows]
ADD CONSTRAINT [PK_Shows]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Episodes'
ALTER TABLE [dbo].[Episodes]
ADD CONSTRAINT [PK_Episodes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Show_Id] in table 'Episodes'
ALTER TABLE [dbo].[Episodes]
ADD CONSTRAINT [FK_ShowEpisode]
    FOREIGN KEY ([Show_Id])
    REFERENCES [dbo].[Shows]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ShowEpisode'
CREATE INDEX [IX_FK_ShowEpisode]
ON [dbo].[Episodes]
    ([Show_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------