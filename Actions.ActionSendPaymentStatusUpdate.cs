namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendPaymentStatusUpdate : VarsBag {
public long inParami_ProposalId;
public int inParami_OldProposalStatusId;
public bool inParamIsPartiallyPaid;
/// <summary>
/// Variable <code>l_EmailNotification</code> that represents the Service Studio EmailNotificationList
///  <code>l_EmailNotification</code> <p>Description: Email list for notification</p>
/// </summary>
public RL_39507255c499d96d2e7021755eecd9e1 varLcl_EmailNotification = new RL_39507255c499d96d2e7021755eecd9e1();

/// <summary>
/// Variable <code>l_EmailNotificationToText</code> that represents the Service Studio Text
///  <code>l_EmailNotificationToText</code> <p>Description: Email list for notification CC</p>
/// </summary>
public string varLcl_EmailNotificationToText = "";

/// <summary>
/// Variable <code>l_ProposalUnpaid</code> that represents the Service Studio
///  AccountAmountMDAmountMLCommentCurrencyMDCurrencyMLNumDocRefRegionNameSocietyNameSupplierNameRecordL
/// ist <code>l_ProposalUnpaid</code> <p>Description: </p>
/// </summary>
public RL_3de40603ae6c869db08c8514af3a6489 varLcl_ProposalUnpaid = new RL_3de40603ae6c869db08c8514af3a6489();

public RL_5d12cbdbc739013acbdd9f1aee86f8c2 queryResGetUsersByApplicationRoles_outParamList = new RL_5d12cbdbc739013acbdd9f1aee86f8c2();
public long queryResGetUsersByApplicationRoles_outParamCount = 0L;

public RL_39507255c499d96d2e7021755eecd9e1 resListDistinct_outParamDistinctList = new RL_39507255c499d96d2e7021755eecd9e1();

public RL_273266e5ba4c20bd7cdd113c40b539f2 queryResGetProposalLineUnpaid_outParamList = new RL_273266e5ba4c20bd7cdd113c40b539f2();
public long queryResGetProposalLineUnpaid_outParamCount = 0L;

public RL_4af0df87a4249e2f3fcc7e163847dc5a queryResGetProposalById_outParamList = new RL_4af0df87a4249e2f3fcc7e163847dc5a();
public long queryResGetProposalById_outParamCount = 0L;

public Actions.lcoMatchRecipientEmails resMatchRecipientEmails =  new Actions.lcoMatchRecipientEmails();
public RL_82f8f815f9fb0b6e192e24e072fb8ae2 queryResGetUserExtendedInternalsByRegionId_outParamList = new RL_82f8f815f9fb0b6e192e24e072fb8ae2();
public long queryResGetUserExtendedInternalsByRegionId_outParamCount = 0L;

public RL_edf26e482e095588ed6d5cbd5313bc7f queryResGetOldProposalStatusById_outParamList = new RL_edf26e482e095588ed6d5cbd5313bc7f();
public long queryResGetOldProposalStatusById_outParamCount = 0L;

public lcvSendPaymentStatusUpdate(long inParami_ProposalId, int inParami_OldProposalStatusId, bool inParamIsPartiallyPaid) {
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_OldProposalStatusId = inParami_OldProposalStatusId;
this.inParamIsPartiallyPaid = inParamIsPartiallyPaid;
}
}
/// <summary>
/// Action <code>SendPaymentStatusUpdate</code> that represents the Service Studio action
///  <code>SendPaymentStatusUpdate</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendPaymentStatusUpdate(IRequestContext requestContext,long inParami_ProposalId,int inParami_OldProposalStatusId,bool inParamIsPartiallyPaid,CancellationToken cancellationToken) {
lcvSendPaymentStatusUpdate localVars = new lcvSendPaymentStatusUpdate(inParami_ProposalId, inParami_OldProposalStatusId, inParamIsPartiallyPaid);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendPaymentStatusUpdate", "d3de26a5-0004-4afc-a447-0b16431e3e62"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendPaymentStatusUpdate", "d3de26a5-0004-4afc-a447-0b16431e3e62", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProposalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalById_maxRecords = 0;
int datasetGetProposalById_startIndex = 0;(localVars.queryResGetProposalById_outParamList,localVars.queryResGetProposalById_outParamCount) = await FuncActionSendPaymentStatusUpdate.datasetGetProposalById(requestContext,datasetGetProposalById_maxRecords,datasetGetProposalById_startIndex,IterationMultiplicity.Single,localVars.inParami_ProposalId,cancellationToken);

