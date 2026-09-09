namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendOrderFirstApproverEmail : VarsBag {
public long inParami_OrderId;
public string inParamUserId;
public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_6d716f51b4f729d7294bc619c2474a13 queryResGetInCompletionOrderById_outParamList = new RL_6d716f51b4f729d7294bc619c2474a13();
public long queryResGetInCompletionOrderById_outParamCount = 0L;

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetSubmissionUserById_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetSubmissionUserById_outParamCount = 0L;

public lcvSendOrderFirstApproverEmail(long inParami_OrderId, string inParamUserId) {
this.inParami_OrderId = inParami_OrderId;
this.inParamUserId = inParamUserId;
}
}
/// <summary>
/// Action <code>SendOrderFirstApproverEmail</code> that represents the Service Studio action
///  <code>SendOrderFirstApproverEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendOrderFirstApproverEmail(IRequestContext requestContext,long inParami_OrderId,string inParamUserId,CancellationToken cancellationToken) {
lcvSendOrderFirstApproverEmail localVars = new lcvSendOrderFirstApproverEmail(inParami_OrderId, inParamUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendOrderFirstApproverEmail", "f44211d7-6d06-4013-a917-f85be8d483c2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendOrderFirstApproverEmail", "f44211d7-6d06-4013-a917-f85be8d483c2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetInCompletionOrderById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInCompletionOrderById_maxRecords = 1;
if (datasetGetInCompletionOrderById_maxRecords < 1) datasetGetInCompletionOrderById_maxRecords = 1;
int datasetGetInCompletionOrderById_startIndex = 0;(localVars.queryResGetInCompletionOrderById_outParamList,localVars.queryResGetInCompletionOrderById_outParamCount) = await FuncActionSendOrderFirstApproverEmail.datasetGetInCompletionOrderById(requestContext,datasetGetInCompletionOrderById_maxRecords,datasetGetInCompletionOrderById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// Query datasetGetSubmissionUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSubmissionUserById_maxRecords = 1;
if (datasetGetSubmissionUserById_maxRecords < 1) datasetGetSubmissionUserById_maxRecords = 1;
int datasetGetSubmissionUserById_startIndex = 0;(localVars.queryResGetSubmissionUserById_outParamList,localVars.queryResGetSubmissionUserById_outParamCount) = await FuncActionSendOrderFirstApproverEmail.datasetGetSubmissionUserById(requestContext,datasetGetSubmissionUserById_maxRecords,datasetGetSubmissionUserById_startIndex,IterationMultiplicity.Never,localVars.inParamUserId,cancellationToken);

// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUser.ssId })),"",1,("Pedidos - Pedido Complementado "+localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber),(((("El pedido "+localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" acaba de ser conplementado por ")+localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUser.ssName)+" y está esperando su aprobación."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUser.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("FirstApproverOrder", "0a1721a3-46c8-4d63-99fb-048fd9389dc7"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("FirstApproverOrder", "0a1721a3-46c8-4d63-99fb-048fd9389dc7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowe_Orders_Emails.e_Orders_Emails_FirstApproverOrder>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUser.ssEmail) : ((((localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUserExtension.ssEmailto!="")) ? (localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUserExtension.ssEmailto) : (localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUser.ssEmail)))), localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber, localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUser.ssName, localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUser.ssName, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUser.ssEmail) : ((((localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUserExtension.ssEmailto!="")) ? (localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUserExtension.ssEmailto) : (localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUser.ssEmail)))), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUser.ssEmail) : ((((localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUserExtension.ssEmailto!="")) ? (localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUserExtension.ssEmailto) : (localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUser.ssEmail)))), (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? ((((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUser.ssEmail))) : ((((localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUserExtension.ssEmailto!="")) ? (localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUserExtension.ssEmailto) : (localVars.queryResGetInCompletionOrderById_outParamList.CurrentRec.ssENUser.ssEmail)))),
        From = "",
        Cc = (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUser.ssEmail) : ((((localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUserExtension.ssEmailto!="")) ? (localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUserExtension.ssEmailto) : (localVars.queryResGetSubmissionUserById_outParamList.CurrentRec.ssENUser.ssEmail)))),
        Bcc = "",
        Subject = string.Empty,
        Headers = new List<string>(),
        Attachments = mappedAttachments,
        ExtraImagesToAppend = emailScreen.ImagesToEmbed()
    };

    await OutSystems.Application.Core.Email.EmailService.Instance.SendEmailAsync(message, sendEmailActivity, cancellationToken);
}
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

