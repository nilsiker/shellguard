namespace Shellguard;

public partial class AppLogic
{
  public abstract partial record State
  {
    public partial record StartingGame : State, IGet<Input.GameReady>
    {
      public StartingGame()
      {
        OnAttach(() =>
        {
          Output(new Output.SetupGame());
          Input(new Input.GameReady());
        });
        OnDetach(() => { });
      }

      public Transition On(in Input.GameReady input) => To<InGame>();
    }
  }
}
