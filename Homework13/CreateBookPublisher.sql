CREATE TABLE [Publisher](
    [PublisherId] [int] NOT NULL,
    [Name] [varchar](50) NULL,
    CONSTRAINT [pk_publisher] PRIMARY KEY CLUSTERED
    (
        [PublisherId] ASC
    ) WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF)
)

CREATE TABLE [Book](
       [BookId] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
       [Title] [varchar](50) NULL,
       [PublisherId] [int] NULL,
       [Year] [int] NULL,
       [Price] [decimal](18, 0) NULL
       )
GO
ALTER TABLE [Book]  WITH CHECK ADD  CONSTRAINT [fk_book_publisherid] FOREIGN KEY([PublisherId])
REFERENCES [Publisher] ([PublisherId])
ON DELETE CASCADE
GO
ALTER TABLE [Book] CHECK CONSTRAINT [fk_book_publisherid]
GO