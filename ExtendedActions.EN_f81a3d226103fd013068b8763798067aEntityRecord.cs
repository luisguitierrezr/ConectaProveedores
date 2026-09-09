using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtended
/// </summary>

public static async Task<long> CreateInvoiceExtended(IRequestContext requestContext,RC_fbe3f1050ad4f34fa0e0a15f88a56873 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid") + "" +
" ) VALUES (" +
" @ssId" +
", @ssVersion" +
", @ssFolio" +
", @ssSerie" +
", @ssFechaEmision" +
", @ssFormaPago" +
", @ssMetodoPago" +
", @ssLugarExpedicion" +
", @ssSubtotal" +
", @ssDescuento" +
", @ssTotalIVA" +
", @ssRetenciones" +
", @ssTotal" +
", @ssTipoComprobante" +
", @ssMoneda" +
", @ssTipoCambio" +
", @ssUsoCFDI" +
", @ssExportacion" +
", @ssUUID" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtended.ssId);
insertSqlCmd.CreateParameter("@ssVersion", DbType.String, ssENInvoiceExtended.ssVersion);
insertSqlCmd.CreateParameter("@ssFolio", DbType.String, ssENInvoiceExtended.ssFolio);
insertSqlCmd.CreateParameter("@ssSerie", DbType.String, ssENInvoiceExtended.ssSerie);
insertSqlCmd.CreateParameter("@ssFechaEmision", DbType.String, ssENInvoiceExtended.ssFechaEmision);
insertSqlCmd.CreateParameter("@ssFormaPago", DbType.String, ssENInvoiceExtended.ssFormaPago);
insertSqlCmd.CreateParameter("@ssMetodoPago", DbType.String, ssENInvoiceExtended.ssMetodoPago);
insertSqlCmd.CreateParameter("@ssLugarExpedicion", DbType.String, ssENInvoiceExtended.ssLugarExpedicion);
var SubtotalParameter = insertSqlCmd.CreateParameter("@ssSubtotal", DbType.Decimal, ssENInvoiceExtended.ssSubtotal);
{
    string decimalAsStr = ssENInvoiceExtended.ssSubtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {SubtotalParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var DescuentoParameter = insertSqlCmd.CreateParameter("@ssDescuento", DbType.Decimal, ssENInvoiceExtended.ssDescuento);
{
    string decimalAsStr = ssENInvoiceExtended.ssDescuento.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {DescuentoParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalIVAParameter = insertSqlCmd.CreateParameter("@ssTotalIVA", DbType.Decimal, ssENInvoiceExtended.ssTotalIVA);
{
    string decimalAsStr = ssENInvoiceExtended.ssTotalIVA.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalIVAParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var RetencionesParameter = insertSqlCmd.CreateParameter("@ssRetenciones", DbType.Decimal, ssENInvoiceExtended.ssRetenciones);
{
    string decimalAsStr = ssENInvoiceExtended.ssRetenciones.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetencionesParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalParameter = insertSqlCmd.CreateParameter("@ssTotal", DbType.Decimal, ssENInvoiceExtended.ssTotal);
{
    string decimalAsStr = ssENInvoiceExtended.ssTotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssTipoComprobante", DbType.String, ssENInvoiceExtended.ssTipoComprobante);
insertSqlCmd.CreateParameter("@ssMoneda", DbType.String, ssENInvoiceExtended.ssMoneda);
var TipoCambioParameter = insertSqlCmd.CreateParameter("@ssTipoCambio", DbType.Decimal, ssENInvoiceExtended.ssTipoCambio);
{
    string decimalAsStr = ssENInvoiceExtended.ssTipoCambio.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TipoCambioParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssUsoCFDI", DbType.String, ssENInvoiceExtended.ssUsoCFDI);
insertSqlCmd.CreateParameter("@ssExportacion", DbType.String, ssENInvoiceExtended.ssExportacion);
insertSqlCmd.CreateParameter("@ssUUID", DbType.String, ssENInvoiceExtended.ssUUID);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtended.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtended
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtended(IRequestContext requestContext,BitArray usedFields,RC_fbe3f1050ad4f34fa0e0a15f88a56873 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(19,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version") + " = @ssVersion"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio") + " = @ssFolio"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie") + " = @ssSerie"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision") + " = @ssFechaEmision"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago") + " = @ssFormaPago"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago") + " = @ssMetodoPago"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion") + " = @ssLugarExpedicion"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + " = @ssSubtotal"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento") + " = @ssDescuento"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva") + " = @ssTotalIVA"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones") + " = @ssRetenciones"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total") + " = @ssTotal"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante") + " = @ssTipoComprobante"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda") + " = @ssMoneda"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio") + " = @ssTipoCambio"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi") + " = @ssUsoCFDI"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion") + " = @ssExportacion"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid") + " = @ssUUID"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtended_ssId_InvoiceExtended";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssVersion", DbType.String, ssENInvoiceExtended.ssVersion);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssFolio", DbType.String, ssENInvoiceExtended.ssFolio);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssSerie", DbType.String, ssENInvoiceExtended.ssSerie);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssFechaEmision", DbType.String, ssENInvoiceExtended.ssFechaEmision);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssFormaPago", DbType.String, ssENInvoiceExtended.ssFormaPago);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMetodoPago", DbType.String, ssENInvoiceExtended.ssMetodoPago);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssLugarExpedicion", DbType.String, ssENInvoiceExtended.ssLugarExpedicion);
}
if(usedFields[8]) {
var SubtotalParameter = sqlCmd.CreateParameter("@ssSubtotal", DbType.Decimal, ssENInvoiceExtended.ssSubtotal);
{
    string decimalAsStr = ssENInvoiceExtended.ssSubtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {SubtotalParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
var DescuentoParameter = sqlCmd.CreateParameter("@ssDescuento", DbType.Decimal, ssENInvoiceExtended.ssDescuento);
{
    string decimalAsStr = ssENInvoiceExtended.ssDescuento.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {DescuentoParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
var TotalIVAParameter = sqlCmd.CreateParameter("@ssTotalIVA", DbType.Decimal, ssENInvoiceExtended.ssTotalIVA);
{
    string decimalAsStr = ssENInvoiceExtended.ssTotalIVA.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalIVAParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
var RetencionesParameter = sqlCmd.CreateParameter("@ssRetenciones", DbType.Decimal, ssENInvoiceExtended.ssRetenciones);
{
    string decimalAsStr = ssENInvoiceExtended.ssRetenciones.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetencionesParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[12]) {
var TotalParameter = sqlCmd.CreateParameter("@ssTotal", DbType.Decimal, ssENInvoiceExtended.ssTotal);
{
    string decimalAsStr = ssENInvoiceExtended.ssTotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssTipoComprobante", DbType.String, ssENInvoiceExtended.ssTipoComprobante);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssMoneda", DbType.String, ssENInvoiceExtended.ssMoneda);
}
if(usedFields[15]) {
var TipoCambioParameter = sqlCmd.CreateParameter("@ssTipoCambio", DbType.Decimal, ssENInvoiceExtended.ssTipoCambio);
{
    string decimalAsStr = ssENInvoiceExtended.ssTipoCambio.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TipoCambioParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssUsoCFDI", DbType.String, ssENInvoiceExtended.ssUsoCFDI);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssExportacion", DbType.String, ssENInvoiceExtended.ssExportacion);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssUUID", DbType.String, ssENInvoiceExtended.ssUUID);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtended_ssId_InvoiceExtended", DbType.Int64, ssENInvoiceExtended.ssId);
int counter = 0;
if(ssENInvoiceExtended.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtended (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid") + "" +
" ) VALUES (" +
" @ssId" +
", @ssVersion" +
", @ssFolio" +
", @ssSerie" +
", @ssFechaEmision" +
", @ssFormaPago" +
", @ssMetodoPago" +
", @ssLugarExpedicion" +
", @ssSubtotal" +
", @ssDescuento" +
", @ssTotalIVA" +
", @ssRetenciones" +
", @ssTotal" +
", @ssTipoComprobante" +
", @ssMoneda" +
", @ssTipoCambio" +
", @ssUsoCFDI" +
", @ssExportacion" +
", @ssUUID" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtended.ssId);
insertSqlCmd.CreateParameter("@ssVersion", DbType.String, ssENInvoiceExtended.ssVersion);
insertSqlCmd.CreateParameter("@ssFolio", DbType.String, ssENInvoiceExtended.ssFolio);
insertSqlCmd.CreateParameter("@ssSerie", DbType.String, ssENInvoiceExtended.ssSerie);
insertSqlCmd.CreateParameter("@ssFechaEmision", DbType.String, ssENInvoiceExtended.ssFechaEmision);
insertSqlCmd.CreateParameter("@ssFormaPago", DbType.String, ssENInvoiceExtended.ssFormaPago);
insertSqlCmd.CreateParameter("@ssMetodoPago", DbType.String, ssENInvoiceExtended.ssMetodoPago);
insertSqlCmd.CreateParameter("@ssLugarExpedicion", DbType.String, ssENInvoiceExtended.ssLugarExpedicion);
var SubtotalParameter = insertSqlCmd.CreateParameter("@ssSubtotal", DbType.Decimal, ssENInvoiceExtended.ssSubtotal);
{
    string decimalAsStr = ssENInvoiceExtended.ssSubtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {SubtotalParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var DescuentoParameter = insertSqlCmd.CreateParameter("@ssDescuento", DbType.Decimal, ssENInvoiceExtended.ssDescuento);
{
    string decimalAsStr = ssENInvoiceExtended.ssDescuento.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {DescuentoParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalIVAParameter = insertSqlCmd.CreateParameter("@ssTotalIVA", DbType.Decimal, ssENInvoiceExtended.ssTotalIVA);
{
    string decimalAsStr = ssENInvoiceExtended.ssTotalIVA.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalIVAParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var RetencionesParameter = insertSqlCmd.CreateParameter("@ssRetenciones", DbType.Decimal, ssENInvoiceExtended.ssRetenciones);
{
    string decimalAsStr = ssENInvoiceExtended.ssRetenciones.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetencionesParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalParameter = insertSqlCmd.CreateParameter("@ssTotal", DbType.Decimal, ssENInvoiceExtended.ssTotal);
{
    string decimalAsStr = ssENInvoiceExtended.ssTotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssTipoComprobante", DbType.String, ssENInvoiceExtended.ssTipoComprobante);
insertSqlCmd.CreateParameter("@ssMoneda", DbType.String, ssENInvoiceExtended.ssMoneda);
var TipoCambioParameter = insertSqlCmd.CreateParameter("@ssTipoCambio", DbType.Decimal, ssENInvoiceExtended.ssTipoCambio);
{
    string decimalAsStr = ssENInvoiceExtended.ssTipoCambio.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TipoCambioParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssUsoCFDI", DbType.String, ssENInvoiceExtended.ssUsoCFDI);
insertSqlCmd.CreateParameter("@ssExportacion", DbType.String, ssENInvoiceExtended.ssExportacion);
insertSqlCmd.CreateParameter("@ssUUID", DbType.String, ssENInvoiceExtended.ssUUID);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtended.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtended.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtended
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtended(IRequestContext requestContext,RL_a675a81d4063c2bba451ee57edc49e99 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid") + ") VALUES ( unnest(@ssId),  unnest(@ssVersion),  unnest(@ssFolio),  unnest(@ssSerie),  unnest(@ssFechaEmision),  unnest(@ssFormaPago),  unnest(@ssMetodoPago),  unnest(@ssLugarExpedicion),  unnest(@ssSubtotal),  unnest(@ssDescuento),  unnest(@ssTotalIVA),  unnest(@ssRetenciones),  unnest(@ssTotal),  unnest(@ssTipoComprobante),  unnest(@ssMoneda),  unnest(@ssTipoCambio),  unnest(@ssUsoCFDI),  unnest(@ssExportacion),  unnest(@ssUUID)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid") + " ";
insertSql += "";


List<object> insertIdList = new List<object>();
List<string> insertVersionList = new List<string>();
List<string> insertFolioList = new List<string>();
List<string> insertSerieList = new List<string>();
List<string> insertFechaEmisionList = new List<string>();
List<string> insertFormaPagoList = new List<string>();
List<string> insertMetodoPagoList = new List<string>();
List<string> insertLugarExpedicionList = new List<string>();
List<decimal> insertSubtotalList = new List<decimal>();
List<decimal> insertDescuentoList = new List<decimal>();
List<decimal> insertTotalIVAList = new List<decimal>();
List<decimal> insertRetencionesList = new List<decimal>();
List<decimal> insertTotalList = new List<decimal>();
List<string> insertTipoComprobanteList = new List<string>();
List<string> insertMonedaList = new List<string>();
List<decimal> insertTipoCambioList = new List<decimal>();
List<string> insertUsoCFDIList = new List<string>();
List<string> insertExportacionList = new List<string>();
List<string> insertUUIDList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_fbe3f1050ad4f34fa0e0a15f88a56873)inParamSourceList.Current).ssENInvoiceExtended;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertVersionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssVersion));
insertFolioList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFolio));
insertSerieList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSerie));
insertFechaEmisionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFechaEmision));
insertFormaPagoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFormaPago));
insertMetodoPagoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMetodoPago));
insertLugarExpedicionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLugarExpedicion));
insertSubtotalList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssSubtotal));
insertDescuentoList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssDescuento));
insertTotalIVAList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalIVA));
insertRetencionesList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssRetenciones));
insertTotalList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotal));
insertTipoComprobanteList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTipoComprobante));
insertMonedaList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMoneda));
insertTipoCambioList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTipoCambio));
insertUsoCFDIList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUsoCFDI));
insertExportacionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssExportacion));
insertUUIDList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUUID));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertVersionList.IsEmpty() || !insertFolioList.IsEmpty() || !insertSerieList.IsEmpty() || !insertFechaEmisionList.IsEmpty() || !insertFormaPagoList.IsEmpty() || !insertMetodoPagoList.IsEmpty() || !insertLugarExpedicionList.IsEmpty() || !insertSubtotalList.IsEmpty() || !insertDescuentoList.IsEmpty() || !insertTotalIVAList.IsEmpty() || !insertRetencionesList.IsEmpty() || !insertTotalList.IsEmpty() || !insertTipoComprobanteList.IsEmpty() || !insertMonedaList.IsEmpty() || !insertTipoCambioList.IsEmpty() || !insertUsoCFDIList.IsEmpty() || !insertExportacionList.IsEmpty() || !insertUUIDList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssVersion",DbType.String,insertVersionList);
executionService.CreateParameter(insertSqlCmd,"@ssFolio",DbType.String,insertFolioList);
executionService.CreateParameter(insertSqlCmd,"@ssSerie",DbType.String,insertSerieList);
executionService.CreateParameter(insertSqlCmd,"@ssFechaEmision",DbType.String,insertFechaEmisionList);
executionService.CreateParameter(insertSqlCmd,"@ssFormaPago",DbType.String,insertFormaPagoList);
executionService.CreateParameter(insertSqlCmd,"@ssMetodoPago",DbType.String,insertMetodoPagoList);
executionService.CreateParameter(insertSqlCmd,"@ssLugarExpedicion",DbType.String,insertLugarExpedicionList);
executionService.CreateParameter(insertSqlCmd,"@ssSubtotal",DbType.Decimal,insertSubtotalList);
executionService.CreateParameter(insertSqlCmd,"@ssDescuento",DbType.Decimal,insertDescuentoList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalIVA",DbType.Decimal,insertTotalIVAList);
executionService.CreateParameter(insertSqlCmd,"@ssRetenciones",DbType.Decimal,insertRetencionesList);
executionService.CreateParameter(insertSqlCmd,"@ssTotal",DbType.Decimal,insertTotalList);
executionService.CreateParameter(insertSqlCmd,"@ssTipoComprobante",DbType.String,insertTipoComprobanteList);
executionService.CreateParameter(insertSqlCmd,"@ssMoneda",DbType.String,insertMonedaList);
executionService.CreateParameter(insertSqlCmd,"@ssTipoCambio",DbType.Decimal,insertTipoCambioList);
executionService.CreateParameter(insertSqlCmd,"@ssUsoCFDI",DbType.String,insertUsoCFDIList);
executionService.CreateParameter(insertSqlCmd,"@ssExportacion",DbType.String,insertExportacionList);
executionService.CreateParameter(insertSqlCmd,"@ssUUID",DbType.String,insertUUIDList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtended (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtended
/// </summary>

public static async Task DeleteInvoiceExtended(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtended
/// </summary>

public static async Task DeleteAllInvoiceExtended(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtended
/// </summary>

public static async Task<RC_fbe3f1050ad4f34fa0e0a15f88a56873> GetInvoiceExtended(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_fbe3f1050ad4f34fa0e0a15f88a56873 outParamRecord = default;
outParamRecord = new RC_fbe3f1050ad4f34fa0e0a15f88a56873();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(19,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedForUpdate
/// </summary>

public static async Task<RC_fbe3f1050ad4f34fa0e0a15f88a56873> GetInvoiceExtendedForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_fbe3f1050ad4f34fa0e0a15f88a56873 outParamRecord = default;
outParamRecord = new RC_fbe3f1050ad4f34fa0e0a15f88a56873();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedForUpdate", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedForUpdate", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(19,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtended
/// </summary>

public static async Task UpdateInvoiceExtended(IRequestContext requestContext,BitArray usedFields,RC_fbe3f1050ad4f34fa0e0a15f88a56873 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtended", "ff5581ea-d78c-4e75-80b4-d175843d8e69.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(19,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Version, "version") ?? "version") + " = @ssVersion"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Folio, "folio") ?? "folio") + " = @ssFolio"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Serie, "serie") ?? "serie") + " = @ssSerie"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FechaEmision, "fechaemision") ?? "fechaemision") + " = @ssFechaEmision"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@FormaPago, "formapago") ?? "formapago") + " = @ssFormaPago"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@MetodoPago, "metodopago") ?? "metodopago") + " = @ssMetodoPago"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@LugarExpedicion, "lugarexpedicion") ?? "lugarexpedicion") + " = @ssLugarExpedicion"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + " = @ssSubtotal"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Descuento, "descuento") ?? "descuento") + " = @ssDescuento"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TotalIVA, "totaliva") ?? "totaliva") + " = @ssTotalIVA"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Retenciones, "retenciones") ?? "retenciones") + " = @ssRetenciones"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Total, "total") ?? "total") + " = @ssTotal"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoComprobante, "tipocomprobante") ?? "tipocomprobante") + " = @ssTipoComprobante"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Moneda, "moneda") ?? "moneda") + " = @ssMoneda"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@TipoCambio, "tipocambio") ?? "tipocambio") + " = @ssTipoCambio"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UsoCFDI, "usocfdi") ?? "usocfdi") + " = @ssUsoCFDI"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Exportacion, "exportacion") ?? "exportacion") + " = @ssExportacion"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@UUID, "uuid") ?? "uuid") + " = @ssUUID"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtended_ssId_InvoiceExtended";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedAttributeKeys.@Subtotal, "subtotal") ?? "subtotal") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssVersion", DbType.String, ssENInvoiceExtended.ssVersion);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssFolio", DbType.String, ssENInvoiceExtended.ssFolio);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssSerie", DbType.String, ssENInvoiceExtended.ssSerie);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssFechaEmision", DbType.String, ssENInvoiceExtended.ssFechaEmision);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssFormaPago", DbType.String, ssENInvoiceExtended.ssFormaPago);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssMetodoPago", DbType.String, ssENInvoiceExtended.ssMetodoPago);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssLugarExpedicion", DbType.String, ssENInvoiceExtended.ssLugarExpedicion);
}
if(usedFields[8]) {
var SubtotalParameter = sqlCmd.CreateParameter("@ssSubtotal", DbType.Decimal, ssENInvoiceExtended.ssSubtotal);
{
    string decimalAsStr = ssENInvoiceExtended.ssSubtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {SubtotalParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
var DescuentoParameter = sqlCmd.CreateParameter("@ssDescuento", DbType.Decimal, ssENInvoiceExtended.ssDescuento);
{
    string decimalAsStr = ssENInvoiceExtended.ssDescuento.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {DescuentoParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
var TotalIVAParameter = sqlCmd.CreateParameter("@ssTotalIVA", DbType.Decimal, ssENInvoiceExtended.ssTotalIVA);
{
    string decimalAsStr = ssENInvoiceExtended.ssTotalIVA.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalIVAParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
var RetencionesParameter = sqlCmd.CreateParameter("@ssRetenciones", DbType.Decimal, ssENInvoiceExtended.ssRetenciones);
{
    string decimalAsStr = ssENInvoiceExtended.ssRetenciones.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetencionesParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[12]) {
var TotalParameter = sqlCmd.CreateParameter("@ssTotal", DbType.Decimal, ssENInvoiceExtended.ssTotal);
{
    string decimalAsStr = ssENInvoiceExtended.ssTotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssTipoComprobante", DbType.String, ssENInvoiceExtended.ssTipoComprobante);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssMoneda", DbType.String, ssENInvoiceExtended.ssMoneda);
}
if(usedFields[15]) {
var TipoCambioParameter = sqlCmd.CreateParameter("@ssTipoCambio", DbType.Decimal, ssENInvoiceExtended.ssTipoCambio);
{
    string decimalAsStr = ssENInvoiceExtended.ssTipoCambio.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TipoCambioParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssUsoCFDI", DbType.String, ssENInvoiceExtended.ssUsoCFDI);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssExportacion", DbType.String, ssENInvoiceExtended.ssExportacion);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssUUID", DbType.String, ssENInvoiceExtended.ssUUID);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtended_ssId_InvoiceExtended", DbType.Int64, ssENInvoiceExtended.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtended", ssENInvoiceExtended.ssId.ToString()); }}
}
return;
}

}
}
