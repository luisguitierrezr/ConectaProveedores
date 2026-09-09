namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendResetPasswordEmail : VarsBag {
public string inParamApplicationName;
public string inParamCustomerEmail;
public ST_7df0b593cd1052614bf3d2f66d1ab2efStructure resStartResetPassword_outParamStartResetPasswordResult = new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure();

public long resServiceUserManagementLogsCreate8_outParamId = 0L;

public long resServiceUserManagementLogsCreate7_outParamId = 0L;

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResTryGetNameByEmail_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResTryGetNameByEmail_outParamCount = 0L;

public lcvSendResetPasswordEmail(string inParamApplicationName, string inParamCustomerEmail) {
this.inParamApplicationName = inParamApplicationName;
this.inParamCustomerEmail = inParamCustomerEmail;
}
}
public class lcoSendResetPasswordEmail : VarsBag {
public bool outParamSuccess = false;

public lcoSendResetPasswordEmail() {
}
}
/// <summary>
/// Action <code>SendResetPasswordEmail</code> that represents the Service Studio action
///  <code>SendResetPasswordEmail</code> <p> Description: Triggers the reset password operation fo
/// r users that don’t have access to the ODC Portal, returning a verification code that can be sent by
///  email to the user.</p>
/// </summary>
public static async Task<bool> ActionSendResetPasswordEmail(IRequestContext requestContext,string inParamApplicationName,string inParamCustomerEmail,CancellationToken cancellationToken) {
bool outParamSuccess = default;
lcoSendResetPasswordEmail result = new lcoSendResetPasswordEmail();
lcvSendResetPasswordEmail localVars = new lcvSendResetPasswordEmail(inParamApplicationName, inParamCustomerEmail);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendResetPasswordEmail", "509b534d-7c3a-4800-a9f3-b73d7d09dd19"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendResetPasswordEmail", "509b534d-7c3a-4800-a9f3-b73d7d09dd19", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// ServiceUserManagementLogsCreate7
localVars.resServiceUserManagementLogsCreate7_outParamId = await ServiceAPIs.ServiceAPIServiceUserManagementLogsCreate(requestContext,BuiltInFunction.GetUserId (),((AppUtils.GetStringResource("FroysgZFDUq2pje3g+46yQ#Value.-97754312.1", "The user requested a new password: ")+" ")+localVars.inParamCustomerEmail),"","",cancellationToken);

// StartResetPassword
localVars.resStartResetPassword_outParamStartResetPasswordResult = await ExtendedActions.StartResetPassword(requestContext,localVars.inParamCustomerEmail,cancellationToken);

// Success?
if(((localVars.resStartResetPassword_outParamStartResetPasswordResult.ssSuccess&&(BuiltInFunction.LengthSC (localVars.resStartResetPassword_outParamStartResetPasswordResult.ssVerificationCode)>0)))) {
// Query datasetTryGetNameByEmail
cancellationToken.ThrowIfCancellationRequested();
int datasetTryGetNameByEmail_maxRecords = 1;
if (datasetTryGetNameByEmail_maxRecords < 1) datasetTryGetNameByEmail_maxRecords = 1;
int datasetTryGetNameByEmail_startIndex = 0;(localVars.queryResTryGetNameByEmail_outParamList,localVars.queryResTryGetNameByEmail_outParamCount) = await FuncActionSendResetPasswordEmail.datasetTryGetNameByEmail(requestContext,datasetTryGetNameByEmail_maxRecords,datasetTryGetNameByEmail_startIndex,IterationMultiplicity.Never,localVars.inParamCustomerEmail,cancellationToken);

// ServiceUserManagementLogsCreate8
localVars.resServiceUserManagementLogsCreate8_outParamId = await ServiceAPIs.ServiceAPIServiceUserManagementLogsCreate(requestContext,BuiltInFunction.GetUserId (),((AppUtils.GetStringResource("VL1KUqZ+OUGNt8HY54UsSw#Value.-2108275950.1", "An email was sent so that the user could reset their password:")+" ")+localVars.inParamCustomerEmail),"","",cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ResetPassword", "ddd51087-195f-4cfe-8ec5-563fc80f4f8a"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ResetPassword", "ddd51087-195f-4cfe-8ec5-563fc80f4f8a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowa_Emails.a_Emails_ResetPassword>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , localVars.inParamApplicationName, localVars.queryResTryGetNameByEmail_outParamList.CurrentRec.ssENUser.ssName, localVars.inParamCustomerEmail, localVars.resStartResetPassword_outParamStartResetPasswordResult.ssVerificationCode, (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
        To = (((((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))!="QA")) ? (localVars.inParamCustomerEmail) : ((((localVars.queryResTryGetNameByEmail_outParamList.CurrentRec.ssENUserExtension.ssEmailto!="")) ? (localVars.queryResTryGetNameByEmail_outParamList.CurrentRec.ssENUserExtension.ssEmailto) : (localVars.inParamCustomerEmail)))),
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
// Success = True
result.outParamSuccess=true;
} else {
// Fake success
// Success = True
result.outParamSuccess=true;
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// Success = False
// Success = False
result.outParamSuccess=false;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamSuccess = result.outParamSuccess;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamSuccess;
}

public static class FuncActionSendResetPasswordEmail {

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetTryGetNameByEmailReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "TryGetNameByEmail" PbG65GPf2kWO0iLP4pPcGQ of Action "SendResetPasswordEmail"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetTryGetNameByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpemUser_Email,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendResetPasswordEmail.TryGetNameByEmail", "e4bab13d-df63-45da-8ed2-22cfe293dc19");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendResetPasswordEmail.TryGetNameByEmail", "e4bab13d-df63-45da-8ed2-22cfe293dc19", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.TVObUDp8AEip87c9fQndGQ/NodesNotShownInESpaceTree.PbG65GPf2kWO0iLP4pPcGQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser53\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuserextension30\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser53\" Left JOIN {UserExtension} \"enuserextension30\" ON (\"enuser53\".\"id\" = \"enuserextension30\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser53\".\"email\" = @qpemUser_Email)");
orderByBuilder.Append(" ORDER BY \"enuser53\".\"name\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpemUser_Email", DbType.String, qpemUser_Email);
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
outParamList.AlternateReadDbMethodAsync = datasetTryGetNameByEmailReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendResetPasswordEmail.TryGetNameByEmail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetTryGetNameByEmailReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendResetPasswordEmail.TryGetNameByEmail.List", cancellationToken: cancellationToken);
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



}


}
