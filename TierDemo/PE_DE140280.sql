USE [DB_DE140280]
GO
/****** Object:  Table [dbo].[Employee_DE140280]    Script Date: 3/18/2021 10:36:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_DE140280](
	[Employee_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Gender] [nvarchar](15) NULL,
 CONSTRAINT [PK_Employee_DE140280] PRIMARY KEY CLUSTERED 
(
	[Employee_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee_DE140280] ON 

INSERT [dbo].[Employee_DE140280] ([Employee_Id], [Name], [Department], [Address], [Gender]) VALUES (1, N'Lê Anh Tuấn', N'VN', N'1212', N'Nữ')
INSERT [dbo].[Employee_DE140280] ([Employee_Id], [Name], [Department], [Address], [Gender]) VALUES (2, N'Linh', N'HN', N'Dong Hoi', N'Nữ')
INSERT [dbo].[Employee_DE140280] ([Employee_Id], [Name], [Department], [Address], [Gender]) VALUES (3, N'Tuấn', N'3213123', N'3213213', N'Nam')
INSERT [dbo].[Employee_DE140280] ([Employee_Id], [Name], [Department], [Address], [Gender]) VALUES (7, N'Lê Anh Tuấn', N'VN', N'1212', N'Nữ')
INSERT [dbo].[Employee_DE140280] ([Employee_Id], [Name], [Department], [Address], [Gender]) VALUES (8, N'Lê Anh ', N'VN', N'FPT', N'Nữ')
INSERT [dbo].[Employee_DE140280] ([Employee_Id], [Name], [Department], [Address], [Gender]) VALUES (9, N'Phước Linh', N'HN', N'Hà Nội', N'Nữ')
SET IDENTITY_INSERT [dbo].[Employee_DE140280] OFF
GO
