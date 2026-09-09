using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoice
/// </summary>

public static async Task<long> CreateInvoice(IRequestContext requestContext,RC_04c5986b32c7822f033c933cf71b96bd inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid") + "" +
" ) VALUES (" +
" @ssName" +
", @ssRequisitionId" +
", @ssFolioId" +
", @ssOrderMainId" +
", @ssCFDITypeId" +
", @ssTotalAmount" +
", @ssCurrency" +
", @ssInvoiceStatusId" +
", @ssAccountingDateTime" +
", @ssPaymentDateTime" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssUpdatedOn" +
", @ssUpdatedBy" +
", @ssSubmittedOn" +
", @ssIsNewVersion" +
", @ssID_POLIZA" +
", @ssID_POLIZA_SAP" +
", @ssDoc51" +
", @ssAccountingError" +
", @ssOrderAccConceptsID" +
", @ssAmortization" +
", @ssCreditNoteInvoiceId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENInvoice.ssName);
if ((ssENInvoice.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENInvoice.ssRequisitionId);

}
if ((ssENInvoice.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENInvoice.ssFolioId);

}
if ((ssENInvoice.ssOrderMainId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENInvoice.ssOrderMainId);

}
if ((ssENInvoice.ssCFDITypeId==0)) {
insertSqlCmd.CreateParameter("@ssCFDITypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCFDITypeId", DbType.Int32, ssENInvoice.ssCFDITypeId);

}
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoice.ssTotalAmount);
{
    string decimalAsStr = ssENInvoice.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoice.ssCurrency);
