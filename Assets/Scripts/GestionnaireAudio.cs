using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider glissiereVolumeMusique;
    [SerializeField] private Slider glissiereVolumeFX;

    private AudioSource audioSource;


    void Start(){

        // meme chose que dutuliser serializedfield et de drag le component dans unity
        audioSource = GetComponent<AudioSource>();
        //audioMixer.SetFloat("VolumeMusique", -10f);
        //audioMixer.GetFloat("VolumeMusique", );

    }

    public void AjustementVolumeMusique(float volume){

        audioMixer.SetFloat("VolumeMusique", ConvertionLineaireALogarithmique(volume));

    }

    public void AjustementVolumeFX(float volume){

        audioMixer.SetFloat("VolumeFX", ConvertionLineaireALogarithmique(volume));
        audioSource.Play();

    }

    private float ConvertionLineaireALogarithmique(float volume){

        return Mathf.Log10(volume) * 20;

    }

}
