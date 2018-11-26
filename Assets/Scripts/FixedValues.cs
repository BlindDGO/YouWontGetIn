using UnityEngine;
using System.Collections;

public class FixedScenes
{
    public static readonly string LVL01_SCENE = "Lvl_01";
    public static readonly string MAIN_SCENE = "Menu";
    public static readonly string LVL02_SCENE = "Lvl_02";
    public static readonly string LOADING_SCENE = "Lvl_02";
    public static bool onOptions;
    
}
public class FixedPlayerPrefKeys
{
    public static readonly string MUSIC_VOLUME = "MusicVolume";
    public static readonly string SFX_VOLUME = "SfxVolume";
}
public class FixedPaths
{
    public static readonly string PERSISTENT_DATA = Application.persistentDataPath;
    public static readonly string PATH_RESOURCE_SFX = "Sounds/MenuSfx/";
    public static readonly string PATH_RESOURCE_MUSIC = "Sounds/Music/";
}
public class FixedSound
{
    public static readonly string TEMITA = "Synth";
    public static readonly string Shoot = "Launch";
    public static readonly string Whatever = "Sounds/Music/";
}
