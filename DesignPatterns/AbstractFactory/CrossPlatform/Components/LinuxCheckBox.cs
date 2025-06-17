using CrossPlatform.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace CrossPlatform.Components;

// TODO: Complete implement interface DONE
public sealed class LinuxCheckBox : ICheckBox
{
  private bool _isChecked;
  public bool IsChecked { get => _isChecked; set { _isChecked = value; } }

  public string GetStyle() => $"{this.GetType().Name} Unix style";
  public void Render()
  {
    Console.WriteLine($"Rendering the {this.GetType().Name} CheckBox Component");
  }
}