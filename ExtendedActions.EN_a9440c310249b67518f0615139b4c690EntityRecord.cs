using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedMoreCharges
/// </summary>

public static async Task<long> CreateInvoiceExtendedMoreCharges(IRequestContext requestContext,RC_152a5bcdbf970bfba2a0da40766a2168 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a9440c310249b67518f0615139b4c690EntityRecord ssENInvoiceExtendedMoreCharges = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedMoreChargesEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssNombreConcepto" +
", @ssValue" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedMoreCharges.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedMoreCharges.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssNombreConcepto", DbType.String, ssENInvoiceExtendedMoreCharges.ssNombreConcepto);
var ValueParameter = insertSqlCmd.CreateParameter("@ssValue", DbType.Decimal, ssENInvoiceExtendedMoreCharges.ssValue);
{
    string decimalAsStr = ssENInvoiceExtendedMoreCharges.ssValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedMoreCharges", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedMoreCharges
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedMoreCharges(IRequestContext requestContext,BitArray usedFields,RC_152a5bcdbf970bfba2a0da40766a2168 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a9440c310249b67518f0615139b4c690EntityRecord ssENInvoiceExtendedMoreCharges = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedMoreChargesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto") + " = @ssNombreConcepto"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + " = @ssValue"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtedMoreCharges_sd_InvoiceExtendMoreCharges";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedMoreCharges.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedMoreCharges.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssNombreConcepto", DbType.String, ssENInvoiceExtendedMoreCharges.ssNombreConcepto);
}
if(usedFields[3]) {
var ValueParameter = sqlCmd.CreateParameter("@ssValue", DbType.Decimal, ssENInvoiceExtendedMoreCharges.ssValue);
{
    string decimalAsStr = ssENInvoiceExtendedMoreCharges.ssValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtedMoreCharges_sd_InvoiceExtendMoreCharges", DbType.Int64, ssENInvoiceExtendedMoreCharges.ssId);
int counter = 0;
if(ssENInvoiceExtendedMoreCharges.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedMoreCharges (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedMoreChargesEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssNombreConcepto" +
", @ssValue" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedMoreCharges.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedMoreCharges.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssNombreConcepto", DbType.String, ssENInvoiceExtendedMoreCharges.ssNombreConcepto);
var ValueParameter = insertSqlCmd.CreateParameter("@ssValue", DbType.Decimal, ssENInvoiceExtendedMoreCharges.ssValue);
{
    string decimalAsStr = ssENInvoiceExtendedMoreCharges.ssValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedMoreCharges", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedMoreCharges.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedMoreCharges
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedMoreCharges(IRequestContext requestContext,RL_ef088826c46241557fb82e7c7f21d334 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedMoreChargesEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssNombreConcepto),  unnest(@ssValue)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssNombreConcepto) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto") + ",  unnest(@ssValue) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<string> insertNombreConceptoList = new List<string>();
List<decimal> insertValueList = new List<decimal>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<string> updateNombreConceptoList = new List<string>();
List<decimal> updateValueList = new List<decimal>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_152a5bcdbf970bfba2a0da40766a2168)inParamSourceList.Current).ssENInvoiceExtendedMoreCharges;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
updateNombreConceptoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssNombreConcepto));
updateValueList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssValue));
} else {
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
insertNombreConceptoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssNombreConcepto));
insertValueList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssValue));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertNombreConceptoList.IsEmpty() || !insertValueList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssNombreConcepto",DbType.String,insertNombreConceptoList);
executionService.CreateParameter(insertSqlCmd,"@ssValue",DbType.Decimal,insertValueList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedMoreCharges (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateNombreConceptoList.IsEmpty() || !updateValueList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssNombreConcepto",DbType.String,updateNombreConceptoList);
executionService.CreateParameter(updateSqlCmd,"@ssValue",DbType.Decimal,updateValueList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedMoreCharges (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedMoreCharges
/// </summary>

public static async Task DeleteInvoiceExtendedMoreCharges(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedMoreChargesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedMoreCharges", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedMoreCharges
/// </summary>

public static async Task DeleteAllInvoiceExtendedMoreCharges(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedMoreChargesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedMoreCharges", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedMoreCharges
/// </summary>

public static async Task<RC_152a5bcdbf970bfba2a0da40766a2168> GetInvoiceExtendedMoreCharges(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_152a5bcdbf970bfba2a0da40766a2168 outParamRecord = default;
outParamRecord = new RC_152a5bcdbf970bfba2a0da40766a2168();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
" FROM " + ENInvoiceExtendedMoreChargesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedMoreCharges", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedMoreChargesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedMoreChargesForUpdate
/// </summary>

public static async Task<RC_152a5bcdbf970bfba2a0da40766a2168> GetInvoiceExtendedMoreChargesForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_152a5bcdbf970bfba2a0da40766a2168 outParamRecord = default;
outParamRecord = new RC_152a5bcdbf970bfba2a0da40766a2168();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedMoreChargesForUpdate", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedMoreChargesForUpdate", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
" FROM " + ENInvoiceExtendedMoreChargesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedMoreChargesForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedMoreChargesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedMoreCharges
/// </summary>

public static async Task UpdateInvoiceExtendedMoreCharges(IRequestContext requestContext,BitArray usedFields,RC_152a5bcdbf970bfba2a0da40766a2168 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedMoreCharges", "d4f6bf4d-b66a-4634-b08f-6601e3e41b77.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a9440c310249b67518f0615139b4c690EntityRecord ssENInvoiceExtendedMoreCharges = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(4,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedMoreChargesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@NombreConcepto, "nombreconcepto") ?? "nombreconcepto") + " = @ssNombreConcepto"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + " = @ssValue"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtedMoreCharges_sd_InvoiceExtendMoreCharges";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedMoreCharges, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedMoreChargesAttributeKeys.@Value, "value") ?? "value") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedMoreCharges.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedMoreCharges.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssNombreConcepto", DbType.String, ssENInvoiceExtendedMoreCharges.ssNombreConcepto);
}
if(usedFields[3]) {
var ValueParameter = sqlCmd.CreateParameter("@ssValue", DbType.Decimal, ssENInvoiceExtendedMoreCharges.ssValue);
{
    string decimalAsStr = ssENInvoiceExtendedMoreCharges.ssValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtedMoreCharges_sd_InvoiceExtendMoreCharges", DbType.Int64, ssENInvoiceExtendedMoreCharges.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedMoreCharges", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedMoreCharges", ssENInvoiceExtendedMoreCharges.ssId.ToString()); }}
}
return;
}

}
}
