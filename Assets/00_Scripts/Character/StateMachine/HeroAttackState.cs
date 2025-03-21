public class HeroAttackState : HeroBaseState
{
    protected HeroAttackState(HeroStateMachine stateMachine) : base(stateMachine)
    {
    }
    
    public override void Enter()
    {
        base.Enter();
        StartAnimation(stateMachine.Hero.HeroData.animationData.AttackParameterHash);
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Hero.HeroData.animationData.AttackParameterHash);
    }
}
