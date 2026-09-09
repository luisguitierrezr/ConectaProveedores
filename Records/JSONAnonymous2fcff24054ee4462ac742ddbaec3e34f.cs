using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDetailRecord
public class JSONRC_7f0ffeffec7d0864eb8855fe8e873743 : AbstractRESTStructure<RC_7f0ffeffec7d0864eb8855fe8e873743> {
[JsonProperty("OrderDetail")]
[JsonPropertyName("OrderDetail")]
public ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

public JSONRC_7f0ffeffec7d0864eb8855fe8e873743() { }

public JSONRC_7f0ffeffec7d0864eb8855fe8e873743 (RC_7f0ffeffec7d0864eb8855fe8e873743 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
  } else {
AttrOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7f0ffeffec7d0864eb8855fe8e873743, RC_7f0ffeffec7d0864eb8855fe8e873743> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7f0ffeffec7d0864eb8855fe8e873743 s) => ToStructure(s, config);
}
public static RC_7f0ffeffec7d0864eb8855fe8e873743 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7f0ffeffec7d0864eb8855fe8e873743 obj, IBehaviorsConfiguration config) { 
  RC_7f0ffeffec7d0864eb8855fe8e873743 s = new RC_7f0ffeffec7d0864eb8855fe8e873743();
  if(obj != null) {
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail, config);
  }
  return s;
}

public static Func<RC_7f0ffeffec7d0864eb8855fe8e873743, ssConectaProveedores.RestRecords.JSONRC_7f0ffeffec7d0864eb8855fe8e873743> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7f0ffeffec7d0864eb8855fe8e873743 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7f0ffeffec7d0864eb8855fe8e873743 FromStructure(RC_7f0ffeffec7d0864eb8855fe8e873743 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7f0ffeffec7d0864eb8855fe8e873743(s, config);
}

}


