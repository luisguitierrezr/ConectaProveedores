namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvEmailFirstApprov_Modify : VarsBag {
public long inParami_InvoiceId;
public string inParami_ModifyReason;
public string inParami_UserRequestedModification;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetApprovers_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetApprovers_outParamCount = 0L;

public RL_3e9501626d68e0b595764f7f1bae2fae queryResGetUserRequestedModificationById_outParamList = new RL_3e9501626d68e0b595764f7f1bae2fae();
public long queryResGetUserRequestedModificationById_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_519cfbd5c9d3e969a6c55ad5a0702da1 queryResGetUsersProveedores_outParamList = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
public long queryResGetUsersProveedores_outParamCount = 0L;

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserExtendedInternal_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserExtendedInternal_outParamCount = 0L;

public RL_4d0a053561fa4a3aef04e507b83b31d1 queryResGetInvoiceById_outParamList = new RL_4d0a053561fa4a3aef04e507b83b31d1();
public long queryResGetInvoiceById_outParamCount = 0L;

public lcvInvEmailFirstApprov_Modify(long inParami_InvoiceId, string inParami_ModifyReason, string inParami_UserRequestedModification) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_ModifyReason = inParami_ModifyReason;
this.inParami_UserRequestedModification = inParami_UserRequestedModification;
}
}
/// <summary>
/// Action <code>InvEmailFirstApprov_Modify</code> that represents the Service Studio action
///  <code>InvEmailFirstApprov_Modify</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvEmailFirstApprov_Modify(IRequestContext requestContext,long inParami_InvoiceId,string inParami_ModifyReason,string inParami_UserRequestedModification,CancellationToken cancellationToken) {
lcvInvEmailFirstApprov_Modify localVars = new lcvInvEmailFirstApprov_Modify(inParami_InvoiceId, inParami_ModifyReason, inParami_UserRequestedModification);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvEmailFirstApprov_Modify", "64df77c1-cfde-4c2b-85d5-012f803081c1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvEmailFirstApprov_Modify", "64df77c1-cfde-4c2b-85d5-012f803081c1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvEmailFirstApprov_Modify.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// Query datasetGetApprovers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovers_maxRecords = 0;
int datasetGetApprovers_startIndex = 0;(localVars.queryResGetApprovers_outParamList,localVars.queryResGetApprovers_outParamCount) = await FuncActionInvEmailFirstApprov_Modify.datasetGetApprovers(requestContext,datasetGetApprovers_maxRecords,datasetGetApprovers_startIndex,IterationMultiplicity.Single,localVars.inParami_InvoiceId,cancellationToken);

