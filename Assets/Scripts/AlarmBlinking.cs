using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlarmBlinking : MonoBehaviour
{
    [Header("Console/Lights Blinking")]
    public float alphaFrequency = 0.4f;
    public int alphaAmplitude = 60;
    public int alphaOffset = 110;

    public SpriteRenderer[] alarmSymbols;
    public Light[] lights;


    [Header("Lights Blinking")]
    public float emissionFrequency = 0.4f;
    public int emissionAmplitude = 125;
    public int emissionOffset = 125;

    public Renderer emission;
    public Color redEmission;


    [Header("State Change References")]
    public GameObject[] alarmMonitors;
    public GameObject[] standardMonitors;

    public AudioSource alarmSound;
    public AudioSource ambienceSound;

    public Color blueEmission;


    private void OnEnable()
    {
        // Switch on alarm monitors
        foreach (GameObject monitor in alarmMonitors)
        {
            monitor.SetActive(true);
        }
        foreach (GameObject monitor in standardMonitors)
        {
            monitor.SetActive(false);
        }

        // Set emission to red
        emission.sharedMaterials[1].SetColor("_EmissionColor", redEmission);
        foreach (Light light in lights)
        {
            light.color = redEmission;
        }

        // Play alarm sound
        alarmSound.Play();
        ambienceSound.Pause();
    }

    private void OnDisable()
    {
        // Switch off alarm monitors
        foreach (GameObject monitor in alarmMonitors)
        {
            monitor.SetActive(false);
        }
        foreach (GameObject monitor in standardMonitors)
        {
            monitor.SetActive(true);
        }

        // Set emission to blue
        emission.sharedMaterials[1].SetColor("_EmissionColor", blueEmission);
        foreach (Light light in lights)
        {
            light.color = blueEmission;
        }

        // Stop alarm sound
        alarmSound.Pause();
        ambienceSound.Play();
    }

    void Update()
    {
        UpdateAlpha();
        UpdateEmission();
        UpdateLights();
    }

    private void UpdateLights()
    {
        foreach (Light light in lights)
        {
            light.intensity = calculateAlpha(Time.time) / 255f;
        }
    }

    private void UpdateAlpha()
    {
        foreach (SpriteRenderer s in alarmSymbols)
        {
            s.color = new Color(s.color.r, s.color.g, s.color.b, calculateAlpha(Time.time) / 255f);
        }
    }

    private int calculateAlpha(float t)
    {
        float alpha =  alphaAmplitude * Mathf.Sin(2 * Mathf.PI * alphaFrequency * t) + alphaOffset;
        return Mathf.RoundToInt(alpha);
    }

    private void UpdateEmission()
    {
        emission.sharedMaterials[1].SetColor("_EmissionColor", new Color(calculateEmission(Time.time) / 255f, 0f, 0f, emission.sharedMaterials[1].GetColor("_EmissionColor").a));
    }

    private int calculateEmission(float t)
    {
        float emission = emissionAmplitude * Mathf.Sin(2 * Mathf.PI * emissionFrequency * t) + emissionOffset;
        return Mathf.RoundToInt(emission);
    }
}
