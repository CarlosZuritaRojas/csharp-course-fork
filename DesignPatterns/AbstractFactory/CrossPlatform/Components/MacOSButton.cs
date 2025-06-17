using CrossPlatform.Interfaces;

namespace CrossPlatform.Components;

// TODO: Complete implement interface DONE
public sealed class MacOSButton : IButton
{
  public void Click()
  {
    Console.WriteLine($"{this.GetType().Name} has been clicked, shows a click and un click interaction");
  }

  public string GetTheme() => "Mac Cloudy Soft";

  public void Render()
  {
     Console.WriteLine($"Rendering {this.GetType().Name} with no rounded borders");
  }
}