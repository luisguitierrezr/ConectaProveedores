namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendEmailSupplier_FolioApproved : VarsBag {
public long inParami_FolioId;
public bool inParami_IsConstruction;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_2b9a8ce7bf73dacd0e0e114719f57b83 queryResGetFolioById_outParamList = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
public long queryResGetFolioById_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_519cfbd5c9d3e969a6c55ad5a0702da1 queryResGetUsersProveedores_outParamList = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
public long queryResGetUsersProveedores_outParamCount = 0L;

public lcvSendEmailSupplier_FolioApproved(long inParami_FolioId, bool inParami_IsConstruction) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_IsConstruction = inParami_IsConstruction;
}
}
/// <summary>
/// Action <code>SendEmailSupplier_FolioApproved</code> that represents the Service Studio action
///  <code>SendEmailSupplier_FolioApproved</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendEmailSupplier_FolioApproved(IRequestContext requestContext,long inParami_FolioId,bool inParami_IsConstruction,CancellationToken cancellationToken) {
lcvSendEmailSupplier_FolioApproved localVars = new lcvSendEmailSupplier_FolioApproved(inParami_FolioId, inParami_IsConstruction);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendEmailSupplier_FolioApproved", "43562381-b42d-41bf-8742-98233d31b191"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendEmailSupplier_FolioApproved", "43562381-b42d-41bf-8742-98233d31b191", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((!(((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_BlockNotifsEXP4])))))) {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionSendEmailSupplier_FolioApproved.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Query datasetGetUsersProveedores
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersProveedores_maxRecords = 0;
int datasetGetUsersProveedores_startIndex = 0;(localVars.queryResGetUsersProveedores_outParamList,localVars.queryResGetUsersProveedores_outParamCount) = await FuncActionSendEmailSupplier_FolioApproved.datasetGetUsersProveedores(requestContext,datasetGetUsersProveedores_maxRecords,datasetGetUsersProveedores_startIndex,IterationMultiplicity.Single,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssSupplierId,cancellationToken);

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
await Actions.ActionInAppNotification(requestContext,((BasicTypeList<string>)(new string[] { localVars.varLcl_EmailNotification.CurrentRec.ssUserId })),"",0,("Folios - Folio Aprobado "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber),(("Lo folio "+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+"  acaba de ser aprobado."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotification.CurrentRec.ssEmail,0,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("FolioApproved", "b546c35c-aba5-4a70-8f79-a909ab60917d"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("FolioApproved", "b546c35c-aba5-4a70-8f79-a909ab60917d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails.j_FoliosSAE_Emails_FolioApproved>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber, localVars.varLcl_EmailNotification.CurrentRec.ssName, ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM, (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))), "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), localVars.inParami_IsConstruction, cancellationToken),
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

public static class FuncActionSendEmailSupplier_FolioApproved {

private static async Task<RC_77e758d8dd6b0d691548b18323e10e77> datasetGetFolioByIdReadDbAsync(RC_77e758d8dd6b0d691548b18323e10e77 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" fWHNnT44aUiSD4SRim4G_w of Action "SendEmailSupplier_FolioApproved"
public static async Task<(RL_2b9a8ce7bf73dacd0e0e114719f57b83,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailSupplier_FolioApproved.GetFolioById", "9dcd617d-383e-4869-920f-84918a6e06ff");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailSupplier_FolioApproved.GetFolioById", "9dcd617d-383e-4869-920f-84918a6e06ff", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gSNWQy20v0GHQpgjPTGxkQ/NodesNotShownInESpaceTree.fWHNnT44aUiSD4SRim4G_w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio10\".\"folionumber\" o2, NULL o3, NULL o4, \"enfolio10\".\"supplierid\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enfoliosapdata3\".\"po_documento_material_em\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM ({Folio} \"enfolio10\" Left JOIN {FolioSAPData} \"enfoliosapdata3\" ON (\"enfolio10\".\"id\" = \"enfoliosapdata3\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio10\".\"id\" = @qpfoFolio_Id) AND (\"enfolio10\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio10\".\"id\" IS NULL)");
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
RL_2b9a8ce7bf73dacd0e0e114719f57b83 outParamList = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailSupplier_FolioApproved.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2b9a8ce7bf73dacd0e0e114719f57b83 _tmp = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailSupplier_FolioApproved.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2b9a8ce7bf73dacd0e0e114719f57b83)_tmp;
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
// Query Function "GetUsersProveedores" u8zq4q847UuWpQV0dqD9Tg of Action "SendEmailSupplier_FolioApproved"
public static async Task<(RL_519cfbd5c9d3e969a6c55ad5a0702da1,long)> datasetGetUsersProveedores(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplierUser_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendEmailSupplier_FolioApproved.GetUsersProveedores", "e2eaccbb-38af-4bed-96a5-057476a0fd4e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendEmailSupplier_FolioApproved.GetUsersProveedores", "e2eaccbb-38af-4bed-96a5-057476a0fd4e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gSNWQy20v0GHQpgjPTGxkQ/NodesNotShownInESpaceTree.u8zq4q847UuWpQV0dqD9Tg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplieruser4\".\"id\" o0, \"ensupplieruser4\".\"supplierid\" o1, \"ensupplieruser4\".\"userid\" o2, \"ensupplieruser4\".\"name\" o3, \"ensupplieruser4\".\"email\" o4, \"ensupplieruser4\".\"activationemailsentdate\" o5, \"ensupplieruser4\".\"isactive\" o6, \"ensupplieruser4\".\"isdeleted\" o7, \"ensupplieruser4\".\"isblocked\" o8, \"ensupplieruser4\".\"blockeduntil\" o9, \"ensupplieruser4\".\"lastlogindate\" o10, \"ensupplieruser4\".\"createdby\" o11, \"ensupplieruser4\".\"createdon\" o12, \"ensupplieruser4\".\"updatedby\" o13, \"ensupplieruser4\".\"updatedon\" o14, \"enuser44\".\"id\" o15, \"enuser44\".\"name\" o16, \"enuser44\".\"email\" o17, \"enuser44\".\"photourl\" o18, \"enuser44\".\"username\" o19, \"enuserextension25\".\"id\" o20, \"enuserextension25\".\"correspondentexternalemail\" o21, \"enuserextension25\".\"emailto\" o22");
fromBuilder.Append(" FROM (({User} \"enuser44\" Left JOIN {UserExtension} \"enuserextension25\" ON (\"enuser44\".\"id\" = \"enuserextension25\".\"id\"))  Left JOIN {SupplierUser} \"ensupplieruser4\" ON (\"enuser44\".\"id\" = \"ensupplieruser4\".\"userid\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierUser_SupplierId != 0) {
whereBuilder.Append("((\"ensupplieruser4\".\"supplierid\" = @qpsuSupplierUser_SupplierId) AND (\"ensupplieruser4\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierUser_SupplierId", DbType.Int64, qpsuSupplierUser_SupplierId);
} else {
whereBuilder.Append("(\"ensupplieruser4\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"ensupplieruser4\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendEmailSupplier_FolioApproved.GetUsersProveedores.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendEmailSupplier_FolioApproved.GetUsersProveedores.List", cancellationToken: cancellationToken);
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
