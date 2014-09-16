/*Saravanan N - 3rd July, 2014 - Newly added to maintain efile_returndata stages during TRANSMIT. */

CREATE TABLE [dbo].[efile_stage]
(
	[efile_stage_Id] INT IDENTITY(1,1) NOT NULL,
    [stage_description] [varchar](50) NOT NULL,
    [is_deleted] BIT NOT NULL DEFAULT 0,
    [create_datetime] DATETIME NOT NULL DEFAULT GetDate(), 
    [update_datetime] DATETIME NOT NULL DEFAULT GetDate(), 
    CONSTRAINT [pk_efile_stage] PRIMARY KEY ([efile_stage_Id])
)

GO
