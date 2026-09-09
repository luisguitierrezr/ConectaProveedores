using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ScrollbarStyleRecord
public class JSONRC_3d7c5be4055c8fe2c227afc40d8dee2f : AbstractRESTStructure<RC_3d7c5be4055c8fe2c227afc40d8dee2f> {
[JsonProperty("ScrollbarStyle")]
[JsonPropertyName("ScrollbarStyle")]
public ssConectaProveedores.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord AttrScrollbarStyle;

public JSONRC_3d7c5be4055c8fe2c227afc40d8dee2f() { }

public JSONRC_3d7c5be4055c8fe2c227afc40d8dee2f (RC_3d7c5be4055c8fe2c227afc40d8dee2f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrScrollbarStyle = ConvertToRestWithoutDefaults(s.ssENScrollbarStyle, new EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord.FromStructure, config);
  } else {
AttrScrollbarStyle = ssConectaProveedores.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord.FromStructure(s.ssENScrollbarStyle, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3d7c5be4055c8fe2c227afc40d8dee2f, RC_3d7c5be4055c8fe2c227afc40d8dee2f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3d7c5be4055c8fe2c227afc40d8dee2f s) => ToStructure(s, config);
}
public static RC_3d7c5be4055c8fe2c227afc40d8dee2f ToStructure(ssConectaProveedores.RestRecords.JSONRC_3d7c5be4055c8fe2c227afc40d8dee2f obj, IBehaviorsConfiguration config) { 
  RC_3d7c5be4055c8fe2c227afc40d8dee2f s = new RC_3d7c5be4055c8fe2c227afc40d8dee2f();
  if(obj != null) {
  s.ssENScrollbarStyle = ssConectaProveedores.RestRecords.JSONEN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord.ToStructure(obj.AttrScrollbarStyle, config);
  }
  return s;
}

public static Func<RC_3d7c5be4055c8fe2c227afc40d8dee2f, ssConectaProveedores.RestRecords.JSONRC_3d7c5be4055c8fe2c227afc40d8dee2f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3d7c5be4055c8fe2c227afc40d8dee2f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3d7c5be4055c8fe2c227afc40d8dee2f FromStructure(RC_3d7c5be4055c8fe2c227afc40d8dee2f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3d7c5be4055c8fe2c227afc40d8dee2f(s, config);
}

}


