CREATE TABLE [dbo].[Appointment] (
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    [id_contact]      INT          NULL,
    [meetingSubject]  VARCHAR (50) NULL,
    [isRemoteMeeting] BIT          NULL,
    [meetingPlace]    VARCHAR (50) NULL,
    [meetingDate]     DATETIME     NULL,
    [startTime]       DATETIME     NULL,
    [endTime]         DATETIME     NULL,
    CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Appointment_Contact] FOREIGN KEY ([id_contact]) REFERENCES [dbo].[Contact] ([Id])
);

