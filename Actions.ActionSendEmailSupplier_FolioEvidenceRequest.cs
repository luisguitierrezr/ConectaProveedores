namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendEmailSupplier_FolioEvidenceRequest : VarsBag {
public long inParami_FolioId;
public string inParami_UserEvidenceRequest;
public string inParami_EvidenceRequestReason;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_3e9501626d68e0b595764f7f1bae2fae queryResGetUserRequestedModificationById_outParamList = new RL_3e9501626d68e0b595764f7f1bae2fae();
public long queryResGetUserRequestedModificationById_outParamCount = 0L;

public RL_519cfbd5c9d3e969a6c55ad5a0702da1 queryResGetUsersProveedores_outParamList = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
public long queryResGetUsersProveedores_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFolioById_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFolioById_outParamCount = 0L;

public lcvSendEmailSupplier_FolioEvidenceRequest(long inParami_FolioId, string inParami_UserEvidenceRequest, string inParami_EvidenceRequestReason) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_UserEvidenceRequest = inParami_UserEvidenceRequest;
this.inParami_EvidenceRequestReason = inParami_EvidenceRequestReason;
}
}
/// <summary>
/// Action <code>SendEmailSupplier_FolioEvidenceRequest</code> that represents the Service Studio
///  action <code>SendEmailSupplier_FolioEvidenceRequest</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendEmailSupplier_FolioEvidenceRequest(IRequestContext requestContext,long inParami_FolioId,string inParami_UserEvidenceRequest,string inParami_EvidenceRequestReason,CancellationToken cancellationToken) {
lcvSendEmailSupplier_FolioEvidenceRequest localVars = new lcvSendEmailSupplier_FolioEvidenceRequest(inParami_FolioId, inParami_UserEvidenceRequest, inParami_EvidenceRequestReason);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendEmailSupplier_FolioEvidenceRequest", "38a36558-4cc3-475a-b7bf-271709eb0e79"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendEmailSupplier_FolioEvidenceRequest", "38a36558-4cc3-475a-b7bf-271709eb0e79", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionSendEmailSupplier_FolioEvidenceRequest.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Query datasetGetUsersProveedores
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersProveedores_maxRecords = 0;
int datasetGetUsersProveedores_startIndex = 0;(localVars.queryResGetUsersProveedores_outParamList,localVars.queryResGetUsersProveedores_outParamCount) = await FuncActionSendEmailSupplier_FolioEvidenceRequest.datasetGetUsersProveedores(requestContext,datasetGetUsersProveedores_maxRecords,datasetGetUsersProveedores_startIndex,IterationMultiplicity.Single,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssSupplierId,cancellationToken);

