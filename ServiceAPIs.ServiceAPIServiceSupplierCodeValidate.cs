namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceSupplierCodeValidate</code> that represents a client request call
///  <code>ServiceSupplierCodeValidate</code> <p> Description: Supplier Code Validate</p>
/// </summary>
public static async Task<bool> ServiceAPIServiceSupplierCodeValidate(IRequestContext requestContext,string inParamUserEmail,string inParamCode,CancellationToken cancellationToken) {
bool outParamIsValid = default;
outParamIsValid = await RsseSpaceSecurityAuth.ServiceSupplierCodeValidate(requestContext,inParamUserEmail,inParamCode,cancellationToken);
return outParamIsValid;
}

}
