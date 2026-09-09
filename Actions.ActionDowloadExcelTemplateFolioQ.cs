namespace ssConectaProveedores;

public partial class Actions {
public class lcoDowloadExcelTemplateFolioQ : VarsBag {
public byte[] outParamo_File = new byte[] {};

public lcoDowloadExcelTemplateFolioQ() {
}
}
/// <summary>
/// Action <code>DowloadExcelTemplateFolioQ</code> that represents the Service Studio action
///  <code>DowloadExcelTemplateFolioQ</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> ActionDowloadExcelTemplateFolioQ(IRequestContext requestContext,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
lcoDowloadExcelTemplateFolioQ result = new lcoDowloadExcelTemplateFolioQ();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DowloadExcelTemplateFolioQ", "dfad02f9-1ee2-4ac3-8d54-54406d0fb77f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DowloadExcelTemplateFolioQ", "dfad02f9-1ee2-4ac3-8d54-54406d0fb77f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_File = Resources.TemplateQ.xlsx.Content
result.outParamo_File=(await RuntimePlatformUtils.GetResourceBinaryAsync(System.IO.Path.Combine("wwwroot/TemplateQ.xlsx"), System.IO.Path.Combine("hidden_resources/ConectaProveedores/TemplateQ.xlsx"), cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamo_File = result.outParamo_File;
} // inner-finally
RETURN_STATEMENT:
return outParamo_File;
}

public static class FuncActionDowloadExcelTemplateFolioQ {



}


}
