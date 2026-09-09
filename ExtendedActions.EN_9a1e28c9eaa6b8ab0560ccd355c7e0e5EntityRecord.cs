using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedTax
/// </summary>

public static async Task<long> CreateInvoiceExtendedTax(IRequestContext requestContext,RC_965912af30c7fbb7316f17bf8e331782 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord ssENInvoiceExtendedTax = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedTaxEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssInvoiceTaxTypeId" +
", @ssImpuesto" +
", @ssBase" +
", @ssTasaOCuota" +
", @ssImporte" +
", @ssTipoFactor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedTax.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedTax.ssInvoiceId);

}
if ((ssENInvoiceExtendedTax.ssInvoiceTaxTypeId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, ssENInvoiceExtendedTax.ssInvoiceTaxTypeId);

}
insertSqlCmd.CreateParameter("@ssImpuesto", DbType.String, ssENInvoiceExtendedTax.ssImpuesto);
var BaseParameter = insertSqlCmd.CreateParameter("@ssBase", DbType.Decimal, ssENInvoiceExtendedTax.ssBase);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssBase.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {BaseParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TasaOCuotaParameter = insertSqlCmd.CreateParameter("@ssTasaOCuota", DbType.Decimal, ssENInvoiceExtendedTax.ssTasaOCuota);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssTasaOCuota.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TasaOCuotaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var ImporteParameter = insertSqlCmd.CreateParameter("@ssImporte", DbType.Decimal, ssENInvoiceExtendedTax.ssImporte);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssImporte.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssTipoFactor", DbType.String, ssENInvoiceExtendedTax.ssTipoFactor);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedTax
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedTax(IRequestContext requestContext,BitArray usedFields,RC_965912af30c7fbb7316f17bf8e331782 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord ssENInvoiceExtendedTax = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + " = @ssInvoiceTaxTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + " = @ssImpuesto"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + " = @ssBase"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + " = @ssTasaOCuota"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe") + " = @ssImporte"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " = @ssTipoFactor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtendedTax_ssId_InvoiceExtendedTax";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedTax.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedTax.ssInvoiceId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceExtendedTax.ssInvoiceTaxTypeId==0)) {
sqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, ssENInvoiceExtendedTax.ssInvoiceTaxTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssImpuesto", DbType.String, ssENInvoiceExtendedTax.ssImpuesto);
}
if(usedFields[4]) {
var BaseParameter = sqlCmd.CreateParameter("@ssBase", DbType.Decimal, ssENInvoiceExtendedTax.ssBase);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssBase.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {BaseParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
var TasaOCuotaParameter = sqlCmd.CreateParameter("@ssTasaOCuota", DbType.Decimal, ssENInvoiceExtendedTax.ssTasaOCuota);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssTasaOCuota.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TasaOCuotaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[6]) {
var ImporteParameter = sqlCmd.CreateParameter("@ssImporte", DbType.Decimal, ssENInvoiceExtendedTax.ssImporte);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssImporte.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssTipoFactor", DbType.String, ssENInvoiceExtendedTax.ssTipoFactor);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtendedTax_ssId_InvoiceExtendedTax", DbType.Int64, ssENInvoiceExtendedTax.ssId);
int counter = 0;
if(ssENInvoiceExtendedTax.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedTax (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedTaxEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssInvoiceTaxTypeId" +
", @ssImpuesto" +
", @ssBase" +
", @ssTasaOCuota" +
", @ssImporte" +
", @ssTipoFactor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedTax.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedTax.ssInvoiceId);

}
if ((ssENInvoiceExtendedTax.ssInvoiceTaxTypeId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, ssENInvoiceExtendedTax.ssInvoiceTaxTypeId);

}
insertSqlCmd.CreateParameter("@ssImpuesto", DbType.String, ssENInvoiceExtendedTax.ssImpuesto);
var BaseParameter = insertSqlCmd.CreateParameter("@ssBase", DbType.Decimal, ssENInvoiceExtendedTax.ssBase);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssBase.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {BaseParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TasaOCuotaParameter = insertSqlCmd.CreateParameter("@ssTasaOCuota", DbType.Decimal, ssENInvoiceExtendedTax.ssTasaOCuota);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssTasaOCuota.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TasaOCuotaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var ImporteParameter = insertSqlCmd.CreateParameter("@ssImporte", DbType.Decimal, ssENInvoiceExtendedTax.ssImporte);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssImporte.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssTipoFactor", DbType.String, ssENInvoiceExtendedTax.ssTipoFactor);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedTax.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedTax
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedTax(IRequestContext requestContext,RL_9404dc36b913809894c7e4e44e8e1dd8 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedTaxEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssInvoiceTaxTypeId),  unnest(@ssImpuesto),  unnest(@ssBase),  unnest(@ssTasaOCuota),  unnest(@ssImporte),  unnest(@ssTipoFactor)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssInvoiceTaxTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + ",  unnest(@ssImpuesto) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + ",  unnest(@ssBase) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + ",  unnest(@ssTasaOCuota) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + ",  unnest(@ssImporte) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe") + ",  unnest(@ssTipoFactor) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<object> insertInvoiceTaxTypeIdList = new List<object>();
List<string> insertImpuestoList = new List<string>();
List<decimal> insertBaseList = new List<decimal>();
List<decimal> insertTasaOCuotaList = new List<decimal>();
List<decimal> insertImporteList = new List<decimal>();
List<string> insertTipoFactorList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<object> updateInvoiceTaxTypeIdList = new List<object>();
List<string> updateImpuestoList = new List<string>();
List<decimal> updateBaseList = new List<decimal>();
List<decimal> updateTasaOCuotaList = new List<decimal>();
List<decimal> updateImporteList = new List<decimal>();
List<string> updateTipoFactorList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_965912af30c7fbb7316f17bf8e331782)inParamSourceList.Current).ssENInvoiceExtendedTax;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssInvoiceTaxTypeId==0)) {
updateInvoiceTaxTypeIdList.Add(null);
} else {
updateInvoiceTaxTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInvoiceTaxTypeId));
}
updateImpuestoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssImpuesto));
updateBaseList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssBase));
updateTasaOCuotaList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTasaOCuota));
updateImporteList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssImporte));
updateTipoFactorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTipoFactor));
} else {
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssInvoiceTaxTypeId==0)) {
insertInvoiceTaxTypeIdList.Add(null);
} else {
insertInvoiceTaxTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInvoiceTaxTypeId));
}
insertImpuestoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssImpuesto));
insertBaseList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssBase));
insertTasaOCuotaList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTasaOCuota));
insertImporteList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssImporte));
insertTipoFactorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTipoFactor));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertInvoiceTaxTypeIdList.IsEmpty() || !insertImpuestoList.IsEmpty() || !insertBaseList.IsEmpty() || !insertTasaOCuotaList.IsEmpty() || !insertImporteList.IsEmpty() || !insertTipoFactorList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceTaxTypeId",DbType.Int32,insertInvoiceTaxTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssImpuesto",DbType.String,insertImpuestoList);
executionService.CreateParameter(insertSqlCmd,"@ssBase",DbType.Decimal,insertBaseList);
executionService.CreateParameter(insertSqlCmd,"@ssTasaOCuota",DbType.Decimal,insertTasaOCuotaList);
executionService.CreateParameter(insertSqlCmd,"@ssImporte",DbType.Decimal,insertImporteList);
executionService.CreateParameter(insertSqlCmd,"@ssTipoFactor",DbType.String,insertTipoFactorList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedTax (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateInvoiceTaxTypeIdList.IsEmpty() || !updateImpuestoList.IsEmpty() || !updateBaseList.IsEmpty() || !updateTasaOCuotaList.IsEmpty() || !updateImporteList.IsEmpty() || !updateTipoFactorList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceTaxTypeId",DbType.Int32,updateInvoiceTaxTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssImpuesto",DbType.String,updateImpuestoList);
executionService.CreateParameter(updateSqlCmd,"@ssBase",DbType.Decimal,updateBaseList);
executionService.CreateParameter(updateSqlCmd,"@ssTasaOCuota",DbType.Decimal,updateTasaOCuotaList);
executionService.CreateParameter(updateSqlCmd,"@ssImporte",DbType.Decimal,updateImporteList);
executionService.CreateParameter(updateSqlCmd,"@ssTipoFactor",DbType.String,updateTipoFactorList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedTax (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedTax
/// </summary>

public static async Task DeleteInvoiceExtendedTax(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedTax
/// </summary>

public static async Task DeleteAllInvoiceExtendedTax(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedTax
/// </summary>

public static async Task<RC_965912af30c7fbb7316f17bf8e331782> GetInvoiceExtendedTax(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_965912af30c7fbb7316f17bf8e331782 outParamRecord = default;
outParamRecord = new RC_965912af30c7fbb7316f17bf8e331782();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedTaxForUpdate
/// </summary>

public static async Task<RC_965912af30c7fbb7316f17bf8e331782> GetInvoiceExtendedTaxForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_965912af30c7fbb7316f17bf8e331782 outParamRecord = default;
outParamRecord = new RC_965912af30c7fbb7316f17bf8e331782();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedTaxForUpdate", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedTaxForUpdate", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedTaxForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedTax
/// </summary>

public static async Task UpdateInvoiceExtendedTax(IRequestContext requestContext,BitArray usedFields,RC_965912af30c7fbb7316f17bf8e331782 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedTax", "1c8e26bc-93d7-48d8-98d4-4eaf315a77ff.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord ssENInvoiceExtendedTax = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + " = @ssInvoiceTaxTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + " = @ssImpuesto"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + " = @ssBase"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + " = @ssTasaOCuota"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Importe, "importe") ?? "importe") + " = @ssImporte"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " = @ssTipoFactor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtendedTax_ssId_InvoiceExtendedTax";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedTaxAttributeKeys.@Base, "base") ?? "base") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedTax.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceExtendedTax.ssInvoiceId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceExtendedTax.ssInvoiceTaxTypeId==0)) {
sqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, ssENInvoiceExtendedTax.ssInvoiceTaxTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssImpuesto", DbType.String, ssENInvoiceExtendedTax.ssImpuesto);
}
if(usedFields[4]) {
var BaseParameter = sqlCmd.CreateParameter("@ssBase", DbType.Decimal, ssENInvoiceExtendedTax.ssBase);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssBase.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {BaseParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
var TasaOCuotaParameter = sqlCmd.CreateParameter("@ssTasaOCuota", DbType.Decimal, ssENInvoiceExtendedTax.ssTasaOCuota);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssTasaOCuota.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TasaOCuotaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[6]) {
var ImporteParameter = sqlCmd.CreateParameter("@ssImporte", DbType.Decimal, ssENInvoiceExtendedTax.ssImporte);
{
    string decimalAsStr = ssENInvoiceExtendedTax.ssImporte.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssTipoFactor", DbType.String, ssENInvoiceExtendedTax.ssTipoFactor);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtendedTax_ssId_InvoiceExtendedTax", DbType.Int64, ssENInvoiceExtendedTax.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedTax", ssENInvoiceExtendedTax.ssId.ToString()); }}
}
return;
}

}
}
