using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InteractableTypes { Speakable, Pickupable, Insertable }

public abstract class IInteractable : MonoBehaviour
{
    public int interactableIndex = 0;
    public bool isAssigned = false;
    public List<InteractableTypeSelector> interactableTypeSelector = new List<InteractableTypeSelector>();
    public abstract string GetInteractPrompt(InteractableTypes _interactableType);
    public abstract void OnInteract(int _interactionIndex, int _interactableIndex);
    public abstract void RPC_OnInteract(int _interactionIndex, int _interactableIndex);
    public abstract void TakeControl(bool _takeControl, int _interactableIndex);
    public abstract void PickupObject(int _viewID);
}
