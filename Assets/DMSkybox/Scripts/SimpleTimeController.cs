using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class SimpleTimeController : MonoBehaviour
{

    [Range(0, 1)] public float CurrentTime = 0f;

    public GameObject Sun;
    public GameObject Moon;

    public Material Stars;
    public Material Atmosphere;
    public Material Clouds;

    public AnimationCurve starsFade = new AnimationCurve();
    public Gradient cloudColor = new Gradient();
    public Gradient horizonColor = new Gradient();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Sun != null) {
            Sun.transform.rotation = Quaternion.AngleAxis(CurrentTime * 360, Vector3.right); //rotate the sun based on the time
        }

        if(Stars != null) {
            Stars.SetFloat("_StarsFade", starsFade.Evaluate(CurrentTime));
            //since the atmosphere is additive, we need to fade the stars out during the day otherwise they will show through the blue sky atmoshphere.  
            //The actually black sky behind the stars is fine though, because black doesn't add.  If you had some kind of galaxy texture or something that wasn't pure black, you'd need to fade that too.
        }


        //setting shader vars for the sun
        Light sunLight = Sun.GetComponentInChildren<Light>();
        if(Sun != null) Shader.SetGlobalVector("SunDirLightDirection", new Vector4(sunLight.transform.forward.x, sunLight.transform.forward.y, sunLight.transform.forward.z, sunLight.intensity));
        if(Sun != null) Shader.SetGlobalColor("SunDirLightColor", sunLight.color);

        Shader.SetGlobalColor("CloudColor", cloudColor.Evaluate(CurrentTime));
        Shader.SetGlobalColor("_HorizonColor", horizonColor  .Evaluate(CurrentTime));

    }
}
