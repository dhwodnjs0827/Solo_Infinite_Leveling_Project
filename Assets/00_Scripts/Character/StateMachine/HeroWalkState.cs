using UnityEngine;

public class HeroWalkState : HeroGroundState
{
    public HeroWalkState(HeroStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Hero.Agent.speed = 1f;
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
        var range = Vector3.Distance(stateMachine.TargetEnemy.transform.position, stateMachine.Hero.transform.position);
        if (range < 2f)
        {
            stateMachine.ChangeState(stateMachine.NormalAttackState);
        }
    }
}
