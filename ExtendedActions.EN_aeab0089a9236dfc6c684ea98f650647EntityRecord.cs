using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisitionContractFile
/// </summary>

public static async Task<long> CreateRequisitionContractFile(IRequestContext requestContext,RC_471ec64149613ec0a9f3525fc2d9e11c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssENRequisitionContractFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionContractFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssRequisitionFileId" +
", @ssContractFileTypeId" +
", @ssAmount" +
", @ssCurrencyId" +
", @ssDepositTypeId" +
", @ssInsuranceTypeId" +
", @ssAdvancePaymentTypeId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionContractFile.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionContractFile.ssRequisitionId);

}
if ((ssENRequisitionContractFile.ssRequisitionFileId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionFileId", DbType.Int64, ssENRequisitionContractFile.ssRequisitionFileId);

}
if ((ssENRequisitionContractFile.ssContractFileTypeId==0)) {
insertSqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, ssENRequisitionContractFile.ssContractFileTypeId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionContractFile.ssAmount);
{
    string decimalAsStr = ssENRequisitionContractFile.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENRequisitionContractFile.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisitionContractFile.ssCurrencyId);

}
if ((ssENRequisitionContractFile.ssDepositTypeId==0)) {
insertSqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, ssENRequisitionContractFile.ssDepositTypeId);

}
if ((ssENRequisitionContractFile.ssInsuranceTypeId==0)) {
insertSqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, ssENRequisitionContractFile.ssInsuranceTypeId);

}
if ((ssENRequisitionContractFile.ssAdvancePaymentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENRequisitionContractFile.ssAdvancePaymentTypeId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisitionContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisitionContractFile
/// </summary>

public static async Task<long> CreateOrUpdateRequisitionContractFile(IRequestContext requestContext,BitArray usedFields,RC_471ec64149613ec0a9f3525fc2d9e11c inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssENRequisitionContractFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENRequisitionContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid") + " = @ssRequisitionFileId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + " = @ssContractFileTypeId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + " = @ssDepositTypeId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + " = @ssInsuranceTypeId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " = @ssAdvancePaymentTypeId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitinContractFile_ssId_RequisitionContractFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionContractFile.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionContractFile.ssRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionContractFile.ssRequisitionFileId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionFileId", DbType.Int64, ssENRequisitionContractFile.ssRequisitionFileId);

}
}
if(usedFields[3]) {
if ((ssENRequisitionContractFile.ssContractFileTypeId==0)) {
sqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, ssENRequisitionContractFile.ssContractFileTypeId);

}
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionContractFile.ssAmount);
{
    string decimalAsStr = ssENRequisitionContractFile.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
if ((ssENRequisitionContractFile.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisitionContractFile.ssCurrencyId);

}
}
if(usedFields[6]) {
if ((ssENRequisitionContractFile.ssDepositTypeId==0)) {
sqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, ssENRequisitionContractFile.ssDepositTypeId);

}
}
if(usedFields[7]) {
if ((ssENRequisitionContractFile.ssInsuranceTypeId==0)) {
sqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, ssENRequisitionContractFile.ssInsuranceTypeId);

}
}
if(usedFields[8]) {
if ((ssENRequisitionContractFile.ssAdvancePaymentTypeId==0)) {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENRequisitionContractFile.ssAdvancePaymentTypeId);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitinContractFile_ssId_RequisitionContractFile", DbType.Int64, ssENRequisitionContractFile.ssId);
int counter = 0;
if(ssENRequisitionContractFile.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionContractFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionContractFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + "" +
" ) VALUES (" +
" @ssRequisitionId" +
", @ssRequisitionFileId" +
", @ssContractFileTypeId" +
", @ssAmount" +
", @ssCurrencyId" +
", @ssDepositTypeId" +
", @ssInsuranceTypeId" +
", @ssAdvancePaymentTypeId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENRequisitionContractFile.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionContractFile.ssRequisitionId);

}
if ((ssENRequisitionContractFile.ssRequisitionFileId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionFileId", DbType.Int64, ssENRequisitionContractFile.ssRequisitionFileId);

}
if ((ssENRequisitionContractFile.ssContractFileTypeId==0)) {
insertSqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, ssENRequisitionContractFile.ssContractFileTypeId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionContractFile.ssAmount);
{
    string decimalAsStr = ssENRequisitionContractFile.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENRequisitionContractFile.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisitionContractFile.ssCurrencyId);

}
if ((ssENRequisitionContractFile.ssDepositTypeId==0)) {
insertSqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, ssENRequisitionContractFile.ssDepositTypeId);

}
if ((ssENRequisitionContractFile.ssInsuranceTypeId==0)) {
insertSqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, ssENRequisitionContractFile.ssInsuranceTypeId);

}
if ((ssENRequisitionContractFile.ssAdvancePaymentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENRequisitionContractFile.ssAdvancePaymentTypeId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisitionContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisitionContractFile.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisitionContractFile
/// </summary>

public static async Task CreateOrUpdateSomeRequisitionContractFile(IRequestContext requestContext,RL_25486e09ba20acde3d8ef9d3e8a6e625 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionContractFileEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + ") VALUES ( unnest(@ssRequisitionId),  unnest(@ssRequisitionFileId),  unnest(@ssContractFileTypeId),  unnest(@ssAmount),  unnest(@ssCurrencyId),  unnest(@ssDepositTypeId),  unnest(@ssInsuranceTypeId),  unnest(@ssAdvancePaymentTypeId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ",  unnest(@ssRequisitionFileId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid") + ",  unnest(@ssContractFileTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + ",  unnest(@ssAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount") + ",  unnest(@ssCurrencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ",  unnest(@ssDepositTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + ",  unnest(@ssInsuranceTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + ",  unnest(@ssAdvancePaymentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertRequisitionIdList = new List<object>();
List<object> insertRequisitionFileIdList = new List<object>();
List<object> insertContractFileTypeIdList = new List<object>();
List<decimal> insertAmountList = new List<decimal>();
List<object> insertCurrencyIdList = new List<object>();
List<object> insertDepositTypeIdList = new List<object>();
List<object> insertInsuranceTypeIdList = new List<object>();
List<object> insertAdvancePaymentTypeIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateRequisitionIdList = new List<object>();
List<object> updateRequisitionFileIdList = new List<object>();
List<object> updateContractFileTypeIdList = new List<object>();
List<decimal> updateAmountList = new List<decimal>();
List<object> updateCurrencyIdList = new List<object>();
List<object> updateDepositTypeIdList = new List<object>();
List<object> updateInsuranceTypeIdList = new List<object>();
List<object> updateAdvancePaymentTypeIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_471ec64149613ec0a9f3525fc2d9e11c)inParamSourceList.Current).ssENRequisitionContractFile;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssRequisitionId==0L)) {
updateRequisitionIdList.Add(null);
} else {
updateRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssRequisitionFileId==0L)) {
updateRequisitionFileIdList.Add(null);
} else {
updateRequisitionFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionFileId));
}
if ((record.ssContractFileTypeId==0)) {
updateContractFileTypeIdList.Add(null);
} else {
updateContractFileTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssContractFileTypeId));
}
updateAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
if ((record.ssCurrencyId=="")) {
updateCurrencyIdList.Add(null);
} else {
updateCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssDepositTypeId==0)) {
updateDepositTypeIdList.Add(null);
} else {
updateDepositTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssDepositTypeId));
}
if ((record.ssInsuranceTypeId==0)) {
updateInsuranceTypeIdList.Add(null);
} else {
updateInsuranceTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInsuranceTypeId));
}
if ((record.ssAdvancePaymentTypeId==0)) {
updateAdvancePaymentTypeIdList.Add(null);
} else {
updateAdvancePaymentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssAdvancePaymentTypeId));
}
} else {
if ((record.ssRequisitionId==0L)) {
insertRequisitionIdList.Add(null);
} else {
insertRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssRequisitionFileId==0L)) {
insertRequisitionFileIdList.Add(null);
} else {
insertRequisitionFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionFileId));
}
if ((record.ssContractFileTypeId==0)) {
insertContractFileTypeIdList.Add(null);
} else {
insertContractFileTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssContractFileTypeId));
}
insertAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
if ((record.ssCurrencyId=="")) {
insertCurrencyIdList.Add(null);
} else {
insertCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssDepositTypeId==0)) {
insertDepositTypeIdList.Add(null);
} else {
insertDepositTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssDepositTypeId));
}
if ((record.ssInsuranceTypeId==0)) {
insertInsuranceTypeIdList.Add(null);
} else {
insertInsuranceTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInsuranceTypeId));
}
if ((record.ssAdvancePaymentTypeId==0)) {
insertAdvancePaymentTypeIdList.Add(null);
} else {
insertAdvancePaymentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssAdvancePaymentTypeId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertRequisitionIdList.IsEmpty() || !insertRequisitionFileIdList.IsEmpty() || !insertContractFileTypeIdList.IsEmpty() || !insertAmountList.IsEmpty() || !insertCurrencyIdList.IsEmpty() || !insertDepositTypeIdList.IsEmpty() || !insertInsuranceTypeIdList.IsEmpty() || !insertAdvancePaymentTypeIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionId",DbType.Int64,insertRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionFileId",DbType.Int64,insertRequisitionFileIdList);
executionService.CreateParameter(insertSqlCmd,"@ssContractFileTypeId",DbType.Int32,insertContractFileTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAmount",DbType.Decimal,insertAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrencyId",DbType.String,insertCurrencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDepositTypeId",DbType.Int32,insertDepositTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInsuranceTypeId",DbType.Int32,insertInsuranceTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAdvancePaymentTypeId",DbType.Int32,insertAdvancePaymentTypeIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionContractFile (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateRequisitionIdList.IsEmpty() || !updateRequisitionFileIdList.IsEmpty() || !updateContractFileTypeIdList.IsEmpty() || !updateAmountList.IsEmpty() || !updateCurrencyIdList.IsEmpty() || !updateDepositTypeIdList.IsEmpty() || !updateInsuranceTypeIdList.IsEmpty() || !updateAdvancePaymentTypeIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionId",DbType.Int64,updateRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionFileId",DbType.Int64,updateRequisitionFileIdList);
executionService.CreateParameter(updateSqlCmd,"@ssContractFileTypeId",DbType.Int32,updateContractFileTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAmount",DbType.Decimal,updateAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrencyId",DbType.String,updateCurrencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDepositTypeId",DbType.Int32,updateDepositTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInsuranceTypeId",DbType.Int32,updateInsuranceTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAdvancePaymentTypeId",DbType.Int32,updateAdvancePaymentTypeIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisitionContractFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisitionContractFile
/// </summary>

public static async Task DeleteRequisitionContractFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisitionContractFile
/// </summary>

public static async Task DeleteAllRequisitionContractFile(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisitionContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisitionContractFile
/// </summary>

public static async Task<RC_471ec64149613ec0a9f3525fc2d9e11c> GetRequisitionContractFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_471ec64149613ec0a9f3525fc2d9e11c outParamRecord = default;
outParamRecord = new RC_471ec64149613ec0a9f3525fc2d9e11c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENRequisitionContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionContractFileForUpdate
/// </summary>

public static async Task<RC_471ec64149613ec0a9f3525fc2d9e11c> GetRequisitionContractFileForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_471ec64149613ec0a9f3525fc2d9e11c outParamRecord = default;
outParamRecord = new RC_471ec64149613ec0a9f3525fc2d9e11c();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionContractFileForUpdate", "1d992305-b244-443a-9764-3617db3cc23b.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionContractFileForUpdate", "1d992305-b244-443a-9764-3617db3cc23b.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENRequisitionContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionContractFileForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisitionContractFile
/// </summary>

public static async Task UpdateRequisitionContractFile(IRequestContext requestContext,BitArray usedFields,RC_471ec64149613ec0a9f3525fc2d9e11c inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisitionContractFile", "1d992305-b244-443a-9764-3617db3cc23b.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssENRequisitionContractFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENRequisitionContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@RequisitionFileId, "requisitionfileid") ?? "requisitionfileid") + " = @ssRequisitionFileId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + " = @ssContractFileTypeId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + " = @ssDepositTypeId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + " = @ssInsuranceTypeId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " = @ssAdvancePaymentTypeId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisitinContractFile_ssId_RequisitionContractFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENRequisitionContractFile.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENRequisitionContractFile.ssRequisitionId);

}
}
if(usedFields[2]) {
if ((ssENRequisitionContractFile.ssRequisitionFileId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionFileId", DbType.Int64, ssENRequisitionContractFile.ssRequisitionFileId);

}
}
if(usedFields[3]) {
if ((ssENRequisitionContractFile.ssContractFileTypeId==0)) {
sqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, ssENRequisitionContractFile.ssContractFileTypeId);

}
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENRequisitionContractFile.ssAmount);
{
    string decimalAsStr = ssENRequisitionContractFile.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
if ((ssENRequisitionContractFile.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisitionContractFile.ssCurrencyId);

}
}
if(usedFields[6]) {
if ((ssENRequisitionContractFile.ssDepositTypeId==0)) {
sqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, ssENRequisitionContractFile.ssDepositTypeId);

}
}
if(usedFields[7]) {
if ((ssENRequisitionContractFile.ssInsuranceTypeId==0)) {
sqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, ssENRequisitionContractFile.ssInsuranceTypeId);

}
}
if(usedFields[8]) {
if ((ssENRequisitionContractFile.ssAdvancePaymentTypeId==0)) {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENRequisitionContractFile.ssAdvancePaymentTypeId);

}
}
sqlCmd.CreateParameter("@idparam_ssENRequisitinContractFile_ssId_RequisitionContractFile", DbType.Int64, ssENRequisitionContractFile.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisitionContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("RequisitionContractFile", ssENRequisitionContractFile.ssId.ToString()); }}
}
return;
}

}
}
