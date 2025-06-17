using CrossPlatform.Interfaces;

namespace CrossPlatform.Components;

// TODO: Complete implement interface DONE
public sealed class MacOSCheckBox : ICheckBox
{
  private bool _isChecked;
  public bool IsChecked { get => _isChecked; set { _isChecked = value; } }
  public string GetStyle() => $"{this.GetType().Name} Mac style";

  public void Render()
  {
    Console.WriteLine($"Rendering the {this.GetType().Name} CheckBox Component");
  }
}