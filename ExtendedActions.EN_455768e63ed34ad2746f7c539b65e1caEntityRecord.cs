using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionService
/// </summary>

public static async Task<long> CreateRequisitionService(IRequestContext requestContext,RC_04e7247757060d4016b43102119b0dd6 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_455768e63ed34ad2746f7c539b65e1caEntityRecord ssENRequisitionService = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionServiceEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssAccountingServiceTypeId" +
", @ssFrequencyId" +
", @ssAmount" +
", @ssDescription" +
", @ssInvoiceUsageId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionService.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionService.ssRequisitionId);

}
if ((ssENRequisitionService.ssAccountingServiceTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, ssENRequisitionService.ssAccountingServiceTypeId);

}
if ((ssENRequisitionService.ssFrequencyId==0)) {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENRequisitionService.ssFrequencyId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionService.ssAmount);
{
    string decimalAsStr = ssENRequisitionService.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENRequisitionService.ssDescription);
if ((ssENRequisitionService.ssInvoiceUsageId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENRequisitionService.ssInvoiceUsageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionService
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionService(IRequestContext requestContext,BitArray usedFields,RC_04e7247757060d4016b43102119b0dd6 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_455768e63ed34ad2746f7c539b65e1caEntityRecord ssENRequisitionService = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENRequisitionServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + " = @ssAccountingServiceTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = @ssFrequencyId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " = @ssInvoiceUsageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionService_ssId_RequisitionService";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionService.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionService.ssRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionService.ssAccountingServiceTypeId==0L)) {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, ssENRequisitionService.ssAccountingServiceTypeId);

}
}
if(usedFields[3]) {
if ((ssENRequisitionService.ssFrequencyId==0)) {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENRequisitionService.ssFrequencyId);

}
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionService.ssAmount);
{
    string decimalAsStr = ssENRequisitionService.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENRequisitionService.ssDescription);
}
if(usedFields[6]) {
if ((ssENRequisitionService.ssInvoiceUsageId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENRequisitionService.ssInvoiceUsageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionService_ssId_RequisitionService", DbType.Int64, ssENRequisitionService.ssId);
int counter = 0;
if(ssENRequisitionService.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionService (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionServiceEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssAccountingServiceTypeId" +
", @ssFrequencyId" +
", @ssAmount" +
", @ssDescription" +
", @ssInvoiceUsageId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionService.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionService.ssRequisitionId);

}
if ((ssENRequisitionService.ssAccountingServiceTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, ssENRequisitionService.ssAccountingServiceTypeId);

}
if ((ssENRequisitionService.ssFrequencyId==0)) {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENRequisitionService.ssFrequencyId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionService.ssAmount);
{
    string decimalAsStr = ssENRequisitionService.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENRequisitionService.ssDescription);
if ((ssENRequisitionService.ssInvoiceUsageId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENRequisitionService.ssInvoiceUsageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionService.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionService
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionService(IRequestContext requestContext,RL_b47d9310671b1b627f451a333bb8980a inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionServiceEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + ") VALUES ( unnest(@ssRequisitionId),  unnest(@ssAccountingServiceTypeId),  unnest(@ssFrequencyId),  unnest(@ssAmount),  unnest(@ssDescription),  unnest(@ssInvoiceUsageId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ",  unnest(@ssAccountingServiceTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + ",  unnest(@ssFrequencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + ",  unnest(@ssAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount") + ",  unnest(@ssDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description") + ",  unnest(@ssInvoiceUsageId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertRequisitionIdList = new List<object>();
List<object> insertAccountingServiceTypeIdList = new List<object>();
List<object> insertFrequencyIdList = new List<object>();
List<decimal> insertAmountList = new List<decimal>();
List<string> insertDescriptionList = new List<string>();
List<object> insertInvoiceUsageIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateRequisitionIdList = new List<object>();
List<object> updateAccountingServiceTypeIdList = new List<object>();
List<object> updateFrequencyIdList = new List<object>();
List<decimal> updateAmountList = new List<decimal>();
List<string> updateDescriptionList = new List<string>();
List<object> updateInvoiceUsageIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_04e7247757060d4016b43102119b0dd6)inParamSourceList.Current).ssENRequisitionService;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssRequisitionId==0L)) {
updateRequisitionIdList.Add(null);
} else {
updateRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssAccountingServiceTypeId==0L)) {
updateAccountingServiceTypeIdList.Add(null);
} else {
updateAccountingServiceTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAccountingServiceTypeId));
}
if ((record.ssFrequencyId==0)) {
updateFrequencyIdList.Add(null);
} else {
updateFrequencyIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssFrequencyId));
}
updateAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
updateDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
if ((record.ssInvoiceUsageId==0L)) {
updateInvoiceUsageIdList.Add(null);
} else {
updateInvoiceUsageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceUsageId));
}
} else {
if ((record.ssRequisitionId==0L)) {
insertRequisitionIdList.Add(null);
} else {
insertRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssAccountingServiceTypeId==0L)) {
insertAccountingServiceTypeIdList.Add(null);
} else {
insertAccountingServiceTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAccountingServiceTypeId));
}
if ((record.ssFrequencyId==0)) {
insertFrequencyIdList.Add(null);
} else {
insertFrequencyIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssFrequencyId));
}
insertAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
insertDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
if ((record.ssInvoiceUsageId==0L)) {
insertInvoiceUsageIdList.Add(null);
} else {
insertInvoiceUsageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceUsageId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertRequisitionIdList.IsEmpty() || !insertAccountingServiceTypeIdList.IsEmpty() || !insertFrequencyIdList.IsEmpty() || !insertAmountList.IsEmpty() || !insertDescriptionList.IsEmpty() || !insertInvoiceUsageIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionId",DbType.Int64,insertRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAccountingServiceTypeId",DbType.Int64,insertAccountingServiceTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFrequencyId",DbType.Int32,insertFrequencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAmount",DbType.Decimal,insertAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceUsageId",DbType.Int64,insertInvoiceUsageIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionService (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateRequisitionIdList.IsEmpty() || !updateAccountingServiceTypeIdList.IsEmpty() || !updateFrequencyIdList.IsEmpty() || !updateAmountList.IsEmpty() || !updateDescriptionList.IsEmpty() || !updateInvoiceUsageIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionId",DbType.Int64,updateRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAccountingServiceTypeId",DbType.Int64,updateAccountingServiceTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFrequencyId",DbType.Int32,updateFrequencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAmount",DbType.Decimal,updateAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssDescription",DbType.String,updateDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceUsageId",DbType.Int64,updateInvoiceUsageIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionService (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionService
/// </summary>

public static async Task DeleteRequisitionService(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionService
/// </summary>

public static async Task DeleteAllRequisitionService(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionService
/// </summary>

public static async Task<RC_04e7247757060d4016b43102119b0dd6> GetRequisitionService(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_04e7247757060d4016b43102119b0dd6 outParamRecord = default;
outParamRecord = new RC_04e7247757060d4016b43102119b0dd6();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENRequisitionServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionServiceForUpdate
/// </summary>

public static async Task<RC_04e7247757060d4016b43102119b0dd6> GetRequisitionServiceForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_04e7247757060d4016b43102119b0dd6 outParamRecord = default;
outParamRecord = new RC_04e7247757060d4016b43102119b0dd6();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionServiceForUpdate", "9375f876-d20e-4a79-b234-dee7e17808cd.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionServiceForUpdate", "9375f876-d20e-4a79-b234-dee7e17808cd.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENRequisitionServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionServiceForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionService
/// </summary>

public static async Task UpdateRequisitionService(IRequestContext requestContext,BitArray usedFields,RC_04e7247757060d4016b43102119b0dd6 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionService", "9375f876-d20e-4a79-b234-dee7e17808cd.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_455768e63ed34ad2746f7c539b65e1caEntityRecord ssENRequisitionService = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENRequisitionServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + " = @ssAccountingServiceTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = @ssFrequencyId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " = @ssInvoiceUsageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionService_ssId_RequisitionService";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionService.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionService.ssRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionService.ssAccountingServiceTypeId==0L)) {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, ssENRequisitionService.ssAccountingServiceTypeId);

}
}
if(usedFields[3]) {
if ((ssENRequisitionService.ssFrequencyId==0)) {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENRequisitionService.ssFrequencyId);

}
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionService.ssAmount);
{
    string decimalAsStr = ssENRequisitionService.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENRequisitionService.ssDescription);
}
if(usedFields[6]) {
if ((ssENRequisitionService.ssInvoiceUsageId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENRequisitionService.ssInvoiceUsageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionService_ssId_RequisitionService", DbType.Int64, ssENRequisitionService.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionService", ssENRequisitionService.ssId.ToString()); }}
}
return;
}

}
}
