namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceStorageGetFileByParts</code> that represents a client request
///  call <code>ServiceStorageGetFileByParts</code> <p> Description: Storage Get File By Storage Id</p>
/// </summary>
public static async Task<(byte[],string,string,bool)> ServiceAPIServiceStorageGetFileByParts(IRequestContext requestContext,long inParami_StorageId,int inParami_ChunkNumber,int inParami_TotalChunks,string inParami_Guid,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
string outParamo_filename = default;
string outParamo_fileInText = default;
bool outParamIsBinary = default;
(outParamo_File,outParamo_filename,outParamo_fileInText,outParamIsBinary) = await RsseSpaceTelcelStorage.ServiceStorageGetFileByParts(requestContext,inParami_StorageId,inParami_ChunkNumber,inParami_TotalChunks,inParami_Guid,cancellationToken);
return (outParamo_File,outParamo_filename,outParamo_fileInText,outParamIsBinary);
}

}
