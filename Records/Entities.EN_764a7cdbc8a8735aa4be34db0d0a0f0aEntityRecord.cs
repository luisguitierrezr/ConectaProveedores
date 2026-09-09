using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id"},
{"isdraft", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft"},
{"folionumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber"},
{"canproveedorcancel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel"},
{"orderid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid"},
{"supplierid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid"},
{"companyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid"},
{"foliostatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid"},
{"totalamount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount"},
{"totaliva_amount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount"},
{"partialamount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount"},
{"currencyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid"},
{"firstapproveruserid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid"},
{"approvalprocesstypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid"},
{"sapentryerror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"minuteselected", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, "folio_u8aqr95gpfeqtjc4xj_owna7"));
}
} // ENFolioEntity

}

