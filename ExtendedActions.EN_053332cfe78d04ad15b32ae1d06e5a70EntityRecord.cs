using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedItem
/// </summary>

public static async Task<long> CreateInvoiceExtendedItem(IRequestContext requestContext,RC_7f2610cf0c5fadd86ba78c902c31effa inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ssENInvoiceExtendedItem = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedItemEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssProductNumber" +
", @ssDescription" +
", @ssMaterialCode" +
", @ssQuantity" +
", @ssUnityPrice" +
", @ssCurrency" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedItem.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedItem.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssProductNumber", DbType.String, ssENInvoiceExtendedItem.ssProductNumber);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENInvoiceExtendedItem.ssDescription);
insertSqlCmd.CreateParameter("@ssMaterialCode", DbType.String, ssENInvoiceExtendedItem.ssMaterialCode);
insertSqlCmd.CreateParameter("@ssQuantity", DbType.Int32, ssENInvoiceExtendedItem.ssQuantity);
var UnityPriceParameter = insertSqlCmd.CreateParameter("@ssUnityPrice", DbType.Decimal, ssENInvoiceExtendedItem.ssUnityPrice);
{
    string decimalAsStr = ssENInvoiceExtendedItem.ssUnityPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnityPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoiceExtendedItem.ssCurrency);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedItem
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedItem(IRequestContext requestContext,BitArray usedFields,RC_7f2610cf0c5fadd86ba78c902c31effa inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ssENInvoiceExtendedItem = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber") + " = @ssProductNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + " = @ssMaterialCode"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = @ssQuantity"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice") + " = @ssUnityPrice"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency") + " = @ssCurrency"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtendedItem_ssId_InvoiceExtendedItem";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedItem.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedItem.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssProductNumber", DbType.String, ssENInvoiceExtendedItem.ssProductNumber);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENInvoiceExtendedItem.ssDescription);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssMaterialCode", DbType.String, ssENInvoiceExtendedItem.ssMaterialCode);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssQuantity", DbType.Int32, ssENInvoiceExtendedItem.ssQuantity);
}
if(usedFields[6]) {
var UnityPriceParameter = sqlCmd.CreateParameter("@ssUnityPrice", DbType.Decimal, ssENInvoiceExtendedItem.ssUnityPrice);
{
    string decimalAsStr = ssENInvoiceExtendedItem.ssUnityPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnityPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoiceExtendedItem.ssCurrency);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtendedItem_ssId_InvoiceExtendedItem", DbType.Int64, ssENInvoiceExtendedItem.ssId);
int counter = 0;
if(ssENInvoiceExtendedItem.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedItem (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedItemEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssProductNumber" +
", @ssDescription" +
", @ssMaterialCode" +
", @ssQuantity" +
", @ssUnityPrice" +
", @ssCurrency" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedItem.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedItem.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssProductNumber", DbType.String, ssENInvoiceExtendedItem.ssProductNumber);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENInvoiceExtendedItem.ssDescription);
insertSqlCmd.CreateParameter("@ssMaterialCode", DbType.String, ssENInvoiceExtendedItem.ssMaterialCode);
insertSqlCmd.CreateParameter("@ssQuantity", DbType.Int32, ssENInvoiceExtendedItem.ssQuantity);
var UnityPriceParameter = insertSqlCmd.CreateParameter("@ssUnityPrice", DbType.Decimal, ssENInvoiceExtendedItem.ssUnityPrice);
{
    string decimalAsStr = ssENInvoiceExtendedItem.ssUnityPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnityPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoiceExtendedItem.ssCurrency);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedItem.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedItem
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedItem(IRequestContext requestContext,RL_772f048f6ee632348101044a1e0eef2f inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedItemEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssProductNumber),  unnest(@ssDescription),  unnest(@ssMaterialCode),  unnest(@ssQuantity),  unnest(@ssUnityPrice),  unnest(@ssCurrency)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssProductNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber") + ",  unnest(@ssDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description") + ",  unnest(@ssMaterialCode) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + ",  unnest(@ssQuantity) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + ",  unnest(@ssUnityPrice) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice") + ",  unnest(@ssCurrency) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<string> insertProductNumberList = new List<string>();
List<string> insertDescriptionList = new List<string>();
List<string> insertMaterialCodeList = new List<string>();
List<int> insertQuantityList = new List<int>();
List<decimal> insertUnityPriceList = new List<decimal>();
List<string> insertCurrencyList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<string> updateProductNumberList = new List<string>();
List<string> updateDescriptionList = new List<string>();
List<string> updateMaterialCodeList = new List<string>();
List<int> updateQuantityList = new List<int>();
List<decimal> updateUnityPriceList = new List<decimal>();
List<string> updateCurrencyList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_7f2610cf0c5fadd86ba78c902c31effa)inParamSourceList.Current).ssENInvoiceExtendedItem;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
updateProductNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProductNumber));
updateDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
updateMaterialCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMaterialCode));
updateQuantityList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssQuantity));
updateUnityPriceList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssUnityPrice));
updateCurrencyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrency));
} else {
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
insertProductNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProductNumber));
insertDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
insertMaterialCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMaterialCode));
insertQuantityList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssQuantity));
insertUnityPriceList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssUnityPrice));
insertCurrencyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrency));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertProductNumberList.IsEmpty() || !insertDescriptionList.IsEmpty() || !insertMaterialCodeList.IsEmpty() || !insertQuantityList.IsEmpty() || !insertUnityPriceList.IsEmpty() || !insertCurrencyList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProductNumber",DbType.String,insertProductNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssMaterialCode",DbType.String,insertMaterialCodeList);
executionService.CreateParameter(insertSqlCmd,"@ssQuantity",DbType.Int32,insertQuantityList);
executionService.CreateParameter(insertSqlCmd,"@ssUnityPrice",DbType.Decimal,insertUnityPriceList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrency",DbType.String,insertCurrencyList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedItem (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateProductNumberList.IsEmpty() || !updateDescriptionList.IsEmpty() || !updateMaterialCodeList.IsEmpty() || !updateQuantityList.IsEmpty() || !updateUnityPriceList.IsEmpty() || !updateCurrencyList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProductNumber",DbType.String,updateProductNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssDescription",DbType.String,updateDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssMaterialCode",DbType.String,updateMaterialCodeList);
executionService.CreateParameter(updateSqlCmd,"@ssQuantity",DbType.Int32,updateQuantityList);
executionService.CreateParameter(updateSqlCmd,"@ssUnityPrice",DbType.Decimal,updateUnityPriceList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrency",DbType.String,updateCurrencyList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedItem (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedItem
/// </summary>

public static async Task DeleteInvoiceExtendedItem(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedItem
/// </summary>

public static async Task DeleteAllInvoiceExtendedItem(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedItem
/// </summary>

public static async Task<RC_7f2610cf0c5fadd86ba78c902c31effa> GetInvoiceExtendedItem(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7f2610cf0c5fadd86ba78c902c31effa outParamRecord = default;
outParamRecord = new RC_7f2610cf0c5fadd86ba78c902c31effa();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedItemForUpdate
/// </summary>

public static async Task<RC_7f2610cf0c5fadd86ba78c902c31effa> GetInvoiceExtendedItemForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7f2610cf0c5fadd86ba78c902c31effa outParamRecord = default;
outParamRecord = new RC_7f2610cf0c5fadd86ba78c902c31effa();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedItemForUpdate", "91219576-8df8-4173-9a94-950826de3ae9.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedItemForUpdate", "91219576-8df8-4173-9a94-950826de3ae9.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedItemForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedItem
/// </summary>

public static async Task UpdateInvoiceExtendedItem(IRequestContext requestContext,BitArray usedFields,RC_7f2610cf0c5fadd86ba78c902c31effa inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedItem", "91219576-8df8-4173-9a94-950826de3ae9.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ssENInvoiceExtendedItem = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@ProductNumber, "productnumber") ?? "productnumber") + " = @ssProductNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + " = @ssMaterialCode"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = @ssQuantity"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@UnityPrice, "unityprice") ?? "unityprice") + " = @ssUnityPrice"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Currency, "currency") ?? "currency") + " = @ssCurrency"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtendedItem_ssId_InvoiceExtendedItem";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedItem.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedItem.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssProductNumber", DbType.String, ssENInvoiceExtendedItem.ssProductNumber);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENInvoiceExtendedItem.ssDescription);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssMaterialCode", DbType.String, ssENInvoiceExtendedItem.ssMaterialCode);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssQuantity", DbType.Int32, ssENInvoiceExtendedItem.ssQuantity);
}
if(usedFields[6]) {
var UnityPriceParameter = sqlCmd.CreateParameter("@ssUnityPrice", DbType.Decimal, ssENInvoiceExtendedItem.ssUnityPrice);
{
    string decimalAsStr = ssENInvoiceExtendedItem.ssUnityPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnityPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoiceExtendedItem.ssCurrency);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtendedItem_ssId_InvoiceExtendedItem", DbType.Int64, ssENInvoiceExtendedItem.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedItem", ssENInvoiceExtendedItem.ssId.ToString()); }}
}
return;
}

}
}
