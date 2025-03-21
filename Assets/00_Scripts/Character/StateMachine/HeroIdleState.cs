using UnityEngine;

public class HeroIdleState : HeroGroundState
{
    private readonly LayerMask enemyMask;

    public HeroIdleState(HeroStateMachine stateMachine) : base(stateMachine)
    {
        enemyMask = LayerMask.NameToLayer("Enemy");
    }

    public override void Enter()
    {
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
        if(stateMachine.StageManager.enemies.Count <= 0) return;;
        
        stateMachine.TargetEnemy =  stateMachine.StageManager.enemies[0];
        stateMachine.Hero.Agent.SetDestination(stateMachine.TargetEnemy.transform.position);
        stateMachine.ChangeState(stateMachine.WalkState);
    }
}