using CrossPlatform.Interfaces;

namespace CrossPlatform.Components;

// TODO: Complete implement interface
public sealed class MacOSTextBox : ITextBox
{
  public string GetFont() => "New Times Roman";

  public string GetText() => $"Get {this.GetType().Name} text from the Mac label";

  public void Render()
  {
     Console.WriteLine($"Rendering {this.GetType().Name} Component");
  }

  public void SetText(string text)
  {
      Console.WriteLine($"Setting {text} text in {this.GetType().Name} Component");
  }
}