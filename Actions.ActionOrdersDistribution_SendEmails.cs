namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersDistribution_SendEmails : VarsBag {
public long inParamOrderMainId;
/// <summary>
/// Variable <code>UsersList</code> that represents the Service Studio UserIdEmailUserNameRecordList
///  <code>UsersList</code> <p>Description: </p>
/// </summary>
public RL_b6937d33871d635163e2cf0ad043c360 varLcUsersList = new RL_b6937d33871d635163e2cf0ad043c360();

public Actions.lcoOrdersImport_RequestUpdateStatus resOrdersImport_RequestUpdateStatus =  new Actions.lcoOrdersImport_RequestUpdateStatus();
public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_b6937d33871d635163e2cf0ad043c360 resListDistinct_outParamDistinctList = new RL_b6937d33871d635163e2cf0ad043c360();

public RL_586f7fa2a94434b7f9ecfc7c44eb315b queryResGetOrdersImportRequests_outParamList = new RL_586f7fa2a94434b7f9ecfc7c44eb315b();
public long queryResGetOrdersImportRequests_outParamCount = 0L;

public RL_752c66ffcb633a1081093541635464e7 queryResGetUserExtendedInternalsByEntraRoleId_outParamList = new RL_752c66ffcb633a1081093541635464e7();
public long queryResGetUserExtendedInternalsByEntraRoleId_outParamCount = 0L;

public lcvOrdersDistribution_SendEmails(long inParamOrderMainId) {
this.inParamOrderMainId = inParamOrderMainId;
}
}
/// <summary>
/// Action <code>OrdersDistribution_SendEmails</code> that represents the Service Studio action
///  <code>OrdersDistribution_SendEmails</code> <p> Description: </p>
/// </summary>
public static async Task ActionOrdersDistribution_SendEmails(IRequestContext requestContext,long inParamOrderMainId,CancellationToken cancellationToken) {
lcvOrdersDistribution_SendEmails localVars = new lcvOrdersDistribution_SendEmails(inParamOrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersDistribution_SendEmails", "55c59134-c92e-45b1-b0c6-018c888038cd"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersDistribution_SendEmails", "55c59134-c92e-45b1-b0c6-018c888038cd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrdersImportRequests
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrdersImportRequests_maxRecords = 0;
int datasetGetOrdersImportRequests_startIndex = 0;(localVars.queryResGetOrdersImportRequests_outParamList,localVars.queryResGetOrdersImportRequests_outParamCount) = await FuncActionOrdersDistribution_SendEmails.datasetGetOrdersImportRequests(requestContext,datasetGetOrdersImportRequests_maxRecords,datasetGetOrdersImportRequests_startIndex,IterationMultiplicity.Multiple,localVars.inParamOrderMainId,cancellationToken);

// send email
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSendEmailsOrderDistrib]))))) {
// Foreach GetOrdersImportRequests.List
localVars.queryResGetOrdersImportRequests_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrdersImportRequests_outParamList.Eof))) {
// Query datasetGetUserExtendedInternalsByEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalsByEntraRoleId_maxRecords = 0;
int datasetGetUserExtendedInternalsByEntraRoleId_startIndex = 0;(localVars.queryResGetUserExtendedInternalsByEntraRoleId_outParamList,localVars.queryResGetUserExtendedInternalsByEntraRoleId_outParamCount) = await FuncActionOrdersDistribution_SendEmails.datasetGetUserExtendedInternalsByEntraRoleId(requestContext,datasetGetUserExtendedInternalsByEntraRoleId_maxRecords,datasetGetUserExtendedInternalsByEntraRoleId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetOrdersImportRequests_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcUsersList,(await RL_b6937d33871d635163e2cf0ad043c360.ConvertAsync(localVars.queryResGetUserExtendedInternalsByEntraRoleId_outParamList, new RL_b6937d33871d635163e2cf0ad043c360(), async (RC_34272dae45b4de5e1332f46c6e8700b9 source, RC_3cb5faf855470afd6e46669ad1a86a21 target, CancellationToken cancellationToken) => {
target.ssEmail = source.ssENUser.ssEmail;
target.ssUserId = source.ssENUser.ssId;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetOrdersImportRequests_outParamList.Advance();
}

} finally {
localVars.queryResGetOrdersImportRequests_outParamList.EndIteration();
}

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_b6937d33871d635163e2cf0ad043c360) localVars.varLcUsersList.Distinct()));

