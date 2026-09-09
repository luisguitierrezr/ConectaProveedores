namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetFilesByStorageIdList : VarsBag {
public BasicTypeList<long> inParamStorageIdList;
public byte[] resServiceStorageGetFile_outParamo_File = new byte[] {};
public string resServiceStorageGetFile_outParamo_filename = "";

public lcvGetFilesByStorageIdList(BasicTypeList<long> inParamStorageIdList) {
this.inParamStorageIdList = inParamStorageIdList;
}
}
public class lcoGetFilesByStorageIdList : VarsBag {
public RL_a1f410d0f62252476f2a43f62445ebc5 outParamFilesList = new RL_a1f410d0f62252476f2a43f62445ebc5();

public lcoGetFilesByStorageIdList() {
}
}
/// <summary>
/// Action <code>GetFilesByStorageIdList</code> that represents the Service Studio action
///  <code>GetFilesByStorageIdList</code> <p> Description: </p>
/// </summary>
public static async Task<RL_a1f410d0f62252476f2a43f62445ebc5> ActionGetFilesByStorageIdList(IRequestContext requestContext,BasicTypeList<long> inParamStorageIdList,CancellationToken cancellationToken) {
RL_a1f410d0f62252476f2a43f62445ebc5 outParamFilesList = default;
lcoGetFilesByStorageIdList result = new lcoGetFilesByStorageIdList();
lcvGetFilesByStorageIdList localVars = new lcvGetFilesByStorageIdList(inParamStorageIdList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetFilesByStorageIdList", "f1c2af41-11ff-4658-8654-efc1e02d4221"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetFilesByStorageIdList", "f1c2af41-11ff-4658-8654-efc1e02d4221", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach StorageIdList
localVars.inParamStorageIdList.StartIteration();
try {while (!((localVars.inParamStorageIdList.Eof))) {
// ServiceStorageGetFile
(localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,localVars.inParamStorageIdList.CurrentRec,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamFilesList,new ST_a158c76eb93396680623c04244f48b6cStructure(){ ssName = localVars.resServiceStorageGetFile_outParamo_filename, ssBinaryData = localVars.resServiceStorageGetFile_outParamo_File },cancellationToken);

localVars.inParamStorageIdList.Advance();
}

} finally {
localVars.inParamStorageIdList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamFilesList = result.outParamFilesList;
} // inner-finally
RETURN_STATEMENT:
return outParamFilesList;
}

public static class FuncActionGetFilesByStorageIdList {



}


}
