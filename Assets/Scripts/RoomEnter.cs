using UnityEngine;

public class RoomEnter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private int roomID = 0; //0 = Sun Room, 1 = Wind Room, 2 = Water Room, 3 = Earth Room

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Debug.Log("Collision with: " + collision.name);
            PlayerController P = collision.GetComponent<PlayerController>();



            if (P != null)
            {
                if (roomID == 0)
                {
                    Debug.Log("Entering The Sun Room" + "/Room ID: " + roomID);
                }

                else if (roomID == 1)
                {
                    Debug.Log("Entering The Wind Room" + "/Room ID: " + roomID);
                }

                else if (roomID == 2)
                {
                    Debug.Log("Entering The Water Room" + "/Room ID: " + roomID);
                }
                else
                {
                    Debug.Log("Entering The Earth Room" + "/Room ID: " + roomID);
                }

            }

        }
    }
}
