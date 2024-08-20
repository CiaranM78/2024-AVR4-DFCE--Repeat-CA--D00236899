using AVR;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[CreateAssetMenu(fileName = "SoundDictionary",
       menuName = "AVR/Scriptable Objects/Game/SoundDictionary")]
public class SoundDictionary :  ScriptableGameObject
{
    [SerializeField]
    private Dictionary<SoundType, AudioClip> data;

    public AudioClip GetAudioClip(SoundType sound)
    {
        if (data.TryGetValue(sound, out var clip))
        {
           return clip;
        }
        return null;
    }

}
