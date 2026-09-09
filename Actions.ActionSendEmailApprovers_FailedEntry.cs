namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendEmailApprovers_FailedEntry : VarsBag {
public long inParami_FolioId;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetApprovers_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetApprovers_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserExtendedInternal_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserExtendedInternal_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_2b9a8ce7bf73dacd0e0e114719f57b83 queryResGetFolioById_outParamList = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
public long queryResGetFolioById_outParamCount = 0L;

public lcvSendEmailApprovers_FailedEntry(long inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}
}
/// <summary>
/// Action <code>SendEmailApprovers_FailedEntry</code> that represents the Service Studio action
///  <code>SendEmailApprovers_FailedEntry</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendEmailApprovers_FailedEntry(IRequestContext requestContext,long inParami_FolioId,CancellationToken cancellationToken) {
lcvSendEmailApprovers_FailedEntry localVars = new lcvSendEmailApprovers_FailedEntry(inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendEmailApprovers_FailedEntry", "c9d52f0a-34db-41f0-b15f-64c6f8c7efa2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendEmailApprovers_FailedEntry", "c9d52f0a-34db-41f0-b15f-64c6f8c7efa2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionSendEmailApprovers_FailedEntry.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Query datasetGetApprovers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovers_maxRecords = 0;
int datasetGetApprovers_startIndex = 0;(localVars.queryResGetApprovers_outParamList,localVars.queryResGetApprovers_outParamCount) = await FuncActionSendEmailApprovers_FailedEntry.datasetGetApprovers(requestContext,datasetGetApprovers_maxRecords,datasetGetApprovers_startIndex,IterationMultiplicity.Single,localVars.inParami_FolioId,cancellationToken);

// Foreach GetApprovers.List
localVars.queryResGetApprovers_outParamList.StartIteration();
try {while (!((localVars.queryResGetApprovers_outParamList.Eof))) {
// Query datasetGetUserExtendedInternal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternal_maxRecords = 1;
if (datasetGetUserExtendedInternal_maxRecords < 1) datasetGetUserExtendedInternal_maxRecords = 1;
int datasetGetUserExtendedInternal_startIndex = 0;(localVars.queryResGetUserExtendedInternal_outParamList,localVars.queryResGetUserExtendedInternal_outParamCount) = await FuncActionSendEmailApprovers_FailedEntry.datasetGetUserExtendedInternal(requestContext,datasetGetUserExtendedInternal_maxRecords,datasetGetUserExtendedInternal_startIndex,IterationMultiplicity.Never,localVars.queryResGetApprovers_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedBy,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,(await RecordUtils.ConvertAsync(localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec, new ST_12668886130225cd5b17c72a6562dd7cStructure(), async (RC_e6a121d9e10463243528b9fbc6a71f2e source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssId;
target.ssEmail = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssEmail;
target.ssName = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssName;
target.ssEmailTo = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetApprovers_outParamList.Advance();
}

} finally {
localVars.queryResGetApprovers_outParamList.EndIteration();
}

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",0,("Folios - Folio con entrada fallida "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber),(("Lo folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ha tienido entrada fallida."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("FailedEntry", "3d4f4a79-c34c-4a39-be69-90360ef152a3"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("FailedEntry", "3d4f4a79-c34c-4a39-be69-90360ef152a3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_FailedEntry>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? ((((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail))) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))),
        From = "",
        Cc = "",
        Bcc = "",
        Subject = string.Empty,
        Headers = new List<string>(),
        Attachments = mappedAttachments,
        ExtraImagesToAppend = emailScreen.ImagesToEmbed()
    };

    await OutSystems.Application.Core.Email.EmailService.Instance.SendEmailAsync(message, sendEmailActivity, cancellationToken);
}
localVars.varLcl_EmailNotification.Advance();
}

} finally {
localVars.varLcl_EmailNotification.EndIteration();
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

goto RETURN_STATEMENT;

} // Catch
finally {
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSendEmailApprovers_FailedEntry {

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetApproversReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovers" hg9ZHx9M30GdabKpIv78QQ of Action "SendEmailApprovers_FailedEntry"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetApprovers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailApprovers_FailedEntry.GetApprovers", "1f590f86-4c1f-41df-9d69-b2a922fefc41");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailApprovers_FailedEntry.GetApprovers", "1f590f86-4c1f-41df-9d69-b2a922fefc41", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.Ci_Vyds08EGxX2TG+Mfvog/NodesNotShownInESpaceTree.hg9ZHx9M30GdabKpIv78QQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enfolioapprovallevel25\".\"approvedby\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval28\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel25\" ON (\"enfolioapproval28\".\"id\" = \"enfolioapprovallevel25\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval28\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval28\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval28\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel25\".\"approvedby\" IS NOT NULL)");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApproversReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailApprovers_FailedEntry.GetApprovers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetApproversReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailApprovers_FailedEntry.GetApprovers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserExtendedInternalReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternal" AldSMK3WVkWtxUTgRHouPA of Action "SendEmailApprovers_FailedEntry"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserExtendedInternal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailApprovers_FailedEntry.GetUserExtendedInternal", "30525702-d6ad-4556-adc5-44e0447a2e3c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailApprovers_FailedEntry.GetUserExtendedInternal", "30525702-d6ad-4556-adc5-44e0447a2e3c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.Ci_Vyds08EGxX2TG+Mfvog/NodesNotShownInESpaceTree.AldSMK3WVkWtxUTgRHouPA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser111\".\"id\" o0, \"enuser111\".\"name\" o1, \"enuser111\".\"email\" o2, \"enuser111\".\"photourl\" o3, \"enuser111\".\"username\" o4, \"enuserextension51\".\"id\" o5, \"enuserextension51\".\"correspondentexternalemail\" o6, \"enuserextension51\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser111\" Left JOIN {UserExtension} \"enuserextension51\" ON (\"enuser111\".\"id\" = \"enuserextension51\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser111\".\"id\" = @qpusUser_Id) AND (\"enuser111\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser111\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_c5c32c91f72d14efd2c0ccca15008afa outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailApprovers_FailedEntry.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailApprovers_FailedEntry.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5c32c91f72d14efd2c0ccca15008afa)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_77e758d8dd6b0d691548b18323e10e77> datasetGetFolioByIdReadDbAsync(RC_77e758d8dd6b0d691548b18323e10e77 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" YcHj+AXT7U6s7hMWumg81A of Action "SendEmailApprovers_FailedEntry"
public static async Task<(RL_2b9a8ce7bf73dacd0e0e114719f57b83,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailApprovers_FailedEntry.GetFolioById", "f8e3c161-d305-4eed-acee-1316ba683cd4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailApprovers_FailedEntry.GetFolioById", "f8e3c161-d305-4eed-acee-1316ba683cd4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.Ci_Vyds08EGxX2TG+Mfvog/NodesNotShownInESpaceTree.YcHj+AXT7U6s7hMWumg81A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio50\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enfoliosapdata10\".\"po_documento_material_em\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM ({Folio} \"enfolio50\" Left JOIN {FolioSAPData} \"enfoliosapdata10\" ON (\"enfolio50\".\"id\" = \"enfoliosapdata10\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio50\".\"id\" = @qpfoFolio_Id) AND (\"enfolio50\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio50\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_2b9a8ce7bf73dacd0e0e114719f57b83 outParamList = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailApprovers_FailedEntry.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2b9a8ce7bf73dacd0e0e114719f57b83 _tmp = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailApprovers_FailedEntry.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2b9a8ce7bf73dacd0e0e114719f57b83)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}



}


}
