using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider glissiereVolumeMusique;


    void Start(){

        audioMixer.SetFloat("VolumeMusique", -10f);
        //audioMixer.GetFloat("VolumeMusique", );

    }

    void Update(){
        
    }

    public void AjustementVolumeMusique(float volume){

        audioMixer.SetFloat("VolumeMusique", ConvertionLineaireALogarithmique(volume));


    }

    private float ConvertionLineaireALogarithmique(float volume){

        return Mathf.Log10(volume) * 20;

    }

}
