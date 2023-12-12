

using System.Numerics;
using System.Text.Json.Serialization;
using MemoryPack;
using PrismCatalogDownloader;

namespace PRISM.Definitions
{
    public enum AlbumType // TypeDefIndex: 24440
    {
        ProduceIdol = 0,
        SupportCharacter = 1
    }

    public static class AppReviewEnum // TypeDefIndex: 24434
    {
        // Nested types
        public enum ReViewType // TypeDefIndex: 24433
        {
            Gasha = 0
        }
    }

    public static class BirthdayCharacterId // TypeDefIndex: 24435
    {
        // Fields
        public const int AmanaCharactorId = 14; // Metadata: 0x00C3A6E3
        public const int TenkaCharactorId = 15; // Metadata: 0x00C3A6E4
        public const int HadukiCharactorId = 90; // Metadata: 0x00C3A6E5
        public const int ProducerCharactorId = 91; // Metadata: 0x00C3A6E7
    }

    public static class BirthdayEnum // TypeDefIndex: 24437
    {
        // Nested types
        public enum BirthdayPresentPhase // TypeDefIndex: 24436
        {
            First = 0,
            KeyWait = 1,
            Second = 2
        }
    }

    public enum ButtonBadgeType // TypeDefIndex: 24453
    {
        Chara = 0,
        Story = 1,
        Produce = 2,
        Live = 3,
        Gasha = 4,
        Mobile = 5,
        News = 6,
        Mission = 7,
        Present = 8,
        SeasonMission = 9,
        SpecialMission = 10,
        DirectMessage = 11,
        Item = 12,
        Shop = 13,
        Exchange = 14,
        Producer = 15,
        Friend = 16,
        Event = 17,
        EventStory = 18,
        EventMission = 19,
        EventMedalGasha = 20,
        Num = 21
    }

    public enum CategoryElementGridCellViewType // TypeDefIndex: 24441
    {
        Category = 0,
        Element = 1
    }

    public static class ChallengeTourConst // TypeDefIndex: 24656
    {
        // Fields
        public const string TopResourceTagName = "ChallengeTourTop"; // Metadata: 0x00C3A8CB
        public const string DetailResourceTagName = "ChallengeTourDetail"; // Metadata: 0x00C3A8DC
        public const string UnitEditResourceTagName = "ChallengeTourUnitEdit"; // Metadata: 0x00C3A8F0
        public const string ResultResourceTagName = "ChallengeTourResult"; // Metadata: 0x00C3A906
        public const string FilterTitle = "\u7D5E\u308A\u8FBC\u307F"; // Metadata: 0x00C3A91A
        public const string ResultAnimGet = "get"; // Metadata: 0x00C3A927
        public const string ResultAnimStar = "star"; // Metadata: 0x00C3A92B
        public static readonly Vector2[][] ShilhouettePosition; // 0x00

        // Constructors
        static ChallengeTourConst() { } // 0x0615A9F8-0x0615ACA0
    }

    public static class ChallengeTourEnum // TypeDefIndex: 24660
    {
        // Nested types
        public enum StageType // TypeDefIndex: 24657
        {
            None = 0,
            Normal = 1,
            Boss = 2
        }

        public enum StageFilterType // TypeDefIndex: 24658
        {
            NonStar = 0,
            Star1 = 1,
            Star2 = 2
        }

        public enum PIdilUnitDetailTabType // TypeDefIndex: 24659
        {
            ProduceIdol = 0,
            ProduceCard = 1
        }
    }

    public static class CharacterConst // TypeDefIndex: 24438
    {
        // Fields
        public const int Hazuki = 90; // Metadata: 0x00C3A6EC
        public const int FesIdolLimit = 500; // Metadata: 0x00C3A6EE
        public const int FesIdolTransferLimit = 15; // Metadata: 0x00C3A6F0
        public const int FesUnitLimit = 100; // Metadata: 0x00C3A6F1
        public const int FesUnitTransferLimit = 5; // Metadata: 0x00C3A6F3
        public const int MaxUnitMemberCount = 5; // Metadata: 0x00C3A6F4
        public const int LiveUnitMaxCount = 20; // Metadata: 0x00C3A6F5
        public const int UnitNameMaxLength = 10; // Metadata: 0x00C3A6F6
        public const int MaxPieceSelectedNum = 10; // Metadata: 0x00C3A6F7
        public const int PieceChangeRate = 1; // Metadata: 0x00C3A6F8
        public static readonly Dictionary<int, int> SupportEffectFilterSchedule; // 0x00
        public static readonly Dictionary<int, HashSet<int>> SupportEffectFilterScheduleDetail; // 0x08
        public static readonly HashSet<int> ProducePassiveEffectTypeIdNotRefersToSchedule; // 0x10
        public static readonly HashSet<int> ProducePassiveEffectTypeIdRefersToScheduleDetail; // 0x18
        public static readonly HashSet<int> ProducePassiveEffectTypeIdRefersToSchedule; // 0x20
        public static readonly Dictionary<int, HashSet<int>> ScheduleDetailTypeBelongingToScheduleType; // 0x28
        public const int RequiredItemsNumByGroup = 3; // Metadata: 0x00C3A6F9
        public const float FUnitLabelBlinkDuration = 2f; // Metadata: 0x00C3A6FA
        public const float TrainingTicketConsumptionMoneyFactor = 0.25f; // Metadata: 0x00C3A6FE

        // Constructors
        static CharacterConst() { } // 0x0612274C-0x06123464
    }

    public enum CostumePartType // TypeDefIndex: 24448
    {
        Costume = 0,
        HairStyle = 1,
        Accessory = 2
    }

    public class ExchangeConst // TypeDefIndex: 24468
    {
        // Fields
        public const int ExchangeIdolPiecePaddingHead = 16; // Metadata: 0x00C3A7FA
        public const int ExchangePaddingHead = 60; // Metadata: 0x00C3A7FB

        // Nested types
        public enum ExchangeViewType // TypeDefIndex: 24465
        {
            None = 0,
            Money = 1,
            IdolPiece = 2,
            CharacterPiece = 3,
            StarFragment = 4,
            SeasonMedal = 5,
            SelectionTicket = 6,
            CostumeTicket = 7
        }

        public enum ExchangeTabType // TypeDefIndex: 24466
        {
            None = 0,
            Money = 1,
            IdolPiece = 2,
            StarFragment = 3,
            SeasonMedal = 4,
            SelectionTicket = 5,
            CostumeTicket = 6
        }

        public enum ExchangeClosedReasonType // TypeDefIndex: 24467
        {
            None = 0,
            Jump = 1
        }

        // Constructors
        public ExchangeConst() { } // 0x0612346C-0x06123474
    }

    public static class FrameRateConstants // TypeDefIndex: 24454
    {
        // Fields
        public const int Shared = 60; // Metadata: 0x00C3A744
        public const int WhenPaused = 30; // Metadata: 0x00C3A745
        public const int ProduceIngame = 30; // Metadata: 0x00C3A746
        public const int DefaultRenderFPS = 60; // Metadata: 0x00C3A747
        public const int PowerSavingRenderFPS = 30; // Metadata: 0x00C3A748
    }

    public static class FriendConst // TypeDefIndex: 24470
    {
        // Fields
        public const string ResourceTagName = "Friend"; // Metadata: 0x00C3A80D
    }

    public static class FriendEnum // TypeDefIndex: 24474
    {
        // Nested types
        public enum CategoryType // TypeDefIndex: 24471
        {
            Follow = 0,
            Follower = 1,
            Recommend = 2
        }

        public enum SortCategory // TypeDefIndex: 24472
        {
            LoginDate = 0,
            Friend = 1,
            Follow = 2
        }

        public enum SortOrder // TypeDefIndex: 24473
        {
            Ascending = 0,
            Descending = 1
        }
    }

    public static class FullSizeOverlayEnum // TypeDefIndex: 24456
    {
        // Nested types
        public enum FullSizeOverlayType // TypeDefIndex: 24455
        {
            GlobalMenu = 0,
            Shop = 1,
            SeasonMission = 2,
            Friend = 3
        }
    }

    public enum GalleryContents // TypeDefIndex: 24439
    {
        Album = 0,
        Costume = 1,
        Voice = 2,
        Movie = 3
    }

    public static class GashaEnum // TypeDefIndex: 24477
    {
        // Nested types
        public enum SGashaPhase1FinishAnimationName // TypeDefIndex: 24475
        {
            Mot_Gasha_S1_SMP_Finish_R = 0,
            Mot_Gasha_S1_SMP_Finish_SR = 1,
            Mot_Gasha_S1_SMP_Finish_SSR = 2
        }

        public enum GashaResultItemAnimationName // TypeDefIndex: 24476
        {
            In_Normal = 0,
            In_PickUP = 1
        }
    }

    public static class GlobalMenuEnum // TypeDefIndex: 24479
    {
        // Nested types
        public enum MenuType // TypeDefIndex: 24478
        {
            Item = 0,
            Producer = 1,
            Friend = 2,
            Account = 3,
            ProduceSettings = 4,
            LiveSetting = 5,
            SystemSetting = 6,
            DM = 7,
            Help = 8,
            Inquiry = 9,
            Others = 10,
            Title = 11
        }
    }

    public enum HelpListCellType // TypeDefIndex: 24457
    {
        Large = 0,
        Small = 1
    }

    public static class HomeConst // TypeDefIndex: 24480
    {
        // Fields
        public const string HomeMainResourceTagName = "HomeMain"; // Metadata: 0x00C3A82D
        public const string HomeRemindItemResourceTagName = "HomeRemind"; // Metadata: 0x00C3A836
        public const string HomeSettingsResourceTagName = "HomeSettings"; // Metadata: 0x00C3A841
        public const string HomeLoginBonusResourceTagName = "HomeLoginBonus"; // Metadata: 0x00C3A84E
        public const string ChallengeTourStageDetailTagName = "ChallengeTourStageDetail"; // Metadata: 0x00C3A85D
        public const string HomeMotionPathFormat = "Animations/Character/ScenarioMode/{0}"; // Metadata: 0x00C3A876
        public const int CacheTime = 10; // Metadata: 0x00C3A89C
        public const float CharaMessageOpenMinTime = 10f; // Metadata: 0x00C3A89D
        public const float CharaMessageOpenMaxTime = 20f; // Metadata: 0x00C3A8A1
        public const float CharaMessageCloseTime = 1f; // Metadata: 0x00C3A8A5
        public const float CharaMessageLeaveActionTime = 60f; // Metadata: 0x00C3A8A9
        public const float FirstCharaMessageOpenTime = 1f; // Metadata: 0x00C3A8AD
    }

    public static class HomeEnum // TypeDefIndex: 24485
    {
        // Nested types
        public enum LoginBonusViewType // TypeDefIndex: 24481
        {
            Daily = 0,
            Special = 1,
            Single = 2
        }

        public enum Home3DViewType // TypeDefIndex: 24482
        {
            Producer = 0,
            CutScene = 1,
            LoginBonus = 2
        }

        public enum FadeType // TypeDefIndex: 24483
        {
            In = 0,
            Out = 1
        }

        public enum LoginBonusSkipType // TypeDefIndex: 24484
        {
            None = 0,
            First = 1,
            Second = 2
        }
    }

    public interface ICostume // TypeDefIndex: 24486
    {
        // Properties
        int Id { get; }
        LocalizationKey Name { get; }
        LocalizationKey Description { get; }
        LocalizationKey UnlockPremise { get; }
        MstCharacterInfo CharacterInfo { get; }
        int CostumeType { get; }
    }

    public enum IdolListFooterType // TypeDefIndex: 24451
    {
        Normal = 0,
        Favorite = 1,
        Transfer = 2
    }

    public enum IdolListTabType // TypeDefIndex: 24450
    {
        PI = 0,
        SC = 1,
        FU = 2,
        FI = 3
    }

    public enum IdolVoicePlayListCategory // TypeDefIndex: 24445
    {
        IdolCommon = 0,
        IdolCasualCostume = 1,
        ProduceIdol = 2,
        SupportCharacter = 3
    }

    public static class IListExtensions // TypeDefIndex: 24469
    {
        // Extension methods
        public static void Deconstruct<T>(this IList<T> list, out T value0, out T value1)
        {
            value0 = default;
            value1 = default;
        }
    }

