using static SSR_Music_Packer_GUI.Areas;

namespace SSR_Music_Packer_GUI;
public static class Areas {
    public enum Area {
        Reactor,
        Medical,
        MedicalBeta,
        Research,
        Maintenance,
        Storage,
        FlightDeck,
        Executive,
        SysEngineering,
        Security,
        Bridge,
        Cyberspace,
        Elevator,
        AlphaGrove,
        BetaGrove,
        DeltaGrove,
        MainMenu,
        IntroCutscene/*,
        EndCreditsSong1,
        EndCreditsSong2*/
    }

    public static bool IsSpecialScene(Area area) {
        return area == Area.IntroCutscene /*|| area == Area.EndCreditsSong1 || area == Area.EndCreditsSong2*/;
    }

    public static Dictionary<Area, Area> GetDefaultMusicSharingMap() {
        return new Dictionary<Area, Area>() {
            { Area.Reactor, Area.Reactor },
            { Area.Medical, Area.Medical },
            { Area.MedicalBeta, Area.MedicalBeta },
            { Area.Research, Area.Research },
            { Area.Maintenance, Area.Maintenance },
            { Area.Storage, Area.Research },
            { Area.FlightDeck, Area.Reactor },
            { Area.Executive, Area.Executive },
            { Area.SysEngineering, Area.Reactor },
            { Area.Security, Area.Security },
            { Area.Bridge, Area.Bridge },
            { Area.Cyberspace, Area.Cyberspace },
            { Area.Elevator, Area.Elevator },
            { Area.AlphaGrove, Area.AlphaGrove },
            { Area.BetaGrove, Area.AlphaGrove },
            { Area.DeltaGrove, Area.AlphaGrove },
            { Area.MainMenu, Area.MainMenu },
            { Area.IntroCutscene, Area.IntroCutscene }/*,
            { Area.EndCreditsSong1, Area.EndCreditsSong1 },
            { Area.EndCreditsSong2, Area.EndCreditsSong2 },*/
        };
    }

    public static Dictionary<Area, Area> musicSharingMap = GetDefaultMusicSharingMap();

