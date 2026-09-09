namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendRejectedProposalEmails : VarsBag {
public long inParami_ProposaId;
public string inParami_RejectionReason;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

/// <summary>
/// Variable <code>l_EmailNotificationToText</code> that represents the Service Studio Text
///  <code>l_EmailNotificationToText</code> <p>Description: Email list for notification CC</p>
/// </summary>
public string varLcl_EmailNotificationToText = "";

/// <summary>
/// Variable <code>UsersToNotify</code> that represents the Service Studio TextList
///  <code>UsersToNotify</code> <p>Description: </p>
/// </summary>
public BasicTypeList<string> varLcUsersToNotify = new BasicTypeList<string>();

public RL_5d12cbdbc739013acbdd9f1aee86f8c2 queryResGetUserApplicationRoles_outParamList = new RL_5d12cbdbc739013acbdd9f1aee86f8c2();
public long queryResGetUserApplicationRoles_outParamCount = 0L;

public ST_8509a484f6b6eac99c83feddd35d5004Structure resUsersWithEmailActive_outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

public ST_8509a484f6b6eac99c83feddd35d5004Structure resNewNotification_outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_82f8f815f9fb0b6e192e24e072fb8ae2 queryResGetUserExtendedInternalsByRegionId_outParamList = new RL_82f8f815f9fb0b6e192e24e072fb8ae2();
public long queryResGetUserExtendedInternalsByRegionId_outParamCount = 0L;

public RL_9f9acf7f8fbbfb480a215bc421efa609 queryResGetProposalById_outParamList = new RL_9f9acf7f8fbbfb480a215bc421efa609();
public long queryResGetProposalById_outParamCount = 0L;

public lcvSendRejectedProposalEmails(long inParami_ProposaId, string inParami_RejectionReason) {
this.inParami_ProposaId = inParami_ProposaId;
this.inParami_RejectionReason = inParami_RejectionReason;
}
}
/// <summary>
/// Action <code>SendRejectedProposalEmails</code> that represents the Service Studio action
///  <code>SendRejectedProposalEmails</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendRejectedProposalEmails(IRequestContext requestContext,long inParami_ProposaId,string inParami_RejectionReason,CancellationToken cancellationToken) {
lcvSendRejectedProposalEmails localVars = new lcvSendRejectedProposalEmails(inParami_ProposaId, inParami_RejectionReason);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendRejectedProposalEmails", "c560971a-e2af-41d1-b5aa-ae0ce498a953"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendRejectedProposalEmails", "c560971a-e2af-41d1-b5aa-ae0ce498a953", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcl_EmailNotification,cancellationToken);

// Query datasetGetProposalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalById_maxRecords = 0;
int datasetGetProposalById_startIndex = 0;(localVars.queryResGetProposalById_outParamList,localVars.queryResGetProposalById_outParamCount) = await FuncActionSendRejectedProposalEmails.datasetGetProposalById(requestContext,datasetGetProposalById_maxRecords,datasetGetProposalById_startIndex,IterationMultiplicity.Single,localVars.inParami_ProposaId,cancellationToken);

