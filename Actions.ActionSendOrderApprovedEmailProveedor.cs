namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendOrderApprovedEmailProveedor : VarsBag {
public long inParami_OrderId;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderById_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderById_outParamCount = 0L;

public RL_519cfbd5c9d3e969a6c55ad5a0702da1 queryResGetUsersProveedores_outParamList = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
public long queryResGetUsersProveedores_outParamCount = 0L;

public lcvSendOrderApprovedEmailProveedor(long inParami_OrderId) {
this.inParami_OrderId = inParami_OrderId;
}
}
/// <summary>
/// Action <code>SendOrderApprovedEmailProveedor</code> that represents the Service Studio action
///  <code>SendOrderApprovedEmailProveedor</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendOrderApprovedEmailProveedor(IRequestContext requestContext,long inParami_OrderId,CancellationToken cancellationToken) {
lcvSendOrderApprovedEmailProveedor localVars = new lcvSendOrderApprovedEmailProveedor(inParami_OrderId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendOrderApprovedEmailProveedor", "76fe515e-f2aa-4423-8421-cd45f8cb8655"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendOrderApprovedEmailProveedor", "76fe515e-f2aa-4423-8421-cd45f8cb8655", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetOrderById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderById_maxRecords = 1;
if (datasetGetOrderById_maxRecords < 1) datasetGetOrderById_maxRecords = 1;
int datasetGetOrderById_startIndex = 0;(localVars.queryResGetOrderById_outParamList,localVars.queryResGetOrderById_outParamCount) = await FuncActionSendOrderApprovedEmailProveedor.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// Query datasetGetUsersProveedores
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersProveedores_maxRecords = 0;
int datasetGetUsersProveedores_startIndex = 0;(localVars.queryResGetUsersProveedores_outParamList,localVars.queryResGetUsersProveedores_outParamCount) = await FuncActionSendOrderApprovedEmailProveedor.datasetGetUsersProveedores(requestContext,datasetGetUsersProveedores_maxRecords,datasetGetUsersProveedores_startIndex,IterationMultiplicity.Single,localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssSupplierId,cancellationToken);

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

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",0,("Pedido - Pedido Aprobado "+localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber),(("Lo pedido "+localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber)+" acaba de ser aprobado."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("OrderApproved", "552646e4-8255-4838-a3f8-daa04fb393c4"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("OrderApproved", "552646e4-8255-4838-a3f8-daa04fb393c4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowe_Orders_Emails.e_Orders_Emails_OrderApproved>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionSendOrderApprovedEmailProveedor {

// Query Function "GetOrderById" or0mrFOU+kGvFTAdS7QtXQ of Action "SendOrderApprovedEmailProveedor"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderApprovedEmailProveedor.GetOrderById", "ac26bda2-9453-41fa-af15-301d4bb42d5d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderApprovedEmailProveedor.GetOrderById", "ac26bda2-9453-41fa-af15-301d4bb42d5d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.XlH+dqryI0SEIc1F+MuGVQ/NodesNotShownInESpaceTree.or0mrFOU+kGvFTAdS7QtXQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enordermain36\".\"ordernumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enordermain36\".\"supplierid\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain36\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordermain36\".\"id\" = @qporId) AND (\"enordermain36\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordermain36\".\"id\" IS NULL)");
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderApprovedEmailProveedor.GetOrderById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderApprovedEmailProveedor.GetOrderById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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
// Query Function "GetUsersProveedores" 5NsU_aS6n0eJZen5XiHZRA of Action "SendOrderApprovedEmailProveedor"
public static async Task<(RL_519cfbd5c9d3e969a6c55ad5a0702da1,long)> datasetGetUsersProveedores(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplierUser_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderApprovedEmailProveedor.GetUsersProveedores", "fd14dbe4-baa4-479f-8965-e9f95e21d944");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderApprovedEmailProveedor.GetUsersProveedores", "fd14dbe4-baa4-479f-8965-e9f95e21d944", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.XlH+dqryI0SEIc1F+MuGVQ/NodesNotShownInESpaceTree.5NsU_aS6n0eJZen5XiHZRA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplieruser8\".\"id\" o0, \"ensupplieruser8\".\"supplierid\" o1, \"ensupplieruser8\".\"userid\" o2, \"ensupplieruser8\".\"name\" o3, \"ensupplieruser8\".\"email\" o4, \"ensupplieruser8\".\"activationemailsentdate\" o5, \"ensupplieruser8\".\"isactive\" o6, \"ensupplieruser8\".\"isdeleted\" o7, \"ensupplieruser8\".\"isblocked\" o8, \"ensupplieruser8\".\"blockeduntil\" o9, \"ensupplieruser8\".\"lastlogindate\" o10, \"ensupplieruser8\".\"createdby\" o11, \"ensupplieruser8\".\"createdon\" o12, \"ensupplieruser8\".\"updatedby\" o13, \"ensupplieruser8\".\"updatedon\" o14, \"enuser76\".\"id\" o15, \"enuser76\".\"name\" o16, \"enuser76\".\"email\" o17, \"enuser76\".\"photourl\" o18, \"enuser76\".\"username\" o19, \"enuserextension39\".\"id\" o20, \"enuserextension39\".\"correspondentexternalemail\" o21, \"enuserextension39\".\"emailto\" o22");
fromBuilder.Append(" FROM (({User} \"enuser76\" Left JOIN {UserExtension} \"enuserextension39\" ON (\"enuser76\".\"id\" = \"enuserextension39\".\"id\"))  Left JOIN {SupplierUser} \"ensupplieruser8\" ON (\"enuser76\".\"id\" = \"ensupplieruser8\".\"userid\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierUser_SupplierId != 0) {
whereBuilder.Append("((\"ensupplieruser8\".\"supplierid\" = @qpsuSupplierUser_SupplierId) AND (\"ensupplieruser8\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierUser_SupplierId", DbType.Int64, qpsuSupplierUser_SupplierId);
} else {
whereBuilder.Append("(\"ensupplieruser8\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"ensupplieruser8\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderApprovedEmailProveedor.GetUsersProveedores.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderApprovedEmailProveedor.GetUsersProveedores.List", cancellationToken: cancellationToken);
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
