namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceDocumentTypeCreateOrUpdate</code> that represents a client
///  request call <code>ServiceDocumentTypeCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceDocumentTypeCreateOrUpdate(IRequestContext requestContext,EN_a70d553ce1458b3952d039852f258a76EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceOrganization.ServiceDocumentTypeCreateOrUpdate(requestContext,inParamSource,cancellationToken);
return outParamId;
}

}