// Foreach GetUsersProveedores.List
localVars.queryResGetUsersProveedores_outParamList.StartIteration();
try {while (!((localVars.queryResGetUsersProveedores_outParamList.Eof))) {
// ListAppend
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

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// Query datasetGetUserRequestedModificationById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserRequestedModificationById_maxRecords = 1;
if (datasetGetUserRequestedModificationById_maxRecords < 1) datasetGetUserRequestedModificationById_maxRecords = 1;
int datasetGetUserRequestedModificationById_startIndex = 0;(localVars.queryResGetUserRequestedModificationById_outParamList,localVars.queryResGetUserRequestedModificationById_outParamCount) = await FuncActionSendEmailSupplier_FolioEvidenceRequest.datasetGetUserRequestedModificationById(requestContext,datasetGetUserRequestedModificationById_maxRecords,datasetGetUserRequestedModificationById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserEvidenceRequest,cancellationToken);

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",1,("Folios - Solicitar evidencia del folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber),(((((("Lo folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+"  recibió un pedido de solicitar evidencia por : ")+localVars.queryResGetUserRequestedModificationById_outParamList.CurrentRec.ssName)+"\r\n")+"\r\n")+localVars.inParami_EvidenceRequestReason),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("EvidenceRequestFolio", "808d9a63-92f2-48bf-96e0-4edebd1a0338"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("EvidenceRequestFolio", "808d9a63-92f2-48bf-96e0-4edebd1a0338", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_EvidenceRequestFolio>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, localVars.inParami_EvidenceRequestReason, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetUserRequestedModificationById_outParamList.CurrentRec.ssName, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionSendEmailSupplier_FolioEvidenceRequest {

// Query Function "GetUserRequestedModificationById" DZSBIFZ3mka_Ul2Ptuweig of Action "SendEmailSupplier_FolioEvidenceRequest"
public static async Task<(RL_3e9501626d68e0b595764f7f1bae2fae,long)> datasetGetUserRequestedModificationById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailSupplier_FolioEvidenceRequest.GetUserRequestedModificationById", "2081940d-7756-469a-bf52-5d8fb6ec1e8a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailSupplier_FolioEvidenceRequest.GetUserRequestedModificationById", "2081940d-7756-469a-bf52-5d8fb6ec1e8a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.WGWjOMNMWke3vycXCesOeQ/NodesNotShownInESpaceTree.DZSBIFZ3mka_Ul2Ptuweig, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser37\".\"name\" \"name\"");
fromBuilder.Append(" FROM {User} \"enuser37\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser37\".\"id\" = @qpusId) AND (\"enuser37\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser37\".\"id\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enuser37\".\"name\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailSupplier_FolioEvidenceRequest.GetUserRequestedModificationById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailSupplier_FolioEvidenceRequest.GetUserRequestedModificationById.List", cancellationToken: cancellationToken);
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
// Query Function "GetUsersProveedores" L6HpTvkG80+RmsqUu8LXbA of Action "SendEmailSupplier_FolioEvidenceRequest"
public static async Task<(RL_519cfbd5c9d3e969a6c55ad5a0702da1,long)> datasetGetUsersProveedores(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplierUser_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailSupplier_FolioEvidenceRequest.GetUsersProveedores", "4ee9a12f-06f9-4ff3-919a-ca94bbc2d76c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailSupplier_FolioEvidenceRequest.GetUsersProveedores", "4ee9a12f-06f9-4ff3-919a-ca94bbc2d76c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.WGWjOMNMWke3vycXCesOeQ/NodesNotShownInESpaceTree.L6HpTvkG80+RmsqUu8LXbA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplieruser2\".\"id\" o0, \"ensupplieruser2\".\"supplierid\" o1, \"ensupplieruser2\".\"userid\" o2, \"ensupplieruser2\".\"name\" o3, \"ensupplieruser2\".\"email\" o4, \"ensupplieruser2\".\"activationemailsentdate\" o5, \"ensupplieruser2\".\"isactive\" o6, \"ensupplieruser2\".\"isdeleted\" o7, \"ensupplieruser2\".\"isblocked\" o8, \"ensupplieruser2\".\"blockeduntil\" o9, \"ensupplieruser2\".\"lastlogindate\" o10, \"ensupplieruser2\".\"createdby\" o11, \"ensupplieruser2\".\"createdon\" o12, \"ensupplieruser2\".\"updatedby\" o13, \"ensupplieruser2\".\"updatedon\" o14, \"enuser38\".\"id\" o15, \"enuser38\".\"name\" o16, \"enuser38\".\"email\" o17, \"enuser38\".\"photourl\" o18, \"enuser38\".\"username\" o19, \"enuserextension20\".\"id\" o20, \"enuserextension20\".\"correspondentexternalemail\" o21, \"enuserextension20\".\"emailto\" o22");
fromBuilder.Append(" FROM (({User} \"enuser38\" Left JOIN {UserExtension} \"enuserextension20\" ON (\"enuser38\".\"id\" = \"enuserextension20\".\"id\"))  Left JOIN {SupplierUser} \"ensupplieruser2\" ON (\"enuser38\".\"id\" = \"ensupplieruser2\".\"userid\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierUser_SupplierId != 0) {
whereBuilder.Append("((\"ensupplieruser2\".\"supplierid\" = @qpsuSupplierUser_SupplierId) AND (\"ensupplieruser2\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierUser_SupplierId", DbType.Int64, qpsuSupplierUser_SupplierId);
} else {
whereBuilder.Append("(\"ensupplieruser2\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"ensupplieruser2\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailSupplier_FolioEvidenceRequest.GetUsersProveedores.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailSupplier_FolioEvidenceRequest.GetUsersProveedores.List", cancellationToken: cancellationToken);
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

// Query Function "GetFolioById" 5+jLuJgTlE2Xatdo8iKvrw of Action "SendEmailSupplier_FolioEvidenceRequest"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailSupplier_FolioEvidenceRequest.GetFolioById", "b8cbe8e7-1398-4d94-976a-d768f222afaf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailSupplier_FolioEvidenceRequest.GetFolioById", "b8cbe8e7-1398-4d94-976a-d768f222afaf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.WGWjOMNMWke3vycXCesOeQ/NodesNotShownInESpaceTree.5+jLuJgTlE2Xatdo8iKvrw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio8\".\"folionumber\" o2, NULL o3, NULL o4, \"enfolio8\".\"supplierid\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {Folio} \"enfolio8\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio8\".\"id\" = @qpfoId) AND (\"enfolio8\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio8\".\"id\" IS NULL)");
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailSupplier_FolioEvidenceRequest.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailSupplier_FolioEvidenceRequest.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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
