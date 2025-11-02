using UnityEngine;
using System.Collections;

public class PressButtonCoroutine
{
    public IEnumerator ButtonCoroutine(ButtonAction ba, AudioSource sound)
    {
        sound.Play();
        yield return new WaitForSeconds(sound.clip.length - 0.35f);

        Debug.Log("Buttin pressed" + ba.Method.Name);

        ba();
    }

    public delegate void ButtonAction();
}
