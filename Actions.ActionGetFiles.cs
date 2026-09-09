namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetFiles</code> that represents the Service Studio reference action
///  <code>GetFiles</code> <p> Description: Returns a list of files and directories contained in a ZI
/// P file.</p>
/// </summary>
public static async Task<RLFileRecordList> ActionGetFiles(IRequestContext requestContext,object inParamZIPHandle,CancellationToken cancellationToken) {
RLFileRecordList outParamFileList = default;
OutSystems.Application.Extensibility.DataTypes.IRecordList proxy_FileList;
proxy_FileList = await RssExtensionZip.MssGetFiles<RLFileRecordList>(requestContext,inParamZIPHandle,cancellationToken);
outParamFileList = (RLFileRecordList) proxy_FileList;
return outParamFileList;
}

}
