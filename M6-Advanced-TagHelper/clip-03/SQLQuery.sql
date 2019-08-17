CREATE TABLE[dbo].[SQLCache](    
  [Id]
  [nvarchar](449) NOT NULL,
  [Value][varbinary](max) NOT NULL,
  [ExpiresAtTime][datetimeoffset](7) NOT NULL,
  [SlidingExpirationInSeconds][bigint]
  NULL,   
  [AbsoluteExpiration]
  [datetimeoffset](7) NULL,   
  CONSTRAINT[pk_Id] PRIMARY KEY 
    CLUSTERED([Id] ASC) WITH(PAD_INDEX = OFF, 
	STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, 
	ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
  ON[PRIMARY]) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
