
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/07/2018 23:53:48
-- Generated from EDMX file: E:\TubDB\DataLibrary\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TubDataBase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BloodTest_BloodTest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BloodTest] DROP CONSTRAINT [FK_BloodTest_BloodTest];
GO
IF OBJECT_ID(N'[dbo].[FK_BlTest - Patient_BloodTest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlTest - Patient] DROP CONSTRAINT [FK_BlTest - Patient_BloodTest];
GO
IF OBJECT_ID(N'[dbo].[FK_BlTest - Patient_Patients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlTest - Patient] DROP CONSTRAINT [FK_BlTest - Patient_Patients];
GO
IF OBJECT_ID(N'[dbo].[FK_BlTest - Patient_State]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlTest - Patient] DROP CONSTRAINT [FK_BlTest - Patient_State];
GO
IF OBJECT_ID(N'[dbo].[FK_Consult - Patient_Consultation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consult - Patient] DROP CONSTRAINT [FK_Consult - Patient_Consultation];
GO
IF OBJECT_ID(N'[dbo].[FK_Consult - Patient_Patients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consult - Patient] DROP CONSTRAINT [FK_Consult - Patient_Patients];
GO
IF OBJECT_ID(N'[dbo].[FK_Consult - Patient_State]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consult - Patient] DROP CONSTRAINT [FK_Consult - Patient_State];
GO
IF OBJECT_ID(N'[dbo].[FK_Consultation_ConsultationType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consultation] DROP CONSTRAINT [FK_Consultation_ConsultationType];
GO
IF OBJECT_ID(N'[dbo].[FK_HepTest - Patient_HepaticTest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HepTest - Patient] DROP CONSTRAINT [FK_HepTest - Patient_HepaticTest];
GO
IF OBJECT_ID(N'[dbo].[FK_HepTest - Patient_Patients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HepTest - Patient] DROP CONSTRAINT [FK_HepTest - Patient_Patients];
GO
IF OBJECT_ID(N'[dbo].[FK_HepTest - Patient_State]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HepTest - Patient] DROP CONSTRAINT [FK_HepTest - Patient_State];
GO
IF OBJECT_ID(N'[dbo].[FK_Patients_BK]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Patients] DROP CONSTRAINT [FK_Patients_BK];
GO
IF OBJECT_ID(N'[dbo].[FK_Patients_Destruction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Patients] DROP CONSTRAINT [FK_Patients_Destruction];
GO
IF OBJECT_ID(N'[dbo].[FK_Patients_Diagnosis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Patients] DROP CONSTRAINT [FK_Patients_Diagnosis];
GO
IF OBJECT_ID(N'[dbo].[FK_Patients_Gender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Patients] DROP CONSTRAINT [FK_Patients_Gender];
GO
IF OBJECT_ID(N'[dbo].[FK_Patients_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Patients] DROP CONSTRAINT [FK_Patients_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_SputumTest - Patient_Patients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SputumTest - Patient] DROP CONSTRAINT [FK_SputumTest - Patient_Patients];
GO
IF OBJECT_ID(N'[dbo].[FK_SputumTest - Patient_SputumTest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SputumTest - Patient] DROP CONSTRAINT [FK_SputumTest - Patient_SputumTest];
GO
IF OBJECT_ID(N'[dbo].[FK_SputumTest - Patient_State]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SputumTest - Patient] DROP CONSTRAINT [FK_SputumTest - Patient_State];
GO
IF OBJECT_ID(N'[dbo].[FK_UrTest- Patient_Patients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UrTest- Patient] DROP CONSTRAINT [FK_UrTest- Patient_Patients];
GO
IF OBJECT_ID(N'[dbo].[FK_UrTest- Patient_State]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UrTest- Patient] DROP CONSTRAINT [FK_UrTest- Patient_State];
GO
IF OBJECT_ID(N'[dbo].[FK_UrTest- Patient_UrineTest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UrTest- Patient] DROP CONSTRAINT [FK_UrTest- Patient_UrineTest];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BK]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BK];
GO
IF OBJECT_ID(N'[dbo].[BloodTest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BloodTest];
GO
IF OBJECT_ID(N'[dbo].[BlTest - Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BlTest - Patient];
GO
IF OBJECT_ID(N'[dbo].[Consult - Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consult - Patient];
GO
IF OBJECT_ID(N'[dbo].[Consultation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consultation];
GO
IF OBJECT_ID(N'[dbo].[ConsultationType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultationType];
GO
IF OBJECT_ID(N'[dbo].[Destruction]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Destruction];
GO
IF OBJECT_ID(N'[dbo].[Diagnosis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Diagnosis];
GO
IF OBJECT_ID(N'[dbo].[Gender]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gender];
GO
IF OBJECT_ID(N'[dbo].[HepaticTest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HepaticTest];
GO
IF OBJECT_ID(N'[dbo].[HepTest - Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HepTest - Patient];
GO
IF OBJECT_ID(N'[dbo].[Logs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Logs];
GO
IF OBJECT_ID(N'[dbo].[Patients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Patients];
GO
IF OBJECT_ID(N'[dbo].[SputumTest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SputumTest];
GO
IF OBJECT_ID(N'[dbo].[SputumTest - Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SputumTest - Patient];
GO
IF OBJECT_ID(N'[dbo].[State]', 'U') IS NOT NULL
    DROP TABLE [dbo].[State];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Type];
GO
IF OBJECT_ID(N'[dbo].[UrineTest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UrineTest];
GO
IF OBJECT_ID(N'[dbo].[UrTest- Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UrTest- Patient];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BK'
CREATE TABLE [dbo].[BK] (
    [bk_id] int IDENTITY(1,1) NOT NULL,
    [bk_value] nchar(1)  NOT NULL
);
GO

-- Creating table 'BloodTest'
CREATE TABLE [dbo].[BloodTest] (
    [bltest_id] int IDENTITY(1,1) NOT NULL,
    [bltest_leu] float  NULL,
    [bltest_hem] int  NULL,
    [bltest_er] float  NULL,
    [bltest_gran] int  NULL,
    [bltest_limf] int  NULL,
    [bltest_mono] int  NULL,
    [bltest_soy] int  NULL
);
GO

-- Creating table 'BlTest___Patient'
CREATE TABLE [dbo].[BlTest___Patient] (
    [bltp_id] int IDENTITY(1,1) NOT NULL,
    [bltp_patid] int  NOT NULL,
    [bltp_testid] int  NOT NULL,
    [bltp_date] datetime  NOT NULL,
    [bltp_state] int  NOT NULL
);
GO

-- Creating table 'Consult___Patient'
CREATE TABLE [dbo].[Consult___Patient] (
    [cp_id] int IDENTITY(1,1) NOT NULL,
    [cp_patid] int  NOT NULL,
    [cp_consid] int  NOT NULL,
    [cp_date] datetime  NOT NULL,
    [cp_state] int  NOT NULL
);
GO

-- Creating table 'Consultation'
CREATE TABLE [dbo].[Consultation] (
    [cons_id] int IDENTITY(1,1) NOT NULL,
    [cons_type] int  NOT NULL,
    [cons_komment] nvarchar(max)  NULL
);
GO

-- Creating table 'ConsultationType'
CREATE TABLE [dbo].[ConsultationType] (
    [ct_id] int IDENTITY(1,1) NOT NULL,
    [ct_value] nchar(20)  NOT NULL
);
GO

-- Creating table 'Destruction'
CREATE TABLE [dbo].[Destruction] (
    [destr_id] int IDENTITY(1,1) NOT NULL,
    [destr_value] nchar(1)  NOT NULL
);
GO

-- Creating table 'Diagnosis'
CREATE TABLE [dbo].[Diagnosis] (
    [diag_id] int IDENTITY(1,1) NOT NULL,
    [diag_value] nchar(15)  NOT NULL
);
GO

-- Creating table 'Gender'
CREATE TABLE [dbo].[Gender] (
    [gen_id] int IDENTITY(1,1) NOT NULL,
    [gen_value] nchar(8)  NOT NULL
);
GO

-- Creating table 'HepaticTest'
CREATE TABLE [dbo].[HepaticTest] (
    [heptest_id] int IDENTITY(1,1) NOT NULL,
    [heptest_bilir] float  NULL,
    [heptest_timil] int  NULL,
    [heptest_alt] float  NULL,
    [heptest_ast] float  NULL,
    [heptest_uricasid] int  NULL,
    [heptest_kreat] float  NULL
);
GO

-- Creating table 'HepTest___Patient'
CREATE TABLE [dbo].[HepTest___Patient] (
    [htp_id] int IDENTITY(1,1) NOT NULL,
    [htp_patid] int  NOT NULL,
    [htp_testid] int  NOT NULL,
    [htp_date] datetime  NOT NULL,
    [htp_state] int  NOT NULL
);
GO

-- Creating table 'Logs'
CREATE TABLE [dbo].[Logs] (
    [log_id] int IDENTITY(1,1) NOT NULL,
    [log_date] datetime  NOT NULL
);
GO

-- Creating table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [p_id] int IDENTITY(1,1) NOT NULL,
    [p_name] nvarchar(50)  NOT NULL,
    [p_surname] nvarchar(50)  NOT NULL,
    [p_secname] nvarchar(50)  NULL,
    [p_birthday] datetime  NULL,
    [p_genderId] int  NOT NULL,
    [p_factAddress] nvarchar(max)  NULL,
    [p_regAddress] nvarchar(max)  NULL,
    [p_diagnosisId] int  NULL,
    [p_typeId] int  NULL,
    [p_bkID] int  NULL,
    [p_destructionId] int  NULL,
    [p_otherDiseases] nvarchar(max)  NULL,
    [p_firstVisit] datetime  NULL,
    [p_lastVisit] datetime  NULL,
    [p_result] nvarchar(50)  NULL,
    [p_phones] nvarchar(max)  NULL,
    [p_komment] nvarchar(max)  NULL
);
GO

-- Creating table 'SputumTest'
CREATE TABLE [dbo].[SputumTest] (
    [sputtest_id] int IDENTITY(1,1) NOT NULL,
    [sputtest_scopy] float  NULL,
    [sputtest_inocul] char(1)  NULL
);
GO

-- Creating table 'SputumTest___Patient'
CREATE TABLE [dbo].[SputumTest___Patient] (
    [sptp_id] int IDENTITY(1,1) NOT NULL,
    [sptp_patid] int  NOT NULL,
    [sptp_testid] int  NOT NULL,
    [sptp_date] datetime  NOT NULL,
    [sptp_state] int  NOT NULL
);
GO

-- Creating table 'State'
CREATE TABLE [dbo].[State] (
    [state_id] int IDENTITY(1,1) NOT NULL,
    [state_value] char(15)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Type'
CREATE TABLE [dbo].[Type] (
    [type_id] int IDENTITY(1,1) NOT NULL,
    [type_value] nchar(15)  NOT NULL
);
GO

-- Creating table 'UrineTest'
CREATE TABLE [dbo].[UrineTest] (
    [urtest_id] int IDENTITY(1,1) NOT NULL,
    [urtest_protein] float  NULL,
    [urtest_sugar] char(1)  NULL,
    [urtest_leumin] int  NULL,
    [urtest_leumax] int  NULL,
    [urtest_ermin] int  NULL,
    [urtest_ermax] int  NULL
);
GO

-- Creating table 'UrTest__Patient'
CREATE TABLE [dbo].[UrTest__Patient] (
    [utp_id] int IDENTITY(1,1) NOT NULL,
    [utp_patid] int  NOT NULL,
    [utp_testid] int  NULL,
    [utp_date] datetime  NOT NULL,
    [utp_state] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [bk_id] in table 'BK'
ALTER TABLE [dbo].[BK]
ADD CONSTRAINT [PK_BK]
    PRIMARY KEY CLUSTERED ([bk_id] ASC);
GO

-- Creating primary key on [bltest_id] in table 'BloodTest'
ALTER TABLE [dbo].[BloodTest]
ADD CONSTRAINT [PK_BloodTest]
    PRIMARY KEY CLUSTERED ([bltest_id] ASC);
GO

-- Creating primary key on [bltp_id] in table 'BlTest___Patient'
ALTER TABLE [dbo].[BlTest___Patient]
ADD CONSTRAINT [PK_BlTest___Patient]
    PRIMARY KEY CLUSTERED ([bltp_id] ASC);
GO

-- Creating primary key on [cp_id] in table 'Consult___Patient'
ALTER TABLE [dbo].[Consult___Patient]
ADD CONSTRAINT [PK_Consult___Patient]
    PRIMARY KEY CLUSTERED ([cp_id] ASC);
GO

-- Creating primary key on [cons_id] in table 'Consultation'
ALTER TABLE [dbo].[Consultation]
ADD CONSTRAINT [PK_Consultation]
    PRIMARY KEY CLUSTERED ([cons_id] ASC);
GO

-- Creating primary key on [ct_id] in table 'ConsultationType'
ALTER TABLE [dbo].[ConsultationType]
ADD CONSTRAINT [PK_ConsultationType]
    PRIMARY KEY CLUSTERED ([ct_id] ASC);
GO

-- Creating primary key on [destr_id] in table 'Destruction'
ALTER TABLE [dbo].[Destruction]
ADD CONSTRAINT [PK_Destruction]
    PRIMARY KEY CLUSTERED ([destr_id] ASC);
GO

-- Creating primary key on [diag_id] in table 'Diagnosis'
ALTER TABLE [dbo].[Diagnosis]
ADD CONSTRAINT [PK_Diagnosis]
    PRIMARY KEY CLUSTERED ([diag_id] ASC);
GO

-- Creating primary key on [gen_id] in table 'Gender'
ALTER TABLE [dbo].[Gender]
ADD CONSTRAINT [PK_Gender]
    PRIMARY KEY CLUSTERED ([gen_id] ASC);
GO

-- Creating primary key on [heptest_id] in table 'HepaticTest'
ALTER TABLE [dbo].[HepaticTest]
ADD CONSTRAINT [PK_HepaticTest]
    PRIMARY KEY CLUSTERED ([heptest_id] ASC);
GO

-- Creating primary key on [htp_id] in table 'HepTest___Patient'
ALTER TABLE [dbo].[HepTest___Patient]
ADD CONSTRAINT [PK_HepTest___Patient]
    PRIMARY KEY CLUSTERED ([htp_id] ASC);
GO

-- Creating primary key on [log_id] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [PK_Logs]
    PRIMARY KEY CLUSTERED ([log_id] ASC);
GO

-- Creating primary key on [p_id] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [PK_Patients]
    PRIMARY KEY CLUSTERED ([p_id] ASC);
GO

-- Creating primary key on [sputtest_id] in table 'SputumTest'
ALTER TABLE [dbo].[SputumTest]
ADD CONSTRAINT [PK_SputumTest]
    PRIMARY KEY CLUSTERED ([sputtest_id] ASC);
GO

-- Creating primary key on [sptp_id] in table 'SputumTest___Patient'
ALTER TABLE [dbo].[SputumTest___Patient]
ADD CONSTRAINT [PK_SputumTest___Patient]
    PRIMARY KEY CLUSTERED ([sptp_id] ASC);
GO

-- Creating primary key on [state_id] in table 'State'
ALTER TABLE [dbo].[State]
ADD CONSTRAINT [PK_State]
    PRIMARY KEY CLUSTERED ([state_id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [type_id] in table 'Type'
ALTER TABLE [dbo].[Type]
ADD CONSTRAINT [PK_Type]
    PRIMARY KEY CLUSTERED ([type_id] ASC);
GO

-- Creating primary key on [urtest_id] in table 'UrineTest'
ALTER TABLE [dbo].[UrineTest]
ADD CONSTRAINT [PK_UrineTest]
    PRIMARY KEY CLUSTERED ([urtest_id] ASC);
GO

-- Creating primary key on [utp_id] in table 'UrTest__Patient'
ALTER TABLE [dbo].[UrTest__Patient]
ADD CONSTRAINT [PK_UrTest__Patient]
    PRIMARY KEY CLUSTERED ([utp_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [p_bkID] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [FK_Patients_BK]
    FOREIGN KEY ([p_bkID])
    REFERENCES [dbo].[BK]
        ([bk_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Patients_BK'
CREATE INDEX [IX_FK_Patients_BK]
ON [dbo].[Patients]
    ([p_bkID]);
GO

-- Creating foreign key on [bltest_id] in table 'BloodTest'
ALTER TABLE [dbo].[BloodTest]
ADD CONSTRAINT [FK_BloodTest_BloodTest]
    FOREIGN KEY ([bltest_id])
    REFERENCES [dbo].[BloodTest]
        ([bltest_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [bltp_testid] in table 'BlTest___Patient'
ALTER TABLE [dbo].[BlTest___Patient]
ADD CONSTRAINT [FK_BlTest___Patient_BloodTest]
    FOREIGN KEY ([bltp_testid])
    REFERENCES [dbo].[BloodTest]
        ([bltest_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BlTest___Patient_BloodTest'
CREATE INDEX [IX_FK_BlTest___Patient_BloodTest]
ON [dbo].[BlTest___Patient]
    ([bltp_testid]);
GO

-- Creating foreign key on [bltp_patid] in table 'BlTest___Patient'
ALTER TABLE [dbo].[BlTest___Patient]
ADD CONSTRAINT [FK_BlTest___Patient_Patients]
    FOREIGN KEY ([bltp_patid])
    REFERENCES [dbo].[Patients]
        ([p_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BlTest___Patient_Patients'
CREATE INDEX [IX_FK_BlTest___Patient_Patients]
ON [dbo].[BlTest___Patient]
    ([bltp_patid]);
GO

-- Creating foreign key on [bltp_state] in table 'BlTest___Patient'
ALTER TABLE [dbo].[BlTest___Patient]
ADD CONSTRAINT [FK_BlTest___Patient_State]
    FOREIGN KEY ([bltp_state])
    REFERENCES [dbo].[State]
        ([state_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BlTest___Patient_State'
CREATE INDEX [IX_FK_BlTest___Patient_State]
ON [dbo].[BlTest___Patient]
    ([bltp_state]);
GO

-- Creating foreign key on [cp_state] in table 'Consult___Patient'
ALTER TABLE [dbo].[Consult___Patient]
ADD CONSTRAINT [FK_Comsult___Patient_State]
    FOREIGN KEY ([cp_state])
    REFERENCES [dbo].[State]
        ([state_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comsult___Patient_State'
CREATE INDEX [IX_FK_Comsult___Patient_State]
ON [dbo].[Consult___Patient]
    ([cp_state]);
GO

-- Creating foreign key on [cp_patid] in table 'Consult___Patient'
ALTER TABLE [dbo].[Consult___Patient]
ADD CONSTRAINT [FK_Consult___Patient_Patients]
    FOREIGN KEY ([cp_patid])
    REFERENCES [dbo].[Patients]
        ([p_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Consult___Patient_Patients'
CREATE INDEX [IX_FK_Consult___Patient_Patients]
ON [dbo].[Consult___Patient]
    ([cp_patid]);
GO

-- Creating foreign key on [cons_type] in table 'Consultation'
ALTER TABLE [dbo].[Consultation]
ADD CONSTRAINT [FK_Consultation_ConsultationType]
    FOREIGN KEY ([cons_type])
    REFERENCES [dbo].[ConsultationType]
        ([ct_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Consultation_ConsultationType'
CREATE INDEX [IX_FK_Consultation_ConsultationType]
ON [dbo].[Consultation]
    ([cons_type]);
GO

-- Creating foreign key on [p_destructionId] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [FK_Patients_Destruction]
    FOREIGN KEY ([p_destructionId])
    REFERENCES [dbo].[Destruction]
        ([destr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Patients_Destruction'
CREATE INDEX [IX_FK_Patients_Destruction]
ON [dbo].[Patients]
    ([p_destructionId]);
GO

-- Creating foreign key on [p_diagnosisId] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [FK_Patients_Diagnosis]
    FOREIGN KEY ([p_diagnosisId])
    REFERENCES [dbo].[Diagnosis]
        ([diag_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Patients_Diagnosis'
CREATE INDEX [IX_FK_Patients_Diagnosis]
ON [dbo].[Patients]
    ([p_diagnosisId]);
GO

-- Creating foreign key on [p_genderId] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [FK_Patients_Gender]
    FOREIGN KEY ([p_genderId])
    REFERENCES [dbo].[Gender]
        ([gen_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Patients_Gender'
CREATE INDEX [IX_FK_Patients_Gender]
ON [dbo].[Patients]
    ([p_genderId]);
GO

-- Creating foreign key on [htp_testid] in table 'HepTest___Patient'
ALTER TABLE [dbo].[HepTest___Patient]
ADD CONSTRAINT [FK_HepTest___Patient_HepaticTest]
    FOREIGN KEY ([htp_testid])
    REFERENCES [dbo].[HepaticTest]
        ([heptest_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HepTest___Patient_HepaticTest'
CREATE INDEX [IX_FK_HepTest___Patient_HepaticTest]
ON [dbo].[HepTest___Patient]
    ([htp_testid]);
GO

-- Creating foreign key on [htp_patid] in table 'HepTest___Patient'
ALTER TABLE [dbo].[HepTest___Patient]
ADD CONSTRAINT [FK_HepTest___Patient_Patients]
    FOREIGN KEY ([htp_patid])
    REFERENCES [dbo].[Patients]
        ([p_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HepTest___Patient_Patients'
CREATE INDEX [IX_FK_HepTest___Patient_Patients]
ON [dbo].[HepTest___Patient]
    ([htp_patid]);
GO

-- Creating foreign key on [htp_state] in table 'HepTest___Patient'
ALTER TABLE [dbo].[HepTest___Patient]
ADD CONSTRAINT [FK_HepTest___Patient_State]
    FOREIGN KEY ([htp_state])
    REFERENCES [dbo].[State]
        ([state_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HepTest___Patient_State'
CREATE INDEX [IX_FK_HepTest___Patient_State]
ON [dbo].[HepTest___Patient]
    ([htp_state]);
GO

-- Creating foreign key on [p_typeId] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [FK_Patients_Type]
    FOREIGN KEY ([p_typeId])
    REFERENCES [dbo].[Type]
        ([type_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Patients_Type'
CREATE INDEX [IX_FK_Patients_Type]
ON [dbo].[Patients]
    ([p_typeId]);
GO

-- Creating foreign key on [sptp_patid] in table 'SputumTest___Patient'
ALTER TABLE [dbo].[SputumTest___Patient]
ADD CONSTRAINT [FK_SputumTest___Patient_Patients]
    FOREIGN KEY ([sptp_patid])
    REFERENCES [dbo].[Patients]
        ([p_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SputumTest___Patient_Patients'
CREATE INDEX [IX_FK_SputumTest___Patient_Patients]
ON [dbo].[SputumTest___Patient]
    ([sptp_patid]);
GO

-- Creating foreign key on [utp_patid] in table 'UrTest__Patient'
ALTER TABLE [dbo].[UrTest__Patient]
ADD CONSTRAINT [FK_UrTest__Patient_Patients]
    FOREIGN KEY ([utp_patid])
    REFERENCES [dbo].[Patients]
        ([p_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UrTest__Patient_Patients'
CREATE INDEX [IX_FK_UrTest__Patient_Patients]
ON [dbo].[UrTest__Patient]
    ([utp_patid]);
GO

-- Creating foreign key on [sptp_testid] in table 'SputumTest___Patient'
ALTER TABLE [dbo].[SputumTest___Patient]
ADD CONSTRAINT [FK_SputumTest___Patient_SputumTest]
    FOREIGN KEY ([sptp_testid])
    REFERENCES [dbo].[SputumTest]
        ([sputtest_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SputumTest___Patient_SputumTest'
CREATE INDEX [IX_FK_SputumTest___Patient_SputumTest]
ON [dbo].[SputumTest___Patient]
    ([sptp_testid]);
GO

-- Creating foreign key on [sptp_state] in table 'SputumTest___Patient'
ALTER TABLE [dbo].[SputumTest___Patient]
ADD CONSTRAINT [FK_SputumTest___Patient_State]
    FOREIGN KEY ([sptp_state])
    REFERENCES [dbo].[State]
        ([state_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SputumTest___Patient_State'
CREATE INDEX [IX_FK_SputumTest___Patient_State]
ON [dbo].[SputumTest___Patient]
    ([sptp_state]);
GO

-- Creating foreign key on [utp_state] in table 'UrTest__Patient'
ALTER TABLE [dbo].[UrTest__Patient]
ADD CONSTRAINT [FK_UrTest__Patient_State]
    FOREIGN KEY ([utp_state])
    REFERENCES [dbo].[State]
        ([state_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UrTest__Patient_State'
CREATE INDEX [IX_FK_UrTest__Patient_State]
ON [dbo].[UrTest__Patient]
    ([utp_state]);
GO

-- Creating foreign key on [utp_testid] in table 'UrTest__Patient'
ALTER TABLE [dbo].[UrTest__Patient]
ADD CONSTRAINT [FK_UrTest__Patient_UrineTest]
    FOREIGN KEY ([utp_testid])
    REFERENCES [dbo].[UrineTest]
        ([urtest_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UrTest__Patient_UrineTest'
CREATE INDEX [IX_FK_UrTest__Patient_UrineTest]
ON [dbo].[UrTest__Patient]
    ([utp_testid]);
GO

-- Creating foreign key on [cp_consid] in table 'Consult___Patient'
ALTER TABLE [dbo].[Consult___Patient]
ADD CONSTRAINT [FK_Consult___Patient_Consultation]
    FOREIGN KEY ([cp_consid])
    REFERENCES [dbo].[Consultation]
        ([cons_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Consult___Patient_Consultation'
CREATE INDEX [IX_FK_Consult___Patient_Consultation]
ON [dbo].[Consult___Patient]
    ([cp_consid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------