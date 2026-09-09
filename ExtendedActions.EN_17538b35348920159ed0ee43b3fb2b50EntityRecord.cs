using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderContractFile
/// </summary>

public static async Task<long> CreateOrderContractFile(IRequestContext requestContext,RC_bdb8cd2e0da3eae2f170942895f2a3ac inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderContractFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssOrderFileId" +
", @ssContractFileTypeId" +
", @ssAmount" +
", @ssTarif" +
", @ssCurrencyId" +
", @ssDepositTypeId" +
", @ssInsuranceTypeId" +
", @ssAdvancePaymentTypeId" +
", @ssStartBaseDate" +
", @ssEndBaseDate" +
", @ssPaymentTermsId" +
", @ssIsForVendorUpload" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderContractFile.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderContractFile.ssOrderId);

}
if ((ssENOrderContractFile.ssOrderFileId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderFileId", DbType.Int64, ssENOrderContractFile.ssOrderFileId);

}
if ((ssENOrderContractFile.ssContractFileTypeId==0)) {
insertSqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, ssENOrderContractFile.ssContractFileTypeId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderContractFile.ssAmount);
{
    string decimalAsStr = ssENOrderContractFile.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TarifParameter = insertSqlCmd.CreateParameter("@ssTarif", DbType.Decimal, ssENOrderContractFile.ssTarif);
{
    string decimalAsStr = ssENOrderContractFile.ssTarif.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TarifParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderContractFile.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderContractFile.ssCurrencyId);

}
if ((ssENOrderContractFile.ssDepositTypeId==0)) {
insertSqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, ssENOrderContractFile.ssDepositTypeId);

}
if ((ssENOrderContractFile.ssInsuranceTypeId==0)) {
insertSqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, ssENOrderContractFile.ssInsuranceTypeId);

}
if ((ssENOrderContractFile.ssAdvancePaymentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENOrderContractFile.ssAdvancePaymentTypeId);

}
insertSqlCmd.CreateParameter("@ssStartBaseDate", DbType.DateTime, ssENOrderContractFile.ssStartBaseDate);
insertSqlCmd.CreateParameter("@ssEndBaseDate", DbType.DateTime, ssENOrderContractFile.ssEndBaseDate);
if ((ssENOrderContractFile.ssPaymentTermsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENOrderContractFile.ssPaymentTermsId);

}
insertSqlCmd.CreateParameter("@ssIsForVendorUpload", DbType.Boolean, ssENOrderContractFile.ssIsForVendorUpload);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderContractFile
/// </summary>

