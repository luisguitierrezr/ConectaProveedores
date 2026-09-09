using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_EM4Record
public class JSONRC_4e0e1f8a1546c166944674b06b11f045 : AbstractRESTStructure<RC_4e0e1f8a1546c166944674b06b11f045> {
[JsonProperty("PI_ITEM_EM3")]
[JsonPropertyName("PI_ITEM_EM3")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure AttrPI_ITEM_EM4;

public JSONRC_4e0e1f8a1546c166944674b06b11f045() { }

public JSONRC_4e0e1f8a1546c166944674b06b11f045 (RC_4e0e1f8a1546c166944674b06b11f045 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_EM4 = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_EM4, new ST_5f3e5a981bd9e9a45ed03e989538932dStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure.FromStructure, config);
  } else {
AttrPI_ITEM_EM4 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure.FromStructure(s.ssSTPI_ITEM_EM4, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4e0e1f8a1546c166944674b06b11f045, RC_4e0e1f8a1546c166944674b06b11f045> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4e0e1f8a1546c166944674b06b11f045 s) => ToStructure(s, config);
}
public static RC_4e0e1f8a1546c166944674b06b11f045 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4e0e1f8a1546c166944674b06b11f045 obj, IBehaviorsConfiguration config) { 
  RC_4e0e1f8a1546c166944674b06b11f045 s = new RC_4e0e1f8a1546c166944674b06b11f045();
  if(obj != null) {
  s.ssSTPI_ITEM_EM4 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure.ToStructure(obj.AttrPI_ITEM_EM4, config);
  }
  return s;
}

public static Func<RC_4e0e1f8a1546c166944674b06b11f045, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4e0e1f8a1546c166944674b06b11f045> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4e0e1f8a1546c166944674b06b11f045 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4e0e1f8a1546c166944674b06b11f045 FromStructure(RC_4e0e1f8a1546c166944674b06b11f045 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4e0e1f8a1546c166944674b06b11f045(s, config);
}

}


