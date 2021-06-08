﻿CREATE TABLE [dbo].[Clans] (
    [Id] [int] NOT NULL IDENTITY,
    [ClanName] [nvarchar](max),
    CONSTRAINT [PK_dbo.Clans] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Ninjas] (
    [Id] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [ServedInOniwaban] [bit] NOT NULL,
    [ClanId] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Ninjas] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_ClanId] ON [dbo].[Ninjas]([ClanId])
CREATE TABLE [dbo].[NinjaEquipments] (
    [Id] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [Type] [int] NOT NULL,
    [Ninja_Id] [int] NOT NULL,
    CONSTRAINT [PK_dbo.NinjaEquipments] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_Ninja_Id] ON [dbo].[NinjaEquipments]([Ninja_Id])
ALTER TABLE [dbo].[Ninjas] ADD CONSTRAINT [FK_dbo.Ninjas_dbo.Clans_ClanId] FOREIGN KEY ([ClanId]) REFERENCES [dbo].[Clans] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[NinjaEquipments] ADD CONSTRAINT [FK_dbo.NinjaEquipments_dbo.Ninjas_Ninja_Id] FOREIGN KEY ([Ninja_Id]) REFERENCES [dbo].[Ninjas] ([Id]) ON DELETE CASCADE
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202106081407494_InitialMigration', N'NinjaDomain.DataModel.Migrations.Configuration',  0x1F8B0800000000000400ED5ACD6EE33610BE17E83B083AB54536CACFA50DEC5D649DA408BA8E177176DB5B404B63872D4569452A6BA3E893F5D047EA2B74A87F91A22D3B3F0D168B1C62539CE170E69BE1F093FFFDFB9FC19B65C89C7B48048DF8D03DDC3F701DE07E1450BE18BAA99CBFFAD17DF3FADB6F06E741B8743E96F38ED53C94E462E8DE49199F789EF0EF2024623FA47E1289682EF7FD28F44810794707073F7987871EA00A177539CEE03AE59286907DC1AFA388FB10CB94B071140013C5383E99665A9D2B128288890F43F78AF2DFC9591412CAF7CF88249984EB9C324AD09829B0B9EB10CE2349249A7AF241C05426115F4C631C20EC661503CE9B1326A0D8C2493DBDEF6E0E8ED46EBC5AB054E5A742A26DDB293C3C2EDCE3E9E23B39D9ADDC870E3C4747CB95DA75E6C4A13B6204D5EA0B9D8C58A226B5FD8B738500A1FEF33DA7E3C95E0509448EFADB734629936902430EA94C08DB73DEA73346FD5F607513FD017CC853C69A16A28DF8AC358043EF93288644AEAE615ED87D19B88ED796F374C14AAC2193EFEA92CBE323D7B9C2C5C98C4105808607A6324AE067E0901009C17B2225245CE980CC85C6EADA5ACA47EA53B922A20E73C875C664F90EF842DE0D5DFCE83A17740941395258F181534C391492490AC64257E49E2E321BB525B38008D7B906963D167734CE53603F7B749BC7FA2289C2EB889502D9E8ED0D491620D1D8C878348DD2C4D7CC18783590D6C22BD3B32DBEB2B1AF005B0FB0A70197B6C814927B082EF984D3CF64A6D0932FF8364294A8AFC6063767C56627F5057C8EE75DE05E62BA03EE6526F435E2FC534AE3106336F9CC21B09B53CDBB2D7242334C7BDE9D91FAA487E766A571A724ADA4BF66EB0BC856A5BE5A4401AF0A4FFE64E7442B10FB58D0EECC3E1BFEFB413B0D1BC0D6B67D292E1859D45DDE763857BA45DB938F0A760C7100095B21249A606C47660CE10C9232CC587C5DE72361297E3934A2D89AFB2B9058F58DC5ECA3F5B327A9FC0C24A9A61F9BEECF1DDD1C3C1522F269E6C9265CF2F2DB5EEC9C078EBD16D7B82D603446FFD1183D86211FBA3F18B677AAABEA66AD2E3F08DADA0E5DBDA84CF8193090E09CFA79AB3E22C227819926E885A03D82750812550808C3BB8BC060532ECDA245B94F63C2AC366B123D0B9DB2A8D2AD3F398318B8AA5156BFF759B43CB6CD852BFD9A8B367964E03560D3034D7A89590B046BBDD110D638FBB6849AF5B0DE80E1C7439DD581798544A74B747995D999356A10965D273D5E8B8B22288AA346DFBE523A05D90004DE34EA6ADCCA34C3776DE1F29E6248172EDB20DE885AB786C6044D55C3659A3945B3D89860B6927AE8D656B3CAEA7ABF46F6ACAD5F0D0585B77540B477D377A7C6616DD9F3DA8CEB9F738D6D58E3D23FBF367A758D57CAE6A14A8D9A56F2725EA9E49F3C0B0135189338C673BA41481523CE3467A346AFA6DB733461AEC3F345075553595BAD848D285980F61497464B2F6822A462C16644353AA32034A6B50A8125D1CAA59AB96E06AC4CBD72B6FADCC099CEC9ED77E550EDC10BDC940A78B63FD0C06F8A655C206124E9E8E947114B436E3F2EEDD23569D3D4518F9A9A069E66BF71421A8E32CA7ADBEBBD625280FFE141E9CCED1E51B1C83D4D58CC90D8C261D360F2184D6DE6D3ED20A3EFCED62EFD6F70A92BEF2321C6AAB02F74D62878A918CA2F934D0DF9C8F347B97DC4755406E38CDF2EA8A5D47691536778176F6039CB4DAFF58A7AAEA3FB32D2306047DBAC77A29D1169B74A6F55CC501B1D8B3EA5025AD5B9681DCAA0E81636BF4733DA877C8AEBA0EDF73450ADC374252484196AF6A79FD888D1AC972B278C09A7731032E736DCA383C323ED3DDCCB7927E60911B01E2FC69E9D89A4CAA31BB9C61D58F72601C9EF49E2DF91E4BB902CBF6F6A3349C62D5FF47C19FEDAD157FD5F9FCCA87CE0AB13DA49D85FF2009643F7CF4CE4C4B9FCED3697DA73260966E88973E0FCB561E15DDF1E7C8DBC958ACF2CDDD690EA98DB2EDEA5DC23447C275E37A7519E937BD598835D78E49DE85BCB75F66918DB2F91A57D4EB6740DC3F4205A7877E2FFD9A0B3EEAA66AEB8AEBD7E74147553D52691B5998BB652D179173B7483598481CE6B60379DDAC952DB49EA2EC5164AB253F3362CB675AD6A8EB9E85351DD4D6FD7FCDC4642D7A46E5F389FBDD9E0B535C57E6B7E12C2DABCE6615A367E5489A541D045AD42FDC49283DF4AC86ACE259F476565D02C2AA768DDCA182409305B4F1349E7C497F8D80721B25F3914AF92CFC359D609A7324E256E19C2196BFD6A42D59775EB67AC7CDBE6C124CE7E8EF0185B4033296E0126FC6D4A5950D97DD1D1305954A8C255F4A22A9652F5A48B55A5E92AE23D1515EEABEAED0D8431436562C2A7E41E76B1ED838077B020FEAABCADDB956C0E44DBED83334A16090945A1A396C7AF88E1205CBEFE0FAF5122025B2C0000 , N'6.4.4')

