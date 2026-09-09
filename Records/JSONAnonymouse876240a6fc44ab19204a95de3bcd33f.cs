using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrentAccountFACT_PEN_PAGStructRecord
public class JSONRC_53151840a12237c01ba8b6380f8a7866 : AbstractRESTStructure<RC_53151840a12237c01ba8b6380f8a7866> {
[JsonProperty("CurrentAccountFACT_PEN_PAGStruct")]
[JsonPropertyName("CurrentAccountFACT_PEN_PAGStruct")]
public ssConectaProveedores.RestRecords.JSONST_6e58a6c07a695cdbbb36aed76c927a26Structure AttrCurrentAccountFACT_PEN_PAGStruct;

public JSONRC_53151840a12237c01ba8b6380f8a7866() { }

public JSONRC_53151840a12237c01ba8b6380f8a7866 (RC_53151840a12237c01ba8b6380f8a7866 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrentAccountFACT_PEN_PAGStruct = ConvertToRestWithoutDefaults(s.ssSTCurrentAccountFACT_PEN_PAGStruct, new ST_6e58a6c07a695cdbbb36aed76c927a26Structure(), ssConectaProveedores.RestRecords.JSONST_6e58a6c07a695cdbbb36aed76c927a26Structure.FromStructure, config);
  } else {
AttrCurrentAccountFACT_PEN_PAGStruct = ssConectaProveedores.RestRecords.JSONST_6e58a6c07a695cdbbb36aed76c927a26Structure.FromStructure(s.ssSTCurrentAccountFACT_PEN_PAGStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_53151840a12237c01ba8b6380f8a7866, RC_53151840a12237c01ba8b6380f8a7866> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_53151840a12237c01ba8b6380f8a7866 s) => ToStructure(s, config);
}
public static RC_53151840a12237c01ba8b6380f8a7866 ToStructure(ssConectaProveedores.RestRecords.JSONRC_53151840a12237c01ba8b6380f8a7866 obj, IBehaviorsConfiguration config) { 
  RC_53151840a12237c01ba8b6380f8a7866 s = new RC_53151840a12237c01ba8b6380f8a7866();
  if(obj != null) {
  s.ssSTCurrentAccountFACT_PEN_PAGStruct = ssConectaProveedores.RestRecords.JSONST_6e58a6c07a695cdbbb36aed76c927a26Structure.ToStructure(obj.AttrCurrentAccountFACT_PEN_PAGStruct, config);
  }
  return s;
}

public static Func<RC_53151840a12237c01ba8b6380f8a7866, ssConectaProveedores.RestRecords.JSONRC_53151840a12237c01ba8b6380f8a7866> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_53151840a12237c01ba8b6380f8a7866 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_53151840a12237c01ba8b6380f8a7866 FromStructure(RC_53151840a12237c01ba8b6380f8a7866 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_53151840a12237c01ba8b6380f8a7866(s, config);
}

}


