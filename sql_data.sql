USE [master]
GO
/****** Object:  Database [CinemaTickets]    Script Date: 2020/7/27 15:50:01 ******/
CREATE DATABASE [CinemaTickets]
GO
ALTER DATABASE [CinemaTickets] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CinemaTickets].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CinemaTickets] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CinemaTickets] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CinemaTickets] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CinemaTickets] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CinemaTickets] SET ARITHABORT OFF 
GO
ALTER DATABASE [CinemaTickets] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CinemaTickets] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CinemaTickets] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CinemaTickets] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CinemaTickets] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CinemaTickets] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CinemaTickets] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CinemaTickets] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CinemaTickets] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CinemaTickets] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CinemaTickets] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CinemaTickets] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CinemaTickets] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CinemaTickets] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CinemaTickets] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CinemaTickets] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CinemaTickets] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CinemaTickets] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CinemaTickets] SET RECOVERY FULL 
GO
ALTER DATABASE [CinemaTickets] SET  MULTI_USER 
GO
ALTER DATABASE [CinemaTickets] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CinemaTickets] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CinemaTickets] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CinemaTickets] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [CinemaTickets]
GO
/****** Object:  Table [dbo].[Movieaddtime]    Script Date: 2020/7/27 15:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movieaddtime](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[addtime] [datetime] NULL,
	[MovieId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MovieInfo]    Script Date: 2020/7/27 15:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieInfo](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [nvarchar](30) NOT NULL,
	[Director] [nvarchar](30) NOT NULL,
	[ToStar] [nvarchar](100) NOT NULL,
	[MovieType] [nvarchar](30) NOT NULL,
	[MovieImage] [nvarchar](100) NOT NULL,
	[Introduce] [nvarchar](500) NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 2020/7/27 15:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfo](
	[orderId] [int] IDENTITY(1,1) NOT NULL,
	[MovieId] [int] NULL,
	[UserId] [int] NULL,
	[addTime] [datetime] NOT NULL,
	[addMoney] [float] NOT NULL,
	[addNumber] [int] NOT NULL,
	[Seat] [nvarchar](10) NOT NULL,
	[MovieUptime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Seat]    Script Date: 2020/7/27 15:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[showId] [int] NULL,
	[seatId] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ShowMovie]    Script Date: 2020/7/27 15:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShowMovie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MovieId] [int] NULL,
	[upshow] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2020/7/27 15:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[zhName] [varchar](30) NOT NULL,
	[UserName] [varchar](30) NOT NULL,
	[Pwd] [varchar](30) NOT NULL,
	[Birthday] [datetime] NOT NULL,
	[Bank] [nvarchar](20) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Admin] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Movieaddtime] ON 

INSERT [dbo].[Movieaddtime] ([id], [addtime], [MovieId]) VALUES (1, CAST(0x0000AC3700000000 AS DateTime), 10)
INSERT [dbo].[Movieaddtime] ([id], [addtime], [MovieId]) VALUES (2, CAST(0x0000AC5500000000 AS DateTime), 11)
INSERT [dbo].[Movieaddtime] ([id], [addtime], [MovieId]) VALUES (3, CAST(0x0000AC0800000000 AS DateTime), 12)
INSERT [dbo].[Movieaddtime] ([id], [addtime], [MovieId]) VALUES (4, CAST(0x0000AC0600000000 AS DateTime), 13)
INSERT [dbo].[Movieaddtime] ([id], [addtime], [MovieId]) VALUES (5, CAST(0x0000ABCB00000000 AS DateTime), 5)
INSERT [dbo].[Movieaddtime] ([id], [addtime], [MovieId]) VALUES (6, CAST(0x0000AB6900000000 AS DateTime), 6)
INSERT [dbo].[Movieaddtime] ([id], [addtime], [MovieId]) VALUES (7, CAST(0x0000ABFF00000000 AS DateTime), 7)
INSERT [dbo].[Movieaddtime] ([id], [addtime], [MovieId]) VALUES (8, CAST(0x0000ABDB00000000 AS DateTime), 8)
SET IDENTITY_INSERT [dbo].[Movieaddtime] OFF
SET IDENTITY_INSERT [dbo].[MovieInfo] ON 

INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (5, N'灰猎犬号', N'汤姆·汉克斯 / C·S·福里斯特', N'汤姆·汉克斯 / 斯蒂芬·格拉汉姆 / 伊丽莎白·苏 / 迈克尔·本茨 / 罗布·摩根', N'剧情 / 战争', N'D:\电影\ia_100000014.jpg', N'影片讲述二战初期，由37支盟军船只组成的护航舰队在欧内斯特·克劳斯（汤姆·汉克斯饰）舰长率领的一艘美国驱逐舰指挥下，穿越险恶的北大西洋，同时还要与德国U型潜艇狼群的周旋', 69)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (6, N'清白', N'朴相铉', N'申惠善 / 裴宗玉 / 许峻豪 / 洪京 / 太恒浩 ', N'剧情', N'D:\电影\清白.jpg', N'从小因父亲重男轻女，贞仁（申惠善 饰演）在中学时就逃家自力更生，与家人断了联系。贞仁后来凭一己之力成为顶级辩护律师，在一次偶然中，她得知罹患老年痴呆症的母亲花子（裴宗玉 饰演）涉嫌杀害父亲，同时还对不少无辜民众下毒手。 怀疑事有蹊翘的贞仁决定亲自出马，在层层阻挠下，她该如何为母亲翻供，揭开这个桩谋杀案背后不可告人的真相？', 39)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (7, N'永生守卫', N'吉娜·普林斯-拜斯伍德', N'查理兹·塞隆 / 琪琪·莱恩 / 马提亚斯·修奈尔 / 马尔万·肯扎里 / 卢卡·马里内利 /', N'动作 / 奇幻', N'D:\电影\永生守卫.jpg', N'一个名叫安迪（查理兹·塞隆饰）的战士领导了一个关系紧密的秘密雇佣兵团体，他们具有神秘的不死之身，为了保护凡人世界而战斗了几个世纪。但团队在受雇执行紧急任务时突然暴露了他们不寻常的能力，他们要依靠安迪和新加入的士兵奈尔（琪琪·莱恩饰），帮助团队消除那些不择手段要复制他们的能力并从中获利的人所带来的威胁。', 49)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (8, N'真心半解', N'伍思薇', N'莉娅·刘易斯 / 丹尼尔·迪默 / 艾丽克西斯·勒梅尔 / 沃尔夫冈·诺沃格拉茨 / 邹兆龙', N'喜剧 / 爱情 / 同性', N'D:\电影\ia_100000017.jpg', N'个性体贴的运动健将保罗爱上了学校校花，但他实在不善言辞，于是决定僱用内向的高材生艾莉帮他展开追求，毫不相干的两人也因此成为朋友。然而，艾莉发现自己竟然也对校花产生好感，她和保罗的友谊因此变得複杂。本片为编剧兼导演伍思薇的最新力作。', 39)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (10, N'少年的你', N'郑国兴', N' 周冬雨 / 易烊千玺 / 尹昉 / 周也 ', N'剧情 / 爱情 / 犯罪', N'D:\电影\少年的你.png', N'陈念（周冬雨 饰）是一名即将参加高考的高三学生，同校女生胡晓蝶（张艺凡 饰）的跳楼自杀让她的生活陷入了困顿之中。胡晓蝶死后，陈念遭到了以魏莱（周也 饰）为首的三人组的霸凌，魏莱虽然表面上看来是乖巧的优等生，实际上却心思毒辣，胡晓蝶的死和她有着千丝万缕的联系。
　　一次偶然中，陈念邂逅了名为小北（易烊千玺 饰）的小混混，随着时间的推移，心心相惜的两人之间产生了真挚的感情。小北答应陈念在暗中保护她免受魏莱的欺凌，没想到这一决定引发了一连串的连锁反应。负责调查胡晓蝶死因的警官郑易（尹昉 饰）隐隐察觉到校园里的古怪气氛，可他的调查却屡屡遭到校方的阻挠', 39)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (11, N'多哥', N'埃里克松·科尔', N' 威廉·达福 / 朱丽安妮·尼科尔森 / 克里斯托弗·赫耶达尔 ', N'剧情 / 冒险', N'D:\电影\多哥.png', N'聚焦1925年雪橇手和雪橇犬齐心协力为拯救阿拉斯加州诺姆市孩子的性命而奔波于血清接力路上的事件，被称为“Great Race of Mercy”。本片将登陆迪士尼自家流媒体，2019年推出。
　　1924年年底，诺姆市一个2岁小孩生病，医生诊断其患有扁桃体炎，这种疾病通常不会有生命危险，然而这个小孩成为例外，接下来很多孩子都被诊断患上了扁桃体炎，有几个不幸离世，医生最终确认这种病症是白喉。当时有一种疫苗能够用来对付白喉，然后诺姆市的疫苗全部过期，新疫苗在港口关闭前却未能送达，来年6月波罗的海才会解冻，也没有公路直通诺姆市、没有飞机，唯一运输货物的通道是邮路，然而冬天只有雪橇犬能够通行。卫生局决定使用两组雪橇犬接力运输，20个雪橇手和150只雪橇犬必须日夜兼程', 49)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (12, N'阳光普照', N'钟孟宏', N'陈以文 / 柯淑勤 / 巫建和 / 刘冠廷 / 许光汉 ', N'剧情 / 家庭 / 犯罪', N'D:\电影\阳光普照.png', N'平凡的一家人阿文（陈以文 饰）和琴姐（柯淑勤 饰）育有两个儿子，叛逆的小儿子阿和（巫建和 饰）与好友菜头（刘冠廷 饰）砍伤人进了少年辅育院，但阿和的女友小玉（吴岱凌 饰）却带着身孕来家里…琴姐不顾阿文反对，将小玉留下来照顾。此时，被砍伤者家属也来找阿文求取巨额赔偿，阿文受不了总是带来麻烦的小儿子，将所有希望都寄托在资优生大儿子阿豪（许光汉 饰）身上，却不知道温暖善良的阿豪心中也藏着不为人知的秘密…', 69)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (13, N'遗落家庭', N'娜塔莉·埃丽卡·詹姆斯', N'艾米莉·莫迪默 / 贝拉·希思科特 / 罗宾·奈文 / 克里斯·邦顿', N'恐怖', N'D:\电影\遗落家庭.png', N'独居老人艾德娜失踪了，她的女儿凯伊和孙女小珊在接获警方通报后，急忙从墨尔本赶回乡间的祖厝。警方和当地居民组织了搜索队在树林裡展开搜寻，不料，艾德娜却突然自行返家，原以为只是阿兹海默症病况加剧，艾德娜完全记不起这些天到底去了哪裡或是经历过什麽事。平安返家的艾德娜却好像变了一个人，她的行径越来越古怪，甚至变得危险，不仅艾德娜感觉到屋裡有股神秘的力量在操控著她，就连凯伊和孙女小珊也逐渐迷失，这个「家」变得越来越暴戾……', 49)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (15, N'前哨', N'罗德·拉里', N'埃瑞克·约翰逊 / 保罗·塔马西 / 杰克·塔伯', N'剧情 / 历史 / 战争', N'D:\电影\前哨.png', N'斯科特·伊斯特伍德、卡赖伯·兰德里·琼斯、奥兰多·布鲁姆将主演Millennium Media打造的阿富汗战争题材影片[前哨](The Outpost，暂译)。罗德·拉里执导影片，影片则根据CNN记者Jake Tapper著作改编。影片故事将围绕53名美国士兵的真实故事展开，这些士兵与阿富汗东北部约400名敌方武装分子拉开持久的作战。他们所建造的前哨基地位于巴基斯坦边境仅14英里处的三处陡峭山脉底部。基地则面临塔利班恐怖分子的袭击。而驻扎在那里的士兵则面临着巨大威胁。', 79)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (16, N'好久不见，武汉', N'竹内亮', N'无', N'纪录片', N'D:\电影\好久不见.png', N'“武汉太危险，最好你不要去”
　　“是不是现在还有很多隐瞒的感染者？”
　　我的日本朋友对武汉有很多偏见。我是作为住在中国的外国人，作为纪录片的导演，特别想去拍武汉，想给全世界介绍真实的武汉。于是我在微博上募集了可以接受我们拍摄的武汉人，然后一百多个人报名了，最后我们选择了十个人的故事。希望通过这部作品让更多的人了解现在的武汉', 39)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (17, N'翻译疑云', N'雷吉斯·罗因萨尔', N'朗贝尔·维尔森 / 欧嘉·柯瑞兰寇 / 里卡多·斯卡马乔', N'悬疑 / 惊悚', N'D:\电影\翻译疑云.png', N'知名畅销小说作家的遗作——他生前畅销小说的三部曲最后一集，即将发布。为了能在世界主要地区同时出版这本小说，出版商聘用了9名来自世界各地的翻译员，同时在现场翻译小说。他们被关进了一间豪华但守卫森严的套房，时刻在监视之下', 59)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (18, N'惊天营救', N'山姆·哈格雷夫', N' 克里斯·海姆斯沃斯 / 大卫·哈伯 / 格什菲·法拉哈尼', N'动作 / 惊悚 / 犯罪', N'D:\电影\惊天营救.png', N'泰勒·雷克（克里斯·海姆斯沃斯饰）是一名无所畏惧的黑市雇佣兵，一无所有的他奉命营救入狱的黑帮大佬被绑架的儿子。但是在充斥着武器交易商和毒贩的阴暗地下世界中，本就致命的任务更是难以完成，并彻底地改变了雷克和男孩的命运。', 54)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (19, N'你好世界', N'伊藤智彦', N'北村匠海 / 松坂桃李 / 滨边美波 / 子安武人 / 寿美菜子', N'剧情 / 爱情 / 科幻 / 动画', N'D:\电影\你好世界.png', N'在京都居住的内向男高中生直实（北村匠海 配音）的面前，突然出现从10年后穿越而来26岁的自己（松坂桃李 配音）。未来的直实告诉他，自己不久便会与琉璃（滨边美波 配音）相爱，可是之后烟花大会时她却会因为一场事故意外离世。
　　为了拯救爱人，16岁的直实卷入了这场现实与虚拟的记忆世界，经历了一系列超乎想象的事情。即使世界毁灭，我也想再见你一面。', 39)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (20, N'星球大战9：天行者崛起', N'J·J·艾布拉姆斯', N'黛西·雷德利 / 亚当·德赖弗 / 奥斯卡·伊萨克 / 约翰·博耶加 / 马克·哈米尔 ', N'动作 / 科幻 / 冒险', N'D:\电影\星球大战.png', N'本片为2017年电影《星球大战：最后的绝地武士》的续集，“星球大战后传三部曲”的第三部作品，同时是“天行者传奇”的第九部作品以及最终章。在卢克·天行者化为绝地英灵的一年后，残存的抵抗势力将再次面对第一秩序。同时，绝地和西斯之间的大战将天行者的传奇带到最后。', 69)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (21, N'知晓天空之蓝的人啊', N'长井龙雪', N' 吉泽亮 / 吉冈里帆 / 若山诗音 / 松平健', N'动画', N'D:\电影\知晓天空之蓝的人.png', N'故事讲述了被群山环绕的小城中，以音乐家为梦想的高二生“相生蓝”与姐姐“相生茜”以及茜的前男友不出名的吉他演奏家“金室慎之介”和从13年前穿越时空来到现在的18岁时的慎之介“しんの”之间不可思议的四角关系。13年前由于父母因事故丧生，姐姐茜放弃了与慎之介一同去东京，亲自抚养妹妹，而蓝一直因为这件事对姐姐抱有愧疚。在小城的音乐节上，被邀请参与的著名歌手的伴奏音乐家竟然就是多年来没有音信的慎之介。而同时在蓝的面前出现的“しんの”又吸引了她的爱慕……', 49)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (22, N'鬼影特攻：以暴制暴', N'迈克尔·贝', N' 瑞恩·雷诺兹 / 本·哈迪 / 梅拉尼·罗兰 / 阿德里娅·阿霍纳 / 戴夫·弗兰科 ', N'动作 / 惊悚', N'D:\电影\鬼影特工.png', N'　来自世界各地的六人，个个都是各自领域的佼佼者。他们之所以被选中，不单是因为能力出众，还在于其独特的志向：他们想抹杀自己的过去以改变未来。一位神秘的领袖（瑞恩·雷诺兹饰）将他们召集到一起组成了这个团队，他毕生唯一的使命就是确保即使他和自己的同伴会被遗忘，但也要让人们永远铭记他们所做的一切。', 29)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (23, N'叶问4：完结篇', N'叶伟信', N' 甄子丹 / 吴樾 / 吴建豪 / 斯科特·阿金斯 / 李宛妲', N'剧情 / 动作 / 功夫', N'D:\电影\叶问4.png', N'因故来到美国唐人街的叶问，意外卷入一场当地军方势力与华人武馆的纠纷，面对日益猖狂的民族歧视与压迫，叶问挺身而出，在美国海军陆战队军营拼死一战，以正宗咏春，向世界证明了中国功夫。', 28)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (24, N'影', N'张艺谋', N' 邓超 / 孙俪 / 郑恺 / 王千源 / 王景春 ', N'剧情 / 动作 / 功夫', N'D:\电影\影.png', N'　战乱年代，群雄并起。割据一方的沛国安于现状，一任国主沛良（郑恺 饰）慨歌太平。要冲之地境州早年为强邻炎国借去，而今据而不还。沛国都督子虞（邓超 饰）前往讨伐，却中了对方大将杨苍（胡军 饰）的拖刀，重伤不愈。心有不甘的子虞暗中派出替身境州（邓超 饰）假扮自己，总理军政，内则使令夫人小艾（孙俪 饰）襄助。真假子虞切磋战法，寻求破解杨苍刀法的绝技', 56)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (25, N'流浪地球', N'郭帆', N' 屈楚萧 / 吴京 / 李光洁 / 吴孟达 / 赵今麦 ', N'科幻 / 冒险 / 灾难', N'D:\电影\流浪地球.png', N'近未来，科学家们发现太阳急速衰老膨胀，短时间内包括地球在内的整个太阳系都将被太阳所吞没。为了自救，人类提出一个名为“流浪地球”的大胆计划，即倾全球之力在地球表面建造上万座发动机和转向发动机，推动地球离开太阳系，用2500年的时间奔往另外一个栖息之地。中国航天员刘培强（吴京 饰）在儿子刘启四岁那年前往国际空间站，和国际同侪肩负起领航者的重任', 52)
INSERT [dbo].[MovieInfo] ([MovieID], [MovieName], [Director], [ToStar], [MovieType], [MovieImage], [Introduce], [Price]) VALUES (26, N'复仇者联盟4：终局之战', N'安东尼·罗素 / 乔·罗素', N'小罗伯特·唐尼 / 克里斯·埃文斯 / 马克·鲁弗洛 / 克里斯·海姆斯沃斯 / 斯嘉丽·约翰逊 ', N'剧情 / 动作 / 科幻 / 奇幻 / 冒险', N'D:\电影\复仇者联盟4.png', N'　一声响指，宇宙间半数生命灰飞烟灭。几近绝望的复仇者们在惊奇队长（布丽·拉尔森 Brie Larson 饰）的帮助下找到灭霸（乔什·布洛林 Josh Brolin 饰）归隐之处，却得知六颗无限宝石均被销毁，希望彻底破灭。如是过了五年，迷失在量子领域的蚁人（保罗·路德 Paul Rudd 饰）意外回到现实世界，他的出现为幸存的复仇者们点燃了希望。', 45)
SET IDENTITY_INSERT [dbo].[MovieInfo] OFF
SET IDENTITY_INSERT [dbo].[OrderInfo] ON 

INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (3, 5, 1, CAST(0x0000ABB400CE3ED4 AS DateTime), 59, 1, N'2-5', CAST(0x0000000000D63BC0 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (4, 5, 1, CAST(0x0000ABB400CB7FB4 AS DateTime), 59, 1, N'2-1', CAST(0x0000000000D63BC0 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (5, 5, 1, CAST(0x0000ABB400C8C094 AS DateTime), 59, 1, N'2-2', CAST(0x0000000000D63BC0 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (6, 5, 1, CAST(0x0000ABB400D0FDF4 AS DateTime), 59, 1, N'2-3', CAST(0x0000000000D63BC0 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (7, 7, 1, CAST(0x0000ABB000C8C094 AS DateTime), 49, 1, N'1-5', CAST(0x0000000000F73140 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (8, 7, 1, CAST(0x0000ABB000CB7FB4 AS DateTime), 49, 1, N'1-2', CAST(0x0000000000F73140 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (9, 7, 1, CAST(0x0000ABB000D0FDF4 AS DateTime), 49, 1, N'1-3', CAST(0x0000000000F73140 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (11, 5, 1, CAST(0x0000ABFE00000000 AS DateTime), 69, 1, N'1-1', CAST(0x0000AC0400E6B680 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (14, 7, 1, CAST(0x0000AC0300000000 AS DateTime), 49, 1, N'2-2', CAST(0x0000AC0400E6B680 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (15, 7, 1, CAST(0x0000AC0300000000 AS DateTime), 49, 1, N'1-1', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (16, 7, 1, CAST(0x0000AC0300000000 AS DateTime), 49, 1, N'3-1', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (17, 7, 1, CAST(0x0000AC0300000000 AS DateTime), 49, 1, N'3-3', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (18, 6, 1, CAST(0x0000ABE000000000 AS DateTime), 39, 1, N'2-1', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (19, 6, 1, CAST(0x0000ABE000000000 AS DateTime), 39, 1, N'3-3', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (20, 6, 1, CAST(0x0000ABE000000000 AS DateTime), 39, 1, N'2-4', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (21, 6, 1, CAST(0x0000ABE000000000 AS DateTime), 39, 1, N'4-4', CAST(0x0000AC04008C1360 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (22, 6, 1, CAST(0x0000ABE000000000 AS DateTime), 39, 1, N'', CAST(0x0000AC23008C1360 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (23, 6, 1, CAST(0x0000ABE000000000 AS DateTime), 39, 1, N'2-1', CAST(0x0000AC23008C1360 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (24, 7, 1, CAST(0x0000AC0300000000 AS DateTime), 49, 1, N'3-3', CAST(0x0000AC42008C1360 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (25, 7, 1, CAST(0x0000AC0401176FF0 AS DateTime), 49, 1, N'4-1', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (26, 7, 1, CAST(0x0000AC0401177374 AS DateTime), 49, 1, N'4-1', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (27, 7, 1, CAST(0x0000AC040117AE0C AS DateTime), 49, 1, N'4-3', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (28, 7, 1, CAST(0x0000AC040117B064 AS DateTime), 49, 1, N'', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (29, 7, 1, CAST(0x0000AC040117DF44 AS DateTime), 49, 1, N'2-3', CAST(0x0000AC0401391C40 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (30, 5, 1, CAST(0x0000AC0401248E88 AS DateTime), 69, 1, N'4-3', CAST(0x0000ABFE00000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (31, 5, 1, CAST(0x0000AC04012496BC AS DateTime), 69, 1, N'1-1', CAST(0x0000ABF900C5C100 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (32, 7, 1, CAST(0x0000AC0401272CD8 AS DateTime), 49, 1, N'4-4', CAST(0x0000AC0300000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (33, 8, 1, CAST(0x0000AC04012AF14C AS DateTime), 39, 1, N'4-3', CAST(0x0000ABB700000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (34, 8, 1, CAST(0x0000AC04012AF278 AS DateTime), 39, 1, N'4-5', CAST(0x0000ABB700000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (35, 8, 1, CAST(0x0000AC04012AF4D0 AS DateTime), 39, 1, N'2-4', CAST(0x0000ABB700000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (36, 8, 1, CAST(0x0000AC04012AF5FC AS DateTime), 39, 1, N'2-2', CAST(0x0000ABB700000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (37, 8, 1, CAST(0x0000AC04012AF854 AS DateTime), 39, 1, N'1-1', CAST(0x0000ABB700000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (38, 8, 1, CAST(0x0000AC04012AFAAC AS DateTime), 39, 1, N'4-1', CAST(0x0000ABB700000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (39, 8, 1, CAST(0x0000AC04012AFD04 AS DateTime), 39, 1, N'1-3', CAST(0x0000ABB700000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (40, 6, 1, CAST(0x0000AC04013B3AD4 AS DateTime), 39, 1, N'3-4', CAST(0x0000AC5500C5C100 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (41, 6, 1, CAST(0x0000AC040155AB94 AS DateTime), 39, 1, N'2-2', CAST(0x0000AC5500C5C100 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (42, 5, 1, CAST(0x0000AC05000493E0 AS DateTime), 69, 1, N'1-1', CAST(0x0000ABFE00000000 AS DateTime))
INSERT [dbo].[OrderInfo] ([orderId], [MovieId], [UserId], [addTime], [addMoney], [addNumber], [Seat], [MovieUptime]) VALUES (43, 7, 1, CAST(0x0000AC0500B9EF38 AS DateTime), 49, 1, N'3-3', CAST(0x0000AC0700E6B680 AS DateTime))
SET IDENTITY_INSERT [dbo].[OrderInfo] OFF
SET IDENTITY_INSERT [dbo].[ShowMovie] ON 

INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (1, 5, CAST(0x0000ABFE00000000 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (2, 6, CAST(0x0000ABE000000000 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (3, 7, CAST(0x0000AC0300000000 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (4, 8, CAST(0x0000ABB700000000 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (5, 5, CAST(0x0000ABF900C5C100 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (6, 5, CAST(0x0000AC3700C5C100 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (7, 6, CAST(0x0000AC5500C5C100 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (8, 7, CAST(0x0000AC7400C5C100 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (9, 8, CAST(0x0000AC0800C5C100 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (10, 8, CAST(0x0000AC6400C5C100 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (11, 7, CAST(0x0000AC0700E6B680 AS DateTime))
INSERT [dbo].[ShowMovie] ([id], [MovieId], [upshow]) VALUES (13, 13, CAST(0x0000AC050107AC00 AS DateTime))
SET IDENTITY_INSERT [dbo].[ShowMovie] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [zhName], [UserName], [Pwd], [Birthday], [Bank], [Phone], [Admin]) VALUES (1, N'第一主打', N'8848', N'123456', CAST(0x00008F7000C5DE4C AS DateTime), N'784544656184', N'1111111111111', 0)
INSERT [dbo].[Users] ([ID], [zhName], [UserName], [Pwd], [Birthday], [Bank], [Phone], [Admin]) VALUES (2, N'云之彼端', N'yezhh', N'123456', CAST(0x00008F7000C5DE4C AS DateTime), N'784544656184', N'1111111111111', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Users__C9F2845613FEFD8C]    Script Date: 2020/7/27 15:50:02 ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderInfo] ADD  DEFAULT (getdate()) FOR [addTime]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [Admin]
GO
ALTER TABLE [dbo].[Movieaddtime]  WITH CHECK ADD FOREIGN KEY([MovieId])
REFERENCES [dbo].[MovieInfo] ([MovieID])
GO
ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD FOREIGN KEY([MovieId])
REFERENCES [dbo].[MovieInfo] ([MovieID])
GO
ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Seat]  WITH CHECK ADD FOREIGN KEY([showId])
REFERENCES [dbo].[ShowMovie] ([id])
GO
ALTER TABLE [dbo].[ShowMovie]  WITH CHECK ADD FOREIGN KEY([MovieId])
REFERENCES [dbo].[MovieInfo] ([MovieID])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Admin]=(0) OR [Admin]=(1)))
GO
USE [master]
GO
ALTER DATABASE [CinemaTickets] SET  READ_WRITE 
GO
