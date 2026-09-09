using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersToConsultRecord
public class JSONRC_d0bb3f44a292c80efaf69b83c1f1cc02 : AbstractRESTStructure<RC_d0bb3f44a292c80efaf69b83c1f1cc02> {
[JsonProperty("OrdersToConsult")]
[JsonPropertyName("OrdersToConsult")]
public ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure AttrOrdersToConsult;

public JSONRC_d0bb3f44a292c80efaf69b83c1f1cc02() { }

public JSONRC_d0bb3f44a292c80efaf69b83c1f1cc02 (RC_d0bb3f44a292c80efaf69b83c1f1cc02 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersToConsult = ConvertToRestWithoutDefaults(s.ssSTOrdersToConsult, new ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure(), ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure.FromStructure, config);
  } else {
AttrOrdersToConsult = ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure.FromStructure(s.ssSTOrdersToConsult, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d0bb3f44a292c80efaf69b83c1f1cc02, RC_d0bb3f44a292c80efaf69b83c1f1cc02> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d0bb3f44a292c80efaf69b83c1f1cc02 s) => ToStructure(s, config);
}
public static RC_d0bb3f44a292c80efaf69b83c1f1cc02 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d0bb3f44a292c80efaf69b83c1f1cc02 obj, IBehaviorsConfiguration config) { 
  RC_d0bb3f44a292c80efaf69b83c1f1cc02 s = new RC_d0bb3f44a292c80efaf69b83c1f1cc02();
  if(obj != null) {
  s.ssSTOrdersToConsult = ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure.ToStructure(obj.AttrOrdersToConsult, config);
  }
  return s;
}

public static Func<RC_d0bb3f44a292c80efaf69b83c1f1cc02, ssConectaProveedores.RestRecords.JSONRC_d0bb3f44a292c80efaf69b83c1f1cc02> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d0bb3f44a292c80efaf69b83c1f1cc02 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d0bb3f44a292c80efaf69b83c1f1cc02 FromStructure(RC_d0bb3f44a292c80efaf69b83c1f1cc02 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d0bb3f44a292c80efaf69b83c1f1cc02(s, config);
}

}


