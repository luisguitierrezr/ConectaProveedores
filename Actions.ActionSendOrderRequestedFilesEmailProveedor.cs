namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendOrderRequestedFilesEmailProveedor : VarsBag {
public long inParami_OrderId;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

/// <summary>
/// Variable <code>FilesList</code> that represents the Service Studio Text <code>FilesList</code>
///  <p>Description: </p>
/// </summary>
public string varLcFilesList = "";

public string resString_JoinRequestFiles_outParamText = "";

public string resString_JoinConcepts_outParamText = "";

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_1ff55f484c8c1943311ff58a000d50d1 queryResGetOrderById_outParamList = new RL_1ff55f484c8c1943311ff58a000d50d1();
public long queryResGetOrderById_outParamCount = 0L;

public RL_d258c3d50d870257794347fdeb7cc218 queryResGetOrderRequestFilesByOrderId_outParamList = new RL_d258c3d50d870257794347fdeb7cc218();
public long queryResGetOrderRequestFilesByOrderId_outParamCount = 0L;

public RL_fe2a66f29d923f08aaf84e90873f4cc6 queryResGetOrderAccountingsByOrderId_outParamList = new RL_fe2a66f29d923f08aaf84e90873f4cc6();
public long queryResGetOrderAccountingsByOrderId_outParamCount = 0L;

public lcvSendOrderRequestedFilesEmailProveedor(long inParami_OrderId) {
this.inParami_OrderId = inParami_OrderId;
}
}
/// <summary>
/// Action <code>SendOrderRequestedFilesEmailProveedor</code> that represents the Service Studio action
///  <code>SendOrderRequestedFilesEmailProveedor</code> <p> Description: Action to send email t
/// o Supplier when order is complemented and ready to upload requested files.</p>
/// </summary>
public static async Task ActionSendOrderRequestedFilesEmailProveedor(IRequestContext requestContext,long inParami_OrderId,CancellationToken cancellationToken) {
lcvSendOrderRequestedFilesEmailProveedor localVars = new lcvSendOrderRequestedFilesEmailProveedor(inParami_OrderId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendOrderRequestedFilesEmailProveedor", "d547e7a9-9ebc-4b99-9b40-87120698f4dc"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendOrderRequestedFilesEmailProveedor", "d547e7a9-9ebc-4b99-9b40-87120698f4dc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderById_maxRecords = 1;
if (datasetGetOrderById_maxRecords < 1) datasetGetOrderById_maxRecords = 1;
int datasetGetOrderById_startIndex = 0;(localVars.queryResGetOrderById_outParamList,localVars.queryResGetOrderById_outParamCount) = await FuncActionSendOrderRequestedFilesEmailProveedor.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// Query datasetGetOrderRequestFilesByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRequestFilesByOrderId_maxRecords = 999999999;
if (datasetGetOrderRequestFilesByOrderId_maxRecords < 1) datasetGetOrderRequestFilesByOrderId_maxRecords = 1;
int datasetGetOrderRequestFilesByOrderId_startIndex = 0;(localVars.queryResGetOrderRequestFilesByOrderId_outParamList,localVars.queryResGetOrderRequestFilesByOrderId_outParamCount) = await FuncActionSendOrderRequestedFilesEmailProveedor.datasetGetOrderRequestFilesByOrderId(requestContext,datasetGetOrderRequestFilesByOrderId_maxRecords,datasetGetOrderRequestFilesByOrderId_startIndex,IterationMultiplicity.Single,localVars.inParami_OrderId,cancellationToken);

// String_JoinRequestFiles
localVars.resString_JoinRequestFiles_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.queryResGetOrderRequestFilesByOrderId_outParamList, new RLTextRecordList(), async (RC_73d8126c722e2b4dd662dab2bf1a72d1 source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = source.ssENOrderRequestFile.ssDescription;
return target;
}, cancellationToken)),"\r\n",cancellationToken);

// Query datasetGetOrderAccountingsByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderAccountingsByOrderId_maxRecords = 0;
int datasetGetOrderAccountingsByOrderId_startIndex = 0;(localVars.queryResGetOrderAccountingsByOrderId_outParamList,localVars.queryResGetOrderAccountingsByOrderId_outParamCount) = await FuncActionSendOrderRequestedFilesEmailProveedor.datasetGetOrderAccountingsByOrderId(requestContext,datasetGetOrderAccountingsByOrderId_maxRecords,datasetGetOrderAccountingsByOrderId_startIndex,IterationMultiplicity.Single,localVars.inParami_OrderId,cancellationToken);

// String_JoinConcepts
localVars.resString_JoinConcepts_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.queryResGetOrderAccountingsByOrderId_outParamList, new RLTextRecordList(), async (RC_27125ab538212d639b6d08211936027a source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = source.ssENAccountingDataType.ssLabel;
return target;
}, cancellationToken)),"\r\n",cancellationToken);

// FilesList = String_JoinRequestFiles.Text + "
//" + String_JoinConcepts.Text
localVars.varLcFilesList=((localVars.resString_JoinRequestFiles_outParamText+"\r\n")+localVars.resString_JoinConcepts_outParamText);
// ListAppendEmail
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_EmailNotification,new ST_12668886130225cd5b17c72a6562dd7cStructure(){ ssUserId = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENUser.ssId, ssEmail = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENUser.ssEmail, ssName = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENUser.ssName, ssEmailTo = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENUserExtension.ssEmailto },cancellationToken);

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",1,("Pedidos - Documentos Requeridos "+localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber),("Estimado proveedor, debe subir los siguientes documentos de información de pago:"+localVars.resString_JoinRequestFiles_outParamText),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("OrderRequestedFiles", "9181bf60-397e-479f-adca-8d8107fc759f"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("OrderRequestedFiles", "9181bf60-397e-479f-adca-8d8107fc759f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowe_Orders_Emails.e_Orders_Emails_OrderRequestedFiles>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, localVars.varLcFilesList, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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

public static class FuncActionSendOrderRequestedFilesEmailProveedor {

private static async Task<RC_ba5d2807543ac9c0e233d12b8827d820> datasetGetOrderByIdReadDbAsync(RC_ba5d2807543ac9c0e233d12b8827d820 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetOrderById" aqtFagKVGUqeyLKRyUPdng of Action "SendOrderRequestedFilesEmailProveedor"
public static async Task<(RL_1ff55f484c8c1943311ff58a000d50d1,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderRequestedFilesEmailProveedor.GetOrderById", "6a45ab6a-9502-4a19-9ec8-b291c943dd9e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderRequestedFilesEmailProveedor.GetOrderById", "6a45ab6a-9502-4a19-9ec8-b291c943dd9e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.qedH1byemUubQIcSBpj03A/NodesNotShownInESpaceTree.aqtFagKVGUqeyLKRyUPdng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enordermain56\".\"ordernumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, \"enuser120\".\"id\" o72, \"enuser120\".\"name\" o73, \"enuser120\".\"email\" o74, NULL o75, NULL o76, NULL o77, NULL o78, \"enuserextension54\".\"emailto\" o79");
fromBuilder.Append(" FROM (((({OrderMain} \"enordermain56\" Inner JOIN {Supplier} \"ensupplier44\" ON (\"enordermain56\".\"supplierid\" = \"ensupplier44\".\"id\"))  Left JOIN {SupplierUser} \"ensupplieruser12\" ON (\"ensupplier44\".\"id\" = \"ensupplieruser12\".\"supplierid\"))  Left JOIN {User} \"enuser120\" ON (\"ensupplieruser12\".\"userid\" = \"enuser120\".\"id\"))  Left JOIN {UserExtension} \"enuserextension54\" ON (\"enuser120\".\"id\" = \"enuserextension54\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain56\".\"id\" = @qporOrderMain_Id) AND (\"enordermain56\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain56\".\"id\" IS NULL)");
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
RL_1ff55f484c8c1943311ff58a000d50d1 outParamList = new RL_1ff55f484c8c1943311ff58a000d50d1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderRequestedFilesEmailProveedor.GetOrderById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1ff55f484c8c1943311ff58a000d50d1 _tmp = new RL_1ff55f484c8c1943311ff58a000d50d1();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderRequestedFilesEmailProveedor.GetOrderById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1ff55f484c8c1943311ff58a000d50d1)_tmp;
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

// Query Function "GetOrderRequestFilesByOrderId" qplRc+6e5UyZS4jBAteOOg of Action "SendOrderRequestedFilesEmailProveedor"
public static async Task<(RL_d258c3d50d870257794347fdeb7cc218,long)> datasetGetOrderRequestFilesByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderRequestedFilesEmailProveedor.GetOrderRequestFilesByOrderId", "735199aa-9eee-4ce5-994b-88c102d78e3a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderRequestedFilesEmailProveedor.GetOrderRequestFilesByOrderId", "735199aa-9eee-4ce5-994b-88c102d78e3a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.qedH1byemUubQIcSBpj03A/NodesNotShownInESpaceTree.qplRc+6e5UyZS4jBAteOOg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"enorderrequestfile8\".\"description\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16");
fromBuilder.Append(" FROM {OrderRequestFile} \"enorderrequestfile8\"");
whereBuilder.Append(" WHERE ");
if (qporOrderId != 0) {
whereBuilder.Append("((\"enorderrequestfile8\".\"orderid\" = @qporOrderId) AND (\"enorderrequestfile8\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enorderrequestfile8\".\"orderid\" IS NULL)");
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
RL_d258c3d50d870257794347fdeb7cc218 outParamList = new RL_d258c3d50d870257794347fdeb7cc218();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderRequestedFilesEmailProveedor.GetOrderRequestFilesByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d258c3d50d870257794347fdeb7cc218 _tmp = new RL_d258c3d50d870257794347fdeb7cc218();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderRequestedFilesEmailProveedor.GetOrderRequestFilesByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d258c3d50d870257794347fdeb7cc218)_tmp;
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

