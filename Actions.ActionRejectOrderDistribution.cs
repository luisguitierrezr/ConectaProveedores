namespace ssConectaProveedores;

public partial class Actions {
public class lcvRejectOrderDistribution : VarsBag {
public long inParami_OrderId;
/// <summary>
/// Variable <code>l_EmailNotificationToText</code> that represents the Service Studio Text
///  <code>l_EmailNotificationToText</code> <p>Description: Email list for notification CC.</p>
/// </summary>
public string varLcl_EmailNotificationToText = "";

/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

/// <summary>
/// Variable <code>l_UsersToNotify</code> that represents the Service Studio TextList
///  <code>l_UsersToNotify</code> <p>Description: Users To Notify.</p>
/// </summary>
public BasicTypeList<string> varLcl_UsersToNotify = new BasicTypeList<string>();

public ST_8509a484f6b6eac99c83feddd35d5004Structure resUsersWithEmailActive_outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

public RL_4ff1b710be996e0ae107a46588f5914b queryResGetOrderById_outParamList = new RL_4ff1b710be996e0ae107a46588f5914b();
public long queryResGetOrderById_outParamCount = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoOrderMainCreateOrUpdate resOrderMainCreateOrUpdate =  new Actions.lcoOrderMainCreateOrUpdate();
public ST_8509a484f6b6eac99c83feddd35d5004Structure resNewNotification_outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_2dc71bb7733217a4742592a2e8d6ef1e queryResGetUsersToNotify_outParamList = new RL_2dc71bb7733217a4742592a2e8d6ef1e();
public long queryResGetUsersToNotify_outParamCount = 0L;

public lcvRejectOrderDistribution(long inParami_OrderId) {
this.inParami_OrderId = inParami_OrderId;
}
}
public class lcoRejectOrderDistribution : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoRejectOrderDistribution() {
}
}
/// <summary>
/// Action <code>RejectOrderDistribution</code> that represents the Service Studio action
///  <code>RejectOrderDistribution</code> <p> Description: Server Action to reject order.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionRejectOrderDistribution(IRequestContext requestContext,long inParami_OrderId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoRejectOrderDistribution result = new lcoRejectOrderDistribution();
lcvRejectOrderDistribution localVars = new lcvRejectOrderDistribution(inParami_OrderId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RejectOrderDistribution", "eff0c88c-5a64-42b8-8282-d8fc91b83844"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RejectOrderDistribution", "eff0c88c-5a64-42b8-8282-d8fc91b83844", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Null id?
if(((localVars.inParami_OrderId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("jCBW0ciTNk6PMk4gSZZAXQ#Message.48399450.1", "Identifier is mandatory"));

} else {
// Query datasetGetOrderById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderById_maxRecords = 1;
if (datasetGetOrderById_maxRecords < 1) datasetGetOrderById_maxRecords = 1;
int datasetGetOrderById_startIndex = 0;(localVars.queryResGetOrderById_outParamList,localVars.queryResGetOrderById_outParamCount) = await FuncActionRejectOrderDistribution.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// New Rejected Status
// GetOrderById.List.Current.OrderMain.OrderStatusId = Rejected
localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId = (ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("bRJk2wDqy0yRFZotyjWZ5Q"))).ssId;
// OrderMainCreateOrUpdate
(localVars.resOrderMainCreateOrUpdate.outParamId,localVars.resOrderMainCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainCreateOrUpdate.outParamErrorMessage,localVars.resOrderMainCreateOrUpdate.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

// HasApproval?
if(((localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderApproval.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// OrderApprovalDelete
await Actions.ActionOrderApprovalDelete(requestContext,localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderApproval.ssId,cancellationToken);

}

// Query datasetGetUsersToNotify
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersToNotify_maxRecords = 999999999;
if (datasetGetUsersToNotify_maxRecords < 1) datasetGetUsersToNotify_maxRecords = 1;
int datasetGetUsersToNotify_startIndex = 0;(localVars.queryResGetUsersToNotify_outParamList,localVars.queryResGetUsersToNotify_outParamCount) = await FuncActionRejectOrderDistribution.datasetGetUsersToNotify(requestContext,datasetGetUsersToNotify_maxRecords,datasetGetUsersToNotify_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUsersToNotify_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_30605cbd04c198a6829dd726d5403039 source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUser.ssId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
target.ssEmailTo = source.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

// ListSort
await ExtendedActions.ListSort(requestContext,localVars.varLcl_EmailNotification,async (p, cancellationToken) => p.ssUserId,true,cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// l_EmailNotification = ListDistinct.DistinctList
localVars.varLcl_EmailNotification=localVars.resListDistinct_outParamDistinctList;
// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// l_EmailNotificationToText = l_EmailNotificationToText + If + If
localVars.varLcl_EmailNotificationToText=((localVars.varLcl_EmailNotificationToText+(((localVars.varLcl_EmailNotificationToText=="")) ? ("") : (",")))+(((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))));
localVars.varLcl_EmailNotification.Advance();
}

} finally {
localVars.varLcl_EmailNotification.EndIteration();
}

// UsersWithEmailActive
localVars.resUsersWithEmailActive_outParamResponse = await ssConectaProveedores.CcNotifications.ActionUsersWithEmailActive(requestContext,new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure(){ ssliststring = localVars.varLcl_EmailNotificationToText, sscategoryclass = "rejection" },cancellationToken);

// LogMessage
await ExtendedActions.LogMessage(requestContext,((((("Reject Order:"+"Original recipients: ")+localVars.varLcl_EmailNotificationToText)+"\r\n")+"Final:")+localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring),"Reject order emails",cancellationToken);

// No recipients?
if((!(((localVars.resUsersWithEmailActive_outParamResponse.sssuccess) ? ((BuiltInFunction.Trim (localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring)=="")) : ((BuiltInFunction.Trim (localVars.varLcl_EmailNotificationToText)=="")))))) {
using (AppHealthProvider.CreateSendEmailMetric("RejectOrderDistribution", "65099370-5e46-47d5-89ce-0e5e34212caa"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("RejectOrderDistribution", "65099370-5e46-47d5-89ce-0e5e34212caa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowh_OrderDistribution_Emails.h_OrderDistribution_Emails_RejectOrderDistribution>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber, "", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), ((localVars.resUsersWithEmailActive_outParamResponse.sssuccess) ? (localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring) : (localVars.varLcl_EmailNotificationToText)), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = ((localVars.resUsersWithEmailActive_outParamResponse.sssuccess) ? (localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring) : (localVars.varLcl_EmailNotificationToText)),
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
// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_UsersToNotify,(await BasicTypeList<string>.ConvertAsync(localVars.varLcl_EmailNotification, new BasicTypeList<string>(), async (ST_12668886130225cd5b17c72a6562dd7cStructure source, string target, CancellationToken cancellationToken) => {
target = source.ssUserId;
return target;
}, cancellationToken)),cancellationToken);

// NewNotification
localVars.resNewNotification_outParamResponse = await ssConectaProveedores.CcNotifications.ActionNewNotification(requestContext,new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure(){ ssuserids = localVars.varLcl_UsersToNotify, sstitle = AppUtils.GetStringResource("3EJVVQAFc0+XRIK978d5aQ#Value.1843250551.1", "Order Rejection"), sscontent = ((((AppUtils.GetStringResource("88a9_r4re0OLATY_pstq_A#Value.-323961123.1", "An order was rejected with number")+": ")+localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+", ")+AppUtils.GetStringResource("88a9_r4re0OLATY_pstq_A#Value.1654048829.1", "please distribute it to the corresponding inbox.")), sscategoryclass = "rejection" },cancellationToken);

}

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParami_OrderId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((AppUtils.GetStringResource("Y8uB7JwSJkWbxcHnVfjGmg#Value.76453678.1", "Order")+" ")+(await Functions.ssGetOrderMain(requestContext,localVars.inParami_OrderId,cancellationToken)).ssENOrderMain.ssOrderNumber)+AppUtils.GetStringResource("Y8uB7JwSJkWbxcHnVfjGmg#Value.1366818879.1", " was rejected, please distribute to the appropriate tray.")), ssIsError = true },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionRejectOrderDistribution {

private static async Task<RC_158d774b1951665b144a20e40b8bb511> datasetGetOrderByIdReadDbAsync(RC_158d774b1951665b144a20e40b8bb511 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderById" vbdwLpoOHUOUku_X8SrN+Q of Action "RejectOrderDistribution"
public static async Task<(RL_4ff1b710be996e0ae107a46588f5914b,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RejectOrderDistribution.GetOrderById", "2e70b7bd-0e9a-431d-9492-efd7f12acdf9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RejectOrderDistribution.GetOrderById", "2e70b7bd-0e9a-431d-9492-efd7f12acdf9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jMjw72RauEKCgtj8kbg4RA/NodesNotShownInESpaceTree.vbdwLpoOHUOUku_X8SrN+Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval16\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enordermain61\".\"id\" o8, \"enordermain61\".\"ordernumber\" o9, \"enordermain61\".\"orderdate\" o10, \"enordermain61\".\"orderstatusid\" o11, \"enordermain61\".\"previousorderstatusid\" o12, \"enordermain61\".\"assignmentcode\" o13, \"enordermain61\".\"supplierid\" o14, \"enordermain61\".\"companyid\" o15, \"enordermain61\".\"documenttypeid\" o16, \"enordermain61\".\"currencyid\" o17, \"enordermain61\".\"telceldirectionid\" o18, \"enordermain61\".\"procurementgroup\" o19, \"enordermain61\".\"creatorsapnumber\" o20, \"enordermain61\".\"creatorsapname\" o21, \"enordermain61\".\"country\" o22, \"enordermain61\".\"isdeleted\" o23, \"enordermain61\".\"isreleased\" o24, trim_scale(\"enordermain61\".\"exchangerate\"::numeric) o25, \"enordermain61\".\"sustainabilitycategory\" o26, \"enordermain61\".\"sustainabilitysubcategory\" o27, trim_scale(\"enordermain61\".\"totalamount\"::numeric) o28, \"enordermain61\".\"fromcosmoz\" o29, \"enordermain61\".\"regionid\" o30, \"enordermain61\".\"divisionid\" o31, \"enordermain61\".\"applicant\" o32, \"enordermain61\".\"createdby\" o33, \"enordermain61\".\"createdon\" o34, \"enordermain61\".\"updatedby\" o35, \"enordermain61\".\"updatedon\" o36");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain61\" Left JOIN {OrderApproval} \"enorderapproval16\" ON (\"enordermain61\".\"id\" = \"enorderapproval16\".\"orderid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain61\".\"id\" = @qporOrderMain_Id) AND (\"enordermain61\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain61\".\"id\" IS NULL)");
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
RL_4ff1b710be996e0ae107a46588f5914b outParamList = new RL_4ff1b710be996e0ae107a46588f5914b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RejectOrderDistribution.GetOrderById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4ff1b710be996e0ae107a46588f5914b _tmp = new RL_4ff1b710be996e0ae107a46588f5914b();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RejectOrderDistribution.GetOrderById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4ff1b710be996e0ae107a46588f5914b)_tmp;
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

private static async Task<RC_30605cbd04c198a6829dd726d5403039> datasetGetUsersToNotifyReadDbAsync(RC_30605cbd04c198a6829dd726d5403039 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUsersToNotify" qtwZmvt7nkaCLI4ybQbNzg of Action "RejectOrderDistribution"
public static async Task<(RL_2dc71bb7733217a4742592a2e8d6ef1e,long)> datasetGetUsersToNotify(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RejectOrderDistribution.GetUsersToNotify", "9a19dcaa-7bfb-469e-822c-8e326d06cdce");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RejectOrderDistribution.GetUsersToNotify", "9a19dcaa-7bfb-469e-822c-8e326d06cdce", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jMjw72RauEKCgtj8kbg4RA/NodesNotShownInESpaceTree.qtwZmvt7nkaCLI4ybQbNzg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"enuser133\".\"id\" o20, \"enuser133\".\"name\" o21, \"enuser133\".\"email\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, \"enuserextension62\".\"emailto\" o57");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal79\" Inner JOIN {Region} \"enregion60\" ON (\"enuser_extended_internal79\".\"regionid\" = \"enregion60\".\"id\"))  Inner JOIN {UserApplicationRole} \"enuserapplicationrole17\" ON (\"enuser_extended_internal79\".\"id\" = \"enuserapplicationrole17\".\"userid\"))  Inner JOIN {User} \"enuser133\" ON (\"enuser_extended_internal79\".\"id\" = \"enuser133\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole35\" ON (\"enuserapplicationrole17\".\"applicationroleid\" = \"enapplicationrole35\".\"id\"))  Left JOIN {UserExtension} \"enuserextension62\" ON (\"enuser133\".\"id\" = \"enuserextension62\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enapplicationrole35\".\"isareacxp\" = 1) AND (\"enregion60\".\"code\" = 'RG00')");
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
RL_2dc71bb7733217a4742592a2e8d6ef1e outParamList = new RL_2dc71bb7733217a4742592a2e8d6ef1e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersToNotifyReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RejectOrderDistribution.GetUsersToNotify.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2dc71bb7733217a4742592a2e8d6ef1e _tmp = new RL_2dc71bb7733217a4742592a2e8d6ef1e();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersToNotifyReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RejectOrderDistribution.GetUsersToNotify.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2dc71bb7733217a4742592a2e8d6ef1e)_tmp;
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
