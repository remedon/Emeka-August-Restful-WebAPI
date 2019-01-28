using System.Threading.Tasks;
using Austine.Test.Configuration.Dto;

namespace Austine.Test.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
