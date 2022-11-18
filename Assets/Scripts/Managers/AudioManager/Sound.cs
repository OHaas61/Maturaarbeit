using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    public bool interruptable;

    [Range(0f, 1f)]
    public float volume = 0.5f;

    [Range(0.1f, 3f)]
    public float pitch = 1f;

    public AudioSource Source { get; set; }
}
