using CrossPlatform.Interfaces;

namespace CrossPlatform.Components;

// TODO: Complete implement interface
public sealed class WindowsTextBox : ITextBox
{
  public string GetFont() => "Arial";

  public string GetText() => $"Get {this.GetType().Name} from basic Text component";

  public void Render()
  {
     Console.WriteLine($"Rendering {this.GetType().Name} Component");
  }

  public void SetText(string text)
  {
     Console.WriteLine($"Setting {text} text in {this.GetType().Name} Component");
  }
}