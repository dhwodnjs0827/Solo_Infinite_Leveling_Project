using UnityEngine;

public class HeroIdleState : HeroGroundState
{
    private readonly LayerMask enemyLayer;

    public HeroIdleState(HeroStateMachine stateMachine) : base(stateMachine)
    {
        enemyLayer = 1 << LayerMask.NameToLayer("Enemy");
    }

    public override void Enter()
    {
        Debug.Log("Entered IdleState");
        stateMachine.Hero.Agent.speed = 0f;
        base.Enter();
        StartAnimation(stateMachine.Hero.HeroData.animationData.IdleParameterHash);
    }

    public override void Update()
    {
        base.Update();
        FindEnemy();
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Hero.HeroData.animationData.IdleParameterHash);
    }

    private void FindEnemy()
    {
        var enemies = Physics.OverlapSphere(stateMachine.Hero.transform.position, 5f, enemyLayer);

        if (enemies.Length > 0)
        {
            stateMachine.TargetEnemy = enemies[0].gameObject;
            stateMachine.Hero.Agent.SetDestination(stateMachine.TargetEnemy.transform.position);
            stateMachine.ChangeState(stateMachine.WalkState);
        }
        else
        {
            enemies = Physics.OverlapSphere(stateMachine.Hero.transform.position, 20f, enemyLayer);

            stateMachine.TargetEnemy = enemies[0].gameObject;
            stateMachine.Hero.Agent.SetDestination(stateMachine.TargetEnemy.transform.position);
            stateMachine.ChangeState(stateMachine.RunState);
        }
    }
}