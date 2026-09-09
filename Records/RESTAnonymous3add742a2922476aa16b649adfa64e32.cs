using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetOrderData_ResponseRecord
public class RESTRC_77a3e11ff871cf6d38ddae5959446c0c : AbstractRESTStructure<RC_77a3e11ff871cf6d38ddae5959446c0c> {
[JsonProperty("GetOrderData_Response")]
public ssConectaProveedores.RestRecords.RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure AttrGetOrderData_Response;

public RESTRC_77a3e11ff871cf6d38ddae5959446c0c() { }

public RESTRC_77a3e11ff871cf6d38ddae5959446c0c (RC_77a3e11ff871cf6d38ddae5959446c0c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGetOrderData_Response = ConvertToRestWithoutDefaults(s.ssSTGetOrderData_Response, new ST_77e33f0a47d2ef32eb85177e44c9b70fStructure(), ssConectaProveedores.RestRecords.RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure.FromStructure, config);
  } else {
AttrGetOrderData_Response = ssConectaProveedores.RestRecords.RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure.FromStructure(s.ssSTGetOrderData_Response, config);
  }
}

public static RC_77a3e11ff871cf6d38ddae5959446c0c ToStructure(ssConectaProveedores.RestRecords.RESTRC_77a3e11ff871cf6d38ddae5959446c0c obj) { 
  RC_77a3e11ff871cf6d38ddae5959446c0c s = new RC_77a3e11ff871cf6d38ddae5959446c0c();
  if(obj != null) {
  s.ssSTGetOrderData_Response = ssConectaProveedores.RestRecords.RESTST_77e33f0a47d2ef32eb85177e44c9b70fStructure.ToStructure(obj.AttrGetOrderData_Response);
  }
  return s;
}

public static Func<RC_77a3e11ff871cf6d38ddae5959446c0c, ssConectaProveedores.RestRecords.RESTRC_77a3e11ff871cf6d38ddae5959446c0c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_77a3e11ff871cf6d38ddae5959446c0c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_77a3e11ff871cf6d38ddae5959446c0c FromStructure(RC_77a3e11ff871cf6d38ddae5959446c0c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_77a3e11ff871cf6d38ddae5959446c0c(s, config);
}

}