// ControledLogMessage2
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("OrdersDistribution_SendEmails » "+((localVars.resListDistinct_outParamDistinctList.Empty) ? (AppUtils.GetStringResource("_2VuS3TNaku_aPaANU+hrg#Value.740254501.1", "Nobody found to send emails")) : ((((((AppUtils.GetStringResource("_2VuS3TNaku_aPaANU+hrg#Value.-650460685.1", "Send to")+" ")+BuiltInFunction.IntegerToText (localVars.resListDistinct_outParamDistinctList.Length))+" ")+AppUtils.GetStringResource("_2VuS3TNaku_aPaANU+hrg#Value.874544034.1", "addresses"))+".")))),"OrdersDistribution_SendEmails",cancellationToken);

// Foreach ListDistinct.DistinctList
localVars.resListDistinct_outParamDistinctList.StartIteration();
try {while (!((localVars.resListDistinct_outParamDistinctList.Eof))) {
// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("OrdersDistribution_SendEmails » Email Sent to: "+localVars.resListDistinct_outParamDistinctList.CurrentRec.ssEmail),"OrdersDistribution_SendEmails",cancellationToken);

// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.resListDistinct_outParamDistinctList.CurrentRec.ssUserId })),"",0,"Nuevos pedidos distribuidos","Se han registrado nuevos pedidos en la plataforma y requieren tu revisión.",cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.resListDistinct_outParamDistinctList.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("OrderDestributionNotification", "ee2d7d8e-29f1-48c3-9e9a-b14f1fb8dd68"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("OrderDestributionNotification", "ee2d7d8e-29f1-48c3-9e9a-b14f1fb8dd68", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowh_OrderDistribution_Emails.h_OrderDistribution_Emails_OrderDestributionNotification>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , BuiltInFunction.GetAppName (), localVars.resListDistinct_outParamDistinctList.CurrentRec.ssUserName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.resListDistinct_outParamDistinctList.CurrentRec.ssEmail, "", cancellationToken),
        To = (((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.resListDistinct_outParamDistinctList.CurrentRec.ssEmail)),
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
localVars.resListDistinct_outParamDistinctList.Advance();
}

} finally {
localVars.resListDistinct_outParamDistinctList.EndIteration();
}

} else {
// dummy
}

