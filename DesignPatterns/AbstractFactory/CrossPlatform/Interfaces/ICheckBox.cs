using System.ComponentModel.DataAnnotations;

namespace CrossPlatform.Interfaces;

public interface ICheckBox : IComponent
{
  bool IsChecked { get; set; }
  string GetStyle();
}