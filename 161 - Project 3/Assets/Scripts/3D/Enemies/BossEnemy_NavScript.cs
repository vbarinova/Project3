using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossEnemy_NavScript : MonoBehaviour {

    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

    public static bool s_PlayerHit;
    public Collider m_Collider;
    public Renderer m_renderer;

    private bool stall = false;
    private bool canHurtPlayer = true;
    private float m_speed = 4.3f;


	// Use this for initialization
	void Start () {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        gameObject.SetActive(true);
        m_Collider.enabled = true;
        m_renderer.enabled = true;

        _navMeshAgent.speed = m_speed;

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
            //StartCoroutine(DoBlinks(1f, 0.5f));
            //_navMeshAgent.isStopped = true;
        }
        if (trig.gameObject.tag == "Player" && canHurtPlayer)
        {
            s_PlayerHit = true;
        }
    }

    private IEnumerator Stall()
    {
        //stall = true;
        _navMeshAgent.isStopped = true;
        canHurtPlayer = false;
        m_Collider.enabled = false;
        blink();
        Debug.Log("Stalled Boss");
        yield return new WaitForSeconds(5f);
        _navMeshAgent.isStopped = false;
        canHurtPlayer = true;
        m_Collider.enabled = false;
        Debug.Log("Unstalled boss");
        //stall = false;
    }

    private void blink()
    {
        StartCoroutine(DoBlinks(.2f, 0.5f));
    }

    private IEnumerator DoBlinks(float duration, float blinkTime)
    {
        while(duration > 0f)
        {
            duration -= Time.deltaTime;
           // Debug.Log("Duration: " + duration);

            // toggle renderer
            m_renderer.enabled = !m_renderer.enabled;

            // wait for a bt
            yield return new WaitForSeconds(blinkTime);

        }

        // make sure renderer is enabled when we exit
        m_renderer.enabled = true;
    }


}
