using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_ZMXFFIMF_ACC_DOC_CHANGE_RequestRecord
public class RESTRC_5679bdbd71aac196e22130b3372a6c2b : AbstractRESTStructure<RC_5679bdbd71aac196e22130b3372a6c2b> {
[JsonProperty("BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request")]
public ssConectaProveedores.RestRecords.RESTST_0cb1a5ee06af693baf5508d00a19d139Structure AttrBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request;

public RESTRC_5679bdbd71aac196e22130b3372a6c2b() { }

public RESTRC_5679bdbd71aac196e22130b3372a6c2b (RC_5679bdbd71aac196e22130b3372a6c2b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = ConvertToRestWithoutDefaults(s.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request, new ST_0cb1a5ee06af693baf5508d00a19d139Structure(), ssConectaProveedores.RestRecords.RESTST_0cb1a5ee06af693baf5508d00a19d139Structure.FromStructure, config);
  } else {
AttrBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = ssConectaProveedores.RestRecords.RESTST_0cb1a5ee06af693baf5508d00a19d139Structure.FromStructure(s.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request, config);
  }
}

public static RC_5679bdbd71aac196e22130b3372a6c2b ToStructure(ssConectaProveedores.RestRecords.RESTRC_5679bdbd71aac196e22130b3372a6c2b obj) { 
  RC_5679bdbd71aac196e22130b3372a6c2b s = new RC_5679bdbd71aac196e22130b3372a6c2b();
  if(obj != null) {
  s.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = ssConectaProveedores.RestRecords.RESTST_0cb1a5ee06af693baf5508d00a19d139Structure.ToStructure(obj.AttrBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request);
  }
  return s;
}

public static Func<RC_5679bdbd71aac196e22130b3372a6c2b, ssConectaProveedores.RestRecords.RESTRC_5679bdbd71aac196e22130b3372a6c2b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5679bdbd71aac196e22130b3372a6c2b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5679bdbd71aac196e22130b3372a6c2b FromStructure(RC_5679bdbd71aac196e22130b3372a6c2b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5679bdbd71aac196e22130b3372a6c2b(s, config);
}

}


