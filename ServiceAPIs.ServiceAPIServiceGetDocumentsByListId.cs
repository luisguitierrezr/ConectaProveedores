namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceGetDocumentsByListId</code> that represents a client request call
///  <code>ServiceGetDocumentsByListId</code> <p> Description: Ger Zip of documents separated b
/// y foder</p>
/// </summary>
public static async Task<byte[]> ServiceAPIServiceGetDocumentsByListId(IRequestContext requestContext,BasicTypeList<long> inParamIdsList,CancellationToken cancellationToken) {
byte[] outParamBinaryZip = default;
outParamBinaryZip = await RsseSpaceTelcelStorage.ServiceGetDocumentsByListId(requestContext,inParamIdsList,cancellationToken);
return outParamBinaryZip;
}

}
