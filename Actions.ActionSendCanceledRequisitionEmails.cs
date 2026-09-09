namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendCanceledRequisitionEmails : VarsBag {
public long inParami_RequisitionId;
public string inParami_CanceledReason;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserExtendedInternal_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserExtendedInternal_outParamCount = 0L;

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserExtendedInternalApplicant_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserExtendedInternalApplicant_outParamCount = 0L;

public RL_4f4f1e0635df8f6f1fa713c495dfccae queryResGetRequisitionById_outParamList = new RL_4f4f1e0635df8f6f1fa713c495dfccae();
public long queryResGetRequisitionById_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public lcvSendCanceledRequisitionEmails(long inParami_RequisitionId, string inParami_CanceledReason) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_CanceledReason = inParami_CanceledReason;
}
}
/// <summary>
/// Action <code>SendCanceledRequisitionEmails</code> that represents the Service Studio action
///  <code>SendCanceledRequisitionEmails</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendCanceledRequisitionEmails(IRequestContext requestContext,long inParami_RequisitionId,string inParami_CanceledReason,CancellationToken cancellationToken) {
lcvSendCanceledRequisitionEmails localVars = new lcvSendCanceledRequisitionEmails(inParami_RequisitionId, inParami_CanceledReason);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendCanceledRequisitionEmails", "083afbaf-bed1-417d-bb1b-4dc9e46e09e2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendCanceledRequisitionEmails", "083afbaf-bed1-417d-bb1b-4dc9e46e09e2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 0;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionSendCanceledRequisitionEmails.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Single,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetUserExtendedInternalApplicant
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalApplicant_maxRecords = 1;
if (datasetGetUserExtendedInternalApplicant_maxRecords < 1) datasetGetUserExtendedInternalApplicant_maxRecords = 1;
int datasetGetUserExtendedInternalApplicant_startIndex = 0;(localVars.queryResGetUserExtendedInternalApplicant_outParamList,localVars.queryResGetUserExtendedInternalApplicant_outParamCount) = await FuncActionSendCanceledRequisitionEmails.datasetGetUserExtendedInternalApplicant(requestContext,datasetGetUserExtendedInternalApplicant_maxRecords,datasetGetUserExtendedInternalApplicant_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssApplicantId,cancellationToken);

