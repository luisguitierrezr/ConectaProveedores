using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TO_RESULTADO_OutRecord
public class JSONRC_55b039ad9dadaf85e6b53027c0f314fc : AbstractRESTStructure<RC_55b039ad9dadaf85e6b53027c0f314fc> {
[JsonProperty("TO_RESULTADO_Out")]
[JsonPropertyName("TO_RESULTADO_Out")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure AttrTO_RESULTADO_Out;

public JSONRC_55b039ad9dadaf85e6b53027c0f314fc() { }

public JSONRC_55b039ad9dadaf85e6b53027c0f314fc (RC_55b039ad9dadaf85e6b53027c0f314fc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTO_RESULTADO_Out = ConvertToRestWithoutDefaults(s.ssSTTO_RESULTADO_Out, new ST_1ca05235ee87feb8ff9907143d7de852Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure.FromStructure, config);
  } else {
AttrTO_RESULTADO_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure.FromStructure(s.ssSTTO_RESULTADO_Out, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_55b039ad9dadaf85e6b53027c0f314fc, RC_55b039ad9dadaf85e6b53027c0f314fc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_55b039ad9dadaf85e6b53027c0f314fc s) => ToStructure(s, config);
}
public static RC_55b039ad9dadaf85e6b53027c0f314fc ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_55b039ad9dadaf85e6b53027c0f314fc obj, IBehaviorsConfiguration config) { 
  RC_55b039ad9dadaf85e6b53027c0f314fc s = new RC_55b039ad9dadaf85e6b53027c0f314fc();
  if(obj != null) {
  s.ssSTTO_RESULTADO_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure.ToStructure(obj.AttrTO_RESULTADO_Out, config);
  }
  return s;
}

public static Func<RC_55b039ad9dadaf85e6b53027c0f314fc, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_55b039ad9dadaf85e6b53027c0f314fc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_55b039ad9dadaf85e6b53027c0f314fc s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_55b039ad9dadaf85e6b53027c0f314fc FromStructure(RC_55b039ad9dadaf85e6b53027c0f314fc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_55b039ad9dadaf85e6b53027c0f314fc(s, config);
}

}