public static class FuncActionSendOrderFirstApproverEmail {

private static async Task<RC_bddd91a3bdb44e007c54b330deac93eb> datasetGetInCompletionOrderByIdReadDbAsync(RC_bddd91a3bdb44e007c54b330deac93eb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetInCompletionOrderById" zT2Kvp+EJUO+2f0lVDRNoQ of Action "SendOrderFirstApproverEmail"
public static async Task<(RL_6d716f51b4f729d7294bc619c2474a13,long)> datasetGetInCompletionOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderFirstApproverEmail.GetInCompletionOrderById", "be8a3dcd-849f-4325-bed9-fd2554344da1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderFirstApproverEmail.GetInCompletionOrderById", "be8a3dcd-849f-4325-bed9-fd2554344da1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1xFC9AZtE0CpF_hb6NSDwg/NodesNotShownInESpaceTree.zT2Kvp+EJUO+2f0lVDRNoQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enordermain63\".\"ordernumber\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, \"enuser138\".\"id\" o54, \"enuser138\".\"name\" o55, \"enuser138\".\"email\" o56, NULL o57, NULL o58, NULL o59, NULL o60, \"enuserextension65\".\"emailto\" o61");
fromBuilder.Append(" FROM (((({OrderMain} \"enordermain63\" Left JOIN {OrderApproval} \"enorderapproval18\" ON (\"enordermain63\".\"id\" = \"enorderapproval18\".\"orderid\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel17\" ON (\"enorderapproval18\".\"id\" = \"enorderapprovallevel17\".\"orderapprovalid\"))  Left JOIN {User} \"enuser138\" ON (\"enorderapprovallevel17\".\"assignedto\" = \"enuser138\".\"id\"))  Left JOIN {UserExtension} \"enuserextension65\" ON (\"enuser138\".\"id\" = \"enuserextension65\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain63\".\"id\" = @qporOrderMain_Id) AND (\"enordermain63\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain63\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderapprovallevel17\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("2bH5k51Eqk+iM0PUO3cbyg"))).ssId);
whereBuilder.Append(")");
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
RL_6d716f51b4f729d7294bc619c2474a13 outParamList = new RL_6d716f51b4f729d7294bc619c2474a13();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInCompletionOrderByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderFirstApproverEmail.GetInCompletionOrderById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6d716f51b4f729d7294bc619c2474a13 _tmp = new RL_6d716f51b4f729d7294bc619c2474a13();
_tmp.AlternateReadDbMethodAsync = datasetGetInCompletionOrderByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderFirstApproverEmail.GetInCompletionOrderById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6d716f51b4f729d7294bc619c2474a13)_tmp;
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

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetSubmissionUserByIdReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetSubmissionUserById" NonH9Fq4M0WJzG7OHjMOIQ of Action "SendOrderFirstApproverEmail"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetSubmissionUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderFirstApproverEmail.GetSubmissionUserById", "f4c78936-b85a-4533-89cc-6ece1e330e21");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderFirstApproverEmail.GetSubmissionUserById", "f4c78936-b85a-4533-89cc-6ece1e330e21", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1xFC9AZtE0CpF_hb6NSDwg/NodesNotShownInESpaceTree.NonH9Fq4M0WJzG7OHjMOIQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser139\".\"name\" o1, \"enuser139\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuserextension66\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser139\" Left JOIN {UserExtension} \"enuserextension66\" ON (\"enuser139\".\"id\" = \"enuserextension66\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser139\".\"id\" = @qpusUser_Id) AND (\"enuser139\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser139\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetSubmissionUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderFirstApproverEmail.GetSubmissionUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetSubmissionUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderFirstApproverEmail.GetSubmissionUserById.List", cancellationToken: cancellationToken);
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
