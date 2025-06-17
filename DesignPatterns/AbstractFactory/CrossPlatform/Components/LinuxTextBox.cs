using CrossPlatform.Interfaces;

namespace CrossPlatform.Components;

// TODO: Complete implement interface DONE
public sealed class LinuxTextBox : ITextBox
{
  public string GetFont() => "Sans-Seriff";

  public string GetText() => "Text from Inner text property";
  
  public void Render()
  {
      Console.WriteLine($"Rendering {this.GetType().Name} Component");
  }

  public void SetText(string text)
  {
      Console.WriteLine($"Setting {text} text in {this.GetType().Name} Component");
  }
}