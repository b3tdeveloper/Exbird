using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // You can set the slow motion amount and lenght from here or in Unity.
    public float slowdownFactor = 0.2f;
    public float slowdownLenght = 2f;


    void Update()
    {
        // These are for adjusting the lenght of slow motion.
        Time.timeScale += (1 / slowdownLenght) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void DoSlowmotion()
    {
        // These are for adjusting the amount of slow motion.
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
}
