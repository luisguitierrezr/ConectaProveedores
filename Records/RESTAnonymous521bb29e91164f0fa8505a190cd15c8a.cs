using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersToConsultRecord
public class RESTRC_d0bb3f44a292c80efaf69b83c1f1cc02 : AbstractRESTStructure<RC_d0bb3f44a292c80efaf69b83c1f1cc02> {
[JsonProperty("OrdersToConsult")]
public ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure AttrOrdersToConsult;

public RESTRC_d0bb3f44a292c80efaf69b83c1f1cc02() { }

public RESTRC_d0bb3f44a292c80efaf69b83c1f1cc02 (RC_d0bb3f44a292c80efaf69b83c1f1cc02 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrdersToConsult = ConvertToRestWithoutDefaults(s.ssSTOrdersToConsult, new ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure(), ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure.FromStructure, config);
  } else {
AttrOrdersToConsult = ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure.FromStructure(s.ssSTOrdersToConsult, config);
  }
}

public static RC_d0bb3f44a292c80efaf69b83c1f1cc02 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d0bb3f44a292c80efaf69b83c1f1cc02 obj) { 
  RC_d0bb3f44a292c80efaf69b83c1f1cc02 s = new RC_d0bb3f44a292c80efaf69b83c1f1cc02();
  if(obj != null) {
  s.ssSTOrdersToConsult = ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure.ToStructure(obj.AttrOrdersToConsult);
  }
  return s;
}

public static Func<RC_d0bb3f44a292c80efaf69b83c1f1cc02, ssConectaProveedores.RestRecords.RESTRC_d0bb3f44a292c80efaf69b83c1f1cc02> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d0bb3f44a292c80efaf69b83c1f1cc02 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d0bb3f44a292c80efaf69b83c1f1cc02 FromStructure(RC_d0bb3f44a292c80efaf69b83c1f1cc02 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d0bb3f44a292c80efaf69b83c1f1cc02(s, config);
}

}


