using CrossPlatform.Interfaces;
using System.Diagnostics.Metrics;

namespace CrossPlatform.Client;

// TODO: Use the client and enhance the creation for user interfaces DONE
public class UserInterfaceApplication(IUserInterfaceComponentFactory uiFactory) : IUserInterfaceApplication
{
  private readonly IUserInterfaceComponentFactory _uiFactory = uiFactory ?? throw new ArgumentNullException(nameof(uiFactory));
  private readonly List<IButton> _buttons = [];
  private readonly List<ITextBox> _textBoxes = [];
  private readonly List<ICheckBox> _checkBoxes = [];

  public void CreateLoginForm()
  {
    AddTextBox("Enter username");
    AddTextBox("*********");
    AddButton();
    Console.WriteLine("Login form created succesfully");
  }

  private void AddTextBox(string text)
  {
    var usernameTextBox = _uiFactory.CreateTextBox();
    usernameTextBox.Render();
    usernameTextBox.SetText(text);
    _textBoxes.Add(usernameTextBox);
  }

  private void AddButton()
  {
    var button = _uiFactory.CreateButton();
    button.Render();
    _buttons.Add(button);
  }
}