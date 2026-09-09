using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRecord
public class RESTRC_35113aa55a750ad2c238c201c4253736 : AbstractRESTStructure<RC_35113aa55a750ad2c238c201c4253736> {
[JsonProperty("Order")]
public ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure AttrOrder;

public RESTRC_35113aa55a750ad2c238c201c4253736() { }

public RESTRC_35113aa55a750ad2c238c201c4253736 (RC_35113aa55a750ad2c238c201c4253736 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrder = ConvertToRestWithoutDefaults(s.ssSTOrder, new ST_1a18ac43e89b6e5649de540bf9caa846Structure(), ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure.FromStructure, config);
  } else {
AttrOrder = ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure.FromStructure(s.ssSTOrder, config);
  }
}

public static RC_35113aa55a750ad2c238c201c4253736 ToStructure(ssConectaProveedores.RestRecords.RESTRC_35113aa55a750ad2c238c201c4253736 obj) { 
  RC_35113aa55a750ad2c238c201c4253736 s = new RC_35113aa55a750ad2c238c201c4253736();
  if(obj != null) {
  s.ssSTOrder = ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure.ToStructure(obj.AttrOrder);
  }
  return s;
}

public static Func<RC_35113aa55a750ad2c238c201c4253736, ssConectaProveedores.RestRecords.RESTRC_35113aa55a750ad2c238c201c4253736> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_35113aa55a750ad2c238c201c4253736 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_35113aa55a750ad2c238c201c4253736 FromStructure(RC_35113aa55a750ad2c238c201c4253736 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_35113aa55a750ad2c238c201c4253736(s, config);
}

}


