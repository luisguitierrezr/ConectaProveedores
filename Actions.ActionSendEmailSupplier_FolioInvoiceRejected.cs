namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendEmailSupplier_FolioInvoiceRejected : VarsBag {
public long inParami_FolioId;
public string inParami_RejectMotive;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_2b9a8ce7bf73dacd0e0e114719f57b83 queryResGetFolioById_outParamList = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
public long queryResGetFolioById_outParamCount = 0L;

public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetApprovers_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetApprovers_outParamCount = 0L;

public RL_519cfbd5c9d3e969a6c55ad5a0702da1 queryResGetUsersProveedores_outParamList = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
public long queryResGetUsersProveedores_outParamCount = 0L;

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserExtendedInternal_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserExtendedInternal_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public lcvSendEmailSupplier_FolioInvoiceRejected(long inParami_FolioId, string inParami_RejectMotive) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_RejectMotive = inParami_RejectMotive;
}
}
/// <summary>
/// Action <code>SendEmailSupplier_FolioInvoiceRejected</code> that represents the Service Studio
///  action <code>SendEmailSupplier_FolioInvoiceRejected</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendEmailSupplier_FolioInvoiceRejected(IRequestContext requestContext,long inParami_FolioId,string inParami_RejectMotive,CancellationToken cancellationToken) {
lcvSendEmailSupplier_FolioInvoiceRejected localVars = new lcvSendEmailSupplier_FolioInvoiceRejected(inParami_FolioId, inParami_RejectMotive);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendEmailSupplier_FolioInvoiceRejected", "82caedaf-c462-4fe6-a011-a52eb1aa4fb6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendEmailSupplier_FolioInvoiceRejected", "82caedaf-c462-4fe6-a011-a52eb1aa4fb6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionSendEmailSupplier_FolioInvoiceRejected.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Query datasetGetApprovers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovers_maxRecords = 0;
int datasetGetApprovers_startIndex = 0;(localVars.queryResGetApprovers_outParamList,localVars.queryResGetApprovers_outParamCount) = await FuncActionSendEmailSupplier_FolioInvoiceRejected.datasetGetApprovers(requestContext,datasetGetApprovers_maxRecords,datasetGetApprovers_startIndex,IterationMultiplicity.Single,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId,localVars.inParami_FolioId,cancellationToken);

