using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateProposalLine
/// </summary>

public static async Task<long> CreateProposalLine(IRequestContext requestContext,RC_cbff39127609a0f830b2d34948d1c019 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENProposalLineEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + "" +
" ) VALUES (" +
" @ssProposalId" +
", @ssApprovalStatusId" +
", @ssCompanyId" +
", @ssSupplierId" +
", @ssFe_contab_" +
", @ssEj__mes" +
", @ssCuenta" +
", @ssReferencia" +
", @ssNombre1" +
", @ssNombre2" +
", @ssN_doc_" +
", @ssN_DocType" +
", @ssImporteenML" +
", @ssML" +
", @ssImporteenMD" +
", @ssMon_" +
", @ssSoc_" +
", @ssDiv_" +
", @ssLib_mayor" +
", @ssTextocab_documento" +
", @ssDoc_comp_" +
", @ssPaidBy" +
", @ssPaidOn" +
", @ssUnpaidBy" +
", @ssUnpaidOn" +
", @ssHasErrors" +
", @ssErrorMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalLine.ssProposalId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalLine.ssProposalId);

}
if ((ssENProposalLine.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENProposalLine.ssApprovalStatusId);

}
if ((ssENProposalLine.ssCompanyId==0L)) {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENProposalLine.ssCompanyId);

}
if ((ssENProposalLine.ssSupplierId==0L)) {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENProposalLine.ssSupplierId);

}
insertSqlCmd.CreateParameter("@ssFe_contab_", DbType.DateTime, ssENProposalLine.ssFe_contab_);
insertSqlCmd.CreateParameter("@ssEj__mes", DbType.String, ssENProposalLine.ssEj__mes);
insertSqlCmd.CreateParameter("@ssCuenta", DbType.String, ssENProposalLine.ssCuenta);
insertSqlCmd.CreateParameter("@ssReferencia", DbType.String, ssENProposalLine.ssReferencia);
insertSqlCmd.CreateParameter("@ssNombre1", DbType.String, ssENProposalLine.ssNombre1);
insertSqlCmd.CreateParameter("@ssNombre2", DbType.String, ssENProposalLine.ssNombre2);
insertSqlCmd.CreateParameter("@ssN_doc_", DbType.String, ssENProposalLine.ssN_doc_);
insertSqlCmd.CreateParameter("@ssN_DocType", DbType.String, ssENProposalLine.ssN_DocType);
var ImporteenMLParameter = insertSqlCmd.CreateParameter("@ssImporteenML", DbType.Decimal, ssENProposalLine.ssImporteenML);
{
    string decimalAsStr = ssENProposalLine.ssImporteenML.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteenMLParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssML", DbType.String, ssENProposalLine.ssML);
var ImporteenMDParameter = insertSqlCmd.CreateParameter("@ssImporteenMD", DbType.Decimal, ssENProposalLine.ssImporteenMD);
{
    string decimalAsStr = ssENProposalLine.ssImporteenMD.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteenMDParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssMon_", DbType.String, ssENProposalLine.ssMon_);
insertSqlCmd.CreateParameter("@ssSoc_", DbType.String, ssENProposalLine.ssSoc_);
insertSqlCmd.CreateParameter("@ssDiv_", DbType.String, ssENProposalLine.ssDiv_);
insertSqlCmd.CreateParameter("@ssLib_mayor", DbType.String, ssENProposalLine.ssLib_mayor);
insertSqlCmd.CreateParameter("@ssTextocab_documento", DbType.String, ssENProposalLine.ssTextocab_documento);
insertSqlCmd.CreateParameter("@ssDoc_comp_", DbType.String, ssENProposalLine.ssDoc_comp_);
if ((ssENProposalLine.ssPaidBy=="")) {
insertSqlCmd.CreateParameter("@ssPaidBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaidBy", DbType.String, ssENProposalLine.ssPaidBy);

}
insertSqlCmd.CreateParameter("@ssPaidOn", DbType.DateTime, ssENProposalLine.ssPaidOn);
if ((ssENProposalLine.ssUnpaidBy=="")) {
insertSqlCmd.CreateParameter("@ssUnpaidBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUnpaidBy", DbType.String, ssENProposalLine.ssUnpaidBy);

}
insertSqlCmd.CreateParameter("@ssUnpaidOn", DbType.DateTime, ssENProposalLine.ssUnpaidOn);
insertSqlCmd.CreateParameter("@ssHasErrors", DbType.Boolean, ssENProposalLine.ssHasErrors);
insertSqlCmd.CreateParameter("@ssErrorMessage", DbType.String, ssENProposalLine.ssErrorMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateProposalLine", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateProposalLine
/// </summary>

public static async Task<long> CreateOrUpdateProposalLine(IRequestContext requestContext,BitArray usedFields,RC_cbff39127609a0f830b2d34948d1c019 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(28,true);
}
string updateSet = "UPDATE " + ENProposalLineEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = @ssCompanyId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = @ssSupplierId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_") + " = @ssFe_contab_"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes") + " = @ssEj__mes"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta") + " = @ssCuenta"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia") + " = @ssReferencia"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1") + " = @ssNombre1"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2") + " = @ssNombre2"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_") + " = @ssN_doc_"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype") + " = @ssN_DocType"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml") + " = @ssImporteenML"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml") + " = @ssML"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd") + " = @ssImporteenMD"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_") + " = @ssMon_"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_") + " = @ssSoc_"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_") + " = @ssDiv_"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor") + " = @ssLib_mayor"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento") + " = @ssTextocab_documento"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_") + " = @ssDoc_comp_"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby") + " = @ssPaidBy"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon") + " = @ssPaidOn"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby") + " = @ssUnpaidBy"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon") + " = @ssUnpaidOn"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + " = @ssHasErrors"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + " = @ssErrorMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalLine_ssId_ProposalLine";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalLine.ssProposalId==0L)) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalLine.ssProposalId);

}
}
if(usedFields[2]) {
if ((ssENProposalLine.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENProposalLine.ssApprovalStatusId);

}
}
if(usedFields[3]) {
if ((ssENProposalLine.ssCompanyId==0L)) {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENProposalLine.ssCompanyId);

}
}
if(usedFields[4]) {
if ((ssENProposalLine.ssSupplierId==0L)) {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENProposalLine.ssSupplierId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssFe_contab_", DbType.DateTime, ssENProposalLine.ssFe_contab_);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssEj__mes", DbType.String, ssENProposalLine.ssEj__mes);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCuenta", DbType.String, ssENProposalLine.ssCuenta);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssReferencia", DbType.String, ssENProposalLine.ssReferencia);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssNombre1", DbType.String, ssENProposalLine.ssNombre1);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssNombre2", DbType.String, ssENProposalLine.ssNombre2);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssN_doc_", DbType.String, ssENProposalLine.ssN_doc_);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssN_DocType", DbType.String, ssENProposalLine.ssN_DocType);
}
if(usedFields[13]) {
var ImporteenMLParameter = sqlCmd.CreateParameter("@ssImporteenML", DbType.Decimal, ssENProposalLine.ssImporteenML);
{
    string decimalAsStr = ssENProposalLine.ssImporteenML.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteenMLParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssML", DbType.String, ssENProposalLine.ssML);
}
if(usedFields[15]) {
var ImporteenMDParameter = sqlCmd.CreateParameter("@ssImporteenMD", DbType.Decimal, ssENProposalLine.ssImporteenMD);
{
    string decimalAsStr = ssENProposalLine.ssImporteenMD.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteenMDParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssMon_", DbType.String, ssENProposalLine.ssMon_);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssSoc_", DbType.String, ssENProposalLine.ssSoc_);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssDiv_", DbType.String, ssENProposalLine.ssDiv_);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssLib_mayor", DbType.String, ssENProposalLine.ssLib_mayor);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssTextocab_documento", DbType.String, ssENProposalLine.ssTextocab_documento);
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssDoc_comp_", DbType.String, ssENProposalLine.ssDoc_comp_);
}
if(usedFields[22]) {
if ((ssENProposalLine.ssPaidBy=="")) {
sqlCmd.CreateParameter("@ssPaidBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaidBy", DbType.String, ssENProposalLine.ssPaidBy);

}
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssPaidOn", DbType.DateTime, ssENProposalLine.ssPaidOn);
}
if(usedFields[24]) {
if ((ssENProposalLine.ssUnpaidBy=="")) {
sqlCmd.CreateParameter("@ssUnpaidBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUnpaidBy", DbType.String, ssENProposalLine.ssUnpaidBy);

}
}
if(usedFields[25]) {
sqlCmd.CreateParameter("@ssUnpaidOn", DbType.DateTime, ssENProposalLine.ssUnpaidOn);
}
if(usedFields[26]) {
sqlCmd.CreateParameter("@ssHasErrors", DbType.Boolean, ssENProposalLine.ssHasErrors);
}
if(usedFields[27]) {
sqlCmd.CreateParameter("@ssErrorMessage", DbType.String, ssENProposalLine.ssErrorMessage);
}
sqlCmd.CreateParameter("@idparam_ssENProposalLine_ssId_ProposalLine", DbType.Int64, ssENProposalLine.ssId);
int counter = 0;
if(ssENProposalLine.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalLine (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENProposalLineEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + "" +
" ) VALUES (" +
" @ssProposalId" +
", @ssApprovalStatusId" +
", @ssCompanyId" +
", @ssSupplierId" +
", @ssFe_contab_" +
", @ssEj__mes" +
", @ssCuenta" +
", @ssReferencia" +
", @ssNombre1" +
", @ssNombre2" +
", @ssN_doc_" +
", @ssN_DocType" +
", @ssImporteenML" +
", @ssML" +
", @ssImporteenMD" +
", @ssMon_" +
", @ssSoc_" +
", @ssDiv_" +
", @ssLib_mayor" +
", @ssTextocab_documento" +
", @ssDoc_comp_" +
", @ssPaidBy" +
", @ssPaidOn" +
", @ssUnpaidBy" +
", @ssUnpaidOn" +
", @ssHasErrors" +
", @ssErrorMessage" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENProposalLine.ssProposalId==0L)) {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalLine.ssProposalId);

}
if ((ssENProposalLine.ssApprovalStatusId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENProposalLine.ssApprovalStatusId);

}
if ((ssENProposalLine.ssCompanyId==0L)) {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENProposalLine.ssCompanyId);

}
if ((ssENProposalLine.ssSupplierId==0L)) {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENProposalLine.ssSupplierId);

}
insertSqlCmd.CreateParameter("@ssFe_contab_", DbType.DateTime, ssENProposalLine.ssFe_contab_);
insertSqlCmd.CreateParameter("@ssEj__mes", DbType.String, ssENProposalLine.ssEj__mes);
insertSqlCmd.CreateParameter("@ssCuenta", DbType.String, ssENProposalLine.ssCuenta);
insertSqlCmd.CreateParameter("@ssReferencia", DbType.String, ssENProposalLine.ssReferencia);
insertSqlCmd.CreateParameter("@ssNombre1", DbType.String, ssENProposalLine.ssNombre1);
insertSqlCmd.CreateParameter("@ssNombre2", DbType.String, ssENProposalLine.ssNombre2);
insertSqlCmd.CreateParameter("@ssN_doc_", DbType.String, ssENProposalLine.ssN_doc_);
insertSqlCmd.CreateParameter("@ssN_DocType", DbType.String, ssENProposalLine.ssN_DocType);
var ImporteenMLParameter = insertSqlCmd.CreateParameter("@ssImporteenML", DbType.Decimal, ssENProposalLine.ssImporteenML);
{
    string decimalAsStr = ssENProposalLine.ssImporteenML.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteenMLParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssML", DbType.String, ssENProposalLine.ssML);
var ImporteenMDParameter = insertSqlCmd.CreateParameter("@ssImporteenMD", DbType.Decimal, ssENProposalLine.ssImporteenMD);
{
    string decimalAsStr = ssENProposalLine.ssImporteenMD.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteenMDParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssMon_", DbType.String, ssENProposalLine.ssMon_);
insertSqlCmd.CreateParameter("@ssSoc_", DbType.String, ssENProposalLine.ssSoc_);
insertSqlCmd.CreateParameter("@ssDiv_", DbType.String, ssENProposalLine.ssDiv_);
insertSqlCmd.CreateParameter("@ssLib_mayor", DbType.String, ssENProposalLine.ssLib_mayor);
insertSqlCmd.CreateParameter("@ssTextocab_documento", DbType.String, ssENProposalLine.ssTextocab_documento);
insertSqlCmd.CreateParameter("@ssDoc_comp_", DbType.String, ssENProposalLine.ssDoc_comp_);
if ((ssENProposalLine.ssPaidBy=="")) {
insertSqlCmd.CreateParameter("@ssPaidBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaidBy", DbType.String, ssENProposalLine.ssPaidBy);

}
insertSqlCmd.CreateParameter("@ssPaidOn", DbType.DateTime, ssENProposalLine.ssPaidOn);
if ((ssENProposalLine.ssUnpaidBy=="")) {
insertSqlCmd.CreateParameter("@ssUnpaidBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUnpaidBy", DbType.String, ssENProposalLine.ssUnpaidBy);

}
insertSqlCmd.CreateParameter("@ssUnpaidOn", DbType.DateTime, ssENProposalLine.ssUnpaidOn);
insertSqlCmd.CreateParameter("@ssHasErrors", DbType.Boolean, ssENProposalLine.ssHasErrors);
insertSqlCmd.CreateParameter("@ssErrorMessage", DbType.String, ssENProposalLine.ssErrorMessage);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateProposalLine", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENProposalLine.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeProposalLine
/// </summary>

public static async Task CreateOrUpdateSomeProposalLine(IRequestContext requestContext,RL_5a265eacaa987aecd8ded8a7c13b9b2d inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENProposalLineEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + ") VALUES ( unnest(@ssProposalId),  unnest(@ssApprovalStatusId),  unnest(@ssCompanyId),  unnest(@ssSupplierId),  unnest(@ssFe_contab_),  unnest(@ssEj__mes),  unnest(@ssCuenta),  unnest(@ssReferencia),  unnest(@ssNombre1),  unnest(@ssNombre2),  unnest(@ssN_doc_),  unnest(@ssN_DocType),  unnest(@ssImporteenML),  unnest(@ssML),  unnest(@ssImporteenMD),  unnest(@ssMon_),  unnest(@ssSoc_),  unnest(@ssDiv_),  unnest(@ssLib_mayor),  unnest(@ssTextocab_documento),  unnest(@ssDoc_comp_),  unnest(@ssPaidBy),  unnest(@ssPaidOn),  unnest(@ssUnpaidBy),  unnest(@ssUnpaidOn),  unnest(@ssHasErrors),  unnest(@ssErrorMessage)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssProposalId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + ",  unnest(@ssApprovalStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + ",  unnest(@ssCompanyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ",  unnest(@ssSupplierId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ",  unnest(@ssFe_contab_) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_") + ",  unnest(@ssEj__mes) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes") + ",  unnest(@ssCuenta) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta") + ",  unnest(@ssReferencia) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia") + ",  unnest(@ssNombre1) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1") + ",  unnest(@ssNombre2) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2") + ",  unnest(@ssN_doc_) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_") + ",  unnest(@ssN_DocType) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype") + ",  unnest(@ssImporteenML) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml") + ",  unnest(@ssML) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml") + ",  unnest(@ssImporteenMD) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd") + ",  unnest(@ssMon_) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_") + ",  unnest(@ssSoc_) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_") + ",  unnest(@ssDiv_) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_") + ",  unnest(@ssLib_mayor) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor") + ",  unnest(@ssTextocab_documento) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento") + ",  unnest(@ssDoc_comp_) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_") + ",  unnest(@ssPaidBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby") + ",  unnest(@ssPaidOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon") + ",  unnest(@ssUnpaidBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby") + ",  unnest(@ssUnpaidOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon") + ",  unnest(@ssHasErrors) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + ",  unnest(@ssErrorMessage) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertProposalIdList = new List<object>();
List<object> insertApprovalStatusIdList = new List<object>();
List<object> insertCompanyIdList = new List<object>();
List<object> insertSupplierIdList = new List<object>();
List<DateTime> insertFe_contab_List = new List<DateTime>();
List<string> insertEj__mesList = new List<string>();
List<string> insertCuentaList = new List<string>();
List<string> insertReferenciaList = new List<string>();
List<string> insertNombre1List = new List<string>();
List<string> insertNombre2List = new List<string>();
List<string> insertN_doc_List = new List<string>();
List<string> insertN_DocTypeList = new List<string>();
List<decimal> insertImporteenMLList = new List<decimal>();
List<string> insertMLList = new List<string>();
List<decimal> insertImporteenMDList = new List<decimal>();
List<string> insertMon_List = new List<string>();
List<string> insertSoc_List = new List<string>();
List<string> insertDiv_List = new List<string>();
List<string> insertLib_mayorList = new List<string>();
List<string> insertTextocab_documentoList = new List<string>();
List<string> insertDoc_comp_List = new List<string>();
List<object> insertPaidByList = new List<object>();
List<DateTime> insertPaidOnList = new List<DateTime>();
List<object> insertUnpaidByList = new List<object>();
List<DateTime> insertUnpaidOnList = new List<DateTime>();
List<bool> insertHasErrorsList = new List<bool>();
List<string> insertErrorMessageList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateProposalIdList = new List<object>();
List<object> updateApprovalStatusIdList = new List<object>();
List<object> updateCompanyIdList = new List<object>();
List<object> updateSupplierIdList = new List<object>();
List<DateTime> updateFe_contab_List = new List<DateTime>();
List<string> updateEj__mesList = new List<string>();
List<string> updateCuentaList = new List<string>();
List<string> updateReferenciaList = new List<string>();
List<string> updateNombre1List = new List<string>();
List<string> updateNombre2List = new List<string>();
List<string> updateN_doc_List = new List<string>();
List<string> updateN_DocTypeList = new List<string>();
List<decimal> updateImporteenMLList = new List<decimal>();
List<string> updateMLList = new List<string>();
List<decimal> updateImporteenMDList = new List<decimal>();
List<string> updateMon_List = new List<string>();
List<string> updateSoc_List = new List<string>();
List<string> updateDiv_List = new List<string>();
List<string> updateLib_mayorList = new List<string>();
List<string> updateTextocab_documentoList = new List<string>();
List<string> updateDoc_comp_List = new List<string>();
List<object> updatePaidByList = new List<object>();
List<DateTime> updatePaidOnList = new List<DateTime>();
List<object> updateUnpaidByList = new List<object>();
List<DateTime> updateUnpaidOnList = new List<DateTime>();
List<bool> updateHasErrorsList = new List<bool>();
List<string> updateErrorMessageList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_cbff39127609a0f830b2d34948d1c019)inParamSourceList.Current).ssENProposalLine;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssProposalId==0L)) {
updateProposalIdList.Add(null);
} else {
updateProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
}
if ((record.ssApprovalStatusId==0)) {
updateApprovalStatusIdList.Add(null);
} else {
updateApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
if ((record.ssCompanyId==0L)) {
updateCompanyIdList.Add(null);
} else {
updateCompanyIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCompanyId));
}
if ((record.ssSupplierId==0L)) {
updateSupplierIdList.Add(null);
} else {
updateSupplierIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSupplierId));
}
updateFe_contab_List.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFe_contab_));
updateEj__mesList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEj__mes));
updateCuentaList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCuenta));
updateReferenciaList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssReferencia));
updateNombre1List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssNombre1));
updateNombre2List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssNombre2));
updateN_doc_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssN_doc_));
updateN_DocTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssN_DocType));
updateImporteenMLList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssImporteenML));
updateMLList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssML));
updateImporteenMDList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssImporteenMD));
updateMon_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMon_));
updateSoc_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSoc_));
updateDiv_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDiv_));
updateLib_mayorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLib_mayor));
updateTextocab_documentoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTextocab_documento));
updateDoc_comp_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDoc_comp_));
if ((record.ssPaidBy=="")) {
updatePaidByList.Add(null);
} else {
updatePaidByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPaidBy));
}
updatePaidOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssPaidOn));
if ((record.ssUnpaidBy=="")) {
updateUnpaidByList.Add(null);
} else {
updateUnpaidByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUnpaidBy));
}
updateUnpaidOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUnpaidOn));
updateHasErrorsList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasErrors));
updateErrorMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssErrorMessage));
} else {
if ((record.ssProposalId==0L)) {
insertProposalIdList.Add(null);
} else {
insertProposalIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProposalId));
}
if ((record.ssApprovalStatusId==0)) {
insertApprovalStatusIdList.Add(null);
} else {
insertApprovalStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalStatusId));
}
if ((record.ssCompanyId==0L)) {
insertCompanyIdList.Add(null);
} else {
insertCompanyIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCompanyId));
}
if ((record.ssSupplierId==0L)) {
insertSupplierIdList.Add(null);
} else {
insertSupplierIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSupplierId));
}
insertFe_contab_List.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssFe_contab_));
insertEj__mesList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEj__mes));
insertCuentaList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCuenta));
insertReferenciaList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssReferencia));
insertNombre1List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssNombre1));
insertNombre2List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssNombre2));
insertN_doc_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssN_doc_));
insertN_DocTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssN_DocType));
insertImporteenMLList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssImporteenML));
insertMLList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssML));
insertImporteenMDList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssImporteenMD));
insertMon_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMon_));
insertSoc_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSoc_));
insertDiv_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDiv_));
insertLib_mayorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssLib_mayor));
insertTextocab_documentoList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTextocab_documento));
insertDoc_comp_List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDoc_comp_));
if ((record.ssPaidBy=="")) {
insertPaidByList.Add(null);
} else {
insertPaidByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPaidBy));
}
insertPaidOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssPaidOn));
if ((record.ssUnpaidBy=="")) {
insertUnpaidByList.Add(null);
} else {
insertUnpaidByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUnpaidBy));
}
insertUnpaidOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUnpaidOn));
insertHasErrorsList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasErrors));
insertErrorMessageList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssErrorMessage));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertProposalIdList.IsEmpty() || !insertApprovalStatusIdList.IsEmpty() || !insertCompanyIdList.IsEmpty() || !insertSupplierIdList.IsEmpty() || !insertFe_contab_List.IsEmpty() || !insertEj__mesList.IsEmpty() || !insertCuentaList.IsEmpty() || !insertReferenciaList.IsEmpty() || !insertNombre1List.IsEmpty() || !insertNombre2List.IsEmpty() || !insertN_doc_List.IsEmpty() || !insertN_DocTypeList.IsEmpty() || !insertImporteenMLList.IsEmpty() || !insertMLList.IsEmpty() || !insertImporteenMDList.IsEmpty() || !insertMon_List.IsEmpty() || !insertSoc_List.IsEmpty() || !insertDiv_List.IsEmpty() || !insertLib_mayorList.IsEmpty() || !insertTextocab_documentoList.IsEmpty() || !insertDoc_comp_List.IsEmpty() || !insertPaidByList.IsEmpty() || !insertPaidOnList.IsEmpty() || !insertUnpaidByList.IsEmpty() || !insertUnpaidOnList.IsEmpty() || !insertHasErrorsList.IsEmpty() || !insertErrorMessageList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssProposalId",DbType.Int64,insertProposalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalStatusId",DbType.Int32,insertApprovalStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCompanyId",DbType.Int64,insertCompanyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSupplierId",DbType.Int64,insertSupplierIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFe_contab_",DbType.DateTime,insertFe_contab_List);
executionService.CreateParameter(insertSqlCmd,"@ssEj__mes",DbType.String,insertEj__mesList);
executionService.CreateParameter(insertSqlCmd,"@ssCuenta",DbType.String,insertCuentaList);
executionService.CreateParameter(insertSqlCmd,"@ssReferencia",DbType.String,insertReferenciaList);
executionService.CreateParameter(insertSqlCmd,"@ssNombre1",DbType.String,insertNombre1List);
executionService.CreateParameter(insertSqlCmd,"@ssNombre2",DbType.String,insertNombre2List);
executionService.CreateParameter(insertSqlCmd,"@ssN_doc_",DbType.String,insertN_doc_List);
executionService.CreateParameter(insertSqlCmd,"@ssN_DocType",DbType.String,insertN_DocTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssImporteenML",DbType.Decimal,insertImporteenMLList);
executionService.CreateParameter(insertSqlCmd,"@ssML",DbType.String,insertMLList);
executionService.CreateParameter(insertSqlCmd,"@ssImporteenMD",DbType.Decimal,insertImporteenMDList);
executionService.CreateParameter(insertSqlCmd,"@ssMon_",DbType.String,insertMon_List);
executionService.CreateParameter(insertSqlCmd,"@ssSoc_",DbType.String,insertSoc_List);
executionService.CreateParameter(insertSqlCmd,"@ssDiv_",DbType.String,insertDiv_List);
executionService.CreateParameter(insertSqlCmd,"@ssLib_mayor",DbType.String,insertLib_mayorList);
executionService.CreateParameter(insertSqlCmd,"@ssTextocab_documento",DbType.String,insertTextocab_documentoList);
executionService.CreateParameter(insertSqlCmd,"@ssDoc_comp_",DbType.String,insertDoc_comp_List);
executionService.CreateParameter(insertSqlCmd,"@ssPaidBy",DbType.String,insertPaidByList);
executionService.CreateParameter(insertSqlCmd,"@ssPaidOn",DbType.DateTime,insertPaidOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUnpaidBy",DbType.String,insertUnpaidByList);
executionService.CreateParameter(insertSqlCmd,"@ssUnpaidOn",DbType.DateTime,insertUnpaidOnList);
executionService.CreateParameter(insertSqlCmd,"@ssHasErrors",DbType.Boolean,insertHasErrorsList);
executionService.CreateParameter(insertSqlCmd,"@ssErrorMessage",DbType.String,insertErrorMessageList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalLine (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateProposalIdList.IsEmpty() || !updateApprovalStatusIdList.IsEmpty() || !updateCompanyIdList.IsEmpty() || !updateSupplierIdList.IsEmpty() || !updateFe_contab_List.IsEmpty() || !updateEj__mesList.IsEmpty() || !updateCuentaList.IsEmpty() || !updateReferenciaList.IsEmpty() || !updateNombre1List.IsEmpty() || !updateNombre2List.IsEmpty() || !updateN_doc_List.IsEmpty() || !updateN_DocTypeList.IsEmpty() || !updateImporteenMLList.IsEmpty() || !updateMLList.IsEmpty() || !updateImporteenMDList.IsEmpty() || !updateMon_List.IsEmpty() || !updateSoc_List.IsEmpty() || !updateDiv_List.IsEmpty() || !updateLib_mayorList.IsEmpty() || !updateTextocab_documentoList.IsEmpty() || !updateDoc_comp_List.IsEmpty() || !updatePaidByList.IsEmpty() || !updatePaidOnList.IsEmpty() || !updateUnpaidByList.IsEmpty() || !updateUnpaidOnList.IsEmpty() || !updateHasErrorsList.IsEmpty() || !updateErrorMessageList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProposalId",DbType.Int64,updateProposalIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalStatusId",DbType.Int32,updateApprovalStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCompanyId",DbType.Int64,updateCompanyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSupplierId",DbType.Int64,updateSupplierIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFe_contab_",DbType.DateTime,updateFe_contab_List);
executionService.CreateParameter(updateSqlCmd,"@ssEj__mes",DbType.String,updateEj__mesList);
executionService.CreateParameter(updateSqlCmd,"@ssCuenta",DbType.String,updateCuentaList);
executionService.CreateParameter(updateSqlCmd,"@ssReferencia",DbType.String,updateReferenciaList);
executionService.CreateParameter(updateSqlCmd,"@ssNombre1",DbType.String,updateNombre1List);
executionService.CreateParameter(updateSqlCmd,"@ssNombre2",DbType.String,updateNombre2List);
executionService.CreateParameter(updateSqlCmd,"@ssN_doc_",DbType.String,updateN_doc_List);
executionService.CreateParameter(updateSqlCmd,"@ssN_DocType",DbType.String,updateN_DocTypeList);
executionService.CreateParameter(updateSqlCmd,"@ssImporteenML",DbType.Decimal,updateImporteenMLList);
executionService.CreateParameter(updateSqlCmd,"@ssML",DbType.String,updateMLList);
executionService.CreateParameter(updateSqlCmd,"@ssImporteenMD",DbType.Decimal,updateImporteenMDList);
executionService.CreateParameter(updateSqlCmd,"@ssMon_",DbType.String,updateMon_List);
executionService.CreateParameter(updateSqlCmd,"@ssSoc_",DbType.String,updateSoc_List);
executionService.CreateParameter(updateSqlCmd,"@ssDiv_",DbType.String,updateDiv_List);
executionService.CreateParameter(updateSqlCmd,"@ssLib_mayor",DbType.String,updateLib_mayorList);
executionService.CreateParameter(updateSqlCmd,"@ssTextocab_documento",DbType.String,updateTextocab_documentoList);
executionService.CreateParameter(updateSqlCmd,"@ssDoc_comp_",DbType.String,updateDoc_comp_List);
executionService.CreateParameter(updateSqlCmd,"@ssPaidBy",DbType.String,updatePaidByList);
executionService.CreateParameter(updateSqlCmd,"@ssPaidOn",DbType.DateTime,updatePaidOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUnpaidBy",DbType.String,updateUnpaidByList);
executionService.CreateParameter(updateSqlCmd,"@ssUnpaidOn",DbType.DateTime,updateUnpaidOnList);
executionService.CreateParameter(updateSqlCmd,"@ssHasErrors",DbType.Boolean,updateHasErrorsList);
executionService.CreateParameter(updateSqlCmd,"@ssErrorMessage",DbType.String,updateErrorMessageList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeProposalLine (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteProposalLine
/// </summary>

public static async Task DeleteProposalLine(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalLineEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalLine", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllProposalLine
/// </summary>

public static async Task DeleteAllProposalLine(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENProposalLineEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteProposalLine", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetProposalLine
/// </summary>

public static async Task<RC_cbff39127609a0f830b2d34948d1c019> GetProposalLine(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cbff39127609a0f830b2d34948d1c019 outParamRecord = default;
outParamRecord = new RC_cbff39127609a0f830b2d34948d1c019();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENProposalLineEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalLine", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(28,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalLineEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetProposalLineForUpdate
/// </summary>

public static async Task<RC_cbff39127609a0f830b2d34948d1c019> GetProposalLineForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cbff39127609a0f830b2d34948d1c019 outParamRecord = default;
outParamRecord = new RC_cbff39127609a0f830b2d34948d1c019();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalLineForUpdate", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalLineForUpdate", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENProposalLineEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalLineForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(28,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalLineEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateProposalLine
/// </summary>

public static async Task UpdateProposalLine(IRequestContext requestContext,BitArray usedFields,RC_cbff39127609a0f830b2d34948d1c019 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateProposalLine", "f80cbef9-5f6a-42fa-822f-dbfef27cab60.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(28,true);
}
string updateSet = "UPDATE " + ENProposalLineEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ProposalId, "proposalid") ?? "proposalid") + " = @ssProposalId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid") + " = @ssApprovalStatusId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = @ssCompanyId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = @ssSupplierId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Fe_contab_, "fe_contab_") ?? "fe_contab_") + " = @ssFe_contab_"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Ej__mes, "ej__mes") ?? "ej__mes") + " = @ssEj__mes"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Cuenta, "cuenta") ?? "cuenta") + " = @ssCuenta"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Referencia, "referencia") ?? "referencia") + " = @ssReferencia"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre1, "nombre1") ?? "nombre1") + " = @ssNombre1"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Nombre2, "nombre2") ?? "nombre2") + " = @ssNombre2"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_doc_, "n_doc_") ?? "n_doc_") + " = @ssN_doc_"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@N_DocType, "n_doctype") ?? "n_doctype") + " = @ssN_DocType"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenML, "importeenml") ?? "importeenml") + " = @ssImporteenML"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ML, "ml") ?? "ml") + " = @ssML"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ImporteenMD, "importeenmd") ?? "importeenmd") + " = @ssImporteenMD"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Mon_, "mon_") ?? "mon_") + " = @ssMon_"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Soc_, "soc_") ?? "soc_") + " = @ssSoc_"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Div_, "div_") ?? "div_") + " = @ssDiv_"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Lib_mayor, "lib_mayor") ?? "lib_mayor") + " = @ssLib_mayor"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Textocab_documento, "textocab_documento") ?? "textocab_documento") + " = @ssTextocab_documento"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Doc_comp_, "doc_comp_") ?? "doc_comp_") + " = @ssDoc_comp_"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidBy, "paidby") ?? "paidby") + " = @ssPaidBy"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@PaidOn, "paidon") ?? "paidon") + " = @ssPaidOn"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidBy, "unpaidby") ?? "unpaidby") + " = @ssUnpaidBy"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@UnpaidOn, "unpaidon") ?? "unpaidon") + " = @ssUnpaidOn"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + " = @ssHasErrors"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@ErrorMessage, "errormessage") ?? "errormessage") + " = @ssErrorMessage"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENProposalLine_ssId_ProposalLine";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLine, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineAttributeKeys.@HasErrors, "haserrors") ?? "haserrors") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENProposalLine.ssProposalId==0L)) {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProposalId", DbType.Int64, ssENProposalLine.ssProposalId);

}
}
if(usedFields[2]) {
if ((ssENProposalLine.ssApprovalStatusId==0)) {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalStatusId", DbType.Int32, ssENProposalLine.ssApprovalStatusId);

}
}
if(usedFields[3]) {
if ((ssENProposalLine.ssCompanyId==0L)) {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENProposalLine.ssCompanyId);

}
}
if(usedFields[4]) {
if ((ssENProposalLine.ssSupplierId==0L)) {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENProposalLine.ssSupplierId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssFe_contab_", DbType.DateTime, ssENProposalLine.ssFe_contab_);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssEj__mes", DbType.String, ssENProposalLine.ssEj__mes);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssCuenta", DbType.String, ssENProposalLine.ssCuenta);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssReferencia", DbType.String, ssENProposalLine.ssReferencia);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssNombre1", DbType.String, ssENProposalLine.ssNombre1);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssNombre2", DbType.String, ssENProposalLine.ssNombre2);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssN_doc_", DbType.String, ssENProposalLine.ssN_doc_);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssN_DocType", DbType.String, ssENProposalLine.ssN_DocType);
}
if(usedFields[13]) {
var ImporteenMLParameter = sqlCmd.CreateParameter("@ssImporteenML", DbType.Decimal, ssENProposalLine.ssImporteenML);
{
    string decimalAsStr = ssENProposalLine.ssImporteenML.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteenMLParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssML", DbType.String, ssENProposalLine.ssML);
}
if(usedFields[15]) {
var ImporteenMDParameter = sqlCmd.CreateParameter("@ssImporteenMD", DbType.Decimal, ssENProposalLine.ssImporteenMD);
{
    string decimalAsStr = ssENProposalLine.ssImporteenMD.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ImporteenMDParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssMon_", DbType.String, ssENProposalLine.ssMon_);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssSoc_", DbType.String, ssENProposalLine.ssSoc_);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssDiv_", DbType.String, ssENProposalLine.ssDiv_);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssLib_mayor", DbType.String, ssENProposalLine.ssLib_mayor);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssTextocab_documento", DbType.String, ssENProposalLine.ssTextocab_documento);
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssDoc_comp_", DbType.String, ssENProposalLine.ssDoc_comp_);
}
if(usedFields[22]) {
if ((ssENProposalLine.ssPaidBy=="")) {
sqlCmd.CreateParameter("@ssPaidBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaidBy", DbType.String, ssENProposalLine.ssPaidBy);

}
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssPaidOn", DbType.DateTime, ssENProposalLine.ssPaidOn);
}
if(usedFields[24]) {
if ((ssENProposalLine.ssUnpaidBy=="")) {
sqlCmd.CreateParameter("@ssUnpaidBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUnpaidBy", DbType.String, ssENProposalLine.ssUnpaidBy);

}
}
if(usedFields[25]) {
sqlCmd.CreateParameter("@ssUnpaidOn", DbType.DateTime, ssENProposalLine.ssUnpaidOn);
}
if(usedFields[26]) {
sqlCmd.CreateParameter("@ssHasErrors", DbType.Boolean, ssENProposalLine.ssHasErrors);
}
if(usedFields[27]) {
sqlCmd.CreateParameter("@ssErrorMessage", DbType.String, ssENProposalLine.ssErrorMessage);
}
sqlCmd.CreateParameter("@idparam_ssENProposalLine_ssId_ProposalLine", DbType.Int64, ssENProposalLine.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateProposalLine", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("ProposalLine", ssENProposalLine.ssId.ToString()); }}
}
return;
}

}
}
