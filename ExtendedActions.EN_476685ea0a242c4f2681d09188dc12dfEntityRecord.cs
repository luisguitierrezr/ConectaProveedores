using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderService
/// </summary>

public static async Task<long> CreateOrderService(IRequestContext requestContext,RC_aaba1a35921d1afc1af21b1865cba418 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_476685ea0a242c4f2681d09188dc12dfEntityRecord ssENOrderService = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderServiceEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssAccountingServiceTypeId" +
", @ssFrequencyId" +
", @ssAmount" +
", @ssDescription" +
", @ssInvoiceUsageId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderService.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderService.ssOrderId);

}
if ((ssENOrderService.ssAccountingServiceTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, ssENOrderService.ssAccountingServiceTypeId);

}
if ((ssENOrderService.ssFrequencyId==0)) {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENOrderService.ssFrequencyId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderService.ssAmount);
{
    string decimalAsStr = ssENOrderService.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENOrderService.ssDescription);
if ((ssENOrderService.ssInvoiceUsageId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENOrderService.ssInvoiceUsageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderService
/// </summary>

public static async Task<long> CreateOrUpdateOrderService(IRequestContext requestContext,BitArray usedFields,RC_aaba1a35921d1afc1af21b1865cba418 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_476685ea0a242c4f2681d09188dc12dfEntityRecord ssENOrderService = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENOrderServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + " = @ssAccountingServiceTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = @ssFrequencyId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " = @ssInvoiceUsageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderService_ssId_OrderService";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderService.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderService.ssOrderId);

}
}
if(usedFields[2]) {
if ((ssENOrderService.ssAccountingServiceTypeId==0L)) {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, ssENOrderService.ssAccountingServiceTypeId);

}
}
if(usedFields[3]) {
if ((ssENOrderService.ssFrequencyId==0)) {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENOrderService.ssFrequencyId);

}
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderService.ssAmount);
{
    string decimalAsStr = ssENOrderService.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENOrderService.ssDescription);
}
if(usedFields[6]) {
if ((ssENOrderService.ssInvoiceUsageId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENOrderService.ssInvoiceUsageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderService_ssId_OrderService", DbType.Int64, ssENOrderService.ssId);
int counter = 0;
if(ssENOrderService.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderService (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderServiceEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssAccountingServiceTypeId" +
", @ssFrequencyId" +
", @ssAmount" +
", @ssDescription" +
", @ssInvoiceUsageId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderService.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderService.ssOrderId);

}
if ((ssENOrderService.ssAccountingServiceTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, ssENOrderService.ssAccountingServiceTypeId);

}
if ((ssENOrderService.ssFrequencyId==0)) {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENOrderService.ssFrequencyId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderService.ssAmount);
{
    string decimalAsStr = ssENOrderService.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENOrderService.ssDescription);
if ((ssENOrderService.ssInvoiceUsageId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENOrderService.ssInvoiceUsageId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderService.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderService
/// </summary>

public static async Task CreateOrUpdateSomeOrderService(IRequestContext requestContext,RL_5b4ba3283dc95d0e2a1e0a402c1ef134 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderServiceEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + ") VALUES ( unnest(@ssOrderId),  unnest(@ssAccountingServiceTypeId),  unnest(@ssFrequencyId),  unnest(@ssAmount),  unnest(@ssDescription),  unnest(@ssInvoiceUsageId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid") + ",  unnest(@ssAccountingServiceTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + ",  unnest(@ssFrequencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + ",  unnest(@ssAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount") + ",  unnest(@ssDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description") + ",  unnest(@ssInvoiceUsageId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderIdList = new List<object>();
List<object> insertAccountingServiceTypeIdList = new List<object>();
List<object> insertFrequencyIdList = new List<object>();
List<decimal> insertAmountList = new List<decimal>();
List<string> insertDescriptionList = new List<string>();
List<object> insertInvoiceUsageIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateOrderIdList = new List<object>();
List<object> updateAccountingServiceTypeIdList = new List<object>();
List<object> updateFrequencyIdList = new List<object>();
List<decimal> updateAmountList = new List<decimal>();
List<string> updateDescriptionList = new List<string>();
List<object> updateInvoiceUsageIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_aaba1a35921d1afc1af21b1865cba418)inParamSourceList.Current).ssENOrderService;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderId==0L)) {
updateOrderIdList.Add(null);
} else {
updateOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
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
if ((record.ssOrderId==0L)) {
insertOrderIdList.Add(null);
} else {
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
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
if (!insertOrderIdList.IsEmpty() || !insertAccountingServiceTypeIdList.IsEmpty() || !insertFrequencyIdList.IsEmpty() || !insertAmountList.IsEmpty() || !insertDescriptionList.IsEmpty() || !insertInvoiceUsageIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAccountingServiceTypeId",DbType.Int64,insertAccountingServiceTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFrequencyId",DbType.Int32,insertFrequencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAmount",DbType.Decimal,insertAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceUsageId",DbType.Int64,insertInvoiceUsageIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderService (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderIdList.IsEmpty() || !updateAccountingServiceTypeIdList.IsEmpty() || !updateFrequencyIdList.IsEmpty() || !updateAmountList.IsEmpty() || !updateDescriptionList.IsEmpty() || !updateInvoiceUsageIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderId",DbType.Int64,updateOrderIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAccountingServiceTypeId",DbType.Int64,updateAccountingServiceTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFrequencyId",DbType.Int32,updateFrequencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAmount",DbType.Decimal,updateAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssDescription",DbType.String,updateDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceUsageId",DbType.Int64,updateInvoiceUsageIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderService (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderService
/// </summary>

public static async Task DeleteOrderService(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderService
/// </summary>

public static async Task DeleteAllOrderService(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderService
/// </summary>

public static async Task<RC_aaba1a35921d1afc1af21b1865cba418> GetOrderService(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_aaba1a35921d1afc1af21b1865cba418 outParamRecord = default;
outParamRecord = new RC_aaba1a35921d1afc1af21b1865cba418();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENOrderServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderServiceForUpdate
/// </summary>

public static async Task<RC_aaba1a35921d1afc1af21b1865cba418> GetOrderServiceForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_aaba1a35921d1afc1af21b1865cba418 outParamRecord = default;
outParamRecord = new RC_aaba1a35921d1afc1af21b1865cba418();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderServiceForUpdate", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderServiceForUpdate", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENOrderServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderServiceForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderService
/// </summary>

public static async Task UpdateOrderService(IRequestContext requestContext,BitArray usedFields,RC_aaba1a35921d1afc1af21b1865cba418 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderService", "98b13797-71c4-4e75-9ae2-1e6584a356d2.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_476685ea0a242c4f2681d09188dc12dfEntityRecord ssENOrderService = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENOrderServiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid") + " = @ssAccountingServiceTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = @ssFrequencyId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " = @ssInvoiceUsageId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderService_ssId_OrderService";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderService.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderService.ssOrderId);

}
}
if(usedFields[2]) {
if ((ssENOrderService.ssAccountingServiceTypeId==0L)) {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId", DbType.Int64, ssENOrderService.ssAccountingServiceTypeId);

}
}
if(usedFields[3]) {
if ((ssENOrderService.ssFrequencyId==0)) {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENOrderService.ssFrequencyId);

}
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderService.ssAmount);
{
    string decimalAsStr = ssENOrderService.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENOrderService.ssDescription);
}
if(usedFields[6]) {
if ((ssENOrderService.ssInvoiceUsageId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENOrderService.ssInvoiceUsageId);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderService_ssId_OrderService", DbType.Int64, ssENOrderService.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderService", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderService", ssENOrderService.ssId.ToString()); }}
}
return;
}

}
}
