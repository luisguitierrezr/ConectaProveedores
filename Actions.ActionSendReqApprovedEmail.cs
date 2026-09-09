namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendReqApprovedEmail : VarsBag {
public long inParami_RequisitionId;
public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_47a3693bfacffecca219041b04d0ade1 queryResGetRequisitionById_outParamList = new RL_47a3693bfacffecca219041b04d0ade1();
public long queryResGetRequisitionById_outParamCount = 0L;

public lcvSendReqApprovedEmail(long inParami_RequisitionId) {
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
/// <summary>
/// Action <code>SendReqApprovedEmail</code> that represents the Service Studio action
///  <code>SendReqApprovedEmail</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendReqApprovedEmail(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
lcvSendReqApprovedEmail localVars = new lcvSendReqApprovedEmail(inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendReqApprovedEmail", "43be7cf6-b981-4d7c-b748-0e599c280b7f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendReqApprovedEmail", "43be7cf6-b981-4d7c-b748-0e599c280b7f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionSendReqApprovedEmail.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Single,localVars.inParami_RequisitionId,cancellationToken);

// Foreach GetRequisitionById.List
localVars.queryResGetRequisitionById_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionById_outParamList.Eof))) {
// InAppNotification
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplierUser.ssUserId })),"",0,(("Requisiciones - Requisición "+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName)+" Aprobada"),(("La requisición "+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName)+" fue aprobada y ya puedes empezar cargando tus facturas!"),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplierUser.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ApprovedRequisition", "faf26c6b-6051-4cb9-9674-5a84aeb55f3f"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ApprovedRequisition", "faf26c6b-6051-4cb9-9674-5a84aeb55f3f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowc_Req_Emails.c_Req_Emails_ApprovedRequisition>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName, localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplierUser.ssName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplierUser.ssEmail, "", cancellationToken),
        To = (((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplierUser.ssEmail)),
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
localVars.queryResGetRequisitionById_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionById_outParamList.EndIteration();
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

public static class FuncActionSendReqApprovedEmail {

private static async Task<RC_d69ddf81a42e386a5136129388ff031f> datasetGetRequisitionByIdReadDbAsync(RC_d69ddf81a42e386a5136129388ff031f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" m0nUyYf3F0OIpAvZGXei4A of Action "SendReqApprovedEmail"
public static async Task<(RL_47a3693bfacffecca219041b04d0ade1,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendReqApprovedEmail.GetRequisitionById", "c9d4499b-f787-4317-88a4-0bd91977a2e0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendReqApprovedEmail.GetRequisitionById", "c9d4499b-f787-4317-88a4-0bd91977a2e0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.9ny+Q4G5fE23SA5ZnCgLfw/NodesNotShownInESpaceTree.m0nUyYf3F0OIpAvZGXei4A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enrequisition18\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, \"ensupplieruser5\".\"userid\" o88, \"ensupplieruser5\".\"name\" o89, \"ensupplieruser5\".\"email\" o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105");
fromBuilder.Append(" FROM ((({Requisition} \"enrequisition18\" Left JOIN {Supplier} \"ensupplier10\" ON (\"enrequisition18\".\"supplierid\" = \"ensupplier10\".\"id\"))  Left JOIN {SupplierUser} \"ensupplieruser5\" ON (\"ensupplier10\".\"id\" = \"ensupplieruser5\".\"supplierid\"))  Left JOIN {User} \"enuser45\" ON (\"enrequisition18\".\"applicantid\" = \"enuser45\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition18\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition18\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition18\".\"id\" IS NULL)");
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
RL_47a3693bfacffecca219041b04d0ade1 outParamList = new RL_47a3693bfacffecca219041b04d0ade1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, false, false, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendReqApprovedEmail.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_47a3693bfacffecca219041b04d0ade1 _tmp = new RL_47a3693bfacffecca219041b04d0ade1();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendReqApprovedEmail.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_47a3693bfacffecca219041b04d0ade1)_tmp;
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
