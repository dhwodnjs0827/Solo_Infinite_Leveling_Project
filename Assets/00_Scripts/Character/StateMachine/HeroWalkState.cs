public class HeroWalkState : HeroGroundState
{
    public HeroWalkState(HeroStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        StartAnimation(stateMachine.Hero.HeroData.animationData.WalkParameterHash);
    }

    public override void Update()
    {
        base.Update();
        OnAttack();
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Hero.HeroData.animationData.WalkParameterHash);
    }

    private void OnAttack()
    {
        if (stateMachine.Hero.Agent.velocity.magnitude < 0.1f)
        {
            stateMachine.ChangeState(stateMachine.NormalAttackState);
        }
    }
}
