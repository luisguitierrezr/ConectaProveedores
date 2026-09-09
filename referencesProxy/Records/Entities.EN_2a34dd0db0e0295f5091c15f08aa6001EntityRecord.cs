using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENSegmentAccGroupTelcelDirEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSegmentAccGroupTelcelDirEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SegmentAccGroupTelcelDir, _EntityKeyConstants._OrganizationEntityKeys._SegmentAccGroupTelcelDirAttributeKeys.@Id, "id") ?? "id"},
{"segmentaccgroupid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SegmentAccGroupTelcelDir, _EntityKeyConstants._OrganizationEntityKeys._SegmentAccGroupTelcelDirAttributeKeys.@SegmentAccGroupId, "segmentaccgroupid") ?? "segmentaccgroupid"},
{"telceldirectionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SegmentAccGroupTelcelDir, _EntityKeyConstants._OrganizationEntityKeys._SegmentAccGroupTelcelDirAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SegmentAccGroupTelcelDir, _EntityKeyConstants._OrganizationEntityKeys._SegmentAccGroupTelcelDirAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SegmentAccGroupTelcelDir, _EntityKeyConstants._OrganizationEntityKeys._SegmentAccGroupTelcelDirAttributeKeys.@CreatedBy, "createdby") ?? "createdby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SegmentAccGroupTelcelDir, "segme_ok7ot05vqroo4hjks8ryp4y5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSegmentAccGroupTelcelDirEntity

}

