using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetOrderData_Response
public class RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure : AbstractRESTStructure<ST_77e33f0a47d2ef32eb85177e44c9b70fStructure> {
[JsonProperty("Success")]
public bool? AttrSuccess;

[JsonProperty("Message")]
public string AttrMessage;

[JsonProperty("OrderInfo_API")]
public ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure AttrOrderInfo_API;

public RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure() { }

public RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure (ST_77e33f0a47d2ef32eb85177e44c9b70fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrOrderInfo_API = ConvertToRestWithoutDefaults(s.ssOrderInfo_API, new ST_1a18ac43e89b6e5649de540bf9caa846Structure(), ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure.FromStructure, config);
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrMessage = s.ssMessage;
AttrOrderInfo_API = ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure.FromStructure(s.ssOrderInfo_API, config);
  }
}

public static ST_77e33f0a47d2ef32eb85177e44c9b70fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure obj) { 
  ST_77e33f0a47d2ef32eb85177e44c9b70fStructure s = new ST_77e33f0a47d2ef32eb85177e44c9b70fStructure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssOrderInfo_API = ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure.ToStructure(obj.AttrOrderInfo_API);
  }
  return s;
}

public static Func<ST_77e33f0a47d2ef32eb85177e44c9b70fStructure, ssConectaProveedores.RestRecords.RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_77e33f0a47d2ef32eb85177e44c9b70fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure FromStructure(ST_77e33f0a47d2ef32eb85177e44c9b70fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure(s, config);
}

}


