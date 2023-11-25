using MemoryPack;

namespace PRISM.Definitions
{
    public enum AlbumType
    {
        ProduceIdol = 0,
        SupportCharacter = 1
    }

    public static class BirthdayCharacterId
    {
        // Fields
        public const int AmanaCharactorId = 14;
        public const int TenkaCharactorId = 15;
        public const int HadukiCharactorId = 90;
        public const int ProducerCharactorId = 91;
    }

    public static class BirthdayEnum
    {
        // Nested types
        public enum BirthdayPresentPhase
        {
            First = 0,
            KeyWait = 1,
            Second = 2
        }
    }

    public enum ButtonBadgeType
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

    public enum CategoryElementGridCellViewType
    {
        Category = 0,
        Element = 1
    }

    public static class ChallengeTourConst
    {
        // Fields
        public const string TopResourceTagName = "ChallengeTourTop";
        public const string DetailResourceTagName = "ChallengeTourDetail";
        public const string UnitEditResourceTagName = "ChallengeTourUnitEdit";
        public const string ResultResourceTagName = "ChallengeTourResult";
        public const string FilterTitle = "\u7D5E\u308A\u8FBC\u307F";
        public const string ResultAnimGet = "get";
        public const string ResultAnimStar = "star";

    }

    public static class ChallengeTourEnum
    {
        // Nested types
        public enum StageType
        {
            None = 0,
            Normal = 1,
            Boss = 2
        }

        public enum StageFilterType
        {
            NonStar = 0,
            Star1 = 1,
            Star2 = 2
        }

        public enum PIdilUnitDetailTabType
        {
            ProduceIdol = 0,
            ProduceCard = 1
        }
    }

    public static class CharacterConst
    {
        // Fields
        public const int Hazuki = 90;
        public const int FesIdolLimit = 500;
        public const int FesIdolTransferLimit = 15;
        public const int FesUnitLimit = 100;
        public const int FesUnitTransferLimit = 5;
        public const int MaxUnitMemberCount = 5;
        public const int LiveUnitMaxCount = 20;
        public const int UnitNameMaxLength = 10;
        public const int MaxPieceSelectedNum = 10;
        public const int PieceChangeRate = 1;
        public static readonly Dictionary<int, int> SupportEffectFilterSchedule;
        public static readonly Dictionary<int, HashSet<int>> SupportEffectFilterScheduleDetail;
        public static readonly HashSet<int> ProducePassiveEffectTypeIdNotRefersToSchedule;
        public static readonly HashSet<int> ProducePassiveEffectTypeIdRefersToScheduleDetail;
        public static readonly HashSet<int> ProducePassiveEffectTypeIdRefersToSchedule;
        public static readonly Dictionary<int, HashSet<int>> ScheduleDetailTypeBelongingToScheduleType;
        public const int RequiredItemsNumByGroup = 3;
        public const float FUnitLabelBlinkDuration = 2f;
        public const float TrainingTicketConsumptionMoneyFactor = 0.25f;

    }

    public enum CostumePartType
    {
        Costume = 0,
        HairStyle = 1,
        Accessory = 2
    }

    public class ExchangeConst
    {
        // Fields
        public const int ExchangeIdolPiecePaddingHead = 16;
        public const int ExchangePaddingHead = 60;

        // Nested types
        public enum ExchangeViewType
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

        public enum ExchangeTabType
        {
            None = 0,
            Money = 1,
            IdolPiece = 2,
            StarFragment = 3,
            SeasonMedal = 4,
            SelectionTicket = 5,
            CostumeTicket = 6
        }

        public enum ExchangeClosedReasonType
        {
            None = 0,
            Jump = 1
        }

        // Constructors
        public ExchangeConst() { }
    }

    public static class FrameRateConstants
    {
        // Fields
        public const int Shared = 60;
        public const int WhenPaused = 30;
        public const int ProduceIngame = 30;
        public const int DefaultRenderFPS = 60;
        public const int PowerSavingRenderFPS = 30;
    }

    public static class FriendConst
    {
        // Fields
        public const string ResourceTagName = "Friend";
    }

    public static class FriendEnum
    {
        // Nested types
        public enum CategoryType
        {
            Follow = 0,
            Follower = 1,
            Recommend = 2
        }

        public enum SortCategory
        {
            LoginDate = 0,
            Friend = 1,
            Follow = 2
        }

        public enum SortOrder
        {
            Ascending = 0,
            Descending = 1
        }
    }

    public static class FullSizeOverlayEnum
    {
        // Nested types
        public enum FullSizeOverlayType
        {
            GlobalMenu = 0,
            Shop = 1,
            SeasonMission = 2,
            Friend = 3
        }
    }

    public enum GalleryContents
    {
        Album = 0,
        Costume = 1,
        Voice = 2,
        Movie = 3
    }

    public static class GashaEnum
    {
        // Nested types
        public enum SGashaPhase1FinishAnimationName
        {
            Mot_Gasha_S1_SMP_Finish_R = 0,
            Mot_Gasha_S1_SMP_Finish_SR = 1,
            Mot_Gasha_S1_SMP_Finish_SSR = 2
        }

        public enum GashaResultItemAnimationName
        {
            In_Normal = 0,
            In_PickUP = 1
        }
    }

    public static class GlobalMenuEnum
    {
        // Nested types
        public enum MenuType
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

    public enum HelpListCellType
    {
        Large = 0,
        Small = 1
    }

    public static class HomeConst
    {
        // Fields
        public const string HomeMainResourceTagName = "HomeMain";
        public const string HomeRemindItemResourceTagName = "HomeRemind";
        public const string HomeSettingsResourceTagName = "HomeSettings";
        public const string HomeLoginBonusResourceTagName = "HomeLoginBonus";
        public const string ChallengeTourStageDetailTagName = "ChallengeTourStageDetail";
        public const string HomeMotionPathFormat = "Animations/Character/ScenarioMode/{0}";
        public const int CacheTime = 10;
        public const float CharaMessageOpenMinTime = 10f;
        public const float CharaMessageOpenMaxTime = 20f;
        public const float CharaMessageCloseTime = 1f;
        public const float CharaMessageLeaveActionTime = 60f;
        public const float FirstCharaMessageOpenTime = 1f;
    }

    public static class HomeEnum
    {
        // Nested types
        public enum LoginBonusViewType
        {
            Daily = 0,
            Special = 1,
            Single = 2
        }

