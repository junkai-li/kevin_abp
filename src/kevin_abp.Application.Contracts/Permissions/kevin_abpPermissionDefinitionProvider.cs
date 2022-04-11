using kevin_abp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace kevin_abp.Permissions;

public class kevin_abpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(kevin_abpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(kevin_abpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<kevin_abpResource>(name);
    }
}
