using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFileExtendedEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFileExtendedEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Id, "id") ?? "id"},
{"filename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@Filename, "filename") ?? "filename"},
{"isprocessed", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@IsProcessed, "isprocessed") ?? "isprocessed"},
{"haserror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@HasError, "haserror") ?? "haserror"},
{"errormessage", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage"},
{"uploadedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedBy, "uploadedby") ?? "uploadedby"},
{"uploadedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FileExtendedAttributeKeys.@UploadedOn, "uploadedon") ?? "uploadedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FileExtended, "file__u8aqr95gpfexwuahx8psobk5"));
}
} // ENFileExtendedEntity

}

