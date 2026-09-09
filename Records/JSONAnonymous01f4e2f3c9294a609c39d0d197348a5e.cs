using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrentAccountFAC_PAG_OutStructRecord
public class JSONRC_07279ed7569c7c3676640051323860d6 : AbstractRESTStructure<RC_07279ed7569c7c3676640051323860d6> {
[JsonProperty("CurrentAccountFAC_PAG_OutStruct")]
[JsonPropertyName("CurrentAccountFAC_PAG_OutStruct")]
public ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure AttrCurrentAccountFAC_PAG_OutStruct;

public JSONRC_07279ed7569c7c3676640051323860d6() { }

public JSONRC_07279ed7569c7c3676640051323860d6 (RC_07279ed7569c7c3676640051323860d6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrentAccountFAC_PAG_OutStruct = ConvertToRestWithoutDefaults(s.ssSTCurrentAccountFAC_PAG_OutStruct, new ST_89af93fec4915ac38f0ef9c0a1b729beStructure(), ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure.FromStructure, config);
  } else {
AttrCurrentAccountFAC_PAG_OutStruct = ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure.FromStructure(s.ssSTCurrentAccountFAC_PAG_OutStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_07279ed7569c7c3676640051323860d6, RC_07279ed7569c7c3676640051323860d6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_07279ed7569c7c3676640051323860d6 s) => ToStructure(s, config);
}
public static RC_07279ed7569c7c3676640051323860d6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_07279ed7569c7c3676640051323860d6 obj, IBehaviorsConfiguration config) { 
  RC_07279ed7569c7c3676640051323860d6 s = new RC_07279ed7569c7c3676640051323860d6();
  if(obj != null) {
  s.ssSTCurrentAccountFAC_PAG_OutStruct = ssConectaProveedores.RestRecords.JSONST_89af93fec4915ac38f0ef9c0a1b729beStructure.ToStructure(obj.AttrCurrentAccountFAC_PAG_OutStruct, config);
  }
  return s;
}

public static Func<RC_07279ed7569c7c3676640051323860d6, ssConectaProveedores.RestRecords.JSONRC_07279ed7569c7c3676640051323860d6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_07279ed7569c7c3676640051323860d6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_07279ed7569c7c3676640051323860d6 FromStructure(RC_07279ed7569c7c3676640051323860d6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_07279ed7569c7c3676640051323860d6(s, config);
}

}


