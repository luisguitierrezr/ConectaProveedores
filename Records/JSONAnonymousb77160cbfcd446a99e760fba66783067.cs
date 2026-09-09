using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ColorRecord
public class JSONRC_87351e3b0fa2ca59cf6c6749c6405006 : AbstractRESTStructure<RC_87351e3b0fa2ca59cf6c6749c6405006> {
[JsonProperty("Color")]
[JsonPropertyName("Color")]
public ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord AttrColor;

public JSONRC_87351e3b0fa2ca59cf6c6749c6405006() { }

public JSONRC_87351e3b0fa2ca59cf6c6749c6405006 (RC_87351e3b0fa2ca59cf6c6749c6405006 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = ConvertToRestWithoutDefaults(s.ssENColor, new EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord.FromStructure, config);
  } else {
AttrColor = ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord.FromStructure(s.ssENColor, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_87351e3b0fa2ca59cf6c6749c6405006, RC_87351e3b0fa2ca59cf6c6749c6405006> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_87351e3b0fa2ca59cf6c6749c6405006 s) => ToStructure(s, config);
}
public static RC_87351e3b0fa2ca59cf6c6749c6405006 ToStructure(ssConectaProveedores.RestRecords.JSONRC_87351e3b0fa2ca59cf6c6749c6405006 obj, IBehaviorsConfiguration config) { 
  RC_87351e3b0fa2ca59cf6c6749c6405006 s = new RC_87351e3b0fa2ca59cf6c6749c6405006();
  if(obj != null) {
  s.ssENColor = ssConectaProveedores.RestRecords.JSONEN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord.ToStructure(obj.AttrColor, config);
  }
  return s;
}

public static Func<RC_87351e3b0fa2ca59cf6c6749c6405006, ssConectaProveedores.RestRecords.JSONRC_87351e3b0fa2ca59cf6c6749c6405006> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_87351e3b0fa2ca59cf6c6749c6405006 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_87351e3b0fa2ca59cf6c6749c6405006 FromStructure(RC_87351e3b0fa2ca59cf6c6749c6405006 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_87351e3b0fa2ca59cf6c6749c6405006(s, config);
}

}