public static async Task<long> CreateOrUpdateOrderContractFile(IRequestContext requestContext,BitArray usedFields,RC_bdb8cd2e0da3eae2f170942895f2a3ac inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(14,true);
}
string updateSet = "UPDATE " + ENOrderContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid") + " = @ssOrderFileId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + " = @ssContractFileTypeId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif") + " = @ssTarif"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + " = @ssDepositTypeId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + " = @ssInsuranceTypeId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " = @ssAdvancePaymentTypeId"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + " = @ssStartBaseDate"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + " = @ssEndBaseDate"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = @ssPaymentTermsId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + " = @ssIsForVendorUpload"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderContractFile_ssId_OrderContractFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderContractFile.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderContractFile.ssOrderId);

}
}
if(usedFields[2]) {
if ((ssENOrderContractFile.ssOrderFileId==0L)) {
sqlCmd.CreateParameter("@ssOrderFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderFileId", DbType.Int64, ssENOrderContractFile.ssOrderFileId);

}
}
if(usedFields[3]) {
if ((ssENOrderContractFile.ssContractFileTypeId==0)) {
sqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, ssENOrderContractFile.ssContractFileTypeId);

}
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderContractFile.ssAmount);
{
    string decimalAsStr = ssENOrderContractFile.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
var TarifParameter = sqlCmd.CreateParameter("@ssTarif", DbType.Decimal, ssENOrderContractFile.ssTarif);
{
    string decimalAsStr = ssENOrderContractFile.ssTarif.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TarifParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[6]) {
if ((ssENOrderContractFile.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderContractFile.ssCurrencyId);

}
}
if(usedFields[7]) {
if ((ssENOrderContractFile.ssDepositTypeId==0)) {
sqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, ssENOrderContractFile.ssDepositTypeId);

}
}
if(usedFields[8]) {
if ((ssENOrderContractFile.ssInsuranceTypeId==0)) {
sqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, ssENOrderContractFile.ssInsuranceTypeId);

}
}
if(usedFields[9]) {
if ((ssENOrderContractFile.ssAdvancePaymentTypeId==0)) {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENOrderContractFile.ssAdvancePaymentTypeId);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssStartBaseDate", DbType.DateTime, ssENOrderContractFile.ssStartBaseDate);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssEndBaseDate", DbType.DateTime, ssENOrderContractFile.ssEndBaseDate);
}
if(usedFields[12]) {
if ((ssENOrderContractFile.ssPaymentTermsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENOrderContractFile.ssPaymentTermsId);

}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssIsForVendorUpload", DbType.Boolean, ssENOrderContractFile.ssIsForVendorUpload);
}
sqlCmd.CreateParameter("@idparam_ssENOrderContractFile_ssId_OrderContractFile", DbType.Int64, ssENOrderContractFile.ssId);
int counter = 0;
if(ssENOrderContractFile.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderContractFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderContractFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssOrderFileId" +
", @ssContractFileTypeId" +
", @ssAmount" +
", @ssTarif" +
", @ssCurrencyId" +
", @ssDepositTypeId" +
", @ssInsuranceTypeId" +
", @ssAdvancePaymentTypeId" +
", @ssStartBaseDate" +
", @ssEndBaseDate" +
", @ssPaymentTermsId" +
", @ssIsForVendorUpload" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderContractFile.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderContractFile.ssOrderId);

}
if ((ssENOrderContractFile.ssOrderFileId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderFileId", DbType.Int64, ssENOrderContractFile.ssOrderFileId);

}
if ((ssENOrderContractFile.ssContractFileTypeId==0)) {
insertSqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, ssENOrderContractFile.ssContractFileTypeId);

}
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderContractFile.ssAmount);
{
    string decimalAsStr = ssENOrderContractFile.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TarifParameter = insertSqlCmd.CreateParameter("@ssTarif", DbType.Decimal, ssENOrderContractFile.ssTarif);
{
    string decimalAsStr = ssENOrderContractFile.ssTarif.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TarifParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderContractFile.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderContractFile.ssCurrencyId);

}
if ((ssENOrderContractFile.ssDepositTypeId==0)) {
insertSqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, ssENOrderContractFile.ssDepositTypeId);

}
if ((ssENOrderContractFile.ssInsuranceTypeId==0)) {
insertSqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, ssENOrderContractFile.ssInsuranceTypeId);

}
if ((ssENOrderContractFile.ssAdvancePaymentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENOrderContractFile.ssAdvancePaymentTypeId);

}
insertSqlCmd.CreateParameter("@ssStartBaseDate", DbType.DateTime, ssENOrderContractFile.ssStartBaseDate);
insertSqlCmd.CreateParameter("@ssEndBaseDate", DbType.DateTime, ssENOrderContractFile.ssEndBaseDate);
if ((ssENOrderContractFile.ssPaymentTermsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENOrderContractFile.ssPaymentTermsId);

}
insertSqlCmd.CreateParameter("@ssIsForVendorUpload", DbType.Boolean, ssENOrderContractFile.ssIsForVendorUpload);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderContractFile.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderContractFile
/// </summary>

