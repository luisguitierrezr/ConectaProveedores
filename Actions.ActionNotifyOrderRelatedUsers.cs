namespace ssConectaProveedores;

public partial class Actions {
public class lcvNotifyOrderRelatedUsers : VarsBag {
public long inParamOrderMainId;
public string inParamCancelationMotive;
/// <summary>
/// Variable <code>UserEmails</code> that represents the Service Studio
///  UserIdEmailNameOrderNumberRecordList <code>UserEmails</code> <p>Description: </p>
/// </summary>
public RL_66bf4c4c2a926b63449c8fef667ea749 varLcUserEmails = new RL_66bf4c4c2a926b63449c8fef667ea749();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_41fd2052c0bcb4477e93a1b27c923798 queryResGetOrderMainSupplier_outParamList = new RL_41fd2052c0bcb4477e93a1b27c923798();
public long queryResGetOrderMainSupplier_outParamCount = 0L;

public RL_66bf4c4c2a926b63449c8fef667ea749 resListDistinct_outParamDistinctList = new RL_66bf4c4c2a926b63449c8fef667ea749();

public RL_33455a72006e2012e266c7532fef851a queryResGetOrderRelatedUsersToNotify_outParamList = new RL_33455a72006e2012e266c7532fef851a();
public long queryResGetOrderRelatedUsersToNotify_outParamCount = 0L;

public lcvNotifyOrderRelatedUsers(long inParamOrderMainId, string inParamCancelationMotive) {
this.inParamOrderMainId = inParamOrderMainId;
this.inParamCancelationMotive = inParamCancelationMotive;
}
}
/// <summary>
/// Action <code>NotifyOrderRelatedUsers</code> that represents the Service Studio action
///  <code>NotifyOrderRelatedUsers</code> <p> Description: </p>
/// </summary>
public static async Task ActionNotifyOrderRelatedUsers(IRequestContext requestContext,long inParamOrderMainId,string inParamCancelationMotive,CancellationToken cancellationToken) {
lcvNotifyOrderRelatedUsers localVars = new lcvNotifyOrderRelatedUsers(inParamOrderMainId, inParamCancelationMotive);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("NotifyOrderRelatedUsers", "b5ba85f9-ca71-4302-a9e6-ddfb848e5272"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("NotifyOrderRelatedUsers", "b5ba85f9-ca71-4302-a9e6-ddfb848e5272", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetOrderRelatedUsersToNotify
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRelatedUsersToNotify_maxRecords = 0;
int datasetGetOrderRelatedUsersToNotify_startIndex = 0;(localVars.queryResGetOrderRelatedUsersToNotify_outParamList,localVars.queryResGetOrderRelatedUsersToNotify_outParamCount) = await FuncActionNotifyOrderRelatedUsers.datasetGetOrderRelatedUsersToNotify(requestContext,datasetGetOrderRelatedUsersToNotify_maxRecords,datasetGetOrderRelatedUsersToNotify_startIndex,IterationMultiplicity.Multiple,localVars.inParamOrderMainId,cancellationToken);

// Query datasetGetOrderMainSupplier
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainSupplier_maxRecords = 0;
int datasetGetOrderMainSupplier_startIndex = 0;(localVars.queryResGetOrderMainSupplier_outParamList,localVars.queryResGetOrderMainSupplier_outParamCount) = await FuncActionNotifyOrderRelatedUsers.datasetGetOrderMainSupplier(requestContext,datasetGetOrderMainSupplier_maxRecords,datasetGetOrderMainSupplier_startIndex,IterationMultiplicity.Multiple,localVars.inParamOrderMainId,cancellationToken);

// ListAppendAllOrderRelatedUsersToNotify
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcUserEmails,(await RL_66bf4c4c2a926b63449c8fef667ea749.ConvertAsync(localVars.queryResGetOrderRelatedUsersToNotify_outParamList, new RL_66bf4c4c2a926b63449c8fef667ea749(), async (RC_84a44699141c955c7970b8e0b66de573 source, RC_0abe3ce56ac5cb76651869d42c67839f target, CancellationToken cancellationToken) => {
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
target.ssOrderNumber = source.ssENOrderMain.ssOrderNumber;
target.ssUserId = source.ssENUser.ssId;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAllOrderMainSupplier
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcUserEmails,(await RL_66bf4c4c2a926b63449c8fef667ea749.ConvertAsync(localVars.queryResGetOrderMainSupplier_outParamList, new RL_66bf4c4c2a926b63449c8fef667ea749(), async (RC_7ff0d2d2388d9acf793b4f023e6f8f0f source, RC_0abe3ce56ac5cb76651869d42c67839f target, CancellationToken cancellationToken) => {
target.ssEmail = source.ssENSupplierUser.ssEmail;
target.ssName = source.ssENSupplierUser.ssName;
target.ssOrderNumber = source.ssENOrderMain.ssOrderNumber;
target.ssUserId = source.ssENSupplierUser.ssUserId;
return target;
}, cancellationToken)),cancellationToken);

// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("NotifyOrderRelatedUsers » Order related users will be notified. Nr. users: "+BuiltInFunction.IntegerToText (localVars.queryResGetOrderRelatedUsersToNotify_outParamList.Length)),"NotifyOrderRelatedUsers",cancellationToken);

// ListSort
await ExtendedActions.ListSort(requestContext,localVars.varLcUserEmails,async (p, cancellationToken) => p.ssUserId,true,cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_66bf4c4c2a926b63449c8fef667ea749) localVars.varLcUserEmails.Distinct()));

// DistinctUserEmails
// UserEmails = ListDistinct.DistinctList
localVars.varLcUserEmails=localVars.resListDistinct_outParamDistinctList;
// Foreach UserEmails
localVars.varLcUserEmails.StartIteration();
try {while (!((localVars.varLcUserEmails.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcUserEmails.CurrentRec.ssUserId })),"",1,"Pedidos distribuidos",(("Está recibiendo este correo electrónico porque el pedido número "+localVars.varLcUserEmails.CurrentRec.ssOrderNumber)+" ha sido modificado y, por esa razón, es necesario que el área de Cuentas por Pagar y Egresos vuelva a realizar el análisis correspondiente."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcUserEmails.CurrentRec.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("OrderChangeNotification", "a35041ed-519e-46aa-9f3c-ffe1fe9e5cb0"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("OrderChangeNotification", "a35041ed-519e-46aa-9f3c-ffe1fe9e5cb0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowh_OrderDistribution_Emails.h_OrderDistribution_Emails_OrderChangeNotification>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , BuiltInFunction.GetAppName (), localVars.varLcUserEmails.CurrentRec.ssName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.varLcUserEmails.CurrentRec.ssOrderNumber, localVars.varLcUserEmails.CurrentRec.ssEmail, "", localVars.inParamCancelationMotive, cancellationToken),
        To = (((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.varLcUserEmails.CurrentRec.ssEmail)),
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
localVars.varLcUserEmails.Advance();
}

} finally {
localVars.varLcUserEmails.EndIteration();
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

public static class FuncActionNotifyOrderRelatedUsers {

private static async Task<RC_7ff0d2d2388d9acf793b4f023e6f8f0f> datasetGetOrderMainSupplierReadDbAsync(RC_7ff0d2d2388d9acf793b4f023e6f8f0f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainSupplier" m9IsiqXJ+Uqze8oQHAhCkA of Action "NotifyOrderRelatedUsers"
public static async Task<(RL_41fd2052c0bcb4477e93a1b27c923798,long)> datasetGetOrderMainSupplier(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("NotifyOrderRelatedUsers.GetOrderMainSupplier", "8a2cd29b-c9a5-4af9-b37b-ca101c084290");
using var queryActivity = activitySource.CreateAggregateQueryActivity("NotifyOrderRelatedUsers.GetOrderMainSupplier", "8a2cd29b-c9a5-4af9-b37b-ca101c084290", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.+YW6tXHKAkOp5t37hI5Scg/NodesNotShownInESpaceTree.m9IsiqXJ+Uqze8oQHAhCkA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enordermain47\".\"ordernumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"ensupplieruser10\".\"userid\" o59, \"ensupplieruser10\".\"name\" o60, \"ensupplieruser10\".\"email\" o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain47\" Inner JOIN {Supplier} \"ensupplier29\" ON (\"enordermain47\".\"supplierid\" = \"ensupplier29\".\"id\"))  Left JOIN {SupplierUser} \"ensupplieruser10\" ON (\"ensupplier29\".\"id\" = \"ensupplieruser10\".\"supplierid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain47\".\"id\" = @qporOrderMain_Id) AND (\"enordermain47\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain47\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (((NOT (\"ensupplieruser10\".\"isdeleted\" = 1)) AND (NOT (\"ensupplieruser10\".\"isblocked\" = 1))) AND (\"ensupplieruser10\".\"isactive\" = 1))");
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
RL_41fd2052c0bcb4477e93a1b27c923798 outParamList = new RL_41fd2052c0bcb4477e93a1b27c923798();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainSupplierReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, false, false, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query NotifyOrderRelatedUsers.GetOrderMainSupplier.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_41fd2052c0bcb4477e93a1b27c923798 _tmp = new RL_41fd2052c0bcb4477e93a1b27c923798();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainSupplierReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query NotifyOrderRelatedUsers.GetOrderMainSupplier.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_41fd2052c0bcb4477e93a1b27c923798)_tmp;
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

private static async Task<RC_84a44699141c955c7970b8e0b66de573> datasetGetOrderRelatedUsersToNotifyReadDbAsync(RC_84a44699141c955c7970b8e0b66de573 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderRelatedUsersToNotify" 6qGv22gmIEKDMbMGI3H0wg of Action "NotifyOrderRelatedUsers"
public static async Task<(RL_33455a72006e2012e266c7532fef851a,long)> datasetGetOrderRelatedUsersToNotify(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("NotifyOrderRelatedUsers.GetOrderRelatedUsersToNotify", "dbafa1ea-2668-4220-8331-b3062371f4c2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("NotifyOrderRelatedUsers.GetOrderRelatedUsersToNotify", "dbafa1ea-2668-4220-8331-b3062371f4c2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.+YW6tXHKAkOp5t37hI5Scg/NodesNotShownInESpaceTree.6qGv22gmIEKDMbMGI3H0wg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enordermain48\".\"ordernumber\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, \"enuser101\".\"id\" o54, \"enuser101\".\"name\" o55, \"enuser101\".\"email\" o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM ((({OrderApproval} \"enorderapproval13\" Left JOIN {OrderApprovalLevel} \"enorderapprovallevel12\" ON (\"enorderapproval13\".\"id\" = \"enorderapprovallevel12\".\"orderapprovalid\"))  Left JOIN {User} \"enuser101\" ON ((((((\"enorderapprovallevel12\".\"assignedto\" = \"enuser101\".\"id\") OR (\"enorderapprovallevel12\".\"approvedby\" = \"enuser101\".\"id\")) OR (\"enorderapprovallevel12\".\"rejectedby\" = \"enuser101\".\"id\")) OR (\"enorderapprovallevel12\".\"issubstitutefor\" = \"enuser101\".\"id\")) OR (\"enorderapprovallevel12\".\"tomodifyby\" = \"enuser101\".\"id\")) OR (\"enorderapprovallevel12\".\"wascanceledby\" = \"enuser101\".\"id\")))  Left JOIN {OrderMain} \"enordermain48\" ON (\"enorderapproval13\".\"orderid\" = \"enordermain48\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval13\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval13\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval13\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderapprovallevel12\".\"levelnumber\" <= \"enorderapproval13\".\"currentlevel\") AND (\"enuser101\".\"id\" IS NOT NULL)");
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
RL_33455a72006e2012e266c7532fef851a outParamList = new RL_33455a72006e2012e266c7532fef851a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderRelatedUsersToNotifyReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query NotifyOrderRelatedUsers.GetOrderRelatedUsersToNotify.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_33455a72006e2012e266c7532fef851a _tmp = new RL_33455a72006e2012e266c7532fef851a();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderRelatedUsersToNotifyReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query NotifyOrderRelatedUsers.GetOrderRelatedUsersToNotify.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_33455a72006e2012e266c7532fef851a)_tmp;
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
