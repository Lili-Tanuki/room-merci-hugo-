using UnityEngine;

[CreateAssetMenu]
public class DialogueAsset : ScriptableObject
{

    [TextArea(3, 6)]
    public string[] dialogue;


}
