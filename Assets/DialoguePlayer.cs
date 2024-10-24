using TMPro;
using UnityEngine;

public class DialoguePlayer : MonoBehaviour
{
    public DialogueAsset dialogueAsset;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;

    private int dialogueIndex;


    private void Start()
    {
        dialogueText.text = dialogueAsset.dialogue[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            dialogueIndex += 1;

            if (dialogueIndex < dialogueAsset.dialogue.Length)
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueIndex];
            }
            else
            {
                dialogueBox.gameObject.SetActive(false);
            }
        }

    }
}