if ((ssENInvoice.ssInvoiceStatusId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, ssENInvoice.ssInvoiceStatusId);

}
insertSqlCmd.CreateParameter("@ssAccountingDateTime", DbType.DateTime, ssENInvoice.ssAccountingDateTime);
insertSqlCmd.CreateParameter("@ssPaymentDateTime", DbType.DateTime, ssENInvoice.ssPaymentDateTime);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoice.ssCreatedOn);
if ((ssENInvoice.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoice.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENInvoice.ssUpdatedOn);
if ((ssENInvoice.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENInvoice.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssSubmittedOn", DbType.DateTime, ssENInvoice.ssSubmittedOn);
insertSqlCmd.CreateParameter("@ssIsNewVersion", DbType.Boolean, ssENInvoice.ssIsNewVersion);
insertSqlCmd.CreateParameter("@ssID_POLIZA", DbType.String, ssENInvoice.ssID_POLIZA);
insertSqlCmd.CreateParameter("@ssID_POLIZA_SAP", DbType.String, ssENInvoice.ssID_POLIZA_SAP);
insertSqlCmd.CreateParameter("@ssDoc51", DbType.String, ssENInvoice.ssDoc51);
insertSqlCmd.CreateParameter("@ssAccountingError", DbType.String, ssENInvoice.ssAccountingError);
if ((ssENInvoice.ssOrderAccConceptsID==0L)) {
insertSqlCmd.CreateParameter("@ssOrderAccConceptsID", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderAccConceptsID", DbType.Int64, ssENInvoice.ssOrderAccConceptsID);

}
var AmortizationParameter = insertSqlCmd.CreateParameter("@ssAmortization", DbType.Decimal, ssENInvoice.ssAmortization);
{
    string decimalAsStr = ssENInvoice.ssAmortization.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmortizationParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENInvoice.ssCreditNoteInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssCreditNoteInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreditNoteInvoiceId", DbType.Int64, ssENInvoice.ssCreditNoteInvoiceId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoice", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoice
/// </summary>

public static async Task<long> CreateOrUpdateInvoice(IRequestContext requestContext,BitArray usedFields,RC_04c5986b32c7822f033c933cf71b96bd inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(24,true);
}
string updateSet = "UPDATE " + ENInvoiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name") + " = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + " = @ssOrderMainId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid") + " = @ssCFDITypeId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency") + " = @ssCurrency"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + " = @ssInvoiceStatusId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime") + " = @ssAccountingDateTime"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime") + " = @ssPaymentDateTime"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + " = @ssSubmittedOn"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + " = @ssIsNewVersion"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + " = @ssID_POLIZA"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap") + " = @ssID_POLIZA_SAP"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51") + " = @ssDoc51"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror") + " = @ssAccountingError"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid") + " = @ssOrderAccConceptsID"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization") + " = @ssAmortization"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid") + " = @ssCreditNoteInvoiceId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoice_ssId_Invoice";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENInvoice.ssName);
}
if(usedFields[2]) {
if ((ssENInvoice.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENInvoice.ssRequisitionId);

}
}
if(usedFields[3]) {
if ((ssENInvoice.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENInvoice.ssFolioId);

}
}
if(usedFields[4]) {
if ((ssENInvoice.ssOrderMainId==0L)) {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENInvoice.ssOrderMainId);

}
}
if(usedFields[5]) {
if ((ssENInvoice.ssCFDITypeId==0)) {
sqlCmd.CreateParameter("@ssCFDITypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCFDITypeId", DbType.Int32, ssENInvoice.ssCFDITypeId);

}
}
if(usedFields[6]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoice.ssTotalAmount);
{
    string decimalAsStr = ssENInvoice.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoice.ssCurrency);
}
if(usedFields[8]) {
if ((ssENInvoice.ssInvoiceStatusId==0)) {
sqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, ssENInvoice.ssInvoiceStatusId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssAccountingDateTime", DbType.DateTime, ssENInvoice.ssAccountingDateTime);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssPaymentDateTime", DbType.DateTime, ssENInvoice.ssPaymentDateTime);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoice.ssCreatedOn);
}
if(usedFields[12]) {
if ((ssENInvoice.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoice.ssCreatedBy);

}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENInvoice.ssUpdatedOn);
}
if(usedFields[14]) {
if ((ssENInvoice.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENInvoice.ssUpdatedBy);

}
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssSubmittedOn", DbType.DateTime, ssENInvoice.ssSubmittedOn);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssIsNewVersion", DbType.Boolean, ssENInvoice.ssIsNewVersion);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssID_POLIZA", DbType.String, ssENInvoice.ssID_POLIZA);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssID_POLIZA_SAP", DbType.String, ssENInvoice.ssID_POLIZA_SAP);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssDoc51", DbType.String, ssENInvoice.ssDoc51);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssAccountingError", DbType.String, ssENInvoice.ssAccountingError);
}
if(usedFields[21]) {
if ((ssENInvoice.ssOrderAccConceptsID==0L)) {
sqlCmd.CreateParameter("@ssOrderAccConceptsID", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderAccConceptsID", DbType.Int64, ssENInvoice.ssOrderAccConceptsID);

}
}
if(usedFields[22]) {
var AmortizationParameter = sqlCmd.CreateParameter("@ssAmortization", DbType.Decimal, ssENInvoice.ssAmortization);
{
    string decimalAsStr = ssENInvoice.ssAmortization.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmortizationParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[23]) {
if ((ssENInvoice.ssCreditNoteInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssCreditNoteInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreditNoteInvoiceId", DbType.Int64, ssENInvoice.ssCreditNoteInvoiceId);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoice_ssId_Invoice", DbType.Int64, ssENInvoice.ssId);
int counter = 0;
if(ssENInvoice.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoice (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid") + "" +
" ) VALUES (" +
" @ssName" +
", @ssRequisitionId" +
", @ssFolioId" +
", @ssOrderMainId" +
", @ssCFDITypeId" +
", @ssTotalAmount" +
", @ssCurrency" +
", @ssInvoiceStatusId" +
", @ssAccountingDateTime" +
", @ssPaymentDateTime" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssUpdatedOn" +
", @ssUpdatedBy" +
", @ssSubmittedOn" +
", @ssIsNewVersion" +
", @ssID_POLIZA" +
", @ssID_POLIZA_SAP" +
", @ssDoc51" +
", @ssAccountingError" +
", @ssOrderAccConceptsID" +
", @ssAmortization" +
", @ssCreditNoteInvoiceId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENInvoice.ssName);
if ((ssENInvoice.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENInvoice.ssRequisitionId);

}
if ((ssENInvoice.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENInvoice.ssFolioId);

}
if ((ssENInvoice.ssOrderMainId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENInvoice.ssOrderMainId);

}
if ((ssENInvoice.ssCFDITypeId==0)) {
insertSqlCmd.CreateParameter("@ssCFDITypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCFDITypeId", DbType.Int32, ssENInvoice.ssCFDITypeId);

}
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoice.ssTotalAmount);
{
    string decimalAsStr = ssENInvoice.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoice.ssCurrency);
if ((ssENInvoice.ssInvoiceStatusId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, ssENInvoice.ssInvoiceStatusId);

}
insertSqlCmd.CreateParameter("@ssAccountingDateTime", DbType.DateTime, ssENInvoice.ssAccountingDateTime);
insertSqlCmd.CreateParameter("@ssPaymentDateTime", DbType.DateTime, ssENInvoice.ssPaymentDateTime);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoice.ssCreatedOn);
if ((ssENInvoice.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoice.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENInvoice.ssUpdatedOn);
if ((ssENInvoice.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENInvoice.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssSubmittedOn", DbType.DateTime, ssENInvoice.ssSubmittedOn);
insertSqlCmd.CreateParameter("@ssIsNewVersion", DbType.Boolean, ssENInvoice.ssIsNewVersion);
insertSqlCmd.CreateParameter("@ssID_POLIZA", DbType.String, ssENInvoice.ssID_POLIZA);
insertSqlCmd.CreateParameter("@ssID_POLIZA_SAP", DbType.String, ssENInvoice.ssID_POLIZA_SAP);
insertSqlCmd.CreateParameter("@ssDoc51", DbType.String, ssENInvoice.ssDoc51);
insertSqlCmd.CreateParameter("@ssAccountingError", DbType.String, ssENInvoice.ssAccountingError);
if ((ssENInvoice.ssOrderAccConceptsID==0L)) {
insertSqlCmd.CreateParameter("@ssOrderAccConceptsID", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderAccConceptsID", DbType.Int64, ssENInvoice.ssOrderAccConceptsID);

}
var AmortizationParameter = insertSqlCmd.CreateParameter("@ssAmortization", DbType.Decimal, ssENInvoice.ssAmortization);
{
    string decimalAsStr = ssENInvoice.ssAmortization.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmortizationParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENInvoice.ssCreditNoteInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssCreditNoteInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreditNoteInvoiceId", DbType.Int64, ssENInvoice.ssCreditNoteInvoiceId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoice", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoice.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoice
/// </summary>

public static async Task CreateOrUpdateSomeInvoice(IRequestContext requestContext,RL_7b3475883ca90ad6eb7fc983e868c456 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid") + ") VALUES ( unnest(@ssName),  unnest(@ssRequisitionId),  unnest(@ssFolioId),  unnest(@ssOrderMainId),  unnest(@ssCFDITypeId),  unnest(@ssTotalAmount),  unnest(@ssCurrency),  unnest(@ssInvoiceStatusId),  unnest(@ssAccountingDateTime),  unnest(@ssPaymentDateTime),  unnest(@ssCreatedOn),  unnest(@ssCreatedBy),  unnest(@ssUpdatedOn),  unnest(@ssUpdatedBy),  unnest(@ssSubmittedOn),  unnest(@ssIsNewVersion),  unnest(@ssID_POLIZA),  unnest(@ssID_POLIZA_SAP),  unnest(@ssDoc51),  unnest(@ssAccountingError),  unnest(@ssOrderAccConceptsID),  unnest(@ssAmortization),  unnest(@ssCreditNoteInvoiceId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssName) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name") + ",  unnest(@ssRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ",  unnest(@ssFolioId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid") + ",  unnest(@ssOrderMainId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + ",  unnest(@ssCFDITypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid") + ",  unnest(@ssTotalAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ",  unnest(@ssCurrency) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency") + ",  unnest(@ssInvoiceStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + ",  unnest(@ssAccountingDateTime) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime") + ",  unnest(@ssPaymentDateTime) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssUpdatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ",  unnest(@ssUpdatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ",  unnest(@ssSubmittedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + ",  unnest(@ssIsNewVersion) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + ",  unnest(@ssID_POLIZA) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + ",  unnest(@ssID_POLIZA_SAP) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap") + ",  unnest(@ssDoc51) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51") + ",  unnest(@ssAccountingError) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror") + ",  unnest(@ssOrderAccConceptsID) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid") + ",  unnest(@ssAmortization) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization") + ",  unnest(@ssCreditNoteInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<string> insertNameList = new List<string>();
List<object> insertRequisitionIdList = new List<object>();
List<object> insertFolioIdList = new List<object>();
List<object> insertOrderMainIdList = new List<object>();
List<object> insertCFDITypeIdList = new List<object>();
List<decimal> insertTotalAmountList = new List<decimal>();
List<string> insertCurrencyList = new List<string>();
List<object> insertInvoiceStatusIdList = new List<object>();
List<DateTime> insertAccountingDateTimeList = new List<DateTime>();
List<DateTime> insertPaymentDateTimeList = new List<DateTime>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertUpdatedOnList = new List<DateTime>();
List<object> insertUpdatedByList = new List<object>();
List<DateTime> insertSubmittedOnList = new List<DateTime>();
List<bool> insertIsNewVersionList = new List<bool>();
List<string> insertID_POLIZAList = new List<string>();
List<string> insertID_POLIZA_SAPList = new List<string>();
List<string> insertDoc51List = new List<string>();
List<string> insertAccountingErrorList = new List<string>();
List<object> insertOrderAccConceptsIDList = new List<object>();
List<decimal> insertAmortizationList = new List<decimal>();
List<object> insertCreditNoteInvoiceIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<string> updateNameList = new List<string>();
List<object> updateRequisitionIdList = new List<object>();
List<object> updateFolioIdList = new List<object>();
List<object> updateOrderMainIdList = new List<object>();
List<object> updateCFDITypeIdList = new List<object>();
List<decimal> updateTotalAmountList = new List<decimal>();
List<string> updateCurrencyList = new List<string>();
List<object> updateInvoiceStatusIdList = new List<object>();
List<DateTime> updateAccountingDateTimeList = new List<DateTime>();
List<DateTime> updatePaymentDateTimeList = new List<DateTime>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateUpdatedOnList = new List<DateTime>();
List<object> updateUpdatedByList = new List<object>();
List<DateTime> updateSubmittedOnList = new List<DateTime>();
List<bool> updateIsNewVersionList = new List<bool>();
List<string> updateID_POLIZAList = new List<string>();
List<string> updateID_POLIZA_SAPList = new List<string>();
List<string> updateDoc51List = new List<string>();
List<string> updateAccountingErrorList = new List<string>();
List<object> updateOrderAccConceptsIDList = new List<object>();
List<decimal> updateAmortizationList = new List<decimal>();
List<object> updateCreditNoteInvoiceIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_04c5986b32c7822f033c933cf71b96bd)inParamSourceList.Current).ssENInvoice;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
if ((record.ssRequisitionId==0L)) {
updateRequisitionIdList.Add(null);
} else {
updateRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssFolioId==0L)) {
updateFolioIdList.Add(null);
} else {
updateFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
if ((record.ssOrderMainId==0L)) {
updateOrderMainIdList.Add(null);
} else {
updateOrderMainIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainId));
}
if ((record.ssCFDITypeId==0)) {
updateCFDITypeIdList.Add(null);
} else {
updateCFDITypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCFDITypeId));
}
updateTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
updateCurrencyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrency));
if ((record.ssInvoiceStatusId==0)) {
updateInvoiceStatusIdList.Add(null);
} else {
updateInvoiceStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInvoiceStatusId));
}
updateAccountingDateTimeList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssAccountingDateTime));
updatePaymentDateTimeList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssPaymentDateTime));
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
if ((record.ssUpdatedBy=="")) {
updateUpdatedByList.Add(null);
} else {
updateUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
updateSubmittedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssSubmittedOn));
updateIsNewVersionList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsNewVersion));
updateID_POLIZAList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssID_POLIZA));
updateID_POLIZA_SAPList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssID_POLIZA_SAP));
updateDoc51List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDoc51));
updateAccountingErrorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAccountingError));
if ((record.ssOrderAccConceptsID==0L)) {
updateOrderAccConceptsIDList.Add(null);
} else {
updateOrderAccConceptsIDList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderAccConceptsID));
}
updateAmortizationList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmortization));
if ((record.ssCreditNoteInvoiceId==0L)) {
updateCreditNoteInvoiceIdList.Add(null);
} else {
updateCreditNoteInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCreditNoteInvoiceId));
}
} else {
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
if ((record.ssRequisitionId==0L)) {
insertRequisitionIdList.Add(null);
} else {
insertRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssFolioId==0L)) {
insertFolioIdList.Add(null);
} else {
insertFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
if ((record.ssOrderMainId==0L)) {
insertOrderMainIdList.Add(null);
} else {
insertOrderMainIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainId));
}
if ((record.ssCFDITypeId==0)) {
insertCFDITypeIdList.Add(null);
} else {
insertCFDITypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCFDITypeId));
}
insertTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
insertCurrencyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrency));
if ((record.ssInvoiceStatusId==0)) {
insertInvoiceStatusIdList.Add(null);
} else {
insertInvoiceStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInvoiceStatusId));
}
insertAccountingDateTimeList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssAccountingDateTime));
insertPaymentDateTimeList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssPaymentDateTime));
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
if ((record.ssUpdatedBy=="")) {
insertUpdatedByList.Add(null);
} else {
insertUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
insertSubmittedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssSubmittedOn));
insertIsNewVersionList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsNewVersion));
insertID_POLIZAList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssID_POLIZA));
insertID_POLIZA_SAPList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssID_POLIZA_SAP));
insertDoc51List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDoc51));
insertAccountingErrorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAccountingError));
if ((record.ssOrderAccConceptsID==0L)) {
insertOrderAccConceptsIDList.Add(null);
} else {
insertOrderAccConceptsIDList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderAccConceptsID));
}
insertAmortizationList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmortization));
if ((record.ssCreditNoteInvoiceId==0L)) {
insertCreditNoteInvoiceIdList.Add(null);
} else {
insertCreditNoteInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCreditNoteInvoiceId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertNameList.IsEmpty() || !insertRequisitionIdList.IsEmpty() || !insertFolioIdList.IsEmpty() || !insertOrderMainIdList.IsEmpty() || !insertCFDITypeIdList.IsEmpty() || !insertTotalAmountList.IsEmpty() || !insertCurrencyList.IsEmpty() || !insertInvoiceStatusIdList.IsEmpty() || !insertAccountingDateTimeList.IsEmpty() || !insertPaymentDateTimeList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertUpdatedOnList.IsEmpty() || !insertUpdatedByList.IsEmpty() || !insertSubmittedOnList.IsEmpty() || !insertIsNewVersionList.IsEmpty() || !insertID_POLIZAList.IsEmpty() || !insertID_POLIZA_SAPList.IsEmpty() || !insertDoc51List.IsEmpty() || !insertAccountingErrorList.IsEmpty() || !insertOrderAccConceptsIDList.IsEmpty() || !insertAmortizationList.IsEmpty() || !insertCreditNoteInvoiceIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionId",DbType.Int64,insertRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFolioId",DbType.Int64,insertFolioIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderMainId",DbType.Int64,insertOrderMainIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCFDITypeId",DbType.Int32,insertCFDITypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalAmount",DbType.Decimal,insertTotalAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrency",DbType.String,insertCurrencyList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceStatusId",DbType.Int32,insertInvoiceStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAccountingDateTime",DbType.DateTime,insertAccountingDateTimeList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentDateTime",DbType.DateTime,insertPaymentDateTimeList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedOn",DbType.DateTime,insertUpdatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedBy",DbType.String,insertUpdatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssSubmittedOn",DbType.DateTime,insertSubmittedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssIsNewVersion",DbType.Boolean,insertIsNewVersionList);
executionService.CreateParameter(insertSqlCmd,"@ssID_POLIZA",DbType.String,insertID_POLIZAList);
executionService.CreateParameter(insertSqlCmd,"@ssID_POLIZA_SAP",DbType.String,insertID_POLIZA_SAPList);
executionService.CreateParameter(insertSqlCmd,"@ssDoc51",DbType.String,insertDoc51List);
executionService.CreateParameter(insertSqlCmd,"@ssAccountingError",DbType.String,insertAccountingErrorList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderAccConceptsID",DbType.Int64,insertOrderAccConceptsIDList);
executionService.CreateParameter(insertSqlCmd,"@ssAmortization",DbType.Decimal,insertAmortizationList);
executionService.CreateParameter(insertSqlCmd,"@ssCreditNoteInvoiceId",DbType.Int64,insertCreditNoteInvoiceIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoice (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateNameList.IsEmpty() || !updateRequisitionIdList.IsEmpty() || !updateFolioIdList.IsEmpty() || !updateOrderMainIdList.IsEmpty() || !updateCFDITypeIdList.IsEmpty() || !updateTotalAmountList.IsEmpty() || !updateCurrencyList.IsEmpty() || !updateInvoiceStatusIdList.IsEmpty() || !updateAccountingDateTimeList.IsEmpty() || !updatePaymentDateTimeList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateUpdatedOnList.IsEmpty() || !updateUpdatedByList.IsEmpty() || !updateSubmittedOnList.IsEmpty() || !updateIsNewVersionList.IsEmpty() || !updateID_POLIZAList.IsEmpty() || !updateID_POLIZA_SAPList.IsEmpty() || !updateDoc51List.IsEmpty() || !updateAccountingErrorList.IsEmpty() || !updateOrderAccConceptsIDList.IsEmpty() || !updateAmortizationList.IsEmpty() || !updateCreditNoteInvoiceIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssName",DbType.String,updateNameList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionId",DbType.Int64,updateRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioId",DbType.Int64,updateFolioIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderMainId",DbType.Int64,updateOrderMainIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCFDITypeId",DbType.Int32,updateCFDITypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalAmount",DbType.Decimal,updateTotalAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrency",DbType.String,updateCurrencyList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceStatusId",DbType.Int32,updateInvoiceStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAccountingDateTime",DbType.DateTime,updateAccountingDateTimeList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentDateTime",DbType.DateTime,updatePaymentDateTimeList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedOn",DbType.DateTime,updateUpdatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedBy",DbType.String,updateUpdatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssSubmittedOn",DbType.DateTime,updateSubmittedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssIsNewVersion",DbType.Boolean,updateIsNewVersionList);
executionService.CreateParameter(updateSqlCmd,"@ssID_POLIZA",DbType.String,updateID_POLIZAList);
executionService.CreateParameter(updateSqlCmd,"@ssID_POLIZA_SAP",DbType.String,updateID_POLIZA_SAPList);
executionService.CreateParameter(updateSqlCmd,"@ssDoc51",DbType.String,updateDoc51List);
executionService.CreateParameter(updateSqlCmd,"@ssAccountingError",DbType.String,updateAccountingErrorList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderAccConceptsID",DbType.Int64,updateOrderAccConceptsIDList);
executionService.CreateParameter(updateSqlCmd,"@ssAmortization",DbType.Decimal,updateAmortizationList);
executionService.CreateParameter(updateSqlCmd,"@ssCreditNoteInvoiceId",DbType.Int64,updateCreditNoteInvoiceIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoice (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoice
/// </summary>

public static async Task DeleteInvoice(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoice", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoice
/// </summary>

public static async Task DeleteAllInvoice(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoice", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoice
/// </summary>

public static async Task<RC_04c5986b32c7822f033c933cf71b96bd> GetInvoice(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_04c5986b32c7822f033c933cf71b96bd outParamRecord = default;
outParamRecord = new RC_04c5986b32c7822f033c933cf71b96bd();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENInvoiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoice", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(24,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceForUpdate
/// </summary>

public static async Task<RC_04c5986b32c7822f033c933cf71b96bd> GetInvoiceForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_04c5986b32c7822f033c933cf71b96bd outParamRecord = default;
outParamRecord = new RC_04c5986b32c7822f033c933cf71b96bd();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceForUpdate", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceForUpdate", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENInvoiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(24,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoice
/// </summary>

public static async Task UpdateInvoice(IRequestContext requestContext,BitArray usedFields,RC_04c5986b32c7822f033c933cf71b96bd inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoice", "15df4c25-ab2d-4bba-b417-d544d255a1ff.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(24,true);
}
string updateSet = "UPDATE " + ENInvoiceEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Name, "name") ?? "name") + " = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + " = @ssOrderMainId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CFDITypeId, "cfditypeid") ?? "cfditypeid") + " = @ssCFDITypeId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Currency, "currency") ?? "currency") + " = @ssCurrency"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@InvoiceStatusId, "invoicestatusid") ?? "invoicestatusid") + " = @ssInvoiceStatusId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingDateTime, "accountingdatetime") ?? "accountingdatetime") + " = @ssAccountingDateTime"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@PaymentDateTime, "paymentdatetime") ?? "paymentdatetime") + " = @ssPaymentDateTime"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + " = @ssSubmittedOn"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + " = @ssIsNewVersion"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA, "id_poliza") ?? "id_poliza") + " = @ssID_POLIZA"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@ID_POLIZA_SAP, "id_poliza_sap") ?? "id_poliza_sap") + " = @ssID_POLIZA_SAP"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Doc51, "doc51") ?? "doc51") + " = @ssDoc51"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@AccountingError, "accountingerror") ?? "accountingerror") + " = @ssAccountingError"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@OrderAccConceptsID, "orderaccconceptsid") ?? "orderaccconceptsid") + " = @ssOrderAccConceptsID"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Amortization, "amortization") ?? "amortization") + " = @ssAmortization"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@CreditNoteInvoiceId, "creditnoteinvoiceid") ?? "creditnoteinvoiceid") + " = @ssCreditNoteInvoiceId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoice_ssId_Invoice";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Invoice, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAttributeKeys.@IsNewVersion, "isnewversion") ?? "isnewversion") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENInvoice.ssName);
}
if(usedFields[2]) {
if ((ssENInvoice.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENInvoice.ssRequisitionId);

}
}
if(usedFields[3]) {
if ((ssENInvoice.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENInvoice.ssFolioId);

}
}
if(usedFields[4]) {
if ((ssENInvoice.ssOrderMainId==0L)) {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENInvoice.ssOrderMainId);

}
}
if(usedFields[5]) {
if ((ssENInvoice.ssCFDITypeId==0)) {
sqlCmd.CreateParameter("@ssCFDITypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCFDITypeId", DbType.Int32, ssENInvoice.ssCFDITypeId);

}
}
if(usedFields[6]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoice.ssTotalAmount);
{
    string decimalAsStr = ssENInvoice.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoice.ssCurrency);
}
if(usedFields[8]) {
if ((ssENInvoice.ssInvoiceStatusId==0)) {
sqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceStatusId", DbType.Int32, ssENInvoice.ssInvoiceStatusId);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssAccountingDateTime", DbType.DateTime, ssENInvoice.ssAccountingDateTime);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssPaymentDateTime", DbType.DateTime, ssENInvoice.ssPaymentDateTime);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoice.ssCreatedOn);
}
if(usedFields[12]) {
if ((ssENInvoice.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoice.ssCreatedBy);

}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENInvoice.ssUpdatedOn);
}
if(usedFields[14]) {
if ((ssENInvoice.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENInvoice.ssUpdatedBy);

}
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssSubmittedOn", DbType.DateTime, ssENInvoice.ssSubmittedOn);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssIsNewVersion", DbType.Boolean, ssENInvoice.ssIsNewVersion);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssID_POLIZA", DbType.String, ssENInvoice.ssID_POLIZA);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssID_POLIZA_SAP", DbType.String, ssENInvoice.ssID_POLIZA_SAP);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssDoc51", DbType.String, ssENInvoice.ssDoc51);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssAccountingError", DbType.String, ssENInvoice.ssAccountingError);
}
if(usedFields[21]) {
if ((ssENInvoice.ssOrderAccConceptsID==0L)) {
sqlCmd.CreateParameter("@ssOrderAccConceptsID", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderAccConceptsID", DbType.Int64, ssENInvoice.ssOrderAccConceptsID);

}
}
if(usedFields[22]) {
var AmortizationParameter = sqlCmd.CreateParameter("@ssAmortization", DbType.Decimal, ssENInvoice.ssAmortization);
{
    string decimalAsStr = ssENInvoice.ssAmortization.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AmortizationParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[23]) {
if ((ssENInvoice.ssCreditNoteInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssCreditNoteInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreditNoteInvoiceId", DbType.Int64, ssENInvoice.ssCreditNoteInvoiceId);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoice_ssId_Invoice", DbType.Int64, ssENInvoice.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoice", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Invoice", ssENInvoice.ssId.ToString()); }}
}
return;
}

}
}
