using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProposal
/// </summary>

public static async Task<long> CreateProposal(IRequestContext requestContext,RC_91adc4f46f8a0f51cacc4bc718d2ea35 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProposalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid") + "" +
" ) VALUES (" +
" @ssName" +
", @ssPaymentDate" +
", @ssProposalDate" +
", @ssProposalTypeId" +
", @ssBankId" +
", @ssProposalStatusId" +
", @ssFileId" +
", @ssTotalProposalLines" +
", @ssTotalValueML" +
", @ssTotalValueMD" +
", @ssCurrencyId" +
", @ssRegionId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssLastUpdatedOn" +
", @ssMaxDatePaymentChanges" +
", @ssAssignedToId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProposal.ssName);
insertSqlCmd.CreateParameter("@ssPaymentDate", DbType.DateTime, ssENProposal.ssPaymentDate);
insertSqlCmd.CreateParameter("@ssProposalDate", DbType.DateTime, ssENProposal.ssProposalDate);
if ((ssENProposal.ssProposalTypeId==0)) {
insertSqlCmd.CreateParameter("@ssProposalTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalTypeId", DbType.Int32, ssENProposal.ssProposalTypeId);

}
if ((ssENProposal.ssBankId==0L)) {
insertSqlCmd.CreateParameter("@ssBankId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBankId", DbType.Int64, ssENProposal.ssBankId);

}
if ((ssENProposal.ssProposalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, ssENProposal.ssProposalStatusId);

}
if ((ssENProposal.ssFileId==0L)) {
insertSqlCmd.CreateParameter("@ssFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFileId", DbType.Int64, ssENProposal.ssFileId);

}
insertSqlCmd.CreateParameter("@ssTotalProposalLines", DbType.Int32, ssENProposal.ssTotalProposalLines);
var TotalValueMLParameter = insertSqlCmd.CreateParameter("@ssTotalValueML", DbType.Decimal, ssENProposal.ssTotalValueML);
{
    string decimalAsStr = ssENProposal.ssTotalValueML.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalValueMLParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalValueMDParameter = insertSqlCmd.CreateParameter("@ssTotalValueMD", DbType.Decimal, ssENProposal.ssTotalValueMD);
{
    string decimalAsStr = ssENProposal.ssTotalValueMD.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalValueMDParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENProposal.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENProposal.ssCurrencyId);

}
if ((ssENProposal.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENProposal.ssRegionId);

}
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposal.ssCreatedBy);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENProposal.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssLastUpdatedOn", DbType.DateTime, ssENProposal.ssLastUpdatedOn);
insertSqlCmd.CreateParameter("@ssMaxDatePaymentChanges", DbType.DateTime, ssENProposal.ssMaxDatePaymentChanges);
if ((ssENProposal.ssAssignedToId=="")) {
insertSqlCmd.CreateParameter("@ssAssignedToId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedToId", DbType.String, ssENProposal.ssAssignedToId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProposal", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProposal
/// </summary>

public static async Task<long> CreateOrUpdateProposal(IRequestContext requestContext,BitArray usedFields,RC_91adc4f46f8a0f51cacc4bc718d2ea35 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(18,true);
}
string updateSet = "UPDATE " + ENProposalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name") + " = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + " = @ssPaymentDate"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate") + " = @ssProposalDate"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid") + " = @ssProposalTypeId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid") + " = @ssBankId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + " = @ssProposalStatusId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid") + " = @ssFileId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + " = @ssTotalProposalLines"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml") + " = @ssTotalValueML"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd") + " = @ssTotalValueMD"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon") + " = @ssLastUpdatedOn"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges") + " = @ssMaxDatePaymentChanges"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid") + " = @ssAssignedToId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposal_ssId_Proposal";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProposal.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssPaymentDate", DbType.DateTime, ssENProposal.ssPaymentDate);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProposalDate", DbType.DateTime, ssENProposal.ssProposalDate);
}
if(usedFields[4]) {
if ((ssENProposal.ssProposalTypeId==0)) {
sqlCmd.CreateParameter("@ssProposalTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalTypeId", DbType.Int32, ssENProposal.ssProposalTypeId);

}
}
if(usedFields[5]) {
if ((ssENProposal.ssBankId==0L)) {
sqlCmd.CreateParameter("@ssBankId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBankId", DbType.Int64, ssENProposal.ssBankId);

}
}
if(usedFields[6]) {
if ((ssENProposal.ssProposalStatusId==0)) {
sqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, ssENProposal.ssProposalStatusId);

}
}
if(usedFields[7]) {
if ((ssENProposal.ssFileId==0L)) {
sqlCmd.CreateParameter("@ssFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFileId", DbType.Int64, ssENProposal.ssFileId);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssTotalProposalLines", DbType.Int32, ssENProposal.ssTotalProposalLines);
}
if(usedFields[9]) {
var TotalValueMLParameter = sqlCmd.CreateParameter("@ssTotalValueML", DbType.Decimal, ssENProposal.ssTotalValueML);
{
    string decimalAsStr = ssENProposal.ssTotalValueML.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalValueMLParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
var TotalValueMDParameter = sqlCmd.CreateParameter("@ssTotalValueMD", DbType.Decimal, ssENProposal.ssTotalValueMD);
{
    string decimalAsStr = ssENProposal.ssTotalValueMD.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalValueMDParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
if ((ssENProposal.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENProposal.ssCurrencyId);

}
}
if(usedFields[12]) {
if ((ssENProposal.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENProposal.ssRegionId);

}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposal.ssCreatedBy);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENProposal.ssCreatedOn);
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssLastUpdatedOn", DbType.DateTime, ssENProposal.ssLastUpdatedOn);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssMaxDatePaymentChanges", DbType.DateTime, ssENProposal.ssMaxDatePaymentChanges);
}
if(usedFields[17]) {
if ((ssENProposal.ssAssignedToId=="")) {
sqlCmd.CreateParameter("@ssAssignedToId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedToId", DbType.String, ssENProposal.ssAssignedToId);

}
}
sqlCmd.CreateParameter("@idparam_ssENProposal_ssId_Proposal", DbType.Int64, ssENProposal.ssId);
int counter = 0;
if(ssENProposal.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposal (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProposalEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid") + "" +
" ) VALUES (" +
" @ssName" +
", @ssPaymentDate" +
", @ssProposalDate" +
", @ssProposalTypeId" +
", @ssBankId" +
", @ssProposalStatusId" +
", @ssFileId" +
", @ssTotalProposalLines" +
", @ssTotalValueML" +
", @ssTotalValueMD" +
", @ssCurrencyId" +
", @ssRegionId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssLastUpdatedOn" +
", @ssMaxDatePaymentChanges" +
", @ssAssignedToId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENProposal.ssName);
insertSqlCmd.CreateParameter("@ssPaymentDate", DbType.DateTime, ssENProposal.ssPaymentDate);
insertSqlCmd.CreateParameter("@ssProposalDate", DbType.DateTime, ssENProposal.ssProposalDate);
if ((ssENProposal.ssProposalTypeId==0)) {
insertSqlCmd.CreateParameter("@ssProposalTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalTypeId", DbType.Int32, ssENProposal.ssProposalTypeId);

}
if ((ssENProposal.ssBankId==0L)) {
insertSqlCmd.CreateParameter("@ssBankId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBankId", DbType.Int64, ssENProposal.ssBankId);

}
if ((ssENProposal.ssProposalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, ssENProposal.ssProposalStatusId);

}
if ((ssENProposal.ssFileId==0L)) {
insertSqlCmd.CreateParameter("@ssFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFileId", DbType.Int64, ssENProposal.ssFileId);

}
insertSqlCmd.CreateParameter("@ssTotalProposalLines", DbType.Int32, ssENProposal.ssTotalProposalLines);
var TotalValueMLParameter = insertSqlCmd.CreateParameter("@ssTotalValueML", DbType.Decimal, ssENProposal.ssTotalValueML);
{
    string decimalAsStr = ssENProposal.ssTotalValueML.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalValueMLParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalValueMDParameter = insertSqlCmd.CreateParameter("@ssTotalValueMD", DbType.Decimal, ssENProposal.ssTotalValueMD);
{
    string decimalAsStr = ssENProposal.ssTotalValueMD.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalValueMDParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENProposal.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENProposal.ssCurrencyId);

}
if ((ssENProposal.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENProposal.ssRegionId);

}
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposal.ssCreatedBy);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENProposal.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssLastUpdatedOn", DbType.DateTime, ssENProposal.ssLastUpdatedOn);
insertSqlCmd.CreateParameter("@ssMaxDatePaymentChanges", DbType.DateTime, ssENProposal.ssMaxDatePaymentChanges);
if ((ssENProposal.ssAssignedToId=="")) {
insertSqlCmd.CreateParameter("@ssAssignedToId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAssignedToId", DbType.String, ssENProposal.ssAssignedToId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposal", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProposal.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProposal
/// </summary>

public static async Task CreateOrUpdateSomeProposal(IRequestContext requestContext,RL_88245586d5ac2ebd4048f53abef0c31b inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENProposalEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid") + ") VALUES ( unnest(@ssName),  unnest(@ssPaymentDate),  unnest(@ssProposalDate),  unnest(@ssProposalTypeId),  unnest(@ssBankId),  unnest(@ssProposalStatusId),  unnest(@ssFileId),  unnest(@ssTotalProposalLines),  unnest(@ssTotalValueML),  unnest(@ssTotalValueMD),  unnest(@ssCurrencyId),  unnest(@ssRegionId),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssLastUpdatedOn),  unnest(@ssMaxDatePaymentChanges),  unnest(@ssAssignedToId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssName) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name") + ",  unnest(@ssPaymentDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + ",  unnest(@ssProposalDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate") + ",  unnest(@ssProposalTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid") + ",  unnest(@ssBankId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid") + ",  unnest(@ssProposalStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + ",  unnest(@ssFileId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid") + ",  unnest(@ssTotalProposalLines) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + ",  unnest(@ssTotalValueML) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml") + ",  unnest(@ssTotalValueMD) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd") + ",  unnest(@ssCurrencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ",  unnest(@ssRegionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssLastUpdatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon") + ",  unnest(@ssMaxDatePaymentChanges) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges") + ",  unnest(@ssAssignedToId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<string> insertNameList = new List<string>();
List<DateTime> insertPaymentDateList = new List<DateTime>();
List<DateTime> insertProposalDateList = new List<DateTime>();
List<object> insertProposalTypeIdList = new List<object>();
List<object> insertBankIdList = new List<object>();
List<object> insertProposalStatusIdList = new List<object>();
List<object> insertFileIdList = new List<object>();
List<int> insertTotalProposalLinesList = new List<int>();
List<decimal> insertTotalValueMLList = new List<decimal>();
List<decimal> insertTotalValueMDList = new List<decimal>();
List<object> insertCurrencyIdList = new List<object>();
List<object> insertRegionIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<DateTime> insertLastUpdatedOnList = new List<DateTime>();
List<DateTime> insertMaxDatePaymentChangesList = new List<DateTime>();
List<object> insertAssignedToIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<string> updateNameList = new List<string>();
List<DateTime> updatePaymentDateList = new List<DateTime>();
List<DateTime> updateProposalDateList = new List<DateTime>();
List<object> updateProposalTypeIdList = new List<object>();
List<object> updateBankIdList = new List<object>();
List<object> updateProposalStatusIdList = new List<object>();
List<object> updateFileIdList = new List<object>();
List<int> updateTotalProposalLinesList = new List<int>();
List<decimal> updateTotalValueMLList = new List<decimal>();
List<decimal> updateTotalValueMDList = new List<decimal>();
List<object> updateCurrencyIdList = new List<object>();
List<object> updateRegionIdList = new List<object>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<DateTime> updateLastUpdatedOnList = new List<DateTime>();
List<DateTime> updateMaxDatePaymentChangesList = new List<DateTime>();
List<object> updateAssignedToIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_91adc4f46f8a0f51cacc4bc718d2ea35)inParamSourceList.Current).ssENProposal;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
updatePaymentDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssPaymentDate));
updateProposalDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssProposalDate));
if ((record.ssProposalTypeId==0)) {
updateProposalTypeIdList.Add(null);
} else {
updateProposalTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProposalTypeId));
}
if ((record.ssBankId==0L)) {
updateBankIdList.Add(null);
} else {
updateBankIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssBankId));
}
if ((record.ssProposalStatusId==0)) {
updateProposalStatusIdList.Add(null);
} else {
updateProposalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProposalStatusId));
}
if ((record.ssFileId==0L)) {
updateFileIdList.Add(null);
} else {
updateFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFileId));
}
updateTotalProposalLinesList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssTotalProposalLines));
updateTotalValueMLList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalValueML));
updateTotalValueMDList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalValueMD));
if ((record.ssCurrencyId=="")) {
updateCurrencyIdList.Add(null);
} else {
updateCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssRegionId==0L)) {
updateRegionIdList.Add(null);
} else {
updateRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
updateLastUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssLastUpdatedOn));
updateMaxDatePaymentChangesList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssMaxDatePaymentChanges));
if ((record.ssAssignedToId=="")) {
updateAssignedToIdList.Add(null);
} else {
updateAssignedToIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedToId));
}
} else {
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertPaymentDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssPaymentDate));
insertProposalDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssProposalDate));
if ((record.ssProposalTypeId==0)) {
insertProposalTypeIdList.Add(null);
} else {
insertProposalTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProposalTypeId));
}
if ((record.ssBankId==0L)) {
insertBankIdList.Add(null);
} else {
insertBankIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssBankId));
}
if ((record.ssProposalStatusId==0)) {
insertProposalStatusIdList.Add(null);
} else {
insertProposalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProposalStatusId));
}
if ((record.ssFileId==0L)) {
insertFileIdList.Add(null);
} else {
insertFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFileId));
}
insertTotalProposalLinesList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssTotalProposalLines));
insertTotalValueMLList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalValueML));
insertTotalValueMDList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalValueMD));
if ((record.ssCurrencyId=="")) {
insertCurrencyIdList.Add(null);
} else {
insertCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssRegionId==0L)) {
insertRegionIdList.Add(null);
} else {
insertRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
insertLastUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssLastUpdatedOn));
insertMaxDatePaymentChangesList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssMaxDatePaymentChanges));
if ((record.ssAssignedToId=="")) {
insertAssignedToIdList.Add(null);
} else {
insertAssignedToIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssignedToId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertNameList.IsEmpty() || !insertPaymentDateList.IsEmpty() || !insertProposalDateList.IsEmpty() || !insertProposalTypeIdList.IsEmpty() || !insertBankIdList.IsEmpty() || !insertProposalStatusIdList.IsEmpty() || !insertFileIdList.IsEmpty() || !insertTotalProposalLinesList.IsEmpty() || !insertTotalValueMLList.IsEmpty() || !insertTotalValueMDList.IsEmpty() || !insertCurrencyIdList.IsEmpty() || !insertRegionIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertLastUpdatedOnList.IsEmpty() || !insertMaxDatePaymentChangesList.IsEmpty() || !insertAssignedToIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentDate",DbType.DateTime,insertPaymentDateList);
executionService.CreateParameter(insertSqlCmd,"@ssProposalDate",DbType.DateTime,insertProposalDateList);
executionService.CreateParameter(insertSqlCmd,"@ssProposalTypeId",DbType.Int32,insertProposalTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssBankId",DbType.Int64,insertBankIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProposalStatusId",DbType.Int32,insertProposalStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFileId",DbType.Int64,insertFileIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalProposalLines",DbType.Int32,insertTotalProposalLinesList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalValueML",DbType.Decimal,insertTotalValueMLList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalValueMD",DbType.Decimal,insertTotalValueMDList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrencyId",DbType.String,insertCurrencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRegionId",DbType.Int64,insertRegionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssLastUpdatedOn",DbType.DateTime,insertLastUpdatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssMaxDatePaymentChanges",DbType.DateTime,insertMaxDatePaymentChangesList);
executionService.CreateParameter(insertSqlCmd,"@ssAssignedToId",DbType.String,insertAssignedToIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposal (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateNameList.IsEmpty() || !updatePaymentDateList.IsEmpty() || !updateProposalDateList.IsEmpty() || !updateProposalTypeIdList.IsEmpty() || !updateBankIdList.IsEmpty() || !updateProposalStatusIdList.IsEmpty() || !updateFileIdList.IsEmpty() || !updateTotalProposalLinesList.IsEmpty() || !updateTotalValueMLList.IsEmpty() || !updateTotalValueMDList.IsEmpty() || !updateCurrencyIdList.IsEmpty() || !updateRegionIdList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateLastUpdatedOnList.IsEmpty() || !updateMaxDatePaymentChangesList.IsEmpty() || !updateAssignedToIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssName",DbType.String,updateNameList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentDate",DbType.DateTime,updatePaymentDateList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalDate",DbType.DateTime,updateProposalDateList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalTypeId",DbType.Int32,updateProposalTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssBankId",DbType.Int64,updateBankIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalStatusId",DbType.Int32,updateProposalStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFileId",DbType.Int64,updateFileIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalProposalLines",DbType.Int32,updateTotalProposalLinesList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalValueML",DbType.Decimal,updateTotalValueMLList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalValueMD",DbType.Decimal,updateTotalValueMDList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrencyId",DbType.String,updateCurrencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRegionId",DbType.Int64,updateRegionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssLastUpdatedOn",DbType.DateTime,updateLastUpdatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssMaxDatePaymentChanges",DbType.DateTime,updateMaxDatePaymentChangesList);
executionService.CreateParameter(updateSqlCmd,"@ssAssignedToId",DbType.String,updateAssignedToIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposal (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProposal
/// </summary>

public static async Task DeleteProposal(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposal", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllProposal
/// </summary>

public static async Task DeleteAllProposal(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposal", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProposal
/// </summary>

public static async Task<RC_91adc4f46f8a0f51cacc4bc718d2ea35> GetProposal(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_91adc4f46f8a0f51cacc4bc718d2ea35 outParamRecord = default;
outParamRecord = new RC_91adc4f46f8a0f51cacc4bc718d2ea35();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENProposalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposal", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(18,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProposalForUpdate
/// </summary>

public static async Task<RC_91adc4f46f8a0f51cacc4bc718d2ea35> GetProposalForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_91adc4f46f8a0f51cacc4bc718d2ea35 outParamRecord = default;
outParamRecord = new RC_91adc4f46f8a0f51cacc4bc718d2ea35();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalForUpdate", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalForUpdate", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENProposalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(18,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProposal
/// </summary>

public static async Task UpdateProposal(IRequestContext requestContext,BitArray usedFields,RC_91adc4f46f8a0f51cacc4bc718d2ea35 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProposal", "1e64385b-1fde-4970-9b47-a360fadd3fd4.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(18,true);
}
string updateSet = "UPDATE " + ENProposalEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Name, "name") ?? "name") + " = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate") + " = @ssPaymentDate"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalDate, "proposaldate") ?? "proposaldate") + " = @ssProposalDate"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalTypeId, "proposaltypeid") ?? "proposaltypeid") + " = @ssProposalTypeId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@BankId, "bankid") ?? "bankid") + " = @ssBankId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid") + " = @ssProposalStatusId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@FileId, "fileid") ?? "fileid") + " = @ssFileId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + " = @ssTotalProposalLines"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueML, "totalvalueml") ?? "totalvalueml") + " = @ssTotalValueML"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalValueMD, "totalvaluemd") ?? "totalvaluemd") + " = @ssTotalValueMD"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon") + " = @ssLastUpdatedOn"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@MaxDatePaymentChanges, "maxdatepaymentchanges") ?? "maxdatepaymentchanges") + " = @ssMaxDatePaymentChanges"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@AssignedToId, "assignedtoid") ?? "assignedtoid") + " = @ssAssignedToId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposal_ssId_Proposal";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Proposal, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalAttributeKeys.@TotalProposalLines, "totalproposallines") ?? "totalproposallines") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENProposal.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssPaymentDate", DbType.DateTime, ssENProposal.ssPaymentDate);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProposalDate", DbType.DateTime, ssENProposal.ssProposalDate);
}
if(usedFields[4]) {
if ((ssENProposal.ssProposalTypeId==0)) {
sqlCmd.CreateParameter("@ssProposalTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalTypeId", DbType.Int32, ssENProposal.ssProposalTypeId);

}
}
if(usedFields[5]) {
if ((ssENProposal.ssBankId==0L)) {
sqlCmd.CreateParameter("@ssBankId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBankId", DbType.Int64, ssENProposal.ssBankId);

}
}
if(usedFields[6]) {
if ((ssENProposal.ssProposalStatusId==0)) {
sqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalStatusId", DbType.Int32, ssENProposal.ssProposalStatusId);

}
}
if(usedFields[7]) {
if ((ssENProposal.ssFileId==0L)) {
sqlCmd.CreateParameter("@ssFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFileId", DbType.Int64, ssENProposal.ssFileId);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssTotalProposalLines", DbType.Int32, ssENProposal.ssTotalProposalLines);
}
if(usedFields[9]) {
var TotalValueMLParameter = sqlCmd.CreateParameter("@ssTotalValueML", DbType.Decimal, ssENProposal.ssTotalValueML);
{
    string decimalAsStr = ssENProposal.ssTotalValueML.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalValueMLParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
var TotalValueMDParameter = sqlCmd.CreateParameter("@ssTotalValueMD", DbType.Decimal, ssENProposal.ssTotalValueMD);
{
    string decimalAsStr = ssENProposal.ssTotalValueMD.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalValueMDParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
if ((ssENProposal.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENProposal.ssCurrencyId);

}
}
if(usedFields[12]) {
if ((ssENProposal.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENProposal.ssRegionId);

}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENProposal.ssCreatedBy);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENProposal.ssCreatedOn);
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssLastUpdatedOn", DbType.DateTime, ssENProposal.ssLastUpdatedOn);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssMaxDatePaymentChanges", DbType.DateTime, ssENProposal.ssMaxDatePaymentChanges);
}
if(usedFields[17]) {
if ((ssENProposal.ssAssignedToId=="")) {
sqlCmd.CreateParameter("@ssAssignedToId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAssignedToId", DbType.String, ssENProposal.ssAssignedToId);

}
}
sqlCmd.CreateParameter("@idparam_ssENProposal_ssId_Proposal", DbType.Int64, ssENProposal.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProposal", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Proposal", ssENProposal.ssId.ToString()); }}
}
return;
}

}
}
