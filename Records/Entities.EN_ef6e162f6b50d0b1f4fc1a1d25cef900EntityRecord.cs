using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioLogEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioLogEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioLogAttributeKeys.@Id, "id") ?? "id"},
{"folioid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioLogAttributeKeys.@FolioId, "folioid") ?? "folioid"},
{"message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioLogAttributeKeys.@Message, "message") ?? "message"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioLogAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioLogAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"iserror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioLogAttributeKeys.@IsError, "iserror") ?? "iserror"},
{"isforsupplier", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioLog, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioLogAttributeKeys.@IsForSupplier, "isforsupplier") ?? "isforsupplier"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioLog, "folio_u8aqr95gpfewqtbl86uw7il2"));
}
} // ENFolioLogEntity

}