// Foreach GetOrdersImportRequests.List
localVars.queryResGetOrdersImportRequests_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrdersImportRequests_outParamList.Eof))) {
// OrdersImport_RequestUpdateStatus
localVars.resOrdersImport_RequestUpdateStatus.outParamResult = await Actions.ActionOrdersImport_RequestUpdateStatus(requestContext,localVars.queryResGetOrdersImportRequests_outParamList.CurrentRec.ssENOrdersImportRequest.ssId,(ENImportStatusEntity.GetRecordByKey(ObjectKey.Parse("RuCeyUnezECw7Jj4dcCBmA"))).ssId,cancellationToken);

localVars.queryResGetOrdersImportRequests_outParamList.Advance();
}

} finally {
localVars.queryResGetOrdersImportRequests_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrdersDistribution_SendEmails {

private static async Task<RC_89706669e1ea39d5a8170d632a3a45dc> datasetGetOrdersImportRequestsReadDbAsync(RC_89706669e1ea39d5a8170d632a3a45dc rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrdersImportRequest.Read( r, ref index);
return rec;
}
// Query Function "GetOrdersImportRequests" t81t5lFHgUO+dJmF4c7r3g of Action "OrdersDistribution_SendEmails"
public static async Task<(RL_586f7fa2a94434b7f9ecfc7c44eb315b,long)> datasetGetOrdersImportRequests(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrdersImportRequest_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersDistribution_SendEmails.GetOrdersImportRequests", "e66dcdb7-4751-4381-be74-9985e1ceebde");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersDistribution_SendEmails.GetOrdersImportRequests", "e66dcdb7-4751-4381-be74-9985e1ceebde", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.NJHFVS7JsUWwxgGMiIA4zQ/NodesNotShownInESpaceTree.t81t5lFHgUO+dJmF4c7r3g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enorderapprovallevel6\".\"entraroleid\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"enordersimportrequest3\".\"id\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM (({OrdersImportRequest} \"enordersimportrequest3\" Inner JOIN {OrderApproval} \"enorderapproval6\" ON (\"enordersimportrequest3\".\"ordermainid\" = \"enorderapproval6\".\"orderid\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel6\" ON ((\"enorderapproval6\".\"id\" = \"enorderapprovallevel6\".\"orderapprovalid\") AND (\"enorderapprovallevel6\".\"levelnumber\" = 1))) ");
whereBuilder.Append(" WHERE ((\"enordersimportrequest3\".\"status\" = ");
whereBuilder.Append((ENImportStatusEntity.GetRecordByKey(ObjectKey.Parse("071tbgS1KEa8CNmBFtu49g"))).ssId);
whereBuilder.Append(") OR ");
if (qporOrdersImportRequest_OrderMainId != 0) {
whereBuilder.Append("((\"enordersimportrequest3\".\"ordermainid\" = @qporOrdersImportRequest_OrderMainId) AND (\"enordersimportrequest3\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrdersImportRequest_OrderMainId", DbType.Int64, qporOrdersImportRequest_OrderMainId);
} else {
whereBuilder.Append("(\"enordersimportrequest3\".\"ordermainid\" IS NULL)");
}
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
RL_586f7fa2a94434b7f9ecfc7c44eb315b outParamList = new RL_586f7fa2a94434b7f9ecfc7c44eb315b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersImportRequestsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersDistribution_SendEmails.GetOrdersImportRequests.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_586f7fa2a94434b7f9ecfc7c44eb315b _tmp = new RL_586f7fa2a94434b7f9ecfc7c44eb315b();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersImportRequestsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersDistribution_SendEmails.GetOrdersImportRequests.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_586f7fa2a94434b7f9ecfc7c44eb315b)_tmp;
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

private static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> datasetGetUserExtendedInternalsByEntraRoleIdReadDbAsync(RC_34272dae45b4de5e1332f46c6e8700b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalsByEntraRoleId" ZODK+D3320SkX+hCNSOspg of Action "OrdersDistribution_SendEmails"
public static async Task<(RL_752c66ffcb633a1081093541635464e7,long)> datasetGetUserExtendedInternalsByEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenUser_Extended_Internal_EntraRoleId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersDistribution_SendEmails.GetUserExtendedInternalsByEntraRoleId", "f8cae064-f73d-44db-a45f-e8423523aca6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersDistribution_SendEmails.GetUserExtendedInternalsByEntraRoleId", "f8cae064-f73d-44db-a45f-e8423523aca6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.NJHFVS7JsUWwxgGMiIA4zQ/NodesNotShownInESpaceTree.ZODK+D3320SkX+hCNSOspg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser59\".\"id\" o0, NULL o1, \"enuser59\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal35\" Inner JOIN {User} \"enuser59\" ON (\"enuser_extended_internal35\".\"id\" = \"enuser59\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpenUser_Extended_Internal_EntraRoleId != 0) {
whereBuilder.Append("((\"enuser_extended_internal35\".\"entraroleid\" = @qpenUser_Extended_Internal_EntraRoleId) AND (\"enuser_extended_internal35\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenUser_Extended_Internal_EntraRoleId", DbType.Int64, qpenUser_Extended_Internal_EntraRoleId);
} else {
whereBuilder.Append("(\"enuser_extended_internal35\".\"entraroleid\" IS NULL)");
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
RL_752c66ffcb633a1081093541635464e7 outParamList = new RL_752c66ffcb633a1081093541635464e7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByEntraRoleIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersDistribution_SendEmails.GetUserExtendedInternalsByEntraRoleId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_752c66ffcb633a1081093541635464e7 _tmp = new RL_752c66ffcb633a1081093541635464e7();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByEntraRoleIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersDistribution_SendEmails.GetUserExtendedInternalsByEntraRoleId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_752c66ffcb633a1081093541635464e7)_tmp;
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
