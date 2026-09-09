namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvEmailFirstApprov_ToApprove : VarsBag {
public long inParami_InvoiceId;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUserExtendedInternalAssignedTo_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUserExtendedInternalAssignedTo_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_130cdfa67e01f3ebccac7a2b8ceec0bf queryResGetInvoiceById_outParamList = new RL_130cdfa67e01f3ebccac7a2b8ceec0bf();
public long queryResGetInvoiceById_outParamCount = 0L;

public lcvInvEmailFirstApprov_ToApprove(long inParami_InvoiceId) {
this.inParami_InvoiceId = inParami_InvoiceId;
}
}
/// <summary>
/// Action <code>InvEmailFirstApprov_ToApprove</code> that represents the Service Studio action
///  <code>InvEmailFirstApprov_ToApprove</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvEmailFirstApprov_ToApprove(IRequestContext requestContext,long inParami_InvoiceId,CancellationToken cancellationToken) {
lcvInvEmailFirstApprov_ToApprove localVars = new lcvInvEmailFirstApprov_ToApprove(inParami_InvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvEmailFirstApprov_ToApprove", "2e108138-edf0-45b6-8dae-d10a71cc8965"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvEmailFirstApprov_ToApprove", "2e108138-edf0-45b6-8dae-d10a71cc8965", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvEmailFirstApprov_ToApprove.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// Query datasetGetUserExtendedInternalAssignedTo
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalAssignedTo_maxRecords = 1;
if (datasetGetUserExtendedInternalAssignedTo_maxRecords < 1) datasetGetUserExtendedInternalAssignedTo_maxRecords = 1;
int datasetGetUserExtendedInternalAssignedTo_startIndex = 0;(localVars.queryResGetUserExtendedInternalAssignedTo_outParamList,localVars.queryResGetUserExtendedInternalAssignedTo_outParamCount) = await FuncActionInvEmailFirstApprov_ToApprove.datasetGetUserExtendedInternalAssignedTo(requestContext,datasetGetUserExtendedInternalAssignedTo_maxRecords,datasetGetUserExtendedInternalAssignedTo_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,new ST_12668886130225cd5b17c72a6562dd7cStructure(){ ssUserId = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssId, ssEmail = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssEmail, ssName = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUser.ssName, ssEmailTo = localVars.queryResGetUserExtendedInternalAssignedTo_outParamList.CurrentRec.ssENUserExtension.ssEmailto },cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",0,(("Facturas -"+((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssIsNewVersion) ? (" Factura Modificada ") : (" Nueva Factura ")))+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName),(((((("La factura "+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" acaba de ser ")+((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssIsNewVersion) ? ("modificada") : ("creada")))+" por ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENUser.ssName)+" y está esperando su aprobación."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("FirstApproverInvoice", "161f9daa-a78d-4b17-8fad-7998addb7df0"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("FirstApproverInvoice", "161f9daa-a78d-4b17-8fad-7998addb7df0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowd_Inv_Emails.d_Inv_Emails_FirstApproverInvoice>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName, localVars.varLcl_EmailNotification.CurrentRec.ssName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENUser.ssName, localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssIsNewVersion, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionInvEmailFirstApprov_ToApprove {

private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUserExtendedInternalAssignedToReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalAssignedTo" UNnzcF3ZUUyYPHa_enKwZA of Action "InvEmailFirstApprov_ToApprove"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserExtendedInternalAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstApprov_ToApprove.GetUserExtendedInternalAssignedTo", "70f3d950-d95d-4c51-983c-76bf7a72b064");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstApprov_ToApprove.GetUserExtendedInternalAssignedTo", "70f3d950-d95d-4c51-983c-76bf7a72b064", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.OIEQLvDttkWNrtEKccyJZQ/NodesNotShownInESpaceTree.UNnzcF3ZUUyYPHa_enKwZA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser29\".\"id\" o0, \"enuser29\".\"name\" o1, \"enuser29\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enuserextension16\".\"emailto\" o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal19\" Inner JOIN {User} \"enuser29\" ON (\"enuser_extended_internal19\".\"id\" = \"enuser29\".\"id\"))  Left JOIN {UserExtension} \"enuserextension16\" ON (\"enuser29\".\"id\" = \"enuserextension16\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser29\".\"id\" = @qpusUser_Id) AND (\"enuser29\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser29\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstApprov_ToApprove.GetUserExtendedInternalAssignedTo.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstApprov_ToApprove.GetUserExtendedInternalAssignedTo.List", cancellationToken: cancellationToken);
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

private static async Task<RC_79a9c9a7ac5e18f00a42c0574d6a2449> datasetGetInvoiceByIdReadDbAsync(RC_79a9c9a7ac5e18f00a42c0574d6a2449 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" ieEm5rec_kOUnahHIAvllw of Action "InvEmailFirstApprov_ToApprove"
public static async Task<(RL_130cdfa67e01f3ebccac7a2b8ceec0bf,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstApprov_ToApprove.GetInvoiceById", "e626e189-9cb7-43fe-949d-a847200be597");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstApprov_ToApprove.GetInvoiceById", "e626e189-9cb7-43fe-949d-a847200be597", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.OIEQLvDttkWNrtEKccyJZQ/NodesNotShownInESpaceTree.ieEm5rec_kOUnahHIAvllw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice8\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"eninvoice8\".\"isnewversion\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"eninvoiceapprovallevel2\".\"assignedto\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, \"enuser30\".\"name\" o118, NULL o119, NULL o120, NULL o121");
fromBuilder.Append(" FROM (((({Invoice} \"eninvoice8\" Left JOIN {InvoiceApproval} \"eninvoiceapproval2\" ON (\"eninvoice8\".\"id\" = \"eninvoiceapproval2\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel2\" ON (\"eninvoiceapproval2\".\"id\" = \"eninvoiceapprovallevel2\".\"invoiceapprovalid\"))  Left JOIN {User} \"enuser30\" ON (\"eninvoice8\".\"createdby\" = \"enuser30\".\"id\"))  Left JOIN {Requisition} \"enrequisition12\" ON (\"eninvoice8\".\"requisitionid\" = \"enrequisition12\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice8\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice8\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice8\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel2\".\"levelnumber\" ASC ");
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
RL_130cdfa67e01f3ebccac7a2b8ceec0bf outParamList = new RL_130cdfa67e01f3ebccac7a2b8ceec0bf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstApprov_ToApprove.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_130cdfa67e01f3ebccac7a2b8ceec0bf _tmp = new RL_130cdfa67e01f3ebccac7a2b8ceec0bf();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstApprov_ToApprove.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_130cdfa67e01f3ebccac7a2b8ceec0bf)_tmp;
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
