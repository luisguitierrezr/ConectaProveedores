namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendReqRequestToModifyEmails : VarsBag {
public long inParami_RequisitionId;
public string inParami_ModifyReason;
public string inParami_UserRequestedModification;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_17106260236c729f86b4f7919e212d21 queryResGetRequisitionApprovers_outParamList = new RL_17106260236c729f86b4f7919e212d21();
public long queryResGetRequisitionApprovers_outParamCount = 0L;

public RL_3e9501626d68e0b595764f7f1bae2fae queryResGetUserRequestedModificationById_outParamList = new RL_3e9501626d68e0b595764f7f1bae2fae();
public long queryResGetUserRequestedModificationById_outParamCount = 0L;

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserExtendedInternalApplicant_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserExtendedInternalApplicant_outParamCount = 0L;

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserExtendedInternal_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserExtendedInternal_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_0ad79b64673379e41188da81c3628c0f queryResGetRequisitionById_outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
public long queryResGetRequisitionById_outParamCount = 0L;

public lcvSendReqRequestToModifyEmails(long inParami_RequisitionId, string inParami_ModifyReason, string inParami_UserRequestedModification) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_ModifyReason = inParami_ModifyReason;
this.inParami_UserRequestedModification = inParami_UserRequestedModification;
}
}
/// <summary>
/// Action <code>SendReqRequestToModifyEmails</code> that represents the Service Studio action
///  <code>SendReqRequestToModifyEmails</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendReqRequestToModifyEmails(IRequestContext requestContext,long inParami_RequisitionId,string inParami_ModifyReason,string inParami_UserRequestedModification,CancellationToken cancellationToken) {
lcvSendReqRequestToModifyEmails localVars = new lcvSendReqRequestToModifyEmails(inParami_RequisitionId, inParami_ModifyReason, inParami_UserRequestedModification);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendReqRequestToModifyEmails", "b5ebf5a5-81d5-4399-87cd-e54bdbe77bd3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendReqRequestToModifyEmails", "b5ebf5a5-81d5-4399-87cd-e54bdbe77bd3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionSendReqRequestToModifyEmails.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetUserExtendedInternalApplicant
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalApplicant_maxRecords = 1;
if (datasetGetUserExtendedInternalApplicant_maxRecords < 1) datasetGetUserExtendedInternalApplicant_maxRecords = 1;
int datasetGetUserExtendedInternalApplicant_startIndex = 0;(localVars.queryResGetUserExtendedInternalApplicant_outParamList,localVars.queryResGetUserExtendedInternalApplicant_outParamCount) = await FuncActionSendReqRequestToModifyEmails.datasetGetUserExtendedInternalApplicant(requestContext,datasetGetUserExtendedInternalApplicant_maxRecords,datasetGetUserExtendedInternalApplicant_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssApplicantId,cancellationToken);

