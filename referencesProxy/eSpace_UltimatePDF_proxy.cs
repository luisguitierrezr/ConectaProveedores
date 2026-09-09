// Proxy for reference eSpace with name UltimatePDF and key ir3_aBm5XUG20cxeTCQ+8w
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceUltimatePDF
/// </summary>
public partial class RsseSpaceUltimatePDF {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceUltimatePDF");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("5be86d03-32b8-4d45-b8c8-b87a417f1574");
       }
   }
public static async Task<byte[]> MssPrintToPDF(IRequestContext requestContext,string inParamURL,IRecord inParamEnvironment,CancellationToken cancellationToken) {
byte[] outParamPDF = default;
var _proxyinParamEnvironment = new ssUltimatePDF.ST_201dce7bb255178c132fec4d547942aeStructure();
_proxyinParamEnvironment.FillFromOther(inParamEnvironment);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("5be86d03-32b8-4d45-b8c8-b87a417f1574");
outParamPDF = await ssUltimatePDF.Actions.ActionPrintToPDF(requestContext,inParamURL,_proxyinParamEnvironment,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamPDF;
}


public sealed partial class ENMarginSizeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("5be86d03-32b8-4d45-b8c8-b87a417f1574");
} // ENMarginSizeEntity
    partial class ENMarginSizeEntity {
        

        public static TRecord GetRecordById<TRecord>(string id) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssUltimatePDF.ENMarginSizeEntity.GetRecordById(id));
return rec;
}


        public static TRecord GetRecordByKey<TRecord>(ObjectKey key) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssUltimatePDF.ENMarginSizeEntity.GetRecordByKey(key));
return rec;
}

    } // ENMarginSizeEntity;

public sealed partial class ENPaperSizeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("5be86d03-32b8-4d45-b8c8-b87a417f1574");
} // ENPaperSizeEntity
    partial class ENPaperSizeEntity {
        

        public static TRecord GetRecordById<TRecord>(string id) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssUltimatePDF.ENPaperSizeEntity.GetRecordById(id));
return rec;
}


        public static TRecord GetRecordByKey<TRecord>(ObjectKey key) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssUltimatePDF.ENPaperSizeEntity.GetRecordByKey(key));
return rec;
}

    } // ENPaperSizeEntity;


public class DefaultValues {
}
}
}
