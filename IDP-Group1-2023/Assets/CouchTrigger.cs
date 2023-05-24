using UnityEngine;
using Fungus;

public class CouchTrigger : MonoBehaviour
{
    public KeyCode interactionKey = KeyCode.Space;
    public Flowchart flowchart;

    private bool canInteract = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = false;
        }
    }

    private void Update()
    {
        if (canInteract && Input.GetKeyDown(interactionKey))
        {
            // Trigger the dialogue in Fungus
            flowchart.ExecuteBlock("DollDiscussion");
        }
    }
}
