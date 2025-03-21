public class HeroNormalAttackState : HeroAttackState
{
    private int atkIndex;
    
    public HeroNormalAttackState(HeroStateMachine stateMachine) : base(stateMachine)
    {
    }
    
    public override void Enter()
    {
        base.Enter();
        StartAnimation(stateMachine.Hero.HeroData.animationData.NormalAttackParameterHash);
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Hero.HeroData.animationData.NormalAttackParameterHash);
    }
}