    public readonly struct LocalizationKey // TypeDefIndex: 24487
    {
        // Fields
        public readonly string Category; // 0x00
        public readonly int Id; // 0x08

        // Constructors
        public LocalizationKey(string category, int id)
        {
            Category = default;
            Id = default;
        } // 0x06123474-0x0612349C
    }

    [MemoryPackable()]
    public partial class MasterData // TypeDefIndex: 24490
    {
        // Properties
        public Dictionary<int, MstCharacterInfo> CharacterInfos { get; private set; } // 0x0612349C-0x061234A4 0x061234A4-0x061234AC
        public Dictionary<int, MstIdol> Idols { get; private set; } // 0x061234AC-0x061234B4 0x061234B4-0x061234BC
        public Dictionary<int, MstIdolStandingPosition> IdolStandingPositions { get; private set; } // 0x061234BC-0x061234C4 0x061234C4-0x061234CC
        public Dictionary<int, MstCostumeSet> CostumeSets { get; private set; } // 0x061234CC-0x061234D4 0x061234D4-0x061234DC
        public Dictionary<int, MstCostume> Costumes { get; private set; } // 0x061234DC-0x061234E4 0x061234E4-0x061234EC
        public Dictionary<int, MstCostumeResource> CostumeResources { get; private set; } // 0x061234EC-0x061234F4 0x061234F4-0x061234FC
        public Dictionary<int, MstHairstyle> Hairstyles { get; private set; } // 0x061234FC-0x06123504 0x06123504-0x0612350C
        [JsonConverter(typeof(ValueTupleDictionaryConverter))]
        public Dictionary<(int MstCharacterInfoId, int StyleType), MstHairstyleResource> HairstyleResources { get; private set; } // 0x0612350C-0x06123514 0x06123514-0x0612351C
        public Dictionary<int, MstAccessory> Accessories { get; private set; } // 0x0612351C-0x06123524 0x06123524-0x0612352C
        public Dictionary<int, MstAccessoryResource> AccessoryResources { get; private set; } // 0x0612352C-0x06123534 0x06123534-0x0612353C
        public MstFavoriteMark[] FavoriteMarks { get; private set; } // 0x0612353C-0x06123544 0x06123544-0x0612354C
        public Dictionary<int, MstProductType> ProductTypes { get; private set; } // 0x0612354C-0x06123554 0x06123554-0x0612355C
        public Dictionary<int, MstProduceIdolLimitBreakRecipe> ProduceIdolLimitBreakRecipes { get; private set; } // 0x0612355C-0x06123564 0x06123564-0x0612356C
        public Dictionary<int, MstProduceIdolEvolutionRecipe> ProduceIdolEvolutionRecipes { get; private set; } // 0x0612356C-0x06123574 0x06123574-0x0612357C
        public Dictionary<int, MstSupportCharacterLevelExp> SupportCharacterLevelExps { get; private set; } // 0x0612357C-0x06123584 0x06123584-0x0612358C
        public Dictionary<int, MstSupportCharacterLimitBreakRecipe> SupportCharacterLimitBreakRecipes { get; private set; } // 0x0612358C-0x06123594 0x06123594-0x0612359C
        public Dictionary<int, MstOutgameVoiceMotion> OutgameVoiceMotions { get; private set; } // 0x0612359C-0x061235A4 0x061235A4-0x061235AC
        public Dictionary<int, MstUnit> Units { get; private set; } // 0x061235AC-0x061235B4 0x061235B4-0x061235BC
        public MstItemProvider[] ItemProviders { get; private set; } // 0x061235BC-0x061235C4 0x061235C4-0x061235CC
        public Dictionary<int, MstTrainingTicket> TrainingTickets { get; private set; } // 0x061235CC-0x061235D4 0x061235D4-0x061235DC
        public MstProduceActionEffectDisplay[] ProduceActionEffectDisplays { get; private set; } // 0x061235DC-0x061235E4 0x061235E4-0x061235EC
        public Dictionary<int, MstVoiceResource> VoiceResources { get; private set; } // 0x061235EC-0x061235F4 0x061235F4-0x061235FC
        public Dictionary<int, MstSupportEffect> SupportEffects { get; private set; } // 0x061235FC-0x06123604 0x06123604-0x0612360C
        public Dictionary<int, MstProducePassiveEffect> ProducePassiveEffects { get; private set; } // 0x0612360C-0x06123614 0x06123614-0x0612361C
        public MstSupportCharacterLimitBreakBonus[] SupportCharacterLimitBreakBonuses { get; private set; } // 0x0612361C-0x06123624 0x06123624-0x0612362C
        public MstTips[] Tips { get; private set; } // 0x0612362C-0x06123634 0x06123634-0x0612363C
        public Dictionary<int, MstTipsCategory> TipsCategory { get; private set; } // 0x0612363C-0x06123644 0x06123644-0x0612364C
        public MstExchangeProductFilter[] ExchangeProductFilters { get; private set; } // 0x0612364C-0x06123654 0x06123654-0x0612365C
        public MstPotentialLiveSkill[] PotentialLiveSkills { get; private set; } // 0x0612365C-0x06123664 0x06123664-0x0612366C
        public Dictionary<int, MstPotentialLiveSkillLevel> PotentialLiveSkillLevels { get; private set; } // 0x0612366C-0x06123674 0x06123674-0x0612367C
        public Dictionary<int, MstLiveSkillEffect> LiveSkillEffects { get; private set; } // 0x0612367C-0x06123684 0x06123684-0x06123694
        public Dictionary<int, MstChainGroup> ChainGroups { get; private set; } // 0x06123694-0x0612369C 0x0612369C-0x061236AC
        public Dictionary<int, MstPhoneUser> PhoneUsers { get; private set; } // 0x061236AC-0x061236B4 0x061236B4-0x061236C4
        public Dictionary<int, MstPotentialSupportSkill> PotentialSupportSkills { get; private set; } // 0x061236C4-0x061236CC 0x061236CC-0x061236DC
        public MstHelp[] Helps { get; private set; } // 0x061236DC-0x061236E4 0x061236E4-0x061236F4
        public MstBirthdayVoice[] BirthdayVoice { get; private set; } // 0x061236F4-0x061236FC 0x061236FC-0x0612370C
        public MstHelpGroup[] HelpGroups { get; private set; } // 0x0612370C-0x06123714 0x06123714-0x06123724
        public Dictionary<int, MstIdolStory> IdolStories { get; private set; } // 0x06123724-0x0612372C 0x0612372C-0x0612373C
        public MstTitleImage[] TitleImages { get; private set; } // 0x0612373C-0x06123744 0x06123744-0x06123754
        public Dictionary<int, MstSong> Songs { get; private set; } // 0x06123754-0x0612375C 0x0612375C-0x0612376C
        public MstAdvInfo[] AdvInfos { get; private set; } // 0x0612376C-0x06123774 0x06123774-0x06123784
        public Dictionary<int, MstTwestaUser> TwestaUsers { get; private set; } // 0x06123784-0x0612378C 0x0612378C-0x0612379C
        public Dictionary<int, MstChainUser> ChainUsers { get; private set; } // 0x0612379C-0x061237A4 0x061237A4-0x061237B4
        public Dictionary<int, MstBannerGenre> BannerGenre { get; private set; } // 0x061237B4-0x061237BC 0x061237BC-0x061237CC
        public Dictionary<int, MstAchievement> Achievement { get; private set; } // 0x061237CC-0x061237D4 0x061237D4-0x061237E4
        public Dictionary<int, MstEventIcon> EventIcon { get; private set; } // 0x061237E4-0x061237EC 0x061237EC-0x061237FC
        public Dictionary<int, MstLoginBonus> LoginBonus { get; private set; } // 0x061237FC-0x06123804 0x06123804-0x06123814
        public Dictionary<int, MstLoginBonusGraffiti> LoginBonusGraffiti { get; private set; } // 0x06123814-0x0612381C 0x0612381C-0x0612382C
        public MstEpisode[] Episodes { get; private set; } // 0x0612382C-0x06123834 0x06123834-0x06123844
        public MstProduceCardContentGroup[] ProduceCardContentGroups { get; private set; } // 0x06123844-0x0612384C 0x0612384C-0x0612385C
        public MstProduceActionEffect[] ProduceActionEffects { get; private set; } // 0x0612385C-0x06123864 0x06123864-0x06123874
        public Dictionary<int, MstEvent> Events { get; private set; } // 0x06123874-0x0612387C 0x0612387C-0x0612388C
        public Dictionary<int, MstProduceIdol> ProduceIdols { get; private set; } // 0x0612388C-0x06123894 0x06123894-0x061238A4
        public Dictionary<int, MstTwestaArticle> TwestaArticles { get; private set; } // 0x061238A4-0x061238AC 0x061238AC-0x061238BC
        public Dictionary<int, MstSupportCharacter> SupportCharacters { get; private set; } // 0x061238BC-0x061238C4 0x061238C4-0x061238D4
        public MstGeneralItem[] GeneralItems { get; private set; } // 0x061238D4-0x061238DC 0x061238DC-0x061238EC
        public Dictionary<int, MstRecoveryDrink> RecoveryDrinks { get; private set; } // 0x061238EC-0x061238F4 0x061238F4-0x06123904
        public Dictionary<int, MstEpisodeEventMissionBanner> EpisodeEventMissionBanners { get; private set; } // 0x06123904-0x0612390C 0x0612390C-0x0612391C
        public Dictionary<int, MstMainStoryChapter> MainStoryChapters { get; private set; } // 0x0612391C-0x06123924 0x06123924-0x06123934
        public Dictionary<int, MstMainStory> MainStories { get; private set; } // 0x06123934-0x0612393C 0x0612393C-0x0612394C
        public Dictionary<int, MstExtraStoryCategory> ExtraStoryCategories { get; private set; } // 0x0612394C-0x06123954 0x06123954-0x06123964
        public Dictionary<int, MstExtraStorySubCategory> ExtraStorySubCategories { get; private set; } // 0x06123964-0x0612396C 0x0612396C-0x0612397C
        public Dictionary<int, MstExtraStory> ExtraStories { get; private set; } // 0x0612397C-0x06123984 0x06123984-0x06123994
        public Dictionary<int, MstEventStory> EventStories { get; private set; } // 0x06123994-0x0612399C 0x0612399C-0x061239AC
        public Dictionary<int, MstChallengeTourStage> ChallengeTourStages { get; private set; } // 0x061239AC-0x061239B4 0x061239B4-0x061239C4
        public Dictionary<int, MstChallengeTourMission> ChallengeTourMissions { get; private set; } // 0x061239C4-0x061239CC 0x061239CC-0x061239DC
        public Dictionary<int, MstChallengeTour> ChallengeTours { get; private set; } // 0x061239DC-0x061239E4 0x061239E4-0x061239F4
        public MstChallengeTourRival[] ChallengeTourRivals { get; private set; } // 0x061239F4-0x061239FC 0x061239FC-0x06123A0C
        public Dictionary<int, MstSeasonMission> SeasonMissions { get; private set; } // 0x06123A0C-0x06123A14 0x06123A14-0x06123A24
        public Dictionary<string, MstGashaResource> GashaResources { get; private set; } // 0x06123A24-0x06123A2C 0x06123A2C-0x06123A3C
        public Dictionary<int, MstPhoneCall> PhoneCalls { get; private set; } // 0x06123A3C-0x06123A44 0x06123A44-0x06123A54
        public Dictionary<int, MstGashaTicket> GashaTickets { get; private set; } // 0x06123A54-0x06123A5C 0x06123A5C-0x06123A6C
        public Dictionary<int, MstGashaCompensationTicket> GashaCompensationTickets { get; private set; } // 0x06123A6C-0x06123A74 0x06123A74-0x06123A84
        public Dictionary<int, MstGashaToken> GashaTokens { get; private set; } // 0x06123A84-0x06123A8C 0x06123A8C-0x06123A9C
        public Dictionary<int, MstSelectionTicket> SelectionTickets { get; private set; } // 0x06123A9C-0x06123AA4 0x06123AA4-0x06123AB4
        public Dictionary<int, MstCostumeTicket> CostumeTickets { get; private set; } // 0x06123AB4-0x06123ABC 0x06123ABC-0x06123ACC
        public MstProduceStrategyType[] ProduceStrategyTypes { get; private set; } // 0x06123ACC-0x06123AD4 0x06123AD4-0x06123AE4
        public Dictionary<int, MstChainTalkText> ChainTalkTexts { get; private set; } // 0x06123AE4-0x06123AEC 0x06123AEC-0x06123AFC
        [MemoryPackIgnore]
        public int[] FavoriteMarkIds { get; private set; } // 0x06123AFC-0x06123B04 0x06123B04-0x06123B14

    }