private static async Task<RC_27125ab538212d639b6d08211936027a> datasetGetOrderAccountingsByOrderIdReadDbAsync(RC_27125ab538212d639b6d08211936027a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENOrderAccounting.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccountingsByOrderId" aZm68Zn9PUqx_9dScajDhQ of Action "SendOrderRequestedFilesEmailProveedor"
public static async Task<(RL_fe2a66f29d923f08aaf84e90873f4cc6,long)> datasetGetOrderAccountingsByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccounting_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendOrderRequestedFilesEmailProveedor.GetOrderAccountingsByOrderId", "f1ba9969-fd99-4a3d-b1ff-d75271a8c385");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendOrderRequestedFilesEmailProveedor.GetOrderAccountingsByOrderId", "f1ba9969-fd99-4a3d-b1ff-d75271a8c385", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.qedH1byemUubQIcSBpj03A/NodesNotShownInESpaceTree.aZm68Zn9PUqx_9dScajDhQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingdatatype6\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37");
fromBuilder.Append(" FROM (({OrderAccounting} \"enorderaccounting2\" Left JOIN {OrderAccConcepts} \"enorderaccconcepts8\" ON (\"enorderaccounting2\".\"id\" = \"enorderaccconcepts8\".\"orderaccountingid\"))  Left JOIN {AccountingDataType} \"enaccountingdatatype6\" ON (\"enorderaccconcepts8\".\"accountingdatatypeid\" = \"enaccountingdatatype6\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccounting_OrderId != 0) {
whereBuilder.Append("((\"enorderaccounting2\".\"orderid\" = @qporOrderAccounting_OrderId) AND (\"enorderaccounting2\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccounting_OrderId", DbType.Int64, qporOrderAccounting_OrderId);
} else {
whereBuilder.Append("(\"enorderaccounting2\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts8\".\"orderaccconceptsid\" IS NOT NULL)");
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
RL_fe2a66f29d923f08aaf84e90873f4cc6 outParamList = new RL_fe2a66f29d923f08aaf84e90873f4cc6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccountingsByOrderIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendOrderRequestedFilesEmailProveedor.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fe2a66f29d923f08aaf84e90873f4cc6 _tmp = new RL_fe2a66f29d923f08aaf84e90873f4cc6();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccountingsByOrderIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendOrderRequestedFilesEmailProveedor.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fe2a66f29d923f08aaf84e90873f4cc6)_tmp;
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
