using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// BAPI_ZMXFFIMF_ACC_DOC_CHANGE_RequestRecord
public class JSONRC_5679bdbd71aac196e22130b3372a6c2b : AbstractRESTStructure<RC_5679bdbd71aac196e22130b3372a6c2b> {
[JsonProperty("BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request")]
[JsonPropertyName("BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure AttrBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request;

public JSONRC_5679bdbd71aac196e22130b3372a6c2b() { }

public JSONRC_5679bdbd71aac196e22130b3372a6c2b (RC_5679bdbd71aac196e22130b3372a6c2b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = ConvertToRestWithoutDefaults(s.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request, new ST_0cb1a5ee06af693baf5508d00a19d139Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure.FromStructure, config);
  } else {
AttrBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure.FromStructure(s.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5679bdbd71aac196e22130b3372a6c2b, RC_5679bdbd71aac196e22130b3372a6c2b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5679bdbd71aac196e22130b3372a6c2b s) => ToStructure(s, config);
}
public static RC_5679bdbd71aac196e22130b3372a6c2b ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5679bdbd71aac196e22130b3372a6c2b obj, IBehaviorsConfiguration config) { 
  RC_5679bdbd71aac196e22130b3372a6c2b s = new RC_5679bdbd71aac196e22130b3372a6c2b();
  if(obj != null) {
  s.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure.ToStructure(obj.AttrBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request, config);
  }
  return s;
}

public static Func<RC_5679bdbd71aac196e22130b3372a6c2b, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5679bdbd71aac196e22130b3372a6c2b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5679bdbd71aac196e22130b3372a6c2b s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5679bdbd71aac196e22130b3372a6c2b FromStructure(RC_5679bdbd71aac196e22130b3372a6c2b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5679bdbd71aac196e22130b3372a6c2b(s, config);
}

}


