using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TO_RESULTADO_OutRecord
public class RESTRC_55b039ad9dadaf85e6b53027c0f314fc : AbstractRESTStructure<RC_55b039ad9dadaf85e6b53027c0f314fc> {
[JsonProperty("TO_RESULTADO_Out")]
public ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure AttrTO_RESULTADO_Out;

public RESTRC_55b039ad9dadaf85e6b53027c0f314fc() { }

public RESTRC_55b039ad9dadaf85e6b53027c0f314fc (RC_55b039ad9dadaf85e6b53027c0f314fc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTO_RESULTADO_Out = ConvertToRestWithoutDefaults(s.ssSTTO_RESULTADO_Out, new ST_1ca05235ee87feb8ff9907143d7de852Structure(), ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure.FromStructure, config);
  } else {
AttrTO_RESULTADO_Out = ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure.FromStructure(s.ssSTTO_RESULTADO_Out, config);
  }
}

public static RC_55b039ad9dadaf85e6b53027c0f314fc ToStructure(ssConectaProveedores.RestRecords.RESTRC_55b039ad9dadaf85e6b53027c0f314fc obj) { 
  RC_55b039ad9dadaf85e6b53027c0f314fc s = new RC_55b039ad9dadaf85e6b53027c0f314fc();
  if(obj != null) {
  s.ssSTTO_RESULTADO_Out = ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure.ToStructure(obj.AttrTO_RESULTADO_Out);
  }
  return s;
}

public static Func<RC_55b039ad9dadaf85e6b53027c0f314fc, ssConectaProveedores.RestRecords.RESTRC_55b039ad9dadaf85e6b53027c0f314fc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_55b039ad9dadaf85e6b53027c0f314fc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_55b039ad9dadaf85e6b53027c0f314fc FromStructure(RC_55b039ad9dadaf85e6b53027c0f314fc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_55b039ad9dadaf85e6b53027c0f314fc(s, config);
}

}


