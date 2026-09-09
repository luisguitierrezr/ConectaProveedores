using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderMainEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderMainEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id"},
{"ordernumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber"},
{"orderdate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate"},
{"orderstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid"},
{"previousorderstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid"},
{"assignmentcode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode"},
{"supplierid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid"},
{"companyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid"},
{"documenttypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid"},
{"currencyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid"},
{"telceldirectionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid"},
{"procurementgroup", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup"},
{"creatorsapnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber"},
{"creatorsapname", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname"},
{"country", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country"},
{"isdeleted", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted"},
{"isreleased", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased"},
{"exchangerate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate"},
{"sustainabilitycategory", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory"},
{"sustainabilitysubcategory", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory"},
{"totalamount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount"},
{"fromcosmoz", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid"},
{"divisionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid"},
{"applicant", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, "order_u8aqr95gpfezu168uwnwiw12"));
}
} // ENOrderMainEntity

}