// Foreach GetApprovers.List
localVars.queryResGetApprovers_outParamList.StartIteration();
try {while (!((localVars.queryResGetApprovers_outParamList.Eof))) {
// Query datasetGetUserExtendedInternal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternal_maxRecords = 1;
if (datasetGetUserExtendedInternal_maxRecords < 1) datasetGetUserExtendedInternal_maxRecords = 1;
int datasetGetUserExtendedInternal_startIndex = 0;(localVars.queryResGetUserExtendedInternal_outParamList,localVars.queryResGetUserExtendedInternal_outParamCount) = await FuncActionSendEmailSupplier_FolioInvoiceRejected.datasetGetUserExtendedInternal(requestContext,datasetGetUserExtendedInternal_maxRecords,datasetGetUserExtendedInternal_startIndex,IterationMultiplicity.Never,localVars.queryResGetApprovers_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovedBy,cancellationToken);

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

// Query datasetGetUsersProveedores
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersProveedores_maxRecords = 0;
int datasetGetUsersProveedores_startIndex = 0;(localVars.queryResGetUsersProveedores_outParamList,localVars.queryResGetUsersProveedores_outParamCount) = await FuncActionSendEmailSupplier_FolioInvoiceRejected.datasetGetUsersProveedores(requestContext,datasetGetUsersProveedores_maxRecords,datasetGetUsersProveedores_startIndex,IterationMultiplicity.Single,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssSupplierId,cancellationToken);

// Foreach GetUsersProveedores.List
localVars.queryResGetUsersProveedores_outParamList.StartIteration();
try {while (!((localVars.queryResGetUsersProveedores_outParamList.Eof))) {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,(await RecordUtils.ConvertAsync(localVars.queryResGetUsersProveedores_outParamList.CurrentRec, new ST_12668886130225cd5b17c72a6562dd7cStructure(), async (RC_60b2ce7251b451294681274f8057cbd6 source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = localVars.queryResGetUsersProveedores_outParamList.CurrentRec.ssENUser.ssId;
target.ssEmail = localVars.queryResGetUsersProveedores_outParamList.CurrentRec.ssENUser.ssEmail;
target.ssName = localVars.queryResGetUsersProveedores_outParamList.CurrentRec.ssENUser.ssName;
target.ssEmailTo = localVars.queryResGetUsersProveedores_outParamList.CurrentRec.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetUsersProveedores_outParamList.Advance();
}

} finally {
localVars.queryResGetUsersProveedores_outParamList.EndIteration();
}

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",0,(("Folios - Folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" factura rechazada"),(("La factura del Folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+"  acaba de ser rechazada."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("FolioInvoiceRejected", "004165ea-0fdd-45fc-95f9-9a98263b4ef5"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("FolioInvoiceRejected", "004165ea-0fdd-45fc-95f9-9a98263b4ef5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_FolioInvoiceRejected>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, localVars.inParami_RejectMotive, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionSendEmailSupplier_FolioInvoiceRejected {

private static async Task<RC_77e758d8dd6b0d691548b18323e10e77> datasetGetFolioByIdReadDbAsync(RC_77e758d8dd6b0d691548b18323e10e77 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" ht0FjYKc4UO0WB0I4di4bA of Action "SendEmailSupplier_FolioInvoiceRejected"
public static async Task<(RL_2b9a8ce7bf73dacd0e0e114719f57b83,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailSupplier_FolioInvoiceRejected.GetFolioById", "8d05dd86-9c82-43e1-b458-1d08e1d8b86c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailSupplier_FolioInvoiceRejected.GetFolioById", "8d05dd86-9c82-43e1-b458-1d08e1d8b86c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.r+3KgmLE5k+gEaUusapPtg/NodesNotShownInESpaceTree.ht0FjYKc4UO0WB0I4di4bA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio28\".\"folionumber\" o2, NULL o3, NULL o4, \"enfolio28\".\"supplierid\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enfolio28\".\"approvalprocesstypeid\" o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM ({Folio} \"enfolio28\" Left JOIN {FolioSAPData} \"enfoliosapdata5\" ON (\"enfolio28\".\"id\" = \"enfoliosapdata5\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio28\".\"id\" = @qpfoFolio_Id) AND (\"enfolio28\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio28\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, false, true, true, true, true, true, true, true, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailSupplier_FolioInvoiceRejected.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailSupplier_FolioInvoiceRejected.GetFolioById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetApproversReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovers" ZQJnn4OEOkiosrRQnEfxug of Action "SendEmailSupplier_FolioInvoiceRejected"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetApprovers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpapApprovalProcessTypeId,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailSupplier_FolioInvoiceRejected.GetApprovers", "9f670265-8483-483a-a8b2-b4509c47f1ba");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailSupplier_FolioInvoiceRejected.GetApprovers", "9f670265-8483-483a-a8b2-b4509c47f1ba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.r+3KgmLE5k+gEaUusapPtg/NodesNotShownInESpaceTree.ZQJnn4OEOkiosrRQnEfxug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enfolioapprovallevel14\".\"approvedby\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval15\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel14\" ON (\"enfolioapproval15\".\"id\" = \"enfolioapprovallevel14\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval15\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval15\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval15\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel14\".\"approvedby\" IS NOT NULL) AND ((CASE WHEN ");
if (qpapApprovalProcessTypeId != 0) {
whereBuilder.Append("((");
whereBuilder.Append(1
);
whereBuilder.Append(" = @qpapApprovalProcessTypeId) AND (");
whereBuilder.Append(1
);
whereBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcessTypeId", DbType.Int32, qpapApprovalProcessTypeId);
} else {
whereBuilder.Append("(");
whereBuilder.Append(1
);
whereBuilder.Append(" IS NULL)");
}
whereBuilder.Append(" THEN \"enfolioapprovallevel14\".\"isinvoiceapproval\" ELSE 1 END) = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailSupplier_FolioInvoiceRejected.GetApprovers.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailSupplier_FolioInvoiceRejected.GetApprovers.List", cancellationToken: cancellationToken);
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

private static async Task<RC_60b2ce7251b451294681274f8057cbd6> datasetGetUsersProveedoresReadDbAsync(RC_60b2ce7251b451294681274f8057cbd6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSupplierUser.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUsersProveedores" Ka0Lv2hS3Ua7G7CDQivfqg of Action "SendEmailSupplier_FolioInvoiceRejected"
public static async Task<(RL_519cfbd5c9d3e969a6c55ad5a0702da1,long)> datasetGetUsersProveedores(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplierUser_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailSupplier_FolioInvoiceRejected.GetUsersProveedores", "bf0bad29-5268-46dd-bb1b-b083422bdfaa");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailSupplier_FolioInvoiceRejected.GetUsersProveedores", "bf0bad29-5268-46dd-bb1b-b083422bdfaa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.r+3KgmLE5k+gEaUusapPtg/NodesNotShownInESpaceTree.Ka0Lv2hS3Ua7G7CDQivfqg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplieruser9\".\"id\" o0, \"ensupplieruser9\".\"supplierid\" o1, \"ensupplieruser9\".\"userid\" o2, \"ensupplieruser9\".\"name\" o3, \"ensupplieruser9\".\"email\" o4, \"ensupplieruser9\".\"activationemailsentdate\" o5, \"ensupplieruser9\".\"isactive\" o6, \"ensupplieruser9\".\"isdeleted\" o7, \"ensupplieruser9\".\"isblocked\" o8, \"ensupplieruser9\".\"blockeduntil\" o9, \"ensupplieruser9\".\"lastlogindate\" o10, \"ensupplieruser9\".\"createdby\" o11, \"ensupplieruser9\".\"createdon\" o12, \"ensupplieruser9\".\"updatedby\" o13, \"ensupplieruser9\".\"updatedon\" o14, \"enuser82\".\"id\" o15, \"enuser82\".\"name\" o16, \"enuser82\".\"email\" o17, \"enuser82\".\"photourl\" o18, \"enuser82\".\"username\" o19, \"enuserextension42\".\"id\" o20, \"enuserextension42\".\"correspondentexternalemail\" o21, \"enuserextension42\".\"emailto\" o22");
fromBuilder.Append(" FROM (({User} \"enuser82\" Left JOIN {UserExtension} \"enuserextension42\" ON (\"enuser82\".\"id\" = \"enuserextension42\".\"id\"))  Left JOIN {SupplierUser} \"ensupplieruser9\" ON (\"enuser82\".\"id\" = \"ensupplieruser9\".\"userid\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierUser_SupplierId != 0) {
whereBuilder.Append("((\"ensupplieruser9\".\"supplierid\" = @qpsuSupplierUser_SupplierId) AND (\"ensupplieruser9\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierUser_SupplierId", DbType.Int64, qpsuSupplierUser_SupplierId);
} else {
whereBuilder.Append("(\"ensupplieruser9\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"ensupplieruser9\".\"isactive\" = 1)");
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
RL_519cfbd5c9d3e969a6c55ad5a0702da1 outParamList = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersProveedoresReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailSupplier_FolioInvoiceRejected.GetUsersProveedores.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_519cfbd5c9d3e969a6c55ad5a0702da1 _tmp = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersProveedoresReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailSupplier_FolioInvoiceRejected.GetUsersProveedores.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_519cfbd5c9d3e969a6c55ad5a0702da1)_tmp;
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
// Query Function "GetUserExtendedInternal" hK_5w8MqEUKt26piHebNjg of Action "SendEmailSupplier_FolioInvoiceRejected"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserExtendedInternal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailSupplier_FolioInvoiceRejected.GetUserExtendedInternal", "c3f9af84-2ac3-4211-addb-aa621de6cd8e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailSupplier_FolioInvoiceRejected.GetUserExtendedInternal", "c3f9af84-2ac3-4211-addb-aa621de6cd8e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.r+3KgmLE5k+gEaUusapPtg/NodesNotShownInESpaceTree.hK_5w8MqEUKt26piHebNjg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser83\".\"id\" o0, \"enuser83\".\"name\" o1, \"enuser83\".\"email\" o2, \"enuser83\".\"photourl\" o3, \"enuser83\".\"username\" o4, \"enuserextension43\".\"id\" o5, \"enuserextension43\".\"correspondentexternalemail\" o6, \"enuserextension43\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser83\" Left JOIN {UserExtension} \"enuserextension43\" ON (\"enuser83\".\"id\" = \"enuserextension43\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser83\".\"id\" = @qpusUser_Id) AND (\"enuser83\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser83\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailSupplier_FolioInvoiceRejected.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailSupplier_FolioInvoiceRejected.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
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



}


}
