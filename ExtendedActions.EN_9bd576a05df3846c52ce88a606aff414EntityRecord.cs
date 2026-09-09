using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedCartaPorte
/// </summary>

public static async Task<long> CreateInvoiceExtendedCartaPorte(IRequestContext requestContext,RC_79b8311427bcbe4ce4ecbe042bf03773 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_9bd576a05df3846c52ce88a606aff414EntityRecord ssENInvoiceExtendedCartaPorte = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedCartaPorteEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + "" +
" ) VALUES (" +
" @ssId" +
", @ssDescripcion" +
", @ssValorMercancia" +
", @ssCentroAtencion" +
", @ssCalle" +
", @ssNumeroExterior" +
", @ssCodigoPostal" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtendedCartaPorte.ssId);
insertSqlCmd.CreateParameter("@ssDescripcion", DbType.String, ssENInvoiceExtendedCartaPorte.ssDescripcion);
var ValorMercanciaParameter = insertSqlCmd.CreateParameter("@ssValorMercancia", DbType.Decimal, ssENInvoiceExtendedCartaPorte.ssValorMercancia);
{
    string decimalAsStr = ssENInvoiceExtendedCartaPorte.ssValorMercancia.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ValorMercanciaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssCentroAtencion", DbType.String, ssENInvoiceExtendedCartaPorte.ssCentroAtencion);
insertSqlCmd.CreateParameter("@ssCalle", DbType.String, ssENInvoiceExtendedCartaPorte.ssCalle);
insertSqlCmd.CreateParameter("@ssNumeroExterior", DbType.String, ssENInvoiceExtendedCartaPorte.ssNumeroExterior);
insertSqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedCartaPorte.ssCodigoPostal);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedCartaPorte", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedCartaPorte.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedCartaPorte
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedCartaPorte(IRequestContext requestContext,BitArray usedFields,RC_79b8311427bcbe4ce4ecbe042bf03773 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_9bd576a05df3846c52ce88a606aff414EntityRecord ssENInvoiceExtendedCartaPorte = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedCartaPorteEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion") + " = @ssDescripcion"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + " = @ssValorMercancia"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion") + " = @ssCentroAtencion"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle") + " = @ssCalle"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior") + " = @ssNumeroExterior"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " = @ssCodigoPostal"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtdedCartaPorte_sd_InvoiceExtenedCartaPorte";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssDescripcion", DbType.String, ssENInvoiceExtendedCartaPorte.ssDescripcion);
}
if(usedFields[2]) {
var ValorMercanciaParameter = sqlCmd.CreateParameter("@ssValorMercancia", DbType.Decimal, ssENInvoiceExtendedCartaPorte.ssValorMercancia);
{
    string decimalAsStr = ssENInvoiceExtendedCartaPorte.ssValorMercancia.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ValorMercanciaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssCentroAtencion", DbType.String, ssENInvoiceExtendedCartaPorte.ssCentroAtencion);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCalle", DbType.String, ssENInvoiceExtendedCartaPorte.ssCalle);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssNumeroExterior", DbType.String, ssENInvoiceExtendedCartaPorte.ssNumeroExterior);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedCartaPorte.ssCodigoPostal);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtdedCartaPorte_sd_InvoiceExtenedCartaPorte", DbType.Int64, ssENInvoiceExtendedCartaPorte.ssId);