    public static Dictionary<Area, AreaMusicData> GetDefaultPaths() {
        return new Dictionary<Area, AreaMusicData>() {
            { Area.Reactor,      new()},
            { Area.Research,     new()},
            { Area.Maintenance,  new()},
            { Area.Storage,      new()},
            { Area.FlightDeck,   new()},
            { Area.SysEngineering,new()},
            { Area.Security,     new()},
            { Area.Bridge,       new()},
            { Area.Cyberspace,   new()},
            { Area.Elevator,     new()},
            { Area.AlphaGrove,   new()},
            { Area.BetaGrove,    new()},
            { Area.DeltaGrove,   new()},
            { Area.Medical,      new()},
            { Area.MedicalBeta,  new()},
            { Area.Executive,    new()},
            { Area.MainMenu,     new()},
            { Area.IntroCutscene,new(_Volume: 1.80f)}
        };
        /*{Area.Reactor,      new(_InputMusic_Main_FileName: "reactor.ogg")},
        {Area.Research,     new(_InputMusic_Intro_FileName: "research_intro.ogg", _InputMusic_Main_FileName: "research_main.ogg")},
        {Area.Maintenance,  new(_PreDelayMeasures: 2, _PostDelayMeasures: 8, _InputMusic_Main_FileName: "maintenance.ogg")},
        {Area.Storage,      new(_InputMusic_Intro_FileName: "", _InputMusic_Main_FileName: "storage.ogg")},
        {Area.FlightDeck,   new(_InputMusic_Main_FileName:  "flightdeck.ogg")},
        {Area.SysEngineering,new(_InputMusic_Main_FileName:  "engineering.ogg")},
        {Area.Security,     new(_InputMusic_Main_FileName:  "security.ogg")},
        {Area.Bridge,       new(_InputMusic_Main_FileName:  "bridge.ogg")},
        {Area.Cyberspace,   new(_InputMusic_Intro_FileName: "cyber_intro.ogg", _InputMusic_Main_FileName: "cyber_main.ogg")},
        {Area.Elevator,     new(_InputMusic_Main_FileName:  "elevator.ogg")},
        {Area.AlphaGrove,   new(_InputMusic_Main_FileName:  "alphagrove.ogg")},
        {Area.BetaGrove,    new(_InputMusic_Main_FileName:  "betagrove.ogg")},
        {Area.DeltaGrove,   new(_InputMusic_Main_FileName:  "deltagrove.ogg")},
        {Area.Medical,      new(_InputMusic_Main_FileName:  "medical.ogg")},
        {Area.MedicalBeta,  new(_InputMusic_Main_FileName:  "medbeta.ogg")},
        {Area.Executive,    new(_InputMusic_Main_FileName:  "executive.ogg")},
        {Area.MainMenu,     new(_InputMusic_Main_FileName:  "mainmenu.ogg")},
        {Area.IntroCutscene,new(_InputMusic_Main_FileName:  "introcutscene.ogg")}*//*,
        {Area.EndCreditsSong1,new(_InputMusic_Main_FileName:"endcreditssong1.ogg")},
        {Area.EndCreditsSong2,new(_InputMusic_Main_FileName:"endcreditssong2.ogg")},*/
    }

//Some soundclasses are custom and do not exist in the vanilla game
public static Dictionary<Area, AreaInfo> GeneralAreaInfo = new Dictionary<Area, AreaInfo>() {
        {Area.Reactor,      new(_FolderName:"Reactor",      _Cue:"BP_MusicCue_Reactor_58_4-4",      _LayerTable:"DT_MusicLayers_Reactor",           _MusicData:"CustomReactorMusic",            _SoundClass:"MX_Reactor")},
        {Area.Research,     new(_FolderName:"Research",     _Cue:"BP_MusicCue_Research_Exploration_77_4-4",_LayerTable:"DT_MusicLayers_Research_Exploration",_MusicData:"CustomResearchMusic",  _SoundClass:"Research")},
        {Area.Maintenance,  new(_FolderName:"Maintenance",  _Cue:"BP_MusicCue_Maintenance_68_4-4",  _LayerTable:"DT_MusicLayers_Maintenance",       _MusicData:"CustomMaintenanceMusic",        _SoundClass:"MX_Maintenance")},
        {Area.Storage,      new(_FolderName:"Storage",      _Cue:"BP_MusicCue_Storage_70_4-4",      _LayerTable:"DT_MusicLayers_Storage",           _MusicData:"CustomStorageMusic",            _SoundClass:"MX_Storage")},
        {Area.FlightDeck,   new(_FolderName:"FlightDeck",   _Cue:"BP_MusicCue_FlightDeck_74_4-4",   _LayerTable:"DT_MusicLayers_FlightDeck",        _MusicData:"CustomFlightDeckMusic",         _SoundClass:"MX_FlightDeck")},
        {Area.SysEngineering,new(_FolderName:"SysEngineering",_Cue:"BP_MusicCue_SysEngineering_80_4-4",_LayerTable:"DT_MusicLayers_SysEngineering", _MusicData:"CustomEngineeringMusic",        _SoundClass:"MX_SysEngineering")},
        {Area.Security,     new(_FolderName:"Security",     _Cue:"BP_MusicCue_Security_65_4-4", _LayerTable:"DT_MusicLayers_Security",              _MusicData:"CustomSecurityMusic",           _SoundClass:"MX_Security")},
        {Area.Bridge,       new(_FolderName:"Bridge",       _Cue:"BP_MusicCue_Bridge_60_4-4",   _LayerTable:"DT_MusicLayers_Bridge",                _MusicData:"CustomBridgeMusic",             _SoundClass:"Bridge")},
        {Area.Cyberspace,   new(_FolderName:"Cyberspace",   _Cue:"BP_MusicCue_Cyberspace",      _LayerTable:"DT_MusicLayers_Cyberspace",            _MusicData:"CustomCyberspaceMusic",         _SoundClass:"Cyberspace")},
        {Area.Elevator,     new(_FolderName:"Global",       _Cue:"BP_MusicCue_Elevator",        _LayerTable:"DT_MusicLayers_Elevator",              _MusicData:"CustomElevatorMusic",           _SoundClass:"MX_Elevator")},
        {Area.AlphaGrove,   new(_FolderName:"AlphaGrove",   _Cue:"BP_MusicCue_AlphaGrove",  _LayerTable:"DT_MusicLayers_AlphaGrove",                _MusicData:"CustomAlphaGroveMusic",         _SoundClass:"MX_AlphaGrove")},
        {Area.BetaGrove,    new(_FolderName:"BetaGrove",    _Cue:"BP_MusicCue_BetaGrove",   _LayerTable:"DT_MusicLayers_BetaGrove",                 _MusicData:"CustomBetaGroveMusic",          _SoundClass:"MX_BetaGrove")},
        {Area.DeltaGrove,   new(_FolderName:"DeltaGrove",   _Cue:"BP_MusicCue_DeltaGrove",  _LayerTable:"DT_MusicLayers_DeltaGrove",                _MusicData:"CustomDeltaGroveMusic",         _SoundClass:"MX_DeltaGrove")},
        {Area.Medical,      new(_FolderName:Path.Combine("Medical","Exploration"),  _Cue:"BP_MusicCue_Medical_Exploration_55_4-4",  _LayerTable:"DT_MusicLayers_Medical_Exploration",  _MusicData:"CustomMedicalMusic",    _SoundClass:"Medical")},
        {Area.MedicalBeta,  new(_FolderName:Path.Combine("Medical","Exploration"),  _Cue:"BP_MusicCue_Techy",                       _LayerTable:"DT_MusicLayers_Techy",                _MusicData:"CustomMedicalBetaMusic",_SoundClass:"MX_Medical_BetaQuadrant")},
        {Area.Executive,    new(_FolderName:Path.Combine("Executive","Exploration"),_Cue:"BP_MusicCue_Executive_Exploration_72_4-4",_LayerTable:"DT_MusicLayers_Executive_Exploration",_MusicData:"CustomExecutiveMusic",  _SoundClass:"Executive")},
        {Area.MainMenu,     new(_FolderName:Path.Combine("Global","Exploration"),_Cue:"BP_MusicCue_TitleScreen",_LayerTable:"DT_MusicLayers_TitleScreen",_MusicData:"CustomMainMenuMusic",_SoundClass:"MX_MainMenu")},
        {Area.IntroCutscene,new(_FolderName:Path.Combine("Cinematics","Intro"),_Cue:"", _LayerTable:"",_MusicData:"Cinematic_Intro_Music_v3",_SoundClass:"MX_Intro")}/*,
        {Area.EndCreditsSong1,new(_FolderName:"Test",       _Cue:"",                    _LayerTable:"",_MusicData:"Outro_Theme",_SoundClass:"MX_OutroA")},
        {Area.EndCreditsSong2,new(_FolderName:"Test",       _Cue:"",                    _LayerTable:"",_MusicData:"Outro_WelcomeBacktoCitadelStation",_SoundClass:"MX_OutroB")}*/
    };

    public static string GetAreaName(Area area) {
        return Enum.GetName(typeof(Area), area);
    }

    public static Area[] GetArrayOfAreas() {
        return (Area[])Enum.GetValues(typeof(Area));
    }
}
