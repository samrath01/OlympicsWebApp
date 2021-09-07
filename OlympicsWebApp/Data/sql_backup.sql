SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (1, N'United States of America')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (2, N'People''s Republic of China')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (3, N'Japan')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (4, N'Great Britain')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (5, N'ROC')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (6, N'Australia')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Medals] ON 
GO
INSERT [dbo].[Medals] ([Id], [GoldMedal], [BronzeMedal], [SilverMedal], [CountryID]) VALUES (1, 39, 41, 33, 1)
GO
INSERT [dbo].[Medals] ([Id], [GoldMedal], [BronzeMedal], [SilverMedal], [CountryID]) VALUES (2, 38, 32, 18, 2)
GO
INSERT [dbo].[Medals] ([Id], [GoldMedal], [BronzeMedal], [SilverMedal], [CountryID]) VALUES (3, 27, 14, 17, 3)
GO
INSERT [dbo].[Medals] ([Id], [GoldMedal], [BronzeMedal], [SilverMedal], [CountryID]) VALUES (4, 22, 21, 22, 4)
GO
INSERT [dbo].[Medals] ([Id], [GoldMedal], [BronzeMedal], [SilverMedal], [CountryID]) VALUES (5, 20, 28, 23, 5)
GO
INSERT [dbo].[Medals] ([Id], [GoldMedal], [BronzeMedal], [SilverMedal], [CountryID]) VALUES (6, 17, 7, 22, 6)
GO
SET IDENTITY_INSERT [dbo].[Medals] OFF
GO
SET IDENTITY_INSERT [dbo].[Disciplines] ON 
GO
INSERT [dbo].[Disciplines] ([Id], [DisciplineName]) VALUES (2, N'Volleyball')
GO
INSERT [dbo].[Disciplines] ([Id], [DisciplineName]) VALUES (3, N'Basketball')
GO
INSERT [dbo].[Disciplines] ([Id], [DisciplineName]) VALUES (4, N'Hockey')
GO
INSERT [dbo].[Disciplines] ([Id], [DisciplineName]) VALUES (5, N'Football')
GO
SET IDENTITY_INSERT [dbo].[Disciplines] OFF
GO
SET IDENTITY_INSERT [dbo].[Coaches] ON 
GO
INSERT [dbo].[Coaches] ([Id], [CoachName], [CountryID], [DisciplineID]) VALUES (1, N'Abdelmagid Wael', 4, 5)
GO
INSERT [dbo].[Coaches] ([Id], [CoachName], [CountryID], [DisciplineID]) VALUES (2, N'ABE Junya', 3, 2)
GO
INSERT [dbo].[Coaches] ([Id], [CoachName], [CountryID], [DisciplineID]) VALUES (3, N'ABE Katsuhiko', 3, 3)
GO
INSERT [dbo].[Coaches] ([Id], [CoachName], [CountryID], [DisciplineID]) VALUES (4, N'AGEBA Yuya', 1, 4)
GO
INSERT [dbo].[Coaches] ([Id], [CoachName], [CountryID], [DisciplineID]) VALUES (5, N'AL SAADI Kais', 1, 4)
GO
INSERT [dbo].[Coaches] ([Id], [CoachName], [CountryID], [DisciplineID]) VALUES (6, N'ADAMA Cherif', 4, 5)
GO
SET IDENTITY_INSERT [dbo].[Coaches] OFF
GO
