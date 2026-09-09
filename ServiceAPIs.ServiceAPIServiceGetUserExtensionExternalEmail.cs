namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceGetUserExtensionExternalEmail</code> that represents a client
///  request call <code>ServiceGetUserExtensionExternalEmail</code> <p> Description: Service action tha
/// t gets the user external email.</p>
/// </summary>
public static async Task<(string,string)> ServiceAPIServiceGetUserExtensionExternalEmail(IRequestContext requestContext,string inParami_UserEmail,CancellationToken cancellationToken) {
string outParamo_ExternalEmail = default;
string outParamo_RegionToBeAssigned = default;
(outParamo_ExternalEmail,outParamo_RegionToBeAssigned) = await RsseSpaceTelCelUsersManagement.ServiceGetUserExtensionExternalEmail(requestContext,inParami_UserEmail,cancellationToken);
return (outParamo_ExternalEmail,outParamo_RegionToBeAssigned);
}

}
