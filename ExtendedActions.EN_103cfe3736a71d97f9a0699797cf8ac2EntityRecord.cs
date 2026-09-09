using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceAccountingServices
/// </summary>

public static async Task<long> CreateInvoiceAccountingServices(IRequestContext requestContext,RC_5a609a7b7b622cde2859ca506690f8db inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord ssENInvoiceAccountingServices = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingServicesEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme") + "" +
" ) VALUES (" +
" @ssInvoiceAccountingId" +
", @ssServiceTypeId" +
", @ssAccount" +
", @ssCostCenterId" +
", @ssCeBeCostCenterId" +
", @ssAmount" +
", @ssIVA_Old" +
", @ssIVAIndicatorId" +
", @ssBuyDocNumber" +
", @ssBuyDocPosition" +
", @ssFreeText" +
", @ssDivision" +
", @ssICME" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccountingServices.ssInvoiceAccountingId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceAccountingId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceAccountingId", DbType.Int64, ssENInvoiceAccountingServices.ssInvoiceAccountingId);

}
if ((ssENInvoiceAccountingServices.ssServiceTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, ssENInvoiceAccountingServices.ssServiceTypeId);

}
insertSqlCmd.CreateParameter("@ssAccount", DbType.String, ssENInvoiceAccountingServices.ssAccount);
if ((ssENInvoiceAccountingServices.ssCostCenterId==0L)) {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENInvoiceAccountingServices.ssCostCenterId);

}
if ((ssENInvoiceAccountingServices.ssCeBeCostCenterId==0L)) {
insertSqlCmd.CreateParameter("@ssCeBeCostCenterId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCeBeCostCenterId", DbType.Int64, ssENInvoiceAccountingServices.ssCeBeCostCenterId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENInvoiceAccountingServices.ssAmount);
{
    string decimalAsStr = ssENInvoiceAccountingServices.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIVA_Old", DbType.String, ssENInvoiceAccountingServices.ssIVA_Old);
if ((ssENInvoiceAccountingServices.ssIVAIndicatorId==0L)) {
insertSqlCmd.CreateParameter("@ssIVAIndicatorId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIVAIndicatorId", DbType.Int64, ssENInvoiceAccountingServices.ssIVAIndicatorId);

}
insertSqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENInvoiceAccountingServices.ssBuyDocNumber);
insertSqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENInvoiceAccountingServices.ssBuyDocPosition);
insertSqlCmd.CreateParameter("@ssFreeText", DbType.String, ssENInvoiceAccountingServices.ssFreeText);
insertSqlCmd.CreateParameter("@ssDivision", DbType.String, ssENInvoiceAccountingServices.ssDivision);
insertSqlCmd.CreateParameter("@ssICME", DbType.String, ssENInvoiceAccountingServices.ssICME);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceAccountingServices", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceAccountingServices
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceAccountingServices(IRequestContext requestContext,BitArray usedFields,RC_5a609a7b7b622cde2859ca506690f8db inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord ssENInvoiceAccountingServices = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(14,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingServicesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid") + " = @ssInvoiceAccountingId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + " = @ssServiceTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account") + " = @ssAccount"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + " = @ssCostCenterId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid") + " = @ssCeBeCostCenterId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old") + " = @ssIVA_Old"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + " = @ssIVAIndicatorId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + " = @ssBuyDocNumber"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " = @ssBuyDocPosition"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext") + " = @ssFreeText"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division") + " = @ssDivision"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme") + " = @ssICME"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAccntingServices_sd_InvoiceAccoutingServices";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccountingServices.ssInvoiceAccountingId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceAccountingId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceAccountingId", DbType.Int64, ssENInvoiceAccountingServices.ssInvoiceAccountingId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceAccountingServices.ssServiceTypeId==0L)) {
sqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, ssENInvoiceAccountingServices.ssServiceTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssAccount", DbType.String, ssENInvoiceAccountingServices.ssAccount);
}
if(usedFields[4]) {
if ((ssENInvoiceAccountingServices.ssCostCenterId==0L)) {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENInvoiceAccountingServices.ssCostCenterId);

}
}
if(usedFields[5]) {
if ((ssENInvoiceAccountingServices.ssCeBeCostCenterId==0L)) {
sqlCmd.CreateParameter("@ssCeBeCostCenterId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCeBeCostCenterId", DbType.Int64, ssENInvoiceAccountingServices.ssCeBeCostCenterId);

}
}
if(usedFields[6]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENInvoiceAccountingServices.ssAmount);
{
    string decimalAsStr = ssENInvoiceAccountingServices.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIVA_Old", DbType.String, ssENInvoiceAccountingServices.ssIVA_Old);
}
if(usedFields[8]) {
if ((ssENInvoiceAccountingServices.ssIVAIndicatorId==0L)) {
sqlCmd.CreateParameter("@ssIVAIndicatorId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIVAIndicatorId", DbType.Int64, ssENInvoiceAccountingServices.ssIVAIndicatorId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENInvoiceAccountingServices.ssBuyDocNumber);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENInvoiceAccountingServices.ssBuyDocPosition);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssFreeText", DbType.String, ssENInvoiceAccountingServices.ssFreeText);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssDivision", DbType.String, ssENInvoiceAccountingServices.ssDivision);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssICME", DbType.String, ssENInvoiceAccountingServices.ssICME);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAccntingServices_sd_InvoiceAccoutingServices", DbType.Int64, ssENInvoiceAccountingServices.ssId);
int counter = 0;
if(ssENInvoiceAccountingServices.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingServices (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingServicesEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme") + "" +
" ) VALUES (" +
" @ssInvoiceAccountingId" +
", @ssServiceTypeId" +
", @ssAccount" +
", @ssCostCenterId" +
", @ssCeBeCostCenterId" +
", @ssAmount" +
", @ssIVA_Old" +
", @ssIVAIndicatorId" +
", @ssBuyDocNumber" +
", @ssBuyDocPosition" +
", @ssFreeText" +
", @ssDivision" +
", @ssICME" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccountingServices.ssInvoiceAccountingId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceAccountingId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceAccountingId", DbType.Int64, ssENInvoiceAccountingServices.ssInvoiceAccountingId);

}
if ((ssENInvoiceAccountingServices.ssServiceTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, ssENInvoiceAccountingServices.ssServiceTypeId);

}
insertSqlCmd.CreateParameter("@ssAccount", DbType.String, ssENInvoiceAccountingServices.ssAccount);
if ((ssENInvoiceAccountingServices.ssCostCenterId==0L)) {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENInvoiceAccountingServices.ssCostCenterId);

}
if ((ssENInvoiceAccountingServices.ssCeBeCostCenterId==0L)) {
insertSqlCmd.CreateParameter("@ssCeBeCostCenterId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCeBeCostCenterId", DbType.Int64, ssENInvoiceAccountingServices.ssCeBeCostCenterId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENInvoiceAccountingServices.ssAmount);
{
    string decimalAsStr = ssENInvoiceAccountingServices.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIVA_Old", DbType.String, ssENInvoiceAccountingServices.ssIVA_Old);
if ((ssENInvoiceAccountingServices.ssIVAIndicatorId==0L)) {
insertSqlCmd.CreateParameter("@ssIVAIndicatorId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIVAIndicatorId", DbType.Int64, ssENInvoiceAccountingServices.ssIVAIndicatorId);

}
insertSqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENInvoiceAccountingServices.ssBuyDocNumber);
insertSqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENInvoiceAccountingServices.ssBuyDocPosition);
insertSqlCmd.CreateParameter("@ssFreeText", DbType.String, ssENInvoiceAccountingServices.ssFreeText);
insertSqlCmd.CreateParameter("@ssDivision", DbType.String, ssENInvoiceAccountingServices.ssDivision);
insertSqlCmd.CreateParameter("@ssICME", DbType.String, ssENInvoiceAccountingServices.ssICME);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingServices", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceAccountingServices.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceAccountingServices
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceAccountingServices(IRequestContext requestContext,RL_ce67f504f77874aaecc91ad036f8a95a inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceAccountingServicesEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme") + ") VALUES ( unnest(@ssInvoiceAccountingId),  unnest(@ssServiceTypeId),  unnest(@ssAccount),  unnest(@ssCostCenterId),  unnest(@ssCeBeCostCenterId),  unnest(@ssAmount),  unnest(@ssIVA_Old),  unnest(@ssIVAIndicatorId),  unnest(@ssBuyDocNumber),  unnest(@ssBuyDocPosition),  unnest(@ssFreeText),  unnest(@ssDivision),  unnest(@ssICME)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceAccountingId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid") + ",  unnest(@ssServiceTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + ",  unnest(@ssAccount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account") + ",  unnest(@ssCostCenterId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + ",  unnest(@ssCeBeCostCenterId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid") + ",  unnest(@ssAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + ",  unnest(@ssIVA_Old) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old") + ",  unnest(@ssIVAIndicatorId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + ",  unnest(@ssBuyDocNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + ",  unnest(@ssBuyDocPosition) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + ",  unnest(@ssFreeText) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext") + ",  unnest(@ssDivision) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division") + ",  unnest(@ssICME) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceAccountingIdList = new List<object>();
List<object> insertServiceTypeIdList = new List<object>();
List<string> insertAccountList = new List<string>();
List<object> insertCostCenterIdList = new List<object>();
List<object> insertCeBeCostCenterIdList = new List<object>();
List<decimal> insertAmountList = new List<decimal>();
List<string> insertIVA_OldList = new List<string>();
List<object> insertIVAIndicatorIdList = new List<object>();
List<string> insertBuyDocNumberList = new List<string>();
List<string> insertBuyDocPositionList = new List<string>();
List<string> insertFreeTextList = new List<string>();
List<string> insertDivisionList = new List<string>();
List<string> insertICMEList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceAccountingIdList = new List<object>();
List<object> updateServiceTypeIdList = new List<object>();
List<string> updateAccountList = new List<string>();
List<object> updateCostCenterIdList = new List<object>();
List<object> updateCeBeCostCenterIdList = new List<object>();
List<decimal> updateAmountList = new List<decimal>();
List<string> updateIVA_OldList = new List<string>();
List<object> updateIVAIndicatorIdList = new List<object>();
List<string> updateBuyDocNumberList = new List<string>();
List<string> updateBuyDocPositionList = new List<string>();
List<string> updateFreeTextList = new List<string>();
List<string> updateDivisionList = new List<string>();
List<string> updateICMEList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_5a609a7b7b622cde2859ca506690f8db)inParamSourceList.Current).ssENInvoiceAccountingServices;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceAccountingId==0L)) {
updateInvoiceAccountingIdList.Add(null);
} else {
updateInvoiceAccountingIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceAccountingId));
}
if ((record.ssServiceTypeId==0L)) {
updateServiceTypeIdList.Add(null);
} else {
updateServiceTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssServiceTypeId));
}
updateAccountList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAccount));
if ((record.ssCostCenterId==0L)) {
updateCostCenterIdList.Add(null);
} else {
updateCostCenterIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostCenterId));
}
if ((record.ssCeBeCostCenterId==0L)) {
updateCeBeCostCenterIdList.Add(null);
} else {
updateCeBeCostCenterIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCeBeCostCenterId));
}
updateAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
updateIVA_OldList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIVA_Old));
if ((record.ssIVAIndicatorId==0L)) {
updateIVAIndicatorIdList.Add(null);
} else {
updateIVAIndicatorIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssIVAIndicatorId));
}
updateBuyDocNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocNumber));
updateBuyDocPositionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocPosition));
updateFreeTextList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFreeText));
updateDivisionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDivision));
updateICMEList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssICME));
} else {
if ((record.ssInvoiceAccountingId==0L)) {
insertInvoiceAccountingIdList.Add(null);
} else {
insertInvoiceAccountingIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceAccountingId));
}
if ((record.ssServiceTypeId==0L)) {
insertServiceTypeIdList.Add(null);
} else {
insertServiceTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssServiceTypeId));
}
insertAccountList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAccount));
if ((record.ssCostCenterId==0L)) {
insertCostCenterIdList.Add(null);
} else {
insertCostCenterIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostCenterId));
}
if ((record.ssCeBeCostCenterId==0L)) {
insertCeBeCostCenterIdList.Add(null);
} else {
insertCeBeCostCenterIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCeBeCostCenterId));
}
insertAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
insertIVA_OldList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIVA_Old));
if ((record.ssIVAIndicatorId==0L)) {
insertIVAIndicatorIdList.Add(null);
} else {
insertIVAIndicatorIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssIVAIndicatorId));
}
insertBuyDocNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocNumber));
insertBuyDocPositionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocPosition));
insertFreeTextList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFreeText));
insertDivisionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDivision));
insertICMEList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssICME));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceAccountingIdList.IsEmpty() || !insertServiceTypeIdList.IsEmpty() || !insertAccountList.IsEmpty() || !insertCostCenterIdList.IsEmpty() || !insertCeBeCostCenterIdList.IsEmpty() || !insertAmountList.IsEmpty() || !insertIVA_OldList.IsEmpty() || !insertIVAIndicatorIdList.IsEmpty() || !insertBuyDocNumberList.IsEmpty() || !insertBuyDocPositionList.IsEmpty() || !insertFreeTextList.IsEmpty() || !insertDivisionList.IsEmpty() || !insertICMEList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceAccountingId",DbType.Int64,insertInvoiceAccountingIdList);
executionService.CreateParameter(insertSqlCmd,"@ssServiceTypeId",DbType.Int64,insertServiceTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAccount",DbType.String,insertAccountList);
executionService.CreateParameter(insertSqlCmd,"@ssCostCenterId",DbType.Int64,insertCostCenterIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCeBeCostCenterId",DbType.Int64,insertCeBeCostCenterIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAmount",DbType.Decimal,insertAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssIVA_Old",DbType.String,insertIVA_OldList);
executionService.CreateParameter(insertSqlCmd,"@ssIVAIndicatorId",DbType.Int64,insertIVAIndicatorIdList);
executionService.CreateParameter(insertSqlCmd,"@ssBuyDocNumber",DbType.String,insertBuyDocNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssBuyDocPosition",DbType.String,insertBuyDocPositionList);
executionService.CreateParameter(insertSqlCmd,"@ssFreeText",DbType.String,insertFreeTextList);
executionService.CreateParameter(insertSqlCmd,"@ssDivision",DbType.String,insertDivisionList);
executionService.CreateParameter(insertSqlCmd,"@ssICME",DbType.String,insertICMEList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccountingServices (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceAccountingIdList.IsEmpty() || !updateServiceTypeIdList.IsEmpty() || !updateAccountList.IsEmpty() || !updateCostCenterIdList.IsEmpty() || !updateCeBeCostCenterIdList.IsEmpty() || !updateAmountList.IsEmpty() || !updateIVA_OldList.IsEmpty() || !updateIVAIndicatorIdList.IsEmpty() || !updateBuyDocNumberList.IsEmpty() || !updateBuyDocPositionList.IsEmpty() || !updateFreeTextList.IsEmpty() || !updateDivisionList.IsEmpty() || !updateICMEList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceAccountingId",DbType.Int64,updateInvoiceAccountingIdList);
executionService.CreateParameter(updateSqlCmd,"@ssServiceTypeId",DbType.Int64,updateServiceTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAccount",DbType.String,updateAccountList);
executionService.CreateParameter(updateSqlCmd,"@ssCostCenterId",DbType.Int64,updateCostCenterIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCeBeCostCenterId",DbType.Int64,updateCeBeCostCenterIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAmount",DbType.Decimal,updateAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssIVA_Old",DbType.String,updateIVA_OldList);
executionService.CreateParameter(updateSqlCmd,"@ssIVAIndicatorId",DbType.Int64,updateIVAIndicatorIdList);
executionService.CreateParameter(updateSqlCmd,"@ssBuyDocNumber",DbType.String,updateBuyDocNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssBuyDocPosition",DbType.String,updateBuyDocPositionList);
executionService.CreateParameter(updateSqlCmd,"@ssFreeText",DbType.String,updateFreeTextList);
executionService.CreateParameter(updateSqlCmd,"@ssDivision",DbType.String,updateDivisionList);
executionService.CreateParameter(updateSqlCmd,"@ssICME",DbType.String,updateICMEList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccountingServices (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceAccountingServices
/// </summary>

public static async Task DeleteInvoiceAccountingServices(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingServicesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingServices", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceAccountingServices
/// </summary>

public static async Task DeleteAllInvoiceAccountingServices(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingServicesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingServices", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceAccountingServices
/// </summary>

public static async Task<RC_5a609a7b7b622cde2859ca506690f8db> GetInvoiceAccountingServices(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5a609a7b7b622cde2859ca506690f8db outParamRecord = default;
outParamRecord = new RC_5a609a7b7b622cde2859ca506690f8db();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingServicesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingServices", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(14,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingServicesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceAccountingServicesForUpdate
/// </summary>

public static async Task<RC_5a609a7b7b622cde2859ca506690f8db> GetInvoiceAccountingServicesForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5a609a7b7b622cde2859ca506690f8db outParamRecord = default;
outParamRecord = new RC_5a609a7b7b622cde2859ca506690f8db();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingServicesForUpdate", "918e765c-22ed-4425-9197-29fec0ccc41f.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingServicesForUpdate", "918e765c-22ed-4425-9197-29fec0ccc41f.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingServicesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingServicesForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(14,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingServicesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceAccountingServices
/// </summary>

public static async Task UpdateInvoiceAccountingServices(IRequestContext requestContext,BitArray usedFields,RC_5a609a7b7b622cde2859ca506690f8db inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceAccountingServices", "918e765c-22ed-4425-9197-29fec0ccc41f.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord ssENInvoiceAccountingServices = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(14,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingServicesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@InvoiceAccountingId, "invoiceaccountingid") ?? "invoiceaccountingid") + " = @ssInvoiceAccountingId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + " = @ssServiceTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Account, "account") ?? "account") + " = @ssAccount"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + " = @ssCostCenterId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@CeBeCostCenterId, "cebecostcenterid") ?? "cebecostcenterid") + " = @ssCeBeCostCenterId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVA_Old, "iva_old") ?? "iva_old") + " = @ssIVA_Old"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@IVAIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + " = @ssIVAIndicatorId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + " = @ssBuyDocNumber"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " = @ssBuyDocPosition"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@FreeText, "freetext") ?? "freetext") + " = @ssFreeText"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Division, "division") ?? "division") + " = @ssDivision"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@ICME, "icme") ?? "icme") + " = @ssICME"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAccntingServices_sd_InvoiceAccoutingServices";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingServices, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingServicesAttributeKeys.@Amount, "amount") ?? "amount") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccountingServices.ssInvoiceAccountingId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceAccountingId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceAccountingId", DbType.Int64, ssENInvoiceAccountingServices.ssInvoiceAccountingId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceAccountingServices.ssServiceTypeId==0L)) {
sqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, ssENInvoiceAccountingServices.ssServiceTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssAccount", DbType.String, ssENInvoiceAccountingServices.ssAccount);
}
if(usedFields[4]) {
if ((ssENInvoiceAccountingServices.ssCostCenterId==0L)) {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENInvoiceAccountingServices.ssCostCenterId);

}
}
if(usedFields[5]) {
if ((ssENInvoiceAccountingServices.ssCeBeCostCenterId==0L)) {
sqlCmd.CreateParameter("@ssCeBeCostCenterId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCeBeCostCenterId", DbType.Int64, ssENInvoiceAccountingServices.ssCeBeCostCenterId);

}
}
if(usedFields[6]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENInvoiceAccountingServices.ssAmount);
{
    string decimalAsStr = ssENInvoiceAccountingServices.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIVA_Old", DbType.String, ssENInvoiceAccountingServices.ssIVA_Old);
}
if(usedFields[8]) {
if ((ssENInvoiceAccountingServices.ssIVAIndicatorId==0L)) {
sqlCmd.CreateParameter("@ssIVAIndicatorId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIVAIndicatorId", DbType.Int64, ssENInvoiceAccountingServices.ssIVAIndicatorId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENInvoiceAccountingServices.ssBuyDocNumber);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENInvoiceAccountingServices.ssBuyDocPosition);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssFreeText", DbType.String, ssENInvoiceAccountingServices.ssFreeText);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssDivision", DbType.String, ssENInvoiceAccountingServices.ssDivision);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssICME", DbType.String, ssENInvoiceAccountingServices.ssICME);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAccntingServices_sd_InvoiceAccoutingServices", DbType.Int64, ssENInvoiceAccountingServices.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceAccountingServices", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceAccountingServices", ssENInvoiceAccountingServices.ssId.ToString()); }}
}
return;
}

}
}
