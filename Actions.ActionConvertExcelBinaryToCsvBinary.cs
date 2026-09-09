namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionConvertExcelBinaryToCsvBinary</code> that represents the Service Studio
///  reference action <code>ConvertExcelBinaryToCsvBinary</code> <p> Description: Converts Excel binar
/// y data to CSV binary format.</p>
/// </summary>
public static async Task<byte[]> ActionConvertExcelBinaryToCsvBinary(IRequestContext requestContext,byte[] inParamexcelBytes,CancellationToken cancellationToken) {
byte[] outParamConvertExcelBinaryToCsvBinary = default;
outParamConvertExcelBinaryToCsvBinary = await RssExternalLibraryDataExportUtilities.MssConvertExcelBinaryToCsvBinary(requestContext,inParamexcelBytes,cancellationToken);
return outParamConvertExcelBinaryToCsvBinary;
}

}
