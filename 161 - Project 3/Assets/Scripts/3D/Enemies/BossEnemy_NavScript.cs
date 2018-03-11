using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossEnemy_NavScript : MonoBehaviour {

    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

    private bool stall = false;


	// Use this for initialization
	void Start () {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (_navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent component is not attached to" + gameObject.name);
        }

        else
        {
            SetDestination();
        }
		
	}

   void FixedUpdate()
    {
        if (!_navMeshAgent.isStopped)
            SetDestination();
    }

    private void SetDestination()
    {
        if(_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
        //if (stall)
        //{
        //    _navMeshAgent.isStopped = true;
        //}
    }


    // Stalling enemy
    private void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.tag == "Bullet")
        {
            Debug.Log("STOPPPPPPPP");
            //_navMeshAgent.isStopped = true;
            StartCoroutine(Stall());
            //_navMeshAgent.isStopped = true;
        }
    }

    private IEnumerator Stall()
    {
        //stall = true;
        _navMeshAgent.isStopped = true;
        Debug.Log("Stalled yo");
        yield return new WaitForSeconds(4f);
        _navMeshAgent.isStopped = false;
        Debug.Log("Unstalled");
        //stall = false;
    }



}
