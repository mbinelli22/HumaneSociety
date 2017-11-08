CREATE TABLE [dbo].[MyHumaneSocietyInventory] (
    [Animal_Id]                INT          IDENTITY (1, 1) NOT NULL,
    [Animal_Name]              VARCHAR (50) NULL,
    [Animal_Types]             VARCHAR (50) NOT NULL,
    [Animal_Breed]             VARCHAR (50) NULL,
    [Animal_Gender]            VARCHAR (50) NOT NULL,
    [Animal_Age]               INT          NULL,
    [Animal_Weight_Pounds]     INT          NULL,
    [Room_Number]              INT          NULL,
    [Vacination_Status]        VARCHAR (50) NULL,
    [Food_Type]                VARCHAR (50) NULL,
    [Food_Amount_Cups_Per_Day] FLOAT (53)   NULL,
    [Adoption_Status]          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Animal_Id] ASC)
);