// Foreach GetProposalById.List
localVars.queryResGetProposalById_outParamList.StartIteration();
try {while (!((localVars.queryResGetProposalById_outParamList.Eof))) {
// Query datasetGetUserExtendedInternalsByRegionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalsByRegionId_maxRecords = 0;
int datasetGetUserExtendedInternalsByRegionId_startIndex = 0;(localVars.queryResGetUserExtendedInternalsByRegionId_outParamList,localVars.queryResGetUserExtendedInternalsByRegionId_outParamCount) = await FuncActionSendPaymentStatusUpdate.datasetGetUserExtendedInternalsByRegionId(requestContext,datasetGetUserExtendedInternalsByRegionId_maxRecords,datasetGetUserExtendedInternalsByRegionId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssRegionId,localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposalApprovalLevel.ssApplicationRoleId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUserExtendedInternalsByRegionId_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_7655e3fb0214830e441b4ca25cd396cb source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUserApplicationRole.ssUserId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
target.ssEmailTo = source.ssENUserExtension.ssEmailto;
return target;
}, cancellationToken)),cancellationToken);

localVars.queryResGetProposalById_outParamList.Advance();
}

} finally {
localVars.queryResGetProposalById_outParamList.EndIteration();
}

// Query datasetGetUsersByApplicationRoles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersByApplicationRoles_maxRecords = 0;
int datasetGetUsersByApplicationRoles_startIndex = 0;(localVars.queryResGetUsersByApplicationRoles_outParamList,localVars.queryResGetUsersByApplicationRoles_outParamCount) = await FuncActionSendPaymentStatusUpdate.datasetGetUsersByApplicationRoles(requestContext,datasetGetUsersByApplicationRoles_maxRecords,datasetGetUsersByApplicationRoles_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_EmailNotification,(await RL_39507255c499d96d2e7021755eecd9e1.ConvertAsync(localVars.queryResGetUsersByApplicationRoles_outParamList, new RL_39507255c499d96d2e7021755eecd9e1(), async (RC_c77d66d9ff86c86854dcdb2c4c9f3219 source, ST_12668886130225cd5b17c72a6562dd7cStructure target, CancellationToken cancellationToken) => {
target.ssUserId = source.ssENUserApplicationRole.ssUserId;
target.ssEmail = source.ssENUser.ssEmail;
target.ssName = source.ssENUser.ssName;
return target;
}, cancellationToken)),cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_39507255c499d96d2e7021755eecd9e1) localVars.varLcl_EmailNotification.Distinct()));

// Query datasetGetOldProposalStatusById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOldProposalStatusById_maxRecords = 1;
if (datasetGetOldProposalStatusById_maxRecords < 1) datasetGetOldProposalStatusById_maxRecords = 1;
int datasetGetOldProposalStatusById_startIndex = 0;(localVars.queryResGetOldProposalStatusById_outParamList,localVars.queryResGetOldProposalStatusById_outParamCount) = await FuncActionSendPaymentStatusUpdate.datasetGetOldProposalStatusById(requestContext,datasetGetOldProposalStatusById_maxRecords,datasetGetOldProposalStatusById_startIndex,IterationMultiplicity.Never,localVars.inParami_OldProposalStatusId,cancellationToken);

