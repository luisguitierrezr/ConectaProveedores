namespace ssConectaProveedores;

public partial class Actions {
public class lcvInAppNotification : VarsBag {
public BasicTypeList<string> inParamUsers;
public string inParamUserIdsText;
public int inParamCategory;
public string inParamTitle;
public string inParamContent;
/// <summary>
/// Variable <code>tempusers</code> that represents the Service Studio TextList <code>tempusers</code>
///  <p>Description: </p>
/// </summary>
public BasicTypeList<string> varLctempusers = new BasicTypeList<string>();

public ST_8509a484f6b6eac99c83feddd35d5004Structure resNewNotification_outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

public RLTextRecordList resString_Split_outParamList = new RLTextRecordList();

public lcvInAppNotification(BasicTypeList<string> inParamUsers, string inParamUserIdsText, int inParamCategory, string inParamTitle, string inParamContent) {
this.inParamUsers = inParamUsers;
this.inParamUserIdsText = inParamUserIdsText;
this.inParamCategory = inParamCategory;
this.inParamTitle = inParamTitle;
this.inParamContent = inParamContent;
}
}
/// <summary>
/// Action <code>InAppNotification</code> that represents the Service Studio action
///  <code>InAppNotification</code> <p> Description: Send InApp notification </p>
/// </summary>
public static async Task ActionInAppNotification(IRequestContext requestContext,BasicTypeList<string> inParamUsers,string inParamUserIdsText,int inParamCategory,string inParamTitle,string inParamContent,CancellationToken cancellationToken) {
lcvInAppNotification localVars = new lcvInAppNotification(inParamUsers, inParamUserIdsText, inParamCategory, inParamTitle, inParamContent);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InAppNotification", "3d2ffb46-afe7-4c10-b5d7-945ae0ee2a3c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InAppNotification", "3d2ffb46-afe7-4c10-b5d7-945ae0ee2a3c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((!localVars.inParamUsers.Empty))) {
// Foreach Users
localVars.inParamUsers.StartIteration();
try {while (!((localVars.inParamUsers.Eof))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLctempusers,localVars.inParamUsers.CurrentRec,cancellationToken);

localVars.inParamUsers.Advance();
}

} finally {
localVars.inParamUsers.EndIteration();
}

} else {
// String_Split
localVars.resString_Split_outParamList = await Actions.ActionString_Split(requestContext,localVars.inParamUserIdsText,",",cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLctempusers,(await BasicTypeList<string>.ConvertAsync(localVars.resString_Split_outParamList, new BasicTypeList<string>(), async (RCTextRecord source, string target, CancellationToken cancellationToken) => {
target = source.ssSTText2.ssValue;
return target;
}, cancellationToken)),cancellationToken);

}

// NewNotification
localVars.resNewNotification_outParamResponse = await ssConectaProveedores.CcNotifications.ActionNewNotification(requestContext,new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure(){ ssuserids = localVars.varLctempusers, sstitle = localVars.inParamTitle, sscontent = localVars.inParamContent, sscategoryclass = (await Functions.ActionNotificationCategory(requestContext,localVars.inParamCategory,cancellationToken)) },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInAppNotification {



}


}
