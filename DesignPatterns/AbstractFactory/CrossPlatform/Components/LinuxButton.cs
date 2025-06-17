using CrossPlatform.Interfaces;

namespace CrossPlatform.Components;

// TODO: Complete implement interface DONE
public sealed class LinuxButton : IButton
{
  public void Click()
  {
     Console.WriteLine($"{this.GetType().Name} clicked redirect us to the next form");
  }

  public string GetTheme() => "Dark bolder green";

  public void Render()
  {
    Console.WriteLine($"Rendering {this.GetType().Name} with highlighted label");
  }
}