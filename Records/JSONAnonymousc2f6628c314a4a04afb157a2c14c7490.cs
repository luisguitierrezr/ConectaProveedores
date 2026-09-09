using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidDateStrucRecord
public class JSONRC_1658f197750f356b33a03fb0cbecd80a : AbstractRESTStructure<RC_1658f197750f356b33a03fb0cbecd80a> {
[JsonProperty("ValidDateStruc")]
[JsonPropertyName("ValidDateStruc")]
public ssConectaProveedores.RestRecords.JSONST_360c3a66fc9951d9de7870c1f87f9bf6Structure AttrValidDateStruc;

public JSONRC_1658f197750f356b33a03fb0cbecd80a() { }

public JSONRC_1658f197750f356b33a03fb0cbecd80a (RC_1658f197750f356b33a03fb0cbecd80a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValidDateStruc = ConvertToRestWithoutDefaults(s.ssSTValidDateStruc, new ST_360c3a66fc9951d9de7870c1f87f9bf6Structure(), ssConectaProveedores.RestRecords.JSONST_360c3a66fc9951d9de7870c1f87f9bf6Structure.FromStructure, config);
  } else {
AttrValidDateStruc = ssConectaProveedores.RestRecords.JSONST_360c3a66fc9951d9de7870c1f87f9bf6Structure.FromStructure(s.ssSTValidDateStruc, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1658f197750f356b33a03fb0cbecd80a, RC_1658f197750f356b33a03fb0cbecd80a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1658f197750f356b33a03fb0cbecd80a s) => ToStructure(s, config);
}
public static RC_1658f197750f356b33a03fb0cbecd80a ToStructure(ssConectaProveedores.RestRecords.JSONRC_1658f197750f356b33a03fb0cbecd80a obj, IBehaviorsConfiguration config) { 
  RC_1658f197750f356b33a03fb0cbecd80a s = new RC_1658f197750f356b33a03fb0cbecd80a();
  if(obj != null) {
  s.ssSTValidDateStruc = ssConectaProveedores.RestRecords.JSONST_360c3a66fc9951d9de7870c1f87f9bf6Structure.ToStructure(obj.AttrValidDateStruc, config);
  }
  return s;
}

public static Func<RC_1658f197750f356b33a03fb0cbecd80a, ssConectaProveedores.RestRecords.JSONRC_1658f197750f356b33a03fb0cbecd80a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1658f197750f356b33a03fb0cbecd80a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1658f197750f356b33a03fb0cbecd80a FromStructure(RC_1658f197750f356b33a03fb0cbecd80a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1658f197750f356b33a03fb0cbecd80a(s, config);
}

}