if((localVars.inParamIsPartiallyPaid)) {
// Query datasetGetProposalLineUnpaid
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLineUnpaid_maxRecords = 50;
if (datasetGetProposalLineUnpaid_maxRecords < 1) datasetGetProposalLineUnpaid_maxRecords = 1;
int datasetGetProposalLineUnpaid_startIndex = 0;(localVars.queryResGetProposalLineUnpaid_outParamList,localVars.queryResGetProposalLineUnpaid_outParamCount) = await FuncActionSendPaymentStatusUpdate.datasetGetProposalLineUnpaid(requestContext,datasetGetProposalLineUnpaid_maxRecords,datasetGetProposalLineUnpaid_startIndex,IterationMultiplicity.Multiple,localVars.inParami_ProposalId,cancellationToken);

// ListAppendAll3
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_ProposalUnpaid,(await RL_3de40603ae6c869db08c8514af3a6489.ConvertAsync(localVars.queryResGetProposalLineUnpaid_outParamList, new RL_3de40603ae6c869db08c8514af3a6489(), async (RC_344c35cf0b565533cad543b081be7d24 source, RC_4dd2c54294876907ff3203d83c5ad25d target, CancellationToken cancellationToken) => {
target.ssAccount = source.ssENProposalLine.ssCuenta;
target.ssAmountMD = BuiltInFunction.FormatDecimal (source.ssENProposalLine.ssImporteenMD, 2, ".", ",");
target.ssAmountML = BuiltInFunction.FormatDecimal (source.ssENProposalLine.ssImporteenML, 2, ".", ",");
target.ssComment = source.ssENProposalComment.ssMessage;
target.ssCurrencyMD = source.ssENProposalLine.ssMon_;
target.ssCurrencyML = source.ssENProposalLine.ssML;
target.ssNumDoc = source.ssENProposalLine.ssN_doc_;
target.ssRef = source.ssENProposalLine.ssReferencia;
target.ssRegionName = source.ssENRegion.ssName;
target.ssSocietyName = source.ssENProposalLine.ssSoc_;
target.ssSupplierName = source.ssENSupplier.ssName;
return target;
}, cancellationToken)),cancellationToken);

}

// Foreach l_EmailNotification
localVars.varLcl_EmailNotification.StartIteration();
try {while (!((localVars.varLcl_EmailNotification.Eof))) {
// l_EmailNotificationToText = l_EmailNotificationToText + If + If
localVars.varLcl_EmailNotificationToText=((localVars.varLcl_EmailNotificationToText+(((localVars.varLcl_EmailNotificationToText=="")) ? ("") : (",")))+(((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmail) : ((((localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo!="")) ? (localVars.varLcl_EmailNotification.CurrentRec.ssEmailTo) : (localVars.varLcl_EmailNotification.CurrentRec.ssEmail)))));
localVars.varLcl_EmailNotification.Advance();
}

} finally {
localVars.varLcl_EmailNotification.EndIteration();
}

// InAppNotification
await Actions.ActionInAppNotification(requestContext,(await BasicTypeList<string>.ConvertAsync(localVars.varLcl_EmailNotification, new BasicTypeList<string>(), async (ST_12668886130225cd5b17c72a6562dd7cStructure source, string target, CancellationToken cancellationToken) => {
target = source.ssUserId;
return target;
}, cancellationToken)),"",1,(((("Comissiones Y Arrendamientos - Propuesta"+" ")+localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName)+" ")+"sufrió un cambio en su estado."),(((((("La propuesta "+localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName)+" ha cambiado su estado de ")+localVars.queryResGetOldProposalStatusById_outParamList.CurrentRec.ssENProposalStatus.ssLabel)+" a ")+localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposalStatus.ssLabel)+"."),cancellationToken);

// MatchRecipientEmails
localVars.resMatchRecipientEmails.outParamResult = await Actions.ActionMatchRecipientEmails(requestContext,localVars.varLcl_EmailNotificationToText,1,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ProposalStatusChange2", "5186c5fc-60fe-480f-93a7-05b4ba2f3aae"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ProposalStatusChange2", "5186c5fc-60fe-480f-93a7-05b4ba2f3aae", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowb_CyA_Emails.b_CyA_Emails_ProposalStatusChange>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , "Conecta Proveedores", ((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment]))), localVars.inParamIsPartiallyPaid, localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposalStatus.ssLabel, localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName, localVars.queryResGetOldProposalStatusById_outParamList.CurrentRec.ssENProposalStatus.ssLabel, ((((AppUtils.GetStringResource("bMKZD7OIWEqeZnbDrGFCqw#Value.-1470417441.1", "Comissiones Y Arrendamientos - Propuesta")+" ")+localVars.queryResGetProposalById_outParamList.CurrentRec.ssENProposal.ssName)+" ")+"sufrió un cambio en su estado."), localVars.varLcl_ProposalUnpaid, "", localVars.varLcl_EmailNotificationToText, "", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = (((localVars.resMatchRecipientEmails.outParamResult!="")) ? (localVars.resMatchRecipientEmails.outParamResult) : (localVars.varLcl_EmailNotificationToText)),
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

