using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class event_control : MonoBehaviour, IPointerClickHandler
{

    //Rigidbody rigidBody;
    //public Vector3 force = new Vector3(0, 10, 0);
    //public ForceMode forceMode = ForceMode.VelocityChange;

    // Use this for initialization
    void Start()
    {
        //rigidBody = gameObject.GetComponent<Rigidbody>();

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        //rigidBody.AddForce(force, forceMode);
    }
}