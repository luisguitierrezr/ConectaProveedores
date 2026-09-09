namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvEmailFirstCxP_ModifyAccounting : VarsBag {
public long inParami_InvoiceId;
public string inParami_AccountingUserId;
public string inParami_ModifyReason;
public string inParami_UserRequestedModification;
public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetAccountingUser_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetAccountingUser_outParamCount = 0L;

public RL_4d0a053561fa4a3aef04e507b83b31d1 queryResGetInvoiceById_outParamList = new RL_4d0a053561fa4a3aef04e507b83b31d1();
public long queryResGetInvoiceById_outParamCount = 0L;

public RL_3e9501626d68e0b595764f7f1bae2fae queryResGetUserRequestedModificationById_outParamList = new RL_3e9501626d68e0b595764f7f1bae2fae();
public long queryResGetUserRequestedModificationById_outParamCount = 0L;

public lcvInvEmailFirstCxP_ModifyAccounting(long inParami_InvoiceId, string inParami_AccountingUserId, string inParami_ModifyReason, string inParami_UserRequestedModification) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_AccountingUserId = inParami_AccountingUserId;
this.inParami_ModifyReason = inParami_ModifyReason;
this.inParami_UserRequestedModification = inParami_UserRequestedModification;
}
}
/// <summary>
/// Action <code>InvEmailFirstCxP_ModifyAccounting</code> that represents the Service Studio action
///  <code>InvEmailFirstCxP_ModifyAccounting</code> <p> Description: Send Invoice Request To Modif
/// y Accounting Email.</p>
/// </summary>
public static async Task ActionInvEmailFirstCxP_ModifyAccounting(IRequestContext requestContext,long inParami_InvoiceId,string inParami_AccountingUserId,string inParami_ModifyReason,string inParami_UserRequestedModification,CancellationToken cancellationToken) {
lcvInvEmailFirstCxP_ModifyAccounting localVars = new lcvInvEmailFirstCxP_ModifyAccounting(inParami_InvoiceId, inParami_AccountingUserId, inParami_ModifyReason, inParami_UserRequestedModification);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvEmailFirstCxP_ModifyAccounting", "346c4744-3e6e-4a08-a7d2-27c9b1228d29"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvEmailFirstCxP_ModifyAccounting", "346c4744-3e6e-4a08-a7d2-27c9b1228d29", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvEmailFirstCxP_ModifyAccounting.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// Query datasetGetAccountingUser
cancellationToken.ThrowIfCancellationRequested();
int datasetGetAccountingUser_maxRecords = 1;
if (datasetGetAccountingUser_maxRecords < 1) datasetGetAccountingUser_maxRecords = 1;
int datasetGetAccountingUser_startIndex = 0;(localVars.queryResGetAccountingUser_outParamList,localVars.queryResGetAccountingUser_outParamCount) = await FuncActionInvEmailFirstCxP_ModifyAccounting.datasetGetAccountingUser(requestContext,datasetGetAccountingUser_maxRecords,datasetGetAccountingUser_startIndex,IterationMultiplicity.Never,localVars.inParami_AccountingUserId,cancellationToken);

// Query datasetGetUserRequestedModificationById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserRequestedModificationById_maxRecords = 1;
if (datasetGetUserRequestedModificationById_maxRecords < 1) datasetGetUserRequestedModificationById_maxRecords = 1;
int datasetGetUserRequestedModificationById_startIndex = 0;(localVars.queryResGetUserRequestedModificationById_outParamList,localVars.queryResGetUserRequestedModificationById_outParamCount) = await FuncActionInvEmailFirstCxP_ModifyAccounting.datasetGetUserRequestedModificationById(requestContext,datasetGetUserRequestedModificationById_maxRecords,datasetGetUserRequestedModificationById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserRequestedModification,cancellationToken);

// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUser.ssId })),"",1,("Facturas - Pedido de Modificación de la Factura "+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName),(((((("La factura "+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName)+" recibió un pedido de modificación por :")+localVars.queryResGetUserRequestedModificationById_outParamList.CurrentRec.ssName)+"\r\n")+"\r\n")+localVars.inParami_ModifyReason),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUser.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ModifyAccountingInvoice", "65790930-9fbd-47d7-992a-669a9535a42d"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ModifyAccountingInvoice", "65790930-9fbd-47d7-992a-669a9535a42d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowd_Inv_Emails.d_Inv_Emails_ModifyAccountingInvoice>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName, localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUser.ssName, localVars.inParami_ModifyReason, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetUserRequestedModificationById_outParamList.CurrentRec.ssName, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUser.ssEmail) : ((((localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUserExtension.ssEmailto!="")) ? (localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUserExtension.ssEmailto) : (localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUser.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? ((((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUser.ssEmail))) : ((((localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUserExtension.ssEmailto!="")) ? (localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUserExtension.ssEmailto) : (localVars.queryResGetAccountingUser_outParamList.CurrentRec.ssENUser.ssEmail)))),
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

public static class FuncActionInvEmailFirstCxP_ModifyAccounting {

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetAccountingUserReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetAccountingUser" fYSbYVDPuki9EUSgi1v6GA of Action "InvEmailFirstCxP_ModifyAccounting"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetAccountingUser(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstCxP_ModifyAccounting.GetAccountingUser", "619b847d-cf50-48ba-bd11-44a08b5bfa18");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstCxP_ModifyAccounting.GetAccountingUser", "619b847d-cf50-48ba-bd11-44a08b5bfa18", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.REdsNG4+CEqn0ifJsSKNKQ/NodesNotShownInESpaceTree.fYSbYVDPuki9EUSgi1v6GA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser34\".\"id\" o0, \"enuser34\".\"name\" o1, \"enuser34\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuserextension17\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser34\" Left JOIN {UserExtension} \"enuserextension17\" ON (\"enuser34\".\"id\" = \"enuserextension17\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser34\".\"id\" = @qpusUser_Id) AND (\"enuser34\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser34\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetAccountingUserReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstCxP_ModifyAccounting.GetAccountingUser.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetAccountingUserReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstCxP_ModifyAccounting.GetAccountingUser.List", cancellationToken: cancellationToken);
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
// Query Function "GetInvoiceById" 96sLblLoNkm9JjjCr9LgQA of Action "InvEmailFirstCxP_ModifyAccounting"
public static async Task<(RL_4d0a053561fa4a3aef04e507b83b31d1,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstCxP_ModifyAccounting.GetInvoiceById", "6e0babf7-e852-4936-bd26-38c2afd2e040");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstCxP_ModifyAccounting.GetInvoiceById", "6e0babf7-e852-4936-bd26-38c2afd2e040", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.REdsNG4+CEqn0ifJsSKNKQ/NodesNotShownInESpaceTree.96sLblLoNkm9JjjCr9LgQA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice9\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice9\" Left JOIN {Requisition} \"enrequisition13\" ON (\"eninvoice9\".\"requisitionid\" = \"enrequisition13\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice9\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice9\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice9\".\"id\" IS NULL)");
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
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstCxP_ModifyAccounting.GetInvoiceById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstCxP_ModifyAccounting.GetInvoiceById.List", cancellationToken: cancellationToken);
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

// Query Function "GetUserRequestedModificationById" BGC4l6s_jkONDs9NaM9J0g of Action "InvEmailFirstCxP_ModifyAccounting"
public static async Task<(RL_3e9501626d68e0b595764f7f1bae2fae,long)> datasetGetUserRequestedModificationById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvEmailFirstCxP_ModifyAccounting.GetUserRequestedModificationById", "97b86004-3fab-438e-8d0e-cf4d68cf49d2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvEmailFirstCxP_ModifyAccounting.GetUserRequestedModificationById", "97b86004-3fab-438e-8d0e-cf4d68cf49d2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.REdsNG4+CEqn0ifJsSKNKQ/NodesNotShownInESpaceTree.BGC4l6s_jkONDs9NaM9J0g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser35\".\"name\" \"name\"");
fromBuilder.Append(" FROM {User} \"enuser35\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser35\".\"id\" = @qpusId) AND (\"enuser35\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser35\".\"id\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enuser35\".\"name\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvEmailFirstCxP_ModifyAccounting.GetUserRequestedModificationById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvEmailFirstCxP_ModifyAccounting.GetUserRequestedModificationById.List", cancellationToken: cancellationToken);
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



}


}