public static class FuncActionSendPaymentStatusUpdate {

private static async Task<RC_c77d66d9ff86c86854dcdb2c4c9f3219> datasetGetUsersByApplicationRolesReadDbAsync(RC_c77d66d9ff86c86854dcdb2c4c9f3219 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "GetUsersByApplicationRoles" ORc7LiOIdEGMXza4pQhqrA of Action "SendPaymentStatusUpdate"
public static async Task<(RL_5d12cbdbc739013acbdd9f1aee86f8c2,long)> datasetGetUsersByApplicationRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendPaymentStatusUpdate.GetUsersByApplicationRoles", "2e3b1739-8823-4174-8c5f-36b8a5086aac");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendPaymentStatusUpdate.GetUsersByApplicationRoles", "2e3b1739-8823-4174-8c5f-36b8a5086aac", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pSbe0wQA_EqkRwsWQx4+Yg/NodesNotShownInESpaceTree.ORc7LiOIdEGMXza4pQhqrA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enuser118\".\"name\" o8, \"enuser118\".\"email\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enuserapplicationrole14\".\"userid\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41");
fromBuilder.Append(" FROM ((({UserApplicationRole} \"enuserapplicationrole14\" Left JOIN {ApplicationRole} \"enapplicationrole27\" ON (\"enuserapplicationrole14\".\"applicationroleid\" = \"enapplicationrole27\".\"id\"))  Left JOIN {User} \"enuser118\" ON (\"enuserapplicationrole14\".\"userid\" = \"enuser118\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal69\" ON (\"enuser118\".\"id\" = \"enuser_extended_internal69\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enapplicationrole27\".\"code\" = 'ADMIN_AREA_CENTRALIZACION')");
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
RL_5d12cbdbc739013acbdd9f1aee86f8c2 outParamList = new RL_5d12cbdbc739013acbdd9f1aee86f8c2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersByApplicationRolesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendPaymentStatusUpdate.GetUsersByApplicationRoles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d12cbdbc739013acbdd9f1aee86f8c2 _tmp = new RL_5d12cbdbc739013acbdd9f1aee86f8c2();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersByApplicationRolesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendPaymentStatusUpdate.GetUsersByApplicationRoles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d12cbdbc739013acbdd9f1aee86f8c2)_tmp;
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

