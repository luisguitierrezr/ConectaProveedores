using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRecord
public class JSONRC_35113aa55a750ad2c238c201c4253736 : AbstractRESTStructure<RC_35113aa55a750ad2c238c201c4253736> {
[JsonProperty("Order")]
[JsonPropertyName("Order")]
public ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure AttrOrder;

public JSONRC_35113aa55a750ad2c238c201c4253736() { }

public JSONRC_35113aa55a750ad2c238c201c4253736 (RC_35113aa55a750ad2c238c201c4253736 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrder = ConvertToRestWithoutDefaults(s.ssSTOrder, new ST_1a18ac43e89b6e5649de540bf9caa846Structure(), ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure.FromStructure, config);
  } else {
AttrOrder = ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure.FromStructure(s.ssSTOrder, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_35113aa55a750ad2c238c201c4253736, RC_35113aa55a750ad2c238c201c4253736> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_35113aa55a750ad2c238c201c4253736 s) => ToStructure(s, config);
}
public static RC_35113aa55a750ad2c238c201c4253736 ToStructure(ssConectaProveedores.RestRecords.JSONRC_35113aa55a750ad2c238c201c4253736 obj, IBehaviorsConfiguration config) { 
  RC_35113aa55a750ad2c238c201c4253736 s = new RC_35113aa55a750ad2c238c201c4253736();
  if(obj != null) {
  s.ssSTOrder = ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure.ToStructure(obj.AttrOrder, config);
  }
  return s;
}

public static Func<RC_35113aa55a750ad2c238c201c4253736, ssConectaProveedores.RestRecords.JSONRC_35113aa55a750ad2c238c201c4253736> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_35113aa55a750ad2c238c201c4253736 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_35113aa55a750ad2c238c201c4253736 FromStructure(RC_35113aa55a750ad2c238c201c4253736 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_35113aa55a750ad2c238c201c4253736(s, config);
}

}