// Foreach GetApprovers.List
localVars.queryResGetApprovers_outParamList.StartIteration();
try {while (!((localVars.queryResGetApprovers_outParamList.Eof))) {
// Query datasetGetUserExtendedInternal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternal_maxRecords = 1;
if (datasetGetUserExtendedInternal_maxRecords < 1) datasetGetUserExtendedInternal_maxRecords = 1;
int datasetGetUserExtendedInternal_startIndex = 0;(localVars.queryResGetUserExtendedInternal_outParamList,localVars.queryResGetUserExtendedInternal_outParamCount) = await FuncActionInvEmailFirstApprov_Modify.datasetGetUserExtendedInternal(requestContext,datasetGetUserExtendedInternal_maxRecords,datasetGetUserExtendedInternal_startIndex,IterationMultiplicity.Never,localVars.queryResGetApprovers_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedBy,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,(await RecordUtils.ConvertAsync(localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec, new ST_12668886130225cd5b17c72a6562dd7cStructure(), async (RC_e6a121d9e10463243528b9fbc6a71f2e source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssId;
target.ssEmail = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssEmail;
target.ssName = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssName;
target.ssEmailTo = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetApprovers_outParamList.Advance();
}

} finally {
localVars.queryResGetApprovers_outParamList.EndIteration();
}

// Query datasetGetUsersProveedores
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersProveedores_maxRecords = 0;
int datasetGetUsersProveedores_startIndex = 0;(localVars.queryResGetUsersProveedores_outParamList,localVars.queryResGetUsersProveedores_outParamCount) = await FuncActionInvEmailFirstApprov_Modify.datasetGetUsersProveedores(requestContext,datasetGetUsersProveedores_maxRecords,datasetGetUsersProveedores_startIndex,IterationMultiplicity.Single,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssSupplierId,cancellationToken);

// Foreach GetUsersProveedores.List
localVars.queryResGetUsersProveedores_outParamList.StartIteration();
try {while (!((localVars.queryResGetUsersProveedores_outParamList.Eof))) {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,(await RecordUtils.ConvertAsync(localVars.queryResGetUsersProveedores_outParamList.CurrentRec, new ST_12668886130225cd5b17c72a6562dd7cStructure(), async (RC_60b2ce7251b451294681274f8057cbd6 source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = localVars.queryResGetUsersProveedores_outParamList.CurrentRec.ssENUser.ssId;
target.ssEmail = localVars.queryResGetUsersProveedores_outParamList.CurrentRec.ssENUser.ssEmail;
target.ssName = localVars.queryResGetUsersProveedores_outParamList.CurrentRec.ssENUser.ssName;
target.ssEmailTo = localVars.queryResGetUsersProveedores_outParamList.CurrentRec.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetUsersProveedores_outParamList.Advance();
}

} finally {
localVars.queryResGetUsersProveedores_outParamList.EndIteration();
}

// ListSort
await ExtendedActions.ListSort(requestContext,localVars.varLcl_EmailNotification,async (p, cancellationToken) => p.ssUserId,true,cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// l_EmailNotification = ListDistinct.DistinctList
localVars.varLcl_EmailNotification=localVars.resListDistinct_outParamDistinctList;
// Query datasetGetUserRequestedModificationById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserRequestedModificationById_maxRecords = 1;
if (datasetGetUserRequestedModificationById_maxRecords < 1) datasetGetUserRequestedModificationById_maxRecords = 1;
int datasetGetUserRequestedModificationById_startIndex = 0;(localVars.queryResGetUserRequestedModificationById_outParamList,localVars.queryResGetUserRequestedModificationById_outParamCount) = await FuncActionInvEmailFirstApprov_Modify.datasetGetUserRequestedModificationById(requestContext,datasetGetUserRequestedModificationById_maxRecords,datasetGetUserRequestedModificationById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserRequestedModification,cancellationToken);

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",1,("Facturas - Pedido de Modificación de la Factura "+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName),(((((("La factura "+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" recibió un pedido de modificación por :")+localVars.queryResGetUserRequestedModificationById_outParamList.CurrentRec.ssName)+"\r\n")+"\r\n")+localVars.inParami_ModifyReason),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ModifyInvoice", "3871d7e7-7378-42c7-9762-2ad09869cd06"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ModifyInvoice", "3871d7e7-7378-42c7-9762-2ad09869cd06", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowd_Inv_Emails.d_Inv_Emails_ModifyInvoice>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName, localVars.varLcl_EmailNotification.CurrentRec.ssName, localVars.inParami_ModifyReason, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetUserRequestedModificationById_outParamList.CurrentRec.ssName, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionInvEmailFirstApprov_Modify {

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetApproversReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovers" W3NXA5yEskatnn_GNmW2pg of Action "InvEmailFirstApprov_Modify"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetApprovers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstApprov_Modify.GetApprovers", "0357735b-849c-46b2-ad9e-7fc63665b6a6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstApprov_Modify.GetApprovers", "0357735b-849c-46b2-ad9e-7fc63665b6a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.wXffZN7PK0yF1QEvgDCBwQ/NodesNotShownInESpaceTree.W3NXA5yEskatnn_GNmW2pg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, \"eninvoiceapprovallevel11\".\"approvedby\" o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice25\" Left JOIN {InvoiceApproval} \"eninvoiceapproval10\" ON (\"eninvoice25\".\"id\" = \"eninvoiceapproval10\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel11\" ON (\"eninvoiceapproval10\".\"id\" = \"eninvoiceapprovallevel11\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice25\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice25\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice25\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel11\".\"approvedby\" IS NOT NULL)");
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
RL_e8a2bfdbad62aa404e80d55d80faa387 outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApproversReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstApprov_Modify.GetApprovers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetApproversReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstApprov_Modify.GetApprovers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e8a2bfdbad62aa404e80d55d80faa387)_tmp;
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

// Query Function "GetUserRequestedModificationById" ARR2DA8J0Ui6t3+R9AKs9A of Action "InvEmailFirstApprov_Modify"
public static async Task<(RL_3e9501626d68e0b595764f7f1bae2fae,long)> datasetGetUserRequestedModificationById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstApprov_Modify.GetUserRequestedModificationById", "0c761401-090f-48d1-bab7-7f91f402acf4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstApprov_Modify.GetUserRequestedModificationById", "0c761401-090f-48d1-bab7-7f91f402acf4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.wXffZN7PK0yF1QEvgDCBwQ/NodesNotShownInESpaceTree.ARR2DA8J0Ui6t3+R9AKs9A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser63\".\"name\" \"name\"");
fromBuilder.Append(" FROM {User} \"enuser63\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser63\".\"id\" = @qpusId) AND (\"enuser63\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser63\".\"id\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enuser63\".\"name\"");
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
RL_3e9501626d68e0b595764f7f1bae2fae outParamList = new RL_3e9501626d68e0b595764f7f1bae2fae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstApprov_Modify.GetUserRequestedModificationById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3e9501626d68e0b595764f7f1bae2fae _tmp = new RL_3e9501626d68e0b595764f7f1bae2fae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstApprov_Modify.GetUserRequestedModificationById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3e9501626d68e0b595764f7f1bae2fae)_tmp;
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

private static async Task<RC_60b2ce7251b451294681274f8057cbd6> datasetGetUsersProveedoresReadDbAsync(RC_60b2ce7251b451294681274f8057cbd6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSupplierUser.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUsersProveedores" bodSeZVWXkmqtjbXlrVc0g of Action "InvEmailFirstApprov_Modify"
public static async Task<(RL_519cfbd5c9d3e969a6c55ad5a0702da1,long)> datasetGetUsersProveedores(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplierUser_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstApprov_Modify.GetUsersProveedores", "7952876e-5695-495e-aab6-36d796b55cd2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstApprov_Modify.GetUsersProveedores", "7952876e-5695-495e-aab6-36d796b55cd2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.wXffZN7PK0yF1QEvgDCBwQ/NodesNotShownInESpaceTree.bodSeZVWXkmqtjbXlrVc0g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplieruser7\".\"id\" o0, \"ensupplieruser7\".\"supplierid\" o1, \"ensupplieruser7\".\"userid\" o2, \"ensupplieruser7\".\"name\" o3, \"ensupplieruser7\".\"email\" o4, \"ensupplieruser7\".\"activationemailsentdate\" o5, \"ensupplieruser7\".\"isactive\" o6, \"ensupplieruser7\".\"isdeleted\" o7, \"ensupplieruser7\".\"isblocked\" o8, \"ensupplieruser7\".\"blockeduntil\" o9, \"ensupplieruser7\".\"lastlogindate\" o10, \"ensupplieruser7\".\"createdby\" o11, \"ensupplieruser7\".\"createdon\" o12, \"ensupplieruser7\".\"updatedby\" o13, \"ensupplieruser7\".\"updatedon\" o14, \"enuser64\".\"id\" o15, \"enuser64\".\"name\" o16, \"enuser64\".\"email\" o17, \"enuser64\".\"photourl\" o18, \"enuser64\".\"username\" o19, \"enuserextension33\".\"id\" o20, \"enuserextension33\".\"correspondentexternalemail\" o21, \"enuserextension33\".\"emailto\" o22");
fromBuilder.Append(" FROM (({User} \"enuser64\" Left JOIN {UserExtension} \"enuserextension33\" ON (\"enuser64\".\"id\" = \"enuserextension33\".\"id\"))  Left JOIN {SupplierUser} \"ensupplieruser7\" ON (\"enuser64\".\"id\" = \"ensupplieruser7\".\"userid\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierUser_SupplierId != 0) {
whereBuilder.Append("((\"ensupplieruser7\".\"supplierid\" = @qpsuSupplierUser_SupplierId) AND (\"ensupplieruser7\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierUser_SupplierId", DbType.Int64, qpsuSupplierUser_SupplierId);
} else {
whereBuilder.Append("(\"ensupplieruser7\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"ensupplieruser7\".\"isactive\" = 1)");
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
RL_519cfbd5c9d3e969a6c55ad5a0702da1 outParamList = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersProveedoresReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstApprov_Modify.GetUsersProveedores.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_519cfbd5c9d3e969a6c55ad5a0702da1 _tmp = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersProveedoresReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstApprov_Modify.GetUsersProveedores.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_519cfbd5c9d3e969a6c55ad5a0702da1)_tmp;
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

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserExtendedInternalReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternal" Z1I5roKRz0K_X6zrD_s6Mg of Action "InvEmailFirstApprov_Modify"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserExtendedInternal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstApprov_Modify.GetUserExtendedInternal", "ae395267-9182-42cf-bf5f-aceb0ffb3a32");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstApprov_Modify.GetUserExtendedInternal", "ae395267-9182-42cf-bf5f-aceb0ffb3a32", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.wXffZN7PK0yF1QEvgDCBwQ/NodesNotShownInESpaceTree.Z1I5roKRz0K_X6zrD_s6Mg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser65\".\"id\" o0, \"enuser65\".\"name\" o1, \"enuser65\".\"email\" o2, \"enuser65\".\"photourl\" o3, \"enuser65\".\"username\" o4, \"enuserextension34\".\"id\" o5, \"enuserextension34\".\"correspondentexternalemail\" o6, \"enuserextension34\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser65\" Left JOIN {UserExtension} \"enuserextension34\" ON (\"enuser65\".\"id\" = \"enuserextension34\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser65\".\"id\" = @qpusUser_Id) AND (\"enuser65\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser65\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstApprov_Modify.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstApprov_Modify.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
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

private static async Task<RC_003d65e5661b449409d67ebedc16a923> datasetGetInvoiceByIdReadDbAsync(RC_003d65e5661b449409d67ebedc16a923 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" codQ2UmZo0+2LVa1IwJC3Q of Action "InvEmailFirstApprov_Modify"
public static async Task<(RL_4d0a053561fa4a3aef04e507b83b31d1,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstApprov_Modify.GetInvoiceById", "d9508772-9949-4fa3-b62d-56b5230242dd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstApprov_Modify.GetInvoiceById", "d9508772-9949-4fa3-b62d-56b5230242dd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.wXffZN7PK0yF1QEvgDCBwQ/NodesNotShownInESpaceTree.codQ2UmZo0+2LVa1IwJC3Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice26\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"enrequisition29\".\"supplierid\" o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice26\" Left JOIN {Requisition} \"enrequisition29\" ON (\"eninvoice26\".\"requisitionid\" = \"enrequisition29\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice26\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice26\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice26\".\"id\" IS NULL)");
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
RL_4d0a053561fa4a3aef04e507b83b31d1 outParamList = new RL_4d0a053561fa4a3aef04e507b83b31d1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstApprov_Modify.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4d0a053561fa4a3aef04e507b83b31d1 _tmp = new RL_4d0a053561fa4a3aef04e507b83b31d1();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstApprov_Modify.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4d0a053561fa4a3aef04e507b83b31d1)_tmp;
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