private static async Task<RC_344c35cf0b565533cad543b081be7d24> datasetGetProposalLineUnpaidReadDbAsync(RC_344c35cf0b565533cad543b081be7d24 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalComment.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetProposalLineUnpaid" kds3TbseQ0Sik4C6u2KqzQ of Action "SendPaymentStatusUpdate"
public static async Task<(RL_273266e5ba4c20bd7cdd113c40b539f2,long)> datasetGetProposalLineUnpaid(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendPaymentStatusUpdate.GetProposalLineUnpaid", "4d37db91-1ebb-4443-a293-80babb62aacd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendPaymentStatusUpdate.GetProposalLineUnpaid", "4d37db91-1ebb-4443-a293-80babb62aacd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pSbe0wQA_EqkRwsWQx4+Yg/NodesNotShownInESpaceTree.kds3TbseQ0Sik4C6u2KqzQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"enproposalcomment\".\"message\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enproposalline8\".\"cuenta\" o33, \"enproposalline8\".\"referencia\" o34, NULL o35, NULL o36, \"enproposalline8\".\"n_doc_\" o37, NULL o38, trim_scale(\"enproposalline8\".\"importeenml\"::numeric) o39, \"enproposalline8\".\"ml\" o40, trim_scale(\"enproposalline8\".\"importeenmd\"::numeric) o41, \"enproposalline8\".\"mon_\" o42, \"enproposalline8\".\"soc_\" o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, \"enregion52\".\"name\" o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, \"ensupplier43\".\"name\" o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94");
fromBuilder.Append(" FROM (((({ProposalLine} \"enproposalline8\" Left JOIN {Proposal} \"enproposal11\" ON (\"enproposalline8\".\"proposalid\" = \"enproposal11\".\"id\"))  Left JOIN {ProposalComment} \"enproposalcomment\" ON (\"enproposalline8\".\"id\" = \"enproposalcomment\".\"proposallineid\"))  Left JOIN {Region} \"enregion52\" ON (\"enproposal11\".\"regionid\" = \"enregion52\".\"id\"))  Left JOIN {Supplier} \"ensupplier43\" ON (\"enproposalline8\".\"supplierid\" = \"ensupplier43\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enproposalline8\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("bkD8ux0JT02InXZZfkOUsA"))).ssId);
whereBuilder.Append(") AND ");
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal11\".\"id\" = @qpprProposal_Id) AND (\"enproposal11\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal11\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enproposalline8\".\"cuenta\" ASC ");
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
RL_273266e5ba4c20bd7cdd113c40b539f2 outParamList = new RL_273266e5ba4c20bd7cdd113c40b539f2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLineUnpaidReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, false, true, true, false, true, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendPaymentStatusUpdate.GetProposalLineUnpaid.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_273266e5ba4c20bd7cdd113c40b539f2 _tmp = new RL_273266e5ba4c20bd7cdd113c40b539f2();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLineUnpaidReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendPaymentStatusUpdate.GetProposalLineUnpaid.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_273266e5ba4c20bd7cdd113c40b539f2)_tmp;
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

private static async Task<RC_8d4e836281190fb3045013ce70fbff7d> datasetGetProposalByIdReadDbAsync(RC_8d4e836281190fb3045013ce70fbff7d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalApproval.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
rec.ssENProposalStatus.Read( r, ref index);
return rec;
}
// Query Function "GetProposalById" yoAmbPHgtEqzg+KyRUt44w of Action "SendPaymentStatusUpdate"
public static async Task<(RL_4af0df87a4249e2f3fcc7e163847dc5a,long)> datasetGetProposalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendPaymentStatusUpdate.GetProposalById", "6c2680ca-e0f1-4ab4-b383-e2b2454b78e3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendPaymentStatusUpdate.GetProposalById", "6c2680ca-e0f1-4ab4-b383-e2b2454b78e3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pSbe0wQA_EqkRwsWQx4+Yg/NodesNotShownInESpaceTree.yoAmbPHgtEqzg+KyRUt44w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enproposal12\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enproposal12\".\"regionid\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enproposalapprovallevel6\".\"applicationroleid\" o29, NULL o30, NULL o31, NULL o32, NULL o33, \"enproposalstatus\".\"label\" o34, NULL o35, NULL o36, NULL o37");
fromBuilder.Append(" FROM ((({Proposal} \"enproposal12\" Inner JOIN {ProposalApproval} \"enproposalapproval4\" ON (\"enproposal12\".\"id\" = \"enproposalapproval4\".\"proposalid\"))  Inner JOIN {ProposalApprovalLevel} \"enproposalapprovallevel6\" ON (\"enproposalapproval4\".\"id\" = \"enproposalapprovallevel6\".\"proposalapprovalid\"))  Left JOIN {ProposalStatus} \"enproposalstatus\" ON (\"enproposal12\".\"proposalstatusid\" = \"enproposalstatus\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal12\".\"id\" = @qpprProposal_Id) AND (\"enproposal12\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal12\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enproposal12\".\"name\" ASC ");
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
RL_4af0df87a4249e2f3fcc7e163847dc5a outParamList = new RL_4af0df87a4249e2f3fcc7e163847dc5a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendPaymentStatusUpdate.GetProposalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4af0df87a4249e2f3fcc7e163847dc5a _tmp = new RL_4af0df87a4249e2f3fcc7e163847dc5a();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendPaymentStatusUpdate.GetProposalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4af0df87a4249e2f3fcc7e163847dc5a)_tmp;
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

