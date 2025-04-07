using TaskManagementSystem.Configuration.Dto;
using System.Threading.Tasks;

namespace TaskManagementSystem.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
