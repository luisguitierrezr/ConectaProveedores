namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendReqFirstApproverEmail : VarsBag {
public long inParami_RequisitionId;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_4f4f1e0635df8f6f1fa713c495dfccae queryResGetRequisitionById_outParamList = new RL_4f4f1e0635df8f6f1fa713c495dfccae();
public long queryResGetRequisitionById_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUserExtendedInternalAssignedTo_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUserExtendedInternalAssignedTo_outParamCount = 0L;

public lcvSendReqFirstApproverEmail(long inParami_RequisitionId) {
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
/// <summary>
/// Action <code>SendReqFirstApproverEmail</code> that represents the Service Studio action
///  <code>SendReqFirstApproverEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendReqFirstApproverEmail(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
lcvSendReqFirstApproverEmail localVars = new lcvSendReqFirstApproverEmail(inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendReqFirstApproverEmail", "ec8c4cc4-1a08-4fec-a819-cedf496f81bb"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendReqFirstApproverEmail", "ec8c4cc4-1a08-4fec-a819-cedf496f81bb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionSendReqFirstApproverEmail.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetUserExtendedInternalAssignedTo
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalAssignedTo_maxRecords = 1;
if (datasetGetUserExtendedInternalAssignedTo_maxRecords < 1) datasetGetUserExtendedInternalAssignedTo_maxRecords = 1;
int datasetGetUserExtendedInternalAssignedTo_startIndex = 0;(localVars.queryResGetUserExtendedInternalAssignedTo_outParamList,localVars.queryResGetUserExtendedInternalAssignedTo_outParamCount) = await FuncActionSendReqFirstApproverEmail.datasetGetUserExtendedInternalAssignedTo(requestContext,datasetGetUserExtendedInternalAssignedTo_maxRecords,datasetGetUserExtendedInternalAssignedTo_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRegionId,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,new ST_12668886130225cd5b17c72a6562dd7cStructure(){ ssUserId = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssId, ssEmail = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssEmail, ssName = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssName, ssEmailTo = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUserExtension.ssEmailto },cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",0,(("Requisiciones -"+(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssMaxDateFinishCapture==BuiltInFunction.NullDate ())) ? (" Requisición Modificada ") : (" Nueva Requisición ")))+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName),(((((("La requisición "+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName)+" acaba de ser ")+(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssMaxDateFinishCapture==BuiltInFunction.NullDate ())) ? ("modificada") : ("creada")))+" por ")+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENUser.ssName)+" y está esperando su aprobación."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("FirstApproverRequisition", "2432635b-d933-477f-aac7-ac2bf903c264"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("FirstApproverRequisition", "2432635b-d933-477f-aac7-ac2bf903c264", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowc_Req_Emails.c_Req_Emails_FirstApproverRequisition>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName, localVars.varLcl_EmailNotification.CurrentRec.ssName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENUser.ssName, (localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssMaxDateFinishCapture==BuiltInFunction.NullDate ()), (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", cancellationToken),
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

public static class FuncActionSendReqFirstApproverEmail {

private static async Task<RC_be45dbebd99ff43af730ddaaf3b9d0b9> datasetGetRequisitionByIdReadDbAsync(RC_be45dbebd99ff43af730ddaaf3b9d0b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" O20ug4tBA0yGGVx9SSeLjA of Action "SendReqFirstApproverEmail"
public static async Task<(RL_4f4f1e0635df8f6f1fa713c495dfccae,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendReqFirstApproverEmail.GetRequisitionById", "832e6d3b-418b-4c03-8619-5c7d49278b8c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendReqFirstApproverEmail.GetRequisitionById", "832e6d3b-418b-4c03-8619-5c7d49278b8c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xEyM7Aga7E+oGc7fSW+Buw/NodesNotShownInESpaceTree.O20ug4tBA0yGGVx9SSeLjA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enrequisition69\".\"name\" o1, NULL o2, NULL o3, NULL o4, \"enrequisition69\".\"regionid\" o5, NULL o6, NULL o7, \"enrequisition69\".\"maxdatefinishcapture\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, \"enrequisitionapprovallevel21\".\"assignedto\" o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, \"enuser131\".\"name\" o95, NULL o96, NULL o97, NULL o98");
fromBuilder.Append(" FROM ((({Requisition} \"enrequisition69\" Left JOIN {RequisitionApproval} \"enrequisitionapproval24\" ON (\"enrequisition69\".\"id\" = \"enrequisitionapproval24\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel21\" ON (\"enrequisitionapproval24\".\"id\" = \"enrequisitionapprovallevel21\".\"requisitionapprovalid\"))  Left JOIN {User} \"enuser131\" ON (\"enrequisition69\".\"applicantid\" = \"enuser131\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition69\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition69\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition69\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enrequisitionapprovallevel21\".\"levelnumber\" ASC ");
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
RL_4f4f1e0635df8f6f1fa713c495dfccae outParamList = new RL_4f4f1e0635df8f6f1fa713c495dfccae();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendReqFirstApproverEmail.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f4f1e0635df8f6f1fa713c495dfccae _tmp = new RL_4f4f1e0635df8f6f1fa713c495dfccae();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendReqFirstApproverEmail.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f4f1e0635df8f6f1fa713c495dfccae)_tmp;
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
// Query Function "GetUserExtendedInternalAssignedTo" UoN8xg0A3Ei4LqL0TDmT8w of Action "SendReqFirstApproverEmail"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserExtendedInternalAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreUser_Extended_Internal_RegionId,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendReqFirstApproverEmail.GetUserExtendedInternalAssignedTo", "c67c8352-000d-48dc-b82e-a2f44c3993f3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendReqFirstApproverEmail.GetUserExtendedInternalAssignedTo", "c67c8352-000d-48dc-b82e-a2f44c3993f3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xEyM7Aga7E+oGc7fSW+Buw/NodesNotShownInESpaceTree.UoN8xg0A3Ei4LqL0TDmT8w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser132\".\"id\" o0, \"enuser132\".\"name\" o1, \"enuser132\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enuserextension61\".\"emailto\" o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal78\" Inner JOIN {User} \"enuser132\" ON (\"enuser_extended_internal78\".\"id\" = \"enuser132\".\"id\"))  Left JOIN {UserExtension} \"enuserextension61\" ON (\"enuser132\".\"id\" = \"enuserextension61\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal78\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal78\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal78\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser132\".\"id\" = @qpusUser_Id) AND (\"enuser132\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser132\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendReqFirstApproverEmail.GetUserExtendedInternalAssignedTo.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendReqFirstApproverEmail.GetUserExtendedInternalAssignedTo.List", cancellationToken: cancellationToken);
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