    public enum MovieCategory // TypeDefIndex: 24443
    {
        ProduceIdol = 0,
        SupportCharacter = 1
    }

    [MemoryPackable()]
    public partial class MstAccessory : ICostume, IMemoryPackable<PRISM.Definitions.MstAccessory> // TypeDefIndex: 24492
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0612D190-0x0612D198 0x0612D198-0x0612D1A0
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x0612D1A0-0x0612D204 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x0612D204-0x0612D268 
        [MemoryPackIgnore]
        public LocalizationKey UnlockPremise { get => default; } // 0x0612D268-0x0612D2CC 
        public int MstCharacterInfoId { get; private set; } // 0x0612D2CC-0x0612D2D4 0x0612D2D4-0x0612D2DC
        public int CostumeType { get; private set; } // 0x0612D2DC-0x0612D2E4 0x0612D2E4-0x0612D2EC
        public int AccessoryType { get; private set; } // 0x0612D2EC-0x0612D2F4 0x0612D2F4-0x0612D2FC
        public int ResourceId { get; private set; } // 0x0612D2FC-0x0612D304 0x0612D304-0x0612D30C
        public int SortId { get; private set; } // 0x0612D30C-0x0612D314 0x0612D314-0x0612D31C
        [MemoryPackIgnore]
        public MstCharacterInfo CharacterInfo { get; private set; } // 0x0612D31C-0x0612D324 0x0612D324-0x0612D32C
        [MemoryPackIgnore]
        public MstAccessoryResource Resource { get; private set; } // 0x0612D32C-0x0612D334 0x0612D334-0x0612D33C

    }

    [MemoryPackable()]
    public partial class MstAccessoryResource // TypeDefIndex: 24494
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0612D9C4-0x0612D9CC 0x0612D9CC-0x0612D9D4
        public string PrefabName { get; private set; } // 0x0612D9D4-0x0612D9DC 0x0612D9DC-0x0612D9E4
    }

    [MemoryPackable()]
    public partial class MstAchievement // TypeDefIndex: 24496
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0612E084-0x0612E08C 0x0612E08C-0x0612E094
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x0612E094-0x0612E0F8 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x0612E0F8-0x0612E15C 
        [MemoryPackIgnore]
        public LocalizationKey Condition { get => default; } // 0x0612E15C-0x0612E1C0 
        public int AchievementType { get; private set; } // 0x0612E1C0-0x0612E1C8 0x0612E1C8-0x0612E1D0
        public int AchievementCategory { get; private set; } // 0x0612E1D0-0x0612E1D8 0x0612E1D8-0x0612E1E0
        [MemoryPackIgnore]
        public string ImagePath { get => default; } // 0x0612E1E0-0x0612E268 
    }

    [MemoryPackable()]
    public partial class MstAdvInfo // TypeDefIndex: 24498
    {
        // Properties
        public string Id { get; private set; } // 0x0612E800-0x0612E808 0x0612E808-0x0612E810
    }

    [MemoryPackable()]
    public partial class MstBannerGenre // TypeDefIndex: 24500
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0612ED5C-0x0612ED64 0x0612ED64-0x0612ED6C
        public string ResourceId { get; private set; } // 0x0612ED6C-0x0612ED74 0x0612ED74-0x0612ED7C
        [MemoryPackIgnore]
        public string ImagePath { get => default; } // 0x0612ED7C-0x0612EE04 
    }

    [MemoryPackable()]
    public partial class MstBirthdayVoice // TypeDefIndex: 24502
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0612F4A4-0x0612F4AC 0x0612F4AC-0x0612F4B4
        public int MstVoiceResourceId { get; private set; } // 0x0612F4B4-0x0612F4BC 0x0612F4BC-0x0612F4C4
        public System.DateTime ReleaseDate { get; private set; } // 0x0612F4C4-0x0612F4CC 0x0612F4CC-0x0612F4D4
    }

    [MemoryPackable()]
    public partial class MstChainGroup // TypeDefIndex: 24504
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0612FA98-0x0612FAA0 0x0612FAA0-0x0612FAA8
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x0612FAA8-0x0612FB0C 
        public int GroupType { get; private set; } // 0x0612FB0C-0x0612FB14 0x0612FB14-0x0612FB1C
        public int[] MstChainUserId { get; private set; } // 0x0612FB1C-0x0612FB24 0x0612FB24-0x0612FB2C
    }

    [MemoryPackable()]
    public partial class MstChainTalkText // TypeDefIndex: 24506
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0613025C-0x06130264 0x06130264-0x0613026C
        public int MstChainTalkId { get; private set; } // 0x0613026C-0x06130274 0x06130274-0x0613027C
        public int MstChainUserId { get; private set; } // 0x0613027C-0x06130284 0x06130284-0x0613028C
        public int TextType { get; private set; } // 0x0613028C-0x06130294 0x06130294-0x0613029C
        [MemoryPackIgnore]
        public LocalizationKey Body { get => default; } // 0x0613029C-0x06130300 
        public int StampId { get; private set; } // 0x06130300-0x06130308 0x06130308-0x06130310
        public int ThumbnailId { get; private set; } // 0x06130310-0x06130318 0x06130318-0x06130320
        public int[] NextId { get; private set; } // 0x06130320-0x06130328 0x06130328-0x06130330
        public int ThinkingRate { get; private set; } // 0x06130330-0x06130338 0x06130338-0x06130340
        public int TypingRate { get; private set; } // 0x06130340-0x06130348 0x06130348-0x06130350
        [MemoryPackIgnore]
        public string StampPath { get => default; } // 0x06130350-0x061303D8 
        [MemoryPackIgnore]
        public string ThumbnailPath { get => default; } // 0x061303D8-0x06130460 
    }

    [MemoryPackable()]
    public partial class MstChainUser // TypeDefIndex: 24508
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06130DD0-0x06130DD8 0x06130DD8-0x06130DE0
        public int MstUnitId { get; private set; } // 0x06130DE0-0x06130DE8 0x06130DE8-0x06130DF0
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06130DF0-0x06130E54 
        [MemoryPackIgnore]
        public LocalizationKey Profile { get => default; } // 0x06130E54-0x06130EB8 
        public int MstCharacterInfoId { get; private set; } // 0x06130EB8-0x06130EC0 0x06130EC0-0x06130EC8
    }

    [MemoryPackable()]
    public partial class MstChallengeTour // TypeDefIndex: 24510
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06131460-0x06131468 0x06131468-0x06131470
        public int MstUnitId { get; private set; } // 0x06131470-0x06131478 0x06131478-0x06131480
        public bool IsDefault { get; private set; } // 0x06131480-0x06131488 0x06131488-0x06131494
        [MemoryPackIgnore]
        public string UnitCharaImagePath { get => default; } // 0x06131494-0x0613151C 
    }

    [MemoryPackable()]
    public partial class MstChallengeTourMission // TypeDefIndex: 24512
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06131AE0-0x06131AE8 0x06131AE8-0x06131AF0
        public int MissionType { get; private set; } // 0x06131AF0-0x06131AF8 0x06131AF8-0x06131B00
        [MemoryPackIgnore]
        public LocalizationKey Text { get => default; } // 0x06131B00-0x06131B64 
    }

    [MemoryPackable()]
    public partial class MstChallengeTourRival // TypeDefIndex: 24514
    {
        // Properties
        public int SilhouetteId { get; private set; } // 0x061320AC-0x061320B4 0x061320B4-0x061320BC
        [MemoryPackIgnore]
        public string IconImagePath { get => default; } // 0x061320BC-0x06132144 
        [MemoryPackIgnore]
        public string SilhouettePrefabPath { get => default; } // 0x06132144-0x061321CC 
    }

    [MemoryPackable()]
    public partial class MstChallengeTourStage // TypeDefIndex: 24516
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06132694-0x0613269C 0x0613269C-0x061326A4
        public int MstChallengeTourId { get; private set; } // 0x061326A4-0x061326AC 0x061326AC-0x061326B4
        public int StageNumber { get; private set; } // 0x061326B4-0x061326BC 0x061326BC-0x061326C4
        public int StageType { get; private set; } // 0x061326C4-0x061326CC 0x061326CC-0x061326D4
        public int MstRivalUnitId { get; private set; } // 0x061326D4-0x061326DC 0x061326DC-0x061326E4
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x061326E4-0x06132748 
    }

    [MemoryPackable()]
    public partial class MstCharacterInfo // TypeDefIndex: 24518
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06132D80-0x06132D88 0x06132D88-0x06132D90
        public int MstUnitId { get; private set; } // 0x06132D90-0x06132D98 0x06132D98-0x06132DA0
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06132DA0-0x06132E04 
        [MemoryPackIgnore]
        public LocalizationKey FirstName { get => default; } // 0x06132E04-0x06132E68 
        [MemoryPackIgnore]
        public LocalizationKey LastName { get => default; } // 0x06132E68-0x06132ECC 
        public string FirstNameRoma { get; private set; } // 0x06132ECC-0x06132ED4 0x06132ED4-0x06132EDC
        public string LastNameRoma { get; private set; } // 0x06132EDC-0x06132EE4 0x06132EE4-0x06132EEC
        public string FirstNameKana { get; private set; } // 0x06132EEC-0x06132EF4 0x06132EF4-0x06132EFC
        public string LastNameKana { get; private set; } // 0x06132EFC-0x06132F04 0x06132F04-0x06132F0C
        [MemoryPackIgnore]
        public LocalizationKey Cv { get => default; } // 0x06132F0C-0x06132F70 
        public int Age { get; private set; } // 0x06132F70-0x06132F78 0x06132F78-0x06132F80
        public string BloodType { get; private set; } // 0x06132F80-0x06132F88 0x06132F88-0x06132F90
        public string Birthday { get; private set; } // 0x06132F90-0x06132F98 0x06132F98-0x06132FA0
        public string ZodiacSign { get; private set; } // 0x06132FA0-0x06132FA8 0x06132FA8-0x06132FB0
        public string DominantHand { get; private set; } // 0x06132FB0-0x06132FB8 0x06132FB8-0x06132FC0
        public string Birthplace { get; private set; } // 0x06132FC0-0x06132FC8 0x06132FC8-0x06132FD0
        public string Height { get; private set; } // 0x06132FD0-0x06132FD8 0x06132FD8-0x06132FE0
        public string Weight { get; private set; } // 0x06132FE0-0x06132FE8 0x06132FE8-0x06132FF0
        public string ThreeSizes { get; private set; } // 0x06132FF0-0x06132FF8 0x06132FF8-0x06133000
        public string Hobby { get; private set; } // 0x06133000-0x06133008 0x06133008-0x06133010
        public string SpecialAbility { get; private set; } // 0x06133010-0x06133018 0x06133018-0x06133020
        public string Description { get; private set; } // 0x06133020-0x06133028 0x06133028-0x06133030
        public string ColorCode { get; private set; } // 0x06133030-0x06133038 0x06133038-0x06133040
        public int MstDefaultCasualCostumeSetId { get; private set; } // 0x06133040-0x06133048 0x06133048-0x06133050
        public int MstTracksuitLifeSizeCostumeSetId { get; private set; } // 0x06133050-0x06133058 0x06133058-0x06133060
        public int MstTracksuitCbCostumeSetId { get; private set; } // 0x06133060-0x06133068 0x06133068-0x06133070
        public float Shape { get; private set; } // 0x06133070-0x06133078 0x06133078-0x06133080
        public float HeadShape { get; private set; } // 0x06133080-0x06133088 0x06133088-0x06133090
        public int MotionType { get; private set; } // 0x06133090-0x06133098 0x06133098-0x061330A0
        public string LightColorCode { get; private set; } // 0x061330A0-0x061330A8 0x061330A8-0x061330B0
        [MemoryPackIgnore]
        public string TipsCharacterImagePath { get => default; } // 0x061330B0-0x06133138 
        [MemoryPackIgnore]
        public string CharacterBaseButtonPrefabPath { get => default; } // 0x06133138-0x061331C0 
        [MemoryPackIgnore]
        public string BirthdayBackgroundPrefabPath { get => default; } // 0x061331C0-0x06133248 
        [MemoryPackIgnore]
        public string BirthdayRibbonPath { get => default; } // 0x06133248-0x061332D0 
        [MemoryPackIgnore]
        public string BirthdayCharacterNamePath { get => default; } // 0x061332D0-0x06133358 
        [MemoryPackIgnore]
        public string SDIconPath { get => default; } // 0x06133358-0x061333E0 
        [MemoryPackIgnore]
        public MstCostumeSet DefaultCasualCostumeSet { get; private set; } // 0x061333E0-0x061333E8 0x061333E8-0x061333F0
        [MemoryPackIgnore]
        public MstCostumeSet TracksuitLifeSizeCostumeSet { get; private set; } // 0x061333F0-0x061333F8 0x061333F8-0x06133400
        [MemoryPackIgnore]
        public MstCostumeSet TracksuitCbCostumeSet { get; private set; } // 0x06133400-0x06133408 0x06133408-0x06133410

    }

    [MemoryPackable()]
    public partial class MstCostume : ICostume // TypeDefIndex: 24520
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06135804-0x0613580C 0x0613580C-0x06135814
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06135814-0x06135878 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x06135878-0x061358DC 
        [MemoryPackIgnore]
        public LocalizationKey UnlockPremise { get => default; } // 0x061358DC-0x06135940 
        public int MstCharacterInfoId { get; private set; } // 0x06135940-0x06135948 0x06135948-0x06135950
        public int CostumeType { get; private set; } // 0x06135950-0x06135958 0x06135958-0x06135960
        public int ResourceId { get; private set; } // 0x06135960-0x06135968 0x06135968-0x06135970
        public int SortId { get; private set; } // 0x06135970-0x06135978 0x06135978-0x06135980
        [MemoryPackIgnore]
        public MstCharacterInfo CharacterInfo { get; private set; } // 0x06135980-0x06135988 0x06135988-0x06135990
        [MemoryPackIgnore]
        public MstCostumeResource Resource { get; private set; } // 0x06135990-0x06135998 0x06135998-0x061359A0

    }

    [MemoryPackable()]
    public partial class MstCostumeResource // TypeDefIndex: 24522
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06135FD8-0x06135FE0 0x06135FE0-0x06135FE8
        public string PrefabName { get; private set; } // 0x06135FE8-0x06135FF0 0x06135FF0-0x06135FF8
    }

    [MemoryPackable()]
    public partial class MstCostumeSet // TypeDefIndex: 24526
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06136698-0x061366A0 0x061366A0-0x061366A8
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x061366A8-0x0613670C 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x0613670C-0x06136770 
        [MemoryPackIgnore]
        public LocalizationKey UnlockPremise { get => default; } // 0x06136770-0x061367D4 
        public int CostumeType { get; private set; } // 0x061367D4-0x061367DC 0x061367DC-0x061367E4
        public int MstCostumeId { get; private set; } // 0x061367E4-0x061367EC 0x061367EC-0x061367F4
        public int MstHairstyleId { get; private set; } // 0x061367F4-0x061367FC 0x061367FC-0x06136804
        public int[] MstAccessoryIdList { get; private set; } // 0x06136804-0x0613680C 0x0613680C-0x06136814
        public int SortId { get; private set; } // 0x06136814-0x0613681C 0x0613681C-0x06136824
        [MemoryPackIgnore]
        public MstCostume Costume { get; private set; } // 0x06136824-0x0613682C 0x0613682C-0x06136834
        [MemoryPackIgnore]
        public MstHairstyle Hairstyle { get; private set; } // 0x06136834-0x0613683C 0x0613683C-0x06136844
        [MemoryPackIgnore]
        public MstAccessory[] Accessories { get; private set; } // 0x06136844-0x0613684C 0x0613684C-0x06136854

        // Constructors
    }

    [MemoryPackable()]
    public partial class MstCostumeTicket // TypeDefIndex: 24528
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x061372CC-0x061372D4 0x061372D4-0x061372DC
    }

    [MemoryPackable()]
    public partial class MstEpisode // TypeDefIndex: 24530
    {
        // Properties
        public int Id { get; private set; } // 0x061377A4-0x061377AC 0x061377AC-0x061377B4
        public int MstUnitId { get; private set; } // 0x061377B4-0x061377BC 0x061377BC-0x061377C4
        public int Chapter { get; private set; } // 0x061377C4-0x061377CC 0x061377CC-0x061377D4
        [MemoryPackIgnore]
        public LocalizationKey MvName { get => default; } // 0x061377D4-0x06137838 
        [MemoryPackIgnore]
        public string CircleThumbnailPath { get => default; } // 0x06137838-0x061378CC 
        [MemoryPackIgnore]
        public string RectThumbnailPath { get => default; } // 0x061378CC-0x06137960 
    }

    [MemoryPackable()]
    public partial class MstEpisodeEventMissionBanner // TypeDefIndex: 24532
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06137EF8-0x06137F00 0x06137F00-0x06137F08
        public int MstEpisodeId { get; private set; } // 0x06137F08-0x06137F10 0x06137F10-0x06137F18
        public int MstMissionGroupId { get; private set; } // 0x06137F18-0x06137F20 0x06137F20-0x06137F28
        [MemoryPackIgnore]
        public string BannerPath { get => default; } // 0x06137F28-0x06137FB0 
    }

    [MemoryPackable()]
    public partial class MstEvent // TypeDefIndex: 24534
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06138548-0x06138550 0x06138550-0x06138558
        public int EventType { get; private set; } // 0x06138558-0x06138560 0x06138560-0x06138568
        public int MstUnitId { get; private set; } // 0x06138568-0x06138570 0x06138570-0x06138578
        [MemoryPackIgnore]
        public string LiveEventLogoPath { get => default; } // 0x06138578-0x06138600 
        [MemoryPackIgnore]
        public string CharacterPrefabPath { get => default; } // 0x06138600-0x06138688 
        [MemoryPackIgnore]
        public string CharacterImagePath { get => default; } // 0x06138688-0x06138710 
        [MemoryPackIgnore]
        public string BannerPath { get => default; } // 0x06138710-0x06138798 
        [MemoryPackIgnore]
        public string BackgroundPath { get => default; } // 0x06138798-0x06138820 
        [MemoryPackIgnore]
        public string MoviePath { get => default; } // 0x06138820-0x061388A8 
        [MemoryPackIgnore]
        public string BgmName { get => default; } // 0x061388A8-0x06138930 
        [MemoryPackIgnore]
        public string EventStoryCategoryThumbnailPath { get => default; } // 0x06138930-0x061389B8 
        [MemoryPackIgnore]
        public string EventStoryBackgroundPath { get => default; } // 0x061389B8-0x06138A40 
    }

    [MemoryPackable()]
    public partial class MstEventIcon // TypeDefIndex: 24536
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06138FD8-0x06138FE0 0x06138FE0-0x06138FE8
        public int Place { get; private set; } // 0x06138FE8-0x06138FF0 0x06138FF0-0x06138FF8
        public string ImageResourceId { get; private set; } // 0x06138FF8-0x06139000 0x06139000-0x06139008
        public string Text { get; private set; } // 0x06139008-0x06139010 0x06139010-0x06139018
        public int DisplayCondition { get; private set; } // 0x06139018-0x06139020 0x06139020-0x06139028
        public int Priority { get; private set; } // 0x06139028-0x06139030 0x06139030-0x06139038
        [MemoryPackIgnore]
        public string ImagePath { get => default; } // 0x06139038-0x061390C0 
    }

    [MemoryPackable()]
    public partial class MstEventStory // TypeDefIndex: 24538
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06139A14-0x06139A1C 0x06139A1C-0x06139A24
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x06139A24-0x06139A88 
        [MemoryPackIgnore]
        public LocalizationKey Episode { get => default; } // 0x06139A88-0x06139AEC 
        public int ScenarioNumber { get; private set; } // 0x06139AEC-0x06139AF4 0x06139AF4-0x06139AFC
        public int MstEventId { get; private set; } // 0x06139AFC-0x06139B04 0x06139B04-0x06139B0C
        public int EpisodeType { get; private set; } // 0x06139B0C-0x06139B14 0x06139B14-0x06139B1C
        public int SortId { get; private set; } // 0x06139B1C-0x06139B24 0x06139B24-0x06139B2C
        public int[] MstCharacterInfoIdList { get; private set; } // 0x06139B2C-0x06139B34 0x06139B34-0x06139B3C
        public int UnlockPremiseMstEventStoryId { get; private set; } // 0x06139B3C-0x06139B44 0x06139B44-0x06139B4C
        public int UnlockPremiseEventPoint { get; private set; } // 0x06139B4C-0x06139B54 0x06139B54-0x06139B5C
        public System.DateTime ReleaseDate { get; private set; } // 0x06139B5C-0x06139B64 0x06139B64-0x06139B6C
        public int PreviousMstEventStoryId { get; private set; } // 0x06139B6C-0x06139B74 0x06139B74-0x06139B7C
        [MemoryPackIgnore]
        public string ThumbnailPath { get => default; } // 0x06139B7C-0x06139C04 
    }

    [MemoryPackable()]
    public partial class MstExchangeProductFilter // TypeDefIndex: 24540
    {
        // Properties
        public int Id { get; private set; } // 0x0613A5F0-0x0613A5F8 0x0613A5F8-0x0613A600
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x0613A600-0x0613A664 
    }

    [MemoryPackable()]
    public partial class MstExtraStory // TypeDefIndex: 24542
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0613C248-0x0613C250 0x0613C250-0x0613C258
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x0613C258-0x0613C2BC 
        public int ExtraStoryType { get; private set; } // 0x0613C2BC-0x0613C2C4 0x0613C2C4-0x0613C2CC
        [MemoryPackIgnore]
        public LocalizationKey Episode { get => default; } // 0x0613C2CC-0x0613C330 
        public int MstExtraStorySubCategoryId { get; private set; } // 0x0613C330-0x0613C338 0x0613C338-0x0613C340
        public int SortId { get; private set; } // 0x0613C340-0x0613C348 0x0613C348-0x0613C350
        public string ScenarioId { get; private set; } // 0x0613C350-0x0613C358 0x0613C358-0x0613C360
        public int[] MstCharacterInfoIdList { get; private set; } // 0x0613C360-0x0613C368 0x0613C368-0x0613C370
        public int UnlockPremiseMstExtraStoryId { get; private set; } // 0x0613C370-0x0613C378 0x0613C378-0x0613C380
        public System.DateTime ReleaseDate { get; private set; } // 0x0613C380-0x0613C388 0x0613C388-0x0613C390
        public int PreviousMstExtraStoryId { get; private set; } // 0x0613C390-0x0613C398 0x0613C398-0x0613C3A0
        [MemoryPackIgnore]
        public string ThumbnailPath { get => default; } // 0x0613C3A0-0x0613C428 
    }

    [MemoryPackable()]
    public partial class MstExtraStoryCategory // TypeDefIndex: 24544
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0613CF14-0x0613CF1C 0x0613CF1C-0x0613CF24
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x0613CF24-0x0613CF88 
        public System.DateTime ReleaseDate { get; private set; } // 0x0613CF88-0x0613CF90 0x0613CF90-0x0613CF98
        [MemoryPackIgnore]
        public string ThumbnailPath { get => default; } // 0x0613CF98-0x0613D020 
    }

    [MemoryPackable()]
    public partial class MstExtraStorySubCategory // TypeDefIndex: 24546
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0613D684-0x0613D68C 0x0613D68C-0x0613D694
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x0613D694-0x0613D6F8 
        public int MstExtraStoryCategoryId { get; private set; } // 0x0613D6F8-0x0613D700 0x0613D700-0x0613D708
        public System.DateTime ReleaseDate { get; private set; } // 0x0613D708-0x0613D710 0x0613D710-0x0613D718
        [MemoryPackIgnore]
        public string ThumbnailPath { get => default; } // 0x0613D718-0x0613D7A0 
        [MemoryPackIgnore]
        public string ExtraStoryBackgroundPath { get => default; } // 0x0613D7A0-0x0613D828 
    }

    [MemoryPackable()]
    public partial class MstFavoriteMark // TypeDefIndex: 24548
    {
        // Properties
        public int Id { get; private set; } // 0x0613DDEC-0x0613DDF4 0x0613DDF4-0x0613DDFC
    }

    [MemoryPackable()]
    public partial class MstGashaCompensationTicket // TypeDefIndex: 24550
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0613E2C4-0x0613E2CC 0x0613E2CC-0x0613E2D4
        public int SortId { get; private set; } // 0x0613E2D4-0x0613E2DC 0x0613E2DC-0x0613E2E4
        public string[] GashaResourceIdList { get; private set; } // 0x0613E2E4-0x0613E2EC 0x0613E2EC-0x0613E2F4
    }

    [MemoryPackable()]
    public partial class MstGashaResource // TypeDefIndex: 24552
    {
        // Properties
        [PrimaryKey]
        public string Id { get; private set; } // 0x0613E9E4-0x0613E9EC 0x0613E9EC-0x0613E9F4
        public string[] MovieList { get; private set; } // 0x0613E9F4-0x0613E9FC 0x0613E9FC-0x0613EA04
        public string[] MovieValueList { get; private set; } // 0x0613EA04-0x0613EA0C 0x0613EA0C-0x0613EA14
        public string[] ImageList { get; private set; } // 0x0613EA14-0x0613EA1C 0x0613EA1C-0x0613EA24
        public string StepCatchphraseImage { get; private set; } // 0x0613EA24-0x0613EA2C 0x0613EA2C-0x0613EA34
    }

    [MemoryPackable()]
    public partial class MstGashaTicket // TypeDefIndex: 24554
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0613F584-0x0613F58C 0x0613F58C-0x0613F594
        public int SortId { get; private set; } // 0x0613F594-0x0613F59C 0x0613F59C-0x0613F5A4
        public string[] GashaResourceIdList { get; private set; } // 0x0613F5A4-0x0613F5AC 0x0613F5AC-0x0613F5B4
    }

    [MemoryPackable()]
    public partial class MstGashaToken // TypeDefIndex: 24556
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0613FCA4-0x0613FCAC 0x0613FCAC-0x0613FCB4
        public int SortId { get; private set; } // 0x0613FCB4-0x0613FCBC 0x0613FCBC-0x0613FCC4
    }

    [MemoryPackable()]
    public partial class MstGeneralItem // TypeDefIndex: 24558
    {
        // Properties
        public int ProductType { get; private set; } // 0x0614020C-0x06140214 0x06140214-0x0614021C
        public int Id { get; private set; } // 0x0614021C-0x06140224 0x06140224-0x0614022C
    }

    [MemoryPackable()]
    public partial class MstHairstyle : ICostume, IMemoryPackable<PRISM.Definitions.MstHairstyle> // TypeDefIndex: 24562
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06140774-0x0614077C 0x0614077C-0x06140784
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06140784-0x061407E8 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x061407E8-0x0614084C 
        [MemoryPackIgnore]
        public LocalizationKey UnlockPremise { get => default; } // 0x0614084C-0x061408B0 
        public int MstCharacterInfoId { get; private set; } // 0x061408B0-0x061408B8 0x061408B8-0x061408C0
        public int CostumeType { get; private set; } // 0x061408C0-0x061408C8 0x061408C8-0x061408D0
        public int HairResourceIdForClient { get; private set; } // 0x061408D0-0x061408D8 0x061408D8-0x061408E0
        public int[] HairAccessoryResourceIdListForClient { get; private set; } // 0x061408E0-0x061408E8 0x061408E8-0x061408F0
        public int SortId { get; private set; } // 0x061408F0-0x061408F8 0x061408F8-0x06140900
        [MemoryPackIgnore]
        public MstCharacterInfo CharacterInfo { get; private set; } // 0x06140900-0x06140908 0x06140908-0x06140910
        [MemoryPackIgnore]
        public MstHairstyleResource HairResource { get; private set; } // 0x06140910-0x06140918 0x06140918-0x06140920
        [MemoryPackIgnore]
        public MstAccessoryResource[] HairAccessoryResources { get; private set; } // 0x06140920-0x06140928 0x06140928-0x06140930

    }

    [MemoryPackable()]
    public partial class MstHairstyleResource // TypeDefIndex: 24564
    {
        // Properties
        [PrimaryKey]
        public int MstCharacterInfoId { get; private set; } // 0x0614153C-0x06141544 0x06141544-0x0614154C
        [PrimaryKey]
        public int StyleType { get; private set; } // 0x0614154C-0x06141554 0x06141554-0x0614155C
        public int HairId { get; private set; } // 0x0614155C-0x06141564 0x06141564-0x0614156C
        public int HeadWearId { get; private set; } // 0x0614156C-0x06141574 0x06141574-0x0614157C
    }

    [MemoryPackable()]
    public partial class MstHelp // TypeDefIndex: 24566
    {
        // Properties
        public int Id { get; private set; } // 0x06141B68-0x06141B70 0x06141B70-0x06141B78
        public int SortId { get; private set; } // 0x06141B78-0x06141B80 0x06141B80-0x06141B88
        public int MstHelpGroupId { get; private set; } // 0x06141B88-0x06141B90 0x06141B90-0x06141B98
        [MemoryPackIgnore]
        public LocalizationKey HelpTitle { get => default; } // 0x06141B98-0x06141BFC 
        [MemoryPackIgnore]
        public LocalizationKey HelpBody { get => default; } // 0x06141BFC-0x06141C60 
        public bool IsMobile { get; private set; } // 0x06141C60-0x06141C68 0x06141C68-0x06141C74
        public bool IsGpg { get; private set; } // 0x06141C74-0x06141C7C 0x06141C7C-0x06141C88
        public bool IsDmm { get; private set; } // 0x06141C88-0x06141C90 0x06141C90-0x06141C9C
        public System.DateTime BeginDate { get; private set; } // 0x06141C9C-0x06141CA4 0x06141CA4-0x06141CAC
        public System.DateTime EndDate { get; private set; } // 0x06141CAC-0x06141CB4 0x06141CB4-0x06141CBC
    }

    [MemoryPackable()]
    public partial class MstHelpGroup // TypeDefIndex: 24568
    {
        // Properties
        public int Id { get; private set; } // 0x06142458-0x06142460 0x06142460-0x06142468
        public int SortId { get; private set; } // 0x06142468-0x06142470 0x06142470-0x06142478
        [MemoryPackIgnore]
        public LocalizationKey HelpGroupTitle { get => default; } // 0x06142478-0x061424DC 
        public int HelpType { get; private set; } // 0x061424DC-0x061424E4 0x061424E4-0x061424EC
        public System.DateTime BeginDate { get; private set; } // 0x061424EC-0x061424F4 0x061424F4-0x061424FC
        public System.DateTime EndDate { get; private set; } // 0x061424FC-0x06142504 0x06142504-0x0614250C
    }

    [MemoryPackable()]
    public partial class MstIdol // TypeDefIndex: 24570
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06142B68-0x06142B70 0x06142B70-0x06142B78
        public int MstDefaultLiveCostumeSetId { get; private set; } // 0x06142B78-0x06142B80 0x06142B80-0x06142B88
        [MemoryPackIgnore]
        public MstCostumeSet DefaultLiveCostumeSet { get; private set; } // 0x06142B88-0x06142B90 0x06142B90-0x06142B98

    }

    [MemoryPackable()]
    public partial class MstIdolStandingPosition // TypeDefIndex: 24572
    {
        // Properties
        [PrimaryKey]
        public int MstUnitId { get; private set; } // 0x06143148-0x06143150 0x06143150-0x06143158
        public int[] Order { get; private set; } // 0x06143158-0x06143160 0x06143160-0x06143168
    }

    [MemoryPackable()]
    public partial class MstIdolStory // TypeDefIndex: 24574
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0614384C-0x06143854 0x06143854-0x0614385C
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x0614385C-0x061438C0 
        [MemoryPackIgnore]
        public LocalizationKey Episode { get => default; } // 0x061438C0-0x06143924 
        public int MstIdolId { get; private set; } // 0x06143924-0x0614392C 0x0614392C-0x06143934
        public int SortId { get; private set; } // 0x06143934-0x0614393C 0x0614393C-0x06143944
        public int[] MstCharacterInfoIdList { get; private set; } // 0x06143944-0x0614394C 0x0614394C-0x06143954
        public int UnlockPremiseMstIdolStoryId { get; private set; } // 0x06143954-0x0614395C 0x0614395C-0x06143964
        public int UnlockPremiseIdolBaseDearness { get; private set; } // 0x06143964-0x0614396C 0x0614396C-0x06143974
        public string[] RewardProductList { get; private set; } // 0x06143974-0x0614397C 0x0614397C-0x06143984
        public System.DateTime ReleaseDate { get; private set; } // 0x06143984-0x0614398C 0x0614398C-0x06143994
        public int PreviousMstIdolStoryId { get; private set; } // 0x06143994-0x0614399C 0x0614399C-0x061439A4
        [MemoryPackIgnore]
        public string ThumbnailPath { get => default; } // 0x061439A4-0x06143A2C 
    }

    [MemoryPackable()]
    public partial class MstItemProvider // TypeDefIndex: 24576
    {
        // Properties
        public int Id { get; private set; } // 0x06144560-0x06144568 0x06144568-0x06144570
        public string ProductId { get; private set; } // 0x06144570-0x06144578 0x06144578-0x06144580
        public int ProviderType { get; private set; } // 0x06144580-0x06144588 0x06144588-0x06144590
        public string ProviderParameter { get; private set; } // 0x06144590-0x06144598 0x06144598-0x061445A0
        [MemoryPackIgnore]
        public LocalizationKey ScreenTitle { get => default; } // 0x061445A0-0x06144604 
        [MemoryPackIgnore]
        public LocalizationKey ScreenTab { get => default; } // 0x06144604-0x06144668 
        public System.DateTime BeginDate { get; private set; } // 0x06144668-0x06144670 0x06144670-0x06144678
        public System.DateTime EndDate { get; private set; } // 0x06144678-0x06144680 0x06144680-0x06144688
    }

    [MemoryPackable()]
    public partial class MstLiveSkillEffect // TypeDefIndex: 24578
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06145124-0x0614512C 0x0614512C-0x06145134
        public int LiveSkillType { get; private set; } // 0x06145134-0x0614513C 0x0614513C-0x06145144
        public int EffectValue { get; private set; } // 0x06145144-0x0614514C 0x0614514C-0x06145154
        public int EffectValue2 { get; private set; } // 0x06145154-0x0614515C 0x0614515C-0x06145164
        public int EffectValue3 { get; private set; } // 0x06145164-0x0614516C 0x0614516C-0x06145174
        public int EffectValue4 { get; private set; } // 0x06145174-0x0614517C 0x0614517C-0x06145184
        public int EffectTime { get; private set; } // 0x06145184-0x0614518C 0x0614518C-0x06145194
    }

    [MemoryPackable()]
    public partial class MstLoginBonus // TypeDefIndex: 24580
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06145870-0x06145878 0x06145878-0x06145880
        public string Title { get; private set; } // 0x06145880-0x06145888 0x06145888-0x06145890
        public int LoginBonusType { get; private set; } // 0x06145890-0x06145898 0x06145898-0x061458A0
        public int DisplayPriority { get; private set; } // 0x061458A0-0x061458A8 0x061458A8-0x061458B0
        [MemoryPackIgnore]
        public string TitleImagePath { get => default; } // 0x061458B0-0x06145938 
        [MemoryPackIgnore]
        public string BgImagePath { get => default; } // 0x06145938-0x061459C0 
    }

    [MemoryPackable()]
    public partial class MstLoginBonusGraffiti // TypeDefIndex: 24582
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06146144-0x0614614C 0x0614614C-0x06146154
        public int MstLoginBonusId { get; private set; } // 0x06146154-0x0614615C 0x0614615C-0x06146164
        public string[] ResourceIdList { get; private set; } // 0x06146164-0x0614616C 0x0614616C-0x06146174
    }

    [MemoryPackable()]
    public partial class MstMainStory // TypeDefIndex: 24584
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06146864-0x0614686C 0x0614686C-0x06146874
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x06146874-0x061468D8 
        [MemoryPackIgnore]
        public LocalizationKey Episode { get => default; } // 0x061468D8-0x0614693C 
        public int MstMainStoryChapterId { get; private set; } // 0x0614693C-0x06146944 0x06146944-0x0614694C
        public int SortId { get; private set; } // 0x0614694C-0x06146954 0x06146954-0x0614695C
        public int[] MstCharacterInfoIdList { get; private set; } // 0x0614695C-0x06146964 0x06146964-0x0614696C
        public int UnlockPremiseMstMainStoryId { get; private set; } // 0x0614696C-0x06146974 0x06146974-0x0614697C
        public string[] RewardProductList { get; private set; } // 0x0614697C-0x06146984 0x06146984-0x0614698C
        public System.DateTime ReleaseDate { get; private set; } // 0x0614698C-0x06146994 0x06146994-0x0614699C
        public int PreviousMstMainStoryId { get; private set; } // 0x0614699C-0x061469A4 0x061469A4-0x061469AC
        [MemoryPackIgnore]
        public string ThumbnailPath { get => default; } // 0x061469AC-0x06146A34 
    }

    [MemoryPackable()]
    public partial class MstMainStoryChapter // TypeDefIndex: 24586
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0614751C-0x06147524 0x06147524-0x0614752C
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x0614752C-0x06147590 
        public int MstUnitId { get; private set; } // 0x06147590-0x06147598 0x06147598-0x061475A0
        public System.DateTime ReleaseDate { get; private set; } // 0x061475A0-0x061475A8 0x061475A8-0x061475B0
        [MemoryPackIgnore]
        public string ThumbnailPath { get => default; } // 0x061475B0-0x06147638 
        [MemoryPackIgnore]
        public string MainStoryBackgroundPath { get => default; } // 0x06147638-0x061476C0 
    }

    [MemoryPackable()]
    public partial class MstOutgameVoiceMotion // TypeDefIndex: 24588
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06147C84-0x06147C8C 0x06147C8C-0x06147C94
        public int MstCharacterInfoId { get; private set; } // 0x06147C94-0x06147C9C 0x06147C9C-0x06147CA4
        public int ScreenType { get; private set; } // 0x06147CA4-0x06147CAC 0x06147CAC-0x06147CB4
        public int MstProduceIdolId { get; private set; } // 0x06147CB4-0x06147CBC 0x06147CBC-0x06147CC4
        public int MstSupportCharacterId { get; private set; } // 0x06147CC4-0x06147CCC 0x06147CCC-0x06147CD4
        public bool ReachedGrowthLimit { get; private set; } // 0x06147CD4-0x06147CDC 0x06147CDC-0x06147CE8
        public int MstVoiceResourceId { get; private set; } // 0x06147CE8-0x06147CF0 0x06147CF0-0x06147CF8
        public System.DateTime ReleaseDate { get; private set; } // 0x06147CF8-0x06147D00 0x06147D00-0x06147D08
        [MemoryPackIgnore]
        public MstVoiceResource Voice { get; private set; } // 0x06147D08-0x06147D10 0x06147D10-0x06147D18

    }

    [MemoryPackable()]
    public partial class MstPhoneCall // TypeDefIndex: 24590
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06148510-0x06148518 0x06148518-0x06148520
        public int MstPhoneUserId { get; private set; } // 0x06148520-0x06148528 0x06148528-0x06148530
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x06148530-0x06148594 
        public int TypeId { get; private set; } // 0x06148594-0x0614859C 0x0614859C-0x061485A4
        public int ScenarioId { get; private set; } // 0x061485A4-0x061485AC 0x061485AC-0x061485B4
        public int ScenarioNumber { get; private set; } // 0x061485B4-0x061485BC 0x061485BC-0x061485C4
        [MemoryPackIgnore]
        public string CueSheetName { get => default; } // 0x061485C4-0x0614866C 
    }

    [MemoryPackable()]
    public partial class MstPhoneUser // TypeDefIndex: 24592
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06148CA4-0x06148CAC 0x06148CAC-0x06148CB4
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06148CB4-0x06148D18 
        public int MstCharacterInfoId { get; private set; } // 0x06148D18-0x06148D20 0x06148D20-0x06148D28
    }

    public static class MstPhoneUserExtensions // TypeDefIndex: 24654
    {
        // Extension methods
        public static bool IsProducer(this MstPhoneUser mstPhoneUser) => default; // 0x0615A9D8-0x0615A9F8
    }

    [MemoryPackable()]
    public partial class MstPotentialLiveSkill // TypeDefIndex: 24594
    {
        // Properties
        public int Id { get; private set; } // 0x06149270-0x06149278 0x06149278-0x06149280
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x06149280-0x061492E4 
    }

    [MemoryPackable()]
    public partial class MstPotentialLiveSkillLevel // TypeDefIndex: 24596
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x061497AC-0x061497B4 0x061497B4-0x061497BC
        public int MstPotentialLiveSkillId { get; private set; } // 0x061497BC-0x061497C4 0x061497C4-0x061497CC
        public int Level { get; private set; } // 0x061497CC-0x061497D4 0x061497D4-0x061497DC
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x061497DC-0x06149840 
        public int[] MstLiveSkillEffectIdList { get; private set; } // 0x06149840-0x06149848 0x06149848-0x06149850
    }

    [MemoryPackable()]
    public partial class MstPotentialSupportSkill // TypeDefIndex: 24598
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06149FD8-0x06149FE0 0x06149FE0-0x06149FE8
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06149FE8-0x0614A04C 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x0614A04C-0x0614A0B0 
        public int MstSupportSkillTypeId { get; private set; } // 0x0614A0B0-0x0614A0B8 0x0614A0B8-0x0614A0C0
        public int[] ValueList { get; private set; } // 0x0614A0C0-0x0614A0C8 0x0614A0C8-0x0614A0D0
        public int MstSkillBufferDisplayId { get; private set; } // 0x0614A0D0-0x0614A0D8 0x0614A0D8-0x0614A0E0
        public int EntrustAppealType { get; private set; } // 0x0614A0E0-0x0614A0E8 0x0614A0E8-0x0614A0F0
        public int EntrustScore { get; private set; } // 0x0614A0F0-0x0614A0F8 0x0614A0F8-0x0614A100
        [MemoryPackIgnore]
        public string SupportSkillIconImagePath { get => default; } // 0x0614A100-0x0614A188 
    }

    [MemoryPackable()]
    public partial class MstProduceActionEffect // TypeDefIndex: 24600
    {
        // Properties
        public int IconId { get; private set; } // 0x0614AA10-0x0614AA18 0x0614AA18-0x0614AA20
        [MemoryPackIgnore]
        public string IconImagePath { get => default; } // 0x0614AA20-0x0614AAA8 
    }

    [MemoryPackable()]
    public partial class MstProduceActionEffectDisplay // TypeDefIndex: 24602
    {
        // Properties
        public int Id { get; private set; } // 0x0614AF70-0x0614AF78 0x0614AF78-0x0614AF80
    }

    [MemoryPackable()]
    public partial class MstProduceCardContentGroup // TypeDefIndex: 24604
    {
        // Properties
        public int MstProduceCardId { get; private set; } // 0x0614B448-0x0614B450 0x0614B450-0x0614B458
        public int MstProduceCardContentGroupTypeId { get; private set; } // 0x0614B458-0x0614B460 0x0614B460-0x0614B468
        [MemoryPackIgnore]
        public string CardImagePath { get => default; } // 0x0614B468-0x0614B4F0 
        [MemoryPackIgnore]
        public string Phase1CardImagePath { get => default; } // 0x0614B4F0-0x0614B578 
        [MemoryPackIgnore]
        public string Phase2CardImagePath { get => default; } // 0x0614B578-0x0614B600 
    }

    [MemoryPackable()]
    public partial class MstProduceIdol // TypeDefIndex: 24606
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0614BB48-0x0614BB50 0x0614BB50-0x0614BB58
        public int MstIdolId { get; private set; } // 0x0614BB58-0x0614BB60 0x0614BB60-0x0614BB68
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x0614BB68-0x0614BBCC 
        public int InitialStar { get; private set; } // 0x0614BBCC-0x0614BBD4 0x0614BBD4-0x0614BBDC
        public int CardId { get; private set; } // 0x0614BBDC-0x0614BBE4 0x0614BBE4-0x0614BBEC
        public int InitialVocal { get; private set; } // 0x0614BBEC-0x0614BBF4 0x0614BBF4-0x0614BBFC
        public int InitialDance { get; private set; } // 0x0614BBFC-0x0614BC04 0x0614BC04-0x0614BC0C
        public int InitialVisual { get; private set; } // 0x0614BC0C-0x0614BC14 0x0614BC14-0x0614BC1C
        public int InitialMental { get; private set; } // 0x0614BC1C-0x0614BC24 0x0614BC24-0x0614BC2C
        public int LimitVocal { get; private set; } // 0x0614BC2C-0x0614BC34 0x0614BC34-0x0614BC3C
        public int LimitDance { get; private set; } // 0x0614BC3C-0x0614BC44 0x0614BC44-0x0614BC4C
        public int LimitVisual { get; private set; } // 0x0614BC4C-0x0614BC54 0x0614BC54-0x0614BC5C
        public int LimitMental { get; private set; } // 0x0614BC5C-0x0614BC64 0x0614BC64-0x0614BC6C
        public int MstStarGrowthId { get; private set; } // 0x0614BC6C-0x0614BC74 0x0614BC74-0x0614BC7C
        public int Cost { get; private set; } // 0x0614BC7C-0x0614BC84 0x0614BC84-0x0614BC8C
        public int[] MstIdolSkillIdList { get; private set; } // 0x0614BC8C-0x0614BC94 0x0614BC94-0x0614BC9C
        public int[] IdolSkillPremiseEvolutionLevelList { get; private set; } // 0x0614BC9C-0x0614BCA4 0x0614BCA4-0x0614BCAC
        public int[] MstPotentialLiveSkillIdList { get; private set; } // 0x0614BCAC-0x0614BCB4 0x0614BCB4-0x0614BCBC
        public int[] PotentialLiveSkillPremiseStarList { get; private set; } // 0x0614BCBC-0x0614BCC4 0x0614BCC4-0x0614BCCC
        public int[] CostumeSetIdList { get; private set; } // 0x0614BCCC-0x0614BCD4 0x0614BCD4-0x0614BCDC
        public int[] CostumeSetPremiseStarList { get; private set; } // 0x0614BCDC-0x0614BCE4 0x0614BCE4-0x0614BCEC
        public System.DateTime ReleaseDate { get; private set; } // 0x0614BCEC-0x0614BCF4 0x0614BCF4-0x0614BCFC
        public string LimitBreakRecipeProductId { get; private set; } // 0x0614BCFC-0x0614BD04 0x0614BD04-0x0614BD0C
        public int EvolutionRecipeGroupId { get; private set; } // 0x0614BD0C-0x0614BD14 0x0614BD14-0x0614BD1C
        public string[] MstIdolSkillForMstProduceIdolList { get; private set; } // 0x0614BD1C-0x0614BD24 0x0614BD24-0x0614BD2C
        public string[] MstPotentialLiveSkillForMstProduceIdolList { get; private set; } // 0x0614BD2C-0x0614BD34 0x0614BD34-0x0614BD3C
        public string[] MstDressSetForMstProduceIdolList { get; private set; } // 0x0614BD3C-0x0614BD44 0x0614BD44-0x0614BD4C
        public int GashaVoiceMstVoiceResourceId { get; private set; } // 0x0614BD4C-0x0614BD54 0x0614BD54-0x0614BD5C
        public int GashaSeMstVoiceResourceId { get; private set; } // 0x0614BD5C-0x0614BD64 0x0614BD64-0x0614BD6C
        [MemoryPackIgnore]
        public string AlignedFacePrefabPath { get => default; } // 0x0614BD6C-0x0614BDF4 
        [MemoryPackIgnore]
        public string StandingImagePath { get => default; } // 0x0614BDF4-0x0614BE7C 
        [MemoryPackIgnore]
        public string IconRectImagePath { get => default; } // 0x0614BE7C-0x0614BF04 
        [MemoryPackIgnore]
        public string IconSqImagePath { get => default; } // 0x0614BF04-0x0614BF8C 
        [MemoryPackIgnore]
        public string SkillCutInImagePath { get => default; } // 0x0614BF8C-0x0614C014 
        [MemoryPackIgnore]
        public MstCharacterInfo CharacterInfo { get; private set; } // 0x0614C014-0x0614C01C 0x0614C01C-0x0614C024

    }

    [MemoryPackable()]
    public partial class MstProduceIdolEvolutionRecipe // TypeDefIndex: 24608
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0614D6AC-0x0614D6B4 0x0614D6B4-0x0614D6BC
        public int GroupId { get; private set; } // 0x0614D6BC-0x0614D6C4 0x0614D6C4-0x0614D6CC
        public int EvolutionLevel { get; private set; } // 0x0614D6CC-0x0614D6D4 0x0614D6D4-0x0614D6DC
        public string[] ProductIdWithAmountList { get; private set; } // 0x0614D6DC-0x0614D6E4 0x0614D6E4-0x0614D6EC
        public int Money { get; private set; } // 0x0614D6EC-0x0614D6F4 0x0614D6F4-0x0614D6FC
    }

    [MemoryPackable()]
    public partial class MstProduceIdolLimitBreakRecipe // TypeDefIndex: 24610
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0614DED8-0x0614DEE0 0x0614DEE0-0x0614DEE8
        public int Star { get; private set; } // 0x0614DEE8-0x0614DEF0 0x0614DEF0-0x0614DEF8
        public int Amount { get; private set; } // 0x0614DEF8-0x0614DF00 0x0614DF00-0x0614DF08
    }

    [MemoryPackable()]
    public partial class MstProducePassiveEffect // TypeDefIndex: 24612
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0614E4A0-0x0614E4A8 0x0614E4A8-0x0614E4B0
        public int MstProducePassiveEffectTypeId { get; private set; } // 0x0614E4B0-0x0614E4B8 0x0614E4B8-0x0614E4C0
        public int[] ValueList { get; private set; } // 0x0614E4C0-0x0614E4C8 0x0614E4C8-0x0614E4D0
    }

    [MemoryPackable()]
    public partial class MstProduceStrategyType // TypeDefIndex: 24614
    {
        // Properties
        public int Id { get; private set; } // 0x0614EC00-0x0614EC08 0x0614EC08-0x0614EC10
        [MemoryPackIgnore]
        public string PolicySelectIconPath { get => default; } // 0x0614EC10-0x0614EC68 

    }

    [MemoryPackable()]
    public partial class MstProductType // TypeDefIndex: 24616
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0614F1B4-0x0614F1BC 0x0614F1BC-0x0614F1C4
        public bool UseCategoricalIcon { get; private set; } // 0x0614F1C4-0x0614F1CC 0x0614F1CC-0x0614F1D8
        public bool VisibleItem { get; private set; } // 0x0614F1D8-0x0614F1E0 0x0614F1E0-0x0614F1EC
    }

    [MemoryPackable()]
    public partial class MstRecoveryDrink // TypeDefIndex: 24618
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0614F7C4-0x0614F7CC 0x0614F7CC-0x0614F7D4
        public int StaminaType { get; private set; } // 0x0614F7D4-0x0614F7DC 0x0614F7DC-0x0614F7E4
        public int Value { get; private set; } // 0x0614F7E4-0x0614F7EC 0x0614F7EC-0x0614F7F4
    }

    [MemoryPackable()]
    public partial class MstSeasonMission // TypeDefIndex: 24620
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0614FD8C-0x0614FD94 0x0614FD94-0x0614FD9C
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x0614FD9C-0x0614FE00 
        [MemoryPackIgnore]
        public string LogoPath { get => default; } // 0x0614FE00-0x0614FE88 
    }

    [MemoryPackable()]
    public partial class MstSelectionTicket // TypeDefIndex: 24622
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06150350-0x06150358 0x06150358-0x06150360
    }

    [MemoryPackable()]
    public partial class MstSelectionTicketProduct // TypeDefIndex: 24624
    {
        // Properties
        public int Id { get; private set; } // 0x06150828-0x06150830 0x06150830-0x06150838
        public int MstExchangeGroupId { get; private set; } // 0x06150838-0x06150840 0x06150840-0x06150848
        public int SortId { get; private set; } // 0x06150848-0x06150850 0x06150850-0x06150858
    }

    [MemoryPackable()]
    public partial class MstSong // TypeDefIndex: 24626
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06150DF0-0x06150DF8 0x06150DF8-0x06150E00
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06150E00-0x06150E64 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x06150E64-0x06150EC8 
        [MemoryPackIgnore]
        public LocalizationKey ReadName { get => default; } // 0x06150EC8-0x06150F2C 
        [MemoryPackIgnore]
        public LocalizationKey Artist { get => default; } // 0x06150F2C-0x06150F90 
        [MemoryPackIgnore]
        public LocalizationKey Lyricist { get => default; } // 0x06150F90-0x06150FF4 
        [MemoryPackIgnore]
        public LocalizationKey Composer { get => default; } // 0x06150FF4-0x06151058 
        [MemoryPackIgnore]
        public LocalizationKey Arranger { get => default; } // 0x06151058-0x061510BC 
        [MemoryPackIgnore]
        public LocalizationKey CueSheet { get => default; } // 0x061510BC-0x06151120 
        [MemoryPackIgnore]
        public LocalizationKey MvScene { get => default; } // 0x06151120-0x06151184 
        public int MstSongTypeId { get; private set; } // 0x06151184-0x0615118C 0x0615118C-0x06151194
        public int MstUnitId { get; private set; } // 0x06151194-0x0615119C 0x0615119C-0x061511A4
        public int MstSongPositionId { get; private set; } // 0x061511A4-0x061511AC 0x061511AC-0x061511B4
        public int SortId { get; private set; } // 0x061511B4-0x061511BC 0x061511BC-0x061511C4
        public int Bpm { get; private set; } // 0x061511C4-0x061511CC 0x061511CC-0x061511D4
        public bool IsAdvanceDownload { get; private set; } // 0x061511D4-0x061511DC 0x061511DC-0x061511E8
        public bool IsSongParts { get; private set; } // 0x061511E8-0x061511F0 0x061511F0-0x061511FC
        public bool IsFocusCamera { get; private set; } // 0x061511FC-0x06151204 0x06151204-0x06151210
        public bool Is3D { get; private set; } // 0x06151210-0x06151218 0x06151218-0x06151224
        public bool Is2D { get; private set; } // 0x06151224-0x0615122C 0x0615122C-0x06151238
        public string PurchaseLink { get; private set; } // 0x06151238-0x06151240 0x06151240-0x06151248
        public System.DateTime PurchaseLinkActiveDate { get; private set; } // 0x06151248-0x06151250 0x06151250-0x06151258
        public bool IsDefault { get; private set; } // 0x06151258-0x06151260 0x06151260-0x0615126C
        public System.DateTime BeginDate { get; private set; } // 0x0615126C-0x06151274 0x06151274-0x0615127C
        [MemoryPackIgnore]
        public string JacketImagePath { get => default; } // 0x0615127C-0x06151304 
        [MemoryPackIgnore]
        public string BackgroundImagePath { get => default; } // 0x06151304-0x0615138C 
    }

    [MemoryPackable()]
    public partial class MstSupportCharacter // TypeDefIndex: 24628
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06151F2C-0x06151F34 0x06151F34-0x06151F3C
        public int MstCharacterId { get; private set; } // 0x06151F3C-0x06151F44 0x06151F44-0x06151F4C
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06151F4C-0x06151FB0 
        public int Rarity { get; private set; } // 0x06151FB0-0x06151FB8 0x06151FB8-0x06151FC0
        public int CardId { get; private set; } // 0x06151FC0-0x06151FC8 0x06151FC8-0x06151FD0
        public int GoodScheduleDetailType { get; private set; } // 0x06151FD0-0x06151FD8 0x06151FD8-0x06151FE0
        public int[] MstPotentialSupportSkillIdList { get; private set; } // 0x06151FE0-0x06151FE8 0x06151FE8-0x06151FF0
        public int[] MstSupportCharacterEventIdList { get; private set; } // 0x06151FF0-0x06151FF8 0x06151FF8-0x06152000
        public int[] MstSupportEffectIdList { get; private set; } // 0x06152000-0x06152008 0x06152008-0x06152010
        public int[] UnlockPremiseLevelList { get; private set; } // 0x06152010-0x06152018 0x06152018-0x06152020
        public System.DateTime ReleaseDate { get; private set; } // 0x06152020-0x06152028 0x06152028-0x06152030
        public string LimitBreakRecipeProductId { get; private set; } // 0x06152030-0x06152038 0x06152038-0x06152040
        [MemoryPackIgnore]
        public string ADVStillImagePath { get => default; } // 0x06152040-0x061520C8 
        [MemoryPackIgnore]
        public string IconRectImagePath { get => default; } // 0x061520C8-0x06152150 
        [MemoryPackIgnore]
        public string IconSqImagePath { get => default; } // 0x06152150-0x061521D8 
        [MemoryPackIgnore]
        public MstCharacterInfo CharacterInfo { get; private set; } // 0x061521D8-0x061521E0 0x061521E0-0x061521E8

    }

    [MemoryPackable()]
    public partial class MstSupportCharacterLevelExp // TypeDefIndex: 24630
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06152F58-0x06152F60 0x06152F60-0x06152F68
        public int Rarity { get; private set; } // 0x06152F68-0x06152F70 0x06152F70-0x06152F78
        public int Level { get; private set; } // 0x06152F78-0x06152F80 0x06152F80-0x06152F88
        public int Exp { get; private set; } // 0x06152F88-0x06152F90 0x06152F90-0x06152F98
    }

    [MemoryPackable()]
    public partial class MstSupportCharacterLimitBreakBonus // TypeDefIndex: 24632
    {
        // Properties
        public int Rarity { get; private set; } // 0x06153584-0x0615358C 0x0615358C-0x06153594
        public int Diamond { get; private set; } // 0x06153594-0x0615359C 0x0615359C-0x061535A4
        public int SkillSlot { get; private set; } // 0x061535A4-0x061535AC 0x061535AC-0x061535B4
        public int LimitLv { get; private set; } // 0x061535B4-0x061535BC 0x061535BC-0x061535C4
    }

    [MemoryPackable()]
    public partial class MstSupportCharacterLimitBreakRecipe // TypeDefIndex: 24634
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06153BB0-0x06153BB8 0x06153BB8-0x06153BC0
        public int Rarity { get; private set; } // 0x06153BC0-0x06153BC8 0x06153BC8-0x06153BD0
        public int Diamond { get; private set; } // 0x06153BD0-0x06153BD8 0x06153BD8-0x06153BE0
        public int Amount { get; private set; } // 0x06153BE0-0x06153BE8 0x06153BE8-0x06153BF0
    }

    [MemoryPackable()]
    public partial class MstSupportEffect // TypeDefIndex: 24636
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06156010-0x06156018 0x06156018-0x06156020
        public int EffectId { get; private set; } // 0x06156020-0x06156028 0x06156028-0x06156030
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06156030-0x06156094 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x06156094-0x061560F8 
        public int[] MstProducePassiveEffectIdList { get; private set; } // 0x061560F8-0x06156100 0x06156100-0x06156108
        public int EntrustAppealType { get; private set; } // 0x06156108-0x06156110 0x06156110-0x06156118
        public int EntrustScore { get; private set; } // 0x06156118-0x06156120 0x06156120-0x06156128
        public int ChoiceWeight { get; private set; } // 0x06156128-0x06156130 0x06156130-0x06156138
    }

    [MemoryPackable()]
    public partial class MstTips // TypeDefIndex: 24638
    {
        // Properties
        public int Id { get; private set; } // 0x061569C0-0x061569C8 0x061569C8-0x061569D0
        public int MstTipsCategoryId { get; private set; } // 0x061569D0-0x061569D8 0x061569D8-0x061569E0
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x061569E0-0x06156A44 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x06156A44-0x06156AA8 
        public int Weight { get; private set; } // 0x06156AA8-0x06156AB0 0x06156AB0-0x06156AB8
    }

    [MemoryPackable()]
    public partial class MstTipsCategory // TypeDefIndex: 24640
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06157050-0x06157058 0x06157058-0x06157060
        [MemoryPackIgnore]
        public LocalizationKey Title { get => default; } // 0x06157060-0x061570C4 
        public string Color { get; private set; } // 0x061570C4-0x061570CC 0x061570CC-0x061570D4
    }

    [MemoryPackable()]
    public partial class MstTitleImage // TypeDefIndex: 24642
    {
        // Properties
        public int Id { get; private set; } // 0x06157774-0x0615777C 0x0615777C-0x06157784
        public string ImageKey { get; private set; } // 0x06157784-0x0615778C 0x0615778C-0x06157794
        public System.DateTime BeginDate { get; private set; } // 0x06157794-0x0615779C 0x0615779C-0x061577A4
        public System.DateTime EndDate { get; private set; } // 0x061577A4-0x061577AC 0x061577AC-0x061577B4
    }

    [MemoryPackable()]
    public partial class MstTrainingTicket // TypeDefIndex: 24644
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0615803C-0x06158044 0x06158044-0x0615804C
        public int ProductType { get; private set; } // 0x0615804C-0x06158054 0x06158054-0x0615805C
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x0615805C-0x061580C0 
        [MemoryPackIgnore]
        public LocalizationKey Description { get => default; } // 0x061580C0-0x06158124 
        public int Exp { get; private set; } // 0x06158124-0x0615812C 0x0615812C-0x06158134
        public int PresentFilterType { get; private set; } // 0x06158134-0x0615813C 0x0615813C-0x06158144
        public int ItemNaviType { get; private set; } // 0x06158144-0x0615814C 0x0615814C-0x06158154
        public int SortId { get; private set; } // 0x06158154-0x0615815C 0x0615815C-0x06158164
        public System.DateTime ReleaseDate { get; private set; } // 0x06158164-0x0615816C 0x0615816C-0x06158174
    }

    [MemoryPackable()]
    public partial class MstTwestaArticle // TypeDefIndex: 24646
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06158880-0x06158888 0x06158888-0x06158890
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06158890-0x061588F4 
        public int MstTwestaUserId { get; private set; } // 0x061588F4-0x061588FC 0x061588FC-0x06158904
        [MemoryPackIgnore]
        public LocalizationKey Body { get => default; } // 0x06158904-0x06158968 
        public int Thumbnail { get; private set; } // 0x06158968-0x06158970 0x06158970-0x06158978
        public bool IsDefault { get; private set; } // 0x06158978-0x06158980 0x06158980-0x0615898C
        [MemoryPackIgnore]
        public string TwestaThumbnailPath { get => default; } // 0x0615898C-0x06158A14 
    }

    [MemoryPackable()]
    public partial class MstTwestaUser // TypeDefIndex: 24648
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06159030-0x06159038 0x06159038-0x06159040
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06159040-0x061590A4 
        [MemoryPackIgnore]
        public LocalizationKey Profile { get => default; } // 0x061590A4-0x06159108 
        public int MstCharacterInfoId { get; private set; } // 0x06159108-0x06159110 0x06159110-0x06159118
    }

    [MemoryPackable()]
    public partial class MstUnit // TypeDefIndex: 24650
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x06159660-0x06159668 0x06159668-0x06159670
        [MemoryPackIgnore]
        public LocalizationKey Name { get => default; } // 0x06159670-0x061596D4 
        public string ColorCode { get; private set; } // 0x061596D4-0x061596DC 0x061596DC-0x061596E4
        [MemoryPackIgnore]
        public string SymbolImagePath { get => default; } // 0x061596E4-0x0615976C 
        [MemoryPackIgnore]
        public string LogoLargeImagePath { get => default; } // 0x0615976C-0x061597F4 
        [MemoryPackIgnore]
        public string IconImagePath { get => default; } // 0x061597F4-0x0615987C 
        [MemoryPackIgnore]
        public string IconWithOutlineImagePath { get => default; } // 0x0615987C-0x06159904 
        [MemoryPackIgnore]
        public string IconSmallImagePath { get => default; } // 0x06159904-0x0615995C 
        [MemoryPackIgnore]
        public string IconExtraLargeImagePath { get => default; } // 0x061599E0-0x06159A68 

    }

    [MemoryPackable()]
    public partial class MstVoiceResource // TypeDefIndex: 24652
    {
        // Properties
        [PrimaryKey]
        public int Id { get; private set; } // 0x0615A108-0x0615A110 0x0615A110-0x0615A118
        [MemoryPackIgnore]
        public LocalizationKey Text { get => default; } // 0x0615A118-0x0615A17C 
        public string CueSheetName { get; private set; } // 0x0615A17C-0x0615A184 0x0615A184-0x0615A18C
        public string CueName { get; private set; } // 0x0615A18C-0x0615A194 0x0615A194-0x0615A19C
    }

    public enum PIdolDetailType // TypeDefIndex: 24446
    {
        Default = 0,
        Other = 1,
        InLive = 2,
        InProduce = 3
    }

    public enum PieceArchiveTabType // TypeDefIndex: 24452
    {
        PI = 0,
        SC = 1
    }

    public static class PopupConst // TypeDefIndex: 24458
    {
        // Fields
        public const string TextKeyOK = "mlPublicText_CommonPopup_00000"; // Metadata: 0x00C3A74F
        public const string TextKeyClose = "mlPublicText_CommonPopup_00001"; // Metadata: 0x00C3A76E
        public const string TextKeyCancel = "mlPublicText_CommonPopup_00002"; // Metadata: 0x00C3A78D
        public const string TextKeyNo = "mlPublicText_CommonPopup_00003"; // Metadata: 0x00C3A7AC
        public const string TextKeyYes = "mlPublicText_CommonPopup_00004"; // Metadata: 0x00C3A7CB
    }

    public static class PopupEnum // TypeDefIndex: 24462
    {
        // Nested types
        public enum PopupSizeType // TypeDefIndex: 24459
        {
            Small = 0,
            Middle = 1,
            Large = 2,
            ExtraLarge = 3,
            Square = 4,
            Tall = 5
        }

        public enum PopupMarkType // TypeDefIndex: 24460
        {
            None = 0,
            Alert = 1,
            Clear = 2
        }

        public enum PopupButtonType // TypeDefIndex: 24461
        {
            Normal = 0,
            Positive = 1,
            Warning = 2,
            Function = 3,
            Purchase = 4
        }
    }

    public static class PresentBoxConst // TypeDefIndex: 24655
    {
        // Fields
        public const int OnceMaxItems = 100; // Metadata: 0x00C3A8BC
        public const int HistoryMasItems = 500; // Metadata: 0x00C3A8BE
        public const string ResourceTagName = "PresentBox"; // Metadata: 0x00C3A8C0
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : System.Attribute // TypeDefIndex: 24653
    {
        // Constructors
        public PrimaryKeyAttribute() { } // 0x0615A9D0-0x0615A9D8
    }

    public static class ProduceConst // TypeDefIndex: 24661
    {
        // Fields
        public const int TutorialEpisodeId = 1000; // Metadata: 0x00C3A938
        public const string RestScenarioIDSuffix = "010025_00"; // Metadata: 0x00C3A93A
        public const string AdviceScenarioIDSuffix = "010026_00"; // Metadata: 0x00C3A944
    }

    public class ProduceEnum // TypeDefIndex: 24663
    {
        // Nested types
        public enum LogItemType // TypeDefIndex: 24662
        {
            None = 0,
            ProducePolicy = 1,
            MainScenario = 2,
            MainIdleScenario = 3,
            UnitCommunicationScenario = 4,
            ProduceIdleScenario = 5,
            SupportCharacterScenario = 6,
            NormalLimitEventScenario = 7,
            SubSeasonEventScenario = 8,
            SubSeasonEventIdleScenario = 9,
            RecommendScenario = 10,
            SupportCooperationEvent = 13,
            Lesson = 14,
            SpecialLesson = 15,
            Working = 16,
            Training = 17,
            Outing = 18,
            Shopping = 19,
            Rest = 20,
            Advice = 21,
            Audition = 22,
            InheritanceSkill = 23,
            VoiceScenarioRest = 24,
            VoiceScenarioAdvice = 25,
            AdvReward = 26,
            MiniLive = 27,
            TalkShow = 28
        }

        // Constructors
        public ProduceEnum() { } // 0x0615ACA0-0x0615ACA8
    }

    public static class ProfileConst // TypeDefIndex: 24664
    {
        // Fields
        public const string FesUnitRankResourceTagName = "ProfileFesUnitRank"; // Metadata: 0x00C3A969
    }

    public enum SCharaDetailType // TypeDefIndex: 24447
    {
        Default = 0,
        Other = 1,
        InProduce = 2
    }

    public static class SeasonMissionConst // TypeDefIndex: 24665
    {
        // Fields
        public const int RankCountMax = 50; // Metadata: 0x00C3A97C
    }

    public class SeasonMissionEnum // TypeDefIndex: 24668
    {
        // Nested types
        public enum AchivedFilter // TypeDefIndex: 24666
        {
            NotAchieved = 0,
            Achieved = 1
        }

        public enum CategoryFilter // TypeDefIndex: 24667
        {
            Character = 0,
            Live = 1,
            Produce = 2,
            Story = 3,
            Other = 4
        }

        // Constructors
        public SeasonMissionEnum() { } // 0x0615ACA8-0x0615ACB0
    }

    public enum SelectFavoriteMarkPopupType // TypeDefIndex: 24449
    {
        ProduceIdol = 0,
        SupportChara = 1,
        FesIdol = 2,
        FesUnit = 3
    }

    public static class ShopConst // TypeDefIndex: 24671
    {
        // Fields
        public const int ChargeLimitUnder16 = 5000; // Metadata: 0x00C3A984
        public const int ChargeLimitUnder18 = 20000; // Metadata: 0x00C3A986
        public const int AgeLimit16 = 16; // Metadata: 0x00C3A98A
        public const int AgeLimit18 = 18; // Metadata: 0x00C3A98B
        public const int MaxPurchaseCount = 99; // Metadata: 0x00C3A98C
        public const int ProductNameLengthPerLine = 16; // Metadata: 0x00C3A98E
        public const int MaxBirthDayStringLength = 8; // Metadata: 0x00C3A98F
        public const int LoginPassValidDays = 29; // Metadata: 0x00C3A990
        public const int HistoryShowDays = 7; // Metadata: 0x00C3A991
        public static readonly int[] ElapsedDaysArrayToPeriodEnd; // 0x00

        // Nested types
        public enum GroupType // TypeDefIndex: 24669
        {
            None = 0,
            Jewel = 1,
            Item = 2,
            SeasonPass = 3,
            LoginPass = 4,
            Costume = 5
        }

        public enum CostumeCategoryType // TypeDefIndex: 24670
        {
            None = 0,
            Private = 1,
            Event = 2
        }

        // Constructors
        static ShopConst() { } // 0x0615ACB0-0x0615AD50
    }

    public class SpecialMissionEnum // TypeDefIndex: 24673
    {
        // Nested types
        public enum MissionMstId // TypeDefIndex: 24672
        {
            BeginnerMission = 1
        }

        // Constructors
        public SpecialMissionEnum() { } // 0x0615AD50-0x0615AD58
    }

    public class ViewEnum // TypeDefIndex: 24464
    {
        // Nested types
        public enum Type // TypeDefIndex: 24463
        {
            Invalid = 0,
            Home = 1
        }

        // Constructors
        public ViewEnum() { } // 0x06123464-0x0612346C
    }

    public enum VoiceCategory // TypeDefIndex: 24442
    {
        Idol = 0,
        ProduceIdol = 1,
        SupportCharacter = 2
    }

    public enum VoicePlayTab // TypeDefIndex: 24444
    {
        Home = 0,
        Produce = 1,
        Live = 2,
        Other = 3
    }

    public static class WeightedRandomPicker // TypeDefIndex: 24677
    {
        // Methods
        public static T Pick<T>(T[] data, Func<T, int> weightSelector) => default;
    }
}
