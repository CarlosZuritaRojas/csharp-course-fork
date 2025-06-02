using InvoiceApp.Models;
using InvoiceApp.Services;

namespace InvoiceApp.Tests.Services;

public class TestArgumentValidator
{

    // TODO: Add negative test cases
    [Fact]
    public void CheckArguments_ThrowsArgumentException_WhenEmptyListIsProvided()
    {
        var validator = new ArgumentValidator();
        
        Assert.Throws<ArgumentException>(() => validator.CheckArguments([]));
    }
}
