public interface IState
{
    public void Enter();
    public void Update();
    public void Exit();
}

public class StateMachine
{
    protected IState curState;

    public void ChangeState(IState state)
    {
        curState?.Exit();
        curState = state;
        curState.Enter();
    }

    public void Update()
    {
        curState?.Update();
    }
}
