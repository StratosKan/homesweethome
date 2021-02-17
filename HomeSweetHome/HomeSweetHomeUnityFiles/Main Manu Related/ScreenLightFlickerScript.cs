using UnityEngine;

public class ScreenLightFlickerScript : MonoBehaviour
{
    private Light screenLight;
    public float multiplier = 1f;

    void Awake()
    {
        screenLight = gameObject.GetComponent<Light>();
    }

    void Update()
    {
        ///lerps the intensity from 2 to 2.29
        screenLight.intensity = Mathf.Lerp(2f, 2.29f, Mathf.PingPong(Time.time * multiplier, 1));
    }
}
