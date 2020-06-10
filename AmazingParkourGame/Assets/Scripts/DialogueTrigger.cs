using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;


    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            TriggerDialogue();
        }
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, this.gameObject);
    }
}
