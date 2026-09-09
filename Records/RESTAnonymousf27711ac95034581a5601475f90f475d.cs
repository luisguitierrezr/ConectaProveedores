using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MultiUploadInvoiceFileStructRecord
public class RESTRC_eccb78cdb64462c8ad8352ba772acab7 : AbstractRESTStructure<RC_eccb78cdb64462c8ad8352ba772acab7> {
[JsonProperty("MultiUploadInvoiceFileStruct")]
public ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure AttrMultiUploadInvoiceFileStruct;

public RESTRC_eccb78cdb64462c8ad8352ba772acab7() { }

public RESTRC_eccb78cdb64462c8ad8352ba772acab7 (RC_eccb78cdb64462c8ad8352ba772acab7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMultiUploadInvoiceFileStruct = ConvertToRestWithoutDefaults(s.ssSTMultiUploadInvoiceFileStruct, new ST_5478c3bb197e3019856d4a634c17d91dStructure(), ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure.FromStructure, config);
  } else {
AttrMultiUploadInvoiceFileStruct = ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure.FromStructure(s.ssSTMultiUploadInvoiceFileStruct, config);
  }
}

public static RC_eccb78cdb64462c8ad8352ba772acab7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_eccb78cdb64462c8ad8352ba772acab7 obj) { 
  RC_eccb78cdb64462c8ad8352ba772acab7 s = new RC_eccb78cdb64462c8ad8352ba772acab7();
  if(obj != null) {
  s.ssSTMultiUploadInvoiceFileStruct = ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure.ToStructure(obj.AttrMultiUploadInvoiceFileStruct);
  }
  return s;
}

public static Func<RC_eccb78cdb64462c8ad8352ba772acab7, ssConectaProveedores.RestRecords.RESTRC_eccb78cdb64462c8ad8352ba772acab7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eccb78cdb64462c8ad8352ba772acab7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_eccb78cdb64462c8ad8352ba772acab7 FromStructure(RC_eccb78cdb64462c8ad8352ba772acab7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_eccb78cdb64462c8ad8352ba772acab7(s, config);
}

}


