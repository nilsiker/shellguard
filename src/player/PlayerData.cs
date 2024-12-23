namespace Shellguard.Player;

using Chickensoft.Introspection;
using Chickensoft.Serialization;
using Godot;

[Meta, Id("player_data")]
public partial record class PlayerData
{
  [Save("global_transform")]
  public required Transform3D GlobalTransform { get; init; }
}