private static async Task<RC_7655e3fb0214830e441b4ca25cd396cb> datasetGetUserExtendedInternalsByRegionIdReadDbAsync(RC_7655e3fb0214830e441b4ca25cd396cb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalsByRegionId" OnhcsgMgIkyOaTo1oE_LUQ of Action "SendPaymentStatusUpdate"
public static async Task<(RL_82f8f815f9fb0b6e192e24e072fb8ae2,long)> datasetGetUserExtendedInternalsByRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreUser_Extended_Internal_RegionId,long qpapUserApplicationRole_ApplicationRoleId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendPaymentStatusUpdate.GetUserExtendedInternalsByRegionId", "b25c783a-2003-4c22-8e69-3a35a04fcb51");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendPaymentStatusUpdate.GetUserExtendedInternalsByRegionId", "b25c783a-2003-4c22-8e69-3a35a04fcb51", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pSbe0wQA_EqkRwsWQx4+Yg/NodesNotShownInESpaceTree.OnhcsgMgIkyOaTo1oE_LUQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser119\".\"name\" o1, \"enuser119\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enuserapplicationrole15\".\"userid\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enuserextension53\".\"emailto\" o37");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal70\" Inner JOIN {User} \"enuser119\" ON (\"enuser_extended_internal70\".\"id\" = \"enuser119\".\"id\"))  Left JOIN {UserApplicationRole} \"enuserapplicationrole15\" ON (\"enuser119\".\"id\" = \"enuserapplicationrole15\".\"userid\"))  Left JOIN {UserExtension} \"enuserextension53\" ON (\"enuser119\".\"id\" = \"enuserextension53\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal70\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal70\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal70\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapUserApplicationRole_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enuserapplicationrole15\".\"applicationroleid\" = @qpapUserApplicationRole_ApplicationRoleId) AND (\"enuserapplicationrole15\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapUserApplicationRole_ApplicationRoleId", DbType.Int64, qpapUserApplicationRole_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enuserapplicationrole15\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationrole15\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(")");
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
RL_82f8f815f9fb0b6e192e24e072fb8ae2 outParamList = new RL_82f8f815f9fb0b6e192e24e072fb8ae2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByRegionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendPaymentStatusUpdate.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_82f8f815f9fb0b6e192e24e072fb8ae2 _tmp = new RL_82f8f815f9fb0b6e192e24e072fb8ae2();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsByRegionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendPaymentStatusUpdate.GetUserExtendedInternalsByRegionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_82f8f815f9fb0b6e192e24e072fb8ae2)_tmp;
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

// Query Function "GetOldProposalStatusById" K2HWwsI8xUyYgRfUtMZcxQ of Action "SendPaymentStatusUpdate"
public static async Task<(RL_edf26e482e095588ed6d5cbd5313bc7f,long)> datasetGetOldProposalStatusById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpprId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendPaymentStatusUpdate.GetOldProposalStatusById", "c2d6612b-3cc2-4cc5-9881-17d4b4c65cc5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendPaymentStatusUpdate.GetOldProposalStatusById", "c2d6612b-3cc2-4cc5-9881-17d4b4c65cc5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pSbe0wQA_EqkRwsWQx4+Yg/NodesNotShownInESpaceTree.K2HWwsI8xUyYgRfUtMZcxQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enproposalstatus1\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProposalStatus} \"enproposalstatus1\"");
whereBuilder.Append(" WHERE (\"enproposalstatus1\".\"is_active\" = 1) AND ");
if (qpprId != 0) {
whereBuilder.Append("((\"enproposalstatus1\".\"id\" = @qpprId) AND (\"enproposalstatus1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int32, qpprId);
} else {
whereBuilder.Append("(\"enproposalstatus1\".\"id\" IS NULL)");
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
RL_edf26e482e095588ed6d5cbd5313bc7f outParamList = new RL_edf26e482e095588ed6d5cbd5313bc7f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendPaymentStatusUpdate.GetOldProposalStatusById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_edf26e482e095588ed6d5cbd5313bc7f _tmp = new RL_edf26e482e095588ed6d5cbd5313bc7f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendPaymentStatusUpdate.GetOldProposalStatusById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_edf26e482e095588ed6d5cbd5313bc7f)_tmp;
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