// ListAppendApplicantId
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,(await RecordUtils.ConvertAsync(localVars.queryResGetUserExtendedInternalApplicant_outParamList.CurrentRec, new ST_12668886130225cd5b17c72a6562dd7cStructure(), async (RC_e6a121d9e10463243528b9fbc6a71f2e source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUser.ssId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
target.ssEmailTo = source.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

// Query datasetGetRequisitionApprovers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovers_maxRecords = 0;
int datasetGetRequisitionApprovers_startIndex = 0;(localVars.queryResGetRequisitionApprovers_outParamList,localVars.queryResGetRequisitionApprovers_outParamCount) = await FuncActionSendReqRequestToModifyEmails.datasetGetRequisitionApprovers(requestContext,datasetGetRequisitionApprovers_maxRecords,datasetGetRequisitionApprovers_startIndex,IterationMultiplicity.Single,localVars.inParami_RequisitionId,cancellationToken);

// Foreach GetRequisitionApprovers.List
localVars.queryResGetRequisitionApprovers_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionApprovers_outParamList.Eof))) {
// Query datasetGetUserExtendedInternal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternal_maxRecords = 1;
if (datasetGetUserExtendedInternal_maxRecords < 1) datasetGetUserExtendedInternal_maxRecords = 1;
int datasetGetUserExtendedInternal_startIndex = 0;(localVars.queryResGetUserExtendedInternal_outParamList,localVars.queryResGetUserExtendedInternal_outParamCount) = await FuncActionSendReqRequestToModifyEmails.datasetGetUserExtendedInternal(requestContext,datasetGetUserExtendedInternal_maxRecords,datasetGetUserExtendedInternal_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionApprovers_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedBy,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,(await RecordUtils.ConvertAsync(localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec, new ST_12668886130225cd5b17c72a6562dd7cStructure(), async (RC_e6a121d9e10463243528b9fbc6a71f2e source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssId;
target.ssEmail = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssEmail;
target.ssName = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssName;
target.ssEmailTo = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetRequisitionApprovers_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionApprovers_outParamList.EndIteration();
}

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// Query datasetGetUserRequestedModificationById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserRequestedModificationById_maxRecords = 1;
if (datasetGetUserRequestedModificationById_maxRecords < 1) datasetGetUserRequestedModificationById_maxRecords = 1;
int datasetGetUserRequestedModificationById_startIndex = 0;(localVars.queryResGetUserRequestedModificationById_outParamList,localVars.queryResGetUserRequestedModificationById_outParamCount) = await FuncActionSendReqRequestToModifyEmails.datasetGetUserRequestedModificationById(requestContext,datasetGetUserRequestedModificationById_maxRecords,datasetGetUserRequestedModificationById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserRequestedModification,cancellationToken);

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",1,("Requisiciones - Pedido de Modificación de la Requisición "+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName),(((((("La requisición "+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName)+" recibió un pedido de modificación por :")+localVars.queryResGetUserRequestedModificationById_outParamList.CurrentRec.ssName)+"\r\n")+"\r\n")+localVars.inParami_ModifyReason),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ModifyRequisition", "cee7ff6a-3a5d-4771-ad3a-e4d7aa733802"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ModifyRequisition", "cee7ff6a-3a5d-4771-ad3a-e4d7aa733802", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowc_Req_Emails.c_Req_Emails_ModifyRequisition>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName, localVars.varLcl_EmailNotification.CurrentRec.ssName, localVars.inParami_ModifyReason, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetUserRequestedModificationById_outParamList.CurrentRec.ssName, (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", cancellationToken),
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

public static class FuncActionSendReqRequestToModifyEmails {

private static async Task<RC_7a202946b9c9ade4fc5b7dc7c07f3279> datasetGetRequisitionApproversReadDbAsync(RC_7a202946b9c9ade4fc5b7dc7c07f3279 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovers" _9w1Da5h8kCXfZphPDxUlg of Action "SendReqRequestToModifyEmails"
public static async Task<(RL_17106260236c729f86b4f7919e212d21,long)> datasetGetRequisitionApprovers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendReqRequestToModifyEmails.GetRequisitionApprovers", "0d35dcff-61ae-40f2-977d-9a613c3c5496");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendReqRequestToModifyEmails.GetRequisitionApprovers", "0d35dcff-61ae-40f2-977d-9a613c3c5496", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pfXrtdWBmUOHzeVL2+d70w/NodesNotShownInESpaceTree._9w1Da5h8kCXfZphPDxUlg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enrequisitionapprovallevel13\".\"approvedby\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35");
fromBuilder.Append(" FROM ({RequisitionApproval} \"enrequisitionapproval15\" Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel13\" ON (\"enrequisitionapproval15\".\"id\" = \"enrequisitionapprovallevel13\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval15\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval15\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval15\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel13\".\"approvedby\" IS NOT NULL)");
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
RL_17106260236c729f86b4f7919e212d21 outParamList = new RL_17106260236c729f86b4f7919e212d21();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApproversReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendReqRequestToModifyEmails.GetRequisitionApprovers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_17106260236c729f86b4f7919e212d21 _tmp = new RL_17106260236c729f86b4f7919e212d21();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApproversReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendReqRequestToModifyEmails.GetRequisitionApprovers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_17106260236c729f86b4f7919e212d21)_tmp;
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

// Query Function "GetUserRequestedModificationById" ujhpLrKMNkeJa0sOo22owQ of Action "SendReqRequestToModifyEmails"
public static async Task<(RL_3e9501626d68e0b595764f7f1bae2fae,long)> datasetGetUserRequestedModificationById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendReqRequestToModifyEmails.GetUserRequestedModificationById", "2e6938ba-8cb2-4736-896b-4b0ea36da8c1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendReqRequestToModifyEmails.GetUserRequestedModificationById", "2e6938ba-8cb2-4736-896b-4b0ea36da8c1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pfXrtdWBmUOHzeVL2+d70w/NodesNotShownInESpaceTree.ujhpLrKMNkeJa0sOo22owQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser102\".\"name\" \"name\"");
fromBuilder.Append(" FROM {User} \"enuser102\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser102\".\"id\" = @qpusId) AND (\"enuser102\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser102\".\"id\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enuser102\".\"name\"");
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
RL_3e9501626d68e0b595764f7f1bae2fae outParamList = new RL_3e9501626d68e0b595764f7f1bae2fae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendReqRequestToModifyEmails.GetUserRequestedModificationById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3e9501626d68e0b595764f7f1bae2fae _tmp = new RL_3e9501626d68e0b595764f7f1bae2fae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendReqRequestToModifyEmails.GetUserRequestedModificationById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3e9501626d68e0b595764f7f1bae2fae)_tmp;
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

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserExtendedInternalApplicantReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalApplicant" kJLHUAnxdkayaRf9+tlnQw of Action "SendReqRequestToModifyEmails"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserExtendedInternalApplicant(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendReqRequestToModifyEmails.GetUserExtendedInternalApplicant", "50c79290-f109-4676-b269-17fdfad96743");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendReqRequestToModifyEmails.GetUserExtendedInternalApplicant", "50c79290-f109-4676-b269-17fdfad96743", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pfXrtdWBmUOHzeVL2+d70w/NodesNotShownInESpaceTree.kJLHUAnxdkayaRf9+tlnQw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser103\".\"id\" o0, \"enuser103\".\"name\" o1, \"enuser103\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuserextension47\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser103\" Left JOIN {UserExtension} \"enuserextension47\" ON (\"enuser103\".\"id\" = \"enuserextension47\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser103\".\"id\" = @qpusUser_Id) AND (\"enuser103\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser103\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalApplicantReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendReqRequestToModifyEmails.GetUserExtendedInternalApplicant.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalApplicantReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendReqRequestToModifyEmails.GetUserExtendedInternalApplicant.List", cancellationToken: cancellationToken);
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

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserExtendedInternalReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternal" uLtCWikx4EySRSIZj8J3wQ of Action "SendReqRequestToModifyEmails"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserExtendedInternal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendReqRequestToModifyEmails.GetUserExtendedInternal", "5a42bbb8-3129-4ce0-9245-22198fc277c1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendReqRequestToModifyEmails.GetUserExtendedInternal", "5a42bbb8-3129-4ce0-9245-22198fc277c1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pfXrtdWBmUOHzeVL2+d70w/NodesNotShownInESpaceTree.uLtCWikx4EySRSIZj8J3wQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser104\".\"id\" o0, \"enuser104\".\"name\" o1, \"enuser104\".\"email\" o2, \"enuser104\".\"photourl\" o3, \"enuser104\".\"username\" o4, \"enuserextension48\".\"id\" o5, \"enuserextension48\".\"correspondentexternalemail\" o6, \"enuserextension48\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser104\" Left JOIN {UserExtension} \"enuserextension48\" ON (\"enuser104\".\"id\" = \"enuserextension48\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser104\".\"id\" = @qpusUser_Id) AND (\"enuser104\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser104\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendReqRequestToModifyEmails.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendReqRequestToModifyEmails.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
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

// Query Function "GetRequisitionById" SFRf3ZBkQUGucgQXufayXA of Action "SendReqRequestToModifyEmails"
public static async Task<(RL_0ad79b64673379e41188da81c3628c0f,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendReqRequestToModifyEmails.GetRequisitionById", "dd5f5448-6490-4141-ae72-0417b9f6b25c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendReqRequestToModifyEmails.GetRequisitionById", "dd5f5448-6490-4141-ae72-0417b9f6b25c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pfXrtdWBmUOHzeVL2+d70w/NodesNotShownInESpaceTree.SFRf3ZBkQUGucgQXufayXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enrequisition49\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enrequisition49\".\"applicantid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57");
fromBuilder.Append(" FROM {Requisition} \"enrequisition49\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enrequisition49\".\"id\" = @qpreId) AND (\"enrequisition49\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enrequisition49\".\"id\" IS NULL)");
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
RL_0ad79b64673379e41188da81c3628c0f outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendReqRequestToModifyEmails.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0ad79b64673379e41188da81c3628c0f _tmp = new RL_0ad79b64673379e41188da81c3628c0f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendReqRequestToModifyEmails.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0ad79b64673379e41188da81c3628c0f)_tmp;
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