        public enum Home3DViewType
        {
            Producer = 0,
            CutScene = 1,
            LoginBonus = 2
        }

        public enum FadeType
        {
            In = 0,
            Out = 1
        }

        public enum LoginBonusSkipType
        {
            None = 0,
            First = 1,
            Second = 2
        }
    }

    public interface ICostume
    {
        // Properties
        int Id { get; }
        LocalizationKey Name { get; }
        LocalizationKey Description { get; }
        LocalizationKey UnlockPremise { get; }
        MstCharacterInfo CharacterInfo { get; }
        int CostumeType { get; }
    }

    public enum IdolListFooterType
    {
        Normal = 0,
        Favorite = 1,
        Transfer = 2
    }

    public enum IdolListTabType
    {
        PI = 0,
        SC = 1,
        FU = 2,
        FI = 3
    }

    public enum IdolVoicePlayListCategory
    {
        IdolCommon = 0,
        IdolCasualCostume = 1,
        ProduceIdol = 2,
        SupportCharacter = 3
    }

    public static class IListExtensions
    {
        // Methods
        public static void Deconstruct<T>(IList<T> list, out T value0, out T value1)
        {
            value0 = default;
            value1 = default;
        }
    }

    public struct LocalizationKey
    {
        // Fields
        public readonly string Category;
        public readonly int Id;

        // Constructors
        public LocalizationKey(string category, int id)
        {
            Category = default;
            Id = default;
        }
    }

    
    [MemoryPackable]
    public partial class MasterData
    {

        // Properties
        public Dictionary<int, MstCharacterInfo> CharacterInfos { get; private set; }
        public Dictionary<int, MstIdol> Idols { get; private set; }
        public Dictionary<int, MstIdolStandingPosition> IdolStandingPositions { get; private set; }
        public Dictionary<int, MstCostumeSet> CostumeSets { get; private set; }
        public Dictionary<int, MstCostume> Costumes { get; private set; }
        public Dictionary<int, MstCostumeResource> CostumeResources { get; private set; }
        public Dictionary<int, MstHairstyle> Hairstyles { get; private set; }
        public Dictionary<ValueTuple<int, int>, MstHairstyleResource> HairstyleResources { get; private set; }
        public Dictionary<int, MstAccessory> Accessories { get; private set; }
        public Dictionary<int, MstAccessoryResource> AccessoryResources { get; private set; }
        public MstFavoriteMark[] FavoriteMarks { get; private set; }
        public Dictionary<int, MstProductType> ProductTypes { get; private set; }
        public Dictionary<int, MstProduceIdolLimitBreakRecipe> ProduceIdolLimitBreakRecipes { get; private set; }
        public Dictionary<int, MstProduceIdolEvolutionRecipe> ProduceIdolEvolutionRecipes { get; private set; }
        public Dictionary<int, MstSupportCharacterLevelExp> SupportCharacterLevelExps { get; private set; }
        public Dictionary<int, MstSupportCharacterLimitBreakRecipe> SupportCharacterLimitBreakRecipes { get; private set; }
        public Dictionary<int, MstOutgameVoiceMotion> OutgameVoiceMotions { get; private set; }
        public Dictionary<int, MstUnit> Units { get; private set; }
        public MstItemProvider[] ItemProviders { get; private set; }
        public Dictionary<int, MstTrainingTicket> TrainingTickets { get; private set; }
        public MstProduceActionEffectDisplay[] ProduceActionEffectDisplays { get; private set; }
        public Dictionary<int, MstVoiceResource> VoiceResources { get; private set; }
        public Dictionary<int, MstSupportEffect> SupportEffects { get; private set; }
        public Dictionary<int, MstProducePassiveEffect> ProducePassiveEffects { get; private set; }
        public MstSupportCharacterLimitBreakBonus[] SupportCharacterLimitBreakBonuses { get; private set; }
        public MstTips[] Tips { get; private set; }
        public Dictionary<int, MstTipsCategory> TipsCategory { get; private set; }
        public MstExchangeProductFilter[] ExchangeProductFilters { get; private set; }
        public MstPotentialLiveSkill[] PotentialLiveSkills { get; private set; }
        public Dictionary<int, MstPotentialLiveSkillLevel> PotentialLiveSkillLevels { get; private set; }
        public Dictionary<int, MstLiveSkillEffect> LiveSkillEffects { get; private set; }
        public Dictionary<int, MstChainGroup> ChainGroups { get; private set; }
        public Dictionary<int, MstPhoneUser> PhoneUsers { get; private set; }
        public Dictionary<int, MstPotentialSupportSkill> PotentialSupportSkills { get; private set; }
        public MstHelp[] Helps { get; private set; }
        public MstBirthdayVoice[] BirthdayVoice { get; private set; }
        public MstHelpGroup[] HelpGroups { get; private set; }
        public Dictionary<int, MstIdolStory> IdolStories { get; private set; }
        public MstTitleImage[] TitleImages { get; private set; }
        public Dictionary<int, MstSong> Songs { get; private set; }
        public MstAdvInfo[] AdvInfos { get; private set; }
        public Dictionary<int, MstTwestaUser> TwestaUsers { get; private set; }
        public Dictionary<int, MstChainUser> ChainUsers { get; private set; }
        public Dictionary<int, MstBannerGenre> BannerGenre { get; private set; }
        public Dictionary<int, MstAchievement> Achievement { get; private set; }
        public Dictionary<int, MstEventIcon> EventIcon { get; private set; }
        public Dictionary<int, MstLoginBonus> LoginBonus { get; private set; }
        public Dictionary<int, MstLoginBonusGraffiti> LoginBonusGraffiti { get; private set; }
        public MstEpisode[] Episodes { get; private set; }
        public MstProduceCardContentGroup[] ProduceCardContentGroups { get; private set; }
        public MstProduceActionEffect[] ProduceActionEffects { get; private set; }
        public Dictionary<int, MstEvent> Events { get; private set; }
        public Dictionary<int, MstProduceIdol> ProduceIdols { get; private set; }
        public Dictionary<int, MstTwestaArticle> TwestaArticles { get; private set; }
        public Dictionary<int, MstSupportCharacter> SupportCharacters { get; private set; }
        public MstGeneralItem[] GeneralItems { get; private set; }
        public Dictionary<int, MstRecoveryDrink> RecoveryDrinks { get; private set; }
        public Dictionary<int, MstEpisodeEventMissionBanner> EpisodeEventMissionBanners { get; private set; }
        public Dictionary<int, MstMainStoryChapter> MainStoryChapters { get; private set; }
        public Dictionary<int, MstMainStory> MainStories { get; private set; }
        public Dictionary<int, MstExtraStoryCategory> ExtraStoryCategories { get; private set; }
        public Dictionary<int, MstExtraStorySubCategory> ExtraStorySubCategories { get; private set; }
        public Dictionary<int, MstExtraStory> ExtraStories { get; private set; }
        public Dictionary<int, MstEventStory> EventStories { get; private set; }
        public Dictionary<int, MstChallengeTourStage> ChallengeTourStages { get; private set; }
        public Dictionary<int, MstChallengeTourMission> ChallengeTourMissions { get; private set; }
        public Dictionary<int, MstChallengeTour> ChallengeTours { get; private set; }
        public MstChallengeTourRival[] ChallengeTourRivals { get; private set; }
        public Dictionary<int, MstSeasonMission> SeasonMissions { get; private set; }
        public Dictionary<string, MstGashaResource> GashaResources { get; private set; }
        public Dictionary<int, MstPhoneCall> PhoneCalls { get; private set; }
        public Dictionary<int, MstGashaTicket> GashaTickets { get; private set; }
        public Dictionary<int, MstGashaCompensationTicket> GashaCompensationTickets { get; private set; }
        public Dictionary<int, MstGashaToken> GashaTokens { get; private set; }
        public Dictionary<int, MstSelectionTicket> SelectionTickets { get; private set; }
        public Dictionary<int, MstCostumeTicket> CostumeTickets { get; private set; }
        public MstProduceStrategyType[] ProduceStrategyTypes { get; private set; }
        public int[] FavoriteMarkIds { get; private set; }