// Foreach GetProposalById.List
localVars.queryResGetProposalById_outParamList.StartIteration();
try {while (!((localVars.queryResGetProposalById_outParamList.Eof))) {
// Query datasetGetUserExtendedInternalsByRegionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalsByRegionId_maxRecords = 0;
int datasetGetUserExtendedInternalsByRegionId_startIndex = 0;(localVars.queryResGetUserExtendedInternalsByRegionId_outParamList,localVars.queryResGetUserExtendedInternalsByRegionId_outParamCount) = await FuncActionSendRejectedProposalEmails.datasetGetUserExtendedInternalsByRegionId(requestContext,datasetGetUserExtendedInternalsByRegionId_maxRecords,datasetGetUserExtendedInternalsByRegionId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssRegionId,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssApplicationRoleId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUserExtendedInternalsByRegionId_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_7655e3fb0214830e441b4ca25cd396cb source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUserApplicationRole.ssUserId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
target.ssEmailTo = source.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetProposalById_outParamList.Advance();
}

} finally {
localVars.queryResGetProposalById_outParamList.EndIteration();
}

// Query datasetGetUserApplicationRoles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoles_maxRecords = 0;
int datasetGetUserApplicationRoles_startIndex = 0;(localVars.queryResGetUserApplicationRoles_outParamList,localVars.queryResGetUserApplicationRoles_outParamCount) = await FuncActionSendRejectedProposalEmails.datasetGetUserApplicationRoles(requestContext,datasetGetUserApplicationRoles_maxRecords,datasetGetUserApplicationRoles_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUserApplicationRoles_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_c77d66d9ff86c86854dcdb2c4c9f3219 source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUserApplicationRole.ssUserId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
return target;
}, cancellationToken)),cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

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
await ExtendedActions.LogMessage(requestContext,((((("REJECTION PROPOSAL::"+"Original recipients: ")+localVars.varLcl_EmailNotificationToText)+"\r\n")+"Final:")+localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring),"Rejection proposal emails",cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("RejectedProposal2", "b5b0ecd6-d9d4-4ebb-9d49-7abc23b8d38c"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("RejectedProposal2", "b5b0ecd6-d9d4-4ebb-9d49-7abc23b8d38c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowb_CyA_Emails.b_CyA_Emails_RejectedProposal>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName, "", localVars.inParami_RejectionReason, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.varLcl_EmailNotificationToText, "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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
// ListAppendAll3
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcUsersToNotify,(await BasicTypeList<string>.ConvertAsync(localVars.varLcl_EmailNotification, new BasicTypeList<string>(), async (ST_12668886130225cd5b17c72a6562dd7cStructure source, string target, CancellationToken cancellationToken) => {
target = source.ssUserId;
return target;
}, cancellationToken)),cancellationToken);

// NewNotification
localVars.resNewNotification_outParamResponse = await ssConectaProveedores.CcNotifications.ActionNewNotification(requestContext,new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure(){ ssuserids = localVars.varLcUsersToNotify, sstitle = (((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="DEV")) ? ("(DEV)") : ((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="QA")) ? ("(QA)") : (""))))+"Comissiones Y Arrendamientos - Rechazo de la Propuesta ")+localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName), sscontent = localVars.inParami_RejectionReason, sscategoryclass = "rejection" },cancellationToken);

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

public static class FuncActionSendRejectedProposalEmails {

private static async Task<RC_c77d66d9ff86c86854dcdb2c4c9f3219> datasetGetUserApplicationRolesReadDbAsync(RC_c77d66d9ff86c86854dcdb2c4c9f3219 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRoles" VT0uBWYZHkqvYRJoz8HzIA of Action "SendRejectedProposalEmails"
public static async Task<(RL_5d12cbdbc739013acbdd9f1aee86f8c2,long)> datasetGetUserApplicationRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendRejectedProposalEmails.GetUserApplicationRoles", "052e3d55-1966-4a1e-af61-1268cfc1f320");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendRejectedProposalEmails.GetUserApplicationRoles", "052e3d55-1966-4a1e-af61-1268cfc1f320", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Gpdgxa_i0UG1qq4M5JipUw/NodesNotShownInESpaceTree.VT0uBWYZHkqvYRJoz8HzIA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enuser109\".\"name\" o8, \"enuser109\".\"email\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enuserapplicationrole11\".\"userid\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41");
fromBuilder.Append(" FROM ((({UserApplicationRole} \"enuserapplicationrole11\" Left JOIN {ApplicationRole} \"enapplicationrole25\" ON (\"enuserapplicationrole11\".\"applicationroleid\" = \"enapplicationrole25\".\"id\"))  Left JOIN {User} \"enuser109\" ON (\"enuserapplicationrole11\".\"userid\" = \"enuser109\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal63\" ON (\"enuser109\".\"id\" = \"enuser_extended_internal63\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enapplicationrole25\".\"code\" = 'ADMIN_AREA_CENTRALIZACION')");
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
RL_5d12cbdbc739013acbdd9f1aee86f8c2 outParamList = new RL_5d12cbdbc739013acbdd9f1aee86f8c2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserApplicationRolesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendRejectedProposalEmails.GetUserApplicationRoles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d12cbdbc739013acbdd9f1aee86f8c2 _tmp = new RL_5d12cbdbc739013acbdd9f1aee86f8c2();
_tmp.AlternateReadDbMethodAsync = datasetGetUserApplicationRolesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendRejectedProposalEmails.GetUserApplicationRoles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d12cbdbc739013acbdd9f1aee86f8c2)_tmp;
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

