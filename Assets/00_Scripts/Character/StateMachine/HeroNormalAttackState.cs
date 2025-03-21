public class HeroNormalAttackState : HeroAttackState
{
    public HeroNormalAttackState(HeroStateMachine stateMachine) : base(stateMachine)
    {
    }
    
    public override void Enter()
    {
        base.Enter();
        StartAnimation(stateMachine.Hero.HeroData.animationData.NormalAttackParameterHash);
    }

    public override void Update()
    {
        base.Update();
        if (stateMachine.TargetEnemy)
        {
            stateMachine.ChangeState(stateMachine.IdleState);
        }
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Hero.HeroData.animationData.NormalAttackParameterHash);
    }
}