        // Nested types

        public MasterData() { }

        // Methods
        public void BindReferences() { }
    }

    public enum MovieCategory
    {
        ProduceIdol = 0,
        SupportCharacter = 1
    }
    
    [MemoryPackable]
    public partial class MstAccessory : ICostume
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }

        [MemoryPackIgnore]
        public LocalizationKey UnlockPremise { get; }
        public int MstCharacterInfoId { get; private set; }
        public int CostumeType { get; private set; }
        public int AccessoryType { get; private set; }
        public int ResourceId { get; private set; }
        public int SortId { get; private set; }
        public MstCharacterInfo CharacterInfo { get; private set; }
        public MstAccessoryResource Resource { get; private set; }

        // Nested types

        // Constructors
        public MstAccessory() { }

        // Methods
        public void BindReferences(MasterData masterData) { }
    }
    
    [MemoryPackable]
    public partial class MstAccessoryResource
    {

        // Properties
        public int Id { get; private set; }
        public string PrefabName { get; private set; }

        // Nested types

        // Constructors
        public MstAccessoryResource() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstAchievement
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }

        [MemoryPackIgnore]
        public LocalizationKey Condition { get; }
        public int AchievementType { get; private set; }
        public int AchievementCategory { get; private set; }

        [MemoryPackIgnore]
        public string ImagePath { get; }

        // Nested types

        // Constructors
        public MstAchievement() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstAdvInfo
    {

        // Properties
        public string Id { get; private set; }

        // Nested types

        // Constructors
        public MstAdvInfo() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstBannerGenre
    {

        // Properties
        public int Id { get; private set; }
        public string ResourceId { get; private set; }

        [MemoryPackIgnore]
        public string ImagePath { get; }

        // Nested types

        // Constructors
        public MstBannerGenre() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstBirthdayVoice
    {

        // Properties
        public int Id { get; private set; }
        public int MstVoiceResourceId { get; private set; }
        public DateTime ReleaseDate { get; private set; }

        // Nested types

        // Constructors
        public MstBirthdayVoice() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstChainGroup
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }
        public int GroupType { get; private set; }
        public int[] MstChainUserId { get; private set; }

        // Nested types

        // Constructors
        public MstChainGroup() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstChainUser
    {

        // Properties
        public int Id { get; private set; }
        public int MstUnitId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey Profile { get; }
        public int MstCharacterInfoId { get; private set; }

        // Nested types

        // Constructors
        public MstChainUser() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstChallengeTour
    {

        // Properties
        public int Id { get; private set; }
        public int MstUnitId { get; private set; }
        public bool IsDefault { get; private set; }

        [MemoryPackIgnore]
        public string UnitCharaImagePath { get; }

        // Nested types

        // Constructors
        public MstChallengeTour() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstChallengeTourMission
    {

        // Properties
        public int Id { get; private set; }
        public int MissionType { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Text { get; }

        // Nested types

        // Constructors
        public MstChallengeTourMission() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstChallengeTourRival
    {

        // Properties
        public int SilhouetteId { get; private set; }

        [MemoryPackIgnore]
        public string IconImagePath { get; }

        [MemoryPackIgnore]
        public string SilhouettePrefabPath { get; }

        // Nested types

        // Constructors
        public MstChallengeTourRival() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstChallengeTourStage
    {

        // Properties
        public int Id { get; private set; }
        public int MstChallengeTourId { get; private set; }
        public int StageNumber { get; private set; }
        public int StageType { get; private set; }
        public int MstRivalUnitId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }

        // Nested types

        // Constructors
        public MstChallengeTourStage() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstCharacterInfo
    {

        // Properties
        public int Id { get; private set; }
        public int MstUnitId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey FirstName { get; }

        [MemoryPackIgnore]
        public LocalizationKey LastName { get; }
        public string FirstNameRoma { get; private set; }
        public string LastNameRoma { get; private set; }
        public string FirstNameKana { get; private set; }
        public string LastNameKana { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Cv { get; }
        public int Age { get; private set; }
        public string BloodType { get; private set; }
        public string Birthday { get; private set; }
        public string ZodiacSign { get; private set; }
        public string DominantHand { get; private set; }
        public string Birthplace { get; private set; }
        public string Height { get; private set; }
        public string Weight { get; private set; }
        public string ThreeSizes { get; private set; }
        public string Hobby { get; private set; }
        public string SpecialAbility { get; private set; }
        public string Description { get; private set; }
        public string ColorCode { get; private set; }
        public int MstDefaultCasualCostumeSetId { get; private set; }
        public int MstTracksuitLifeSizeCostumeSetId { get; private set; }
        public int MstTracksuitCbCostumeSetId { get; private set; }
        public float Shape { get; private set; }
        public float HeadShape { get; private set; }
        public int MotionType { get; private set; }
        public string LightColorCode { get; private set; }

        [MemoryPackIgnore] public string TipsCharacterImagePath => $"Tips_MiniCharacter_{Id:D2}.png";

        [MemoryPackIgnore] public string CharacterBaseButtonPrefabPath => $"CharacterBaseButton_{Id}.prefab";

        [MemoryPackIgnore] public string BirthdayBackgroundPrefabPath => $"BirthdayBG{Id:D2}.prefab";

        [MemoryPackIgnore]
        public string BirthdayRibbonPath => $"Img_Birthday_Ribon_{Id:D3}.png";

        [MemoryPackIgnore]
        public string BirthdayCharacterNamePath => $"Text_Birthday_ChrName_{Id:D3}.png";

        [MemoryPackIgnore]
        public string SDIconPath => $"Support_SD_{Id:D2}.png";
        public MstCostumeSet DefaultCasualCostumeSet { get; private set; }
        public MstCostumeSet TracksuitLifeSizeCostumeSet { get; private set; }
        public MstCostumeSet TracksuitCbCostumeSet { get; private set; }


        // Methods
        public void BindReferences(MasterData masterData) { }
    }
    
    [MemoryPackable]
    public partial class MstCostume : ICostume
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name => new("mlCostume_Name", Id);

        [MemoryPackIgnore]
        public LocalizationKey Description => new("mlCostume_Name", Id);

        [MemoryPackIgnore]
        public LocalizationKey UnlockPremise => new("mlCostume_UnlockPremise", Id);
        public int MstCharacterInfoId { get; private set; }
        public int CostumeType { get; private set; }
        public int ResourceId { get; private set; }
        public int SortId { get; private set; }
        public MstCharacterInfo CharacterInfo { get; private set; }
        public MstCostumeResource Resource { get; private set; }

        // Nested types

        // Constructors
        public MstCostume() { }

        // Methods
        public void BindReferences(MasterData masterData) { }
    }
    
    [MemoryPackable]
    public partial class MstCostumeResource
    {

        // Properties
        public int Id { get; private set; }
        public string PrefabName { get; private set; }

        // Nested types

        // Constructors
        public MstCostumeResource() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstCostumeSet
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name => new("mlCostumeSet_Name", Id);

        [MemoryPackIgnore]
        public LocalizationKey Description => new("mlCostumeSet_Description", Id);

        [MemoryPackIgnore]
        public LocalizationKey UnlockPremise => new("mlCostumeSet_UnlockPremise", Id);
        public int CostumeType { get; private set; }
        public int MstCostumeId { get; private set; }
        public int MstHairstyleId { get; private set; }
        public int[] MstAccessoryIdList { get; private set; }
        public int SortId { get; private set; }
        public MstCostume Costume { get; private set; }
        public MstHairstyle Hairstyle { get; private set; }
        public MstAccessory[] Accessories { get; private set; }

        // Nested types

        [Serializable]
        private partial class __c
        {
            // Fields
            public static readonly __c __9;
            public static Func<MstAccessory, bool> __9__42_1;

            // Constructors
            static __c() { }
            public __c() { }

            // Methods
            internal bool _BindReferences_b__42_1(MstAccessory x) => default;
        }

        private partial class __c__DisplayClass42_0
        {
            // Fields
            public MasterData masterData;

            // Constructors
            public __c__DisplayClass42_0() { }

            // Methods
            internal MstAccessory _BindReferences_b__0(int id) => default;
        }

        // Constructors
        public MstCostumeSet() { }

        // Methods
        public void BindReferences(MasterData masterData) { }
        public int[] GetAccessoryResourceIds() => default;
    }
    
    [MemoryPackable]
    public partial class MstCostumeTicket
    {

        // Properties
        public int Id { get; private set; }

        // Nested types

        // Constructors
        public MstCostumeTicket() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstEpisode
    {

        // Properties
        public int Id { get; private set; }
        public int MstUnitId { get; private set; }
        public int Chapter { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey MvName => new("mlEpisode_MvName", Id);

        [MemoryPackIgnore]
        public string CircleThumbnailPath => $"Thumb_ProduceEp_Circle_{MstUnitId:D2}_{Id:D2}.png";

        [MemoryPackIgnore]
        public string RectThumbnailPath => $"Thumb_ProduceEp_Rect_{MstUnitId:D2}_{Id:D2}.png";
    }
    
    [MemoryPackable]
    public partial class MstEpisodeEventMissionBanner
    {

        // Properties
        public int Id { get; private set; }
        public int MstEpisodeId { get; private set; }
        public int MstMissionGroupId { get; private set; }

        [MemoryPackIgnore] public string BannerPath => $"produce{Id}_banner.png";
    }
    
    [MemoryPackable]
    public partial class MstEvent
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore] public string LiveEventLogoPath => $"LiveEvent_{Id}_Logo.png";

        [MemoryPackIgnore]
        public string CharacterPrefabPath => $"LiveEvent_{Id}_Prefab.prefab";

        [MemoryPackIgnore]
        public string CharacterImagePath => $"LiveEvent_{Id}_Chara1.prefab";

        [MemoryPackIgnore]
        public string BannerPath => $"LiveEvent_{Id}_Banner_A.png";

        [MemoryPackIgnore]
        public string BackgroundPath => $"LiveEvent_{Id}_Bg.png";

        [MemoryPackIgnore]
        public string MoviePath => $"LiveEvent_{Id}_Movie.usm";

        [MemoryPackIgnore] public string BgmName => $"inst_event_{Id}";

        [MemoryPackIgnore]
        public string EventStoryCategoryThumbnailPath => $"Thumb_EvCat_{Id:D5}.png";

        [MemoryPackIgnore]
        public string EventStoryBackgroundPath => $"Bg_Story_Event_{Id:D5}.png";
    }
    
    [MemoryPackable]
    public partial class MstEventIcon
    {

        // Properties
        public int Id { get; private set; }
        public int Place { get; private set; }
        public string ImageResourceId { get; private set; }
        public string Text { get; private set; }
        public int DisplayCondition { get; private set; }
        public int Priority { get; private set; }

        [MemoryPackIgnore] public string ImagePath => $"EventIcon_{ImageResourceId}.png";
    }
    
    [MemoryPackable]
    public partial class MstEventStory
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore] public LocalizationKey Title => new("mlStory_EventStoryTitle", Id);

        [MemoryPackIgnore]
        public LocalizationKey Episode => new("mlStory_EventStoryEpisode", Id);
        public int MstEventId { get; private set; }
        public int EpisodeType { get; private set; }
        public int SortId { get; private set; }
        public int[] MstCharacterInfoIdList { get; private set; }
        public int UnlockPremiseMstEventStoryId { get; private set; }
        public int UnlockPremiseEventPoint { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public int PreviousMstEventStoryId { get; private set; }

        [MemoryPackIgnore] public string ThumbnailPath => $"Thumb_EvEp_{Id:D6}.png";
    }
    
    [MemoryPackable]
    public partial class MstExchangeProductFilter
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name => new("mlExchangeFilter_FilterName", Id);
    }
    
    [MemoryPackable]
    public partial class MstExtraStory
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title => new("mlExtraStory_ExtraStoryTitle", Id);
        public int ExtraStoryType { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Episode => new("mlExtraStory_ExtraStoryEpisode", Id);
        public int MstExtraStorySubCategoryId { get; private set; }
        public int SortId { get; private set; }
        public string ScenarioId { get; private set; }
        public int[] MstCharacterInfoIdList { get; private set; }
        public int UnlockPremiseMstExtraStoryId { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public int PreviousMstExtraStoryId { get; private set; }

        [MemoryPackIgnore]
        public string ThumbnailPath => $"Thumb_ExEp_{Id:D6}.png";
    }
    
    [MemoryPackable]
    public partial class MstExtraStoryCategory
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title => new("mlExtraStory_ExtraStoryTitle", Id);
        public DateTime ReleaseDate { get; private set; }

        [MemoryPackIgnore] public string ThumbnailPath => $"Thumb_ExCat_{Id:D5}.png";
    }
    
    [MemoryPackable]
    public partial class MstExtraStorySubCategory
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title { get; }
        public int MstExtraStoryCategoryId { get; private set; }
        public DateTime ReleaseDate { get; private set; }

        [MemoryPackIgnore]
        public string ThumbnailPath { get; }

        [MemoryPackIgnore]
        public string ExtraStoryBackgroundPath { get; }

        // Nested types

        // Constructors
        public MstExtraStorySubCategory() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstFavoriteMark
    {

        // Properties
        public int Id { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstGashaCompensationTicket
    {

        // Properties
        public int Id { get; private set; }
        public int SortId { get; private set; }
        public string[] GashaResourceIdList { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstGashaResource
    {

        // Properties
        public string Id { get; private set; }
        public string[] MovieList { get; private set; }
        public string[] MovieValueList { get; private set; }
        public string[] ImageList { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstGashaTicket
    {

        // Properties
        public int Id { get; private set; }
        public int SortId { get; private set; }
        public string[] GashaResourceIdList { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstGashaToken
    {

        // Properties
        public int Id { get; private set; }
        public int SortId { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstGeneralItem
    {

        // Properties
        public int ProductType { get; private set; }
        public int Id { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstHairstyle : ICostume
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }

        [MemoryPackIgnore]
        public LocalizationKey UnlockPremise { get; }
        public int MstCharacterInfoId { get; private set; }
        public int CostumeType { get; private set; }
        public int HairResourceIdForClient { get; private set; }
        public int[] HairAccessoryResourceIdListForClient { get; private set; }
        public int SortId { get; private set; }
        public MstCharacterInfo CharacterInfo { get; private set; }
        public MstHairstyleResource HairResource { get; private set; }
        public MstAccessoryResource[] HairAccessoryResources { get; private set; }

        public void BindReferences(MasterData masterData) { }
    }
    
    [MemoryPackable]
    public partial class MstHairstyleResource
    {

        // Properties
        public int MstCharacterInfoId { get; private set; }
        public int StyleType { get; private set; }
        public int HairId { get; private set; }
        public int HeadWearId { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstHelp
    {

        // Properties
        public int Id { get; private set; }
        public int SortId { get; private set; }
        public int MstHelpGroupId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey HelpTitle { get; }

        [MemoryPackIgnore]
        public LocalizationKey HelpBody { get; }
        public bool IsMobile { get; private set; }
        public bool IsGpg { get; private set; }
        public bool IsDmm { get; private set; }
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstHelpGroup
    {

        // Properties
        public int Id { get; private set; }
        public int SortId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey HelpGroupTitle { get; }
        public int HelpType { get; private set; }
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstIdol
    {

        // Properties
        public int Id { get; private set; }
        public int MstDefaultLiveCostumeSetId { get; private set; }
        public MstCostumeSet DefaultLiveCostumeSet { get; private set; }

        public void BindReferences(MasterData masterData) { }
    }
    
    [MemoryPackable]
    public partial class MstIdolStandingPosition
    {

        // Properties
        public int MstUnitId { get; private set; }
        public int[] Order { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstIdolStory
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title { get; }

        [MemoryPackIgnore]
        public LocalizationKey Episode { get; }
        public int MstIdolId { get; private set; }
        public int SortId { get; private set; }
        public int[] MstCharacterInfoIdList { get; private set; }
        public int UnlockPremiseMstIdolStoryId { get; private set; }
        public int UnlockPremiseIdolBaseDearness { get; private set; }
        public string[] RewardProductList { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public int PreviousMstIdolStoryId { get; private set; }

        [MemoryPackIgnore]
        public string ThumbnailPath { get; }
    }
    
    [MemoryPackable]
    public partial class MstItemProvider
    {

        // Properties
        public int Id { get; private set; }
        public string ProductId { get; private set; }
        public int ProviderType { get; private set; }
        public string ProviderParameter { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey ScreenTitle { get; }

        [MemoryPackIgnore]
        public LocalizationKey ScreenTab { get; }
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstLiveSkillEffect
    {

        // Properties
        public int Id { get; private set; }
        public int LiveSkillType { get; private set; }
        public int EffectValue { get; private set; }
        public int EffectValue2 { get; private set; }
        public int EffectValue3 { get; private set; }
        public int EffectValue4 { get; private set; }
        public int EffectTime { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstLoginBonus
    {

        // Properties
        public int Id { get; private set; }
        public string Title { get; private set; }
        public int LoginBonusType { get; private set; }
        public int DisplayPriority { get; private set; }

        [MemoryPackIgnore]
        public string TitleImagePath { get; }

        [MemoryPackIgnore]
        public string BgImagePath { get; }
    }
    
    [MemoryPackable]
    public partial class MstLoginBonusGraffiti
    {

        // Properties
        public int Id { get; private set; }
        public int MstLoginBonusId { get; private set; }
        public string[] ResourceIdList { get; private set; }
    }
    
    [MemoryPackable]
    public partial class MstMainStory
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title { get; }

        [MemoryPackIgnore]
        public LocalizationKey Episode { get; }
        public int MstMainStoryChapterId { get; private set; }
        public int SortId { get; private set; }
        public int[] MstCharacterInfoIdList { get; private set; }
        public int UnlockPremiseMstMainStoryId { get; private set; }
        public string[] RewardProductList { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public int PreviousMstMainStoryId { get; private set; }

        [MemoryPackIgnore]
        public string ThumbnailPath { get; }
    }
    
    [MemoryPackable]
    public partial class MstMainStoryChapter
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title { get; }
        public int MstUnitId { get; private set; }
        public DateTime ReleaseDate { get; private set; }

        [MemoryPackIgnore]
        public string ThumbnailPath { get; }

        [MemoryPackIgnore]
        public string MainStoryBackgroundPath { get; }
    }
    
    [MemoryPackable]
    public partial class MstOutgameVoiceMotion
    {

        // Properties
        public int Id { get; private set; }
        public int MstCharacterInfoId { get; private set; }
        public int ScreenType { get; private set; }
        public int MstProduceIdolId { get; private set; }
        public int MstSupportCharacterId { get; private set; }
        public bool ReachedGrowthLimit { get; private set; }
        public int MstVoiceResourceId { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public MstVoiceResource Voice { get; private set; }

        public void BindReferences(MasterData masterData) { }
    }
    
    [MemoryPackable]
    public partial class MstPhoneCall
    {

        // Properties
        public int Id { get; private set; }
        public int MstPhoneUserId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title { get; }
        public int TypeId { get; private set; }
        public int ScenarioId { get; private set; }
        public int ScenarioNumber { get; private set; }

        [MemoryPackIgnore]
        public string CueSheetName { get; }

        // Nested types

        // Constructors
        public MstPhoneCall() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstPhoneUser
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }
        public int MstCharacterInfoId { get; private set; }

        // Nested types

        // Constructors
        public MstPhoneUser() { }

        // Methods
    }

    public static class MstPhoneUserExtensions
    {
        // Methods
        public static bool IsProducer(MstPhoneUser mstPhoneUser) => default;
    }
    
    [MemoryPackable]
    public partial class MstPotentialLiveSkill
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title { get; }

        // Nested types

        // Constructors
        public MstPotentialLiveSkill() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstPotentialLiveSkillLevel
    {

        // Properties
        public int Id { get; private set; }
        public int MstPotentialLiveSkillId { get; private set; }
        public int Level { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }
        public int[] MstLiveSkillEffectIdList { get; private set; }

        // Nested types

        // Constructors
        public MstPotentialLiveSkillLevel() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstPotentialSupportSkill
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }
        public int MstSupportSkillTypeId { get; private set; }
        public int[] ValueList { get; private set; }
        public int MstSkillBufferDisplayId { get; private set; }
        public int EntrustAppealType { get; private set; }
        public int EntrustScore { get; private set; }

        [MemoryPackIgnore]
        public string SupportSkillIconImagePath { get; }

        // Nested types

        // Constructors
        public MstPotentialSupportSkill() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstProduceActionEffect
    {

        // Properties
        public int IconId { get; private set; }

        [MemoryPackIgnore]
        public string IconImagePath { get; }

        // Nested types

        // Constructors
        public MstProduceActionEffect() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstProduceActionEffectDisplay
    {

        // Properties
        public int Id { get; private set; }

        // Nested types

        // Constructors
        public MstProduceActionEffectDisplay() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstProduceCardContentGroup
    {

        // Properties
        public int MstProduceCardId { get; private set; }
        public int MstProduceCardContentGroupTypeId { get; private set; }

        [MemoryPackIgnore]
        public string CardImagePath { get; }

        [MemoryPackIgnore]
        public string Phase1CardImagePath { get; }

        [MemoryPackIgnore]
        public string Phase2CardImagePath { get; }

        // Nested types

        // Constructors
        public MstProduceCardContentGroup() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstProduceIdol
    {

        // Properties
        public int Id { get; private set; }
        public int MstIdolId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }
        public int InitialStar { get; private set; }
        public int CardId { get; private set; }
        public int InitialVocal { get; private set; }
        public int InitialDance { get; private set; }
        public int InitialVisual { get; private set; }
        public int InitialMental { get; private set; }
        public int LimitVocal { get; private set; }
        public int LimitDance { get; private set; }
        public int LimitVisual { get; private set; }
        public int LimitMental { get; private set; }
        public int MstStarGrowthId { get; private set; }
        public int Cost { get; private set; }
        public int[] MstIdolSkillIdList { get; private set; }
        public int[] IdolSkillPremiseEvolutionLevelList { get; private set; }
        public int[] MstPotentialLiveSkillIdList { get; private set; }
        public int[] PotentialLiveSkillPremiseStarList { get; private set; }
        public int[] CostumeSetIdList { get; private set; }
        public int[] CostumeSetPremiseStarList { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string LimitBreakRecipeProductId { get; private set; }
        public int EvolutionRecipeGroupId { get; private set; }
        public string[] MstIdolSkillForMstProduceIdolList { get; private set; }
        public string[] MstPotentialLiveSkillForMstProduceIdolList { get; private set; }
        public string[] MstDressSetForMstProduceIdolList { get; private set; }
        public int GashaVoiceMstVoiceResourceId { get; private set; }
        public int GashaSeMstVoiceResourceId { get; private set; }

        [MemoryPackIgnore]
        public string AlignedFacePrefabPath { get; }

        [MemoryPackIgnore]
        public string StandingImagePath { get; }

        [MemoryPackIgnore]
        public string IconRectImagePath { get; }

        [MemoryPackIgnore]
        public string IconSqImagePath { get; }

        [MemoryPackIgnore]
        public string SkillCutInImagePath { get; }
        public MstCharacterInfo CharacterInfo { get; private set; }

        // Nested types

        // Constructors
        public MstProduceIdol() { }

        // Methods
        public void BindReferences(MasterData masterData) { }
    }
    
    [MemoryPackable]
    public partial class MstProduceIdolEvolutionRecipe
    {

        // Properties
        public int Id { get; private set; }
        public int GroupId { get; private set; }
        public int EvolutionLevel { get; private set; }
        public string[] ProductIdWithAmountList { get; private set; }
        public int Money { get; private set; }

        // Nested types

        // Constructors
        public MstProduceIdolEvolutionRecipe() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstProduceIdolLimitBreakRecipe
    {

        // Properties
        public int Id { get; private set; }
        public int Star { get; private set; }
        public int Amount { get; private set; }

        // Nested types

        // Constructors
        public MstProduceIdolLimitBreakRecipe() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstProducePassiveEffect
    {

        // Properties
        public int Id { get; private set; }
        public int MstProducePassiveEffectTypeId { get; private set; }
        public int[] ValueList { get; private set; }

        // Nested types

        // Constructors
        public MstProducePassiveEffect() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstProduceStrategyType
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public string PolicySelectIconPath { get; }

        // Nested types

        // Constructors
        public MstProduceStrategyType() { }

        // Methods
        public static string GetPolicySelectIconPath(int id) => default;
    }
    
    [MemoryPackable]
    public partial class MstProductType
    {

        // Properties
        public int Id { get; private set; }
        public bool UseCategoricalIcon { get; private set; }
        public bool VisibleItem { get; private set; }

        // Nested types

        // Constructors
        public MstProductType() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstRecoveryDrink
    {

        // Properties
        public int Id { get; private set; }
        public int StaminaType { get; private set; }
        public int Value { get; private set; }

        // Nested types

        // Constructors
        public MstRecoveryDrink() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstSeasonMission
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public string LogoPath { get; }

        // Nested types

        // Constructors
        public MstSeasonMission() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstSelectionTicket
    {

        // Properties
        public int Id { get; private set; }

        // Nested types

        // Constructors
        public MstSelectionTicket() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstSelectionTicketProduct
    {

        // Properties
        public int Id { get; private set; }
        public int MstExchangeGroupId { get; private set; }
        public int SortId { get; private set; }

        // Nested types

        // Constructors
        public MstSelectionTicketProduct() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstSong
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }

        [MemoryPackIgnore]
        public LocalizationKey ReadName { get; }

        [MemoryPackIgnore]
        public LocalizationKey Artist { get; }

        [MemoryPackIgnore]
        public LocalizationKey Lyricist { get; }

        [MemoryPackIgnore]
        public LocalizationKey Composer { get; }

        [MemoryPackIgnore]
        public LocalizationKey Arranger { get; }

        [MemoryPackIgnore]
        public LocalizationKey CueSheet { get; }

        [MemoryPackIgnore]
        public LocalizationKey MvScene { get; }
        public int MstSongTypeId { get; private set; }
        public int MstUnitId { get; private set; }
        public int MstSongPositionId { get; private set; }
        public int SortId { get; private set; }
        public int Bpm { get; private set; }
        public bool IsAdvanceDownload { get; private set; }
        public bool IsSongParts { get; private set; }
        public bool IsFocusCamera { get; private set; }
        public bool Is3D { get; private set; }
        public bool Is2D { get; private set; }
        public string PurchaseLink { get; private set; }
        public DateTime PurchaseLinkActiveDate { get; private set; }
        public bool IsDefault { get; private set; }
        public DateTime BeginDate { get; private set; }

        [MemoryPackIgnore]
        public string JacketImagePath { get; }

        [MemoryPackIgnore]
        public string BackgroundImagePath { get; }

        // Nested types

        // Constructors
        public MstSong() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstSupportCharacter
    {

        // Properties
        public int Id { get; private set; }
        public int MstCharacterId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }
        public int Rarity { get; private set; }
        public int CardId { get; private set; }
        public int GoodScheduleDetailType { get; private set; }
        public int[] MstPotentialSupportSkillIdList { get; private set; }
        public int[] MstSupportCharacterEventIdList { get; private set; }
        public int[] MstSupportEffectIdList { get; private set; }
        public int[] UnlockPremiseLevelList { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string LimitBreakRecipeProductId { get; private set; }

        [MemoryPackIgnore]
        public string ADVStillImagePath { get; }

        [MemoryPackIgnore]
        public string IconRectImagePath { get; }

        [MemoryPackIgnore]
        public string IconSqImagePath { get; }
        public MstCharacterInfo CharacterInfo { get; private set; }

        // Nested types

        // Constructors
        public MstSupportCharacter() { }

        // Methods
        public void BindReferences(MasterData masterData) { }
    }
    
    [MemoryPackable]
    public partial class MstSupportCharacterLevelExp
    {

        // Properties
        public int Id { get; private set; }
        public int Rarity { get; private set; }
        public int Level { get; private set; }
        public int Exp { get; private set; }

        // Nested types

        // Constructors
        public MstSupportCharacterLevelExp() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstSupportCharacterLimitBreakBonus
    {

        // Properties
        public int Rarity { get; private set; }
        public int Diamond { get; private set; }
        public int SkillSlot { get; private set; }
        public int LimitLv { get; private set; }

        // Nested types

        // Constructors
        public MstSupportCharacterLimitBreakBonus() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstSupportCharacterLimitBreakRecipe
    {

        // Properties
        public int Id { get; private set; }
        public int Rarity { get; private set; }
        public int Diamond { get; private set; }
        public int Amount { get; private set; }

        // Nested types

        // Constructors
        public MstSupportCharacterLimitBreakRecipe() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstSupportEffect
    {

        // Properties
        public int Id { get; private set; }
        public int EffectId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }
        public int[] MstProducePassiveEffectIdList { get; private set; }
        public int EntrustAppealType { get; private set; }
        public int EntrustScore { get; private set; }
        public int ChoiceWeight { get; private set; }

        // Nested types

        // Constructors
        public MstSupportEffect() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstTips
    {

        // Properties
        public int Id { get; private set; }
        public int MstTipsCategoryId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title { get; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }
        public int Weight { get; private set; }

        // Nested types

        // Constructors
        public MstTips() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstTipsCategory
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Title { get; }
        public string Color { get; private set; }

        // Nested types

        // Constructors
        public MstTipsCategory() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstTitleImage
    {

        // Properties
        public int Id { get; private set; }
        public string ImageKey { get; private set; }
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }

        // Nested types

        // Constructors
        public MstTitleImage() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstTrainingTicket
    {

        // Properties
        public int Id { get; private set; }
        public int ProductType { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey Description { get; }
        public int Exp { get; private set; }
        public int PresentFilterType { get; private set; }
        public int ItemNaviType { get; private set; }
        public int SortId { get; private set; }
        public DateTime ReleaseDate { get; private set; }

        // Nested types

        // Constructors
        public MstTrainingTicket() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstTwestaArticle
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }
        public int MstTwestaUserId { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Body { get; }
        public int Thumbnail { get; private set; }
        public bool IsDefault { get; private set; }

        [MemoryPackIgnore]
        public string TwestaThumbnailPath { get; }

        // Nested types

        // Constructors
        public MstTwestaArticle() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstTwestaUser
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }

        [MemoryPackIgnore]
        public LocalizationKey Profile { get; }
        public int MstCharacterInfoId { get; private set; }

        // Nested types

        // Constructors
        public MstTwestaUser() { }

        // Methods
    }
    
    [MemoryPackable]
    public partial class MstUnit
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Name { get; }
        public string ColorCode { get; private set; }

        [MemoryPackIgnore]
        public string SymbolImagePath { get; }

        [MemoryPackIgnore]
        public string LogoLargeImagePath { get; }

        [MemoryPackIgnore]
        public string IconImagePath { get; }

        [MemoryPackIgnore]
        public string IconWithOutlineImagePath { get; }

        [MemoryPackIgnore]
        public string IconSmallImagePath { get; }

        [MemoryPackIgnore]
        public string IconExtraLargeImagePath { get; }

        // Nested types

        // Constructors
        public MstUnit() { }

        // Methods
        public static string GetIconSmallImagePath(int unitId) => default;
    }
    
    [MemoryPackable]
    public partial class MstVoiceResource
    {

        // Properties
        public int Id { get; private set; }

        [MemoryPackIgnore]
        public LocalizationKey Text { get; }
        public string CueSheetName { get; private set; }
        public string CueName { get; private set; }

        // Nested types

        // Constructors
        public MstVoiceResource() { }

        // Methods
    }

    public enum PIdolDetailType
    {
        Default = 0,
        Other = 1,
        InLive = 2,
        InProduce = 3
    }

    public enum PieceArchiveTabType
    {
        PI = 0,
        SC = 1
    }

    public static class PopupConst
    {
        // Fields
        public const string TextKeyOK = "mlPublicText_CommonPopup_00000";
        public const string TextKeyClose = "mlPublicText_CommonPopup_00001";
        public const string TextKeyCancel = "mlPublicText_CommonPopup_00002";
        public const string TextKeyNo = "mlPublicText_CommonPopup_00003";
        public const string TextKeyYes = "mlPublicText_CommonPopup_00004";
    }

    public static class PopupEnum
    {
        // Nested types
        public enum PopupSizeType
        {
            Small = 0,
            Middle = 1,
            Large = 2,
            ExtraLarge = 3,
            Square = 4,
            Tall = 5
        }

        public enum PopupMarkType
        {
            None = 0,
            Alert = 1,
            Clear = 2
        }

        public enum PopupButtonType
        {
            Normal = 0,
            Positive = 1,
            Warning = 2,
            Function = 3,
            Purchase = 4
        }
    }

    public static class PresentBoxConst
    {
        // Fields
        public const int OnceMaxItems = 100;
        public const int HistoryMasItems = 500;
        public const string ResourceTagName = "PresentBox";
    }

    public class PrimaryKeyAttribute : Attribute
    {
        // Constructors
        public PrimaryKeyAttribute() { }
    }

    public static class ProduceConst
    {
        // Fields
        public const int TutorialEpisodeId = 1000;
        public const string RestScenarioIDSuffix = "010025_00";
        public const string AdviceScenarioIDSuffix = "010026_00";
    }

    public class ProduceEnum
    {
        // Nested types
        public enum LogItemType
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
        public ProduceEnum() { }
    }

    public static class ProfileConst
    {
        // Fields
        public const string FesUnitRankResourceTagName = "ProfileFesUnitRank";
    }

    public enum SCharaDetailType
    {
        Default = 0,
        Other = 1,
        InProduce = 2
    }

    public static class SeasonMissionConst
    {
        // Fields
        public const int RankCountMax = 50;
    }

    public class SeasonMissionEnum
    {
        // Nested types
        public enum AchivedFilter
        {
            NotAchieved = 0,
            Achieved = 1
        }

        public enum CategoryFilter
        {
            Character = 0,
            Live = 1,
            Produce = 2,
            Story = 3,
            Other = 4
        }

        // Constructors
        public SeasonMissionEnum() { }
    }

    public enum SelectFavoriteMarkPopupType
    {
        ProduceIdol = 0,
        SupportChara = 1,
        FesIdol = 2,
        FesUnit = 3
    }

    public static class ShopConst
    {
        // Fields
        public const int ChargeLimitUnder16 = 5000;
        public const int ChargeLimitUnder18 = 20000;
        public const int AgeLimit16 = 16;
        public const int AgeLimit18 = 18;
        public const int MonthlyChargeAlert = 100000;
        public const int MaxPurchaseCount = 99;
        public const int ProductNameLengthPerLine = 16;
        public const int MaxBirthDayStringLength = 8;
        public const int LoginPassValidDays = 29;
        public const int HistoryShowDays = 7;
        public static readonly int[] ElapsedDaysArrayToPeriodEnd;

        // Nested types
        public enum GroupType
        {
            None = 0,
            Jewel = 1,
            Item = 2,
            SeasonPass = 3,
            LoginPass = 4,
            Costume = 5
        }

        public enum CostumeCategoryType
        {
            None = 0,
            Private = 1,
            Event = 2
        }

    }

    public class SpecialMissionEnum
    {
        // Nested types
        public enum MissionMstId
        {
            BeginnerMission = 1
        }

        // Constructors
        public SpecialMissionEnum() { }
    }
    public class ViewEnum
    {
        // Nested types
        public enum Type
        {
            Invalid = 0,
            Home = 1
        }

        // Constructors
        public ViewEnum() { }
    }

    public enum VoiceCategory
    {
        Idol = 0,
        ProduceIdol = 1,
        SupportCharacter = 2
    }

    public enum VoicePlayTab
    {
        Home = 0,
        Produce = 1,
        Live = 2,
        Other = 3
    }
}
