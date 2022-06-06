using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent = null;
    public RaycastHit hit;
    private Selection selectionManager;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        selectionManager = GameObject.Find("SelectionManager").GetComponent<Selection>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoving();
    }

    void PlayerMoving()
    {
        if (Input.GetMouseButtonDown(0) && gameManager.gameIsActive)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Bush"))
                {
                    selectionManager.SelectBush(hit.collider.gameObject);
                }
                _agent.SetDestination(hit.point);
            }
        }
    }

    public void ChangeSpeed(float speedMultiplier)
    {
        _agent.acceleration = speedMultiplier;
        _agent.speed = speedMultiplier;
        Debug.Log("Speed" + _agent.speed);
    }
}
