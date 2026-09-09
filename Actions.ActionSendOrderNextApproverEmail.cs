namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendOrderNextApproverEmail : VarsBag {
public long inParami_OrderId;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUserAssignedTo_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUserAssignedTo_outParamCount = 0L;

public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUsers_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUsers_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_466c605dd07558761818d5a27c59c2b8 queryResGetOrderById_outParamList = new RL_466c605dd07558761818d5a27c59c2b8();
public long queryResGetOrderById_outParamCount = 0L;

public lcvSendOrderNextApproverEmail(long inParami_OrderId) {
this.inParami_OrderId = inParami_OrderId;
}
}
/// <summary>
/// Action <code>SendOrderNextApproverEmail</code> that represents the Service Studio action
///  <code>SendOrderNextApproverEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendOrderNextApproverEmail(IRequestContext requestContext,long inParami_OrderId,CancellationToken cancellationToken) {
lcvSendOrderNextApproverEmail localVars = new lcvSendOrderNextApproverEmail(inParami_OrderId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendOrderNextApproverEmail", "742c6137-d93a-4d6e-a3f6-29de89f1c57d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendOrderNextApproverEmail", "742c6137-d93a-4d6e-a3f6-29de89f1c57d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetOrderById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderById_maxRecords = 1;
if (datasetGetOrderById_maxRecords < 1) datasetGetOrderById_maxRecords = 1;
int datasetGetOrderById_startIndex = 0;(localVars.queryResGetOrderById_outParamList,localVars.queryResGetOrderById_outParamCount) = await FuncActionSendOrderNextApproverEmail.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// AssignedTo?
if(((localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ()))) {
// Query datasetGetUserAssignedTo
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserAssignedTo_maxRecords = 1;
if (datasetGetUserAssignedTo_maxRecords < 1) datasetGetUserAssignedTo_maxRecords = 1;
int datasetGetUserAssignedTo_startIndex = 0;(localVars.queryResGetUserAssignedTo_outParamList,localVars.queryResGetUserAssignedTo_outParamCount) = await FuncActionSendOrderNextApproverEmail.datasetGetUserAssignedTo(requestContext,datasetGetUserAssignedTo_maxRecords,datasetGetUserAssignedTo_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,new ST_12668886130225cd5b17c72a6562dd7cStructure(){ ssUserId = localVars.queryResGetUserAssignedTo_outParamList.CurrentRec.ssENUser.ssId, ssEmail = localVars.queryResGetUserAssignedTo_outParamList.CurrentRec.ssENUser.ssEmail, ssName = localVars.queryResGetUserAssignedTo_outParamList.CurrentRec.ssENUser.ssName, ssEmailTo = localVars.queryResGetUserAssignedTo_outParamList.CurrentRec.ssENUserExtension.ssEmailto },cancellationToken);

} else {
// Query datasetGetUsers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsers_maxRecords = 0;
int datasetGetUsers_startIndex = 0;(localVars.queryResGetUsers_outParamList,localVars.queryResGetUsers_outParamCount) = await FuncActionSendOrderNextApproverEmail.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId,localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssRegionId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUsers_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_184336c68155ad9e77005f91e8e8b363 source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUser.ssId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
target.ssEmailTo = source.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

}

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",1,("Pedidos - Aprobar Pedido "+localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber),(("El pedido "+localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" está esperando su aprobación."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("NextApproverOrder", "37b89c1e-65be-4486-9643-0e73734755f5"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("NextApproverOrder", "37b89c1e-65be-4486-9643-0e73734755f5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowe_Orders_Emails.e_Orders_Emails_NextApproverOrder>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionSendOrderNextApproverEmail {

private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUserAssignedToReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserAssignedTo" at+BLhT8qEqnXLqKF7JuiA of Action "SendOrderNextApproverEmail"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderNextApproverEmail.GetUserAssignedTo", "2e81df6a-fc14-4aa8-a75c-ba8a17b26e88");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderNextApproverEmail.GetUserAssignedTo", "2e81df6a-fc14-4aa8-a75c-ba8a17b26e88", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.N2EsdDrZbk2j9ineifHFfQ/NodesNotShownInESpaceTree.at+BLhT8qEqnXLqKF7JuiA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser73\".\"id\" o0, \"enuser73\".\"name\" o1, \"enuser73\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enuserextension37\".\"emailto\" o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal43\" Inner JOIN {User} \"enuser73\" ON (\"enuser_extended_internal43\".\"id\" = \"enuser73\".\"id\"))  Left JOIN {UserExtension} \"enuserextension37\" ON (\"enuser73\".\"id\" = \"enuserextension37\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser73\".\"id\" = @qpusUser_Id) AND (\"enuser73\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser73\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetUserAssignedToReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderNextApproverEmail.GetUserAssignedTo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bc2063fe1d05aa544017f329fb1e030b _tmp = new RL_bc2063fe1d05aa544017f329fb1e030b();
_tmp.AlternateReadDbMethodAsync = datasetGetUserAssignedToReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderNextApproverEmail.GetUserAssignedTo.List", cancellationToken: cancellationToken);
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

private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUsersReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUsers" aoX2cjSeYkqINsCFa84gjg of Action "SendOrderNextApproverEmail"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenUser_Extended_Internal_EntraRoleId,long qpreUser_Extended_Internal_RegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderNextApproverEmail.GetUsers", "72f6856a-9e34-4a62-8836-c0856bce208e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderNextApproverEmail.GetUsers", "72f6856a-9e34-4a62-8836-c0856bce208e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.N2EsdDrZbk2j9ineifHFfQ/NodesNotShownInESpaceTree.aoX2cjSeYkqINsCFa84gjg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser74\".\"id\" o0, \"enuser74\".\"name\" o1, \"enuser74\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enuserextension38\".\"emailto\" o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal44\" Inner JOIN {User} \"enuser74\" ON (\"enuser_extended_internal44\".\"id\" = \"enuser74\".\"id\"))  Left JOIN {UserExtension} \"enuserextension38\" ON (\"enuser74\".\"id\" = \"enuserextension38\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal44\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal44\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal44\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenUser_Extended_Internal_EntraRoleId != 0) {
whereBuilder.Append("((\"enuser_extended_internal44\".\"entraroleid\" = @qpenUser_Extended_Internal_EntraRoleId) AND (\"enuser_extended_internal44\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenUser_Extended_Internal_EntraRoleId", DbType.Int64, qpenUser_Extended_Internal_EntraRoleId);
} else {
whereBuilder.Append("(\"enuser_extended_internal44\".\"entraroleid\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderNextApproverEmail.GetUsers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bc2063fe1d05aa544017f329fb1e030b _tmp = new RL_bc2063fe1d05aa544017f329fb1e030b();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderNextApproverEmail.GetUsers.List", cancellationToken: cancellationToken);
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

private static async Task<RC_7074703fd377ca40d733f2d5d8d3fde2> datasetGetOrderByIdReadDbAsync(RC_7074703fd377ca40d733f2d5d8d3fde2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderById" dL4a2IbrYE+tMrGFmeaeZA of Action "SendOrderNextApproverEmail"
public static async Task<(RL_466c605dd07558761818d5a27c59c2b8,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderNextApproverEmail.GetOrderById", "d81abe74-eb86-4f60-ad32-b18599e69e64");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderNextApproverEmail.GetOrderById", "d81abe74-eb86-4f60-ad32-b18599e69e64", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.N2EsdDrZbk2j9ineifHFfQ/NodesNotShownInESpaceTree.dL4a2IbrYE+tMrGFmeaeZA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enorderapprovallevel9\".\"entraroleid\" o11, \"enorderapprovallevel9\".\"assignedto\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enordermain34\".\"ordernumber\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enordermain34\".\"regionid\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain34\" Left JOIN {OrderApproval} \"enorderapproval10\" ON (\"enordermain34\".\"id\" = \"enorderapproval10\".\"orderid\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel9\" ON (\"enorderapproval10\".\"id\" = \"enorderapprovallevel9\".\"orderapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain34\".\"id\" = @qporOrderMain_Id) AND (\"enordermain34\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain34\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderapprovallevel9\".\"approvalstatusid\" = ");
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
RL_466c605dd07558761818d5a27c59c2b8 outParamList = new RL_466c605dd07558761818d5a27c59c2b8();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderNextApproverEmail.GetOrderById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_466c605dd07558761818d5a27c59c2b8 _tmp = new RL_466c605dd07558761818d5a27c59c2b8();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderNextApproverEmail.GetOrderById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_466c605dd07558761818d5a27c59c2b8)_tmp;
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
