namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendChangeEmail : VarsBag {
public string inParamApplicationName;
public string inParamCustomerEmail;
public RL_c5c32c91f72d14efd2c0ccca15008afa queryResTryGetNameByEmail_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResTryGetNameByEmail_outParamCount = 0L;

public ST_f4b6c6eeb122dfa3165aeece838fd077Structure resStartUpdateEmail_outParamStartUpdateEmailResult = new ST_f4b6c6eeb122dfa3165aeece838fd077Structure();

public lcvSendChangeEmail(string inParamApplicationName, string inParamCustomerEmail) {
this.inParamApplicationName = inParamApplicationName;
this.inParamCustomerEmail = inParamCustomerEmail;
}
}
public class lcoSendChangeEmail : VarsBag {
public bool outParamSuccess = false;

public lcoSendChangeEmail() {
}
}
/// <summary>
/// Action <code>SendChangeEmail</code> that represents the Service Studio action
///  <code>SendChangeEmail</code> <p> Description: Triggers the update email operation for users wh
/// o don't  have access to the ODC Portal, returning a verification code that  can be sent by email to
///  the user.</p>
/// </summary>
public static async Task<bool> ActionSendChangeEmail(IRequestContext requestContext,string inParamApplicationName,string inParamCustomerEmail,CancellationToken cancellationToken) {
bool outParamSuccess = default;
lcoSendChangeEmail result = new lcoSendChangeEmail();
lcvSendChangeEmail localVars = new lcvSendChangeEmail(inParamApplicationName, inParamCustomerEmail);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendChangeEmail", "bfc89435-186e-4b59-9466-ec4a06915318"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendChangeEmail", "bfc89435-186e-4b59-9466-ec4a06915318", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// StartUpdateEmail
localVars.resStartUpdateEmail_outParamStartUpdateEmailResult = await ExtendedActions.StartUpdateEmail(requestContext,localVars.inParamCustomerEmail,cancellationToken);

// Success?
if(((localVars.resStartUpdateEmail_outParamStartUpdateEmailResult.ssSuccess&&(BuiltInFunction.LengthSC (localVars.resStartUpdateEmail_outParamStartUpdateEmailResult.ssVerificationCode)>0)))) {
// Query datasetTryGetNameByEmail
cancellationToken.ThrowIfCancellationRequested();
int datasetTryGetNameByEmail_maxRecords = 1;
if (datasetTryGetNameByEmail_maxRecords < 1) datasetTryGetNameByEmail_maxRecords = 1;
int datasetTryGetNameByEmail_startIndex = 0;(localVars.queryResTryGetNameByEmail_outParamList,localVars.queryResTryGetNameByEmail_outParamCount) = await FuncActionSendChangeEmail.datasetTryGetNameByEmail(requestContext,datasetTryGetNameByEmail_maxRecords,datasetTryGetNameByEmail_startIndex,IterationMultiplicity.Never,localVars.inParamCustomerEmail,cancellationToken);

using (AppHealthProvider.CreateSendEmailMetric("ChangeEmail", "5f0b6aa8-cbf2-4874-b490-e1b463a9ac25"))
using (var sendEmailActivity = activitySource.CreateSendEmailActivity("ChangeEmail", "5f0b6aa8-cbf2-4874-b490-e1b463a9ac25", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
    var emailScreen = ServiceLocator.GetService<ssConectaProveedores.Flows.Flowa_Emails.a_Emails_ChangeEmail>();

    RLAttachmentList attachments = null;
    List<OutSystems.Application.Models.Emails.Attachment> mappedAttachments = attachments?.ToArray(t => new OutSystems.Application.Models.Emails.Attachment(t.ssFileName, t.ssFileContent, t.ssMimeType)).ToList();

    var message = new OutSystems.Application.Models.Emails.Message() {
        Body = await emailScreen.GetEmailContentAsync(requestContext , localVars.inParamApplicationName, localVars.queryResTryGetNameByEmail_outParamList.CurrentRec.ssENUser.ssName, localVars.inParamCustomerEmail, localVars.resStartUpdateEmail_outParamStartUpdateEmailResult.ssVerificationCode, (((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])))=="PROD"), cancellationToken),
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
// Success = True
result.outParamSuccess=true;
} else {
// Success = False
// Success = False
result.outParamSuccess=false;
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

public static class FuncActionSendChangeEmail {

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetTryGetNameByEmailReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "TryGetNameByEmail" iq3iLPylc0egrF_S53UHuQ of Action "SendChangeEmail"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetTryGetNameByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpemUser_Email,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SendChangeEmail.TryGetNameByEmail", "2ce2ad8a-a5fc-4773-a0ac-5fd2e77507b9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SendChangeEmail.TryGetNameByEmail", "2ce2ad8a-a5fc-4773-a0ac-5fd2e77507b9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.NZTIv24YWUuUZuxKBpFTGA/NodesNotShownInESpaceTree.iq3iLPylc0egrF_S53UHuQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser107\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuserextension49\".\"emailto\" o7");
fromBuilder.Append(" FROM ({User} \"enuser107\" Left JOIN {UserExtension} \"enuserextension49\" ON (\"enuser107\".\"id\" = \"enuserextension49\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser107\".\"email\" = @qpemUser_Email)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SendChangeEmail.TryGetNameByEmail.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SendChangeEmail.TryGetNameByEmail.List", cancellationToken: cancellationToken);
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
