public class HeroAttackState : HeroBaseState
{
    protected HeroAttackState(HeroStateMachine stateMachine) : base(stateMachine)
    {
    }
    
    public override void Enter()
    {
        stateMachine.Hero.Agent.speed = 0f;
        base.Enter();
        StartAnimation(stateMachine.Hero.HeroData.animationData.AttackParameterHash);
    }

    public override void Update()
    {
        base.Update();
        if (!stateMachine.TargetEnemy)
        {
            stateMachine.ChangeState(stateMachine.IdleState);
        }
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Hero.HeroData.animationData.AttackParameterHash);
    }
}
