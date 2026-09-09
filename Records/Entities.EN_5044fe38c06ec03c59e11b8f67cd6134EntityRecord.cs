using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENBankEntity {
private static readonly ActivitySource activitySource = new(typeof(ENBankEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Bank, _EntityKeyConstants._CommonEntityKeys._BankAttributeKeys.@Id, "id") ?? "id"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Bank, _EntityKeyConstants._CommonEntityKeys._BankAttributeKeys.@Name, "name") ?? "name"},
{"shortname", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Bank, _EntityKeyConstants._CommonEntityKeys._BankAttributeKeys.@ShortName, "shortname") ?? "shortname"},
{"code", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Bank, _EntityKeyConstants._CommonEntityKeys._BankAttributeKeys.@Code, "code") ?? "code"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Bank, _EntityKeyConstants._CommonEntityKeys._BankAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Bank, _EntityKeyConstants._CommonEntityKeys._BankAttributeKeys.@Order, "order") ?? "order"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Bank, "bank_woucc4dity14wg1xnrs18960"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
} // ENBankEntity

}

