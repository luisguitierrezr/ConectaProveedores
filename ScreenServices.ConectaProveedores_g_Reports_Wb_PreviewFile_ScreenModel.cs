using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel).Namespace);

    public long inParamStorageId;
public DateTime inParamForceRefresh;
public byte[] varLcl_Binary;
public string varLcl_xml;
public string varLcl_Filename;
public bool varLcl_PopupToggler;
public ConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Model varLcGetData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel() {
}



    public ConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel(long inParamStorageId, DateTime inParamForceRefresh, byte[] varLcl_Binary, string varLcl_xml, string varLcl_Filename, bool varLcl_PopupToggler, ConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Model varLcGetData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"StorageId", "ForceRefresh", "l_Binary", "l_xml", "l_Filename", "l_PopupToggler", "GetData", "ClientVars"}, new string[] {"inParamStorageId", "inParamForceRefresh", "varLcl_Binary", "varLcl_xml", "varLcl_Filename", "varLcl_PopupToggler", "varLcGetData", "clientVariables"});
this.inParamStorageId = inParamStorageId;
this.inParamForceRefresh = inParamForceRefresh;
this.varLcl_Binary = varLcl_Binary;
this.varLcl_xml = varLcl_xml;
this.varLcl_Filename = varLcl_Filename;
this.varLcl_PopupToggler = varLcl_PopupToggler;
this.varLcGetData = varLcGetData;
this.clientVariables = clientVariables;
}



    

    public class lcvGetData : VarsBag {
public string resBinaryDataToText_outParamText = "";

public byte[] resServiceStorageGetFile_outParamo_File = new byte[] {};
public string resServiceStorageGetFile_outParamo_filename = "";

public lcvGetData() {
}
}
public class lcoGetData : VarsBag {
public string outParamo_xml = "";

public string outParamo_Filename = "";

public byte[] outParamo_Binary = new byte[] {};

public lcoGetData() {
}
}
/// <summary>
/// Action <code>GetData</code> that represents the Service Studio action <code>GetData</code> <p>
///  Description: </p>
/// </summary>
public async Task<(string,string,byte[])> DataActionGetData(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamo_xml = default;
string outParamo_Filename = default;
byte[] outParamo_Binary = default;
lcoGetData result = new lcoGetData();
lcvGetData localVars = new lcvGetData();
ConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetData", "99eb93cc-bbd3-469f-af4c-e66553dc538c"))
using (activitySource.CreateScreenDataActionActivity("Wb_PreviewFile", "GetData")){
// ServiceStorageGetFile
(localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,inParamStorageId,cancellationToken);

// If_XML
if(((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resServiceStorageGetFile_outParamo_filename), ".xml", 0, false, false)!=(-1)))) {
// BinaryDataToText
localVars.resBinaryDataToText_outParamText = await Actions.ActionBinaryDataToText(requestContext,localVars.resServiceStorageGetFile_outParamo_File,"",cancellationToken);

// Set XML_Text
// o_xml = BinaryDataToText.Text
result.outParamo_xml=localVars.resBinaryDataToText_outParamText;

// o_Filename = ServiceStorageGetFile.o_filename
result.outParamo_Filename=localVars.resServiceStorageGetFile_outParamo_filename;
} else {
// Assign Locals
// o_Filename = ServiceStorageGetFile.o_filename
result.outParamo_Filename=localVars.resServiceStorageGetFile_outParamo_filename;

// o_Binary = ServiceStorageGetFile.o_File
result.outParamo_Binary=localVars.resServiceStorageGetFile_outParamo_File;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_xml = result.outParamo_xml;
outParamo_Filename = result.outParamo_Filename;
outParamo_Binary = result.outParamo_Binary;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_xml,outParamo_Filename,outParamo_Binary);
}


    public static class FuncDataActionGetData {
}


}
