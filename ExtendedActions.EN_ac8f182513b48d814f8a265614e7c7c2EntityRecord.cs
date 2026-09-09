using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedItemTax
/// </summary>

public static async Task<long> CreateInvoiceExtendedItemTax(IRequestContext requestContext,RC_e7b4e13946d568a48ef39b6a3bfce595 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord ssENInvoiceExtendedItemTax = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedItemTaxEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + "" +
" ) VALUES (" +
" @ssInvoiceExtendedItemId" +
", @ssInvoiceTaxTypeId" +
", @ssImpuesto" +
", @ssBase" +
", @ssTasaOCuota" +
", @ssImporte" +
", @ssTipoFactor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedItemTax.ssInvoiceExtendedItemId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceExtendedItemId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceExtendedItemId", DbType.Int64, ssENInvoiceExtendedItemTax.ssInvoiceExtendedItemId);

}
if ((ssENInvoiceExtendedItemTax.ssInvoiceTaxTypeId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, ssENInvoiceExtendedItemTax.ssInvoiceTaxTypeId);

}
insertSqlCmd.CreateParameter("@ssImpuesto", DbType.String, ssENInvoiceExtendedItemTax.ssImpuesto);
var BaseParameter = insertSqlCmd.CreateParameter("@ssBase", DbType.Decimal, ssENInvoiceExtendedItemTax.ssBase);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssBase.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {BaseParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TasaOCuotaParameter = insertSqlCmd.CreateParameter("@ssTasaOCuota", DbType.Decimal, ssENInvoiceExtendedItemTax.ssTasaOCuota);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssTasaOCuota.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TasaOCuotaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var ImporteParameter = insertSqlCmd.CreateParameter("@ssImporte", DbType.Decimal, ssENInvoiceExtendedItemTax.ssImporte);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssImporte.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssTipoFactor", DbType.String, ssENInvoiceExtendedItemTax.ssTipoFactor);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedItemTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedItemTax
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedItemTax(IRequestContext requestContext,BitArray usedFields,RC_e7b4e13946d568a48ef39b6a3bfce595 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord ssENInvoiceExtendedItemTax = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedItemTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid") + " = @ssInvoiceExtendedItemId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + " = @ssInvoiceTaxTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + " = @ssImpuesto"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + " = @ssBase"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + " = @ssTasaOCuota"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe") + " = @ssImporte"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " = @ssTipoFactor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtendedItemTax_ssId_InvoiceExtendedItemTax";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedItemTax.ssInvoiceExtendedItemId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceExtendedItemId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceExtendedItemId", DbType.Int64, ssENInvoiceExtendedItemTax.ssInvoiceExtendedItemId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceExtendedItemTax.ssInvoiceTaxTypeId==0)) {
sqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, ssENInvoiceExtendedItemTax.ssInvoiceTaxTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssImpuesto", DbType.String, ssENInvoiceExtendedItemTax.ssImpuesto);
}
if(usedFields[4]) {
var BaseParameter = sqlCmd.CreateParameter("@ssBase", DbType.Decimal, ssENInvoiceExtendedItemTax.ssBase);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssBase.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {BaseParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
var TasaOCuotaParameter = sqlCmd.CreateParameter("@ssTasaOCuota", DbType.Decimal, ssENInvoiceExtendedItemTax.ssTasaOCuota);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssTasaOCuota.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TasaOCuotaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[6]) {
var ImporteParameter = sqlCmd.CreateParameter("@ssImporte", DbType.Decimal, ssENInvoiceExtendedItemTax.ssImporte);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssImporte.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssTipoFactor", DbType.String, ssENInvoiceExtendedItemTax.ssTipoFactor);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtendedItemTax_ssId_InvoiceExtendedItemTax", DbType.Int64, ssENInvoiceExtendedItemTax.ssId);
int counter = 0;
if(ssENInvoiceExtendedItemTax.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedItemTax (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedItemTaxEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + "" +
" ) VALUES (" +
" @ssInvoiceExtendedItemId" +
", @ssInvoiceTaxTypeId" +
", @ssImpuesto" +
", @ssBase" +
", @ssTasaOCuota" +
", @ssImporte" +
", @ssTipoFactor" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceExtendedItemTax.ssInvoiceExtendedItemId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceExtendedItemId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceExtendedItemId", DbType.Int64, ssENInvoiceExtendedItemTax.ssInvoiceExtendedItemId);

}
if ((ssENInvoiceExtendedItemTax.ssInvoiceTaxTypeId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, ssENInvoiceExtendedItemTax.ssInvoiceTaxTypeId);

}
insertSqlCmd.CreateParameter("@ssImpuesto", DbType.String, ssENInvoiceExtendedItemTax.ssImpuesto);
var BaseParameter = insertSqlCmd.CreateParameter("@ssBase", DbType.Decimal, ssENInvoiceExtendedItemTax.ssBase);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssBase.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {BaseParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TasaOCuotaParameter = insertSqlCmd.CreateParameter("@ssTasaOCuota", DbType.Decimal, ssENInvoiceExtendedItemTax.ssTasaOCuota);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssTasaOCuota.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TasaOCuotaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var ImporteParameter = insertSqlCmd.CreateParameter("@ssImporte", DbType.Decimal, ssENInvoiceExtendedItemTax.ssImporte);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssImporte.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssTipoFactor", DbType.String, ssENInvoiceExtendedItemTax.ssTipoFactor);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedItemTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedItemTax.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedItemTax
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedItemTax(IRequestContext requestContext,RL_5b975f6376260cc87a4dc39e570700ae inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedItemTaxEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + ") VALUES ( unnest(@ssInvoiceExtendedItemId),  unnest(@ssInvoiceTaxTypeId),  unnest(@ssImpuesto),  unnest(@ssBase),  unnest(@ssTasaOCuota),  unnest(@ssImporte),  unnest(@ssTipoFactor)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceExtendedItemId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid") + ",  unnest(@ssInvoiceTaxTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + ",  unnest(@ssImpuesto) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + ",  unnest(@ssBase) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + ",  unnest(@ssTasaOCuota) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + ",  unnest(@ssImporte) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe") + ",  unnest(@ssTipoFactor) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceExtendedItemIdList = new List<object>();
List<object> insertInvoiceTaxTypeIdList = new List<object>();
List<string> insertImpuestoList = new List<string>();
List<decimal> insertBaseList = new List<decimal>();
List<decimal> insertTasaOCuotaList = new List<decimal>();
List<decimal> insertImporteList = new List<decimal>();
List<string> insertTipoFactorList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceExtendedItemIdList = new List<object>();
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
var record = ((RC_e7b4e13946d568a48ef39b6a3bfce595)inParamSourceList.Current).ssENInvoiceExtendedItemTax;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceExtendedItemId==0L)) {
updateInvoiceExtendedItemIdList.Add(null);
} else {
updateInvoiceExtendedItemIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceExtendedItemId));
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
if ((record.ssInvoiceExtendedItemId==0L)) {
insertInvoiceExtendedItemIdList.Add(null);
} else {
insertInvoiceExtendedItemIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceExtendedItemId));
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
if (!insertInvoiceExtendedItemIdList.IsEmpty() || !insertInvoiceTaxTypeIdList.IsEmpty() || !insertImpuestoList.IsEmpty() || !insertBaseList.IsEmpty() || !insertTasaOCuotaList.IsEmpty() || !insertImporteList.IsEmpty() || !insertTipoFactorList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceExtendedItemId",DbType.Int64,insertInvoiceExtendedItemIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceTaxTypeId",DbType.Int32,insertInvoiceTaxTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssImpuesto",DbType.String,insertImpuestoList);
executionService.CreateParameter(insertSqlCmd,"@ssBase",DbType.Decimal,insertBaseList);
executionService.CreateParameter(insertSqlCmd,"@ssTasaOCuota",DbType.Decimal,insertTasaOCuotaList);
executionService.CreateParameter(insertSqlCmd,"@ssImporte",DbType.Decimal,insertImporteList);
executionService.CreateParameter(insertSqlCmd,"@ssTipoFactor",DbType.String,insertTipoFactorList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedItemTax (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceExtendedItemIdList.IsEmpty() || !updateInvoiceTaxTypeIdList.IsEmpty() || !updateImpuestoList.IsEmpty() || !updateBaseList.IsEmpty() || !updateTasaOCuotaList.IsEmpty() || !updateImporteList.IsEmpty() || !updateTipoFactorList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceExtendedItemId",DbType.Int64,updateInvoiceExtendedItemIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceTaxTypeId",DbType.Int32,updateInvoiceTaxTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssImpuesto",DbType.String,updateImpuestoList);
executionService.CreateParameter(updateSqlCmd,"@ssBase",DbType.Decimal,updateBaseList);
executionService.CreateParameter(updateSqlCmd,"@ssTasaOCuota",DbType.Decimal,updateTasaOCuotaList);
executionService.CreateParameter(updateSqlCmd,"@ssImporte",DbType.Decimal,updateImporteList);
executionService.CreateParameter(updateSqlCmd,"@ssTipoFactor",DbType.String,updateTipoFactorList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedItemTax (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedItemTax
/// </summary>

public static async Task DeleteInvoiceExtendedItemTax(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedItemTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedItemTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedItemTax
/// </summary>

public static async Task DeleteAllInvoiceExtendedItemTax(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedItemTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedItemTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedItemTax
/// </summary>

public static async Task<RC_e7b4e13946d568a48ef39b6a3bfce595> GetInvoiceExtendedItemTax(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e7b4e13946d568a48ef39b6a3bfce595 outParamRecord = default;
outParamRecord = new RC_e7b4e13946d568a48ef39b6a3bfce595();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedItemTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedItemTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedItemTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedItemTaxForUpdate
/// </summary>

public static async Task<RC_e7b4e13946d568a48ef39b6a3bfce595> GetInvoiceExtendedItemTaxForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e7b4e13946d568a48ef39b6a3bfce595 outParamRecord = default;
outParamRecord = new RC_e7b4e13946d568a48ef39b6a3bfce595();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedItemTaxForUpdate", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedItemTaxForUpdate", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedItemTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedItemTaxForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedItemTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedItemTax
/// </summary>

public static async Task UpdateInvoiceExtendedItemTax(IRequestContext requestContext,BitArray usedFields,RC_e7b4e13946d568a48ef39b6a3bfce595 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedItemTax", "e1a118aa-20fb-4f8a-8801-0513c7f6e0b6.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord ssENInvoiceExtendedItemTax = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedItemTaxEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceExtendedItemId, "invoiceextendeditemid") ?? "invoiceextendeditemid") + " = @ssInvoiceExtendedItemId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@InvoiceTaxTypeId, "invoicetaxtypeid") ?? "invoicetaxtypeid") + " = @ssInvoiceTaxTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Impuesto, "impuesto") ?? "impuesto") + " = @ssImpuesto"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + " = @ssBase"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TasaOCuota, "tasaocuota") ?? "tasaocuota") + " = @ssTasaOCuota"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Importe, "importe") ?? "importe") + " = @ssImporte"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@TipoFactor, "tipofactor") ?? "tipofactor") + " = @ssTipoFactor"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtendedItemTax_ssId_InvoiceExtendedItemTax";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedItemTax, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedItemTaxAttributeKeys.@Base, "base") ?? "base") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceExtendedItemTax.ssInvoiceExtendedItemId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceExtendedItemId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceExtendedItemId", DbType.Int64, ssENInvoiceExtendedItemTax.ssInvoiceExtendedItemId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceExtendedItemTax.ssInvoiceTaxTypeId==0)) {
sqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceTaxTypeId", DbType.Int32, ssENInvoiceExtendedItemTax.ssInvoiceTaxTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssImpuesto", DbType.String, ssENInvoiceExtendedItemTax.ssImpuesto);
}
if(usedFields[4]) {
var BaseParameter = sqlCmd.CreateParameter("@ssBase", DbType.Decimal, ssENInvoiceExtendedItemTax.ssBase);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssBase.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {BaseParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
var TasaOCuotaParameter = sqlCmd.CreateParameter("@ssTasaOCuota", DbType.Decimal, ssENInvoiceExtendedItemTax.ssTasaOCuota);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssTasaOCuota.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TasaOCuotaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[6]) {
var ImporteParameter = sqlCmd.CreateParameter("@ssImporte", DbType.Decimal, ssENInvoiceExtendedItemTax.ssImporte);
{
    string decimalAsStr = ssENInvoiceExtendedItemTax.ssImporte.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssTipoFactor", DbType.String, ssENInvoiceExtendedItemTax.ssTipoFactor);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtendedItemTax_ssId_InvoiceExtendedItemTax", DbType.Int64, ssENInvoiceExtendedItemTax.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedItemTax", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedItemTax", ssENInvoiceExtendedItemTax.ssId.ToString()); }}
}
return;
}

}
}
