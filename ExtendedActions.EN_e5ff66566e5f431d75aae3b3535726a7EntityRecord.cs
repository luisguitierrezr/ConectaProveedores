using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionAccConcepts
/// </summary>

public static async Task<long> CreateRequisitionAccConcepts(IRequestContext requestContext,RC_e33b49261cecfe02249fd0f5f57f5dbc inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ssENRequisitionAccConcepts = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionAccConceptsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + "" +
" ) VALUES (" +
" @ssRequisitionAccountingId" +
", @ssAccountingDataTypeId" +
", @ssNumberOfPayments" +
", @ssAmount" +
", @ssCurrencyId" +
", @ssRequisitionAccConceptsId" +
", @ssIsActive" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionAccConcepts.ssRequisitionAccountingId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionAccountingId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionAccountingId", DbType.Int64, ssENRequisitionAccConcepts.ssRequisitionAccountingId);

}
if ((ssENRequisitionAccConcepts.ssAccountingDataTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, ssENRequisitionAccConcepts.ssAccountingDataTypeId);

}
insertSqlCmd.CreateParameter("@ssNumberOfPayments", DbType.Int32, ssENRequisitionAccConcepts.ssNumberOfPayments);
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionAccConcepts.ssAmount);
{
    string decimalAsStr = ssENRequisitionAccConcepts.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENRequisitionAccConcepts.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisitionAccConcepts.ssCurrencyId);

}
if ((ssENRequisitionAccConcepts.ssRequisitionAccConceptsId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionAccConceptsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionAccConceptsId", DbType.Int64, ssENRequisitionAccConcepts.ssRequisitionAccConceptsId);

}
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENRequisitionAccConcepts.ssIsActive);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionAccConcepts
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionAccConcepts(IRequestContext requestContext,BitArray usedFields,RC_e33b49261cecfe02249fd0f5f57f5dbc inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ssENRequisitionAccConcepts = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENRequisitionAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid") + " = @ssRequisitionAccountingId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + " = @ssAccountingDataTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + " = @ssNumberOfPayments"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid") + " = @ssRequisitionAccConceptsId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " = @ssIsActive"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionAccConcepts_ssId_RequisitionAccConcepts";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionAccConcepts.ssRequisitionAccountingId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionAccountingId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionAccountingId", DbType.Int64, ssENRequisitionAccConcepts.ssRequisitionAccountingId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionAccConcepts.ssAccountingDataTypeId==0)) {
sqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, ssENRequisitionAccConcepts.ssAccountingDataTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssNumberOfPayments", DbType.Int32, ssENRequisitionAccConcepts.ssNumberOfPayments);
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionAccConcepts.ssAmount);
{
    string decimalAsStr = ssENRequisitionAccConcepts.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
if ((ssENRequisitionAccConcepts.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisitionAccConcepts.ssCurrencyId);

}
}
if(usedFields[6]) {
if ((ssENRequisitionAccConcepts.ssRequisitionAccConceptsId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionAccConceptsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionAccConceptsId", DbType.Int64, ssENRequisitionAccConcepts.ssRequisitionAccConceptsId);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENRequisitionAccConcepts.ssIsActive);
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionAccConcepts_ssId_RequisitionAccConcepts", DbType.Int64, ssENRequisitionAccConcepts.ssId);
int counter = 0;
if(ssENRequisitionAccConcepts.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionAccConcepts (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionAccConceptsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + "" +
" ) VALUES (" +
" @ssRequisitionAccountingId" +
", @ssAccountingDataTypeId" +
", @ssNumberOfPayments" +
", @ssAmount" +
", @ssCurrencyId" +
", @ssRequisitionAccConceptsId" +
", @ssIsActive" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionAccConcepts.ssRequisitionAccountingId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionAccountingId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionAccountingId", DbType.Int64, ssENRequisitionAccConcepts.ssRequisitionAccountingId);

}
if ((ssENRequisitionAccConcepts.ssAccountingDataTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, ssENRequisitionAccConcepts.ssAccountingDataTypeId);

}
insertSqlCmd.CreateParameter("@ssNumberOfPayments", DbType.Int32, ssENRequisitionAccConcepts.ssNumberOfPayments);
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionAccConcepts.ssAmount);
{
    string decimalAsStr = ssENRequisitionAccConcepts.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENRequisitionAccConcepts.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisitionAccConcepts.ssCurrencyId);

}
if ((ssENRequisitionAccConcepts.ssRequisitionAccConceptsId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionAccConceptsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionAccConceptsId", DbType.Int64, ssENRequisitionAccConcepts.ssRequisitionAccConceptsId);

}
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENRequisitionAccConcepts.ssIsActive);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionAccConcepts.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionAccConcepts
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionAccConcepts(IRequestContext requestContext,RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionAccConceptsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + ") VALUES ( unnest(@ssRequisitionAccountingId),  unnest(@ssAccountingDataTypeId),  unnest(@ssNumberOfPayments),  unnest(@ssAmount),  unnest(@ssCurrencyId),  unnest(@ssRequisitionAccConceptsId),  unnest(@ssIsActive)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssRequisitionAccountingId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid") + ",  unnest(@ssAccountingDataTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + ",  unnest(@ssNumberOfPayments) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + ",  unnest(@ssAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + ",  unnest(@ssCurrencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ",  unnest(@ssRequisitionAccConceptsId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid") + ",  unnest(@ssIsActive) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertRequisitionAccountingIdList = new List<object>();
List<object> insertAccountingDataTypeIdList = new List<object>();
List<int> insertNumberOfPaymentsList = new List<int>();
List<decimal> insertAmountList = new List<decimal>();
List<object> insertCurrencyIdList = new List<object>();
List<object> insertRequisitionAccConceptsIdList = new List<object>();
List<bool> insertIsActiveList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateRequisitionAccountingIdList = new List<object>();
List<object> updateAccountingDataTypeIdList = new List<object>();
List<int> updateNumberOfPaymentsList = new List<int>();
List<decimal> updateAmountList = new List<decimal>();
List<object> updateCurrencyIdList = new List<object>();
List<object> updateRequisitionAccConceptsIdList = new List<object>();
List<bool> updateIsActiveList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_e33b49261cecfe02249fd0f5f57f5dbc)inParamSourceList.Current).ssENRequisitionAccConcepts;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssRequisitionAccountingId==0L)) {
updateRequisitionAccountingIdList.Add(null);
} else {
updateRequisitionAccountingIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionAccountingId));
}
if ((record.ssAccountingDataTypeId==0)) {
updateAccountingDataTypeIdList.Add(null);
} else {
updateAccountingDataTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssAccountingDataTypeId));
}
updateNumberOfPaymentsList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssNumberOfPayments));
updateAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
if ((record.ssCurrencyId=="")) {
updateCurrencyIdList.Add(null);
} else {
updateCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssRequisitionAccConceptsId==0L)) {
updateRequisitionAccConceptsIdList.Add(null);
} else {
updateRequisitionAccConceptsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionAccConceptsId));
}
updateIsActiveList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsActive));
} else {
if ((record.ssRequisitionAccountingId==0L)) {
insertRequisitionAccountingIdList.Add(null);
} else {
insertRequisitionAccountingIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionAccountingId));
}
if ((record.ssAccountingDataTypeId==0)) {
insertAccountingDataTypeIdList.Add(null);
} else {
insertAccountingDataTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssAccountingDataTypeId));
}
insertNumberOfPaymentsList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssNumberOfPayments));
insertAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
if ((record.ssCurrencyId=="")) {
insertCurrencyIdList.Add(null);
} else {
insertCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssRequisitionAccConceptsId==0L)) {
insertRequisitionAccConceptsIdList.Add(null);
} else {
insertRequisitionAccConceptsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionAccConceptsId));
}
insertIsActiveList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsActive));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertRequisitionAccountingIdList.IsEmpty() || !insertAccountingDataTypeIdList.IsEmpty() || !insertNumberOfPaymentsList.IsEmpty() || !insertAmountList.IsEmpty() || !insertCurrencyIdList.IsEmpty() || !insertRequisitionAccConceptsIdList.IsEmpty() || !insertIsActiveList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionAccountingId",DbType.Int64,insertRequisitionAccountingIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAccountingDataTypeId",DbType.Int32,insertAccountingDataTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssNumberOfPayments",DbType.Int32,insertNumberOfPaymentsList);
executionService.CreateParameter(insertSqlCmd,"@ssAmount",DbType.Decimal,insertAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrencyId",DbType.String,insertCurrencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionAccConceptsId",DbType.Int64,insertRequisitionAccConceptsIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsActive",DbType.Boolean,insertIsActiveList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionAccConcepts (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateRequisitionAccountingIdList.IsEmpty() || !updateAccountingDataTypeIdList.IsEmpty() || !updateNumberOfPaymentsList.IsEmpty() || !updateAmountList.IsEmpty() || !updateCurrencyIdList.IsEmpty() || !updateRequisitionAccConceptsIdList.IsEmpty() || !updateIsActiveList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionAccountingId",DbType.Int64,updateRequisitionAccountingIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAccountingDataTypeId",DbType.Int32,updateAccountingDataTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssNumberOfPayments",DbType.Int32,updateNumberOfPaymentsList);
executionService.CreateParameter(updateSqlCmd,"@ssAmount",DbType.Decimal,updateAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrencyId",DbType.String,updateCurrencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionAccConceptsId",DbType.Int64,updateRequisitionAccConceptsIdList);
executionService.CreateParameter(updateSqlCmd,"@ssIsActive",DbType.Boolean,updateIsActiveList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionAccConcepts (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionAccConcepts
/// </summary>

public static async Task DeleteRequisitionAccConcepts(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionAccConcepts
/// </summary>

public static async Task DeleteAllRequisitionAccConcepts(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionAccConcepts
/// </summary>

public static async Task<RC_e33b49261cecfe02249fd0f5f57f5dbc> GetRequisitionAccConcepts(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e33b49261cecfe02249fd0f5f57f5dbc outParamRecord = default;
outParamRecord = new RC_e33b49261cecfe02249fd0f5f57f5dbc();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENRequisitionAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionAccConceptsForUpdate
/// </summary>

public static async Task<RC_e33b49261cecfe02249fd0f5f57f5dbc> GetRequisitionAccConceptsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e33b49261cecfe02249fd0f5f57f5dbc outParamRecord = default;
outParamRecord = new RC_e33b49261cecfe02249fd0f5f57f5dbc();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionAccConceptsForUpdate", "3d8a0269-34c6-4162-801b-bf33c6b39876.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionAccConceptsForUpdate", "3d8a0269-34c6-4162-801b-bf33c6b39876.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENRequisitionAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionAccConceptsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionAccConcepts
/// </summary>

public static async Task UpdateRequisitionAccConcepts(IRequestContext requestContext,BitArray usedFields,RC_e33b49261cecfe02249fd0f5f57f5dbc inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionAccConcepts", "3d8a0269-34c6-4162-801b-bf33c6b39876.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord ssENRequisitionAccConcepts = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENRequisitionAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid") + " = @ssRequisitionAccountingId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + " = @ssAccountingDataTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + " = @ssNumberOfPayments"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid") + " = @ssRequisitionAccConceptsId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " = @ssIsActive"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitionAccConcepts_ssId_RequisitionAccConcepts";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionAccConcepts.ssRequisitionAccountingId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionAccountingId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionAccountingId", DbType.Int64, ssENRequisitionAccConcepts.ssRequisitionAccountingId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionAccConcepts.ssAccountingDataTypeId==0)) {
sqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, ssENRequisitionAccConcepts.ssAccountingDataTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssNumberOfPayments", DbType.Int32, ssENRequisitionAccConcepts.ssNumberOfPayments);
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionAccConcepts.ssAmount);
{
    string decimalAsStr = ssENRequisitionAccConcepts.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
if ((ssENRequisitionAccConcepts.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisitionAccConcepts.ssCurrencyId);

}
}
if(usedFields[6]) {
if ((ssENRequisitionAccConcepts.ssRequisitionAccConceptsId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionAccConceptsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionAccConceptsId", DbType.Int64, ssENRequisitionAccConcepts.ssRequisitionAccConceptsId);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENRequisitionAccConcepts.ssIsActive);
}
sqlCmd.CreateParameter("@idparam_ssENRequisitionAccConcepts_ssId_RequisitionAccConcepts", DbType.Int64, ssENRequisitionAccConcepts.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionAccConcepts", ssENRequisitionAccConcepts.ssId.ToString()); }}
}
return;
}

}
}
