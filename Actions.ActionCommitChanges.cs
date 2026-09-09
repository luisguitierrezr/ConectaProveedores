namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionCommitChanges</code> that represents the Service Studio reference action
///  <code>CommitChanges</code> <p> Description: Commits any changes made to a ZIP in memory. If AddFil
/// e is used, this action must be called before GetZIPBinary or GetFiles.</p>
/// </summary>
public static async Task ActionCommitChanges(IRequestContext requestContext,object inParamZIPHandle,CancellationToken cancellationToken) {
await RssExtensionZip.MssCommitChanges(requestContext,inParamZIPHandle,cancellationToken);
return;
}

}
