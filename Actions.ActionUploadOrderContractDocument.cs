namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadOrderContractDocument : VarsBag {
public long inParami_OrderRequestFileId;
public RC_f6cad939346a2d641ae33c13dbcb8a70 inParami_OrderContractFile;
public long inParami_OrderMainId;
public ST_6f620840109ac6f721328b723ec0152cStructure inParami_InvoiceForeign;
public ST_1d6498da9105fbe815a7f766352917c0Structure inParami_File;
public RL_1501ee54ff868a67eff67465502ee3d9 inParami_FilesList;
public int inParamOffsetUtc;
public long resCreateOrderRequestFile_outParamId = 0L;

public Actions.lcoUploadDocumentOrderByProvider resUploadDocumentOrderByProvider =  new Actions.lcoUploadDocumentOrderByProvider();
public lcvUploadOrderContractDocument(long inParami_OrderRequestFileId, RC_f6cad939346a2d641ae33c13dbcb8a70 inParami_OrderContractFile, long inParami_OrderMainId, ST_6f620840109ac6f721328b723ec0152cStructure inParami_InvoiceForeign, ST_1d6498da9105fbe815a7f766352917c0Structure inParami_File, RL_1501ee54ff868a67eff67465502ee3d9 inParami_FilesList, int inParamOffsetUtc) {
this.inParami_OrderRequestFileId = inParami_OrderRequestFileId;
this.inParami_OrderContractFile = inParami_OrderContractFile;
this.inParami_OrderMainId = inParami_OrderMainId;
this.inParami_InvoiceForeign = inParami_InvoiceForeign;
this.inParami_File = inParami_File;
this.inParami_FilesList = inParami_FilesList;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
/// <summary>
/// Action <code>UploadOrderContractDocument</code> that represents the Service Studio action
///  <code>UploadOrderContractDocument</code> <p> Description: </p>
/// </summary>
public static async Task ActionUploadOrderContractDocument(IRequestContext requestContext,long inParami_OrderRequestFileId,RC_f6cad939346a2d641ae33c13dbcb8a70 inParami_OrderContractFile,long inParami_OrderMainId,ST_6f620840109ac6f721328b723ec0152cStructure inParami_InvoiceForeign,ST_1d6498da9105fbe815a7f766352917c0Structure inParami_File,RL_1501ee54ff868a67eff67465502ee3d9 inParami_FilesList,int inParamOffsetUtc,CancellationToken cancellationToken) {
lcvUploadOrderContractDocument localVars = new lcvUploadOrderContractDocument(inParami_OrderRequestFileId, inParami_OrderContractFile, inParami_OrderMainId, inParami_InvoiceForeign, inParami_File, inParami_FilesList, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadOrderContractDocument", "97bb63dc-1419-450c-95b6-86322207e712"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadOrderContractDocument", "97bb63dc-1419-450c-95b6-86322207e712", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParami_OrderRequestFileId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// CreateOrderRequestFile
localVars.resCreateOrderRequestFile_outParamId = await ExtendedActions.CreateOrderRequestFile(requestContext,new RC_73d8126c722e2b4dd662dab2bf1a72d1(){ ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(){ ssOrderId = localVars.inParami_OrderMainId, ssDescription = localVars.inParami_OrderContractFile.ssENContractFileType.ssLabel, ssNeedsApproval = true, ssIsFinancialFile = true, ssOrderContractFile = localVars.inParami_OrderContractFile.ssENOrderContractFile.ssId, ssNeedAccounting = false } },cancellationToken);

// i_OrderRequestFileId = CreateOrderRequestFile.Id
localVars.inParami_OrderRequestFileId=localVars.resCreateOrderRequestFile_outParamId;
}

// UploadDocumentOrderByProvider
(localVars.resUploadDocumentOrderByProvider.outParamInvoiceId,localVars.resUploadDocumentOrderByProvider.outParamStorageId) = await Actions.ActionUploadDocumentOrderByProvider(requestContext,localVars.inParami_OrderRequestFileId,localVars.inParami_OrderMainId,localVars.inParami_FilesList,((RL_1501ee54ff868a67eff67465502ee3d9)(new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure[] { new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure(){ ssName = localVars.inParami_File.ssFileName, ssBinaryData = localVars.inParami_File.ssFileContent, ssIsExtra = true } })),localVars.inParami_InvoiceForeign,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),false,localVars.inParamOffsetUtc,cancellationToken);

// Set Storage Id
// i_OrderContractFile.OrderFile.StorageId = UploadDocumentOrderByProvider.StorageId
localVars.inParami_OrderContractFile.ssENOrderFile.ssStorageId = localVars.resUploadDocumentOrderByProvider.outParamStorageId;

// i_OrderContractFile.OrderFile.Filename = i_File.FileName
localVars.inParami_OrderContractFile.ssENOrderFile.ssFilename = localVars.inParami_File.ssFileName;
// UpdateOrderFile
await ExtendedActions.UpdateOrderFile(requestContext,(await RecordUtils.ConvertAsync(localVars.inParami_OrderContractFile, new RC_a7394a353dc1b7f636aaced209e66116(), async (RC_f6cad939346a2d641ae33c13dbcb8a70 source, RC_a7394a353dc1b7f636aaced209e66116 target, CancellationToken cancellationToken) => {
target.ssENOrderFile = source.ssENOrderFile;
return target;
}, cancellationToken)).ChangedAttributes,(await RecordUtils.ConvertAsync(localVars.inParami_OrderContractFile, new RC_a7394a353dc1b7f636aaced209e66116(), async (RC_f6cad939346a2d641ae33c13dbcb8a70 source, RC_a7394a353dc1b7f636aaced209e66116 target, CancellationToken cancellationToken) => {
target.ssENOrderFile = source.ssENOrderFile;
return target;
}, cancellationToken)),cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionUploadOrderContractDocument {



}


}
