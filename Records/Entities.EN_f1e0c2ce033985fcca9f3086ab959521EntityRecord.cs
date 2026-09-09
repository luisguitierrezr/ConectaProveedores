using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENUserExtensionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENUserExtensionEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelCelUsersManagement, _EntityKeyConstants._TelCelUsersManagementEntityKeys.@UserExtension, _EntityKeyConstants._TelCelUsersManagementEntityKeys._UserExtensionAttributeKeys.@Id, "id") ?? "id"},
{"correspondentexternalemail", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelCelUsersManagement, _EntityKeyConstants._TelCelUsersManagementEntityKeys.@UserExtension, _EntityKeyConstants._TelCelUsersManagementEntityKeys._UserExtensionAttributeKeys.@CorrespondentExternalEmail, "correspondentexternalemail") ?? "correspondentexternalemail"},
{"emailto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelCelUsersManagement, _EntityKeyConstants._TelCelUsersManagementEntityKeys.@UserExtension, _EntityKeyConstants._TelCelUsersManagementEntityKeys._UserExtensionAttributeKeys.@Emailto, "emailto") ?? "emailto"}
};
}
public static System.Collections.Generic.Dictionary<string,string> AttributesToDatabaseNamesMap() {
return EntityAttributes;
}
public static string AttributeDatabaseName(string attributeName) {
string databaseName;
EntityAttributes.TryGetValue(attributeName, out databaseName);
return databaseName;
}
public static string LocalViewName(string locale) {
return ViewName(locale);
}
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@TelCelUsersManagement, _EntityKeyConstants._TelCelUsersManagementEntityKeys.@UserExtension, "usere_ihdi729yy17qst3kjw76auy3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("abbc6e11-902c-4319-878b-9d0fec641e61");
} // ENUserExtensionEntity

}

