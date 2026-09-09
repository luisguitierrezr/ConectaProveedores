namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionAddFile</code> that represents the Service Studio reference action
///  <code>AddFile</code> <p> Description: Adds a file to a ZIP. The Action CommitChanges must be calle
/// d after all the files are added.</p>
/// </summary>
public static async Task ActionAddFile(IRequestContext requestContext,object inParamZIPHandle,string inParamFileName,DateTime inParamDateTime,byte[] inParamFileContent,CancellationToken cancellationToken) {
await RssExtensionZip.MssAddFile(requestContext,inParamZIPHandle,inParamFileName,inParamDateTime,inParamFileContent,cancellationToken);
return;
}

}
