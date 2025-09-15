using UnityEngine;
using TMPro;

public class JoueMusic : MonoBehaviour
{

    AudioSource leSon;
    public TextMeshProUGUI preuve;

    private void Start()
    {
        leSon= GetComponent<AudioSource>();
    }

    public void jouerSon()
    {
        leSon.Play();
        preuve.text = "yes";
        
    }

    public void ArreterSon()
    {
        leSon.Stop();
        preuve.text = "";
    }

}
