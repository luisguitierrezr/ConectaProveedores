namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendOrdReqFileNextApproverEmail : VarsBag {
public long inParamOrderRequestFileId;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_248cdd7729c13fb50aed8d762c8fa086 queryResGetOrderRequestFileById_outParamList = new RL_248cdd7729c13fb50aed8d762c8fa086();
public long queryResGetOrderRequestFileById_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUserExtendedInternalAssignedTo_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUserExtendedInternalAssignedTo_outParamCount = 0L;

public lcvSendOrdReqFileNextApproverEmail(long inParamOrderRequestFileId) {
this.inParamOrderRequestFileId = inParamOrderRequestFileId;
}
}
/// <summary>
/// Action <code>SendOrdReqFileNextApproverEmail</code> that represents the Service Studio action
///  <code>SendOrdReqFileNextApproverEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendOrdReqFileNextApproverEmail(IRequestContext requestContext,long inParamOrderRequestFileId,CancellationToken cancellationToken) {
lcvSendOrdReqFileNextApproverEmail localVars = new lcvSendOrdReqFileNextApproverEmail(inParamOrderRequestFileId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendOrdReqFileNextApproverEmail", "35b4eac9-808c-4346-8049-f8b27a50e807"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendOrdReqFileNextApproverEmail", "35b4eac9-808c-4346-8049-f8b27a50e807", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderRequestFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRequestFileById_maxRecords = 0;
int datasetGetOrderRequestFileById_startIndex = 0;(localVars.queryResGetOrderRequestFileById_outParamList,localVars.queryResGetOrderRequestFileById_outParamCount) = await FuncActionSendOrdReqFileNextApproverEmail.datasetGetOrderRequestFileById(requestContext,datasetGetOrderRequestFileById_maxRecords,datasetGetOrderRequestFileById_startIndex,IterationMultiplicity.Never,localVars.inParamOrderRequestFileId,cancellationToken);

// Query datasetGetUserExtendedInternalAssignedTo
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalAssignedTo_maxRecords = 1;
if (datasetGetUserExtendedInternalAssignedTo_maxRecords < 1) datasetGetUserExtendedInternalAssignedTo_maxRecords = 1;
int datasetGetUserExtendedInternalAssignedTo_startIndex = 0;(localVars.queryResGetUserExtendedInternalAssignedTo_outParamList,localVars.queryResGetUserExtendedInternalAssignedTo_outParamCount) = await FuncActionSendOrdReqFileNextApproverEmail.datasetGetUserExtendedInternalAssignedTo(requestContext,datasetGetUserExtendedInternalAssignedTo_maxRecords,datasetGetUserExtendedInternalAssignedTo_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderRequestFileApprovalLevel.ssAssignedTo,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,new ST_12668886130225cd5b17c72a6562dd7cStructure(){ ssUserId = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssId, ssEmail = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssEmail, ssName = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssName, ssEmailTo = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUserExtension.ssEmailto },cancellationToken);

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification2
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",0,("Pedidos - Aprobar archivo "+localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderRequestFile.ssDescription),"Un archivo está esperando su aprobación.",cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("NextApproverOrderFile", "8017eaaa-22a0-48da-8dd6-50ea39b9e279"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("NextApproverOrderFile", "8017eaaa-22a0-48da-8dd6-50ea39b9e279", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowe_Orders_Emails.e_Orders_Emails_NextApproverOrderFile>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber, localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderRequestFile.ssDescription, localVars.varLcl_EmailNotification.CurrentRec.ssName, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = localVars.resMatchRecipientEmails.outParamResult,
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

public static class FuncActionSendOrdReqFileNextApproverEmail {

private static async Task<RC_c7df2d0e3d19438989bc28bf5440baf5> datasetGetOrderRequestFileByIdReadDbAsync(RC_c7df2d0e3d19438989bc28bf5440baf5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderRequestFile.Read( r, ref index);
rec.ssENOrderRequestFileApproval.Read( r, ref index);
rec.ssENOrderRequestFileApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetOrderRequestFileById" 6Bg7oNljFkON6Gd9G07JcQ of Action "SendOrdReqFileNextApproverEmail"
public static async Task<(RL_248cdd7729c13fb50aed8d762c8fa086,long)> datasetGetOrderRequestFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFile_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrdReqFileNextApproverEmail.GetOrderRequestFileById", "a03b18e8-63d9-4316-8de8-677d1b4ec971");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrdReqFileNextApproverEmail.GetOrderRequestFileById", "a03b18e8-63d9-4316-8de8-677d1b4ec971", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.yeq0NYyARkOASfiyelDoBw/NodesNotShownInESpaceTree.6Bg7oNljFkON6Gd9G07JcQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enordermain14\".\"ordernumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"enorderrequestfile1\".\"description\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, \"enorderrequestfileapprovallevel\".\"assignedto\" o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63");
fromBuilder.Append(" FROM ((({OrderRequestFile} \"enorderrequestfile1\" Inner JOIN {OrderMain} \"enordermain14\" ON (\"enorderrequestfile1\".\"orderid\" = \"enordermain14\".\"id\"))  Left JOIN {OrderRequestFileApproval} \"enorderrequestfileapproval\" ON (\"enorderrequestfile1\".\"id\" = \"enorderrequestfileapproval\".\"orderrequestfileid\"))  Left JOIN {OrderRequestFileApprovalLevel} \"enorderrequestfileapprovallevel\" ON (\"enorderrequestfileapproval\".\"id\" = \"enorderrequestfileapprovallevel\".\"orderrequestfileapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFile_Id != 0) {
whereBuilder.Append("((\"enorderrequestfile1\".\"id\" = @qporOrderRequestFile_Id) AND (\"enorderrequestfile1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFile_Id", DbType.Int64, qporOrderRequestFile_Id);
} else {
whereBuilder.Append("(\"enorderrequestfile1\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderrequestfileapprovallevel\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
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
RL_248cdd7729c13fb50aed8d762c8fa086 outParamList = new RL_248cdd7729c13fb50aed8d762c8fa086();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderRequestFileByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrdReqFileNextApproverEmail.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_248cdd7729c13fb50aed8d762c8fa086 _tmp = new RL_248cdd7729c13fb50aed8d762c8fa086();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderRequestFileByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrdReqFileNextApproverEmail.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_248cdd7729c13fb50aed8d762c8fa086)_tmp;
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

private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUserExtendedInternalAssignedToReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalAssignedTo" jdfe9P2xBkKtaIVOwNOKuA of Action "SendOrdReqFileNextApproverEmail"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserExtendedInternalAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrdReqFileNextApproverEmail.GetUserExtendedInternalAssignedTo", "f4ded78d-b1fd-4206-ad68-854ec0d38ab8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrdReqFileNextApproverEmail.GetUserExtendedInternalAssignedTo", "f4ded78d-b1fd-4206-ad68-854ec0d38ab8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.yeq0NYyARkOASfiyelDoBw/NodesNotShownInESpaceTree.jdfe9P2xBkKtaIVOwNOKuA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser36\".\"id\" o0, \"enuser36\".\"name\" o1, \"enuser36\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enuserextension19\".\"emailto\" o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal22\" Inner JOIN {User} \"enuser36\" ON (\"enuser_extended_internal22\".\"id\" = \"enuser36\".\"id\"))  Left JOIN {UserExtension} \"enuserextension19\" ON (\"enuser36\".\"id\" = \"enuserextension19\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser36\".\"id\" = @qpusUser_Id) AND (\"enuser36\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser36\".\"id\" IS NULL)");
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
RL_bc2063fe1d05aa544017f329fb1e030b outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalAssignedToReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrdReqFileNextApproverEmail.GetUserExtendedInternalAssignedTo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bc2063fe1d05aa544017f329fb1e030b _tmp = new RL_bc2063fe1d05aa544017f329fb1e030b();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalAssignedToReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrdReqFileNextApproverEmail.GetUserExtendedInternalAssignedTo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bc2063fe1d05aa544017f329fb1e030b)_tmp;
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
