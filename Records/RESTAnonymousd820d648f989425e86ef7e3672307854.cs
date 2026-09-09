using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM4Record
public class RESTRC_4e0e1f8a1546c166944674b06b11f045 : AbstractRESTStructure<RC_4e0e1f8a1546c166944674b06b11f045> {
[JsonProperty("PI_ITEM_EM3")]
public ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure AttrPI_ITEM_EM4;

public RESTRC_4e0e1f8a1546c166944674b06b11f045() { }

public RESTRC_4e0e1f8a1546c166944674b06b11f045 (RC_4e0e1f8a1546c166944674b06b11f045 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_EM4 = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_EM4, new ST_5f3e5a981bd9e9a45ed03e989538932dStructure(), ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure.FromStructure, config);
  } else {
AttrPI_ITEM_EM4 = ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure.FromStructure(s.ssSTPI_ITEM_EM4, config);
  }
}

public static RC_4e0e1f8a1546c166944674b06b11f045 ToStructure(ssConectaProveedores.RestRecords.RESTRC_4e0e1f8a1546c166944674b06b11f045 obj) { 
  RC_4e0e1f8a1546c166944674b06b11f045 s = new RC_4e0e1f8a1546c166944674b06b11f045();
  if(obj != null) {
  s.ssSTPI_ITEM_EM4 = ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure.ToStructure(obj.AttrPI_ITEM_EM4);
  }
  return s;
}

public static Func<RC_4e0e1f8a1546c166944674b06b11f045, ssConectaProveedores.RestRecords.RESTRC_4e0e1f8a1546c166944674b06b11f045> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4e0e1f8a1546c166944674b06b11f045 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4e0e1f8a1546c166944674b06b11f045 FromStructure(RC_4e0e1f8a1546c166944674b06b11f045 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4e0e1f8a1546c166944674b06b11f045(s, config);
}

}


