using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioRegionSeqEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioRegionSeqEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioRegionSeq, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioRegionSeqAttributeKeys.@Id, "id") ?? "id"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioRegionSeq, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioRegionSeqAttributeKeys.@RegionId, "regionid") ?? "regionid"},
{"seqvalue", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioRegionSeq, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioRegionSeqAttributeKeys.@SeqValue, "seqvalue") ?? "seqvalue"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioRegionSeq, "folio_u8aqr95gpferwflelwndfu80"));
}
} // ENFolioRegionSeqEntity

}

