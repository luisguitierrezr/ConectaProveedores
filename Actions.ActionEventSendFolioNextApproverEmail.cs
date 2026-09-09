namespace ssConectaProveedores;

public partial class Actions {
public class lcvEventSendFolioNextApproverEmail : VarsBag {
public long inParami_FolioId;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_3a99147a5a14669e8ced82dd9eebacf0 queryResGetUserExtendedInternalsByRegionId_outParamList = new RL_3a99147a5a14669e8ced82dd9eebacf0();
public long queryResGetUserExtendedInternalsByRegionId_outParamCount = 0L;

public RL_57593cd225237ead1eaddf28b138c8a4 queryResGetFolioById_outParamList = new RL_57593cd225237ead1eaddf28b138c8a4();
public long queryResGetFolioById_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUserExtendedInternalAssignedTo_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUserExtendedInternalAssignedTo_outParamCount = 0L;

public lcvEventSendFolioNextApproverEmail(long inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}
}
/// <summary>
/// Action <code>EventSendFolioNextApproverEmail</code> that represents the Service Studio action
///  <code>EventSendFolioNextApproverEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionEventSendFolioNextApproverEmail(IRequestContext requestContext,long inParami_FolioId,CancellationToken cancellationToken) {
lcvEventSendFolioNextApproverEmail localVars = new lcvEventSendFolioNextApproverEmail(inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EventSendFolioNextApproverEmail", "7e7acac6-3eca-4a46-b5a9-fec5c419cced"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EventSendFolioNextApproverEmail", "7e7acac6-3eca-4a46-b5a9-fec5c419cced", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionEventSendFolioNextApproverEmail.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Single,localVars.inParami_FolioId,cancellationToken);

// AssignedTo?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ()))) {
// Query datasetGetUserExtendedInternalAssignedTo
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalAssignedTo_maxRecords = 1;
if (datasetGetUserExtendedInternalAssignedTo_maxRecords < 1) datasetGetUserExtendedInternalAssignedTo_maxRecords = 1;
int datasetGetUserExtendedInternalAssignedTo_startIndex = 0;(localVars.queryResGetUserExtendedInternalAssignedTo_outParamList,localVars.queryResGetUserExtendedInternalAssignedTo_outParamCount) = await FuncActionEventSendFolioNextApproverEmail.datasetGetUserExtendedInternalAssignedTo(requestContext,datasetGetUserExtendedInternalAssignedTo_maxRecords,datasetGetUserExtendedInternalAssignedTo_startIndex,IterationMultiplicity.Never,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,new ST_12668886130225cd5b17c72a6562dd7cStructure(){ ssUserId = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssId, ssEmail = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssEmail, ssName = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssName, ssEmailTo = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUserExtension.ssEmailto },cancellationToken);

} else {
// Foreach GetFolioById.List
localVars.queryResGetFolioById_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioById_outParamList.Eof))) {
// Query datasetGetUserExtendedInternalsByRegionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalsByRegionId_maxRecords = 0;
int datasetGetUserExtendedInternalsByRegionId_startIndex = 0;(localVars.queryResGetUserExtendedInternalsByRegionId_outParamList,localVars.queryResGetUserExtendedInternalsByRegionId_outParamCount) = await FuncActionEventSendFolioNextApproverEmail.datasetGetUserExtendedInternalsByRegionId(requestContext,datasetGetUserExtendedInternalsByRegionId_maxRecords,datasetGetUserExtendedInternalsByRegionId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssRegionId,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApplicationRoleId,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssDivisionId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUserExtendedInternalsByRegionId_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_6783422774b4547f1160d86529102520 source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUser.ssId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
target.ssEmailTo = source.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetFolioById_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioById_outParamList.EndIteration();
}

// ListSort
await ExtendedActions.ListSort(requestContext,localVars.varLcl_EmailNotification,async (p, cancellationToken) => p.ssUserId,true,cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// Set New List
// l_EmailNotification = ListDistinct.DistinctList
localVars.varLcl_EmailNotification=localVars.resListDistinct_outParamDistinctList;
}

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",0,("Folios - Aprobar Folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber),(("El folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" está esperando su aprobación."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("NextApproverFolio", "3031301d-5404-4d22-99c0-fb19cad48e5f"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("NextApproverFolio", "3031301d-5404-4d22-99c0-fb19cad48e5f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_NextApproverFolio>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionEventSendFolioNextApproverEmail {

private static async Task<RC_6783422774b4547f1160d86529102520> datasetGetUserExtendedInternalsByRegionIdReadDbAsync(RC_6783422774b4547f1160d86529102520 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalsByRegionId" MZo0CNvOxkyeuw3WeHhNlQ of Action "EventSendFolioNextApproverEmail"
public static async Task<(RL_3a99147a5a14669e8ced82dd9eebacf0,long)> datasetGetUserExtendedInternalsByRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreUser_Extended_Internal_RegionId,long qpapApplicationRole_Id,long qpenEntraRole_Id,long qpreUser_Extended_Internal_RegionId1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventSendFolioNextApproverEmail.GetUserExtendedInternalsByRegionId", "08349a31-cedb-4cc6-9ebb-0dd678784d95");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventSendFolioNextApproverEmail.GetUserExtendedInternalsByRegionId", "08349a31-cedb-4cc6-9ebb-0dd678784d95", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xsp6fso+Rkq1qf7FxBnM7Q/NodesNotShownInESpaceTree.MZo0CNvOxkyeuw3WeHhNlQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enuser77\".\"id\" o17, \"enuser77\".\"name\" o18, \"enuser77\".\"email\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, \"enuserextension40\".\"emailto\" o44");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal46\" Inner JOIN {User} \"enuser77\" ON (\"enuser_extended_internal46\".\"id\" = \"enuser77\".\"id\"))  Left JOIN {UserExtension} \"enuserextension40\" ON (\"enuser77\".\"id\" = \"enuserextension40\".\"id\"))  Left JOIN {EntraRole} \"enentrarole21\" ON (\"enuser_extended_internal46\".\"entraroleid\" = \"enentrarole21\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept5\" ON (\"enentrarole21\".\"id\" = \"enroleconcept5\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole12\" ON (\"enroleconcept5\".\"applicationroleid\" = \"enapplicationrole12\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpreUser_Extended_Internal_RegionId <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal46\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal46\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal46\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpreUser_Extended_Internal_RegionId1 != 0) {
whereBuilder.Append("((\"enuser_extended_internal46\".\"regionid\" = @qpreUser_Extended_Internal_RegionId1) AND (\"enuser_extended_internal46\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId1", DbType.Int64, qpreUser_Extended_Internal_RegionId1);
} else {
whereBuilder.Append("(\"enuser_extended_internal46\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1) AND ((CASE WHEN (@qpapApplicationRole_Id <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpapApplicationRole_Id", DbType.Int64, qpapApplicationRole_Id);
if (qpapApplicationRole_Id != 0) {
whereBuilder.Append("((\"enapplicationrole12\".\"id\" = @qpapApplicationRole_Id) AND (\"enapplicationrole12\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApplicationRole_Id", DbType.Int64, qpapApplicationRole_Id);
} else {
whereBuilder.Append("(\"enapplicationrole12\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpenEntraRole_Id != 0) {
whereBuilder.Append("((\"enentrarole21\".\"id\" = @qpenEntraRole_Id) AND (\"enentrarole21\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenEntraRole_Id", DbType.Int64, qpenEntraRole_Id);
} else {
whereBuilder.Append("(\"enentrarole21\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1)");
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
RL_3a99147a5a14669e8ced82dd9eebacf0 outParamList = new RL_3a99147a5a14669e8ced82dd9eebacf0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByRegionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, false});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventSendFolioNextApproverEmail.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3a99147a5a14669e8ced82dd9eebacf0 _tmp = new RL_3a99147a5a14669e8ced82dd9eebacf0();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByRegionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventSendFolioNextApproverEmail.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3a99147a5a14669e8ced82dd9eebacf0)_tmp;
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

private static async Task<RC_497f735a522829d94999357ea05280c6> datasetGetFolioByIdReadDbAsync(RC_497f735a522829d94999357ea05280c6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" 2u5qneJEUkGsqJ2w95TIVQ of Action "EventSendFolioNextApproverEmail"
public static async Task<(RL_57593cd225237ead1eaddf28b138c8a4,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventSendFolioNextApproverEmail.GetFolioById", "9d6aeeda-44e2-4152-aca8-9db0f794c855");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventSendFolioNextApproverEmail.GetFolioById", "9d6aeeda-44e2-4152-aca8-9db0f794c855", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xsp6fso+Rkq1qf7FxBnM7Q/NodesNotShownInESpaceTree.2u5qneJEUkGsqJ2w95TIVQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio26\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enfolioapproval14\".\"regionid\" o29, NULL o30, NULL o31, NULL o32, \"enfolioapprovallevel13\".\"applicationroleid\" o33, NULL o34, \"enfolioapprovallevel13\".\"entraroleid\" o35, NULL o36, \"enfolioapprovallevel13\".\"assignedto\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, \"enordermain38\".\"divisionid\" o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78");
fromBuilder.Append(" FROM ((({Folio} \"enfolio26\" Left JOIN {FolioApproval} \"enfolioapproval14\" ON (\"enfolio26\".\"id\" = \"enfolioapproval14\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel13\" ON (\"enfolioapproval14\".\"id\" = \"enfolioapprovallevel13\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain38\" ON (\"enfolio26\".\"orderid\" = \"enordermain38\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio26\".\"id\" = @qpfoFolio_Id) AND (\"enfolio26\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio26\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel13\".\"approvalstatusid\" = ");
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
RL_57593cd225237ead1eaddf28b138c8a4 outParamList = new RL_57593cd225237ead1eaddf28b138c8a4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventSendFolioNextApproverEmail.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_57593cd225237ead1eaddf28b138c8a4 _tmp = new RL_57593cd225237ead1eaddf28b138c8a4();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventSendFolioNextApproverEmail.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_57593cd225237ead1eaddf28b138c8a4)_tmp;
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
// Query Function "GetUserExtendedInternalAssignedTo" Ilev3hAvyEOEK_IrnC7aiQ of Action "EventSendFolioNextApproverEmail"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserExtendedInternalAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventSendFolioNextApproverEmail.GetUserExtendedInternalAssignedTo", "deaf5722-2f10-43c8-842b-f22b9c2eda89");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventSendFolioNextApproverEmail.GetUserExtendedInternalAssignedTo", "deaf5722-2f10-43c8-842b-f22b9c2eda89", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xsp6fso+Rkq1qf7FxBnM7Q/NodesNotShownInESpaceTree.Ilev3hAvyEOEK_IrnC7aiQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser78\".\"id\" o0, \"enuser78\".\"name\" o1, \"enuser78\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enuserextension41\".\"emailto\" o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal47\" Inner JOIN {User} \"enuser78\" ON (\"enuser_extended_internal47\".\"id\" = \"enuser78\".\"id\"))  Left JOIN {UserExtension} \"enuserextension41\" ON (\"enuser78\".\"id\" = \"enuserextension41\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser78\".\"id\" = @qpusUser_Id) AND (\"enuser78\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser78\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventSendFolioNextApproverEmail.GetUserExtendedInternalAssignedTo.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventSendFolioNextApproverEmail.GetUserExtendedInternalAssignedTo.List", cancellationToken: cancellationToken);
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
