using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderMain
/// </summary>

public static async Task<long> CreateOrderMain(IRequestContext requestContext,RC_1583d548420c231ffb93458312800446 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderMainEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
" ) VALUES (" +
" @ssOrderNumber" +
", @ssOrderDate" +
", @ssOrderStatusId" +
", @ssPreviousOrderStatusId" +
", @ssAssignmentCode" +
", @ssSupplierId" +
", @ssCompanyId" +
", @ssDocumentTypeId" +
", @ssCurrencyId" +
", @ssTelcelDirectionId" +
", @ssProcurementGroup" +
", @ssCreatorSAPNumber" +
", @ssCreatorSAPName" +
", @ssCountry" +
", @ssIsDeleted" +
", @ssIsReleased" +
", @ssExchangeRate" +
", @ssSustainabilityCategory" +
", @ssSustainabilitySubcategory" +
", @ssTotalAmount" +
", @ssFromCosmoz" +
", @ssRegionId" +
", @ssDivisionId" +
", @ssApplicant" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssOrderNumber", DbType.String, ssENOrderMain.ssOrderNumber);
insertSqlCmd.CreateParameter("@ssOrderDate", DbType.DateTime, ssENOrderMain.ssOrderDate);
insertSqlCmd.CreateParameter("@ssOrderStatusId", DbType.Int32, ssENOrderMain.ssOrderStatusId);
if ((ssENOrderMain.ssPreviousOrderStatusId==0)) {
insertSqlCmd.CreateParameter("@ssPreviousOrderStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPreviousOrderStatusId", DbType.Int32, ssENOrderMain.ssPreviousOrderStatusId);

}
insertSqlCmd.CreateParameter("@ssAssignmentCode", DbType.String, ssENOrderMain.ssAssignmentCode);
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENOrderMain.ssSupplierId);
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENOrderMain.ssCompanyId);
if ((ssENOrderMain.ssDocumentTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, ssENOrderMain.ssDocumentTypeId);

}
if ((ssENOrderMain.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderMain.ssCurrencyId);

}
if ((ssENOrderMain.ssTelcelDirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, ssENOrderMain.ssTelcelDirectionId);

}
insertSqlCmd.CreateParameter("@ssProcurementGroup", DbType.String, ssENOrderMain.ssProcurementGroup);
insertSqlCmd.CreateParameter("@ssCreatorSAPNumber", DbType.String, ssENOrderMain.ssCreatorSAPNumber);
insertSqlCmd.CreateParameter("@ssCreatorSAPName", DbType.String, ssENOrderMain.ssCreatorSAPName);
insertSqlCmd.CreateParameter("@ssCountry", DbType.String, ssENOrderMain.ssCountry);
insertSqlCmd.CreateParameter("@ssIsDeleted", DbType.Boolean, ssENOrderMain.ssIsDeleted);
insertSqlCmd.CreateParameter("@ssIsReleased", DbType.Boolean, ssENOrderMain.ssIsReleased);
var ExchangeRateParameter = insertSqlCmd.CreateParameter("@ssExchangeRate", DbType.Decimal, ssENOrderMain.ssExchangeRate);
{
    string decimalAsStr = ssENOrderMain.ssExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssSustainabilityCategory", DbType.String, ssENOrderMain.ssSustainabilityCategory);
insertSqlCmd.CreateParameter("@ssSustainabilitySubcategory", DbType.String, ssENOrderMain.ssSustainabilitySubcategory);
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENOrderMain.ssTotalAmount);
{
    string decimalAsStr = ssENOrderMain.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssFromCosmoz", DbType.Boolean, ssENOrderMain.ssFromCosmoz);
if ((ssENOrderMain.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderMain.ssRegionId);

}
if ((ssENOrderMain.ssDivisionId==0L)) {
insertSqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, ssENOrderMain.ssDivisionId);

}
insertSqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderMain.ssApplicant);
if ((ssENOrderMain.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderMain.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderMain.ssCreatedOn);
if ((ssENOrderMain.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderMain.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderMain.ssUpdatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderMain", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderMain
/// </summary>

public static async Task<long> CreateOrUpdateOrderMain(IRequestContext requestContext,BitArray usedFields,RC_1583d548420c231ffb93458312800446 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(29,true);
}
string updateSet = "UPDATE " + ENOrderMainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + " = @ssOrderNumber"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate") + " = @ssOrderDate"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid") + " = @ssOrderStatusId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid") + " = @ssPreviousOrderStatusId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode") + " = @ssAssignmentCode"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = @ssSupplierId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = @ssCompanyId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + " = @ssDocumentTypeId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + " = @ssTelcelDirectionId"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup") + " = @ssProcurementGroup"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber") + " = @ssCreatorSAPNumber"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname") + " = @ssCreatorSAPName"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country") + " = @ssCountry"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = @ssIsDeleted"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased") + " = @ssIsReleased"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate") + " = @ssExchangeRate"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory") + " = @ssSustainabilityCategory"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory") + " = @ssSustainabilitySubcategory"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz") + " = @ssFromCosmoz"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + " = @ssDivisionId"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant") + " = @ssApplicant"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[28] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderMain_ssId_OrderMain";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssOrderNumber", DbType.String, ssENOrderMain.ssOrderNumber);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssOrderDate", DbType.DateTime, ssENOrderMain.ssOrderDate);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOrderStatusId", DbType.Int32, ssENOrderMain.ssOrderStatusId);
}
if(usedFields[4]) {
if ((ssENOrderMain.ssPreviousOrderStatusId==0)) {
sqlCmd.CreateParameter("@ssPreviousOrderStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPreviousOrderStatusId", DbType.Int32, ssENOrderMain.ssPreviousOrderStatusId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssAssignmentCode", DbType.String, ssENOrderMain.ssAssignmentCode);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENOrderMain.ssSupplierId);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENOrderMain.ssCompanyId);
}
if(usedFields[8]) {
if ((ssENOrderMain.ssDocumentTypeId==0L)) {
sqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, ssENOrderMain.ssDocumentTypeId);

}
}
if(usedFields[9]) {
if ((ssENOrderMain.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderMain.ssCurrencyId);

}
}
if(usedFields[10]) {
if ((ssENOrderMain.ssTelcelDirectionId==0L)) {
sqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, ssENOrderMain.ssTelcelDirectionId);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssProcurementGroup", DbType.String, ssENOrderMain.ssProcurementGroup);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssCreatorSAPNumber", DbType.String, ssENOrderMain.ssCreatorSAPNumber);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssCreatorSAPName", DbType.String, ssENOrderMain.ssCreatorSAPName);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCountry", DbType.String, ssENOrderMain.ssCountry);
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssIsDeleted", DbType.Boolean, ssENOrderMain.ssIsDeleted);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssIsReleased", DbType.Boolean, ssENOrderMain.ssIsReleased);
}
if(usedFields[17]) {
var ExchangeRateParameter = sqlCmd.CreateParameter("@ssExchangeRate", DbType.Decimal, ssENOrderMain.ssExchangeRate);
{
    string decimalAsStr = ssENOrderMain.ssExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssSustainabilityCategory", DbType.String, ssENOrderMain.ssSustainabilityCategory);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssSustainabilitySubcategory", DbType.String, ssENOrderMain.ssSustainabilitySubcategory);
}
if(usedFields[20]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENOrderMain.ssTotalAmount);
{
    string decimalAsStr = ssENOrderMain.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssFromCosmoz", DbType.Boolean, ssENOrderMain.ssFromCosmoz);
}
if(usedFields[22]) {
if ((ssENOrderMain.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderMain.ssRegionId);

}
}
if(usedFields[23]) {
if ((ssENOrderMain.ssDivisionId==0L)) {
sqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, ssENOrderMain.ssDivisionId);

}
}
if(usedFields[24]) {
sqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderMain.ssApplicant);
}
if(usedFields[25]) {
if ((ssENOrderMain.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderMain.ssCreatedBy);

}
}
if(usedFields[26]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderMain.ssCreatedOn);
}
if(usedFields[27]) {
if ((ssENOrderMain.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderMain.ssUpdatedBy);

}
}
if(usedFields[28]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderMain.ssUpdatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrderMain_ssId_OrderMain", DbType.Int64, ssENOrderMain.ssId);
int counter = 0;
if(ssENOrderMain.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderMain (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderMainEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
" ) VALUES (" +
" @ssOrderNumber" +
", @ssOrderDate" +
", @ssOrderStatusId" +
", @ssPreviousOrderStatusId" +
", @ssAssignmentCode" +
", @ssSupplierId" +
", @ssCompanyId" +
", @ssDocumentTypeId" +
", @ssCurrencyId" +
", @ssTelcelDirectionId" +
", @ssProcurementGroup" +
", @ssCreatorSAPNumber" +
", @ssCreatorSAPName" +
", @ssCountry" +
", @ssIsDeleted" +
", @ssIsReleased" +
", @ssExchangeRate" +
", @ssSustainabilityCategory" +
", @ssSustainabilitySubcategory" +
", @ssTotalAmount" +
", @ssFromCosmoz" +
", @ssRegionId" +
", @ssDivisionId" +
", @ssApplicant" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssOrderNumber", DbType.String, ssENOrderMain.ssOrderNumber);
insertSqlCmd.CreateParameter("@ssOrderDate", DbType.DateTime, ssENOrderMain.ssOrderDate);
insertSqlCmd.CreateParameter("@ssOrderStatusId", DbType.Int32, ssENOrderMain.ssOrderStatusId);
if ((ssENOrderMain.ssPreviousOrderStatusId==0)) {
insertSqlCmd.CreateParameter("@ssPreviousOrderStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPreviousOrderStatusId", DbType.Int32, ssENOrderMain.ssPreviousOrderStatusId);

}
insertSqlCmd.CreateParameter("@ssAssignmentCode", DbType.String, ssENOrderMain.ssAssignmentCode);
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENOrderMain.ssSupplierId);
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENOrderMain.ssCompanyId);
if ((ssENOrderMain.ssDocumentTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, ssENOrderMain.ssDocumentTypeId);

}
if ((ssENOrderMain.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderMain.ssCurrencyId);

}
if ((ssENOrderMain.ssTelcelDirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, ssENOrderMain.ssTelcelDirectionId);

}
insertSqlCmd.CreateParameter("@ssProcurementGroup", DbType.String, ssENOrderMain.ssProcurementGroup);
insertSqlCmd.CreateParameter("@ssCreatorSAPNumber", DbType.String, ssENOrderMain.ssCreatorSAPNumber);
insertSqlCmd.CreateParameter("@ssCreatorSAPName", DbType.String, ssENOrderMain.ssCreatorSAPName);
insertSqlCmd.CreateParameter("@ssCountry", DbType.String, ssENOrderMain.ssCountry);
insertSqlCmd.CreateParameter("@ssIsDeleted", DbType.Boolean, ssENOrderMain.ssIsDeleted);
insertSqlCmd.CreateParameter("@ssIsReleased", DbType.Boolean, ssENOrderMain.ssIsReleased);
var ExchangeRateParameter = insertSqlCmd.CreateParameter("@ssExchangeRate", DbType.Decimal, ssENOrderMain.ssExchangeRate);
{
    string decimalAsStr = ssENOrderMain.ssExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssSustainabilityCategory", DbType.String, ssENOrderMain.ssSustainabilityCategory);
insertSqlCmd.CreateParameter("@ssSustainabilitySubcategory", DbType.String, ssENOrderMain.ssSustainabilitySubcategory);
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENOrderMain.ssTotalAmount);
{
    string decimalAsStr = ssENOrderMain.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssFromCosmoz", DbType.Boolean, ssENOrderMain.ssFromCosmoz);
if ((ssENOrderMain.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderMain.ssRegionId);

}
if ((ssENOrderMain.ssDivisionId==0L)) {
insertSqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, ssENOrderMain.ssDivisionId);

}
insertSqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderMain.ssApplicant);
if ((ssENOrderMain.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderMain.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderMain.ssCreatedOn);
if ((ssENOrderMain.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderMain.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderMain.ssUpdatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderMain", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderMain.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderMain
/// </summary>

public static async Task CreateOrUpdateSomeOrderMain(IRequestContext requestContext,RL_339e5fbd74448809f3620bf1c8c54b9a inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderMainEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ") VALUES ( unnest(@ssOrderNumber),  unnest(@ssOrderDate),  unnest(@ssOrderStatusId),  unnest(@ssPreviousOrderStatusId),  unnest(@ssAssignmentCode),  unnest(@ssSupplierId),  unnest(@ssCompanyId),  unnest(@ssDocumentTypeId),  unnest(@ssCurrencyId),  unnest(@ssTelcelDirectionId),  unnest(@ssProcurementGroup),  unnest(@ssCreatorSAPNumber),  unnest(@ssCreatorSAPName),  unnest(@ssCountry),  unnest(@ssIsDeleted),  unnest(@ssIsReleased),  unnest(@ssExchangeRate),  unnest(@ssSustainabilityCategory),  unnest(@ssSustainabilitySubcategory),  unnest(@ssTotalAmount),  unnest(@ssFromCosmoz),  unnest(@ssRegionId),  unnest(@ssDivisionId),  unnest(@ssApplicant),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssUpdatedBy),  unnest(@ssUpdatedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + ",  unnest(@ssOrderDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate") + ",  unnest(@ssOrderStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid") + ",  unnest(@ssPreviousOrderStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid") + ",  unnest(@ssAssignmentCode) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode") + ",  unnest(@ssSupplierId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ",  unnest(@ssCompanyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ",  unnest(@ssDocumentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + ",  unnest(@ssCurrencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ",  unnest(@ssTelcelDirectionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + ",  unnest(@ssProcurementGroup) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup") + ",  unnest(@ssCreatorSAPNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber") + ",  unnest(@ssCreatorSAPName) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname") + ",  unnest(@ssCountry) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country") + ",  unnest(@ssIsDeleted) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + ",  unnest(@ssIsReleased) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased") + ",  unnest(@ssExchangeRate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate") + ",  unnest(@ssSustainabilityCategory) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory") + ",  unnest(@ssSustainabilitySubcategory) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory") + ",  unnest(@ssTotalAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ",  unnest(@ssFromCosmoz) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz") + ",  unnest(@ssRegionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid") + ",  unnest(@ssDivisionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + ",  unnest(@ssApplicant) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssUpdatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ",  unnest(@ssUpdatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<string> insertOrderNumberList = new List<string>();
List<DateTime> insertOrderDateList = new List<DateTime>();
List<object> insertOrderStatusIdList = new List<object>();
List<object> insertPreviousOrderStatusIdList = new List<object>();
List<string> insertAssignmentCodeList = new List<string>();
List<object> insertSupplierIdList = new List<object>();
List<object> insertCompanyIdList = new List<object>();
List<object> insertDocumentTypeIdList = new List<object>();
List<object> insertCurrencyIdList = new List<object>();
List<object> insertTelcelDirectionIdList = new List<object>();
List<string> insertProcurementGroupList = new List<string>();
List<string> insertCreatorSAPNumberList = new List<string>();
List<string> insertCreatorSAPNameList = new List<string>();
List<string> insertCountryList = new List<string>();
List<bool> insertIsDeletedList = new List<bool>();
List<bool> insertIsReleasedList = new List<bool>();
List<decimal> insertExchangeRateList = new List<decimal>();
List<string> insertSustainabilityCategoryList = new List<string>();
List<string> insertSustainabilitySubcategoryList = new List<string>();
List<decimal> insertTotalAmountList = new List<decimal>();
List<bool> insertFromCosmozList = new List<bool>();
List<object> insertRegionIdList = new List<object>();
List<object> insertDivisionIdList = new List<object>();
List<string> insertApplicantList = new List<string>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertUpdatedByList = new List<object>();
List<DateTime> insertUpdatedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<string> updateOrderNumberList = new List<string>();
List<DateTime> updateOrderDateList = new List<DateTime>();
List<object> updateOrderStatusIdList = new List<object>();
List<object> updatePreviousOrderStatusIdList = new List<object>();
List<string> updateAssignmentCodeList = new List<string>();
List<object> updateSupplierIdList = new List<object>();
List<object> updateCompanyIdList = new List<object>();
List<object> updateDocumentTypeIdList = new List<object>();
List<object> updateCurrencyIdList = new List<object>();
List<object> updateTelcelDirectionIdList = new List<object>();
List<string> updateProcurementGroupList = new List<string>();
List<string> updateCreatorSAPNumberList = new List<string>();
List<string> updateCreatorSAPNameList = new List<string>();
List<string> updateCountryList = new List<string>();
List<bool> updateIsDeletedList = new List<bool>();
List<bool> updateIsReleasedList = new List<bool>();
List<decimal> updateExchangeRateList = new List<decimal>();
List<string> updateSustainabilityCategoryList = new List<string>();
List<string> updateSustainabilitySubcategoryList = new List<string>();
List<decimal> updateTotalAmountList = new List<decimal>();
List<bool> updateFromCosmozList = new List<bool>();
List<object> updateRegionIdList = new List<object>();
List<object> updateDivisionIdList = new List<object>();
List<string> updateApplicantList = new List<string>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateUpdatedByList = new List<object>();
List<DateTime> updateUpdatedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_1583d548420c231ffb93458312800446)inParamSourceList.Current).ssENOrderMain;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateOrderNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrderNumber));
updateOrderDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssOrderDate));
updateOrderStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssOrderStatusId));
if ((record.ssPreviousOrderStatusId==0)) {
updatePreviousOrderStatusIdList.Add(null);
} else {
updatePreviousOrderStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssPreviousOrderStatusId));
}
updateAssignmentCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignmentCode));
updateSupplierIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSupplierId));
updateCompanyIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCompanyId));
if ((record.ssDocumentTypeId==0L)) {
updateDocumentTypeIdList.Add(null);
} else {
updateDocumentTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDocumentTypeId));
}
if ((record.ssCurrencyId=="")) {
updateCurrencyIdList.Add(null);
} else {
updateCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssTelcelDirectionId==0L)) {
updateTelcelDirectionIdList.Add(null);
} else {
updateTelcelDirectionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssTelcelDirectionId));
}
updateProcurementGroupList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcurementGroup));
updateCreatorSAPNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatorSAPNumber));
updateCreatorSAPNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatorSAPName));
updateCountryList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCountry));
updateIsDeletedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsDeleted));
updateIsReleasedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReleased));
updateExchangeRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssExchangeRate));
updateSustainabilityCategoryList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSustainabilityCategory));
updateSustainabilitySubcategoryList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSustainabilitySubcategory));
updateTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
updateFromCosmozList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssFromCosmoz));
if ((record.ssRegionId==0L)) {
updateRegionIdList.Add(null);
} else {
updateRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
if ((record.ssDivisionId==0L)) {
updateDivisionIdList.Add(null);
} else {
updateDivisionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDivisionId));
}
updateApplicantList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicant));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssUpdatedBy=="")) {
updateUpdatedByList.Add(null);
} else {
updateUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
updateUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
} else {
insertOrderNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrderNumber));
insertOrderDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssOrderDate));
insertOrderStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssOrderStatusId));
if ((record.ssPreviousOrderStatusId==0)) {
insertPreviousOrderStatusIdList.Add(null);
} else {
insertPreviousOrderStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssPreviousOrderStatusId));
}
insertAssignmentCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignmentCode));
insertSupplierIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSupplierId));
insertCompanyIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCompanyId));
if ((record.ssDocumentTypeId==0L)) {
insertDocumentTypeIdList.Add(null);
} else {
insertDocumentTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDocumentTypeId));
}
if ((record.ssCurrencyId=="")) {
insertCurrencyIdList.Add(null);
} else {
insertCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssTelcelDirectionId==0L)) {
insertTelcelDirectionIdList.Add(null);
} else {
insertTelcelDirectionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssTelcelDirectionId));
}
insertProcurementGroupList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProcurementGroup));
insertCreatorSAPNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatorSAPNumber));
insertCreatorSAPNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatorSAPName));
insertCountryList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCountry));
insertIsDeletedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsDeleted));
insertIsReleasedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsReleased));
insertExchangeRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssExchangeRate));
insertSustainabilityCategoryList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSustainabilityCategory));
insertSustainabilitySubcategoryList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSustainabilitySubcategory));
insertTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
insertFromCosmozList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssFromCosmoz));
if ((record.ssRegionId==0L)) {
insertRegionIdList.Add(null);
} else {
insertRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
if ((record.ssDivisionId==0L)) {
insertDivisionIdList.Add(null);
} else {
insertDivisionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDivisionId));
}
insertApplicantList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicant));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssUpdatedBy=="")) {
insertUpdatedByList.Add(null);
} else {
insertUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
insertUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderNumberList.IsEmpty() || !insertOrderDateList.IsEmpty() || !insertOrderStatusIdList.IsEmpty() || !insertPreviousOrderStatusIdList.IsEmpty() || !insertAssignmentCodeList.IsEmpty() || !insertSupplierIdList.IsEmpty() || !insertCompanyIdList.IsEmpty() || !insertDocumentTypeIdList.IsEmpty() || !insertCurrencyIdList.IsEmpty() || !insertTelcelDirectionIdList.IsEmpty() || !insertProcurementGroupList.IsEmpty() || !insertCreatorSAPNumberList.IsEmpty() || !insertCreatorSAPNameList.IsEmpty() || !insertCountryList.IsEmpty() || !insertIsDeletedList.IsEmpty() || !insertIsReleasedList.IsEmpty() || !insertExchangeRateList.IsEmpty() || !insertSustainabilityCategoryList.IsEmpty() || !insertSustainabilitySubcategoryList.IsEmpty() || !insertTotalAmountList.IsEmpty() || !insertFromCosmozList.IsEmpty() || !insertRegionIdList.IsEmpty() || !insertDivisionIdList.IsEmpty() || !insertApplicantList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertUpdatedByList.IsEmpty() || !insertUpdatedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderNumber",DbType.String,insertOrderNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderDate",DbType.DateTime,insertOrderDateList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderStatusId",DbType.Int32,insertOrderStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPreviousOrderStatusId",DbType.Int32,insertPreviousOrderStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAssignmentCode",DbType.String,insertAssignmentCodeList);
executionService.CreateParameter(insertSqlCmd,"@ssSupplierId",DbType.Int64,insertSupplierIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCompanyId",DbType.Int64,insertCompanyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDocumentTypeId",DbType.Int64,insertDocumentTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrencyId",DbType.String,insertCurrencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTelcelDirectionId",DbType.Int64,insertTelcelDirectionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProcurementGroup",DbType.String,insertProcurementGroupList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatorSAPNumber",DbType.String,insertCreatorSAPNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatorSAPName",DbType.String,insertCreatorSAPNameList);
executionService.CreateParameter(insertSqlCmd,"@ssCountry",DbType.String,insertCountryList);
executionService.CreateParameter(insertSqlCmd,"@ssIsDeleted",DbType.Boolean,insertIsDeletedList);
executionService.CreateParameter(insertSqlCmd,"@ssIsReleased",DbType.Boolean,insertIsReleasedList);
executionService.CreateParameter(insertSqlCmd,"@ssExchangeRate",DbType.Decimal,insertExchangeRateList);
executionService.CreateParameter(insertSqlCmd,"@ssSustainabilityCategory",DbType.String,insertSustainabilityCategoryList);
executionService.CreateParameter(insertSqlCmd,"@ssSustainabilitySubcategory",DbType.String,insertSustainabilitySubcategoryList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalAmount",DbType.Decimal,insertTotalAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssFromCosmoz",DbType.Boolean,insertFromCosmozList);
executionService.CreateParameter(insertSqlCmd,"@ssRegionId",DbType.Int64,insertRegionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDivisionId",DbType.Int64,insertDivisionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicant",DbType.String,insertApplicantList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedBy",DbType.String,insertUpdatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedOn",DbType.DateTime,insertUpdatedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderMain (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderNumberList.IsEmpty() || !updateOrderDateList.IsEmpty() || !updateOrderStatusIdList.IsEmpty() || !updatePreviousOrderStatusIdList.IsEmpty() || !updateAssignmentCodeList.IsEmpty() || !updateSupplierIdList.IsEmpty() || !updateCompanyIdList.IsEmpty() || !updateDocumentTypeIdList.IsEmpty() || !updateCurrencyIdList.IsEmpty() || !updateTelcelDirectionIdList.IsEmpty() || !updateProcurementGroupList.IsEmpty() || !updateCreatorSAPNumberList.IsEmpty() || !updateCreatorSAPNameList.IsEmpty() || !updateCountryList.IsEmpty() || !updateIsDeletedList.IsEmpty() || !updateIsReleasedList.IsEmpty() || !updateExchangeRateList.IsEmpty() || !updateSustainabilityCategoryList.IsEmpty() || !updateSustainabilitySubcategoryList.IsEmpty() || !updateTotalAmountList.IsEmpty() || !updateFromCosmozList.IsEmpty() || !updateRegionIdList.IsEmpty() || !updateDivisionIdList.IsEmpty() || !updateApplicantList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateUpdatedByList.IsEmpty() || !updateUpdatedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderNumber",DbType.String,updateOrderNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderDate",DbType.DateTime,updateOrderDateList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderStatusId",DbType.Int32,updateOrderStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssPreviousOrderStatusId",DbType.Int32,updatePreviousOrderStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAssignmentCode",DbType.String,updateAssignmentCodeList);
executionService.CreateParameter(updateSqlCmd,"@ssSupplierId",DbType.Int64,updateSupplierIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCompanyId",DbType.Int64,updateCompanyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDocumentTypeId",DbType.Int64,updateDocumentTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrencyId",DbType.String,updateCurrencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTelcelDirectionId",DbType.Int64,updateTelcelDirectionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProcurementGroup",DbType.String,updateProcurementGroupList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatorSAPNumber",DbType.String,updateCreatorSAPNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatorSAPName",DbType.String,updateCreatorSAPNameList);
executionService.CreateParameter(updateSqlCmd,"@ssCountry",DbType.String,updateCountryList);
executionService.CreateParameter(updateSqlCmd,"@ssIsDeleted",DbType.Boolean,updateIsDeletedList);
executionService.CreateParameter(updateSqlCmd,"@ssIsReleased",DbType.Boolean,updateIsReleasedList);
executionService.CreateParameter(updateSqlCmd,"@ssExchangeRate",DbType.Decimal,updateExchangeRateList);
executionService.CreateParameter(updateSqlCmd,"@ssSustainabilityCategory",DbType.String,updateSustainabilityCategoryList);
executionService.CreateParameter(updateSqlCmd,"@ssSustainabilitySubcategory",DbType.String,updateSustainabilitySubcategoryList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalAmount",DbType.Decimal,updateTotalAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssFromCosmoz",DbType.Boolean,updateFromCosmozList);
executionService.CreateParameter(updateSqlCmd,"@ssRegionId",DbType.Int64,updateRegionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDivisionId",DbType.Int64,updateDivisionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicant",DbType.String,updateApplicantList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedBy",DbType.String,updateUpdatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedOn",DbType.DateTime,updateUpdatedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderMain (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderMain
/// </summary>

public static async Task DeleteOrderMain(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderMainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderMain", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderMain
/// </summary>

public static async Task DeleteAllOrderMain(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderMainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderMain", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderMain
/// </summary>

public static async Task<RC_1583d548420c231ffb93458312800446> GetOrderMain(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1583d548420c231ffb93458312800446 outParamRecord = default;
outParamRecord = new RC_1583d548420c231ffb93458312800446();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrderMainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderMain", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(29,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderMainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderMainForUpdate
/// </summary>

public static async Task<RC_1583d548420c231ffb93458312800446> GetOrderMainForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1583d548420c231ffb93458312800446 outParamRecord = default;
outParamRecord = new RC_1583d548420c231ffb93458312800446();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderMainForUpdate", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderMainForUpdate", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrderMainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderMainForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(29,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderMainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderMain
/// </summary>

public static async Task UpdateOrderMain(IRequestContext requestContext,BitArray usedFields,RC_1583d548420c231ffb93458312800446 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderMain", "8e9d0d7d-2397-4726-bc09-7c8487b8b157.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(29,true);
}
string updateSet = "UPDATE " + ENOrderMainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderNumber, "ordernumber") ?? "ordernumber") + " = @ssOrderNumber"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderDate, "orderdate") ?? "orderdate") + " = @ssOrderDate"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@OrderStatusId, "orderstatusid") ?? "orderstatusid") + " = @ssOrderStatusId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@PreviousOrderStatusId, "previousorderstatusid") ?? "previousorderstatusid") + " = @ssPreviousOrderStatusId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@AssignmentCode, "assignmentcode") ?? "assignmentcode") + " = @ssAssignmentCode"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = @ssSupplierId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = @ssCompanyId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + " = @ssDocumentTypeId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + " = @ssTelcelDirectionId"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ProcurementGroup, "procurementgroup") ?? "procurementgroup") + " = @ssProcurementGroup"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPNumber, "creatorsapnumber") ?? "creatorsapnumber") + " = @ssCreatorSAPNumber"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatorSAPName, "creatorsapname") ?? "creatorsapname") + " = @ssCreatorSAPName"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Country, "country") ?? "country") + " = @ssCountry"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = @ssIsDeleted"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsReleased, "isreleased") ?? "isreleased") + " = @ssIsReleased"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@ExchangeRate, "exchangerate") ?? "exchangerate") + " = @ssExchangeRate"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilityCategory, "sustainabilitycategory") ?? "sustainabilitycategory") + " = @ssSustainabilityCategory"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@SustainabilitySubcategory, "sustainabilitysubcategory") ?? "sustainabilitysubcategory") + " = @ssSustainabilitySubcategory"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@FromCosmoz, "fromcosmoz") ?? "fromcosmoz") + " = @ssFromCosmoz"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + " = @ssDivisionId"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Applicant, "applicant") ?? "applicant") + " = @ssApplicant"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[28] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderMain_ssId_OrderMain";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMain, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssOrderNumber", DbType.String, ssENOrderMain.ssOrderNumber);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssOrderDate", DbType.DateTime, ssENOrderMain.ssOrderDate);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOrderStatusId", DbType.Int32, ssENOrderMain.ssOrderStatusId);
}
if(usedFields[4]) {
if ((ssENOrderMain.ssPreviousOrderStatusId==0)) {
sqlCmd.CreateParameter("@ssPreviousOrderStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPreviousOrderStatusId", DbType.Int32, ssENOrderMain.ssPreviousOrderStatusId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssAssignmentCode", DbType.String, ssENOrderMain.ssAssignmentCode);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENOrderMain.ssSupplierId);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENOrderMain.ssCompanyId);
}
if(usedFields[8]) {
if ((ssENOrderMain.ssDocumentTypeId==0L)) {
sqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, ssENOrderMain.ssDocumentTypeId);

}
}
if(usedFields[9]) {
if ((ssENOrderMain.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderMain.ssCurrencyId);

}
}
if(usedFields[10]) {
if ((ssENOrderMain.ssTelcelDirectionId==0L)) {
sqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, ssENOrderMain.ssTelcelDirectionId);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssProcurementGroup", DbType.String, ssENOrderMain.ssProcurementGroup);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssCreatorSAPNumber", DbType.String, ssENOrderMain.ssCreatorSAPNumber);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssCreatorSAPName", DbType.String, ssENOrderMain.ssCreatorSAPName);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCountry", DbType.String, ssENOrderMain.ssCountry);
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssIsDeleted", DbType.Boolean, ssENOrderMain.ssIsDeleted);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssIsReleased", DbType.Boolean, ssENOrderMain.ssIsReleased);
}
if(usedFields[17]) {
var ExchangeRateParameter = sqlCmd.CreateParameter("@ssExchangeRate", DbType.Decimal, ssENOrderMain.ssExchangeRate);
{
    string decimalAsStr = ssENOrderMain.ssExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssSustainabilityCategory", DbType.String, ssENOrderMain.ssSustainabilityCategory);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssSustainabilitySubcategory", DbType.String, ssENOrderMain.ssSustainabilitySubcategory);
}
if(usedFields[20]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENOrderMain.ssTotalAmount);
{
    string decimalAsStr = ssENOrderMain.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssFromCosmoz", DbType.Boolean, ssENOrderMain.ssFromCosmoz);
}
if(usedFields[22]) {
if ((ssENOrderMain.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderMain.ssRegionId);

}
}
if(usedFields[23]) {
if ((ssENOrderMain.ssDivisionId==0L)) {
sqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, ssENOrderMain.ssDivisionId);

}
}
if(usedFields[24]) {
sqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderMain.ssApplicant);
}
if(usedFields[25]) {
if ((ssENOrderMain.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderMain.ssCreatedBy);

}
}
if(usedFields[26]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderMain.ssCreatedOn);
}
if(usedFields[27]) {
if ((ssENOrderMain.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderMain.ssUpdatedBy);

}
}
if(usedFields[28]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderMain.ssUpdatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrderMain_ssId_OrderMain", DbType.Int64, ssENOrderMain.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderMain", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderMain", ssENOrderMain.ssId.ToString()); }}
}
return;
}

}
}