private static async Task<RC_7655e3fb0214830e441b4ca25cd396cb> datasetGetUserExtendedInternalsByRegionIdReadDbAsync(RC_7655e3fb0214830e441b4ca25cd396cb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalsByRegionId" z0bUgpbXFUSDHWVKdSQU1A of Action "SendRejectedProposalEmails"
public static async Task<(RL_82f8f815f9fb0b6e192e24e072fb8ae2,long)> datasetGetUserExtendedInternalsByRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreUser_Extended_Internal_RegionId,long qpapUserApplicationRole_ApplicationRoleId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendRejectedProposalEmails.GetUserExtendedInternalsByRegionId", "82d446cf-d796-4415-831d-654a752414d4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendRejectedProposalEmails.GetUserExtendedInternalsByRegionId", "82d446cf-d796-4415-831d-654a752414d4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Gpdgxa_i0UG1qq4M5JipUw/NodesNotShownInESpaceTree.z0bUgpbXFUSDHWVKdSQU1A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser110\".\"name\" o1, \"enuser110\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enuserapplicationrole12\".\"userid\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enuserextension50\".\"emailto\" o37");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal64\" Inner JOIN {User} \"enuser110\" ON (\"enuser_extended_internal64\".\"id\" = \"enuser110\".\"id\"))  Left JOIN {UserApplicationRole} \"enuserapplicationrole12\" ON (\"enuser110\".\"id\" = \"enuserapplicationrole12\".\"userid\"))  Left JOIN {UserExtension} \"enuserextension50\" ON (\"enuser110\".\"id\" = \"enuserextension50\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal64\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal64\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal64\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapUserApplicationRole_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enuserapplicationrole12\".\"applicationroleid\" = @qpapUserApplicationRole_ApplicationRoleId) AND (\"enuserapplicationrole12\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapUserApplicationRole_ApplicationRoleId", DbType.Int64, qpapUserApplicationRole_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enuserapplicationrole12\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationrole12\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
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
RL_82f8f815f9fb0b6e192e24e072fb8ae2 outParamList = new RL_82f8f815f9fb0b6e192e24e072fb8ae2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByRegionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendRejectedProposalEmails.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_82f8f815f9fb0b6e192e24e072fb8ae2 _tmp = new RL_82f8f815f9fb0b6e192e24e072fb8ae2();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByRegionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendRejectedProposalEmails.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_82f8f815f9fb0b6e192e24e072fb8ae2)_tmp;
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

private static async Task<RC_921fd9090c7367c088e0777ee6e3ef28> datasetGetProposalByIdReadDbAsync(RC_921fd9090c7367c088e0777ee6e3ef28 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalApproval.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetProposalById" YyKN4XaMYE6tBrI8gob8IQ of Action "SendRejectedProposalEmails"
public static async Task<(RL_9f9acf7f8fbbfb480a215bc421efa609,long)> datasetGetProposalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendRejectedProposalEmails.GetProposalById", "e18d2263-8c76-4e60-ad06-b23c8286fc21");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendRejectedProposalEmails.GetProposalById", "e18d2263-8c76-4e60-ad06-b23c8286fc21", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Gpdgxa_i0UG1qq4M5JipUw/NodesNotShownInESpaceTree.YyKN4XaMYE6tBrI8gob8IQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enproposal9\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enproposal9\".\"regionid\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enproposalapprovallevel3\".\"applicationroleid\" o29, NULL o30, NULL o31, NULL o32");
fromBuilder.Append(" FROM (({Proposal} \"enproposal9\" Left JOIN {ProposalApproval} \"enproposalapproval3\" ON (\"enproposal9\".\"id\" = \"enproposalapproval3\".\"proposalid\"))  Left JOIN {ProposalApprovalLevel} \"enproposalapprovallevel3\" ON (\"enproposalapproval3\".\"id\" = \"enproposalapprovallevel3\".\"proposalapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal9\".\"id\" = @qpprProposal_Id) AND (\"enproposal9\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal9\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enproposal9\".\"name\" ASC ");
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
RL_9f9acf7f8fbbfb480a215bc421efa609 outParamList = new RL_9f9acf7f8fbbfb480a215bc421efa609();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendRejectedProposalEmails.GetProposalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9f9acf7f8fbbfb480a215bc421efa609 _tmp = new RL_9f9acf7f8fbbfb480a215bc421efa609();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendRejectedProposalEmails.GetProposalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9f9acf7f8fbbfb480a215bc421efa609)_tmp;
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
