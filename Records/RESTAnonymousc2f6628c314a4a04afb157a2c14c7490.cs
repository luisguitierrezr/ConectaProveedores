using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidDateStrucRecord
public class RESTRC_1658f197750f356b33a03fb0cbecd80a : AbstractRESTStructure<RC_1658f197750f356b33a03fb0cbecd80a> {
[JsonProperty("ValidDateStruc")]
public ssConectaProveedores.RestRecords.RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure AttrValidDateStruc;

public RESTRC_1658f197750f356b33a03fb0cbecd80a() { }

public RESTRC_1658f197750f356b33a03fb0cbecd80a (RC_1658f197750f356b33a03fb0cbecd80a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValidDateStruc = ConvertToRestWithoutDefaults(s.ssSTValidDateStruc, new ST_360c3a66fc9951d9de7870c1f87f9bf6Structure(), ssConectaProveedores.RestRecords.RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure.FromStructure, config);
  } else {
AttrValidDateStruc = ssConectaProveedores.RestRecords.RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure.FromStructure(s.ssSTValidDateStruc, config);
  }
}

public static RC_1658f197750f356b33a03fb0cbecd80a ToStructure(ssConectaProveedores.RestRecords.RESTRC_1658f197750f356b33a03fb0cbecd80a obj) { 
  RC_1658f197750f356b33a03fb0cbecd80a s = new RC_1658f197750f356b33a03fb0cbecd80a();
  if(obj != null) {
  s.ssSTValidDateStruc = ssConectaProveedores.RestRecords.RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure.ToStructure(obj.AttrValidDateStruc);
  }
  return s;
}

public static Func<RC_1658f197750f356b33a03fb0cbecd80a, ssConectaProveedores.RestRecords.RESTRC_1658f197750f356b33a03fb0cbecd80a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1658f197750f356b33a03fb0cbecd80a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1658f197750f356b33a03fb0cbecd80a FromStructure(RC_1658f197750f356b33a03fb0cbecd80a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1658f197750f356b33a03fb0cbecd80a(s, config);
}

}