// ListAppendApplicantId
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,(await RecordUtils.ConvertAsync(localVars.queryResGetUserExtendedInternalApplicant_outParamList.CurrentRec, new ST_12668886130225cd5b17c72a6562dd7cStructure(), async (RC_e6a121d9e10463243528b9fbc6a71f2e source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUser.ssId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
target.ssEmailTo = source.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

// Foreach GetRequisitionById.List
localVars.queryResGetRequisitionById_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionById_outParamList.Eof))) {
// Query datasetGetUserExtendedInternal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternal_maxRecords = 1;
if (datasetGetUserExtendedInternal_maxRecords < 1) datasetGetUserExtendedInternal_maxRecords = 1;
int datasetGetUserExtendedInternal_startIndex = 0;(localVars.queryResGetUserExtendedInternal_outParamList,localVars.queryResGetUserExtendedInternal_outParamCount) = await FuncActionSendCanceledRequisitionEmails.datasetGetUserExtendedInternal(requestContext,datasetGetUserExtendedInternal_maxRecords,datasetGetUserExtendedInternal_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedBy,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,(await RecordUtils.ConvertAsync(localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec, new ST_12668886130225cd5b17c72a6562dd7cStructure(), async (RC_e6a121d9e10463243528b9fbc6a71f2e source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssId;
target.ssEmail = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssEmail;
target.ssName = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUser.ssName;
target.ssEmailTo = localVars.queryResGetUserExtendedInternal_outParamList.CurrentRec.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetRequisitionById_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionById_outParamList.EndIteration();
}

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",2,("Requisiciones - Cancelación de la Requisición "+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName),((((("La requisición "+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName)+" fue cancelada.")+"\r\n")+"\r\n")+localVars.inParami_CanceledReason),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,2,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("CanceledRequisition", "8395057f-a23a-4ef0-b8bf-830d66b36f0f"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("CanceledRequisition", "8395057f-a23a-4ef0-b8bf-830d66b36f0f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowc_Req_Emails.c_Req_Emails_CanceledRequisition>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName, localVars.varLcl_EmailNotification.CurrentRec.ssName, localVars.inParami_CanceledReason, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", cancellationToken),
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

public static class FuncActionSendCanceledRequisitionEmails {

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserExtendedInternalReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternal" 3112PgbyhUOGpAG5fm+7uQ of Action "SendCanceledRequisitionEmails"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserExtendedInternal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendCanceledRequisitionEmails.GetUserExtendedInternal", "3e765ddf-f206-4385-86a4-01b97e6fbbb9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendCanceledRequisitionEmails.GetUserExtendedInternal", "3e765ddf-f206-4385-86a4-01b97e6fbbb9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.r_s6CNG+fUG7G03J5G4J4g/NodesNotShownInESpaceTree.3112PgbyhUOGpAG5fm+7uQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser4\".\"id\" o0, \"enuser4\".\"name\" o1, \"enuser4\".\"email\" o2, \"enuser4\".\"photourl\" o3, \"enuser4\".\"username\" o4, \"enuserextension1\".\"id\" o5, \"enuserextension1\".\"correspondentexternalemail\" o6, \"enuserextension1\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser4\" Left JOIN {UserExtension} \"enuserextension1\" ON (\"enuser4\".\"id\" = \"enuserextension1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser4\".\"id\" = @qpusUser_Id) AND (\"enuser4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser4\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendCanceledRequisitionEmails.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendCanceledRequisitionEmails.GetUserExtendedInternal.List", cancellationToken: cancellationToken);
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

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserExtendedInternalApplicantReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalApplicant" LAm2eap+rEyjZnawQq+qMw of Action "SendCanceledRequisitionEmails"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserExtendedInternalApplicant(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendCanceledRequisitionEmails.GetUserExtendedInternalApplicant", "79b6092c-7eaa-4cac-a366-76b042afaa33");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendCanceledRequisitionEmails.GetUserExtendedInternalApplicant", "79b6092c-7eaa-4cac-a366-76b042afaa33", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.r_s6CNG+fUG7G03J5G4J4g/NodesNotShownInESpaceTree.LAm2eap+rEyjZnawQq+qMw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser5\".\"id\" o0, \"enuser5\".\"name\" o1, \"enuser5\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuserextension2\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser5\" Left JOIN {UserExtension} \"enuserextension2\" ON (\"enuser5\".\"id\" = \"enuserextension2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser5\".\"id\" = @qpusUser_Id) AND (\"enuser5\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser5\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalApplicantReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendCanceledRequisitionEmails.GetUserExtendedInternalApplicant.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalApplicantReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendCanceledRequisitionEmails.GetUserExtendedInternalApplicant.List", cancellationToken: cancellationToken);
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

private static async Task<RC_be45dbebd99ff43af730ddaaf3b9d0b9> datasetGetRequisitionByIdReadDbAsync(RC_be45dbebd99ff43af730ddaaf3b9d0b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" HB5BldXbUEa2AOPPI_82VQ of Action "SendCanceledRequisitionEmails"
public static async Task<(RL_4f4f1e0635df8f6f1fa713c495dfccae,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendCanceledRequisitionEmails.GetRequisitionById", "95411e1c-dbd5-4650-b600-e3cf23ff3655");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendCanceledRequisitionEmails.GetRequisitionById", "95411e1c-dbd5-4650-b600-e3cf23ff3655", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.r_s6CNG+fUG7G03J5G4J4g/NodesNotShownInESpaceTree.HB5BldXbUEa2AOPPI_82VQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enrequisition4\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enrequisition4\".\"applicantid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enrequisitionapprovallevel3\".\"approvedby\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98");
fromBuilder.Append(" FROM ((({Requisition} \"enrequisition4\" Left JOIN {RequisitionApproval} \"enrequisitionapproval3\" ON (\"enrequisition4\".\"id\" = \"enrequisitionapproval3\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel3\" ON (\"enrequisitionapproval3\".\"id\" = \"enrequisitionapprovallevel3\".\"requisitionapprovalid\"))  Left JOIN {User} \"enuser6\" ON (\"enrequisition4\".\"applicantid\" = \"enuser6\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition4\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition4\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel3\".\"approvedby\" IS NOT NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendCanceledRequisitionEmails.GetRequisitionById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendCanceledRequisitionEmails.GetRequisitionById.List", cancellationToken: cancellationToken);
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



}


}
