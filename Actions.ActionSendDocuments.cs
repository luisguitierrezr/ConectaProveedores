namespace ssConectaProveedores;

public partial class Actions {
public class lcvSendDocuments : VarsBag {
public RL_d9f83b71a68be75785bb65af54dd24f1 inParamDocumentsRecordList;
public BasicTypeList<string> inParamUserIds;
public RL_08794d38cc3e746db7e33443c648a0fa inParamGetOrderRequestFiles_RequestFiles;
public RL_84bdfe424d1eb0223fc2b8cfa9bb96be inParamGetSupplierUsersBySupplierId_List;
public string resDocuments_for_Email_outParamText = "";

public string resDocuments_for_Notification_outParamText = "";

public string resEmails_To_Send_outParamText = "";

public lcvSendDocuments(RL_d9f83b71a68be75785bb65af54dd24f1 inParamDocumentsRecordList, BasicTypeList<string> inParamUserIds, RL_08794d38cc3e746db7e33443c648a0fa inParamGetOrderRequestFiles_RequestFiles, RL_84bdfe424d1eb0223fc2b8cfa9bb96be inParamGetSupplierUsersBySupplierId_List) {
this.inParamDocumentsRecordList = inParamDocumentsRecordList;
this.inParamUserIds = inParamUserIds;
this.inParamGetOrderRequestFiles_RequestFiles = inParamGetOrderRequestFiles_RequestFiles;
this.inParamGetSupplierUsersBySupplierId_List = inParamGetSupplierUsersBySupplierId_List;
}
}
/// <summary>
/// Action <code>SendDocuments</code> that represents the Service Studio action
///  <code>SendDocuments</code> <p> Description: </p>
/// </summary>
public static async Task ActionSendDocuments(IRequestContext requestContext,RL_d9f83b71a68be75785bb65af54dd24f1 inParamDocumentsRecordList,BasicTypeList<string> inParamUserIds,RL_08794d38cc3e746db7e33443c648a0fa inParamGetOrderRequestFiles_RequestFiles,RL_84bdfe424d1eb0223fc2b8cfa9bb96be inParamGetSupplierUsersBySupplierId_List,CancellationToken cancellationToken) {
lcvSendDocuments localVars = new lcvSendDocuments(inParamDocumentsRecordList, inParamUserIds, inParamGetOrderRequestFiles_RequestFiles, inParamGetSupplierUsersBySupplierId_List);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SendDocuments", "2904340f-f348-43a5-b2df-fd04a326ac55"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SendDocuments", "2904340f-f348-43a5-b2df-fd04a326ac55", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListAppendAllSupplierUsers
await ExtendedActions.ListAppendAll(requestContext,localVars.inParamUserIds,(await BasicTypeList<string>.ConvertAsync(localVars.inParamGetSupplierUsersBySupplierId_List, new BasicTypeList<string>(), async (RC_33e6e9ec201f65e0eb7bd5d251178def source, string target, CancellationToken cancellationToken) => {
target = source.ssENSupplierUser.ssUserId;
return target;
}, cancellationToken)),cancellationToken);

// Foreach GetOrderRequestFiles_RequestFiles
localVars.inParamGetOrderRequestFiles_RequestFiles.StartIteration();
try {while (!((localVars.inParamGetOrderRequestFiles_RequestFiles.Eof))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.inParamDocumentsRecordList,new RC_9b26d66c2c2462dead9020a39a074a2b(){ ssDocument = localVars.inParamGetOrderRequestFiles_RequestFiles.CurrentRec.ssDescription },cancellationToken);

localVars.inParamGetOrderRequestFiles_RequestFiles.Advance();
}

} finally {
localVars.inParamGetOrderRequestFiles_RequestFiles.EndIteration();
}

// Documents_for_Notification
localVars.resDocuments_for_Notification_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.inParamDocumentsRecordList, new RLTextRecordList(), async (RC_9b26d66c2c2462dead9020a39a074a2b source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = source.ssDocument;
return target;
}, cancellationToken)),", ",cancellationToken);

// Documents_for_Email
localVars.resDocuments_for_Email_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.inParamDocumentsRecordList, new RLTextRecordList(), async (RC_9b26d66c2c2462dead9020a39a074a2b source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = ("- "+source.ssDocument);
return target;
}, cancellationToken)),"\r\n",cancellationToken);

// Emails_To_Send
localVars.resEmails_To_Send_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.inParamGetSupplierUsersBySupplierId_List, new RLTextRecordList(), async (RC_33e6e9ec201f65e0eb7bd5d251178def source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = source.ssENSupplierUser.ssEmail;
return target;
}, cancellationToken)),",",cancellationToken);

// InAppNotification
await Actions.ActionInAppNotification(requestContext,localVars.inParamUserIds,"",1,("Código para "+"Conecta Proveedores"),("Estimado proveedor, debe subir los siguientes documentos de información de pago: "+localVars.resDocuments_for_Notification_outParamText),cancellationToken);

// SendRequestDocuments
await Actions.ActionSendRequestDocuments(requestContext,localVars.resEmails_To_Send_outParamText,"Conecta Proveedores",localVars.resDocuments_for_Email_outParamText,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSendDocuments {



}


}
