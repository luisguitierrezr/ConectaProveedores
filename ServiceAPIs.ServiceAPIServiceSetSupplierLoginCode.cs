namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceSetSupplierLoginCode</code> that represents a client request call
///  <code>ServiceSetSupplierLoginCode</code> <p> Description: Set Supplier Login Code</p>
/// </summary>
public static async Task<string> ServiceAPIServiceSetSupplierLoginCode(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
string outParamCode = default;
outParamCode = await RsseSpaceSecurityAuth.ServiceSetSupplierLoginCode(requestContext,inParamEmail,cancellationToken);
return outParamCode;
}

}