int counter = 0;
if(ssENInvoiceExtendedCartaPorte.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedCartaPorte (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedCartaPorteEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + "" +
" ) VALUES (" +
" @ssId" +
", @ssDescripcion" +
", @ssValorMercancia" +
", @ssCentroAtencion" +
", @ssCalle" +
", @ssNumeroExterior" +
", @ssCodigoPostal" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtendedCartaPorte.ssId);
insertSqlCmd.CreateParameter("@ssDescripcion", DbType.String, ssENInvoiceExtendedCartaPorte.ssDescripcion);
var ValorMercanciaParameter = insertSqlCmd.CreateParameter("@ssValorMercancia", DbType.Decimal, ssENInvoiceExtendedCartaPorte.ssValorMercancia);
{
    string decimalAsStr = ssENInvoiceExtendedCartaPorte.ssValorMercancia.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ValorMercanciaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssCentroAtencion", DbType.String, ssENInvoiceExtendedCartaPorte.ssCentroAtencion);
insertSqlCmd.CreateParameter("@ssCalle", DbType.String, ssENInvoiceExtendedCartaPorte.ssCalle);
insertSqlCmd.CreateParameter("@ssNumeroExterior", DbType.String, ssENInvoiceExtendedCartaPorte.ssNumeroExterior);
insertSqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedCartaPorte.ssCodigoPostal);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedCartaPorte", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedCartaPorte.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedCartaPorte.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedCartaPorte
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedCartaPorte(IRequestContext requestContext,RL_14eea858c7edac2969e2f91a68030ca7 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedCartaPorteEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + ") VALUES ( unnest(@ssId),  unnest(@ssDescripcion),  unnest(@ssValorMercancia),  unnest(@ssCentroAtencion),  unnest(@ssCalle),  unnest(@ssNumeroExterior),  unnest(@ssCodigoPostal)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " ";
insertSql += "";


List<object> insertIdList = new List<object>();
List<string> insertDescripcionList = new List<string>();
List<decimal> insertValorMercanciaList = new List<decimal>();
List<string> insertCentroAtencionList = new List<string>();
List<string> insertCalleList = new List<string>();
List<string> insertNumeroExteriorList = new List<string>();
List<string> insertCodigoPostalList = new List<string>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_79b8311427bcbe4ce4ecbe042bf03773)inParamSourceList.Current).ssENInvoiceExtendedCartaPorte;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertDescripcionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescripcion));
insertValorMercanciaList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssValorMercancia));
insertCentroAtencionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCentroAtencion));
insertCalleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCalle));
insertNumeroExteriorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssNumeroExterior));
insertCodigoPostalList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCodigoPostal));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertDescripcionList.IsEmpty() || !insertValorMercanciaList.IsEmpty() || !insertCentroAtencionList.IsEmpty() || !insertCalleList.IsEmpty() || !insertNumeroExteriorList.IsEmpty() || !insertCodigoPostalList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDescripcion",DbType.String,insertDescripcionList);
executionService.CreateParameter(insertSqlCmd,"@ssValorMercancia",DbType.Decimal,insertValorMercanciaList);
executionService.CreateParameter(insertSqlCmd,"@ssCentroAtencion",DbType.String,insertCentroAtencionList);
executionService.CreateParameter(insertSqlCmd,"@ssCalle",DbType.String,insertCalleList);
executionService.CreateParameter(insertSqlCmd,"@ssNumeroExterior",DbType.String,insertNumeroExteriorList);
executionService.CreateParameter(insertSqlCmd,"@ssCodigoPostal",DbType.String,insertCodigoPostalList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedCartaPorte (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedCartaPorte
/// </summary>

public static async Task DeleteInvoiceExtendedCartaPorte(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedCartaPorteEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedCartaPorte", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedCartaPorte
/// </summary>

public static async Task DeleteAllInvoiceExtendedCartaPorte(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedCartaPorteEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedCartaPorte", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedCartaPorte
/// </summary>

public static async Task<RC_79b8311427bcbe4ce4ecbe042bf03773> GetInvoiceExtendedCartaPorte(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_79b8311427bcbe4ce4ecbe042bf03773 outParamRecord = default;
outParamRecord = new RC_79b8311427bcbe4ce4ecbe042bf03773();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedCartaPorteEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedCartaPorte", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedCartaPorteEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedCartaPorteForUpdate
/// </summary>

public static async Task<RC_79b8311427bcbe4ce4ecbe042bf03773> GetInvoiceExtendedCartaPorteForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_79b8311427bcbe4ce4ecbe042bf03773 outParamRecord = default;
outParamRecord = new RC_79b8311427bcbe4ce4ecbe042bf03773();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedCartaPorteForUpdate", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedCartaPorteForUpdate", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedCartaPorteEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedCartaPorteForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedCartaPorteEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedCartaPorte
/// </summary>

public static async Task UpdateInvoiceExtendedCartaPorte(IRequestContext requestContext,BitArray usedFields,RC_79b8311427bcbe4ce4ecbe042bf03773 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedCartaPorte", "73516b9a-d5a2-42d3-b083-473fd56ceb36.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_9bd576a05df3846c52ce88a606aff414EntityRecord ssENInvoiceExtendedCartaPorte = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedCartaPorteEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Descripcion, "descripcion") ?? "descripcion") + " = @ssDescripcion"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + " = @ssValorMercancia"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CentroAtencion, "centroatencion") ?? "centroatencion") + " = @ssCentroAtencion"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Calle, "calle") ?? "calle") + " = @ssCalle"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@NumeroExterior, "numeroexterior") ?? "numeroexterior") + " = @ssNumeroExterior"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@CodigoPostal, "codigopostal") ?? "codigopostal") + " = @ssCodigoPostal"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtdedCartaPorte_sd_InvoiceExtenedCartaPorte";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedCartaPorte, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedCartaPorteAttributeKeys.@ValorMercancia, "valormercancia") ?? "valormercancia") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssDescripcion", DbType.String, ssENInvoiceExtendedCartaPorte.ssDescripcion);
}
if(usedFields[2]) {
var ValorMercanciaParameter = sqlCmd.CreateParameter("@ssValorMercancia", DbType.Decimal, ssENInvoiceExtendedCartaPorte.ssValorMercancia);
{
    string decimalAsStr = ssENInvoiceExtendedCartaPorte.ssValorMercancia.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ValorMercanciaParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssCentroAtencion", DbType.String, ssENInvoiceExtendedCartaPorte.ssCentroAtencion);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssCalle", DbType.String, ssENInvoiceExtendedCartaPorte.ssCalle);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssNumeroExterior", DbType.String, ssENInvoiceExtendedCartaPorte.ssNumeroExterior);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCodigoPostal", DbType.String, ssENInvoiceExtendedCartaPorte.ssCodigoPostal);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtdedCartaPorte_sd_InvoiceExtenedCartaPorte", DbType.Int64, ssENInvoiceExtendedCartaPorte.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedCartaPorte", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedCartaPorte", ssENInvoiceExtendedCartaPorte.ssId.ToString()); }}
}
return;
}

}
}
