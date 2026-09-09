using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderAccConcepts
/// </summary>

public static async Task<long> CreateOrderAccConcepts(IRequestContext requestContext,RC_dc9a6819825fee88eba01192ae9b1890 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderAccConceptsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete") + "" +
" ) VALUES (" +
" @ssOrderAccountingId" +
", @ssAccountingDataTypeId" +
", @ssNumberOfPayments" +
", @ssAmount" +
", @ssCurrencyId" +
", @ssOrderAccConceptsId" +
", @ssApplyForRequestProject" +
", @ssPaymentTermId" +
", @ssPaymentTermCustomDays" +
", @ssIsActive" +
", @ssAdvancePaymentTypeId" +
", @ssPaymentDate" +
", @ssPaymentMethodsIdToDelete" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderAccConcepts.ssOrderAccountingId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderAccountingId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderAccountingId", DbType.Int64, ssENOrderAccConcepts.ssOrderAccountingId);

}
if ((ssENOrderAccConcepts.ssAccountingDataTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, ssENOrderAccConcepts.ssAccountingDataTypeId);

}
insertSqlCmd.CreateParameter("@ssNumberOfPayments", DbType.Int32, ssENOrderAccConcepts.ssNumberOfPayments);
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderAccConcepts.ssAmount);
{
    string decimalAsStr = ssENOrderAccConcepts.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderAccConcepts.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderAccConcepts.ssCurrencyId);

}
if ((ssENOrderAccConcepts.ssOrderAccConceptsId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderAccConceptsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderAccConceptsId", DbType.Int64, ssENOrderAccConcepts.ssOrderAccConceptsId);

}
insertSqlCmd.CreateParameter("@ssApplyForRequestProject", DbType.Boolean, ssENOrderAccConcepts.ssApplyForRequestProject);
if ((ssENOrderAccConcepts.ssPaymentTermId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermId", DbType.Int64, ssENOrderAccConcepts.ssPaymentTermId);

}
insertSqlCmd.CreateParameter("@ssPaymentTermCustomDays", DbType.Int32, ssENOrderAccConcepts.ssPaymentTermCustomDays);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENOrderAccConcepts.ssIsActive);
if ((ssENOrderAccConcepts.ssAdvancePaymentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENOrderAccConcepts.ssAdvancePaymentTypeId);

}
insertSqlCmd.CreateParameter("@ssPaymentDate", DbType.DateTime, ssENOrderAccConcepts.ssPaymentDate);
if ((ssENOrderAccConcepts.ssPaymentMethodsIdToDelete==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodsIdToDelete", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodsIdToDelete", DbType.Int64, ssENOrderAccConcepts.ssPaymentMethodsIdToDelete);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderAccConcepts
/// </summary>

public static async Task<long> CreateOrUpdateOrderAccConcepts(IRequestContext requestContext,BitArray usedFields,RC_dc9a6819825fee88eba01192ae9b1890 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(14,true);
}
string updateSet = "UPDATE " + ENOrderAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid") + " = @ssOrderAccountingId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + " = @ssAccountingDataTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + " = @ssNumberOfPayments"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid") + " = @ssOrderAccConceptsId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + " = @ssApplyForRequestProject"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid") + " = @ssPaymentTermId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays") + " = @ssPaymentTermCustomDays"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " = @ssIsActive"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " = @ssAdvancePaymentTypeId"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + " = @ssPaymentDate"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete") + " = @ssPaymentMethodsIdToDelete"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderAccConcepts_ssId_OrderAccConcepts";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderAccConcepts.ssOrderAccountingId==0L)) {
sqlCmd.CreateParameter("@ssOrderAccountingId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderAccountingId", DbType.Int64, ssENOrderAccConcepts.ssOrderAccountingId);

}
}
if(usedFields[2]) {
if ((ssENOrderAccConcepts.ssAccountingDataTypeId==0)) {
sqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, ssENOrderAccConcepts.ssAccountingDataTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssNumberOfPayments", DbType.Int32, ssENOrderAccConcepts.ssNumberOfPayments);
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderAccConcepts.ssAmount);
{
    string decimalAsStr = ssENOrderAccConcepts.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
if ((ssENOrderAccConcepts.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderAccConcepts.ssCurrencyId);

}
}
if(usedFields[6]) {
if ((ssENOrderAccConcepts.ssOrderAccConceptsId==0L)) {
sqlCmd.CreateParameter("@ssOrderAccConceptsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderAccConceptsId", DbType.Int64, ssENOrderAccConcepts.ssOrderAccConceptsId);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssApplyForRequestProject", DbType.Boolean, ssENOrderAccConcepts.ssApplyForRequestProject);
}
if(usedFields[8]) {
if ((ssENOrderAccConcepts.ssPaymentTermId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermId", DbType.Int64, ssENOrderAccConcepts.ssPaymentTermId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssPaymentTermCustomDays", DbType.Int32, ssENOrderAccConcepts.ssPaymentTermCustomDays);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENOrderAccConcepts.ssIsActive);
}
if(usedFields[11]) {
if ((ssENOrderAccConcepts.ssAdvancePaymentTypeId==0)) {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENOrderAccConcepts.ssAdvancePaymentTypeId);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssPaymentDate", DbType.DateTime, ssENOrderAccConcepts.ssPaymentDate);
}
if(usedFields[13]) {
if ((ssENOrderAccConcepts.ssPaymentMethodsIdToDelete==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodsIdToDelete", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodsIdToDelete", DbType.Int64, ssENOrderAccConcepts.ssPaymentMethodsIdToDelete);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderAccConcepts_ssId_OrderAccConcepts", DbType.Int64, ssENOrderAccConcepts.ssId);
int counter = 0;
if(ssENOrderAccConcepts.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderAccConcepts (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderAccConceptsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete") + "" +
" ) VALUES (" +
" @ssOrderAccountingId" +
", @ssAccountingDataTypeId" +
", @ssNumberOfPayments" +
", @ssAmount" +
", @ssCurrencyId" +
", @ssOrderAccConceptsId" +
", @ssApplyForRequestProject" +
", @ssPaymentTermId" +
", @ssPaymentTermCustomDays" +
", @ssIsActive" +
", @ssAdvancePaymentTypeId" +
", @ssPaymentDate" +
", @ssPaymentMethodsIdToDelete" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderAccConcepts.ssOrderAccountingId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderAccountingId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderAccountingId", DbType.Int64, ssENOrderAccConcepts.ssOrderAccountingId);

}
if ((ssENOrderAccConcepts.ssAccountingDataTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, ssENOrderAccConcepts.ssAccountingDataTypeId);

}
insertSqlCmd.CreateParameter("@ssNumberOfPayments", DbType.Int32, ssENOrderAccConcepts.ssNumberOfPayments);
var AmountParameter = insertSqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderAccConcepts.ssAmount);
{
    string decimalAsStr = ssENOrderAccConcepts.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderAccConcepts.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderAccConcepts.ssCurrencyId);

}
if ((ssENOrderAccConcepts.ssOrderAccConceptsId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderAccConceptsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderAccConceptsId", DbType.Int64, ssENOrderAccConcepts.ssOrderAccConceptsId);

}
insertSqlCmd.CreateParameter("@ssApplyForRequestProject", DbType.Boolean, ssENOrderAccConcepts.ssApplyForRequestProject);
if ((ssENOrderAccConcepts.ssPaymentTermId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermId", DbType.Int64, ssENOrderAccConcepts.ssPaymentTermId);

}
insertSqlCmd.CreateParameter("@ssPaymentTermCustomDays", DbType.Int32, ssENOrderAccConcepts.ssPaymentTermCustomDays);
insertSqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENOrderAccConcepts.ssIsActive);
if ((ssENOrderAccConcepts.ssAdvancePaymentTypeId==0)) {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENOrderAccConcepts.ssAdvancePaymentTypeId);

}
insertSqlCmd.CreateParameter("@ssPaymentDate", DbType.DateTime, ssENOrderAccConcepts.ssPaymentDate);
if ((ssENOrderAccConcepts.ssPaymentMethodsIdToDelete==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodsIdToDelete", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodsIdToDelete", DbType.Int64, ssENOrderAccConcepts.ssPaymentMethodsIdToDelete);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderAccConcepts.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderAccConcepts
/// </summary>

public static async Task CreateOrUpdateSomeOrderAccConcepts(IRequestContext requestContext,RL_f805dfae1f4ccde9f7b0028b80707abe inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderAccConceptsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete") + ") VALUES ( unnest(@ssOrderAccountingId),  unnest(@ssAccountingDataTypeId),  unnest(@ssNumberOfPayments),  unnest(@ssAmount),  unnest(@ssCurrencyId),  unnest(@ssOrderAccConceptsId),  unnest(@ssApplyForRequestProject),  unnest(@ssPaymentTermId),  unnest(@ssPaymentTermCustomDays),  unnest(@ssIsActive),  unnest(@ssAdvancePaymentTypeId),  unnest(@ssPaymentDate),  unnest(@ssPaymentMethodsIdToDelete)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderAccountingId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid") + ",  unnest(@ssAccountingDataTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + ",  unnest(@ssNumberOfPayments) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + ",  unnest(@ssAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + ",  unnest(@ssCurrencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ",  unnest(@ssOrderAccConceptsId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid") + ",  unnest(@ssApplyForRequestProject) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + ",  unnest(@ssPaymentTermId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid") + ",  unnest(@ssPaymentTermCustomDays) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays") + ",  unnest(@ssIsActive) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + ",  unnest(@ssAdvancePaymentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + ",  unnest(@ssPaymentDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + ",  unnest(@ssPaymentMethodsIdToDelete) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderAccountingIdList = new List<object>();
List<object> insertAccountingDataTypeIdList = new List<object>();
List<int> insertNumberOfPaymentsList = new List<int>();
List<decimal> insertAmountList = new List<decimal>();
List<object> insertCurrencyIdList = new List<object>();
List<object> insertOrderAccConceptsIdList = new List<object>();
List<bool> insertApplyForRequestProjectList = new List<bool>();
List<object> insertPaymentTermIdList = new List<object>();
List<int> insertPaymentTermCustomDaysList = new List<int>();
List<bool> insertIsActiveList = new List<bool>();
List<object> insertAdvancePaymentTypeIdList = new List<object>();
List<DateTime> insertPaymentDateList = new List<DateTime>();
List<object> insertPaymentMethodsIdToDeleteList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateOrderAccountingIdList = new List<object>();
List<object> updateAccountingDataTypeIdList = new List<object>();
List<int> updateNumberOfPaymentsList = new List<int>();
List<decimal> updateAmountList = new List<decimal>();
List<object> updateCurrencyIdList = new List<object>();
List<object> updateOrderAccConceptsIdList = new List<object>();
List<bool> updateApplyForRequestProjectList = new List<bool>();
List<object> updatePaymentTermIdList = new List<object>();
List<int> updatePaymentTermCustomDaysList = new List<int>();
List<bool> updateIsActiveList = new List<bool>();
List<object> updateAdvancePaymentTypeIdList = new List<object>();
List<DateTime> updatePaymentDateList = new List<DateTime>();
List<object> updatePaymentMethodsIdToDeleteList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_dc9a6819825fee88eba01192ae9b1890)inParamSourceList.Current).ssENOrderAccConcepts;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderAccountingId==0L)) {
updateOrderAccountingIdList.Add(null);
} else {
updateOrderAccountingIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderAccountingId));
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
if ((record.ssOrderAccConceptsId==0L)) {
updateOrderAccConceptsIdList.Add(null);
} else {
updateOrderAccConceptsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderAccConceptsId));
}
updateApplyForRequestProjectList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssApplyForRequestProject));
if ((record.ssPaymentTermId==0L)) {
updatePaymentTermIdList.Add(null);
} else {
updatePaymentTermIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermId));
}
updatePaymentTermCustomDaysList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssPaymentTermCustomDays));
updateIsActiveList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsActive));
if ((record.ssAdvancePaymentTypeId==0)) {
updateAdvancePaymentTypeIdList.Add(null);
} else {
updateAdvancePaymentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssAdvancePaymentTypeId));
}
updatePaymentDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssPaymentDate));
if ((record.ssPaymentMethodsIdToDelete==0L)) {
updatePaymentMethodsIdToDeleteList.Add(null);
} else {
updatePaymentMethodsIdToDeleteList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentMethodsIdToDelete));
}
} else {
if ((record.ssOrderAccountingId==0L)) {
insertOrderAccountingIdList.Add(null);
} else {
insertOrderAccountingIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderAccountingId));
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
if ((record.ssOrderAccConceptsId==0L)) {
insertOrderAccConceptsIdList.Add(null);
} else {
insertOrderAccConceptsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderAccConceptsId));
}
insertApplyForRequestProjectList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssApplyForRequestProject));
if ((record.ssPaymentTermId==0L)) {
insertPaymentTermIdList.Add(null);
} else {
insertPaymentTermIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermId));
}
insertPaymentTermCustomDaysList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssPaymentTermCustomDays));
insertIsActiveList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsActive));
if ((record.ssAdvancePaymentTypeId==0)) {
insertAdvancePaymentTypeIdList.Add(null);
} else {
insertAdvancePaymentTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssAdvancePaymentTypeId));
}
insertPaymentDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssPaymentDate));
if ((record.ssPaymentMethodsIdToDelete==0L)) {
insertPaymentMethodsIdToDeleteList.Add(null);
} else {
insertPaymentMethodsIdToDeleteList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentMethodsIdToDelete));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderAccountingIdList.IsEmpty() || !insertAccountingDataTypeIdList.IsEmpty() || !insertNumberOfPaymentsList.IsEmpty() || !insertAmountList.IsEmpty() || !insertCurrencyIdList.IsEmpty() || !insertOrderAccConceptsIdList.IsEmpty() || !insertApplyForRequestProjectList.IsEmpty() || !insertPaymentTermIdList.IsEmpty() || !insertPaymentTermCustomDaysList.IsEmpty() || !insertIsActiveList.IsEmpty() || !insertAdvancePaymentTypeIdList.IsEmpty() || !insertPaymentDateList.IsEmpty() || !insertPaymentMethodsIdToDeleteList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderAccountingId",DbType.Int64,insertOrderAccountingIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAccountingDataTypeId",DbType.Int32,insertAccountingDataTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssNumberOfPayments",DbType.Int32,insertNumberOfPaymentsList);
executionService.CreateParameter(insertSqlCmd,"@ssAmount",DbType.Decimal,insertAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrencyId",DbType.String,insertCurrencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderAccConceptsId",DbType.Int64,insertOrderAccConceptsIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApplyForRequestProject",DbType.Boolean,insertApplyForRequestProjectList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentTermId",DbType.Int64,insertPaymentTermIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentTermCustomDays",DbType.Int32,insertPaymentTermCustomDaysList);
executionService.CreateParameter(insertSqlCmd,"@ssIsActive",DbType.Boolean,insertIsActiveList);
executionService.CreateParameter(insertSqlCmd,"@ssAdvancePaymentTypeId",DbType.Int32,insertAdvancePaymentTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentDate",DbType.DateTime,insertPaymentDateList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentMethodsIdToDelete",DbType.Int64,insertPaymentMethodsIdToDeleteList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderAccConcepts (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderAccountingIdList.IsEmpty() || !updateAccountingDataTypeIdList.IsEmpty() || !updateNumberOfPaymentsList.IsEmpty() || !updateAmountList.IsEmpty() || !updateCurrencyIdList.IsEmpty() || !updateOrderAccConceptsIdList.IsEmpty() || !updateApplyForRequestProjectList.IsEmpty() || !updatePaymentTermIdList.IsEmpty() || !updatePaymentTermCustomDaysList.IsEmpty() || !updateIsActiveList.IsEmpty() || !updateAdvancePaymentTypeIdList.IsEmpty() || !updatePaymentDateList.IsEmpty() || !updatePaymentMethodsIdToDeleteList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderAccountingId",DbType.Int64,updateOrderAccountingIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAccountingDataTypeId",DbType.Int32,updateAccountingDataTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssNumberOfPayments",DbType.Int32,updateNumberOfPaymentsList);
executionService.CreateParameter(updateSqlCmd,"@ssAmount",DbType.Decimal,updateAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrencyId",DbType.String,updateCurrencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderAccConceptsId",DbType.Int64,updateOrderAccConceptsIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApplyForRequestProject",DbType.Boolean,updateApplyForRequestProjectList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentTermId",DbType.Int64,updatePaymentTermIdList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentTermCustomDays",DbType.Int32,updatePaymentTermCustomDaysList);
executionService.CreateParameter(updateSqlCmd,"@ssIsActive",DbType.Boolean,updateIsActiveList);
executionService.CreateParameter(updateSqlCmd,"@ssAdvancePaymentTypeId",DbType.Int32,updateAdvancePaymentTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentDate",DbType.DateTime,updatePaymentDateList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentMethodsIdToDelete",DbType.Int64,updatePaymentMethodsIdToDeleteList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderAccConcepts (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderAccConcepts
/// </summary>

public static async Task DeleteOrderAccConcepts(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderAccConcepts
/// </summary>

public static async Task DeleteAllOrderAccConcepts(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderAccConcepts
/// </summary>

public static async Task<RC_dc9a6819825fee88eba01192ae9b1890> GetOrderAccConcepts(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_dc9a6819825fee88eba01192ae9b1890 outParamRecord = default;
outParamRecord = new RC_dc9a6819825fee88eba01192ae9b1890();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENOrderAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(14,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderAccConceptsForUpdate
/// </summary>

public static async Task<RC_dc9a6819825fee88eba01192ae9b1890> GetOrderAccConceptsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_dc9a6819825fee88eba01192ae9b1890 outParamRecord = default;
outParamRecord = new RC_dc9a6819825fee88eba01192ae9b1890();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderAccConceptsForUpdate", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderAccConceptsForUpdate", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENOrderAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderAccConceptsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(14,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderAccConcepts
/// </summary>

public static async Task UpdateOrderAccConcepts(IRequestContext requestContext,BitArray usedFields,RC_dc9a6819825fee88eba01192ae9b1890 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderAccConcepts", "5b882f6b-c2ca-497f-b7f0-94f3ae4789a8.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(14,true);
}
string updateSet = "UPDATE " + ENOrderAccConceptsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid") + " = @ssOrderAccountingId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid") + " = @ssAccountingDataTypeId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments") + " = @ssNumberOfPayments"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount") + " = @ssAmount"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid") + " = @ssOrderAccConceptsId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + " = @ssApplyForRequestProject"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid") + " = @ssPaymentTermId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays") + " = @ssPaymentTermCustomDays"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive") + " = @ssIsActive"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid") + " = @ssAdvancePaymentTypeId"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + " = @ssPaymentDate"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete") + " = @ssPaymentMethodsIdToDelete"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderAccConcepts_ssId_OrderAccConcepts";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderAccConcepts.ssOrderAccountingId==0L)) {
sqlCmd.CreateParameter("@ssOrderAccountingId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderAccountingId", DbType.Int64, ssENOrderAccConcepts.ssOrderAccountingId);

}
}
if(usedFields[2]) {
if ((ssENOrderAccConcepts.ssAccountingDataTypeId==0)) {
sqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingDataTypeId", DbType.Int32, ssENOrderAccConcepts.ssAccountingDataTypeId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssNumberOfPayments", DbType.Int32, ssENOrderAccConcepts.ssNumberOfPayments);
}
if(usedFields[4]) {
var AmountParameter = sqlCmd.CreateParameter("@ssAmount", DbType.Decimal, ssENOrderAccConcepts.ssAmount);
{
    string decimalAsStr = ssENOrderAccConcepts.ssAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
if ((ssENOrderAccConcepts.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENOrderAccConcepts.ssCurrencyId);

}
}
if(usedFields[6]) {
if ((ssENOrderAccConcepts.ssOrderAccConceptsId==0L)) {
sqlCmd.CreateParameter("@ssOrderAccConceptsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderAccConceptsId", DbType.Int64, ssENOrderAccConcepts.ssOrderAccConceptsId);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssApplyForRequestProject", DbType.Boolean, ssENOrderAccConcepts.ssApplyForRequestProject);
}
if(usedFields[8]) {
if ((ssENOrderAccConcepts.ssPaymentTermId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermId", DbType.Int64, ssENOrderAccConcepts.ssPaymentTermId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssPaymentTermCustomDays", DbType.Int32, ssENOrderAccConcepts.ssPaymentTermCustomDays);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssIsActive", DbType.Boolean, ssENOrderAccConcepts.ssIsActive);
}
if(usedFields[11]) {
if ((ssENOrderAccConcepts.ssAdvancePaymentTypeId==0)) {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAdvancePaymentTypeId", DbType.Int32, ssENOrderAccConcepts.ssAdvancePaymentTypeId);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssPaymentDate", DbType.DateTime, ssENOrderAccConcepts.ssPaymentDate);
}
if(usedFields[13]) {
if ((ssENOrderAccConcepts.ssPaymentMethodsIdToDelete==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodsIdToDelete", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodsIdToDelete", DbType.Int64, ssENOrderAccConcepts.ssPaymentMethodsIdToDelete);

}
}
sqlCmd.CreateParameter("@idparam_ssENOrderAccConcepts_ssId_OrderAccConcepts", DbType.Int64, ssENOrderAccConcepts.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderAccConcepts", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderAccConcepts", ssENOrderAccConcepts.ssId.ToString()); }}
}
return;
}

}
}
