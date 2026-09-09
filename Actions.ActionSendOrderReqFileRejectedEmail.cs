namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendOrderReqFileRejectedEmail : VarsBag {
public long inParami_OrderReqFileId;
public string inParami_RejectReason;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_39842304b010e66ad38d0f73c466d0e1 queryResGetOrderRequestFileById_outParamList = new RL_39842304b010e66ad38d0f73c466d0e1();
public long queryResGetOrderRequestFileById_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_519cfbd5c9d3e969a6c55ad5a0702da1 queryResGetUsers_outParamList = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
public long queryResGetUsers_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public lcvSendOrderReqFileRejectedEmail(long inParami_OrderReqFileId, string inParami_RejectReason) {
this.inParami_OrderReqFileId = inParami_OrderReqFileId;
this.inParami_RejectReason = inParami_RejectReason;
}
}
/// <summary>
/// Action <code>SendOrderReqFileRejectedEmail</code> that represents the Service Studio action
///  <code>SendOrderReqFileRejectedEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendOrderReqFileRejectedEmail(IRequestContext requestContext,long inParami_OrderReqFileId,string inParami_RejectReason,CancellationToken cancellationToken) {
lcvSendOrderReqFileRejectedEmail localVars = new lcvSendOrderReqFileRejectedEmail(inParami_OrderReqFileId, inParami_RejectReason);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendOrderReqFileRejectedEmail", "14361800-4826-462f-9634-54cbd4f28625"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendOrderReqFileRejectedEmail", "14361800-4826-462f-9634-54cbd4f28625", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderRequestFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRequestFileById_maxRecords = 1;
if (datasetGetOrderRequestFileById_maxRecords < 1) datasetGetOrderRequestFileById_maxRecords = 1;
int datasetGetOrderRequestFileById_startIndex = 0;(localVars.queryResGetOrderRequestFileById_outParamList,localVars.queryResGetOrderRequestFileById_outParamCount) = await FuncActionSendOrderReqFileRejectedEmail.datasetGetOrderRequestFileById(requestContext,datasetGetOrderRequestFileById_maxRecords,datasetGetOrderRequestFileById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderReqFileId,cancellationToken);

// Query datasetGetUsers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsers_maxRecords = 1;
if (datasetGetUsers_maxRecords < 1) datasetGetUsers_maxRecords = 1;
int datasetGetUsers_startIndex = 0;(localVars.queryResGetUsers_outParamList,localVars.queryResGetUsers_outParamCount) = await FuncActionSendOrderReqFileRejectedEmail.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENSupplier.ssId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUsers_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_60b2ce7251b451294681274f8057cbd6 source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
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
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",1,("Pedidos - Rechazo del Archivo del Pedido "+localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderRequestFile.ssFilename),(("El archivo "+localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderRequestFile.ssFilename)+" fue rechazado."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("RejectOrderReqFile", "866c9760-3637-4ffe-acdd-131912068de9"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("RejectOrderReqFile", "866c9760-3637-4ffe-acdd-131912068de9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowe_Orders_Emails.e_Orders_Emails_RejectOrderReqFile>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderRequestFile.ssFilename, localVars.queryResGetOrderRequestFileById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber, localVars.inParami_RejectReason, localVars.varLcl_EmailNotification.CurrentRec.ssName, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionSendOrderReqFileRejectedEmail {

private static async Task<RC_8c4427441293dc27b4cc40905a444588> datasetGetOrderRequestFileByIdReadDbAsync(RC_8c4427441293dc27b4cc40905a444588 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderRequestFile.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderRequestFileById" OEcXBNrjxU646dBXsJLweg of Action "SendOrderReqFileRejectedEmail"
public static async Task<(RL_39842304b010e66ad38d0f73c466d0e1,long)> datasetGetOrderRequestFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFile_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderReqFileRejectedEmail.GetOrderRequestFileById", "04174738-e3da-4ec5-b8e9-d057b092f07a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderReqFileRejectedEmail.GetOrderRequestFileById", "04174738-e3da-4ec5-b8e9-d057b092f07a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ABg2FCZIL0aWNFTL1PKGJQ/NodesNotShownInESpaceTree.OEcXBNrjxU646dBXsJLweg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enordermain4\".\"ordernumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enorderrequestfile\".\"filename\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"ensupplier4\".\"id\" o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73");
fromBuilder.Append(" FROM (({OrderRequestFile} \"enorderrequestfile\" Left JOIN {OrderMain} \"enordermain4\" ON (\"enorderrequestfile\".\"orderid\" = \"enordermain4\".\"id\"))  Inner JOIN {Supplier} \"ensupplier4\" ON (\"enordermain4\".\"supplierid\" = \"ensupplier4\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFile_Id != 0) {
whereBuilder.Append("((\"enorderrequestfile\".\"id\" = @qporOrderRequestFile_Id) AND (\"enorderrequestfile\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFile_Id", DbType.Int64, qporOrderRequestFile_Id);
} else {
whereBuilder.Append("(\"enorderrequestfile\".\"id\" IS NULL)");
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
RL_39842304b010e66ad38d0f73c466d0e1 outParamList = new RL_39842304b010e66ad38d0f73c466d0e1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderRequestFileByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderReqFileRejectedEmail.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39842304b010e66ad38d0f73c466d0e1 _tmp = new RL_39842304b010e66ad38d0f73c466d0e1();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderRequestFileByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderReqFileRejectedEmail.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39842304b010e66ad38d0f73c466d0e1)_tmp;
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

private static async Task<RC_60b2ce7251b451294681274f8057cbd6> datasetGetUsersReadDbAsync(RC_60b2ce7251b451294681274f8057cbd6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSupplierUser.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUsers" 5yMdiHlr_U2gi9jSgR3ExA of Action "SendOrderReqFileRejectedEmail"
public static async Task<(RL_519cfbd5c9d3e969a6c55ad5a0702da1,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplierUser_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderReqFileRejectedEmail.GetUsers", "881d23e7-6b79-4dfd-a08b-d8d2811dc4c4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderReqFileRejectedEmail.GetUsers", "881d23e7-6b79-4dfd-a08b-d8d2811dc4c4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ABg2FCZIL0aWNFTL1PKGJQ/NodesNotShownInESpaceTree.5yMdiHlr_U2gi9jSgR3ExA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"enuser13\".\"id\" o15, \"enuser13\".\"name\" o16, \"enuser13\".\"email\" o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enuserextension6\".\"emailto\" o22");
fromBuilder.Append(" FROM (({SupplierUser} \"ensupplieruser\" Inner JOIN {User} \"enuser13\" ON (\"ensupplieruser\".\"userid\" = \"enuser13\".\"id\"))  Left JOIN {UserExtension} \"enuserextension6\" ON (\"enuser13\".\"id\" = \"enuserextension6\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierUser_SupplierId != 0) {
whereBuilder.Append("((\"ensupplieruser\".\"supplierid\" = @qpsuSupplierUser_SupplierId) AND (\"ensupplieruser\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierUser_SupplierId", DbType.Int64, qpsuSupplierUser_SupplierId);
} else {
whereBuilder.Append("(\"ensupplieruser\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"ensupplieruser\".\"isactive\" = 1) AND (NOT (\"ensupplieruser\".\"isblocked\" = 1))");
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
outParamList.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderReqFileRejectedEmail.GetUsers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_519cfbd5c9d3e969a6c55ad5a0702da1 _tmp = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderReqFileRejectedEmail.GetUsers.List", cancellationToken: cancellationToken);
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



}


}
