using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENUser_Extended_InternalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENUser_Extended_InternalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@Id, "id") ?? "id"},
{"employeenumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@EmployeeNumber, "employeenumber") ?? "employeenumber"},
{"managedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@ManagedBy, "managedby") ?? "managedby"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@RegionId, "regionid") ?? "regionid"},
{"departmentid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid"},
{"managementid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@ManagementId, "managementid") ?? "managementid"},
{"subdirectionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid"},
{"telceldirectionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid"},
{"city", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@City, "city") ?? "city"},
{"jobtitle", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@JobTitle, "jobtitle") ?? "jobtitle"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"},
{"onpremisesdistinguishedname", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@onPremisesDistinguishedName, "onpremisesdistinguishedname") ?? "onpremisesdistinguishedname"},
{"hasrolesassigned", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@HasRolesAssigned, "hasrolesassigned") ?? "hasrolesassigned"},
{"lastsync", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@LastSync, "lastsync") ?? "lastsync"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"entraid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@EntraId, "entraid") ?? "entraid"},
{"telceldireccion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, _EntityKeyConstants._OrganizationEntityKeys._User_Extended_InternalAttributeKeys.@TelcelDireccion, "telceldireccion") ?? "telceldireccion"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, "user__ok7ot05vqrokko456jh6e415"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENUser_Extended_InternalEntity

}