public static async Task CreateOrUpdateSomeOrderContractFile(IRequestContext requestContext,RL_0c8daebacea14512c4f2bc71294af3cc inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderContractFileEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + ") VALUES ( unnest(@ssOrderId),  unnest(@ssOrderFileId),  unnest(@ssContractFileTypeId),  unnest(@ssAmount),  unnest(@ssTarif),  unnest(@ssCurrencyId),  unnest(@ssDepositTypeId),  unnest(@ssInsuranceTypeId),  unnest(@ssAdvancePaymentTypeId),  unnest(@ssStartBaseDate),  unnest(@ssEndBaseDate),  unnest(@ssPaymentTermsId),  unnest(@ssIsForVendorUpload)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + ",  unnest(@ssOrderFileId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid") + ",  unnest(@ssContractFileTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + ",  unnest(@ssAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount") + ",  unnest(@ssTarif) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif") + ",  unnest(@ssCurrencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ",  unnest(@ssDepositTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + ",  unnest(@ssInsuranceTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + ",  unnest(@ssAdvancePaymentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + ",  unnest(@ssStartBaseDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + ",  unnest(@ssEndBaseDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + ",  unnest(@ssPaymentTermsId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ",  unnest(@ssIsForVendorUpload) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderIdList = new List<object>();
List<object> insertOrderFileIdList = new List<object>();
List<object> insertContractFileTypeIdList = new List<object>();
List<decimal> insertAmountList = new List<decimal>();
List<decimal> insertTarifList = new List<decimal>();
List<object> insertCurrencyIdList = new List<object>();
List<object> insertDepositTypeIdList = new List<object>();
List<object> insertInsuranceTypeIdList = new List<object>();
List<object> insertAdvancePaymentTypeIdList = new List<object>();
List<DateTime> insertStartBaseDateList = new List<DateTime>();
List<DateTime> insertEndBaseDateList = new List<DateTime>();
List<object> insertPaymentTermsIdList = new List<object>();
List<bool> insertIsForVendorUploadList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateOrderIdList = new List<object>();
List<object> updateOrderFileIdList = new List<object>();
List<object> updateContractFileTypeIdList = new List<object>();
List<decimal> updateAmountList = new List<decimal>();
List<decimal> updateTarifList = new List<decimal>();
List<object> updateCurrencyIdList = new List<object>();
List<object> updateDepositTypeIdList = new List<object>();
List<object> updateInsuranceTypeIdList = new List<object>();
List<object> updateAdvancePaymentTypeIdList = new List<object>();
List<DateTime> updateStartBaseDateList = new List<DateTime>();
List<DateTime> updateEndBaseDateList = new List<DateTime>();
List<object> updatePaymentTermsIdList = new List<object>();
List<bool> updateIsForVendorUploadList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_bdb8cd2e0da3eae2f170942895f2a3ac)inParamSourceList.Current).ssENOrderContractFile;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderId==0L)) {
updateOrderIdList.Add(null);
} else {
updateOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssOrderFileId==0L)) {
updateOrderFileIdList.Add(null);
} else {
updateOrderFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderFileId));
}
if ((record.ssContractFileTypeId==0)) {
updateContractFileTypeIdList.Add(null);
} else {
updateContractFileTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssContractFileTypeId));
}
updateAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
updateTarifList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTarif));
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
updateStartBaseDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartBaseDate));
updateEndBaseDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssEndBaseDate));
if ((record.ssPaymentTermsId==0L)) {
updatePaymentTermsIdList.Add(null);
} else {
updatePaymentTermsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermsId));
}
updateIsForVendorUploadList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsForVendorUpload));
} else {
if ((record.ssOrderId==0L)) {
insertOrderIdList.Add(null);
} else {
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssOrderFileId==0L)) {
insertOrderFileIdList.Add(null);
} else {
insertOrderFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderFileId));
}
if ((record.ssContractFileTypeId==0)) {
insertContractFileTypeIdList.Add(null);
} else {
insertContractFileTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssContractFileTypeId));
}
insertAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount));
insertTarifList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTarif));
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
insertStartBaseDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartBaseDate));
insertEndBaseDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssEndBaseDate));
if ((record.ssPaymentTermsId==0L)) {
insertPaymentTermsIdList.Add(null);
} else {
insertPaymentTermsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermsId));
}
insertIsForVendorUploadList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsForVendorUpload));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderIdList.IsEmpty() || !insertOrderFileIdList.IsEmpty() || !insertContractFileTypeIdList.IsEmpty() || !insertAmountList.IsEmpty() || !insertTarifList.IsEmpty() || !insertCurrencyIdList.IsEmpty() || !insertDepositTypeIdList.IsEmpty() || !insertInsuranceTypeIdList.IsEmpty() || !insertAdvancePaymentTypeIdList.IsEmpty() || !insertStartBaseDateList.IsEmpty() || !insertEndBaseDateList.IsEmpty() || !insertPaymentTermsIdList.IsEmpty() || !insertIsForVendorUploadList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderFileId",DbType.Int64,insertOrderFileIdList);
executionService.CreateParameter(insertSqlCmd,"@ssContractFileTypeId",DbType.Int32,insertContractFileTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAmount",DbType.Decimal,insertAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssTarif",DbType.Decimal,insertTarifList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrencyId",DbType.String,insertCurrencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDepositTypeId",DbType.Int32,insertDepositTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInsuranceTypeId",DbType.Int32,insertInsuranceTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAdvancePaymentTypeId",DbType.Int32,insertAdvancePaymentTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssStartBaseDate",DbType.DateTime,insertStartBaseDateList);
executionService.CreateParameter(insertSqlCmd,"@ssEndBaseDate",DbType.DateTime,insertEndBaseDateList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentTermsId",DbType.Int64,insertPaymentTermsIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsForVendorUpload",DbType.Boolean,insertIsForVendorUploadList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderContractFile (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderIdList.IsEmpty() || !updateOrderFileIdList.IsEmpty() || !updateContractFileTypeIdList.IsEmpty() || !updateAmountList.IsEmpty() || !updateTarifList.IsEmpty() || !updateCurrencyIdList.IsEmpty() || !updateDepositTypeIdList.IsEmpty() || !updateInsuranceTypeIdList.IsEmpty() || !updateAdvancePaymentTypeIdList.IsEmpty() || !updateStartBaseDateList.IsEmpty() || !updateEndBaseDateList.IsEmpty() || !updatePaymentTermsIdList.IsEmpty() || !updateIsForVendorUploadList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderId",DbType.Int64,updateOrderIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderFileId",DbType.Int64,updateOrderFileIdList);
executionService.CreateParameter(updateSqlCmd,"@ssContractFileTypeId",DbType.Int32,updateContractFileTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAmount",DbType.Decimal,updateAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssTarif",DbType.Decimal,updateTarifList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrencyId",DbType.String,updateCurrencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDepositTypeId",DbType.Int32,updateDepositTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInsuranceTypeId",DbType.Int32,updateInsuranceTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAdvancePaymentTypeId",DbType.Int32,updateAdvancePaymentTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssStartBaseDate",DbType.DateTime,updateStartBaseDateList);
executionService.CreateParameter(updateSqlCmd,"@ssEndBaseDate",DbType.DateTime,updateEndBaseDateList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentTermsId",DbType.Int64,updatePaymentTermsIdList);
executionService.CreateParameter(updateSqlCmd,"@ssIsForVendorUpload",DbType.Boolean,updateIsForVendorUploadList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderContractFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderContractFile
/// </summary>

public static async Task DeleteOrderContractFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderContractFile
/// </summary>

public static async Task DeleteAllOrderContractFile(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderContractFile
/// </summary>

public static async Task<RC_bdb8cd2e0da3eae2f170942895f2a3ac> GetOrderContractFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bdb8cd2e0da3eae2f170942895f2a3ac outParamRecord = default;
outParamRecord = new RC_bdb8cd2e0da3eae2f170942895f2a3ac();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(14,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderContractFileForUpdate
/// </summary>

public static async Task<RC_bdb8cd2e0da3eae2f170942895f2a3ac> GetOrderContractFileForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bdb8cd2e0da3eae2f170942895f2a3ac outParamRecord = default;
outParamRecord = new RC_bdb8cd2e0da3eae2f170942895f2a3ac();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderContractFileForUpdate", "8c037397-8383-45cd-b017-b30ef353825d.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderContractFileForUpdate", "8c037397-8383-45cd-b017-b30ef353825d.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderContractFileForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(14,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderContractFile
/// </summary>

public static async Task UpdateOrderContractFile(IRequestContext requestContext,BitArray usedFields,RC_bdb8cd2e0da3eae2f170942895f2a3ac inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderContractFile", "8c037397-8383-45cd-b017-b30ef353825d.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(14,true);
}
string updateSet = "UPDATE " + ENOrderContractFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@OrderFileId, "orderfileid") ?? "orderfileid") + " = @ssOrderFileId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@ContractFileTypeId, "contractfiletypeid") ?? "contractfiletypeid") + " = @ssContractFileTypeId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Tarif, "tarif") ?? "tarif") + " = @ssTarif"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@DepositTypeId, "deposittypeid") ?? "deposittypeid") + " = @ssDepositTypeId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@InsuranceTypeId, "insurancetypeid") ?? "insurancetypeid") + " = @ssInsuranceTypeId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " = @ssAdvancePaymentTypeId"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + " = @ssStartBaseDate"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + " = @ssEndBaseDate"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = @ssPaymentTermsId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + " = @ssIsForVendorUpload"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderContractFile_ssId_OrderContractFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderContractFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderContractFileAttributeKeys.@IsForVendorUpload, "isforvendorupload") ?? "isforvendorupload") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderContractFile.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderContractFile.ssOrderId);

}
}
if(usedFields[2]) {
if ((ssENOrderContractFile.ssOrderFileId==0L)) {
sqlCmd.CreateParameter("@ssOrderFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderFileId", DbType.Int64, ssENOrderContractFile.ssOrderFileId);

}
}
if(usedFields[3]) {
if ((ssENOrderContractFile.ssContractFileTypeId==0)) {
sqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssContractFileTypeId", DbType.Int32, ssENOrderContractFile.ssContractFileTypeId);

}
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderContractFile.ssAmount);
{
    string decimalAsStr = ssENOrderContractFile.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
var TarifParameter = sqlCmd.CreateParameter("@ssTarif", DbType.Decimal, ssENOrderContractFile.ssTarif);
{
    string decimalAsStr = ssENOrderContractFile.ssTarif.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TarifParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[6]) {
if ((ssENOrderContractFile.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderContractFile.ssCurrencyId);

}
}
if(usedFields[7]) {
if ((ssENOrderContractFile.ssDepositTypeId==0)) {
sqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDepositTypeId", DbType.Int32, ssENOrderContractFile.ssDepositTypeId);

}
}
if(usedFields[8]) {
if ((ssENOrderContractFile.ssInsuranceTypeId==0)) {
sqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInsuranceTypeId", DbType.Int32, ssENOrderContractFile.ssInsuranceTypeId);

}
}
if(usedFields[9]) {
if ((ssENOrderContractFile.ssAdvancePaymentTypeId==0)) {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENOrderContractFile.ssAdvancePaymentTypeId);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssStartBaseDate", DbType.DateTime, ssENOrderContractFile.ssStartBaseDate);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssEndBaseDate", DbType.DateTime, ssENOrderContractFile.ssEndBaseDate);
}
if(usedFields[12]) {
if ((ssENOrderContractFile.ssPaymentTermsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENOrderContractFile.ssPaymentTermsId);

}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssIsForVendorUpload", DbType.Boolean, ssENOrderContractFile.ssIsForVendorUpload);
}
sqlCmd.CreateParameter("@idparam_ssENOrderContractFile_ssId_OrderContractFile", DbType.Int64, ssENOrderContractFile.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderContractFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderContractFile", ssENOrderContractFile.ssId.ToString()); }}
}
return;
}

}
}
