using Abp.Authorization;
using Abp.Runtime.Session;
using TaskManagementSystem.Configuration.Dto;
using System.Threading.Tasks;

namespace TaskManagementSystem.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : TaskManagementSystemAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
