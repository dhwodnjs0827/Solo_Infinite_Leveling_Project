using UnityEngine;
using UnityEngine.AI;

public class Hero : MonoBehaviour
{
    [SerializeField] private HeroData heroData;

    private HeroStateMachine stateMachine;

    public HeroData HeroData => heroData;
    public NavMeshAgent Agent { get; private set; }

    public Animator Animator { get; private set; }

    private void Awake()
    {
        heroData.animationData.Initialize();
        
        Agent =  GetComponent<NavMeshAgent>();
        Agent.SetDestination(transform.position);
        Animator = GetComponentInChildren<Animator>();

        stateMachine = new HeroStateMachine(this);
    }

    private void Start()
    {
        stateMachine.ChangeState(stateMachine.IdleState);
    }

    private void Update()
    {
        stateMachine.Update();
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 5f);
    }
}