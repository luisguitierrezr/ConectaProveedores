namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceResendFailedFile</code> that represents a client request call
///  <code>ServiceResendFailedFile</code> <p> Description: Service Resend Failed File</p>
/// </summary>
public static async Task ServiceAPIServiceResendFailedFile(IRequestContext requestContext,long inParamStorageId,CancellationToken cancellationToken) {
await RsseSpaceTelcelStorage.ServiceResendFailedFile(requestContext,inParamStorageId,cancellationToken);
return;
}

}
