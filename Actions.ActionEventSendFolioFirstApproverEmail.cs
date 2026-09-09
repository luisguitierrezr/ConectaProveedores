namespace ssConectaProveedores;

public partial class Actions {
public class lcvEventSendFolioFirstApproverEmail : VarsBag {
public long inParami_FolioId;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_acaf133767807a8b8b2412d4fe6cd8a1 queryResGetFolioById_outParamList = new RL_acaf133767807a8b8b2412d4fe6cd8a1();
public long queryResGetFolioById_outParamCount = 0L;

public RL_3a99147a5a14669e8ced82dd9eebacf0 queryResGetUserExtendedInternalsByRegionId_outParamList = new RL_3a99147a5a14669e8ced82dd9eebacf0();
public long queryResGetUserExtendedInternalsByRegionId_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUserExtendedInternalAssignedTo2_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUserExtendedInternalAssignedTo2_outParamCount = 0L;

public lcvEventSendFolioFirstApproverEmail(long inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}
}
/// <summary>
/// Action <code>EventSendFolioFirstApproverEmail</code> that represents the Service Studio action
///  <code>EventSendFolioFirstApproverEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionEventSendFolioFirstApproverEmail(IRequestContext requestContext,long inParami_FolioId,CancellationToken cancellationToken) {
lcvEventSendFolioFirstApproverEmail localVars = new lcvEventSendFolioFirstApproverEmail(inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EventSendFolioFirstApproverEmail", "08477907-867f-43ab-88bd-16792041a4b3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EventSendFolioFirstApproverEmail", "08477907-867f-43ab-88bd-16792041a4b3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionEventSendFolioFirstApproverEmail.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Single,localVars.inParami_FolioId,cancellationToken);

// AssignedTo?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ()))) {
// Query datasetGetUserExtendedInternalAssignedTo2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalAssignedTo2_maxRecords = 1;
if (datasetGetUserExtendedInternalAssignedTo2_maxRecords < 1) datasetGetUserExtendedInternalAssignedTo2_maxRecords = 1;
int datasetGetUserExtendedInternalAssignedTo2_startIndex = 0;(localVars.queryResGetUserExtendedInternalAssignedTo2_outParamList,localVars.queryResGetUserExtendedInternalAssignedTo2_outParamCount) = await FuncActionEventSendFolioFirstApproverEmail.datasetGetUserExtendedInternalAssignedTo2(requestContext,datasetGetUserExtendedInternalAssignedTo2_maxRecords,datasetGetUserExtendedInternalAssignedTo2_startIndex,IterationMultiplicity.Never,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssAssignedTo,cancellationToken);

// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,new ST_12668886130225cd5b17c72a6562dd7cStructure(){ ssUserId = localVars.queryResGetUserExtendedInternalAssignedTo2_outParamList.CurrentRec.ssENUser.ssId, ssEmail = localVars.queryResGetUserExtendedInternalAssignedTo2_outParamList.CurrentRec.ssENUser.ssEmail, ssName = localVars.queryResGetUserExtendedInternalAssignedTo2_outParamList.CurrentRec.ssENUser.ssName, ssEmailTo = localVars.queryResGetUserExtendedInternalAssignedTo2_outParamList.CurrentRec.ssENUserExtension.ssEmailto },cancellationToken);

} else {
// Foreach GetFolioById.List
localVars.queryResGetFolioById_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioById_outParamList.Eof))) {
// Query datasetGetUserExtendedInternalsByRegionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalsByRegionId_maxRecords = 0;
int datasetGetUserExtendedInternalsByRegionId_startIndex = 0;(localVars.queryResGetUserExtendedInternalsByRegionId_outParamList,localVars.queryResGetUserExtendedInternalsByRegionId_outParamCount) = await FuncActionEventSendFolioFirstApproverEmail.datasetGetUserExtendedInternalsByRegionId(requestContext,datasetGetUserExtendedInternalsByRegionId_maxRecords,datasetGetUserExtendedInternalsByRegionId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssRegionId,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApplicationRoleId,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApprovalLevel.ssEntraRoleId,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssDivisionId,cancellationToken);

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
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",0,("Folios - Aprobar Folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber),((((((("El folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" acaba de ser creado por ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssName)+"(")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssNumber)+")")+" y está esperando su aprobación."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("FirstApproverFolio", "618e4afe-2f68-4280-b2bd-0a65d79a4967"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("FirstApproverFolio", "618e4afe-2f68-4280-b2bd-0a65d79a4967", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_FirstApproverFolio>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, (((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssName+"(")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssNumber)+")"), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionEventSendFolioFirstApproverEmail {

private static async Task<RC_c05f5f529fd46e2239b1c8228703d2c7> datasetGetFolioByIdReadDbAsync(RC_c05f5f529fd46e2239b1c8228703d2c7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" _OBnKm9CFkS1rR0QmQSmcg of Action "EventSendFolioFirstApproverEmail"
public static async Task<(RL_acaf133767807a8b8b2412d4fe6cd8a1,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventSendFolioFirstApproverEmail.GetFolioById", "2a67e0fc-426f-4416-b5ad-1d109904a672");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventSendFolioFirstApproverEmail.GetFolioById", "2a67e0fc-426f-4416-b5ad-1d109904a672", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.B3lHCH+Gq0OIvRZ5IEGksw/NodesNotShownInESpaceTree._OBnKm9CFkS1rR0QmQSmcg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enfolioapproval\".\"regionid\" o29, NULL o30, NULL o31, NULL o32, \"enfolioapprovallevel\".\"applicationroleid\" o33, NULL o34, \"enfolioapprovallevel\".\"entraroleid\" o35, NULL o36, \"enfolioapprovallevel\".\"assignedto\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, \"enordermain\".\"divisionid\" o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"ensupplier3\".\"name\" o81, \"ensupplier3\".\"number\" o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111");
fromBuilder.Append(" FROM ((((({Folio} \"enfolio\" Left JOIN {FolioApproval} \"enfolioapproval\" ON (\"enfolio\".\"id\" = \"enfolioapproval\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel\" ON (\"enfolioapproval\".\"id\" = \"enfolioapprovallevel\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain\" ON (\"enfolio\".\"orderid\" = \"enordermain\".\"id\"))  Left JOIN {User} \"enuser7\" ON (\"enfolio\".\"createdby\" = \"enuser7\".\"id\"))  Left JOIN {Supplier} \"ensupplier3\" ON (\"enfolio\".\"supplierid\" = \"ensupplier3\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio\".\"id\" = @qpfoFolio_Id) AND (\"enfolio\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel\".\"approvalstatusid\" = ");
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
RL_acaf133767807a8b8b2412d4fe6cd8a1 outParamList = new RL_acaf133767807a8b8b2412d4fe6cd8a1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, false, true, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventSendFolioFirstApproverEmail.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_acaf133767807a8b8b2412d4fe6cd8a1 _tmp = new RL_acaf133767807a8b8b2412d4fe6cd8a1();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventSendFolioFirstApproverEmail.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_acaf133767807a8b8b2412d4fe6cd8a1)_tmp;
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
// Query Function "GetUserExtendedInternalsByRegionId" 8UkMV85phkWicKR1dBwPsQ of Action "EventSendFolioFirstApproverEmail"
public static async Task<(RL_3a99147a5a14669e8ced82dd9eebacf0,long)> datasetGetUserExtendedInternalsByRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreUser_Extended_Internal_RegionId,long qpapApplicationRole_Id,long qpenEntraRole_Id,long qpreUser_Extended_Internal_RegionId1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventSendFolioFirstApproverEmail.GetUserExtendedInternalsByRegionId", "570c49f1-69ce-4586-a270-a475741c0fb1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventSendFolioFirstApproverEmail.GetUserExtendedInternalsByRegionId", "570c49f1-69ce-4586-a270-a475741c0fb1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.B3lHCH+Gq0OIvRZ5IEGksw/NodesNotShownInESpaceTree.8UkMV85phkWicKR1dBwPsQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enuser8\".\"id\" o17, \"enuser8\".\"name\" o18, \"enuser8\".\"email\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, \"enuserextension3\".\"emailto\" o44");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal3\" Inner JOIN {User} \"enuser8\" ON (\"enuser_extended_internal3\".\"id\" = \"enuser8\".\"id\"))  Left JOIN {UserExtension} \"enuserextension3\" ON (\"enuser8\".\"id\" = \"enuserextension3\".\"id\"))  Left JOIN {EntraRole} \"enentrarole1\" ON (\"enuser_extended_internal3\".\"entraroleid\" = \"enentrarole1\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept1\" ON (\"enentrarole1\".\"id\" = \"enroleconcept1\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole1\" ON (\"enroleconcept1\".\"applicationroleid\" = \"enapplicationrole1\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpreUser_Extended_Internal_RegionId <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal3\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal3\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal3\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpreUser_Extended_Internal_RegionId1 != 0) {
whereBuilder.Append("((\"enuser_extended_internal3\".\"regionid\" = @qpreUser_Extended_Internal_RegionId1) AND (\"enuser_extended_internal3\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId1", DbType.Int64, qpreUser_Extended_Internal_RegionId1);
} else {
whereBuilder.Append("(\"enuser_extended_internal3\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1) AND ((CASE WHEN (@qpapApplicationRole_Id <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpapApplicationRole_Id", DbType.Int64, qpapApplicationRole_Id);
if (qpapApplicationRole_Id != 0) {
whereBuilder.Append("((\"enapplicationrole1\".\"id\" = @qpapApplicationRole_Id) AND (\"enapplicationrole1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApplicationRole_Id", DbType.Int64, qpapApplicationRole_Id);
} else {
whereBuilder.Append("(\"enapplicationrole1\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpenEntraRole_Id != 0) {
whereBuilder.Append("((\"enentrarole1\".\"id\" = @qpenEntraRole_Id) AND (\"enentrarole1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenEntraRole_Id", DbType.Int64, qpenEntraRole_Id);
} else {
whereBuilder.Append("(\"enentrarole1\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventSendFolioFirstApproverEmail.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventSendFolioFirstApproverEmail.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUserExtendedInternalAssignedTo2ReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalAssignedTo2" LHDTxmcEOUGAN0St+zh03A of Action "EventSendFolioFirstApproverEmail"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserExtendedInternalAssignedTo2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EventSendFolioFirstApproverEmail.GetUserExtendedInternalAssignedTo2", "c6d3702c-0467-4139-8037-44adfb3874dc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EventSendFolioFirstApproverEmail.GetUserExtendedInternalAssignedTo2", "c6d3702c-0467-4139-8037-44adfb3874dc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.B3lHCH+Gq0OIvRZ5IEGksw/NodesNotShownInESpaceTree.LHDTxmcEOUGAN0St+zh03A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser9\".\"id\" o0, \"enuser9\".\"name\" o1, \"enuser9\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enuserextension4\".\"emailto\" o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal4\" Inner JOIN {User} \"enuser9\" ON (\"enuser_extended_internal4\".\"id\" = \"enuser9\".\"id\"))  Left JOIN {UserExtension} \"enuserextension4\" ON (\"enuser9\".\"id\" = \"enuserextension4\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser9\".\"id\" = @qpusUser_Id) AND (\"enuser9\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser9\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalAssignedTo2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EventSendFolioFirstApproverEmail.GetUserExtendedInternalAssignedTo2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bc2063fe1d05aa544017f329fb1e030b _tmp = new RL_bc2063fe1d05aa544017f329fb1e030b();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalAssignedTo2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EventSendFolioFirstApproverEmail.GetUserExtendedInternalAssignedTo2.List", cancellationToken: cancellationToken);
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
