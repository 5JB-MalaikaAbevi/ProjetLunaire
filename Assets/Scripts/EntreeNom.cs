using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EntreeNom : MonoBehaviour
{
    public TextMeshProUGUI nom;
    public TMP_InputField nomEntree;

    public void DefinirNom()
    {
        nom.text = nomEntree.text;
    }
}
