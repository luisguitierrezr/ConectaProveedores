namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceGetUploadContractDateLimit</code> that represents a client
///  request call <code>ServiceGetUploadContractDateLimit</code> <p> Description: Upload Contract Dat
/// e Limit</p>
/// </summary>
public static async Task<int> ServiceAPIServiceGetUploadContractDateLimit(IRequestContext requestContext,CancellationToken cancellationToken) {
int outParamo_Value = default;
outParamo_Value = await RsseSpaceCommon.ServiceGetUploadContractDateLimit(requestContext,cancellationToken);
return outParamo_Value;
}

}
